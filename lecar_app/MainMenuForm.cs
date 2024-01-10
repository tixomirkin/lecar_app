using lecar_app.IllnessForms;
using lecar_app.JurnalForms;
using lecar_app.MedForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecar_app
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var listillnessform = new ListIllnessForm();
            listillnessform.ShowDialog();
            this.Show();
        }

        private void med_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var listmedform = new MedListForms();
            listmedform.ShowDialog();
            this.Show();
        }

        private void add_jurnal_btn_Click(object sender, EventArgs e)
        {
            var jurnal_form = new JurnalAddForm();
            jurnal_form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var aform = new aboutFormcs();
            aform.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var jurnal_form = new JurnalForm();
            jurnal_form.ShowDialog();
        }
    }
}
