using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RuntimeButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        Button btn;

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

      
        private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            
            e.Control.Anchor = ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            flowLayoutPanel1.AutoScroll = false;  
            for (int i = 0; i < 100; i++)
            {   
                btn = new Button();
                btn.Click += new EventHandler(this.MultiButton_Click);
                btn.Margin = new Padding(1, 1, 1, 1);
                btn.Name = "BTN";
                btn.Text = "BTN";
                btn.Tag = Guid.NewGuid();
                btn.Left = -15;
                this.flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void MultiButton_Click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            MessageBox.Show(clicked.Tag.ToString());
        }
    }
}
