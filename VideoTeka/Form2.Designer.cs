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
            Tabla = new DataGridView();
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
            // Tabla
            // 
            Tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tabla.Dock = DockStyle.Bottom;
            Tabla.Location = new Point(0, 195);
            Tabla.Name = "Tabla";
            Tabla.RowTemplate.Height = 25;
            Tabla.Size = new Size(1051, 244);
            Tabla.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 439);
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
        private DataGridView Tabla;
    }
}