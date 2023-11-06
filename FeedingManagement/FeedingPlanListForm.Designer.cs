namespace FeedingManagement
{
    partial class FeedingPlanListForm
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
            components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(components);
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            ((System.ComponentModel.ISupportInitialize)schedulerDataStorage1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)schedulerControl1).BeginInit();
            SuspendLayout();
            // 
            // schedulerDataStorage1
            // 
            // 
            // 
            // 
            schedulerDataStorage1.AppointmentDependencies.AutoReload = false;
            // 
            // 
            // 
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(0, "None", "&None", SystemColors.Window);
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(1, "Important", "&Important", Color.FromArgb(255, 194, 190));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(2, "Business", "&Business", Color.FromArgb(168, 213, 255));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(3, "Personal", "&Personal", Color.FromArgb(193, 244, 156));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(4, "Vacation", "&Vacation", Color.FromArgb(243, 228, 199));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(5, "Must Attend", "Must &Attend", Color.FromArgb(244, 206, 147));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(6, "Travel Required", "&Travel Required", Color.FromArgb(199, 244, 255));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(7, "Needs Preparation", "&Needs Preparation", Color.FromArgb(207, 219, 152));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(8, "Birthday", "&Birthday", Color.FromArgb(224, 207, 233));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(9, "Anniversary", "&Anniversary", Color.FromArgb(141, 233, 223));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(10, "Phone Call", "Phone &Call", Color.FromArgb(255, 247, 165));
            // 
            // barManager1
            // 
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new Size(926, 0);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 671);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new Size(926, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 0);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new Size(0, 671);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(926, 0);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new Size(0, 671);
            // 
            // schedulerControl1
            // 
            schedulerControl1.DataStorage = schedulerDataStorage1;
            schedulerControl1.Location = new Point(41, 46);
            schedulerControl1.MenuManager = barManager1;
            schedulerControl1.Name = "schedulerControl1";
            schedulerControl1.Size = new Size(799, 613);
            schedulerControl1.Start = new DateTime(2023, 11, 6, 0, 0, 0, 0);
            schedulerControl1.TabIndex = 5;
            schedulerControl1.Text = "schedulerControl1";
            schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            schedulerControl1.Views.FullWeekView.Enabled = true;
            schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            schedulerControl1.Views.WeekView.Enabled = false;
            schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            schedulerControl1.Views.YearView.UseOptimizedScrolling = false;
            // 
            // FeedingPlanListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 671);
            Controls.Add(schedulerControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "FeedingPlanListForm";
            Text = "FeedingPlanListForm";
            ((System.ComponentModel.ISupportInitialize)schedulerDataStorage1).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)schedulerControl1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
    }
}