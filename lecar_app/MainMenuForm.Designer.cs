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
            illness_btn = new Button();
            med_btn = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // illness_btn
            // 
            illness_btn.Location = new Point(167, 340);
            illness_btn.Name = "illness_btn";
            illness_btn.Size = new Size(241, 46);
            illness_btn.TabIndex = 0;
            illness_btn.Text = "База болезней";
            illness_btn.UseVisualStyleBackColor = true;
            illness_btn.Click += button1_Click;
            // 
            // med_btn
            // 
            med_btn.Location = new Point(167, 405);
            med_btn.Name = "med_btn";
            med_btn.Size = new Size(241, 46);
            med_btn.TabIndex = 1;
            med_btn.Text = "База лекарств";
            med_btn.UseVisualStyleBackColor = true;
            med_btn.Click += med_btn_Click;
            // 
            // button3
            // 
            button3.Location = new Point(67, 531);
            button3.Name = "button3";
            button3.Size = new Size(208, 46);
            button3.TabIndex = 2;
            button3.Text = "О программе";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(322, 531);
            button4.Name = "button4";
            button4.Size = new Size(150, 46);
            button4.TabIndex = 3;
            button4.Text = "Выход";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(174, 176);
            button5.Name = "button5";
            button5.Size = new Size(234, 46);
            button5.TabIndex = 4;
            button5.Text = "Новая запись";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(210, 255);
            button6.Name = "button6";
            button6.Size = new Size(150, 46);
            button6.TabIndex = 5;
            button6.Text = "Журнал";
            button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 36);
            label1.Name = "label1";
            label1.Size = new Size(220, 27);
            label1.TabIndex = 6;
            label1.Text = "Добро пожаловать";
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(587, 634);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(med_btn);
            Controls.Add(illness_btn);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainMenuForm";
            Text = "MainMenuForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button illness_btn;
        private Button med_btn;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
    }
}