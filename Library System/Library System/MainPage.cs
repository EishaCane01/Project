using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_System
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book newForm = new Book();
            newForm.Show();
            this.BringToFront();
            this.SendToBack();
        }

       
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBarrower newForm = new AddBarrower();
            newForm.Show();
            this.Hide();
        }

        private void updateDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpDel newForm = new UpDel();
            newForm.Show();
            this.Hide();
        }

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrow newForm = new Borrow();
            newForm.Show();
            this.Hide();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return newForm = new Return();
            newForm.Show();
            this.Hide();
        }
        
       
    }
}
