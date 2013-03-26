using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Threading;

namespace OKResizer
{
  public partial class frmMain : Form
  {
    String g_source = "";
    String g_target = "";
    String g_html_class = "";
    String g_html_prefix = "";

    List<String> g_files;
    bool g_no_crop = false;
    bool g_caption_html = false;
    bool g_rename_orig = false;
    bool g_all_as_jpeg = false;
    Int32 g_jpeg_quality = 7;
    Int32 g_max_size = 100;

    private static String[] g_supported = {
                                            "jpg", "jpeg", "bmp", "png", "tiff"
                                          };

    private String GetExt(String fn)
    {
      return fn.Substring(fn.LastIndexOf('.') + 1).ToLower();
    }

    private ImageCodecInfo GetEncoder(ImageFormat format)
    {
      ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

      foreach (ImageCodecInfo codec in codecs)
      {
        if (codec.FormatID == format.Guid)
        {
          return codec;
        }
      }
      return null;
    }

    private void SetEnabled(bool b)
    {
      cmdSource.SetEnabledTS(b);
      cmdTarget.SetEnabledTS(b);
      cmdGo.SetEnabledTS(b);
      txtSource.SetEnabledTS(b);
      txtTarget.SetEnabledTS(b);
      txtHtmlClass.SetEnabledTS(b);
      txtHtmlFilePrefix.SetEnabledTS(b);
      txtHtmlOut.SetEnabledTS(b);
      txtMax.SetEnabledTS(b);
      numJpegQuality.SetEnabledTS(b);
      chkDoNotCrop.SetEnabledTS(b);
      chkEnableCaptions.SetEnabledTS(b);
      chkRenameOriginal.SetEnabledTS(b);
      chkSaveAllJpg.SetEnabledTS(b);
    }

    public frmMain()
    {
      InitializeComponent();

      g_files = new List<String>();

      Properties.Settings.Default.PropertyChanged += (object sender, PropertyChangedEventArgs e) =>
      {
        Properties.Settings.Default.Save();
      };
    }

