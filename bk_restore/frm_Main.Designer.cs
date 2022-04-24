namespace bk_restore
{
    partial class frm_main
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
        private async System.Threading.Tasks.Task InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.bciRestoreWithTime = new DevExpress.XtraBars.BarCheckItem();
            this.btnDevice = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcBackup = new DevExpress.XtraGrid.GridControl();
            this.cmsBackupRow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bttRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.bttDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.bdsSTTBackup = new System.Windows.Forms.BindingSource(this.components);
            this.tempdbDataSet = new bk_restore.tempdbDataSet();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.position = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbackup_start_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsBackupset = new System.Windows.Forms.BindingSource(this.components);
            this.tbBackupPosition = new DevExpress.XtraEditors.TextEdit();
            this.tbDatabaseName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tePickTime = new DevExpress.XtraEditors.TimeEdit();
            this.dePickDate = new DevExpress.XtraEditors.DateEdit();
            this.lbTimeRestore = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbDeleteOldBackUp = new System.Windows.Forms.CheckBox();
            this.neHuongdan = new DevExpress.XtraEditors.MemoEdit();
            this.databasesTableAdapter = new bk_restore.tempdbDataSetTableAdapters.databasesTableAdapter();
            this.backupsetTableAdapter = new bk_restore.tempdbDataSetTableAdapters.backupsetTableAdapter();
            this.gvDatabases = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Da = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatabase_id1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDatabases = new DevExpress.XtraGrid.GridControl();
            this.cmsDatabase = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bttCreateDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.bttBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.bttDeleteDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.bdsdatabases = new System.Windows.Forms.BindingSource(this.components);
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.bdsDevices = new System.Windows.Forms.BindingSource(this.components);
            this.backup_devicesTableAdapter = new bk_restore.tempdbDataSetTableAdapters.backup_devicesTableAdapter();
            this.bdsRestoreHistory = new System.Windows.Forms.BindingSource(this.components);
            this.sp_BackupTableAdapter = new bk_restore.tempdbDataSetTableAdapters.SP_STT_BACKUPTableAdapter();
            this.restore_historyTableAdapter = new bk_restore.tempdbDataSetTableAdapters.restore_historyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBackup)).BeginInit();
            this.cmsBackupRow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSTTBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBackupset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBackupPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDatabaseName.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tePickTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePickDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePickDate.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neHuongdan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatabases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatabases)).BeginInit();
            this.cmsDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsdatabases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDevices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsRestoreHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnBackup,
            this.btnRestore,
            this.bciRestoreWithTime,
            this.btnDevice,
            this.btnRefresh,
            this.btnExit});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBackup, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRestore, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bciRestoreWithTime, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDevice, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnBackup
            // 
            this.btnBackup.Caption = "Sao lưu";
            this.btnBackup.Id = 0;
            this.btnBackup.ImageOptions.Image = global::bk_restore.Properties.Resources.icons8_cloud_backup_restore_32;
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnRestore
            // 
            this.btnRestore.Caption = "Phục hồi";
            this.btnRestore.Id = 1;
            this.btnRestore.ImageOptions.Image = global::bk_restore.Properties.Resources.icons8_download_from_cloud_32;
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRestore_ItemClickAsync);
            // 
            // bciRestoreWithTime
            // 
            this.bciRestoreWithTime.Caption = "Phục hồi theo thời gian";
            this.bciRestoreWithTime.Id = 2;
            this.bciRestoreWithTime.ImageOptions.Image = global::bk_restore.Properties.Resources.icons8_time_32;
            this.bciRestoreWithTime.Name = "bciRestoreWithTime";
            this.bciRestoreWithTime.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bciRestoreWithTime_CheckedChanged);
            // 
            // btnDevice
            // 
            this.btnDevice.Caption = "Tạo device sao lưu";
            this.btnDevice.Id = 3;
            this.btnDevice.ImageOptions.Image = global::bk_restore.Properties.Resources.icons8_cloud_storage_32;
            this.btnDevice.Name = "btnDevice";
            this.btnDevice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDevice_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Làm mới";
            this.btnRefresh.Id = 4;
            this.btnRefresh.ImageOptions.Image = global::bk_restore.Properties.Resources.icons8_cloud_sync_32;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Thoát";
            this.btnExit.Id = 5;
            this.btnExit.ImageOptions.Image = global::bk_restore.Properties.Resources.icons8_logout_32;
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1306, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 601);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1306, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 561);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1306, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 561);
            // 
            // gcBackup
            // 
            this.gcBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcBackup.ContextMenuStrip = this.cmsBackupRow;
            this.gcBackup.DataSource = this.bdsSTTBackup;
            this.gcBackup.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcBackup.Location = new System.Drawing.Point(316, 91);
            this.gcBackup.MainView = this.gridView2;
            this.gcBackup.MenuManager = this.barManager1;
            this.gcBackup.Name = "gcBackup";
            this.gcBackup.Size = new System.Drawing.Size(978, 331);
            this.gcBackup.TabIndex = 5;
            this.gcBackup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gcBackup.Click += new System.EventHandler(this.gcBackup_Click);
            // 
            // cmsBackupRow
            // 
            this.cmsBackupRow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bttRestore,
            this.bttDelete});
            this.cmsBackupRow.Name = "cmsBackupRow";
            this.cmsBackupRow.Size = new System.Drawing.Size(114, 48);
            // 
            // bttRestore
            // 
            this.bttRestore.Image = global::bk_restore.Properties.Resources.icons8_download_from_cloud_32;
            this.bttRestore.Name = "bttRestore";
            this.bttRestore.Size = new System.Drawing.Size(113, 22);
            this.bttRestore.Text = "Restore";
            this.bttRestore.Click += new System.EventHandler(this.bttRestore_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.Image = global::bk_restore.Properties.Resources.icons8_delete_trash_32;
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(113, 22);
            this.bttDelete.Text = "Delete";
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // bdsSTTBackup
            // 
            this.bdsSTTBackup.DataMember = "SP_STT_BACKUP";
            this.bdsSTTBackup.DataSource = this.tempdbDataSet;
            // 
            // tempdbDataSet
            // 
            this.tempdbDataSet.DataSetName = "tempdbDataSet";
            this.tempdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.position,
            this.colname,
            this.colbackup_start_date,
            this.coluser_name});
            this.gridView2.GridControl = this.gcBackup;
            this.gridView2.Name = "gridView2";
            // 
            // position
            // 
            this.position.Caption = "Bản sao lưu thứ#";
            this.position.FieldName = "position";
            this.position.Name = "position";
            this.position.Visible = true;
            this.position.VisibleIndex = 0;
            // 
            // colname
            // 
            this.colname.Caption = "Diễn giải";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            // 
            // colbackup_start_date
            // 
            this.colbackup_start_date.Caption = "Ngày sao lưu";
            this.colbackup_start_date.FieldName = "backup_start_date";
            this.colbackup_start_date.Name = "colbackup_start_date";
            this.colbackup_start_date.Visible = true;
            this.colbackup_start_date.VisibleIndex = 2;
            // 
            // coluser_name
            // 
            this.coluser_name.Caption = "User sao lưu";
            this.coluser_name.FieldName = "user_name";
            this.coluser_name.Name = "coluser_name";
            this.coluser_name.Visible = true;
            this.coluser_name.VisibleIndex = 3;
            // 
            // bdsBackupset
            // 
            this.bdsBackupset.DataMember = "backupset";
            this.bdsBackupset.DataSource = this.tempdbDataSet;
            // 
            // tbBackupPosition
            // 
            this.tbBackupPosition.Location = new System.Drawing.Point(369, 6);
            this.tbBackupPosition.Name = "tbBackupPosition";
            this.tbBackupPosition.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBackupPosition.Properties.Appearance.Options.UseFont = true;
            this.tbBackupPosition.Properties.ReadOnly = true;
            this.tbBackupPosition.Size = new System.Drawing.Size(50, 24);
            this.tbBackupPosition.TabIndex = 9;
            // 
            // tbDatabaseName
            // 
            this.tbDatabaseName.Location = new System.Drawing.Point(144, 6);
            this.tbDatabaseName.Name = "tbDatabaseName";
            this.tbDatabaseName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDatabaseName.Properties.Appearance.Options.UseFont = true;
            this.tbDatabaseName.Properties.ReadOnly = true;
            this.tbDatabaseName.Size = new System.Drawing.Size(219, 24);
            this.tbDatabaseName.TabIndex = 8;
            this.tbDatabaseName.EditValueChanged += new System.EventHandler(this.txtDatabaseName_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(135, 17);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Tên database phục hồi:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbDatabaseName);
            this.panel1.Controls.Add(this.tbBackupPosition);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Location = new System.Drawing.Point(316, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 44);
            this.panel1.TabIndex = 10;
            // 
            // tePickTime
            // 
            this.tePickTime.EditValue = new System.DateTime(2022, 4, 14, 0, 0, 0, 0);
            this.tePickTime.Location = new System.Drawing.Point(335, 41);
            this.tePickTime.MenuManager = this.barManager1;
            this.tePickTime.Name = "tePickTime";
            this.tePickTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tePickTime.Size = new System.Drawing.Size(106, 20);
            this.tePickTime.TabIndex = 2;
            // 
            // dePickDate
            // 
            this.dePickDate.EditValue = null;
            this.dePickDate.Location = new System.Drawing.Point(189, 41);
            this.dePickDate.MenuManager = this.barManager1;
            this.dePickDate.Name = "dePickDate";
            this.dePickDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dePickDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dePickDate.Size = new System.Drawing.Size(140, 20);
            this.dePickDate.TabIndex = 1;
            // 
            // lbTimeRestore
            // 
            this.lbTimeRestore.AutoSize = true;
            this.lbTimeRestore.Location = new System.Drawing.Point(16, 44);
            this.lbTimeRestore.Name = "lbTimeRestore";
            this.lbTimeRestore.Size = new System.Drawing.Size(172, 13);
            this.lbTimeRestore.TabIndex = 0;
            this.lbTimeRestore.Text = "Ngày giờ phục hồi tới thời điểm đó:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbDeleteOldBackUp);
            this.panel2.Controls.Add(this.neHuongdan);
            this.panel2.Controls.Add(this.tePickTime);
            this.panel2.Controls.Add(this.lbTimeRestore);
            this.panel2.Controls.Add(this.dePickDate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(310, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(996, 220);
            this.panel2.TabIndex = 11;
            // 
            // cbDeleteOldBackUp
            // 
            this.cbDeleteOldBackUp.AutoSize = true;
            this.cbDeleteOldBackUp.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cbDeleteOldBackUp.Location = new System.Drawing.Point(19, 14);
            this.cbDeleteOldBackUp.Name = "cbDeleteOldBackUp";
            this.cbDeleteOldBackUp.Size = new System.Drawing.Size(320, 17);
            this.cbDeleteOldBackUp.TabIndex = 11;
            this.cbDeleteOldBackUp.Text = "Xóa tất cả các bản sao cũ trong File trước khi sao lưu bản mới";
            this.cbDeleteOldBackUp.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cbDeleteOldBackUp.UseVisualStyleBackColor = true;
            // 
            // neHuongdan
            // 
            this.neHuongdan.EditValue = resources.GetString("neHuongdan.EditValue");
            this.neHuongdan.Location = new System.Drawing.Point(19, 73);
            this.neHuongdan.MenuManager = this.barManager1;
            this.neHuongdan.Name = "neHuongdan";
            this.neHuongdan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.neHuongdan.Properties.Appearance.Options.UseFont = true;
            this.neHuongdan.Size = new System.Drawing.Size(422, 89);
            this.neHuongdan.TabIndex = 3;
            // 
            // databasesTableAdapter
            // 
            this.databasesTableAdapter.ClearBeforeFill = true;
            // 
            // backupsetTableAdapter
            // 
            this.backupsetTableAdapter.ClearBeforeFill = true;
            // 
            // gvDatabases
            // 
            this.gvDatabases.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDatabases.Appearance.FocusedRow.Options.UseFont = true;
            this.gvDatabases.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDatabases.Appearance.SelectedRow.Options.UseFont = true;
            this.gvDatabases.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Da,
            this.coldatabase_id1});
            this.gvDatabases.GridControl = this.gcDatabases;
            this.gvDatabases.Name = "gvDatabases";
            this.gvDatabases.OptionsBehavior.Editable = false;
            // 
            // Da
            // 
            this.Da.Caption = "database";
            this.Da.FieldName = "name";
            this.Da.Name = "Da";
            this.Da.Visible = true;
            this.Da.VisibleIndex = 0;
            // 
            // coldatabase_id1
            // 
            this.coldatabase_id1.FieldName = "database_id";
            this.coldatabase_id1.Name = "coldatabase_id1";
            // 
            // gcDatabases
            // 
            this.gcDatabases.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gcDatabases.ContextMenuStrip = this.cmsDatabase;
            this.gcDatabases.DataSource = this.bdsdatabases;
            this.gcDatabases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDatabases.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcDatabases.Location = new System.Drawing.Point(0, 0);
            this.gcDatabases.MainView = this.gvDatabases;
            this.gcDatabases.Name = "gcDatabases";
            this.gcDatabases.Size = new System.Drawing.Size(310, 561);
            this.gcDatabases.TabIndex = 6;
            this.gcDatabases.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDatabases});
            this.gcDatabases.Click += new System.EventHandler(this.gcDatabases_Click);
            // 
            // cmsDatabase
            // 
            this.cmsDatabase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bttCreateDevice,
            this.bttBackup,
            this.bttDeleteDevice});
            this.cmsDatabase.Name = "cmsDatabase";
            this.cmsDatabase.Size = new System.Drawing.Size(132, 70);
            this.cmsDatabase.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // bttCreateDevice
            // 
            this.bttCreateDevice.Image = global::bk_restore.Properties.Resources.icons8_cloud_storage_32;
            this.bttCreateDevice.Name = "bttCreateDevice";
            this.bttCreateDevice.Size = new System.Drawing.Size(131, 22);
            this.bttCreateDevice.Text = "Tạo device";
            this.bttCreateDevice.Click += new System.EventHandler(this.bttCreateDevice_Click);
            // 
            // bttBackup
            // 
            this.bttBackup.Image = global::bk_restore.Properties.Resources.icons8_cloud_backup_restore_32;
            this.bttBackup.Name = "bttBackup";
            this.bttBackup.Size = new System.Drawing.Size(131, 22);
            this.bttBackup.Text = "Sao lưu";
            this.bttBackup.Click += new System.EventHandler(this.bttBackup_Click);
            // 
            // bttDeleteDevice
            // 
            this.bttDeleteDevice.Image = global::bk_restore.Properties.Resources.icons8_delete_trash_32;
            this.bttDeleteDevice.Name = "bttDeleteDevice";
            this.bttDeleteDevice.Size = new System.Drawing.Size(131, 22);
            this.bttDeleteDevice.Text = "Xóa device";
            this.bttDeleteDevice.Click += new System.EventHandler(this.bttDeleteDevice_Click);
            // 
            // bdsdatabases
            // 
            this.bdsdatabases.DataMember = "databases";
            this.bdsdatabases.DataSource = this.tempdbDataSet;
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridSplitContainer1.Grid = this.gcDatabases;
            this.gridSplitContainer1.Location = new System.Drawing.Point(0, 40);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.gcDatabases);
            this.gridSplitContainer1.Size = new System.Drawing.Size(310, 561);
            this.gridSplitContainer1.TabIndex = 16;
            // 
            // bdsDevices
            // 
            this.bdsDevices.DataMember = "backup_devices";
            this.bdsDevices.DataSource = this.tempdbDataSet;
            // 
            // backup_devicesTableAdapter
            // 
            this.backup_devicesTableAdapter.ClearBeforeFill = true;
            // 
            // bdsRestoreHistory
            // 
            this.bdsRestoreHistory.DataMember = "restore_history";
            this.bdsRestoreHistory.DataSource = this.tempdbDataSet;
            // 
            // sp_BackupTableAdapter
            // 
            this.sp_BackupTableAdapter.ClearBeforeFill = true;
            // 
            // restore_historyTableAdapter
            // 
            this.restore_historyTableAdapter.ClearBeforeFill = true;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 601);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridSplitContainer1);
            this.Controls.Add(this.gcBackup);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frm_main";
            this.Text = "Backup Restore Database";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBackup)).EndInit();
            this.cmsBackupRow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsSTTBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBackupset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBackupPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDatabaseName.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tePickTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePickDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePickDate.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neHuongdan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatabases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatabases)).EndInit();
            this.cmsDatabase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsdatabases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsDevices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsRestoreHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnBackup;
        private DevExpress.XtraBars.BarButtonItem btnRestore;
        private DevExpress.XtraBars.BarCheckItem bciRestoreWithTime;
        private DevExpress.XtraBars.BarButtonItem btnDevice;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit tbDatabaseName;
        private DevExpress.XtraEditors.TextEdit tbBackupPosition;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcBackup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbDeleteOldBackUp;
        private DevExpress.XtraEditors.MemoEdit neHuongdan;
        private DevExpress.XtraEditors.TimeEdit tePickTime;
        private DevExpress.XtraEditors.DateEdit dePickDate;
        private System.Windows.Forms.Label lbTimeRestore;
        private tempdbDataSet tempdbDataSet;
        private tempdbDataSetTableAdapters.databasesTableAdapter databasesTableAdapter;
        private System.Windows.Forms.BindingSource bdsBackupset;
        private tempdbDataSetTableAdapters.backupsetTableAdapter backupsetTableAdapter;
        private DevExpress.XtraGrid.GridControl gcDatabases;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDatabases;
        private DevExpress.XtraGrid.Columns.GridColumn Da;
        private DevExpress.XtraGrid.Columns.GridColumn coldatabase_id1;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private System.Windows.Forms.BindingSource bdsDevices;
        private tempdbDataSetTableAdapters.backup_devicesTableAdapter backup_devicesTableAdapter;
        private System.Windows.Forms.BindingSource bdsdatabases;
        private DevExpress.XtraGrid.Columns.GridColumn position;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colbackup_start_date;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_name;
        private System.Windows.Forms.BindingSource bdsRestoreHistory;
        private System.Windows.Forms.BindingSource bdsSTTBackup;
        private tempdbDataSetTableAdapters.SP_STT_BACKUPTableAdapter sp_BackupTableAdapter;
        private tempdbDataSetTableAdapters.restore_historyTableAdapter restore_historyTableAdapter;
        private System.Windows.Forms.ContextMenuStrip cmsDatabase;
        private System.Windows.Forms.ToolStripMenuItem bttCreateDevice;
        private System.Windows.Forms.ToolStripMenuItem bttBackup;
        private System.Windows.Forms.ContextMenuStrip cmsBackupRow;
        private System.Windows.Forms.ToolStripMenuItem bttRestore;
        private System.Windows.Forms.ToolStripMenuItem bttDelete;
        private System.Windows.Forms.ToolStripMenuItem bttDeleteDevice;
    }
}

