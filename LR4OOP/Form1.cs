using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR4OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void MouseHover(object sender, EventArgs e)
        {
            panel1.Controls.Remove((Control)sender);
        }
        private void Panel1_MouseClick(Object sender, MouseEventArgs e)
        {
            int size = 500;
            Random rnd = new Random();
            for (int i = 0; i < rnd.Next(3); i++) { 
                Button b = new Button();
                b.Width = 80;
                b.Height = 20;
                b.Location = new Point(rnd.Next(size), rnd.Next(size));
                b.Text = "Кнопка";
                
                b.MouseEnter += new System.EventHandler(this.MouseHover);
                panel1.Controls.Add(b);
                TextBox t = new TextBox();
                t.Width = 80;
                t.Height = 20;
                t.Location = new Point(rnd.Next(size), rnd.Next(size));
                t.Text = "Поле";
                
                t.MouseEnter += new System.EventHandler(this.MouseHover);
                panel1.Controls.Add(t);
            }
        }
    }
}
