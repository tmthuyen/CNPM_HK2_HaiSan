using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Usercontrol
{
    public partial class PromotionControl : UserControl
    {
        public PromotionControl()
        {
            InitializeComponent();
        }
        public virtual bool ValidateInput()
        {
            throw new NotImplementedException("ValidateInput must be implemented by derived classes.");
        }
    }
}
