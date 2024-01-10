namespace lecar_app.JurnalForms
{
    partial class JurnalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JurnalForm));
            jurnal_grid = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            illness = new DataGridViewTextBoxColumn();
            syptoms = new DataGridViewTextBoxColumn();
            recomends = new DataGridViewTextBoxColumn();
            other = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            tabss = new TabControl();
            tabPage2 = new TabPage();
            rect_text = new RichTextBox();
            tabPage1 = new TabPage();
            symtoms_text = new RichTextBox();
            tabPage3 = new TabPage();
            other_text = new RichTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            exit_btn = new Button();
            del_med_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)jurnal_grid).BeginInit();
            panel1.SuspendLayout();
            tabss.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // jurnal_grid
            // 
            jurnal_grid.AllowUserToAddRows = false;
            jurnal_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            jurnal_grid.Columns.AddRange(new DataGridViewColumn[] { id, date, name, illness, syptoms, recomends, other });
            jurnal_grid.Dock = DockStyle.Fill;
            jurnal_grid.Location = new Point(3, 3);
            jurnal_grid.Name = "jurnal_grid";
            jurnal_grid.ReadOnly = true;
            jurnal_grid.RowHeadersWidth = 82;
            jurnal_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            jurnal_grid.Size = new Size(776, 801);
            jurnal_grid.TabIndex = 0;
            jurnal_grid.SelectionChanged += jurnal_grid_SelectionChanged;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 10;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 200;
            // 
            // date
            // 
            date.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            date.HeaderText = "Дата";
            date.MinimumWidth = 10;
            date.Name = "date";
            date.ReadOnly = true;
            date.Width = 110;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "ФИО";
            name.MinimumWidth = 10;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // illness
            // 
            illness.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            illness.HeaderText = "Диагноз";
            illness.MinimumWidth = 10;
            illness.Name = "illness";
            illness.ReadOnly = true;
            illness.Width = 150;
            // 
            // syptoms
            // 
            syptoms.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            syptoms.HeaderText = "Симптомы";
            syptoms.MinimumWidth = 10;
            syptoms.Name = "syptoms";
            syptoms.ReadOnly = true;
            syptoms.Visible = false;
            syptoms.Width = 200;
            // 
            // recomends
            // 
            recomends.HeaderText = "Лечение";
            recomends.MinimumWidth = 10;
            recomends.Name = "recomends";
            recomends.ReadOnly = true;
            recomends.Visible = false;
            recomends.Width = 200;
            // 
            // other
            // 
            other.HeaderText = "Примечания";
            other.MinimumWidth = 10;
            other.Name = "other";
            other.ReadOnly = true;
            other.Visible = false;
            other.Width = 200;
            // 
            // panel1
            // 
            panel1.Controls.Add(tabss);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(785, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 801);
            panel1.TabIndex = 1;
            // 
            // tabss
            // 
            tabss.Controls.Add(tabPage2);
            tabss.Controls.Add(tabPage1);
            tabss.Controls.Add(tabPage3);
            tabss.Dock = DockStyle.Fill;
            tabss.Location = new Point(0, 0);
            tabss.Name = "tabss";
            tabss.SelectedIndex = 0;
            tabss.Size = new Size(620, 801);
            tabss.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(rect_text);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(604, 747);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Лечение";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // rect_text
            // 
            rect_text.Dock = DockStyle.Fill;
            rect_text.Location = new Point(3, 3);
            rect_text.Name = "rect_text";
            rect_text.ReadOnly = true;
            rect_text.Size = new Size(598, 741);
            rect_text.TabIndex = 2;
            rect_text.Text = "";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(symtoms_text);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(604, 747);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Симптомы";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // symtoms_text
            // 
            symtoms_text.Dock = DockStyle.Fill;
            symtoms_text.Location = new Point(3, 3);
            symtoms_text.Name = "symtoms_text";
            symtoms_text.ReadOnly = true;
            symtoms_text.Size = new Size(598, 741);
            symtoms_text.TabIndex = 3;
            symtoms_text.Text = "";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(other_text);
            tabPage3.Location = new Point(8, 46);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(604, 747);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Примечания";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // other_text
            // 
            other_text.Dock = DockStyle.Fill;
            other_text.Location = new Point(0, 0);
            other_text.Name = "other_text";
            other_text.ReadOnly = true;
            other_text.Size = new Size(604, 747);
            other_text.TabIndex = 2;
            other_text.Text = "";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.5555573F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.4444427F));
            tableLayoutPanel1.Controls.Add(jurnal_grid, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tableLayoutPanel1.Size = new Size(1408, 879);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(exit_btn);
            panel2.Controls.Add(del_med_btn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(785, 810);
            panel2.Name = "panel2";
            panel2.Size = new Size(620, 66);
            panel2.TabIndex = 2;
            // 
            // exit_btn
            // 
            exit_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exit_btn.Font = new Font("Arial", 9F);
            exit_btn.Location = new Point(401, 7);
            exit_btn.Margin = new Padding(4, 2, 4, 2);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(208, 51);
            exit_btn.TabIndex = 10;
            exit_btn.Text = "Закрыть";
            exit_btn.UseVisualStyleBackColor = true;
            exit_btn.Click += exit_btn_Click;
            // 
            // del_med_btn
            // 
            del_med_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            del_med_btn.BackColor = Color.LightCoral;
            del_med_btn.Font = new Font("Arial", 9F);
            del_med_btn.ForeColor = SystemColors.ControlLightLight;
            del_med_btn.Location = new Point(185, 7);
            del_med_btn.Margin = new Padding(4, 2, 4, 2);
            del_med_btn.Name = "del_med_btn";
            del_med_btn.Size = new Size(208, 51);
            del_med_btn.TabIndex = 5;
            del_med_btn.Text = "Удалить";
            del_med_btn.UseVisualStyleBackColor = false;
            del_med_btn.Click += del_med_btn_Click;
            // 
            // JurnalForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1408, 879);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "JurnalForm";
            Text = "Jurnal";
            ((System.ComponentModel.ISupportInitialize)jurnal_grid).EndInit();
            panel1.ResumeLayout(false);
            tabss.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView jurnal_grid;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn illness;
        private DataGridViewTextBoxColumn syptoms;
        private DataGridViewTextBoxColumn recomends;
        private DataGridViewTextBoxColumn other;
        private Panel panel1;
        private TabControl tabss;
        private TabPage tabPage2;
        private RichTextBox rect_text;
        private TabPage tabPage3;
        private RichTextBox other_text;
        private TableLayoutPanel tableLayoutPanel1;
        private TabPage tabPage1;
        private RichTextBox symtoms_text;
        private Panel panel2;
        private Button del_med_btn;
        private Button exit_btn;
    }
}