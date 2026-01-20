namespace BTCMS
{
    partial class Search_Bus
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
            this.lblAvailableBusList = new System.Windows.Forms.Label();
            this.lblRouteID = new System.Windows.Forms.Label();
            this.lblJourneyDate = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BusNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnViewSchedule = new System.Windows.Forms.Button();
            this.lblSEARCHBUS = new System.Windows.Forms.Label();
            this.txtRouteID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAvailableBusList
            // 
            this.lblAvailableBusList.AutoSize = true;
            this.lblAvailableBusList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableBusList.Location = new System.Drawing.Point(13, 265);
            this.lblAvailableBusList.Name = "lblAvailableBusList";
            this.lblAvailableBusList.Size = new System.Drawing.Size(180, 30);
            this.lblAvailableBusList.TabIndex = 0;
            this.lblAvailableBusList.Text = "Available Bus List";
            // 
            // lblRouteID
            // 
            this.lblRouteID.AutoSize = true;
            this.lblRouteID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouteID.Location = new System.Drawing.Point(85, 165);
            this.lblRouteID.Name = "lblRouteID";
            this.lblRouteID.Size = new System.Drawing.Size(98, 30);
            this.lblRouteID.TabIndex = 3;
            this.lblRouteID.Text = "Route ID";
            // 
            // lblJourneyDate
            // 
            this.lblJourneyDate.AutoSize = true;
            this.lblJourneyDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJourneyDate.Location = new System.Drawing.Point(48, 215);
            this.lblJourneyDate.Name = "lblJourneyDate";
            this.lblJourneyDate.Size = new System.Drawing.Size(141, 30);
            this.lblJourneyDate.TabIndex = 12;
            this.lblJourneyDate.Text = "Journey Date";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker2.Location = new System.Drawing.Point(200, 215);
            this.dateTimePicker2.MinDate = System.DateTime.Today;
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(320, 31);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BusNumber,
            this.BusName,
            this.Departure,
            this.Arrival,
            this.Fare});
            this.dataGridView2.Location = new System.Drawing.Point(200, 265);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(750, 180);
            this.dataGridView2.TabIndex = 14;
            // 
            // BusNumber
            // 
            this.BusNumber.HeaderText = "Bus Number";
            this.BusNumber.MinimumWidth = 8;
            this.BusNumber.Name = "BusNumber";
            this.BusNumber.Width = 150;
            // 
            // BusName
            // 
            this.BusName.HeaderText = "Bus Name";
            this.BusName.MinimumWidth = 8;
            this.BusName.Name = "BusName";
            this.BusName.Width = 150;
            // 
            // Departure
            // 
            this.Departure.HeaderText = "Departure";
            this.Departure.MinimumWidth = 8;
            this.Departure.Name = "Departure";
            this.Departure.Width = 150;
            // 
            // Arrival
            // 
            this.Arrival.HeaderText = "Arrival";
            this.Arrival.MinimumWidth = 8;
            this.Arrival.Name = "Arrival";
            this.Arrival.Width = 150;
            // 
            // Fare
            // 
            this.Fare.HeaderText = "Fare";
            this.Fare.MinimumWidth = 8;
            this.Fare.Name = "Fare";
            this.Fare.Width = 150;
            // 
            // btnViewSchedule
            // 
            this.btnViewSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnViewSchedule.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSchedule.ForeColor = System.Drawing.Color.White;
            this.btnViewSchedule.Location = new System.Drawing.Point(430, 470);
            this.btnViewSchedule.Name = "btnViewSchedule";
            this.btnViewSchedule.Size = new System.Drawing.Size(180, 50);
            this.btnViewSchedule.TabIndex = 15;
            this.btnViewSchedule.Text = "View Schedule";
            this.btnViewSchedule.UseVisualStyleBackColor = false;
            this.btnViewSchedule.Click += new System.EventHandler(this.btnViewSchedule_Click);
            // 
            // lblSEARCHBUS
            // 
            this.lblSEARCHBUS.AutoSize = true;
            this.lblSEARCHBUS.BackColor = System.Drawing.Color.Lavender;
            this.lblSEARCHBUS.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSEARCHBUS.Location = new System.Drawing.Point(460, 30);
            this.lblSEARCHBUS.Name = "lblSEARCHBUS";
            this.lblSEARCHBUS.Size = new System.Drawing.Size(210, 48);
            this.lblSEARCHBUS.TabIndex = 17;
            this.lblSEARCHBUS.Text = "SEARCH BUS";
            this.lblSEARCHBUS.Click += new System.EventHandler(this.lblSEARCHBUS_Click);
            // 
            // txtRouteID
            // 
            this.txtRouteID.Location = new System.Drawing.Point(200, 165);
            this.txtRouteID.Name = "txtRouteID";
            this.txtRouteID.Size = new System.Drawing.Size(260, 26);
            this.txtRouteID.TabIndex = 18;
            this.txtRouteID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Search_Bus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1000, 580);
            this.Controls.Add(this.txtRouteID);
            this.Controls.Add(this.lblSEARCHBUS);
            this.Controls.Add(this.btnViewSchedule);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.lblJourneyDate);
            this.Controls.Add(this.lblRouteID);
            this.Controls.Add(this.lblAvailableBusList);
            this.Name = "Search_Bus";
            this.Text = "Search_Bus";
            this.Load += new System.EventHandler(this.Search_Bus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAvailableBusList;
        private System.Windows.Forms.Label lblRouteID;
        private System.Windows.Forms.Label lblJourneyDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fare;
        private System.Windows.Forms.Button btnViewSchedule;
        private System.Windows.Forms.Label lblSEARCHBUS;
        private System.Windows.Forms.TextBox txtRouteID;
    }
}