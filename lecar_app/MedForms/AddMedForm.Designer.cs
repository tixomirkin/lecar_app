﻿namespace lecar_app.MedForms
{
    partial class AddMedForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            med_counter = new NumericUpDown();
            label1 = new Label();
            ill_list_box = new ListBox();
            button2 = new Button();
            add_med_btn = new Button();
            cancel_btn = new Button();
            label5 = new Label();
            save_illness_btn = new Button();
            label3 = new Label();
            name_text = new RichTextBox();
            active_substance_text = new RichTextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)med_counter).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(med_counter);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ill_list_box);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(add_med_btn);
            panel1.Controls.Add(cancel_btn);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(save_illness_btn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(name_text);
            panel1.Controls.Add(active_substance_text);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(11, 13);
            panel1.Margin = new Padding(4, 2, 4, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(683, 764);
            panel1.TabIndex = 8;
            // 
            // med_counter
            // 
            med_counter.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            med_counter.Location = new Point(28, 386);
            med_counter.Margin = new Padding(4, 2, 4, 2);
            med_counter.Name = "med_counter";
            med_counter.Size = new Size(149, 65);
            med_counter.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(28, 343);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(393, 27);
            label1.TabIndex = 13;
            label1.Text = "Колличество лекарства на складе";
            // 
            // ill_list_box
            // 
            ill_list_box.DisplayMember = "name";
            ill_list_box.FormattingEnabled = true;
            ill_list_box.Location = new Point(28, 529);
            ill_list_box.Margin = new Padding(4, 2, 4, 2);
            ill_list_box.Name = "ill_list_box";
            ill_list_box.Size = new Size(570, 132);
            ill_list_box.TabIndex = 12;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 9F);
            button2.Location = new Point(605, 587);
            button2.Margin = new Padding(4, 2, 4, 2);
            button2.Name = "button2";
            button2.Size = new Size(56, 51);
            button2.TabIndex = 11;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            // 
            // add_med_btn
            // 
            add_med_btn.Font = new Font("Arial", 9F);
            add_med_btn.Location = new Point(605, 529);
            add_med_btn.Margin = new Padding(4, 2, 4, 2);
            add_med_btn.Name = "add_med_btn";
            add_med_btn.Size = new Size(56, 51);
            add_med_btn.TabIndex = 10;
            add_med_btn.Text = "+";
            add_med_btn.UseVisualStyleBackColor = true;
            add_med_btn.Click += add_med_btn_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.BackColor = Color.Orange;
            cancel_btn.Font = new Font("Arial", 9F);
            cancel_btn.ForeColor = SystemColors.ControlLightLight;
            cancel_btn.Location = new Point(453, 685);
            cancel_btn.Margin = new Padding(4, 2, 4, 2);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(208, 51);
            cancel_btn.TabIndex = 9;
            cancel_btn.Text = "Отмена";
            cancel_btn.UseVisualStyleBackColor = false;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(22, 484);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(284, 27);
            label5.TabIndex = 7;
            label5.Text = "Связанные заболевания";
            // 
            // save_illness_btn
            // 
            save_illness_btn.BackColor = Color.LimeGreen;
            save_illness_btn.Font = new Font("Arial", 9F);
            save_illness_btn.ForeColor = SystemColors.ControlLightLight;
            save_illness_btn.Location = new Point(238, 685);
            save_illness_btn.Margin = new Padding(4, 2, 4, 2);
            save_illness_btn.Name = "save_illness_btn";
            save_illness_btn.Size = new Size(208, 51);
            save_illness_btn.TabIndex = 4;
            save_illness_btn.Text = "Добавить";
            save_illness_btn.UseVisualStyleBackColor = false;
            save_illness_btn.Click += save_illness_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(22, 143);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(229, 27);
            label3.TabIndex = 3;
            label3.Text = "Активное вещество";
            // 
            // name_text
            // 
            name_text.BorderStyle = BorderStyle.FixedSingle;
            name_text.Font = new Font("Arial", 16.1F, FontStyle.Bold, GraphicsUnit.Point, 204);
            name_text.Location = new Point(28, 75);
            name_text.Margin = new Padding(4, 2, 4, 2);
            name_text.Name = "name_text";
            name_text.Size = new Size(635, 57);
            name_text.TabIndex = 2;
            name_text.Text = "";
            // 
            // active_substance_text
            // 
            active_substance_text.BackColor = SystemColors.ControlLightLight;
            active_substance_text.BorderStyle = BorderStyle.FixedSingle;
            active_substance_text.Font = new Font("Arial", 10.1F, FontStyle.Regular, GraphicsUnit.Point, 204);
            active_substance_text.Location = new Point(28, 186);
            active_substance_text.Margin = new Padding(4, 2, 4, 2);
            active_substance_text.Name = "active_substance_text";
            active_substance_text.Size = new Size(635, 134);
            active_substance_text.TabIndex = 1;
            active_substance_text.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(22, 36);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 27);
            label2.TabIndex = 0;
            label2.Text = "Название";
            // 
            // AddMedForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(711, 789);
            Controls.Add(panel1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "AddMedForm";
            Text = "AddMedForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)med_counter).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox ill_list_box;
        private Button button2;
        private Button add_med_btn;
        private Button cancel_btn;
        private Label label5;
        private Button save_illness_btn;
        private Label label3;
        private RichTextBox name_text;
        private RichTextBox active_substance_text;
        private Label label2;
        private NumericUpDown med_counter;
        private Label label1;
    }
}