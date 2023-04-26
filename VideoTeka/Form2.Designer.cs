namespace VideoTeka
{
    partial class Form2
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
            button2 = new Button();
            button1 = new Button();
            tb_search = new TextBox();
            data = new Button();
            label1 = new Label();
            label2 = new Label();
            Tabla = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Title = new DataGridViewTextBoxColumn();
            Actors = new DataGridViewTextBoxColumn();
            Runtime = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            poszter = new DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)Tabla).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(139, 12);
            button2.Name = "button2";
            button2.Size = new Size(121, 27);
            button2.TabIndex = 1;
            button2.Text = "Vásárlás";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(121, 27);
            button1.TabIndex = 0;
            button1.Text = "Kölcsönzés";
            button1.UseVisualStyleBackColor = true;
            // 
            // tb_search
            // 
            tb_search.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_search.Location = new Point(266, 12);
            tb_search.Name = "tb_search";
            tb_search.PlaceholderText = "Film Keresés";
            tb_search.Size = new Size(274, 27);
            tb_search.TabIndex = 2;
            tb_search.KeyPress += tb_search_KeyPress;
            // 
            // data
            // 
            data.Location = new Point(546, 12);
            data.Name = "data";
            data.Size = new Size(121, 27);
            data.TabIndex = 4;
            data.Text = "Keresés";
            data.UseVisualStyleBackColor = true;
            data.Click += data_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // Tabla
            // 
            Tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tabla.Columns.AddRange(new DataGridViewColumn[] { Title, Actors, Runtime, Year, poszter });
            Tabla.Dock = DockStyle.Bottom;
            Tabla.Location = new Point(0, 195);
            Tabla.Name = "Tabla";
            Tabla.RowTemplate.Height = 25;
            Tabla.Size = new Size(1051, 244);
            Tabla.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 8;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 134);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 7;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 166);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 9;
            label5.Text = "label5";
            // 
            // Title
            // 
            Title.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Title.HeaderText = "Cim";
            Title.Name = "Title";
            Title.Width = 54;
            // 
            // Actors
            // 
            Actors.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Actors.HeaderText = "Főszereplők";
            Actors.Name = "Actors";
            Actors.Width = 94;
            // 
            // Runtime
            // 
            Runtime.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Runtime.HeaderText = "Hossz";
            Runtime.Name = "Runtime";
            Runtime.Width = 63;
            // 
            // Year
            // 
            Year.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Year.HeaderText = "Megjelenés";
            Year.Name = "Year";
            Year.Width = 92;
            // 
            // poszter
            // 
            poszter.HeaderText = "Poszter";
            poszter.Name = "poszter";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 439);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(data);
            Controls.Add(button2);
            Controls.Add(Tabla);
            Controls.Add(button1);
            Controls.Add(tb_search);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)Tabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private Button rentBtn;
        private Button button2;
        private Button button1;
        private TextBox tb_search;
        private Button data;
        private Label label1;
        private Label label2;
        private DataGridView Tabla;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Actors;
        private DataGridViewTextBoxColumn Runtime;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewLinkColumn poszter;
    }
}