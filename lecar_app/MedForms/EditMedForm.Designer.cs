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
            med_counter = new NumericUpDown();
            illness_list_box = new ListBox();
            button2 = new Button();
            add_med_btn = new Button();
            cancel_btn = new Button();
            label5 = new Label();
            save_illness_btn = new Button();
            label4 = new Label();
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
            panel1.Controls.Add(illness_list_box);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(add_med_btn);
            panel1.Controls.Add(cancel_btn);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(save_illness_btn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(name_text);
            panel1.Controls.Add(active_substance_text);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(6, 6);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 379);
            panel1.TabIndex = 8;
            // 
            // med_counter
            // 
            med_counter.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            med_counter.Location = new Point(15, 188);
            med_counter.Margin = new Padding(2, 1, 2, 1);
            med_counter.Name = "med_counter";
            med_counter.Size = new Size(80, 36);
            med_counter.TabIndex = 13;
            // 
            // illness_list_box
            // 
            illness_list_box.DisplayMember = "name";
            illness_list_box.FormattingEnabled = true;
            illness_list_box.ItemHeight = 15;
            illness_list_box.Location = new Point(15, 267);
            illness_list_box.Margin = new Padding(2, 1, 2, 1);
            illness_list_box.Name = "illness_list_box";
            illness_list_box.Size = new Size(309, 64);
            illness_list_box.TabIndex = 12;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 9F);
            button2.Location = new Point(326, 294);
            button2.Margin = new Padding(2, 1, 2, 1);
            button2.Name = "button2";
            button2.Size = new Size(30, 24);
            button2.TabIndex = 11;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // add_med_btn
            // 
            add_med_btn.Font = new Font("Arial", 9F);
            add_med_btn.Location = new Point(326, 267);
            add_med_btn.Margin = new Padding(2, 1, 2, 1);
            add_med_btn.Name = "add_med_btn";
            add_med_btn.Size = new Size(30, 24);
            add_med_btn.TabIndex = 10;
            add_med_btn.Text = "+";
            add_med_btn.UseVisualStyleBackColor = true;
            add_med_btn.Click += add_med_btn_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.Font = new Font("Arial", 9F);
            cancel_btn.Location = new Point(244, 340);
            cancel_btn.Margin = new Padding(2, 1, 2, 1);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(112, 24);
            cancel_btn.TabIndex = 9;
            cancel_btn.Text = "Отмена";
            cancel_btn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(12, 247);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(150, 15);
            label5.TabIndex = 7;
            label5.Text = "Связанные заболевания";
            // 
            // save_illness_btn
            // 
            save_illness_btn.Font = new Font("Arial", 9F);
            save_illness_btn.Location = new Point(128, 340);
            save_illness_btn.Margin = new Padding(2, 1, 2, 1);
            save_illness_btn.Name = "save_illness_btn";
            save_illness_btn.Size = new Size(112, 24);
            save_illness_btn.TabIndex = 4;
            save_illness_btn.Text = "Сохранить";
            save_illness_btn.UseVisualStyleBackColor = true;
            save_illness_btn.Click += save_illness_btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 158);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(132, 15);
            label4.TabIndex = 5;
            label4.Text = "Количество на складе";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 67);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 3;
            label3.Text = "Активное вещество";
            // 
            // name_text
            // 
            name_text.BorderStyle = BorderStyle.FixedSingle;
            name_text.Font = new Font("Arial", 16.1F, FontStyle.Bold, GraphicsUnit.Point, 204);
            name_text.Location = new Point(15, 35);
            name_text.Margin = new Padding(2, 1, 2, 1);
            name_text.Name = "name_text";
            name_text.Size = new Size(344, 29);
            name_text.TabIndex = 2;
            name_text.Text = "";
            // 
            // active_substance_text
            // 
            active_substance_text.BackColor = Color.FromArgb(192, 255, 192);
            active_substance_text.BorderStyle = BorderStyle.FixedSingle;
            active_substance_text.Font = new Font("Arial", 10.1F, FontStyle.Regular, GraphicsUnit.Point, 204);
            active_substance_text.Location = new Point(15, 87);
            active_substance_text.Margin = new Padding(2, 1, 2, 1);
            active_substance_text.Name = "active_substance_text";
            active_substance_text.Size = new Size(344, 65);
            active_substance_text.TabIndex = 1;
            active_substance_text.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 17);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 0;
            label2.Text = "Название";
            // 
            // EditMedForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 390);
            Controls.Add(panel1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "EditMedForm";
            Text = "EditMedForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)med_counter).EndInit();
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
        private RichTextBox active_substance_text;
        private Label label2;
        private NumericUpDown med_counter;
    }
}