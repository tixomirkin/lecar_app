using lecar_app.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecar_app.IllnessForms
{
    public partial class EditIllnessForm : Form
    {
        int edit_id;
        public Illness edit_ill;
        public EditIllnessForm(Illness ill)
        {
            InitializeComponent();
            edit_ill = ill;

            name_text.Text = edit_ill.Name;
            symptoms_text.Text = edit_ill.Symptoms;
            rec_text.Text = edit_ill.Recommendations;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void save_illness_btn_Click(object sender, EventArgs e)
        {
            using var db = new LecarAppContext();
            edit_ill.Name = name_text.Text;
            edit_ill.Recommendations = rec_text.Text;
            edit_ill.Symptoms = symptoms_text.Text;
            db.Illnesses.Update(edit_ill);
            db.SaveChanges();
            Close();
        }
    }
}
