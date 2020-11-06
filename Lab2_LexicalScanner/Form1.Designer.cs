namespace Lab2_LexicalScanner
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.Header = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ChooseFileBtn = new System.Windows.Forms.Button();
            this.NameOfFileField = new System.Windows.Forms.TextBox();
            this.FileTextField = new System.Windows.Forms.RichTextBox();
            this.LexemGuiTable = new System.Windows.Forms.DataGridView();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LexemGuiTable)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(82)))), ((int)(((byte)(48)))));
            this.Header.Controls.Add(this.ExitBtn);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(900, 63);
            this.Header.TabIndex = 0;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitBtn.BackgroundImage")));
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Location = new System.Drawing.Point(14, 6);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(50, 47);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 63);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ChooseFileBtn);
            this.splitContainer1.Panel1.Controls.Add(this.NameOfFileField);
            this.splitContainer1.Panel1.Controls.Add(this.FileTextField);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.LexemGuiTable);
            this.splitContainer1.Size = new System.Drawing.Size(900, 437);
            this.splitContainer1.SplitterDistance = 443;
            this.splitContainer1.TabIndex = 1;
            // 
            // ChooseFileBtn
            // 
            this.ChooseFileBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(82)))), ((int)(((byte)(48)))));
            this.ChooseFileBtn.FlatAppearance.BorderSize = 3;
            this.ChooseFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseFileBtn.Font = new System.Drawing.Font("Ubuntu Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseFileBtn.ForeColor = System.Drawing.Color.Beige;
            this.ChooseFileBtn.Location = new System.Drawing.Point(318, 6);
            this.ChooseFileBtn.Name = "ChooseFileBtn";
            this.ChooseFileBtn.Size = new System.Drawing.Size(122, 44);
            this.ChooseFileBtn.TabIndex = 2;
            this.ChooseFileBtn.Text = "Select file";
            this.ChooseFileBtn.UseVisualStyleBackColor = true;
            this.ChooseFileBtn.Click += new System.EventHandler(this.ChooseFileBtn_Click);
            // 
            // NameOfFileField
            // 
            this.NameOfFileField.Font = new System.Drawing.Font("Ubuntu Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameOfFileField.Location = new System.Drawing.Point(14, 15);
            this.NameOfFileField.Name = "NameOfFileField";
            this.NameOfFileField.ReadOnly = true;
            this.NameOfFileField.Size = new System.Drawing.Size(298, 25);
            this.NameOfFileField.TabIndex = 1;
            // 
            // FileTextField
            // 
            this.FileTextField.Font = new System.Drawing.Font("Ubuntu Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileTextField.Location = new System.Drawing.Point(12, 56);
            this.FileTextField.Name = "FileTextField";
            this.FileTextField.ReadOnly = true;
            this.FileTextField.Size = new System.Drawing.Size(428, 369);
            this.FileTextField.TabIndex = 0;
            this.FileTextField.Text = "";
            // 
            // LexemGuiTable
            // 
            this.LexemGuiTable.AllowUserToAddRows = false;
            this.LexemGuiTable.AllowUserToDeleteRows = false;
            this.LexemGuiTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LexemGuiTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LexemGuiTable.ColumnHeadersVisible = false;
            this.LexemGuiTable.Location = new System.Drawing.Point(3, 6);
            this.LexemGuiTable.Name = "LexemGuiTable";
            this.LexemGuiTable.ReadOnly = true;
            this.LexemGuiTable.RowHeadersVisible = false;
            this.LexemGuiTable.Size = new System.Drawing.Size(446, 419);
            this.LexemGuiTable.TabIndex = 0;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lexical Scanner";
            this.Header.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LexemGuiTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button ChooseFileBtn;
        private System.Windows.Forms.TextBox NameOfFileField;
        private System.Windows.Forms.RichTextBox FileTextField;
        private System.Windows.Forms.DataGridView LexemGuiTable;
    }
}

