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

    public partial class ListIllnessForm : Form
    {
        public void reload_list()
        {
            illness_list_box.Items.Clear();
            using var db = new LecarAppContext();
            var ills = db.Illnesses.ToList();
            foreach (var ill in ills)
            {
                illness_list_box.Items.Add(ill);
            }
        }
        public ListIllnessForm()
        {
            InitializeComponent();
            reload_list();
        }

        private void add_illness_btn_Click(object sender, EventArgs e)
        {
            using var db = new LecarAppContext();
            var add_form = new AddIllnessForm();
            this.Hide();
            add_form.ShowDialog();
            this.Show();
            panel_ill.Visible = false;
            reload_list();
        }

        private void illness_list_box_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (illness_list_box.SelectedItem != null)
            {
                using var db = new LecarAppContext();
                Illness ill = (Illness)illness_list_box.SelectedItem;

                panel_ill.Visible = true;
                name_text.Text = ill.Name;
                symptoms_text.Text = ill.Symptoms;
                rec_text.Text = ill.Recommendations;
                //rec_med_text.Text = ...

                var cons_list = db.Cons.Where(c => c.IdIllnes == ill.Id).ToList();
                String con_meds = "";
                foreach (var cons in cons_list)
                {
                    var med = db.Medicaments.Find(cons.IdMedicament);
                    if (med != null)
                    {
                        con_meds += med.Name + "\n";
                    }
                }
                rec_med_text.Text = con_meds;
            }

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void del_illness_btn_Click(object sender, EventArgs e)
        {
            if (illness_list_box.SelectedItem != null)
            {
                Illness ill = (Illness)illness_list_box.SelectedItem;
                using var db = new LecarAppContext();
                db.Illnesses.Remove(ill);
                panel_ill.Visible = false;
                db.SaveChanges();
                reload_list();
            }
        }

        private void edit_illness_btn_Click(object sender, EventArgs e)
        {
            if (illness_list_box.SelectedItem != null)
            {
                Illness ill = (Illness)illness_list_box.SelectedItem;

                this.Hide();
                var edit_form = new EditIllnessForm(ill);
                edit_form.ShowDialog();
                this.Show();

                int old_index = illness_list_box.SelectedIndex;
                search_text_box_TextChanged(sender, EventArgs.Empty);
                //reload_list();
                illness_list_box.SelectedIndex = old_index;
                illness_list_box_SelectedIndexChanged(sender, EventArgs.Empty);
            }
        }

        private void search_text_box_TextChanged(object sender, EventArgs e)
        {
            panel_ill.Visible = false;
            illness_list_box.ClearSelected();
            reload_list();
            var findlist = new List<Object>();
            var find = illness_list_box.FindString(search_text_box.Text);

            while (find != -1)
            {
                findlist.Add(illness_list_box.Items[find]);
                illness_list_box.Items.RemoveAt(find);
                find = illness_list_box.FindString(search_text_box.Text);
            }

            illness_list_box.Items.Clear();

            foreach (var item in findlist)
            {
                illness_list_box.Items.Add(item);
            }
        }
    }
}
