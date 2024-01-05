namespace lecar_app.MedForms
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
            med_list_box = new ListBox();
            button2 = new Button();
            add_med_btn = new Button();
            cancel_btn = new Button();
            label5 = new Label();
            save_illness_btn = new Button();
            label3 = new Label();
            name_text = new RichTextBox();
            active_substance_text = new RichTextBox();
            label2 = new Label();
            med_counter = new NumericUpDown();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)med_counter).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(med_counter);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(med_list_box);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(add_med_btn);
            panel1.Controls.Add(cancel_btn);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(save_illness_btn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(name_text);
            panel1.Controls.Add(active_substance_text);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(683, 764);
            panel1.TabIndex = 8;
            // 
            // med_list_box
            // 
            med_list_box.FormattingEnabled = true;
            med_list_box.Location = new Point(27, 528);
            med_list_box.Margin = new Padding(4, 3, 4, 3);
            med_list_box.Name = "med_list_box";
            med_list_box.Size = new Size(571, 132);
            med_list_box.TabIndex = 12;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 9F);
            button2.Location = new Point(606, 586);
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
            add_med_btn.Location = new Point(606, 528);
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
            cancel_btn.Location = new Point(454, 685);
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
            label5.Location = new Point(22, 485);
            label5.Name = "label5";
            label5.Size = new Size(284, 27);
            label5.TabIndex = 7;
            label5.Text = "Связанные заболевания";
            // 
            // save_illness_btn
            // 
            save_illness_btn.Font = new Font("Arial", 9F);
            save_illness_btn.Location = new Point(238, 685);
            save_illness_btn.Margin = new Padding(4, 3, 4, 3);
            save_illness_btn.Name = "save_illness_btn";
            save_illness_btn.Size = new Size(208, 52);
            save_illness_btn.TabIndex = 4;
            save_illness_btn.Text = "Добавить";
            save_illness_btn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(22, 143);
            label3.Name = "label3";
            label3.Size = new Size(229, 27);
            label3.TabIndex = 3;
            label3.Text = "Активное вещество";
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
            // active_substance_text
            // 
            active_substance_text.BackColor = Color.FromArgb(192, 255, 192);
            active_substance_text.BorderStyle = BorderStyle.FixedSingle;
            active_substance_text.Font = new Font("Arial", 10.1F, FontStyle.Regular, GraphicsUnit.Point, 204);
            active_substance_text.Location = new Point(27, 186);
            active_substance_text.Name = "active_substance_text";
            active_substance_text.Size = new Size(635, 135);
            active_substance_text.TabIndex = 1;
            active_substance_text.Text = "";
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
            // med_counter
            // 
            med_counter.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            med_counter.Location = new Point(27, 387);
            med_counter.Name = "med_counter";
            med_counter.Size = new Size(148, 65);
            med_counter.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(27, 343);
            label1.Name = "label1";
            label1.Size = new Size(393, 27);
            label1.TabIndex = 13;
            label1.Text = "Колличество лекарства на складе";
            // 
            // AddMedForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 789);
            Controls.Add(panel1);
            Name = "AddMedForm";
            Text = "AddMedForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)med_counter).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox med_list_box;
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