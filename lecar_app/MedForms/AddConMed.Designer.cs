namespace lecar_app.MedForms
{
    partial class AddConMed
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
            ill_list_box = new ListBox();
            label6 = new Label();
            add_illness_btn = new Button();
            search_text_box = new TextBox();
            SuspendLayout();
            // 
            // ill_list_box
            // 
            ill_list_box.DisplayMember = "name";
            ill_list_box.FormattingEnabled = true;
            ill_list_box.ItemHeight = 15;
            ill_list_box.Location = new Point(3, 62);
            ill_list_box.Name = "ill_list_box";
            ill_list_box.SelectionMode = SelectionMode.MultiSimple;
            ill_list_box.Size = new Size(191, 244);
            ill_list_box.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(3, 5);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 16;
            label6.Text = "Поиск";
            // 
            // add_illness_btn
            // 
            add_illness_btn.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            add_illness_btn.Location = new Point(3, 336);
            add_illness_btn.Margin = new Padding(8, 5, 8, 5);
            add_illness_btn.Name = "add_illness_btn";
            add_illness_btn.Size = new Size(233, 24);
            add_illness_btn.TabIndex = 15;
            add_illness_btn.Text = "Добавить";
            add_illness_btn.UseVisualStyleBackColor = true;
            add_illness_btn.Click += add_illness_btn_Click;
            // 
            // search_text_box
            // 
            search_text_box.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            search_text_box.Location = new Point(3, 21);
            search_text_box.Margin = new Padding(4, 3, 4, 3);
            search_text_box.Name = "search_text_box";
            search_text_box.Size = new Size(191, 35);
            search_text_box.TabIndex = 14;
            // 
            // AddConMed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 370);
            Controls.Add(ill_list_box);
            Controls.Add(label6);
            Controls.Add(add_illness_btn);
            Controls.Add(search_text_box);
            Name = "AddConMed";
            Text = "Добавить болезнь";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ill_list_box;
        private Label label6;
        private Button add_illness_btn;
        private TextBox search_text_box;
    }
}