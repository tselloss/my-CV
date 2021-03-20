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
        
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
            
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
            
            hideSubMenu();
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
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
        
    }
}
