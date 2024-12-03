namespace SudokuGame
{
    partial class Sudoku
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
            this.SudokuField = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SudokuField)).BeginInit();
            this.SuspendLayout();
            // 
            // SudokuField
            // 
            this.SudokuField.AllowUserToAddRows = false;
            this.SudokuField.AllowUserToDeleteRows = false;
            this.SudokuField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SudokuField.Location = new System.Drawing.Point(117, 65);
            this.SudokuField.Name = "SudokuField";
            this.SudokuField.ReadOnly = true;
            this.SudokuField.Size = new System.Drawing.Size(500, 500);
            this.SudokuField.TabIndex = 0;
            // 
            // Sudoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 714);
            this.Controls.Add(this.SudokuField);
            this.Name = "Sudoku";
            this.Text = "Sudoku game";
            this.Load += new System.EventHandler(this.Sudoku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SudokuField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SudokuField;
    }
}

