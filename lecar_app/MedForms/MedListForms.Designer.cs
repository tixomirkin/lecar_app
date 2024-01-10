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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedListForms));
            label6 = new Label();
            panel_med = new Panel();
            analog_btn = new Button();
            med_counter = new RichTextBox();
            edit_med_btn = new Button();
            label5 = new Label();
            del_med_btn = new Button();
            label4 = new Label();
            illness_text = new RichTextBox();
            label3 = new Label();
            name_text = new RichTextBox();
            active_substance_text = new RichTextBox();
            label2 = new Label();
            exit_btn = new Button();
            label1 = new Label();
            add_med_btn = new Button();
            search_text_box = new TextBox();
            med_list_box = new ListBox();
            pictureBox1 = new PictureBox();
            panel_med.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(20, 38);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(78, 27);
            label6.TabIndex = 13;
            label6.Text = "Поиск";
            // 
            // panel_med
            // 
            panel_med.BackColor = SystemColors.ControlLightLight;
            panel_med.BorderStyle = BorderStyle.FixedSingle;
            panel_med.Controls.Add(analog_btn);
            panel_med.Controls.Add(med_counter);
            panel_med.Controls.Add(edit_med_btn);
            panel_med.Controls.Add(label5);
            panel_med.Controls.Add(del_med_btn);
            panel_med.Controls.Add(label4);
            panel_med.Controls.Add(illness_text);
            panel_med.Controls.Add(label3);
            panel_med.Controls.Add(name_text);
            panel_med.Controls.Add(active_substance_text);
            panel_med.Controls.Add(label2);
            panel_med.Location = new Point(478, 17);
            panel_med.Margin = new Padding(4, 2, 4, 2);
            panel_med.Name = "panel_med";
            panel_med.Size = new Size(683, 809);
            panel_med.TabIndex = 12;
            panel_med.Visible = false;
            // 
            // analog_btn
            // 
            analog_btn.BackColor = SystemColors.ActiveCaption;
            analog_btn.Font = new Font("Arial", 9F);
            analog_btn.ForeColor = SystemColors.ControlLightLight;
            analog_btn.Location = new Point(454, 732);
            analog_btn.Margin = new Padding(4, 2, 4, 2);
            analog_btn.Name = "analog_btn";
            analog_btn.Size = new Size(208, 51);
            analog_btn.TabIndex = 11;
            analog_btn.Text = "Аналоги";
            analog_btn.UseVisualStyleBackColor = false;
            analog_btn.Click += analog_btn_Click;
            // 
            // med_counter
            // 
            med_counter.BackColor = SystemColors.ControlLightLight;
            med_counter.BorderStyle = BorderStyle.None;
            med_counter.Font = new Font("Arial", 16.1F, FontStyle.Bold, GraphicsUnit.Point, 204);
            med_counter.HideSelection = false;
            med_counter.Location = new Point(28, 617);
            med_counter.Margin = new Padding(4, 2, 4, 2);
            med_counter.Name = "med_counter";
            med_counter.ReadOnly = true;
            med_counter.Size = new Size(635, 58);
            med_counter.TabIndex = 10;
            med_counter.Text = "0";
            // 
            // edit_med_btn
            // 
            edit_med_btn.BackColor = Color.Orange;
            edit_med_btn.Font = new Font("Arial", 9F);
            edit_med_btn.ForeColor = SystemColors.ControlLightLight;
            edit_med_btn.Location = new Point(238, 732);
            edit_med_btn.Margin = new Padding(4, 2, 4, 2);
            edit_med_btn.Name = "edit_med_btn";
            edit_med_btn.Size = new Size(208, 51);
            edit_med_btn.TabIndex = 8;
            edit_med_btn.Text = "Редактировать";
            edit_med_btn.UseVisualStyleBackColor = false;
            edit_med_btn.Click += edit_med_btn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(28, 559);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(379, 27);
            label5.TabIndex = 7;
            label5.Text = "Количество лекарства на складе";
            // 
            // del_med_btn
            // 
            del_med_btn.BackColor = Color.LightCoral;
            del_med_btn.Font = new Font("Arial", 9F);
            del_med_btn.ForeColor = SystemColors.ControlLightLight;
            del_med_btn.Location = new Point(22, 732);
            del_med_btn.Margin = new Padding(4, 2, 4, 2);
            del_med_btn.Name = "del_med_btn";
            del_med_btn.Size = new Size(208, 51);
            del_med_btn.TabIndex = 4;
            del_med_btn.Text = "Удалить";
            del_med_btn.UseVisualStyleBackColor = false;
            del_med_btn.Click += del_med_btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(22, 337);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(284, 27);
            label4.TabIndex = 5;
            label4.Text = "Связанные заболевания";
            // 
            // illness_text
            // 
            illness_text.BackColor = Color.WhiteSmoke;
            illness_text.BorderStyle = BorderStyle.None;
            illness_text.Font = new Font("Arial", 10.1F, FontStyle.Regular, GraphicsUnit.Point, 204);
            illness_text.HideSelection = false;
            illness_text.Location = new Point(28, 382);
            illness_text.Margin = new Padding(4, 2, 4, 2);
            illness_text.Name = "illness_text";
            illness_text.ReadOnly = true;
            illness_text.Size = new Size(635, 134);
            illness_text.TabIndex = 4;
            illness_text.Text = "Заболевания";
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
            name_text.BackColor = SystemColors.ControlLightLight;
            name_text.BorderStyle = BorderStyle.None;
            name_text.Font = new Font("Arial", 16.1F, FontStyle.Bold, GraphicsUnit.Point, 204);
            name_text.ForeColor = Color.DarkOliveGreen;
            name_text.HideSelection = false;
            name_text.Location = new Point(28, 75);
            name_text.Margin = new Padding(4, 2, 4, 2);
            name_text.Name = "name_text";
            name_text.ReadOnly = true;
            name_text.Size = new Size(635, 58);
            name_text.TabIndex = 2;
            name_text.Text = "Название лекарства";
            // 
            // active_substance_text
            // 
            active_substance_text.BackColor = Color.WhiteSmoke;
            active_substance_text.BorderStyle = BorderStyle.None;
            active_substance_text.Font = new Font("Arial", 10.1F, FontStyle.Regular, GraphicsUnit.Point, 204);
            active_substance_text.HideSelection = false;
            active_substance_text.Location = new Point(28, 186);
            active_substance_text.Margin = new Padding(4, 2, 4, 2);
            active_substance_text.Name = "active_substance_text";
            active_substance_text.ReadOnly = true;
            active_substance_text.Size = new Size(635, 134);
            active_substance_text.TabIndex = 1;
            active_substance_text.Text = "Активное вещество";
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
            // exit_btn
            // 
            exit_btn.Font = new Font("Arial", 9F);
            exit_btn.Location = new Point(245, 752);
            exit_btn.Margin = new Padding(4, 2, 4, 2);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(208, 51);
            exit_btn.TabIndex = 9;
            exit_btn.Text = "Закрыть";
            exit_btn.UseVisualStyleBackColor = true;
            exit_btn.Click += exit_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(607, 384);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(436, 45);
            label1.TabIndex = 11;
            label1.Text = "<- Выберите лекарство";
            // 
            // add_med_btn
            // 
            add_med_btn.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            add_med_btn.Location = new Point(20, 752);
            add_med_btn.Margin = new Padding(15, 11, 15, 11);
            add_med_btn.Name = "add_med_btn";
            add_med_btn.Size = new Size(219, 51);
            add_med_btn.TabIndex = 10;
            add_med_btn.Text = "Добавить";
            add_med_btn.UseVisualStyleBackColor = true;
            add_med_btn.Click += add_med_btn_Click;
            // 
            // search_text_box
            // 
            search_text_box.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            search_text_box.Location = new Point(20, 70);
            search_text_box.Margin = new Padding(7, 6, 7, 6);
            search_text_box.Name = "search_text_box";
            search_text_box.Size = new Size(351, 63);
            search_text_box.TabIndex = 9;
            search_text_box.TextChanged += search_text_box_TextChanged;
            // 
            // med_list_box
            // 
            med_list_box.DisplayMember = "name";
            med_list_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            med_list_box.FormattingEnabled = true;
            med_list_box.ItemHeight = 45;
            med_list_box.Location = new Point(20, 149);
            med_list_box.Margin = new Padding(4, 2, 4, 2);
            med_list_box.Name = "med_list_box";
            med_list_box.Size = new Size(433, 589);
            med_list_box.TabIndex = 8;
            med_list_box.ValueMember = "Id";
            med_list_box.SelectedIndexChanged += med_list_box_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(381, 70);
            pictureBox1.Margin = new Padding(4, 2, 4, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // MedListForms
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 841);
            Controls.Add(pictureBox1);
            Controls.Add(exit_btn);
            Controls.Add(label6);
            Controls.Add(panel_med);
            Controls.Add(label1);
            Controls.Add(add_med_btn);
            Controls.Add(search_text_box);
            Controls.Add(med_list_box);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 2, 4, 2);
            Name = "MedListForms";
            Text = "Список Лекарств";
            panel_med.ResumeLayout(false);
            panel_med.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Panel panel_med;
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
        private PictureBox pictureBox1;
        private RichTextBox med_counter;
        private Button analog_btn;
    }
}