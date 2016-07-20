using System;
using System.Windows.Forms;

namespace VacationBalance.Utils
{
    public class GridHelper
    {

        public enum EColType
        {
            IntegerCol,
            NumericCol,
            PositiveIntegerCol,
            PositiveNumericCol,
            NegativeIntegerCol,
            NegativeNumericCol
        }

        private readonly DataGridViewColumn _grdC;
        
        private readonly EColType _colT = EColType.NumericCol;

        private readonly object _dftVal;

        public GridHelper(DataGridViewColumn gridCol, EColType colType, object defaultValue = null)
        {
            if (gridCol != null && gridCol.DataGridView != null && !gridCol.DataGridView.IsDisposed)
            {
                _grdC = gridCol;
                _colT = colType;
                _dftVal = defaultValue ?? 0;
                _grdC.DataGridView.CellEndEdit += GridEndEdit;
            }
        }

        private void GridEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == _grdC.Index)
                {
                    switch (_colT)
                    {
                        case EColType.IntegerCol:
                        case EColType.PositiveIntegerCol:
                        case EColType.NegativeIntegerCol:

                            int intForParse;
                            //Integer
                            if (!int.TryParse(_grdC.DataGridView.Rows[e.RowIndex].Cells[_grdC.Index].Value.ToString(), out intForParse))
                            {
                                _grdC.DataGridView.Rows[e.RowIndex].Cells[_grdC.Index].Value = Convert.ToInt32(_grdC.DataGridView.Rows[e.RowIndex].Cells[_grdC.Index].Value.ToString());
                            }
                            else
                            {
                                _grdC.DataGridView.Rows[e.RowIndex].Cells[_grdC.Index].Value = _dftVal;
                            }

                            //+
                            if (_colT == EColType.PositiveIntegerCol)
                            {
                                if (Convert.ToInt32(_grdC.DataGridView.Rows[e.RowIndex].Cells[_grdC.Index].Value.ToString()) < 0)
                                {
                                    _grdC.DataGridView.Rows[e.RowIndex].Cells[_grdC.Index].Value = _dftVal;
                                }
                            }

                            //-
                            if (_colT == EColType.NegativeIntegerCol)
                            {
                                if (Convert.ToInt32(_grdC.DataGridView.Rows[e.RowIndex].Cells[_grdC.Index].Value.ToString()) > 0)
                                {
                                    _grdC.DataGridView.Rows[e.RowIndex].Cells[_grdC.Index].Value = _dftVal;
                                }
                            }

                            break;
                        case EColType.NumericCol:
                        case EColType.PositiveNumericCol:
                        case EColType.NegativeNumericCol:

                            decimal dToParse;
                            //decimal
                            if (!decimal.TryParse(_grdC.DataGridView.Rows[e.RowIndex].Cells[_grdC.Index].Value.ToString(), out dToParse))
                            {
                                _grdC.DataGridView.Rows[e.RowIndex].Cells[_grdC.Index].Value = _dftVal;
                            }

                            //+
                            if (_colT == EColType.PositiveNumericCol)
                            {
                                if (Convert.ToInt32(_grdC.DataGridView.Rows[e.RowIndex].Cells[_grdC.Index].Value.ToString()) < 0)
                                {
                                    _grdC.DataGridView.Rows[e.RowIndex].Cells[_grdC.Index].Value = _dftVal;
                                }
                            }

                            //-
                            if (_colT == EColType.NegativeNumericCol)
                            {
                                if (Convert.ToInt32(_grdC.DataGridView.Rows[e.RowIndex].Cells[_grdC.Index].Value.ToString()) > 0)
                                {
                                    _grdC.DataGridView.Rows[e.RowIndex].Cells[_grdC.Index].Value = _dftVal;
                                }
                            }

                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                ex.PromptMsg();
            }
        }

        public static void ApplyColumnBehavior(DataGridViewColumn gridCol, EColType colType, object defaultValue = null)
        {
            // ReSharper disable once ObjectCreationAsStatement
            new GridHelper(gridCol, colType, defaultValue);
        }
    }
}
