namespace lecar_app
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            illness_btn = new Button();
            med_btn = new Button();
            button3 = new Button();
            button4 = new Button();
            add_jurnal_btn = new Button();
            button6 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // illness_btn
            // 
            illness_btn.Location = new Point(18, 311);
            illness_btn.Margin = new Padding(4);
            illness_btn.Name = "illness_btn";
            illness_btn.Size = new Size(492, 61);
            illness_btn.TabIndex = 0;
            illness_btn.Text = "База болезней";
            illness_btn.UseVisualStyleBackColor = true;
            illness_btn.Click += button1_Click;
            // 
            // med_btn
            // 
            med_btn.Location = new Point(18, 391);
            med_btn.Margin = new Padding(4);
            med_btn.Name = "med_btn";
            med_btn.Size = new Size(492, 61);
            med_btn.TabIndex = 1;
            med_btn.Text = "База лекарств";
            med_btn.UseVisualStyleBackColor = true;
            med_btn.Click += med_btn_Click;
            // 
            // button3
            // 
            button3.Location = new Point(18, 475);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(242, 61);
            button3.TabIndex = 2;
            button3.Text = "О программе";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(268, 475);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(242, 61);
            button4.TabIndex = 3;
            button4.Text = "Выход";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // add_jurnal_btn
            // 
            add_jurnal_btn.Location = new Point(18, 155);
            add_jurnal_btn.Margin = new Padding(4);
            add_jurnal_btn.Name = "add_jurnal_btn";
            add_jurnal_btn.Size = new Size(492, 61);
            add_jurnal_btn.TabIndex = 4;
            add_jurnal_btn.Text = "Новая запись";
            add_jurnal_btn.UseVisualStyleBackColor = true;
            add_jurnal_btn.Click += add_jurnal_btn_Click;
            // 
            // button6
            // 
            button6.Location = new Point(18, 236);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(492, 61);
            button6.TabIndex = 5;
            button6.Text = "Журнал";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(30, 58);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(477, 56);
            label1.TabIndex = 6;
            label1.Text = "Добро пожаловать";
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(192F, 192F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(533, 563);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(add_jurnal_btn);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(med_btn);
            Controls.Add(illness_btn);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главное меню";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button illness_btn;
        private Button med_btn;
        private Button button3;
        private Button button4;
        private Button add_jurnal_btn;
        private Button button6;
        private Label label1;
    }
}