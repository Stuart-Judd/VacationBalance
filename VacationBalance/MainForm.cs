using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VacationBalance.Models;
using VacationBalance.Utils;

namespace VacationBalance
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Icon = Properties.Resources.travel_journey;
            GridHelper.ApplyColumnBehavior(colNBOfDays, GridHelper.EColType.NumericCol, 0m);
            DtpForGrid.ApplyTo(colStartDate, "dd-MM-yyyy", EndEdit);
            DtpForGrid.ApplyTo(colEndDate, "dd-MM-yyyy", EndEdit);
            dtpToDate.Value = DateTime.Now.Date;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {

                //var testData = new UserData()
                //{
                //    StartDate = new DateTime(2016, 4, 25),
                //    StartBalance = 30.25m,
                //    UserId = Environment.UserName,
                //    Vacations = new[] { new Vacation() { StartDate = DateTime.Now, EndDate = DateTime.Now, Days = 1m } }.ToList()
                //};
                //ControlMod.SaveBinary(testData, ControlMod.CombinePath(Application.StartupPath, "data.bd"));

                LoadData();
            }
            catch (Exception ex)
            {
                ex.PromptMsg();
            }
        }

        /// <summary>
        /// Loads data from the saved binary file into UI
        /// </summary>
        private void LoadData()
        {
            var data = ControlMod.LoadBinary(ControlMod.CombinePath(Application.StartupPath, "data.bd")) as UserData;

            if (data != null)
            {
                dtpStartBalance.Value = data.StartDate;
                numStartBalance.Value = data.StartBalance;

                if (data.Vacations.NotEmpty())
                {

                    grdVacations.AllowUserToAddRows = false;

                    for (int i = 0; i < data.Vacations.Count; i++)
                    {

                        grdVacations.Rows.Add();
                        grdVacations.sg(i, colStartDate, data.Vacations[i].StartDate);
                        grdVacations.sg(i, colEndDate, data.Vacations[i].EndDate);
                        grdVacations.sg(i, colNBOfDays, data.Vacations[i].Days);

                    }

                }
            }

            grdVacations.AllowUserToAddRows = true;
        }

        /// <summary>
        /// Saving user data when user closes the app
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

                var userData = new UserData()
                {
                    StartDate = dtpStartBalance.Value.Date,
                    StartBalance = numStartBalance.Value,
                    UserId = Environment.UserName,
                    Vacations = new List<Vacation>()
                };

                grdVacations.AllowUserToAddRows = false;

                if (grdVacations.RowCount > 0)
                {

                    for (int i = 0; i < grdVacations.RowCount; i++)
                    {

                        var cStart = grdVacations.gg(i, colStartDate) != null ? (DateTime)grdVacations.gg(i, colStartDate) : DateTime.Now;
                        var cEnd = grdVacations.gg(i, colEndDate) != null ? (DateTime)grdVacations.gg(i, colEndDate) : DateTime.Now;
                        var cDays = grdVacations.gg(i, colNBOfDays) != null ? Convert.ToDecimal(grdVacations.gg(i, colNBOfDays)) : 0m;
                        userData.Vacations.Add(new Vacation() { StartDate = cStart, EndDate = cEnd, Days = cDays });

                    }
                }

                ControlMod.SaveBinary(userData, ControlMod.CombinePath(Application.StartupPath, "data.bd"));
            }
            catch (Exception ex)
            {
                ex.PromptMsg();
            }
        }

        /// <summary>
        /// Change Nb of days according to the selected vacation dates and user can override it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndEdit(object sender, DtpForGridEventArgs e)
        {
            try
            {

                var cStart = grdVacations.gg(e.RowIndex, colStartDate) != null ? (DateTime)grdVacations.gg(e.RowIndex, colStartDate) : DateTime.Now;
                var cEnd = grdVacations.gg(e.RowIndex, colEndDate) != null ? (DateTime)grdVacations.gg(e.RowIndex, colEndDate) : DateTime.Now;

                if (e.ColumnIndex == colStartDate.Index || e.ColumnIndex == colEndDate.Index)
                {
                    grdVacations.sg(e.RowIndex, colNBOfDays, (decimal)(cEnd.Date - cStart.Date).TotalDays + 1);
                }
            }
            catch
            {

            }
        }

        /// <summary>
        /// Calculates the balance
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                var result = numStartBalance.Value +
                             dtpToDate.Value.Date.MonthDifference(dtpStartBalance.Value.Date) *
                             numDaysPerMonth.Value;

                grdVacations.AllowUserToAddRows = false;

                for (int i = 0; i < grdVacations.RowCount; i++)
                {

                    var cDays = grdVacations.gg(i, colNBOfDays) != null ? Convert.ToDecimal(grdVacations.gg(i, colNBOfDays)) : 0m;
                    result -= cDays;

                }

                lblBalance.Text = string.Format("{0} Days", result.ToString("0.##"));

            }
            catch (Exception ex)
            {
                ex.PromptMsg();
            }
            finally
            {
                grdVacations.AllowUserToAddRows = true;
            }
        }

        /// <summary>
        /// Intercept user hotkeys
        /// </summary>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnRefresh.PerformClick();
            }
        }

    }
}
