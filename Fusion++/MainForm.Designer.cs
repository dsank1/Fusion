﻿namespace FusionPlusPlus
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
			DevExpress.XtraEditors.RangeControlRange rangeControlRange1 = new DevExpress.XtraEditors.RangeControlRange();
			DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
			DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
			DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
			DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.rangeData = new DevExpress.XtraEditors.RangeControl();
			this.dateTimeChartRangeControlClient1 = new DevExpress.XtraEditors.DateTimeChartRangeControlClient();
			this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridLog = new DevExpress.XtraGrid.GridControl();
			this.viewLog = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colTimeStamp = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAppName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDisplayName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.btnRecord = new DevExpress.XtraEditors.SimpleButton();
			this.btnImport = new DevExpress.XtraEditors.DropDownButton();
			this.popupLastSessions = new DevExpress.XtraBars.PopupMenu(this.components);
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.btnExport = new DevExpress.XtraEditors.SimpleButton();
			this.toolbarFormControl1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
			this.toolbarFormManager1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
			this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
			this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
			this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
			this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
			this.biTheme = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			((System.ComponentModel.ISupportInitialize)(this.rangeData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridLog)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.viewLog)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popupLastSessions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// rangeData
			// 
			this.rangeData.AllowDrop = true;
			this.rangeData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rangeData.Client = this.dateTimeChartRangeControlClient1;
			this.rangeData.Location = new System.Drawing.Point(127, 40);
			this.rangeData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rangeData.Name = "rangeData";
			rangeControlRange1.Maximum = new System.DateTime(2018, 7, 5, 0, 0, 0, 0);
			rangeControlRange1.Minimum = new System.DateTime(2018, 6, 26, 0, 0, 0, 0);
			rangeControlRange1.Owner = this.rangeData;
			this.rangeData.SelectedRange = rangeControlRange1;
			this.rangeData.SelectionType = DevExpress.XtraEditors.RangeControlSelectionType.ThumbAndFlag;
			this.rangeData.Size = new System.Drawing.Size(1125, 98);
			this.rangeData.TabIndex = 2;
			this.rangeData.Text = "rangeControl1";
			this.rangeData.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
			this.rangeData.RangeChanged += new DevExpress.XtraEditors.RangeChangedEventHandler(this.rangeData_RangeChanged);
			this.rangeData.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
			this.rangeData.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
			// 
			// colState
			// 
			this.colState.Caption = "State";
			this.colState.FieldName = "AccumulatedState";
			this.colState.Name = "colState";
			this.colState.OptionsColumn.FixedWidth = true;
			this.colState.Visible = true;
			this.colState.VisibleIndex = 1;
			this.colState.Width = 100;
			// 
			// gridLog
			// 
			this.gridLog.AllowDrop = true;
			this.gridLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridLog.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gridLog.Location = new System.Drawing.Point(12, 142);
			this.gridLog.MainView = this.viewLog;
			this.gridLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gridLog.Name = "gridLog";
			this.gridLog.Size = new System.Drawing.Size(1240, 593);
			this.gridLog.TabIndex = 0;
			this.gridLog.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewLog});
			this.gridLog.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
			this.gridLog.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
			// 
			// viewLog
			// 
			this.viewLog.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTimeStamp,
            this.colState,
            this.colAppName,
            this.colDisplayName});
			this.viewLog.DetailHeight = 284;
			gridFormatRule1.Column = this.colState;
			gridFormatRule1.Name = "Highlight Warnings";
			formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
			formatConditionRuleValue1.PredefinedName = "Yellow Fill, Yellow Text";
			formatConditionRuleValue1.Value1 = FusionPlusPlus.Model.LogItem.State.Warning;
			gridFormatRule1.Rule = formatConditionRuleValue1;
			gridFormatRule2.Column = this.colState;
			gridFormatRule2.Name = "Highlight Errors";
			formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
			formatConditionRuleValue2.PredefinedName = "Red Fill, Red Text";
			formatConditionRuleValue2.Value1 = FusionPlusPlus.Model.LogItem.State.Error;
			gridFormatRule2.Rule = formatConditionRuleValue2;
			this.viewLog.FormatRules.Add(gridFormatRule1);
			this.viewLog.FormatRules.Add(gridFormatRule2);
			this.viewLog.GridControl = this.gridLog;
			this.viewLog.Name = "viewLog";
			this.viewLog.OptionsBehavior.AllowIncrementalSearch = true;
			this.viewLog.OptionsBehavior.Editable = false;
			this.viewLog.OptionsBehavior.ReadOnly = true;
			this.viewLog.OptionsDetail.EnableMasterViewMode = false;
			this.viewLog.OptionsFind.AlwaysVisible = true;
			this.viewLog.OptionsFind.Behavior = DevExpress.XtraEditors.FindPanelBehavior.Search;
			this.viewLog.OptionsMenu.ShowConditionalFormattingItem = true;
			this.viewLog.OptionsScrollAnnotations.ShowCustomAnnotations = DevExpress.Utils.DefaultBoolean.True;
			this.viewLog.OptionsScrollAnnotations.ShowErrors = DevExpress.Utils.DefaultBoolean.True;
			this.viewLog.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.True;
			this.viewLog.OptionsScrollAnnotations.ShowSelectedRows = DevExpress.Utils.DefaultBoolean.False;
			this.viewLog.OptionsView.ShowGroupPanel = false;
			this.viewLog.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTimeStamp, DevExpress.Data.ColumnSortOrder.Ascending)});
			this.viewLog.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.viewLog_RowClick);
			this.viewLog.CustomScrollAnnotation += new System.EventHandler<DevExpress.XtraGrid.Views.Grid.GridCustomScrollAnnotationsEventArgs>(this.ViewLog_CustomScrollAnnotation);
			// 
			// colTimeStamp
			// 
			this.colTimeStamp.Caption = "Time Stamp";
			this.colTimeStamp.DisplayFormat.FormatString = "G";
			this.colTimeStamp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.colTimeStamp.FieldName = "TimeStampLocal";
			this.colTimeStamp.Name = "colTimeStamp";
			this.colTimeStamp.OptionsColumn.FixedWidth = true;
			this.colTimeStamp.Visible = true;
			this.colTimeStamp.VisibleIndex = 0;
			this.colTimeStamp.Width = 150;
			// 
			// colAppName
			// 
			this.colAppName.FieldName = "AppName";
			this.colAppName.Name = "colAppName";
			this.colAppName.OptionsColumn.FixedWidth = true;
			this.colAppName.Visible = true;
			this.colAppName.VisibleIndex = 2;
			this.colAppName.Width = 200;
			// 
			// colDisplayName
			// 
			this.colDisplayName.FieldName = "DisplayName";
			this.colDisplayName.Name = "colDisplayName";
			this.colDisplayName.Visible = true;
			this.colDisplayName.VisibleIndex = 3;
			this.colDisplayName.Width = 558;
			// 
			// btnRecord
			// 
			this.btnRecord.AllowFocus = false;
			this.btnRecord.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
			this.btnRecord.ImageOptions.SvgImage = global::FusionPlusPlus.Properties.Resources.Capture;
			this.btnRecord.Location = new System.Drawing.Point(12, 40);
			this.btnRecord.Name = "btnRecord";
			this.btnRecord.Size = new System.Drawing.Size(109, 72);
			this.btnRecord.TabIndex = 5;
			this.btnRecord.Text = "Record";
			this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
			// 
			// btnImport
			// 
			this.btnImport.AllowFocus = false;
			this.btnImport.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.SplitButton;
			this.btnImport.DropDownButtonPadding = new System.Windows.Forms.Padding(-4, 0, -4, 0);
			this.btnImport.DropDownControl = this.popupLastSessions;
			this.btnImport.Location = new System.Drawing.Point(12, 113);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(60, 25);
			this.btnImport.TabIndex = 5;
			this.btnImport.Text = "Import";
			this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
			// 
			// popupLastSessions
			// 
			this.popupLastSessions.Manager = this.barManager1;
			this.popupLastSessions.Name = "popupLastSessions";
			this.popupLastSessions.BeforePopup += new System.ComponentModel.CancelEventHandler(this.popupLastSessions_BeforePopup);
			// 
			// barManager1
			// 
			this.barManager1.DockControls.Add(this.barDockControlTop);
			this.barManager1.DockControls.Add(this.barDockControlBottom);
			this.barManager1.DockControls.Add(this.barDockControlLeft);
			this.barManager1.DockControls.Add(this.barDockControlRight);
			this.barManager1.Form = this;
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 27);
			this.barDockControlTop.Manager = this.barManager1;
			this.barDockControlTop.Size = new System.Drawing.Size(1264, 0);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 746);
			this.barDockControlBottom.Manager = this.barManager1;
			this.barDockControlBottom.Size = new System.Drawing.Size(1264, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 27);
			this.barDockControlLeft.Manager = this.barManager1;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 719);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(1264, 27);
			this.barDockControlRight.Manager = this.barManager1;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 719);
			// 
			// btnExport
			// 
			this.btnExport.AllowFocus = false;
			this.btnExport.Location = new System.Drawing.Point(73, 113);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(48, 25);
			this.btnExport.TabIndex = 5;
			this.btnExport.Text = "Export";
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// toolbarFormControl1
			// 
			this.toolbarFormControl1.Location = new System.Drawing.Point(0, 0);
			this.toolbarFormControl1.Manager = this.toolbarFormManager1;
			this.toolbarFormControl1.Name = "toolbarFormControl1";
			this.toolbarFormControl1.Size = new System.Drawing.Size(1264, 27);
			this.toolbarFormControl1.TabIndex = 10;
			this.toolbarFormControl1.TabStop = false;
			this.toolbarFormControl1.TitleItemLinks.Add(this.biTheme);
			this.toolbarFormControl1.TitleItemLinks.Add(this.barButtonItem1);
			this.toolbarFormControl1.ToolbarForm = this;
			// 
			// toolbarFormManager1
			// 
			this.toolbarFormManager1.DockControls.Add(this.barDockControl1);
			this.toolbarFormManager1.DockControls.Add(this.barDockControl2);
			this.toolbarFormManager1.DockControls.Add(this.barDockControl3);
			this.toolbarFormManager1.DockControls.Add(this.barDockControl4);
			this.toolbarFormManager1.Form = this;
			this.toolbarFormManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.biTheme,
            this.barButtonItem1});
			this.toolbarFormManager1.MaxItemId = 2;
			// 
			// barDockControl1
			// 
			this.barDockControl1.CausesValidation = false;
			this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControl1.Location = new System.Drawing.Point(0, 27);
			this.barDockControl1.Manager = this.toolbarFormManager1;
			this.barDockControl1.Size = new System.Drawing.Size(1264, 0);
			// 
			// barDockControl2
			// 
			this.barDockControl2.CausesValidation = false;
			this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControl2.Location = new System.Drawing.Point(0, 746);
			this.barDockControl2.Manager = this.toolbarFormManager1;
			this.barDockControl2.Size = new System.Drawing.Size(1264, 0);
			// 
			// barDockControl3
			// 
			this.barDockControl3.CausesValidation = false;
			this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControl3.Location = new System.Drawing.Point(0, 27);
			this.barDockControl3.Manager = this.toolbarFormManager1;
			this.barDockControl3.Size = new System.Drawing.Size(0, 719);
			// 
			// barDockControl4
			// 
			this.barDockControl4.CausesValidation = false;
			this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControl4.Location = new System.Drawing.Point(1264, 27);
			this.barDockControl4.Manager = this.toolbarFormManager1;
			this.barDockControl4.Size = new System.Drawing.Size(0, 719);
			// 
			// biTheme
			// 
			this.biTheme.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.biTheme.Id = 0;
			this.biTheme.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("biTheme.ImageOptions.SvgImage")));
			this.biTheme.Name = "biTheme";
			this.biTheme.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			// 
			// barButtonItem1
			// 
			this.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.barButtonItem1.Caption = "@Waescher";
			this.barButtonItem1.Id = 1;
			this.barButtonItem1.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
			this.barButtonItem1.ImageOptions.SvgImage = global::FusionPlusPlus.Properties.Resources.Twitter;
			this.barButtonItem1.Name = "barButtonItem1";
			this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 746);
			this.Controls.Add(this.btnExport);
			this.Controls.Add(this.btnImport);
			this.Controls.Add(this.btnRecord);
			this.Controls.Add(this.gridLog);
			this.Controls.Add(this.rangeData);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Controls.Add(this.barDockControl3);
			this.Controls.Add(this.barDockControl4);
			this.Controls.Add(this.barDockControl2);
			this.Controls.Add(this.barDockControl1);
			this.Controls.Add(this.toolbarFormControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fusion++";
			this.ToolbarFormControl = this.toolbarFormControl1;
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.rangeData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridLog)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.viewLog)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popupLastSessions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridLog;
		private DevExpress.XtraGrid.Views.Grid.GridView viewLog;
		private DevExpress.XtraGrid.Columns.GridColumn colTimeStamp;
		private DevExpress.XtraGrid.Columns.GridColumn colState;
		private DevExpress.XtraGrid.Columns.GridColumn colAppName;
		private DevExpress.XtraGrid.Columns.GridColumn colDisplayName;
		private DevExpress.XtraEditors.RangeControl rangeData;
		private DevExpress.XtraEditors.DateTimeChartRangeControlClient dateTimeChartRangeControlClient1;
		private DevExpress.XtraEditors.SimpleButton btnRecord;
		private DevExpress.XtraEditors.DropDownButton btnImport;
		private DevExpress.XtraEditors.SimpleButton btnExport;
		private DevExpress.XtraBars.PopupMenu popupLastSessions;
		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl toolbarFormControl1;
		private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager1;
		private DevExpress.XtraBars.BarDockControl barDockControl1;
		private DevExpress.XtraBars.BarDockControl barDockControl2;
		private DevExpress.XtraBars.BarDockControl barDockControl3;
		private DevExpress.XtraBars.BarDockControl barDockControl4;
		private DevExpress.XtraBars.BarButtonItem biTheme;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
	}
}

