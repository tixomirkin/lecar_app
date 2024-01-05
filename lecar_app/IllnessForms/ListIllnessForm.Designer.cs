namespace lecar_app.IllnessForms
{
    partial class ListIllnessForm
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
            components = new System.ComponentModel.Container();
            illness_list_box = new ListBox();
            illnessBindingSource = new BindingSource(components);
            search_text_box = new TextBox();
            add_illness_btn = new Button();
            del_illness_btn = new Button();
            label1 = new Label();
            panel_ill = new Panel();
            exit_btn = new Button();
            edit_illness_btn = new Button();
            label5 = new Label();
            rec_med_text = new RichTextBox();
            label4 = new Label();
            rec_text = new RichTextBox();
            label3 = new Label();
            name_text = new RichTextBox();
            symptoms_text = new RichTextBox();
            label2 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)illnessBindingSource).BeginInit();
            panel_ill.SuspendLayout();
            SuspendLayout();
            // 
            // illness_list_box
            // 
            illness_list_box.DisplayMember = "name";
            illness_list_box.FormattingEnabled = true;
            illness_list_box.ItemHeight = 36;
            illness_list_box.Location = new Point(31, 142);
            illness_list_box.Margin = new Padding(4, 3, 4, 3);
            illness_list_box.Name = "illness_list_box";
            illness_list_box.Size = new Size(433, 580);
            illness_list_box.TabIndex = 0;
            illness_list_box.ValueMember = "Id";
            illness_list_box.SelectedIndexChanged += illness_list_box_SelectedIndexChanged;
            // 
            // illnessBindingSource
            // 
            illnessBindingSource.DataSource = typeof(database.Illness);
            // 
            // search_text_box
            // 
            search_text_box.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            search_text_box.Location = new Point(31, 64);
            search_text_box.Margin = new Padding(7, 6, 7, 6);
            search_text_box.Name = "search_text_box";
            search_text_box.Size = new Size(352, 63);
            search_text_box.TabIndex = 1;
            search_text_box.TextChanged += search_text_box_TextChanged;
            // 
            // add_illness_btn
            // 
            add_illness_btn.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            add_illness_btn.Location = new Point(31, 736);
            add_illness_btn.Margin = new Padding(14, 11, 14, 11);
            add_illness_btn.Name = "add_illness_btn";
            add_illness_btn.Size = new Size(433, 52);
            add_illness_btn.TabIndex = 3;
            add_illness_btn.Text = "Добавить";
            add_illness_btn.UseVisualStyleBackColor = true;
            add_illness_btn.Click += add_illness_btn_Click;
            // 
            // del_illness_btn
            // 
            del_illness_btn.Font = new Font("Arial", 9F);
            del_illness_btn.Location = new Point(22, 731);
            del_illness_btn.Margin = new Padding(4, 3, 4, 3);
            del_illness_btn.Name = "del_illness_btn";
            del_illness_btn.Size = new Size(208, 52);
            del_illness_btn.TabIndex = 4;
            del_illness_btn.Text = "Удалить";
            del_illness_btn.UseVisualStyleBackColor = true;
            del_illness_btn.Click += del_illness_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(619, 376);
            label1.Name = "label1";
            label1.Size = new Size(402, 45);
            label1.TabIndex = 5;
            label1.Text = "<- Выберите болезнь";
            // 
            // panel_ill
            // 
            panel_ill.Controls.Add(exit_btn);
            panel_ill.Controls.Add(edit_illness_btn);
            panel_ill.Controls.Add(label5);
            panel_ill.Controls.Add(del_illness_btn);
            panel_ill.Controls.Add(rec_med_text);
            panel_ill.Controls.Add(label4);
            panel_ill.Controls.Add(rec_text);
            panel_ill.Controls.Add(label3);
            panel_ill.Controls.Add(name_text);
            panel_ill.Controls.Add(symptoms_text);
            panel_ill.Controls.Add(label2);
            panel_ill.Location = new Point(488, 5);
            panel_ill.Name = "panel_ill";
            panel_ill.Size = new Size(683, 808);
            panel_ill.TabIndex = 6;
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
            // edit_illness_btn
            // 
            edit_illness_btn.Font = new Font("Arial", 9F);
            edit_illness_btn.Location = new Point(238, 731);
            edit_illness_btn.Margin = new Padding(4, 3, 4, 3);
            edit_illness_btn.Name = "edit_illness_btn";
            edit_illness_btn.Size = new Size(208, 52);
            edit_illness_btn.TabIndex = 8;
            edit_illness_btn.Text = "Редактировать";
            edit_illness_btn.UseVisualStyleBackColor = true;
            edit_illness_btn.Click += edit_illness_btn_Click;
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
            // rec_med_text
            // 
            rec_med_text.BackColor = Color.FromArgb(192, 255, 192);
            rec_med_text.BorderStyle = BorderStyle.None;
            rec_med_text.Font = new Font("Arial", 10.1F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rec_med_text.HideSelection = false;
            rec_med_text.Location = new Point(27, 570);
            rec_med_text.Name = "rec_med_text";
            rec_med_text.ReadOnly = true;
            rec_med_text.Size = new Size(635, 134);
            rec_med_text.TabIndex = 6;
            rec_med_text.Text = "эта хуйня пока не робит лол";
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
            rec_text.BorderStyle = BorderStyle.None;
            rec_text.Font = new Font("Arial", 10.1F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rec_text.HideSelection = false;
            rec_text.Location = new Point(27, 381);
            rec_text.Name = "rec_text";
            rec_text.ReadOnly = true;
            rec_text.Size = new Size(635, 134);
            rec_text.TabIndex = 4;
            rec_text.Text = "- Кашель\n- Температура\n- Кашель\n- Температура\n- Кашель\n- Температура\n- Кашель\n- Температура\n- Кашель\n- Температура\n- Кашель\n- Температура\n- Кашель\n- Температура";
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
            name_text.BorderStyle = BorderStyle.None;
            name_text.Font = new Font("Arial", 16.1F, FontStyle.Bold, GraphicsUnit.Point, 204);
            name_text.HideSelection = false;
            name_text.Location = new Point(27, 75);
            name_text.Name = "name_text";
            name_text.ReadOnly = true;
            name_text.Size = new Size(635, 58);
            name_text.TabIndex = 2;
            name_text.Text = "ОРВИ";
            // 
            // symptoms_text
            // 
            symptoms_text.BackColor = Color.FromArgb(192, 255, 192);
            symptoms_text.BorderStyle = BorderStyle.None;
            symptoms_text.Font = new Font("Arial", 10.1F, FontStyle.Regular, GraphicsUnit.Point, 204);
            symptoms_text.HideSelection = false;
            symptoms_text.Location = new Point(27, 186);
            symptoms_text.Name = "symptoms_text";
            symptoms_text.ReadOnly = true;
            symptoms_text.Size = new Size(635, 135);
            symptoms_text.TabIndex = 1;
            symptoms_text.Text = "- Кашель\n- Температура\n- Кашель\n- Температура\n- Кашель\n- Температура\n- Кашель\n- Температура\n- Кашель\n- Температура\n- Кашель\n- Температура\n- Кашель\n- Температура";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(31, 31);
            label6.Name = "label6";
            label6.Size = new Size(78, 27);
            label6.TabIndex = 7;
            label6.Text = "Поиск";
            // 
            // ListIllnessForm
            // 
            AutoScaleDimensions = new SizeF(18F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 825);
            Controls.Add(label6);
            Controls.Add(panel_ill);
            Controls.Add(label1);
            Controls.Add(add_illness_btn);
            Controls.Add(search_text_box);
            Controls.Add(illness_list_box);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ListIllnessForm";
            Text = "База болезней";
            ((System.ComponentModel.ISupportInitialize)illnessBindingSource).EndInit();
            panel_ill.ResumeLayout(false);
            panel_ill.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox illness_list_box;
        private TextBox search_text_box;
        private Button add_illness_btn;
        private Button del_illness_btn;
        private Label label1;
        private Panel panel_ill;
        private RichTextBox symptoms_text;
        private Label label2;
        private RichTextBox name_text;
        private Label label3;
        private Label label4;
        private RichTextBox rec_text;
        private Button exit_btn;
        private Button edit_illness_btn;
        private Label label5;
        private RichTextBox rec_med_text;
        private Label label6;
        private BindingSource illnessBindingSource;
    }
}