    private void cmdSource_Click(object sender, EventArgs e)
    {
      fbdMain.Description = "Select a source directory";
      fbdMain.ShowNewFolderButton = false;
      if (fbdMain.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      {
        txtSource.Text = fbdMain.SelectedPath;
      }
    }

    private void cmdTarget_Click(object sender, EventArgs e)
    {
      fbdMain.Description = "Select a target directory";
      fbdMain.ShowNewFolderButton = true;
      if (fbdMain.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      {
        txtTarget.Text = fbdMain.SelectedPath;
      }
    }

    private Size GetNewSize(Size imgsize)
    {
      double w = imgsize.Width;
      double h = imgsize.Height;

      if (w > h)
      {
        //landscape
        if (g_no_crop)
        {
          int m_width = g_max_size;
          float m_height = (float)((float)imgsize.Height / (float)imgsize.Width) * (float)g_max_size;

          return new Size((int)m_width, (int)m_height);
        }
        else
        {
          //cropping
          int m_height = g_max_size;
          float m_width = (float)((float)imgsize.Width / (float)imgsize.Height) * (float)g_max_size;

          return new Size((int)m_width, m_height);
        }
      }
      else if (h > w)
      {
        //portrate

        if (g_no_crop)
        {
          int m_height = g_max_size;
          float m_width = (float)((float)imgsize.Width / (float)imgsize.Height) * (float)g_max_size;

          return new Size((int)m_width, (int)m_height);
        }
        else
        {
          //cropping
          int m_width = g_max_size;
          float m_height = (float)((float)imgsize.Height / (float)imgsize.Width) * (float)g_max_size;

          return new Size(m_width, (int)m_height);
        }
      }

      return new Size(g_max_size, g_max_size);
    }

    public delegate void InitProgressCallback(Int32 t);
    private void InitProgress(Int32 t)
    {
      progMain.Value = 0;
      progMain.Maximum = t;
    }

    private void InitProgressT(Int32 t)
    {
      this.Invoke(new InitProgressCallback(this.InitProgress), new object[] { t });
    }

    public delegate void SetProgressCallback(Int32 t);
    private void SetProgress(Int32 t)
    {
      progMain.Value = t;
    }

    private void SetProgressT(Int32 t)
    {
      this.Invoke(new SetProgressCallback(this.SetProgress), new object[] { t });
    }

    private void Process()
    {
      g_files.Clear();

      g_source = txtSource.GetTextTS();
      g_target = txtTarget.GetTextTS();
      g_html_class = txtHtmlClass.GetTextTS();
      g_html_prefix = txtHtmlFilePrefix.GetTextTS();

      if (!g_html_prefix.EndsWith("/")) g_html_prefix += "/";

      g_no_crop = chkDoNotCrop.GetCheckedTS();
      g_caption_html = chkEnableCaptions.GetCheckedTS();
      g_rename_orig = chkRenameOriginal.GetCheckedTS();
      g_all_as_jpeg = chkSaveAllJpg.GetCheckedTS();
      g_jpeg_quality = Convert.ToInt32(numJpegQuality.GetValueTS());
      g_max_size = Convert.ToInt32(txtMax.GetTextTS());

      if (g_source.Trim() == "")
      {
        MessageBox.Show("Please select a source directory");
        return;
      }

      if (!Directory.Exists(g_source))
      {
        MessageBox.Show("Source directory does not exist");
        return;
      }

      SetEnabled(false);

      if (g_target.Trim() == "")
      {
        g_target = g_source + "\\output";

        txtTarget.SetTextTS(g_target);
      }

      if (!Directory.Exists(g_target))
      {
        Directory.CreateDirectory(g_target);
      }

      String[] m_files = Directory.GetFiles(g_source, "*.*", SearchOption.TopDirectoryOnly);
      foreach (String fn in m_files)
      {
        if (g_supported.Contains(GetExt(fn)))
        {
          g_files.Add(fn);
        }
      }

      progMain.SetMinTS(0);
      progMain.SetMaxTS(g_files.Count);

      Image m_img = null;
      Bitmap m_bmp = null;
      Size m_s;
      Int32 m_c = 1;
      String m_ext = "";

      ImageCodecInfo m_enc = null;
      EncoderParameters m_enc_params = null;
      EncoderParameter m_enc_param = null;

      StringBuilder m_bld = new StringBuilder();

      foreach (String file in g_files)
      {
        m_ext = GetExt(file);

        m_img = Image.FromFile(file, true);
        m_s = GetNewSize(m_img.Size);
        m_bmp = new Bitmap(m_img, m_s);

        Int32 x = g_no_crop == true ? 0 : (int)((float)(m_s.Width - g_max_size) / 2);
        Int32 y = g_no_crop == true ? 0 : (int)((float)(m_s.Height - g_max_size) / 2);
        Int32 w = g_no_crop == true ? m_s.Width : g_max_size;
        Int32 h = g_no_crop == true ? m_s.Height : g_max_size;

        Bitmap m_out = (Bitmap)m_bmp.Clone(new Rectangle(x, y, w, h), PixelFormat.Format24bppRgb);

        String m_ofile = String.Format("{0:d3}.{1}", m_c, m_ext);
        String m_file = String.Format("{0:d3}.{1}", m_c, g_all_as_jpeg == false ? m_ext : "jpg");

        if ((m_ext == "jpg" || m_ext == "jpeg") || g_all_as_jpeg)
        {
          m_enc = GetEncoder(ImageFormat.Jpeg);
          m_enc_params = new EncoderParameters(1);
          m_enc_param = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, g_jpeg_quality * 10);
          m_enc_params.Param[0] = m_enc_param;
        }
        else if (m_ext == "png")
        {
          m_enc = GetEncoder(ImageFormat.Png);
        }
        else if (m_ext == "tiff")
        {
          m_enc = GetEncoder(ImageFormat.Tiff);
        }
        else if (m_ext == "bmp")
        {
          m_enc = GetEncoder(ImageFormat.Bmp);
        }

        foreach (PropertyItem i in m_img.PropertyItems)
        {
          if (i.Id == 0x112)
          {
            int o = (int)i.Value[0];
            if (o == 6)
            {
              m_out.RotateFlip(RotateFlipType.Rotate90FlipNone);
              break;
            }
            else if (o == 8)
            {
              m_out.RotateFlip(RotateFlipType.Rotate270FlipNone);
              break;
            }
          }
        }

        m_out.Save(g_target + "\\" + m_file, m_enc, m_enc_params);

        m_out.Dispose();
        m_bmp.Dispose();
        m_img.Dispose();

        if (g_rename_orig)
        {
          File.Move(file, g_source + "\\" + m_ofile);
        }

        String m_cap_line = (g_caption_html == true ? "  <div class=\"caption\"></div>\r\n" : "");
        m_bld.AppendLine(String.Format("<div class=\"{0}\">\r\n  <a href=\"{1}{2}\" rel=\"lightbox[g]\"><img src=\"{1}thumbs/{2}\" alt=\"\"/></a>\r\n{3}</div>", g_html_class, g_html_prefix, m_file, m_cap_line));

        progMain.SetValueTS(m_c++);
      }

      txtHtmlOut.SetTextTS(m_bld.ToString());

      SetEnabled(true);
    }

    private void cmdGo_Click(object sender, EventArgs e)
    {
      Thread m_thread = new Thread(Process);
      m_thread.Start();
    }

    private void mnuFileExit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void mnuFileSelect_Click(object sender, EventArgs e)
    {
      cmdSource_Click(sender, e);
    }

    private void mnuFileCrop_Click(object sender, EventArgs e)
    {
      cmdGo_Click(sender, e);
    }

    private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (MessageBox.Show("Are you sure?", "Are you sure?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
      {
        e.Cancel = true;
      }
    }

    private void mnuAboutAbout_Click(object sender, EventArgs e)
    {
      (new frmAbout()).ShowDialog(this);
    }

    private void numJpegQuality_ValueChanged(object sender, EventArgs e)
    {

    }

  }
}
