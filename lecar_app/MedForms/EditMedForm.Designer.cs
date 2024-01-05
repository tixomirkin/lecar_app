namespace lecar_app.MedForms
{
    partial class EditMedForm
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
            illness_list_box = new ListBox();
            button2 = new Button();
            add_med_btn = new Button();
            cancel_btn = new Button();
            label5 = new Label();
            save_illness_btn = new Button();
            label4 = new Label();
            rec_text = new RichTextBox();
            label3 = new Label();
            name_text = new RichTextBox();
            symptoms_text = new RichTextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(illness_list_box);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(add_med_btn);
            panel1.Controls.Add(cancel_btn);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(save_illness_btn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(rec_text);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(name_text);
            panel1.Controls.Add(symptoms_text);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(683, 808);
            panel1.TabIndex = 8;
            // 
            // illness_list_box
            // 
            illness_list_box.FormattingEnabled = true;
            illness_list_box.Location = new Point(27, 570);
            illness_list_box.Margin = new Padding(4, 3, 4, 3);
            illness_list_box.Name = "illness_list_box";
            illness_list_box.Size = new Size(571, 132);
            illness_list_box.TabIndex = 12;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 9F);
            button2.Location = new Point(606, 628);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(56, 52);
            button2.TabIndex = 11;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            // 
            // add_med_btn
            // 
            add_med_btn.Font = new Font("Arial", 9F);
            add_med_btn.Location = new Point(606, 570);
            add_med_btn.Margin = new Padding(4, 3, 4, 3);
            add_med_btn.Name = "add_med_btn";
            add_med_btn.Size = new Size(56, 52);
            add_med_btn.TabIndex = 10;
            add_med_btn.Text = "+";
            add_med_btn.UseVisualStyleBackColor = true;
            // 
            // cancel_btn
            // 
            cancel_btn.Font = new Font("Arial", 9F);
            cancel_btn.Location = new Point(454, 726);
            cancel_btn.Margin = new Padding(4, 3, 4, 3);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(208, 52);
            cancel_btn.TabIndex = 9;
            cancel_btn.Text = "Отмена";
            cancel_btn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(22, 527);
            label5.Name = "label5";
            label5.Size = new Size(315, 27);
            label5.TabIndex = 7;
            label5.Text = "Рекомендуемые лекарства";
            // 
            // save_illness_btn
            // 
            save_illness_btn.Font = new Font("Arial", 9F);
            save_illness_btn.Location = new Point(238, 726);
            save_illness_btn.Margin = new Padding(4, 3, 4, 3);
            save_illness_btn.Name = "save_illness_btn";
            save_illness_btn.Size = new Size(208, 52);
            save_illness_btn.TabIndex = 4;
            save_illness_btn.Text = "Сохранить";
            save_illness_btn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(22, 338);
            label4.Name = "label4";
            label4.Size = new Size(323, 27);
            label4.TabIndex = 5;
            label4.Text = "Рекомендуемые процедуры";
            // 
            // rec_text
            // 
            rec_text.BackColor = Color.FromArgb(192, 255, 192);
            rec_text.BorderStyle = BorderStyle.FixedSingle;
            rec_text.Font = new Font("Arial", 10.1F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rec_text.Location = new Point(27, 381);
            rec_text.Name = "rec_text";
            rec_text.Size = new Size(635, 134);
            rec_text.TabIndex = 4;
            rec_text.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(22, 143);
            label3.Name = "label3";
            label3.Size = new Size(130, 27);
            label3.TabIndex = 3;
            label3.Text = "Симптомы";
            // 
            // name_text
            // 
            name_text.BorderStyle = BorderStyle.FixedSingle;
            name_text.Font = new Font("Arial", 16.1F, FontStyle.Bold, GraphicsUnit.Point, 204);
            name_text.Location = new Point(27, 75);
            name_text.Name = "name_text";
            name_text.Size = new Size(635, 58);
            name_text.TabIndex = 2;
            name_text.Text = "";
            // 
            // symptoms_text
            // 
            symptoms_text.BackColor = Color.FromArgb(192, 255, 192);
            symptoms_text.BorderStyle = BorderStyle.FixedSingle;
            symptoms_text.Font = new Font("Arial", 10.1F, FontStyle.Regular, GraphicsUnit.Point, 204);
            symptoms_text.Location = new Point(27, 186);
            symptoms_text.Name = "symptoms_text";
            symptoms_text.Size = new Size(635, 135);
            symptoms_text.TabIndex = 1;
            symptoms_text.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(22, 36);
            label2.Name = "label2";
            label2.Size = new Size(118, 27);
            label2.TabIndex = 0;
            label2.Text = "Название";
            // 
            // EditMedForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 833);
            Controls.Add(panel1);
            Name = "EditMedForm";
            Text = "EditMedForm";
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
        private RichTextBox rec_text;
        private Label label3;
        private RichTextBox name_text;
        private RichTextBox symptoms_text;
        private Label label2;
    }
}