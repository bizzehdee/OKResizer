/*
 * Copyright (c) 2013, Darren Horrocks
 * All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without modification, 
 * are permitted provided that the following conditions are met:
 * 
 * Redistributions of source code must retain the above copyright notice, this list 
 * of conditions and the following disclaimer.
 * Redistributions in binary form must reproduce the above copyright notice, this 
 * list of conditions and the following disclaimer in the documentation and/or 
 * other materials provided with the distribution.
 * Neither the name of Darren Horrocks/www.bizzeh.com nor the names of its 
 * contributors may be used to endorse or promote products derived from this software 
 * without specific prior written permission.
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY 
 * EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES 
 * OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT 
 * SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
 * INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO,
 * PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
 * INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, 
 * STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF 
 * THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace System.Windows.Forms
{
  public static class TSFormExtenders
  {
    #region Control
    public static void SetEnabledTS(this Control x, bool s)
    {
      if (x.InvokeRequired)
      {
        x.Invoke(new EventHandler(delegate(object o, EventArgs a)
        {
          x.SetEnabledTS(s);
        }));
      }
      else
      {
        x.Enabled = s;
      }
    }

    public static bool GetEnabledTS(this Control x, bool def = false)
    {
      if (x.InvokeRequired)
      {
        bool m_ret = def;
        x.Invoke(new EventHandler(delegate(object o, EventArgs a)
        {
          m_ret = x.GetEnabledTS();
        }));
        return m_ret;
      }
      else
      {
        return x.Enabled;
      }
    }

    public static void SetTextTS(this Control x, String s)
    {
      if (x.InvokeRequired)
      {
        x.Invoke(new EventHandler(delegate(object o, EventArgs a)
        {
          x.SetTextTS(s);
        }));
      }
      else
      {
        x.Text = s;
      }
    }

    public static String GetTextTS(this Control x, String def = "")
    {
      if (x.InvokeRequired)
      {
        String m_ret = def;
        x.Invoke(new EventHandler(delegate(object o, EventArgs a)
        {
          m_ret = x.GetTextTS();
        }));
        return m_ret;
      }
      else
      {
        return x.Text;
      }
    }

    public static void SetVisibleTS(this Control x, bool s)
    {
      if (x.InvokeRequired)
      {
        x.Invoke(new EventHandler(delegate(object o, EventArgs a)
        {
          x.SetVisibleTS(s);
        }));
      }
      else
      {
        x.Visible = s;
      }
    }

    public static bool GetVisibleTS(this Control x, bool def = true)
    {
      if (x.InvokeRequired)
      {
        bool m_ret = def;
        x.Invoke(new EventHandler(delegate(object o, EventArgs a)
        {
          m_ret = x.GetVisibleTS();
        }));
        return m_ret;
      }
      else
      {
        return x.Visible;
      }
    }

    public static void SetSizeTS(this Control x, Size s)
    {
      if (x.InvokeRequired)
      {
        x.Invoke(new EventHandler(delegate(object o, EventArgs a)
        {
          x.SetSizeTS(s);
        }));
      }
      else
      {
        x.Size = s;
      }
    }

    public static Size GetSizeTS(this Control x)
    {
      if (x.InvokeRequired)
      {
        Size m_ret = new Size();
        x.Invoke(new EventHandler(delegate(object o, EventArgs a)
        {
          m_ret = x.GetSizeTS();
        }));
        return m_ret;
      }
      else
      {
        return x.Size;
      }
    }
    #endregion

    #region CheckBox
    public static void SetCheckedTS(this CheckBox x, bool s)
    {
      if (x.InvokeRequired)
      {
        x.Invoke(new EventHandler(delegate(object o, EventArgs a)
        {
          x.SetCheckedTS(s);
        }));
      }
      else
      {
        x.Checked = s;
      }
    }

    public static bool GetCheckedTS(this CheckBox x)
    {
      if (x.InvokeRequired)
      {
        bool m_ret = false;
        x.Invoke(new EventHandler(delegate(object o, EventArgs a)
        {
          m_ret = x.GetCheckedTS();
        }));
        return m_ret;
      }
      else
      {
        return x.Checked;
      }
    }
    #endregion

    #region NumericUpDown
    public static void SetValueTS(this NumericUpDown x, Decimal s)
    {
      if (x.InvokeRequired)
      {
        x.Invoke(new EventHandler(delegate(object o, EventArgs a)
        {
          x.SetValueTS(s);
        }));
      }
      else
      {
        x.Value = s;
      }
    }

    public static Decimal GetValueTS(this NumericUpDown x)
    {
      if (x.InvokeRequired)
      {
        Decimal m_ret = 0;
        x.Invoke(new EventHandler(delegate(object o, EventArgs a)
        {
          m_ret = x.GetValueTS();
        }));
        return m_ret;
      }
      else
      {
        return x.Value;
      }
    }

    public static void SetMinTS(this NumericUpDown x, Decimal s)
    {
      if (x.InvokeRequired)
      {
        x.Invoke(new EventHandler(delegate(object o, EventArgs a)
        {
          x.SetMinTS(s);
        }));
      }
      else
      {
        x.Minimum = s;
      }
    }

    public static void SetMaxTS(this NumericUpDown x, Decimal s)
    {
      if (x.InvokeRequired)
      {
        x.Invoke(new EventHandler(delegate(object o, EventArgs a)
        {
          x.SetMaxTS(s);
        }));
      }
      else
      {
        x.Maximum = s;
      }
    }
    #endregion

    #region ProgressBar
    public static void SetValueTS(this ProgressBar x, Int32 s)
    {
      if (x.InvokeRequired)
      {
        x.Invoke(new EventHandler(delegate(object o, EventArgs a)
        {
          x.SetValueTS(s);
        }));
      }
      else
      {
        x.Value = s;
      }
    }

    public static Int32 GetValueTS(this ProgressBar x)
    {
      if (x.InvokeRequired)
      {
        Int32 m_ret = 0;
        x.Invoke(new EventHandler(delegate(object o, EventArgs a)
        {
          m_ret = x.GetValueTS();
        }));
        return m_ret;
      }
      else
      {
        return x.Value;
      }
    }

    public static void SetMinTS(this ProgressBar x, Int32 s)
    {
      if (x.InvokeRequired)
      {
        x.Invoke(new EventHandler(delegate(object o, EventArgs a)
        {
          x.SetMinTS(s);
        }));
      }
      else
      {
        x.Minimum = s;
      }
    }

    public static void SetMaxTS(this ProgressBar x, Int32 s)
    {
      if (x.InvokeRequired)
      {
        x.Invoke(new EventHandler(delegate(object o, EventArgs a)
        {
          x.SetMaxTS(s);
        }));
      }
      else
      {
        x.Maximum = s;
      }
    }
    #endregion

    #region ListView
    public static void AddItemTS(this ListView x, ListViewItem s)
    {
      if (x.InvokeRequired)
      {
        x.Invoke(new EventHandler(delegate(object o, EventArgs a)
        {
          x.AddItemTS(s);
        }));
      }
      else
      {
        x.Items.Add(s);
      }
    }

    public static void AddItemTS(this ListViewItem x, System.Windows.Forms.ListViewItem.ListViewSubItem s)
    {
      if (x.ListView.InvokeRequired)
      {
        x.ListView.Invoke(new EventHandler(delegate(object o, EventArgs a)
        {
          x.AddItemTS(s);
        }));
      }
      else
      {
        x.SubItems.Add(s);
      }
    }
    #endregion
  }
}
