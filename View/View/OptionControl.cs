using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class OptionControl : UserControl
    {
        public OptionControl()
        {
            InitializeComponent();
        }

        public int GetSelectedHeight()
        {
            object sender = GetSelectRadioHeight();
            int selected = -1;
            if (sender != null)
            {
                if (sender == rbHigh)
                {
                    selected = HIGH;
                }
                else if(sender == rbMid)
                {
                    selected = MID;
                }
                else
                {
                    selected = LOW;
                }
            }

            return selected;



        }

        private object GetSelectRadioHeight()
        {
            object sender = null;
            foreach (RadioButton rb in gbHeight.Controls)
            {
                if (rb.Checked)
                {
                    sender = rb;
                    break;
                }
            }

            return sender;
        }
    }
}
