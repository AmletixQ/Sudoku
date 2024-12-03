using System;
using System.Drawing;
using System.Windows.Forms;

namespace SudokuGame
{
    public partial class Sudoku : Form
    {
        public Sudoku()
        {
            InitializeComponent();
        }

        private void Sudoku_Load(object sender, EventArgs e)
        {
            int gridSize = 9;
            int cellSize = 50;

            SudokuField.RowCount = gridSize;
            SudokuField.ColumnCount = gridSize;

            SudokuField.AllowUserToAddRows = false;
            SudokuField.AllowUserToDeleteRows = false;
            SudokuField.AllowUserToResizeRows = false;
            SudokuField.AllowUserToResizeColumns = false;

            SudokuField.RowHeadersVisible = false;
            SudokuField.ColumnHeadersVisible = false;

            SudokuField.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SudokuField.DefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);
            SudokuField.DefaultCellStyle.ForeColor = Color.Black;

            foreach (DataGridViewColumn column in SudokuField.Columns)
                column.Width = cellSize;

            foreach (DataGridViewRow row in SudokuField.Rows)
                row.Height = cellSize;

            SudokuField.Width = cellSize * gridSize + 3;
            SudokuField.Height = cellSize * gridSize + 3;

            SudokuField.Left = (this.ClientSize.Width - SudokuField.Width) / 2;
            SudokuField.Top = (this.ClientSize.Height - SudokuField.Height) / 2;

            SudokuField.GridColor = Color.Black;

            SudokuField.EditingControlShowing += SudokuField_EditingControlShowing;
            SudokuField.CellPainting += SudokuField_CellPainting;

            this.Resize += Sudoku_Resize;
        }

        private void SudokuField_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

        }

        private void Sudoku_Resize(object sender, EventArgs e)
        {
            SudokuField.Left = (this.ClientSize.Width - SudokuField.Width) / 2;
            SudokuField.Top = (this.ClientSize.Height - SudokuField.Height) / 2;
        }

        private void SudokuField_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (e.ColumnIndex % 3 == 0)
                e.AdvancedBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.Single;
            if (e.RowIndex % 3 == 0)
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;

            e.Handled = false;
        }
    }
}
