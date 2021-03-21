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
    public partial class Form1 : Form
    {
        ContactCD u1;
        OtherCD u2;
        WorkexpCD u3;
        EduCD u4;
        Home u5;
        EmbSyst u6;
        CodingL u9;
        LangCD u10;
        ExtrasCD u11;
        public Form1()
        {
            u1 = new ContactCD();
            u2 = new OtherCD();
            u3 = new WorkexpCD();
            u4 = new EduCD();
            u5 = new Home();
            u6 = new EmbSyst();
            u9 = new CodingL();
            u10 = new LangCD();
            u11 = new ExtrasCD();
            InitializeComponent();
            customizeDesing();
            u5.Show();
            u5.Dock = DockStyle.Fill;
            this.Controls.Add(u5);

        }
        private void customizeDesing()
        {
            panelPersonal.Visible = false;
            panelSkills.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelPersonal.Visible == true)
                panelPersonal.Visible = false;
            if (panelSkills.Visible == true)
                panelSkills.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;

            }
            else
                subMenu.Visible = false;
        }
        private void btnPersonal_Click_1(object sender, EventArgs e)
        {

            showSubMenu(panelPersonal);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            u1.Hide();
            u2.Hide();   
            u3.Hide();
            u5.Hide();
            u9.Hide();
            u6.Hide();
            u10.Hide();
            u11.Hide();
            u4.Show();
            u4.Dock = DockStyle.Fill;
            this.Controls.Add(u4);
            hideSubMenu();
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            u1.Hide();
            u2.Hide();
            u9.Hide();
            u10.Hide();
            u11.Hide();
            u4.Hide();
            u6.Hide();
            u5.Hide();
            u3.Show();
            u3.Dock = DockStyle.Fill;
            this.Controls.Add(u3);
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            u1.Hide();
            u4.Hide();
            u9.Hide();
            u6.Hide();
            u10.Hide();
            u11.Hide();
            u5.Hide();
            u3.Hide();
            u2.Show();
            u2.Dock = DockStyle.Fill;
            this.Controls.Add(u2);
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            u1.Hide();
            u4.Hide();
            u2.Hide();
            u6.Hide();
            u10.Hide();
            u11.Hide();
            u5.Hide();
            u3.Hide();
            u9.Show();
            u9.Dock = DockStyle.Fill;
            this.Controls.Add(u9);
            hideSubMenu();
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            u1.Hide();
            u4.Hide();
            u2.Hide();
            u10.Hide();
            u11.Hide();
            u9.Hide();
            u5.Hide();
            u3.Hide();
            u6.Show();
            u6.Dock = DockStyle.Fill;
            this.Controls.Add(u6);
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            u1.Hide();
            u4.Hide();
            u2.Hide();
            u10.Hide();
            u6.Hide();
            u9.Hide();
            u5.Hide();
            u3.Hide();
            u11.Show();
            u11.Dock = DockStyle.Fill;
            this.Controls.Add(u11);
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            u1.Hide();
            u4.Hide();
            u2.Hide();
            u11.Hide();
            u6.Hide();
            u9.Hide();
            u5.Hide();
            u3.Hide();
            u10.Show();
            u10.Dock = DockStyle.Fill;
            this.Controls.Add(u10);
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPersonal);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSkills);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
       

        private void button13_Click(object sender, EventArgs e)
        {
            var uri = "https://github.com/tselloss";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            u4.Hide();
            u2.Hide();
            u9.Hide();
            u10.Hide();
            u11.Hide();
            u6.Hide();
            u5.Hide();
            u3.Hide();
            u1.Show();
            u1.Dock = DockStyle.Fill;
            this.Controls.Add(u1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            u1.Hide();
            u4.Hide();
            u2.Hide();
            u6.Hide();
            u10.Hide();
            u11.Hide();
            u9.Hide();
            u3.Hide();
            u4.Hide();
            u5.Show();
            u5.Dock = DockStyle.Fill;
            this.Controls.Add(u5);
        }
    }
}
