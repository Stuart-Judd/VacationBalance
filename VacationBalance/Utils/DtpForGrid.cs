using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace VacationBalance.Utils
{
    /// <summary>
    /// By Amen Ayach
    /// </summary>
    public class DtpForGrid : DateTimePicker
    {

        public event EndEditEventHandler EndEdit;
        public delegate void EndEditEventHandler(object sender, DtpForGridEventArgs e);

        private DataGridViewColumn _GridCol = null;
        public DataGridViewColumn GridCol
        {
            get { return _GridCol; }
            set
            {
                _GridCol = value;
                if (_GridCol != null)
                {

                    if (_GridCol.DataGridView != null)
                    {
                        System.Windows.Forms.DataGridViewCellStyle CellStyle = new System.Windows.Forms.DataGridViewCellStyle();
                        CellStyle.Format = "dd/MM/yyyy";
                        _GridCol.DefaultCellStyle = CellStyle;
                        _GridCol.DataGridView.CellBeginEdit += grd_CellBeginEdit;
                        _GridCol.DataGridView.CurrentCellChanged += grd_CurrentCellChanged;

                    }
                }
            }
        }

        private int _CurrentRowIndex = -1;
        public int CurrentRowIndex
        {
            get { return _CurrentRowIndex; }
            set { _CurrentRowIndex = value; }
        }

        private void grd_CellBeginEdit(object sender, System.Windows.Forms.DataGridViewCellCancelEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == GridCol.Index)
                {
                    e.Cancel = true;
                    var _with1 = this;

                    _with1.Width = GridCol.DataGridView.Columns[e.ColumnIndex].Width;
                    GridCol.DataGridView.Parent.Controls.Add(this);
                    _with1.Location =
                        GridCol.DataGridView.Parent.PointToClient(
                            GridCol.DataGridView.PointToScreen(
                                GridCol.DataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location));
                    _with1.Show();
                    _with1.BringToFront();
                    _with1.Select();
                }
            }
            catch
            {
            }
        }

        private void grd_CurrentCellChanged(object sender, System.EventArgs e)
        {
            if (GridCol.DataGridView != null)
            {
                if (GridCol.DataGridView.CurrentRow != null)
                    CurrentRowIndex = GridCol.DataGridView.CurrentRow.Index;
                this.Hide();
            }
        }

        private void dtGrid_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                    case Keys.Space:
                    case Keys.Tab:
                        GridCol.DataGridView.Rows[CurrentRowIndex].Cells[GridCol.Name].Value = this.Value;
                        this.Hide();
                        GridCol.DataGridView.Select();
                        if (EndEdit != null)
                        {
                            EndEdit(this, new DtpForGridEventArgs
                            {
                                RowIndex = CurrentRowIndex,
                                ColumnIndex = GridCol.Index,
                                Value = this.Value
                            });
                        }

                        break;
                    case Keys.Escape:
                        this.Hide();
                        break;
                }
            }
            catch
            {
            }
        }

        public DtpForGrid()
        {
            KeyDown += dtGrid_KeyDown;
            Visible = false;
        }

        public static void ApplyTo(DataGridViewColumn gridColumn, string format = "dd-MM-yyyy", EndEditEventHandler endEdit = null)
        {
            var dtpForGrid = new DtpForGrid() { GridCol = gridColumn, Format = DateTimePickerFormat.Custom, CustomFormat = format };
            if (endEdit != null) dtpForGrid.EndEdit += endEdit;
        }
    }

    public class DtpForGridEventArgs : EventArgs
    {

        private System.DateTime _Value;
        public System.DateTime Value
        {
            get { return _Value; }
            set { _Value = value; }
        }

        private int _RowIndex;
        public int RowIndex
        {
            get { return _RowIndex; }
            set { _RowIndex = value; }
        }

        public int ColumnIndex { get; set; }

    }
}
