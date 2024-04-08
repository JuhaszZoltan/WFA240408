namespace WFA240408
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            cb = new ComboBox();
            tb = new TextBox();
            btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgv.Location = new Point(12, 12);
            dgv.Name = "dgv";
            dgv.RowHeadersVisible = false;
            dgv.Size = new Size(643, 226);
            dgv.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.FillWeight = 1F;
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.FillWeight = 2F;
            Column2.HeaderText = "username";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.FillWeight = 5F;
            Column3.HeaderText = "content";
            Column3.Name = "Column3";
            // 
            // cb
            // 
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.FormattingEnabled = true;
            cb.Location = new Point(12, 272);
            cb.Name = "cb";
            cb.Size = new Size(126, 23);
            cb.TabIndex = 1;
            // 
            // tb
            // 
            tb.Location = new Point(144, 272);
            tb.Name = "tb";
            tb.Size = new Size(511, 23);
            tb.TabIndex = 2;
            // 
            // btn
            // 
            btn.Location = new Point(12, 311);
            btn.Name = "btn";
            btn.Size = new Size(643, 35);
            btn.TabIndex = 3;
            btn.Text = "új bejegyzés";
            btn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 364);
            Controls.Add(btn);
            Controls.Add(tb);
            Controls.Add(cb);
            Controls.Add(dgv);
            Name = "MainForm";
            Text = "beszelgetes";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private ComboBox cb;
        private TextBox tb;
        private Button btn;
    }
}
