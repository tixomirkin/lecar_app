﻿using lecar_app.database;
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
    public partial class AddIllnessForm : Form
    {
        public AddIllnessForm()
        {
            InitializeComponent();
        }

        private void add_med_btn_Click(object sender, EventArgs e)
        {
            var add_con_form = new AddConIllness();
            add_con_form.ShowDialog();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_illness_btn_Click(object sender, EventArgs e)
        {
            using var db = new LecarAppContext();
            
            Illness new_ill = new Illness();
            new_ill.Name = name_text.Text;
            new_ill.Symptoms = symptoms_text.Text;
            new_ill.Recommendations = rec_text.Text;

            db.Illnesses.Add(new_ill);
            db.SaveChanges();

            this.Close();
        }
    }
}
