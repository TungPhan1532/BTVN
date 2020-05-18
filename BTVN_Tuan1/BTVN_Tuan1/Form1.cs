using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Tuan1
{
    public partial class Form1 : Form
    {
       
        Button b;
        //int x=0; int o=1;
        public Form1()
        {
            InitializeComponent();
            banco(10);
        }

        public void banco(int n)
        {
            for (int i = 0; i < n * 20; i += 20)
            {
                for (int j = 0; j < n * 20; j += 20)
                {
                    demo1(i, j);
                }
            }
        }
        public void demo1(int top, int left)
        {


            //but1
            Button b = new Button();
            b.Name = "b1";
            b.Text = "";
            b.Size = new Size(30, 30);
            b.Top = top;
            b.Left = left;

            this.Controls.Add(b);

            b.Click += new System.EventHandler(bt_Click);
        }



        
        private void bt_Click(object sender, EventArgs e)
        {
            //if (x == 0)
            //    x = 1;
            //else
            //    x = 0;
            
            
            Button b = sender as Button;
            //if(x==1)
            b.BackgroundImage = Image.FromFile(Application.StartupPath + "\\icon\\x.png");
            //else
                b.BackgroundImage = Image.FromFile(Application.StartupPath + "\\icon\\o.png");
             

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
