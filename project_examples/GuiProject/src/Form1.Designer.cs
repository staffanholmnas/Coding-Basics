using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace GuiProject
{
    partial class Form1
    {
        private IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.components = new Container();
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 600);
            this.Text = "Staffans App";
            this.MinimumSize = new Size(800, 400);
            this.MaximumSize = new Size(800, 1000);
            this.MaximizeBox = false;
            this.CenterToScreen();

            this.textBox1 = new TextBox();
            this.textBox1.Size = new Size(150, 600);
            this.textBox1.ReadOnly = true;
            this.textBox1.Location = new Point((this.Width - this.textBox1.Width) / 2, (this.Height - this.textBox1.Height) / 2);
            this.Controls.Add(this.textBox1);

            this.button1 = new Button();
            this.button1.DialogResult = DialogResult.OK;
            this.button1.Location = new Point((this.Width - this.textBox1.Width) / 2, 150);
            this.button1.Height = 40;
            this.button1.Width = 150;
            this.button1.Text = "Click here!";
            this.button1.Name = "button1";
            this.button1.Font = new Font("Helvetica", 16);
            this.button1.BackColor = Color.LightSkyBlue;
            this.button1.ForeColor = Color.Black;
            this.button1.Click += new EventHandler(ShowMessage);
            Controls.Add(button1);

            this.button2 = new Button();
            this.button2.DialogResult = DialogResult.OK;
            this.button2.Location = new Point((this.Width - this.textBox1.Width) / 2, this.button1.Height + 150);
            this.button2.Height = 40;
            this.button2.Width = 150;
            this.button2.Text = "No, click me!";
            this.button2.Name = "button2";
            this.button2.Font = new Font("Helvetica", 16);
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = AutoSizeMode.GrowOnly;
            this.button2.BackColor = Color.PaleTurquoise;
            this.button2.ForeColor = Color.Black;
            this.button2.Click += new EventHandler(ShowMessage);
            Controls.Add(button2);
        }
        private void ShowMessage(object sender, EventArgs e)
        {
            string buttonName = (sender as Button).Text;
            if (buttonName == "Click here!")
            {
                this.textBox1.Text = "Button Clicked!";
            }
            else
            {
                this.textBox1.Text = "Other Button Clicked!";
            }
        }
    }
}

