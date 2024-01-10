namespace lecar_app.IllnessForms
{
    partial class AddConIllness
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddConIllness));
            label6 = new Label();
            add_illness_btn = new Button();
            search_text_box = new TextBox();
            med_list_box = new ListBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(13, 19);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(78, 27);
            label6.TabIndex = 11;
            label6.Text = "Поиск";
            // 
            // add_illness_btn
            // 
            add_illness_btn.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            add_illness_btn.Location = new Point(13, 706);
            add_illness_btn.Margin = new Padding(15, 11, 15, 11);
            add_illness_btn.Name = "add_illness_btn";
            add_illness_btn.Size = new Size(433, 51);
            add_illness_btn.TabIndex = 10;
            add_illness_btn.Text = "Добавить";
            add_illness_btn.UseVisualStyleBackColor = true;
            add_illness_btn.Click += add_illness_btn_Click;
            // 
            // search_text_box
            // 
            search_text_box.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            search_text_box.Location = new Point(13, 53);
            search_text_box.Margin = new Padding(7, 6, 7, 6);
            search_text_box.Name = "search_text_box";
            search_text_box.Size = new Size(364, 63);
            search_text_box.TabIndex = 9;
            search_text_box.TextChanged += search_text_box_TextChanged;
            // 
            // med_list_box
            // 
            med_list_box.DisplayMember = "name";
            med_list_box.FormattingEnabled = true;
            med_list_box.Location = new Point(13, 141);
            med_list_box.Margin = new Padding(6);
            med_list_box.Name = "med_list_box";
            med_list_box.SelectionMode = SelectionMode.MultiSimple;
            med_list_box.Size = new Size(429, 548);
            med_list_box.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(388, 53);
            pictureBox1.Margin = new Padding(4, 2, 4, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // AddConIllness
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 776);
            Controls.Add(pictureBox1);
            Controls.Add(med_list_box);
            Controls.Add(label6);
            Controls.Add(add_illness_btn);
            Controls.Add(search_text_box);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 2, 4, 2);
            Name = "AddConIllness";
            Text = "Добавить лекарство";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Button add_illness_btn;
        private TextBox search_text_box;
        private ListBox med_list_box;
        private PictureBox pictureBox1;
    }
}