using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPiR
{
    public partial class FormDate : Form
    {
        private TextBox dategetter;
        private Form main;
        public FormDate(TextBox dategetter, Form main)
        {
            main.Enabled = false;
            this.main = main;
            InitializeComponent();
            this.dategetter = dategetter;
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            dategetter.Text = monthCalendar1.SelectionStart.ToShortDateString();
            this.Close();
        }

        private void FormDate_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.Enabled = true;
        }
    }
}
