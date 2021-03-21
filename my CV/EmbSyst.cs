using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_CV
{
    public partial class EmbSyst : UserControl

    {
        Ardu u7;
        FPGAsRe u8;
        public EmbSyst()
        {
            InitializeComponent();
            u7 = new Ardu();
            u8 = new FPGAsRe();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            u8.Hide();
            u7.Show();
            u7.Dock = DockStyle.Fill;
            this.Controls.Add(u7);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            u7.Hide();
            u8.Show();
            u8.Dock = DockStyle.Fill;
            this.Controls.Add(u8);
        }
    }
}
