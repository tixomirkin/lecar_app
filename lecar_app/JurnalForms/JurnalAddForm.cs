using lecar_app.database;
using lecar_app.IllnessForms;
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

namespace lecar_app.JurnalForms
{
    public partial class JurnalAddForm : Form
    {
        public JurnalAddForm()
        {
            InitializeComponent();
        }

        private void add_ill_btn_Click(object sender, EventArgs e)
        {
            var select_ill_form = new AddConMed();
            var ill = select_ill_form.get_ill();

            ill_text.Text = ill.Name;
            rect_text.Text = "Курс лечения ...\n\n" +
                "Рекомендуемые процедуры:\n" +
                ill.Recommendations +
                "\n\nНазначенные лекарства:";

            med_list.Items.Clear();
            using var db = new LecarAppContext();
            var cons_list = db.Cons.Where(c => c.IdIllnes == ill.Id).ToList();
            if (cons_list.Count != 0)
            {
                med_list.Visible = true;
                foreach (var cons in cons_list)
                {
                    var med = db.Medicaments.Find(cons.IdMedicament);
                    if (med != null)
                    {
                        med_list.Items.Add(med.Name);
                    }
                }
            }
            else
            {
                med_list.Visible = false;
            }

        }

        private void med_list_Click(object sender, EventArgs e)
        {
            if (med_list.SelectedItem != null)
            {
                rect_text.Text += "\n" + med_list.SelectedItem.ToString() + " - (колличество) / (переодичность)";
            }
        }
    }
}
