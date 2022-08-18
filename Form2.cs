using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form2 : Form
    {

        Database db = new Database();

        public Form2()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.LogWindow;

            UpdateLogBtn.Image = Properties.Resources.UpdateLogBtn;

            db.Get();
            this.LogTxt.Text = db.LogS;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void DeleteLogBtn_Click(object sender, EventArgs e)
        {
            this.LogTxt.Text = "";
            db.LogS = "";
            db.Get();
            this.LogTxt.Text = db.LogS;
        }
    }
}
