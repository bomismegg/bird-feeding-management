using DevExpress.XtraScheduler;

namespace DevExpress.DentalClinic.View {
    partial class SchedulerView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler4 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler5 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler6 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerControl = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
            this.xpBindingSource1 = new DevExpress.Xpo.XPBindingSource(this.components);
            this.xpBindingSource2 = new DevExpress.Xpo.XPBindingSource(this.components);
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.whiteningButton = new DevExpress.XtraEditors.SimpleButton();
            this.surgeryButton = new DevExpress.XtraEditors.SimpleButton();
            this.rootCanalButton = new DevExpress.XtraEditors.SimpleButton();
            this.restorationButton = new DevExpress.XtraEditors.SimpleButton();
            this.orthodonticsButton = new DevExpress.XtraEditors.SimpleButton();
            this.implantationButton = new DevExpress.XtraEditors.SimpleButton();
            this.hygieneButton = new DevExpress.XtraEditors.SimpleButton();
            this.diagnosisButton = new DevExpress.XtraEditors.SimpleButton();
            this.prostheticsButton = new DevExpress.XtraEditors.SimpleButton();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerControl
            // 
            this.schedulerControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.schedulerControl.DataStorage = this.schedulerDataStorage1;
            this.schedulerControl.DateNavigationBar.ShowTodayButton = true;
            this.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl.Margin = new System.Windows.Forms.Padding(0);
            this.schedulerControl.Name = "schedulerControl";
            this.schedulerControl.OptionsBehavior.UseAsyncMode = false;
            this.schedulerControl.OptionsCustomization.AllowAppointmentDelete = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl.OptionsCustomization.AllowAppointmentDrag = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl.OptionsCustomization.AllowAppointmentResize = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl.Size = new System.Drawing.Size(1099, 614);
            this.schedulerControl.Start = new System.DateTime(2019, 10, 7, 0, 0, 0, 0);
            this.schedulerControl.TabIndex = 0;
            this.schedulerControl.Text = "schedulerControl";
            this.schedulerControl.Views.AgendaView.Enabled = false;
            this.schedulerControl.Views.DayView.DayCount = 3;
            this.schedulerControl.Views.DayView.ShowWorkTimeOnly = true;
            this.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler4);
            this.schedulerControl.Views.FullWeekView.Enabled = true;
            this.schedulerControl.Views.FullWeekView.ShowWorkTimeOnly = true;
            this.schedulerControl.Views.FullWeekView.TimeRulers.Add(timeRuler5);
            this.schedulerControl.Views.GanttView.Enabled = false;
            this.schedulerControl.Views.MonthView.AppointmentDisplayOptions.EndTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never;
            this.schedulerControl.Views.MonthView.AppointmentDisplayOptions.StartTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never;
            this.schedulerControl.Views.TimelineView.AppointmentDisplayOptions.EndTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never;
            this.schedulerControl.Views.TimelineView.AppointmentDisplayOptions.StartTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never;
            this.schedulerControl.Views.WeekView.Enabled = false;
            this.schedulerControl.Views.WorkWeekView.ShowWorkTimeOnly = true;
            this.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler6);
            this.schedulerControl.Views.YearView.Enabled = false;
            this.schedulerControl.Views.YearView.UseOptimizedScrolling = false;
            this.schedulerControl.PopupMenuShowing += new DevExpress.XtraScheduler.PopupMenuShowingEventHandler(this.OnSchedulerControlPopupMenuShowing);
            this.schedulerControl.AppointmentFlyoutShowing += new DevExpress.XtraScheduler.AppointmentFlyoutShowingEventHandler(this.OnAppointmentFlyoutShowing);
            // 
            // schedulerDataStorage1
            // 
            // 
            // 
            // 
            this.schedulerDataStorage1.AppointmentDependencies.AutoReload = false;
            // 
            // 
            // 
            this.schedulerDataStorage1.Appointments.DataSource = this.xpBindingSource1;
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(0, "None", "&None", System.Drawing.SystemColors.Window);
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(1, "Important", "&Important", System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(2, "Business", "&Business", System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(3, "Personal", "&Personal", System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(4, "Vacation", "&Vacation", System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(5, "Must Attend", "Must &Attend", System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(6, "Travel Required", "&Travel Required", System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(7, "Needs Preparation", "&Needs Preparation", System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(8, "Birthday", "&Birthday", System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(9, "Anniversary", "&Anniversary", System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(10, "Phone Call", "Phone &Call", System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))));
            this.schedulerDataStorage1.Appointments.Mappings.AppointmentId = "Oid";
            this.schedulerDataStorage1.Appointments.Mappings.Description = "Comment";
            this.schedulerDataStorage1.Appointments.Mappings.End = "EndDate";
            this.schedulerDataStorage1.Appointments.Mappings.Label = "ProcedureGroup";
            this.schedulerDataStorage1.Appointments.Mappings.ResourceId = "Doctor!Key";
            this.schedulerDataStorage1.Appointments.Mappings.Start = "Date";
            this.schedulerDataStorage1.Appointments.Mappings.Status = "ProcedureGroup";
            this.schedulerDataStorage1.Appointments.Mappings.Subject = "Patient.FullName";
            // 
            // 
            // 
            this.schedulerDataStorage1.Resources.DataSource = this.xpBindingSource2;
            this.schedulerDataStorage1.Resources.Mappings.Caption = "FullName";
            this.schedulerDataStorage1.Resources.Mappings.Id = "Oid";
            this.schedulerDataStorage1.FilterAppointment += new DevExpress.XtraScheduler.PersistentObjectCancelEventHandler(this.OnFilterAppointment);
            // 
            // xpBindingSource1
            // 
            this.xpBindingSource1.ObjectType = typeof(DevExpress.DentalClinic.Model.Appointment);
            // 
            // xpBindingSource2
            // 
            this.xpBindingSource2.ObjectType = typeof(DevExpress.DentalClinic.Model.Doctor);
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.whiteningButton);
            this.tablePanel1.Controls.Add(this.surgeryButton);
            this.tablePanel1.Controls.Add(this.rootCanalButton);
            this.tablePanel1.Controls.Add(this.restorationButton);
            this.tablePanel1.Controls.Add(this.orthodonticsButton);
            this.tablePanel1.Controls.Add(this.implantationButton);
            this.tablePanel1.Controls.Add(this.hygieneButton);
            this.tablePanel1.Controls.Add(this.diagnosisButton);
            this.tablePanel1.Controls.Add(this.prostheticsButton);
            this.tablePanel1.Controls.Add(this.simpleButton1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tablePanel1.Location = new System.Drawing.Point(0, 615);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Padding = new System.Windows.Forms.Padding(2, 0, 15, 0);
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1099, 75);
            this.tablePanel1.TabIndex = 1;
            this.tablePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tablePanel1_Paint);
            // 
            // whiteningButton
            // 
            this.tablePanel1.SetColumn(this.whiteningButton, 8);
            this.whiteningButton.Location = new System.Drawing.Point(880, 15);
            this.whiteningButton.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.whiteningButton.Name = "whiteningButton";
            this.tablePanel1.SetRow(this.whiteningButton, 0);
            this.whiteningButton.Size = new System.Drawing.Size(96, 44);
            this.whiteningButton.TabIndex = 8;
            this.whiteningButton.Text = "Surgery";
            // 
            // surgeryButton
            // 
            this.tablePanel1.SetColumn(this.surgeryButton, 7);
            this.surgeryButton.Location = new System.Drawing.Point(771, 15);
            this.surgeryButton.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.surgeryButton.Name = "surgeryButton";
            this.tablePanel1.SetRow(this.surgeryButton, 0);
            this.surgeryButton.Size = new System.Drawing.Size(96, 44);
            this.surgeryButton.TabIndex = 7;
            this.surgeryButton.Text = "Orthodontics";
            // 
            // rootCanalButton
            // 
            this.tablePanel1.SetColumn(this.rootCanalButton, 6);
            this.rootCanalButton.Location = new System.Drawing.Point(663, 15);
            this.rootCanalButton.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.rootCanalButton.Name = "rootCanalButton";
            this.tablePanel1.SetRow(this.rootCanalButton, 0);
            this.rootCanalButton.Size = new System.Drawing.Size(96, 44);
            this.rootCanalButton.TabIndex = 6;
            this.rootCanalButton.Text = "Implantation";
            // 
            // restorationButton
            // 
            this.tablePanel1.SetColumn(this.restorationButton, 5);
            this.restorationButton.Location = new System.Drawing.Point(555, 15);
            this.restorationButton.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.restorationButton.Name = "restorationButton";
            this.tablePanel1.SetRow(this.restorationButton, 0);
            this.restorationButton.Size = new System.Drawing.Size(96, 44);
            this.restorationButton.TabIndex = 5;
            this.restorationButton.Text = "Prosthetics";
            // 
            // orthodonticsButton
            // 
            this.tablePanel1.SetColumn(this.orthodonticsButton, 3);
            this.orthodonticsButton.Location = new System.Drawing.Point(339, 15);
            this.orthodonticsButton.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.orthodonticsButton.Name = "orthodonticsButton";
            this.tablePanel1.SetRow(this.orthodonticsButton, 0);
            this.orthodonticsButton.Size = new System.Drawing.Size(96, 44);
            this.orthodonticsButton.TabIndex = 3;
            this.orthodonticsButton.Text = "Hygiene";
            // 
            // implantationButton
            // 
            this.tablePanel1.SetColumn(this.implantationButton, 2);
            this.implantationButton.Location = new System.Drawing.Point(230, 15);
            this.implantationButton.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.implantationButton.Name = "implantationButton";
            this.tablePanel1.SetRow(this.implantationButton, 0);
            this.implantationButton.Size = new System.Drawing.Size(96, 44);
            this.implantationButton.TabIndex = 2;
            this.implantationButton.Text = "Root canal";
            // 
            // hygieneButton
            // 
            this.tablePanel1.SetColumn(this.hygieneButton, 1);
            this.hygieneButton.Location = new System.Drawing.Point(122, 15);
            this.hygieneButton.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.hygieneButton.Name = "hygieneButton";
            this.tablePanel1.SetRow(this.hygieneButton, 0);
            this.hygieneButton.Size = new System.Drawing.Size(96, 44);
            this.hygieneButton.TabIndex = 1;
            this.hygieneButton.Text = "Restoration";
            // 
            // diagnosisButton
            // 
            this.tablePanel1.SetColumn(this.diagnosisButton, 0);
            this.diagnosisButton.Location = new System.Drawing.Point(14, 15);
            this.diagnosisButton.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.diagnosisButton.Name = "diagnosisButton";
            this.tablePanel1.SetRow(this.diagnosisButton, 0);
            this.diagnosisButton.Size = new System.Drawing.Size(96, 44);
            this.diagnosisButton.TabIndex = 0;
            this.diagnosisButton.Text = "Diagnosis";
            // 
            // prostheticsButton
            // 
            this.tablePanel1.SetColumn(this.prostheticsButton, 4);
            this.prostheticsButton.Location = new System.Drawing.Point(447, 15);
            this.prostheticsButton.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.prostheticsButton.Name = "prostheticsButton";
            this.tablePanel1.SetRow(this.prostheticsButton, 0);
            this.prostheticsButton.Size = new System.Drawing.Size(96, 44);
            this.prostheticsButton.TabIndex = 4;
            this.prostheticsButton.Text = "Whitening";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separatorControl1.Location = new System.Drawing.Point(0, 614);
            this.separatorControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.separatorControl1.Size = new System.Drawing.Size(1099, 1);
            this.separatorControl1.TabIndex = 2;
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.ViewModelType = typeof(DevExpress.DentalClinic.ViewModel.SchedulerViewModel);
            // 
            // simpleButton1
            // 
            this.tablePanel1.SetColumn(this.simpleButton1, 9);
            this.simpleButton1.Location = new System.Drawing.Point(988, 15);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.tablePanel1.SetRow(this.simpleButton1, 0);
            this.simpleButton1.Size = new System.Drawing.Size(96, 44);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Surgery";
            // 
            // SchedulerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.schedulerControl);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.tablePanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SchedulerView";
            this.Size = new System.Drawing.Size(1099, 690);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraScheduler.SchedulerControl schedulerControl;
        private XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
        private Utils.MVVM.MVVMContext mvvmContext1;
        private Xpo.XPBindingSource xpBindingSource1;
        private Xpo.XPBindingSource xpBindingSource2;
        private Utils.Layout.TablePanel tablePanel1;
        private XtraEditors.SimpleButton whiteningButton;
        private XtraEditors.SimpleButton surgeryButton;
        private XtraEditors.SimpleButton rootCanalButton;
        private XtraEditors.SimpleButton restorationButton;
        private XtraEditors.SimpleButton prostheticsButton;
        private XtraEditors.SimpleButton orthodonticsButton;
        private XtraEditors.SimpleButton implantationButton;
        private XtraEditors.SimpleButton hygieneButton;
        private XtraEditors.SimpleButton diagnosisButton;
        private XtraEditors.SeparatorControl separatorControl1;
        private XtraEditors.SimpleButton simpleButton1;
    }
}
