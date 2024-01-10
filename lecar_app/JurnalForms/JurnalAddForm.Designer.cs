namespace lecar_app.JurnalForms
{
    partial class JurnalAddForm
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
            other_text = new TabControl();
            tabPage2 = new TabPage();
            med_list = new ListBox();
            label6 = new Label();
            rect_text = new RichTextBox();
            tabPage3 = new TabPage();
            richTextBox3 = new RichTextBox();
            name_text = new TextBox();
            label3 = new Label();
            label1 = new Label();
            ill_text = new TextBox();
            add_ill_btn = new Button();
            label2 = new Label();
            date_pick = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            syptoms_text = new RichTextBox();
            save_btn = new Button();
            cancel_btn = new Button();
            other_text.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // other_text
            // 
            other_text.Controls.Add(tabPage2);
            other_text.Controls.Add(tabPage3);
            other_text.Location = new Point(568, 12);
            other_text.Name = "other_text";
            other_text.SelectedIndex = 0;
            other_text.Size = new Size(695, 737);
            other_text.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(med_list);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(rect_text);
            tabPage2.Location = new Point(8, 50);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(679, 679);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Лечение";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // med_list
            // 
            med_list.FormattingEnabled = true;
            med_list.ItemHeight = 36;
            med_list.Location = new Point(0, 459);
            med_list.Name = "med_list";
            med_list.Size = new Size(676, 220);
            med_list.TabIndex = 4;
            med_list.Visible = false;
            med_list.Click += med_list_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(3, 382);
            label6.Name = "label6";
            label6.Size = new Size(481, 64);
            label6.TabIndex = 3;
            label6.Text = "Список рекомендуемых лекарств\r\n(нажмите чтобы добавить в лечение)\r\n";
            // 
            // rect_text
            // 
            rect_text.Location = new Point(3, 3);
            rect_text.Name = "rect_text";
            rect_text.Size = new Size(670, 376);
            rect_text.TabIndex = 2;
            rect_text.Text = "";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(richTextBox3);
            tabPage3.Location = new Point(8, 50);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(679, 679);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Примечания";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBox3
            // 
            richTextBox3.Dock = DockStyle.Fill;
            richTextBox3.Location = new Point(0, 0);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(679, 679);
            richTextBox3.TabIndex = 2;
            richTextBox3.Text = "";
            // 
            // name_text
            // 
            name_text.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            name_text.Location = new Point(26, 62);
            name_text.Name = "name_text";
            name_text.Size = new Size(517, 50);
            name_text.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(23, 26);
            label3.Name = "label3";
            label3.Size = new Size(180, 27);
            label3.TabIndex = 4;
            label3.Text = "ФИО Пациента";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(21, 125);
            label1.Name = "label1";
            label1.Size = new Size(100, 27);
            label1.TabIndex = 5;
            label1.Text = "Диагноз";
            // 
            // ill_text
            // 
            ill_text.BackColor = SystemColors.ControlLightLight;
            ill_text.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ill_text.Location = new Point(26, 161);
            ill_text.Name = "ill_text";
            ill_text.ReadOnly = true;
            ill_text.Size = new Size(446, 50);
            ill_text.TabIndex = 6;
            ill_text.Text = "Выберите болезнь";
            // 
            // add_ill_btn
            // 
            add_ill_btn.Location = new Point(475, 161);
            add_ill_btn.Name = "add_ill_btn";
            add_ill_btn.Size = new Size(68, 50);
            add_ill_btn.TabIndex = 7;
            add_ill_btn.Text = "...";
            add_ill_btn.UseVisualStyleBackColor = true;
            add_ill_btn.Click += add_ill_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(22, 573);
            label2.Name = "label2";
            label2.Size = new Size(64, 27);
            label2.TabIndex = 8;
            label2.Text = "Дата";
            // 
            // date_pick
            // 
            date_pick.CalendarFont = new Font("Arial", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            date_pick.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            date_pick.Location = new Point(26, 609);
            date_pick.Name = "date_pick";
            date_pick.Size = new Size(517, 50);
            date_pick.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(21, 234);
            label4.Name = "label4";
            label4.Size = new Size(130, 27);
            label4.TabIndex = 11;
            label4.Text = "Симптомы";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 588);
            label5.Name = "label5";
            label5.Size = new Size(0, 36);
            label5.TabIndex = 12;
            // 
            // syptoms_text
            // 
            syptoms_text.Location = new Point(26, 275);
            syptoms_text.Name = "syptoms_text";
            syptoms_text.Size = new Size(517, 270);
            syptoms_text.TabIndex = 13;
            syptoms_text.Text = "";
            // 
            // save_btn
            // 
            save_btn.BackColor = Color.LimeGreen;
            save_btn.Font = new Font("Arial", 9F);
            save_btn.ForeColor = SystemColors.ControlLightLight;
            save_btn.Location = new Point(119, 690);
            save_btn.Margin = new Padding(4, 2, 4, 2);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(208, 51);
            save_btn.TabIndex = 14;
            save_btn.Text = "Добавить";
            save_btn.UseVisualStyleBackColor = false;
            // 
            // cancel_btn
            // 
            cancel_btn.BackColor = Color.Orange;
            cancel_btn.Font = new Font("Arial", 9F);
            cancel_btn.ForeColor = SystemColors.ControlLightLight;
            cancel_btn.Location = new Point(335, 690);
            cancel_btn.Margin = new Padding(4, 2, 4, 2);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(208, 51);
            cancel_btn.TabIndex = 15;
            cancel_btn.Text = "Отмена";
            cancel_btn.UseVisualStyleBackColor = false;
            // 
            // JurnalAddForm
            // 
            AutoScaleDimensions = new SizeF(18F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 761);
            Controls.Add(cancel_btn);
            Controls.Add(save_btn);
            Controls.Add(syptoms_text);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(date_pick);
            Controls.Add(label2);
            Controls.Add(add_ill_btn);
            Controls.Add(ill_text);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(name_text);
            Controls.Add(other_text);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 3, 4, 3);
            Name = "JurnalAddForm";
            Text = "JurnalAddForm";
            other_text.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl other_text;
        private TabPage tabPage2;
        private TextBox name_text;
        private Label label3;
        private Label label1;
        private TextBox ill_text;
        private Button add_ill_btn;
        private Label label2;
        private DateTimePicker date_pick;
        private RichTextBox rect_text;
        private TabPage tabPage3;
        private RichTextBox richTextBox3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox med_list;
        private RichTextBox syptoms_text;
        private Button save_btn;
        private Button cancel_btn;
    }
}