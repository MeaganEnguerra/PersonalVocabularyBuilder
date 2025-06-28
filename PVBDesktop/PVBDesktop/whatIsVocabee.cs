using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVBDesktop
{
    public partial class whatIsVocabee : Form
    {
        Welcome welcome = new Welcome();

        public whatIsVocabee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            welcome.Show();
            this.Close();
        }
    }
}
