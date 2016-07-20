namespace VacationBalance
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartBalance = new System.Windows.Forms.DateTimePicker();
            this.lblStartBalance = new System.Windows.Forms.Label();
            this.numStartBalance = new System.Windows.Forms.NumericUpDown();
            this.lblVacations = new System.Windows.Forms.Label();
            this.grdVacations = new System.Windows.Forms.DataGridView();
            this.colStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNBOfDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lblTill = new System.Windows.Forms.Label();
            this.lblBalanceIs = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.numDaysPerMonth = new System.Windows.Forms.NumericUpDown();
            this.lblDaysPerMonth = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numStartBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVacations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDaysPerMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(9, 22);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(83, 20);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "Start Date";
            // 
            // dtpStartBalance
            // 
            this.dtpStartBalance.CustomFormat = "dd-MM-yyyy";
            this.dtpStartBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartBalance.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartBalance.Location = new System.Drawing.Point(122, 18);
            this.dtpStartBalance.Name = "dtpStartBalance";
            this.dtpStartBalance.Size = new System.Drawing.Size(104, 26);
            this.dtpStartBalance.TabIndex = 1;
            // 
            // lblStartBalance
            // 
            this.lblStartBalance.AutoSize = true;
            this.lblStartBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartBalance.Location = new System.Drawing.Point(10, 53);
            this.lblStartBalance.Name = "lblStartBalance";
            this.lblStartBalance.Size = new System.Drawing.Size(106, 20);
            this.lblStartBalance.TabIndex = 2;
            this.lblStartBalance.Text = "Start Balance";
            // 
            // numStartBalance
            // 
            this.numStartBalance.DecimalPlaces = 2;
            this.numStartBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numStartBalance.Location = new System.Drawing.Point(122, 50);
            this.numStartBalance.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numStartBalance.Name = "numStartBalance";
            this.numStartBalance.Size = new System.Drawing.Size(104, 26);
            this.numStartBalance.TabIndex = 3;
            // 
            // lblVacations
            // 
            this.lblVacations.AutoSize = true;
            this.lblVacations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacations.Location = new System.Drawing.Point(9, 92);
            this.lblVacations.Name = "lblVacations";
            this.lblVacations.Size = new System.Drawing.Size(80, 20);
            this.lblVacations.TabIndex = 6;
            this.lblVacations.Text = "Vacations";
            // 
            // grdVacations
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grdVacations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.grdVacations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdVacations.BackgroundColor = System.Drawing.Color.White;
            this.grdVacations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVacations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStartDate,
            this.colEndDate,
            this.colNBOfDays});
            this.grdVacations.Location = new System.Drawing.Point(12, 121);
            this.grdVacations.Name = "grdVacations";
            this.grdVacations.Size = new System.Drawing.Size(474, 293);
            this.grdVacations.TabIndex = 7;
            // 
            // colStartDate
            // 
            dataGridViewCellStyle11.Format = "dd-MM-yyyy";
            dataGridViewCellStyle11.NullValue = null;
            this.colStartDate.DefaultCellStyle = dataGridViewCellStyle11;
            this.colStartDate.HeaderText = "Start Date";
            this.colStartDate.Name = "colStartDate";
            // 
            // colEndDate
            // 
            dataGridViewCellStyle12.Format = "dd-MM-yyyy";
            this.colEndDate.DefaultCellStyle = dataGridViewCellStyle12;
            this.colEndDate.HeaderText = "End Date";
            this.colEndDate.Name = "colEndDate";
            // 
            // colNBOfDays
            // 
            this.colNBOfDays.HeaderText = "Nb of Days";
            this.colNBOfDays.Name = "colNBOfDays";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpToDate.CustomFormat = "dd-MM-yyyy";
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(48, 420);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(104, 26);
            this.dtpToDate.TabIndex = 9;
            // 
            // lblTill
            // 
            this.lblTill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTill.AutoSize = true;
            this.lblTill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTill.Location = new System.Drawing.Point(9, 424);
            this.lblTill.Name = "lblTill";
            this.lblTill.Size = new System.Drawing.Size(27, 20);
            this.lblTill.TabIndex = 8;
            this.lblTill.Text = "Till";
            // 
            // lblBalanceIs
            // 
            this.lblBalanceIs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBalanceIs.AutoSize = true;
            this.lblBalanceIs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceIs.Location = new System.Drawing.Point(158, 424);
            this.lblBalanceIs.Name = "lblBalanceIs";
            this.lblBalanceIs.Size = new System.Drawing.Size(118, 20);
            this.lblBalanceIs.TabIndex = 10;
            this.lblBalanceIs.Text = "Your balance is";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackgroundImage = global::VacationBalance.Properties.Resources.refreshicon;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.Location = new System.Drawing.Point(451, 420);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(35, 26);
            this.btnRefresh.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnRefresh, "Calculate Balance (F5) ");
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // numDaysPerMonth
            // 
            this.numDaysPerMonth.DecimalPlaces = 2;
            this.numDaysPerMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDaysPerMonth.Location = new System.Drawing.Point(382, 20);
            this.numDaysPerMonth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDaysPerMonth.Name = "numDaysPerMonth";
            this.numDaysPerMonth.Size = new System.Drawing.Size(104, 26);
            this.numDaysPerMonth.TabIndex = 13;
            this.numDaysPerMonth.Value = new decimal(new int[] {
            125,
            0,
            0,
            131072});
            // 
            // lblDaysPerMonth
            // 
            this.lblDaysPerMonth.AutoSize = true;
            this.lblDaysPerMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysPerMonth.Location = new System.Drawing.Point(266, 22);
            this.lblDaysPerMonth.Name = "lblDaysPerMonth";
            this.lblDaysPerMonth.Size = new System.Drawing.Size(121, 20);
            this.lblDaysPerMonth.TabIndex = 12;
            this.lblDaysPerMonth.Text = "Days per month";
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblBalance.Location = new System.Drawing.Point(282, 424);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(19, 20);
            this.lblBalance.TabIndex = 14;
            this.lblBalance.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(493, 464);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.numDaysPerMonth);
            this.Controls.Add(this.lblDaysPerMonth);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblBalanceIs);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.lblTill);
            this.Controls.Add(this.grdVacations);
            this.Controls.Add(this.lblVacations);
            this.Controls.Add(this.numStartBalance);
            this.Controls.Add(this.lblStartBalance);
            this.Controls.Add(this.dtpStartBalance);
            this.Controls.Add(this.lblStartDate);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Vacation Balance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numStartBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVacations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDaysPerMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartBalance;
        private System.Windows.Forms.Label lblStartBalance;
        private System.Windows.Forms.NumericUpDown numStartBalance;
        private System.Windows.Forms.Label lblVacations;
        private System.Windows.Forms.DataGridView grdVacations;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNBOfDays;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label lblTill;
        private System.Windows.Forms.Label lblBalanceIs;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.NumericUpDown numDaysPerMonth;
        private System.Windows.Forms.Label lblDaysPerMonth;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

