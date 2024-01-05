namespace lecar_app.MedForms
{
    partial class MedListForms
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
            label6 = new Label();
            panel_ill = new Panel();
            exit_btn = new Button();
            edit_med_btn = new Button();
            label5 = new Label();
            del_med_btn = new Button();
            label4 = new Label();
            illness_text = new RichTextBox();
            label3 = new Label();
            name_text = new RichTextBox();
            active_substance_text = new RichTextBox();
            label2 = new Label();
            label1 = new Label();
            add_med_btn = new Button();
            search_text_box = new TextBox();
            med_list_box = new ListBox();
            med_counter = new NumericUpDown();
            panel_ill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)med_counter).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(20, 38);
            label6.Name = "label6";
            label6.Size = new Size(78, 27);
            label6.TabIndex = 13;
            label6.Text = "Поиск";
            // 
            // panel_ill
            // 
            panel_ill.Controls.Add(med_counter);
            panel_ill.Controls.Add(exit_btn);
            panel_ill.Controls.Add(edit_med_btn);
            panel_ill.Controls.Add(label5);
            panel_ill.Controls.Add(del_med_btn);
            panel_ill.Controls.Add(label4);
            panel_ill.Controls.Add(illness_text);
            panel_ill.Controls.Add(label3);
            panel_ill.Controls.Add(name_text);
            panel_ill.Controls.Add(active_substance_text);
            panel_ill.Controls.Add(label2);
            panel_ill.Location = new Point(480, 21);
            panel_ill.Name = "panel_ill";
            panel_ill.Size = new Size(683, 808);
            panel_ill.TabIndex = 12;
            panel_ill.Visible = false;
            // 
            // exit_btn
            // 
            exit_btn.Font = new Font("Arial", 9F);
            exit_btn.Location = new Point(454, 731);
            exit_btn.Margin = new Padding(4, 3, 4, 3);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(208, 52);
            exit_btn.TabIndex = 9;
            exit_btn.Text = "Закрыть";
            exit_btn.UseVisualStyleBackColor = true;
            exit_btn.Click += exit_btn_Click;
            // 
            // edit_med_btn
            // 
            edit_med_btn.Font = new Font("Arial", 9F);
            edit_med_btn.Location = new Point(238, 731);
            edit_med_btn.Margin = new Padding(4, 3, 4, 3);
            edit_med_btn.Name = "edit_med_btn";
            edit_med_btn.Size = new Size(208, 52);
            edit_med_btn.TabIndex = 8;
            edit_med_btn.Text = "Редактировать";
            edit_med_btn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(27, 558);
            label5.Name = "label5";
            label5.Size = new Size(393, 27);
            label5.TabIndex = 7;
            label5.Text = "Колличество лекарства на складе";
            // 
            // del_med_btn
            // 
            del_med_btn.Font = new Font("Arial", 9F);
            del_med_btn.Location = new Point(22, 731);
            del_med_btn.Margin = new Padding(4, 3, 4, 3);
            del_med_btn.Name = "del_med_btn";
            del_med_btn.Size = new Size(208, 52);
            del_med_btn.TabIndex = 4;
            del_med_btn.Text = "Удалить";
            del_med_btn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(22, 338);
            label4.Name = "label4";
            label4.Size = new Size(284, 27);
            label4.TabIndex = 5;
            label4.Text = "Связанные заболевания";
            // 
            // illness_text
            // 
            illness_text.BackColor = Color.FromArgb(192, 255, 192);
            illness_text.BorderStyle = BorderStyle.None;
            illness_text.Font = new Font("Arial", 10.1F, FontStyle.Regular, GraphicsUnit.Point, 204);
            illness_text.HideSelection = false;
            illness_text.Location = new Point(27, 381);
            illness_text.Name = "illness_text";
            illness_text.ReadOnly = true;
            illness_text.Size = new Size(635, 134);
            illness_text.TabIndex = 4;
            illness_text.Text = "- Кашель\n- Температура\n- Кашель\n- Температура\n- Кашель\n- Температура\n- Кашель\n- Температура\n- Кашель\n- Температура\n- Кашель\n- Температура\n- Кашель\n- Температура";
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
            name_text.BorderStyle = BorderStyle.None;
            name_text.Font = new Font("Arial", 16.1F, FontStyle.Bold, GraphicsUnit.Point, 204);
            name_text.HideSelection = false;
            name_text.Location = new Point(27, 75);
            name_text.Name = "name_text";
            name_text.ReadOnly = true;
            name_text.Size = new Size(635, 58);
            name_text.TabIndex = 2;
            name_text.Text = "Атаракс";
            // 
            // active_substance_text
            // 
            active_substance_text.BackColor = Color.FromArgb(192, 255, 192);
            active_substance_text.BorderStyle = BorderStyle.None;
            active_substance_text.Font = new Font("Arial", 10.1F, FontStyle.Regular, GraphicsUnit.Point, 204);
            active_substance_text.HideSelection = false;
            active_substance_text.Location = new Point(27, 186);
            active_substance_text.Name = "active_substance_text";
            active_substance_text.ReadOnly = true;
            active_substance_text.Size = new Size(635, 135);
            active_substance_text.TabIndex = 1;
            active_substance_text.Text = "Морфий";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(608, 383);
            label1.Name = "label1";
            label1.Size = new Size(436, 45);
            label1.TabIndex = 11;
            label1.Text = "<- Выберите лекарство";
            // 
            // add_med_btn
            // 
            this.add_med_btn.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.add_med_btn.Location = new Point(20, 743);
            this.add_med_btn.Margin = new Padding(14, 11, 14, 11);
            this.add_med_btn.Name = "add_med_btn";
            this.add_med_btn.Size = new Size(433, 52);
            this.add_med_btn.TabIndex = 10;
            this.add_med_btn.Text = "Добавить";
            this.add_med_btn.UseVisualStyleBackColor = true;
            // 
            // search_text_box
            // 
            search_text_box.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            search_text_box.Location = new Point(20, 71);
            search_text_box.Margin = new Padding(7, 6, 7, 6);
            search_text_box.Name = "search_text_box";
            search_text_box.Size = new Size(352, 63);
            search_text_box.TabIndex = 9;
            // 
            // med_list_box
            // 
            med_list_box.DisplayMember = "name";
            med_list_box.FormattingEnabled = true;
            med_list_box.Location = new Point(20, 149);
            med_list_box.Margin = new Padding(4, 3, 4, 3);
            med_list_box.Name = "med_list_box";
            med_list_box.Size = new Size(433, 580);
            med_list_box.TabIndex = 8;
            med_list_box.ValueMember = "Id";
            // 
            // med_counter
            // 
            med_counter.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            med_counter.Location = new Point(27, 602);
            med_counter.Name = "med_counter";
            med_counter.Size = new Size(148, 65);
            med_counter.TabIndex = 10;
            // 
            // MedListForms
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 841);
            Controls.Add(label6);
            Controls.Add(panel_ill);
            Controls.Add(label1);
            Controls.Add(this.add_med_btn);
            Controls.Add(search_text_box);
            Controls.Add(med_list_box);
            Name = "MedListForms";
            Text = "MedListForms";
            panel_ill.ResumeLayout(false);
            panel_ill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)med_counter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Panel panel_ill;
        private Button exit_btn;
        private Button edit_med_btn;
        private Label label5;
        private Button del_med_btn;
        private RichTextBox rec_med_text;
        private Label label4;
        private RichTextBox illness_text;
        private Label label3;
        private RichTextBox name_text;
        private RichTextBox active_substance_text;
        private Label label2;
        private Label label1;
        private Button add_med_btn;
        private TextBox search_text_box;
        private ListBox med_list_box;
        private NumericUpDown med_counter;
    }
}