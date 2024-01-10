﻿namespace lecar_app.IllnessForms
{
    partial class EditIllnessForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditIllnessForm));
            panel1 = new Panel();
            rec_text = new RichTextBox();
            illness_list_box = new ListBox();
            button2 = new Button();
            add_med_btn = new Button();
            cancel_btn = new Button();
            label5 = new Label();
            save_illness_btn = new Button();
            label4 = new Label();
            label3 = new Label();
            name_text = new RichTextBox();
            symptoms_text = new RichTextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(rec_text);
            panel1.Controls.Add(illness_list_box);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(add_med_btn);
            panel1.Controls.Add(cancel_btn);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(save_illness_btn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(name_text);
            panel1.Controls.Add(symptoms_text);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(11, 13);
            panel1.Margin = new Padding(4, 2, 4, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(683, 809);
            panel1.TabIndex = 8;
            // 
            // rec_text
            // 
            rec_text.BackColor = SystemColors.ControlLightLight;
            rec_text.BorderStyle = BorderStyle.FixedSingle;
            rec_text.Font = new Font("Arial", 10.1F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rec_text.Location = new Point(28, 371);
            rec_text.Margin = new Padding(4, 2, 4, 2);
            rec_text.Name = "rec_text";
            rec_text.Size = new Size(635, 134);
            rec_text.TabIndex = 13;
            rec_text.Text = "";
            // 
            // illness_list_box
            // 
            illness_list_box.DisplayMember = "name";
            illness_list_box.FormattingEnabled = true;
            illness_list_box.Location = new Point(28, 570);
            illness_list_box.Margin = new Padding(4, 2, 4, 2);
            illness_list_box.Name = "illness_list_box";
            illness_list_box.Size = new Size(570, 132);
            illness_list_box.TabIndex = 12;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 9F);
            button2.Location = new Point(605, 627);
            button2.Margin = new Padding(4, 2, 4, 2);
            button2.Name = "button2";
            button2.Size = new Size(56, 51);
            button2.TabIndex = 11;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // add_med_btn
            // 
            add_med_btn.Font = new Font("Arial", 9F);
            add_med_btn.Location = new Point(605, 570);
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
            cancel_btn.Location = new Point(453, 725);
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
            label5.Location = new Point(22, 527);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(315, 27);
            label5.TabIndex = 7;
            label5.Text = "Рекомендуемые лекарства";
            // 
            // save_illness_btn
            // 
            save_illness_btn.BackColor = Color.LimeGreen;
            save_illness_btn.Font = new Font("Arial", 9F);
            save_illness_btn.ForeColor = SystemColors.ControlLightLight;
            save_illness_btn.Location = new Point(238, 725);
            save_illness_btn.Margin = new Padding(4, 2, 4, 2);
            save_illness_btn.Name = "save_illness_btn";
            save_illness_btn.Size = new Size(208, 51);
            save_illness_btn.TabIndex = 4;
            save_illness_btn.Text = "Сохранить";
            save_illness_btn.UseVisualStyleBackColor = false;
            save_illness_btn.Click += save_illness_btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(22, 337);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(323, 27);
            label4.TabIndex = 5;
            label4.Text = "Рекомендуемые процедуры";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(22, 143);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(130, 27);
            label3.TabIndex = 3;
            label3.Text = "Симптомы";
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
            // symptoms_text
            // 
            symptoms_text.BackColor = SystemColors.ControlLightLight;
            symptoms_text.BorderStyle = BorderStyle.FixedSingle;
            symptoms_text.Font = new Font("Arial", 10.1F, FontStyle.Regular, GraphicsUnit.Point, 204);
            symptoms_text.Location = new Point(28, 186);
            symptoms_text.Margin = new Padding(4, 2, 4, 2);
            symptoms_text.Name = "symptoms_text";
            symptoms_text.Size = new Size(635, 134);
            symptoms_text.TabIndex = 1;
            symptoms_text.Text = "";
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
            // EditIllnessForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 832);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 2, 4, 2);
            Name = "EditIllnessForm";
            Text = "Редактирование заболевания";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox illness_list_box;
        private Button button2;
        private Button add_med_btn;
        private Button cancel_btn;
        private Label label5;
        private Button save_illness_btn;
        private Label label4;
        private Label label3;
        private RichTextBox name_text;
        private RichTextBox symptoms_text;
        private Label label2;
        private RichTextBox rec_text;
    }
}