using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Computer_Cleaner
{
    public partial class termsScreen : MaterialSkin.Controls.MaterialForm
    {
        public static bool AcceptTerm = false;
        public bool open = false;

        public termsScreen()
        {
            InitializeComponent();
        }

        private void termsScreen_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            AcceptTerm = true;
            this.Close();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            AcceptTerm = false;
            this.Close();
        }
    }
}
