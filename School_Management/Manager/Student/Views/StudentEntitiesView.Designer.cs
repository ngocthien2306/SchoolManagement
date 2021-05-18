namespace School_Management.Manager.Student.Views.StudentEntitiesView {
    partial class StudentEntitiesView {
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
			this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager();
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView();
			this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
			this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.ribbonPageGroupNavigation = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.barSubItemNavigation = new DevExpress.XtraBars.BarSubItem();
			this.skinRibbonGalleryBarItem = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
			this.officeNavigationBar = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
						this.barSubItemTables = new DevExpress.XtraBars.BarSubItem();
			this.barSubItemViews = new DevExpress.XtraBars.BarSubItem();
									this.navigationBarItemAdd_StudentCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemAdd_StudentCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemCourseCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemCourseCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemLoginCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemLoginCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemNameCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemNameCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemsysdiagramCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemsysdiagramCollectionView = new DevExpress.XtraBars.BarButtonItem();
									this.navigationBarItemScoreCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem(); 
			this.barButtonItemScoreCollectionView = new DevExpress.XtraBars.BarButtonItem();
			            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar)).BeginInit();
            this.SuspendLayout();
			// 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.MaxItemId = 14;
            this.ribbonControl.Name = "ribbonControl";
			this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {this.skinRibbonGalleryBarItem, this.barSubItemNavigation ,this.barSubItemTables,this.barSubItemViews});
			this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
			this.ribbonControl.StatusBar = this.ribbonStatusBar;
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
			this.ribbonPageGroupNavigation,
            this.ribbonPageGroup});
			this.ribbonPage.MergeOrder = -1;
            this.ribbonPage.Name = "ribbonPage";
            this.ribbonPage.Text = "View";
			// 
            // ribbonPageGroupNavigation
            // 
            this.ribbonPageGroupNavigation.ItemLinks.Add(this.barSubItemNavigation);
            this.ribbonPageGroupNavigation.Name = "ribbonPageGroupNavigation";
            this.ribbonPageGroupNavigation.Text = "Module";
			 // 
            // barSubItemNavigation
            // 
            this.barSubItemNavigation.Caption = "Navigation";
            this.barSubItemNavigation.ImageUri.Uri = "NavigationBar";
            this.barSubItemNavigation.Name = "barSubItemNavigation";
						// 
            // barSubItemTables
            // 
            this.barSubItemTables.Caption = "Tables";
            this.barSubItemTables.Name = "barSubItemTables";
			// 
            // barSubItemViews
            // 
            this.barSubItemViews.Caption = "Views";
            this.barSubItemViews.Name = "barSubItemViews";
			this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemTables));
			this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemViews));
			            // 
            // ribbonPageGroup
            // 
            this.ribbonPageGroup.AllowTextClipping = false;
			this.ribbonPageGroup.ItemLinks.Add(this.skinRibbonGalleryBarItem);
            this.ribbonPageGroup.Name = "ribbonPageGroup";
            this.ribbonPageGroup.ShowCaptionButton = false;
            this.ribbonPageGroup.Text = "Appearance";
			// 
            // ribbonStatusBar
            // 
			this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
			// 
            // officeNavigationBar
            //
			this.officeNavigationBar.Dock = System.Windows.Forms.DockStyle.Bottom; 
            this.officeNavigationBar.Items.AddRange(new DevExpress.XtraBars.Navigation.NavigationBarItem[] {
            			this.navigationBarItemAdd_StudentCollectionView,
						this.navigationBarItemCourseCollectionView,
						this.navigationBarItemLoginCollectionView,
						this.navigationBarItemNameCollectionView,
						this.navigationBarItemsysdiagramCollectionView,
									this.navigationBarItemScoreCollectionView,
						
			});
            this.officeNavigationBar.Name = "officeNavigationBar";
            this.officeNavigationBar.Text = "officeNavigationBar";
						// 
            // navigationBarItemAdd_StudentCollectionView
            // 
			this.navigationBarItemAdd_StudentCollectionView.Name = "navigationBarItemAdd_StudentCollectionView";
            this.navigationBarItemAdd_StudentCollectionView.Text = "Add Student";
			// 
            // barButtonItemAdd_StudentCollectionView
            // 
			this.barButtonItemAdd_StudentCollectionView.Name = "barButtonItemAdd_StudentCollectionView";
            this.barButtonItemAdd_StudentCollectionView.Caption = "Add Student";
							this.barSubItemTables.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAdd_StudentCollectionView));
									
						// 
            // navigationBarItemCourseCollectionView
            // 
			this.navigationBarItemCourseCollectionView.Name = "navigationBarItemCourseCollectionView";
            this.navigationBarItemCourseCollectionView.Text = "Courses";
			// 
            // barButtonItemCourseCollectionView
            // 
			this.barButtonItemCourseCollectionView.Name = "barButtonItemCourseCollectionView";
            this.barButtonItemCourseCollectionView.Caption = "Courses";
							this.barSubItemTables.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemCourseCollectionView));
									
						// 
            // navigationBarItemLoginCollectionView
            // 
			this.navigationBarItemLoginCollectionView.Name = "navigationBarItemLoginCollectionView";
            this.navigationBarItemLoginCollectionView.Text = "Logins";
			// 
            // barButtonItemLoginCollectionView
            // 
			this.barButtonItemLoginCollectionView.Name = "barButtonItemLoginCollectionView";
            this.barButtonItemLoginCollectionView.Caption = "Logins";
							this.barSubItemTables.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemLoginCollectionView));
									
						// 
            // navigationBarItemNameCollectionView
            // 
			this.navigationBarItemNameCollectionView.Name = "navigationBarItemNameCollectionView";
            this.navigationBarItemNameCollectionView.Text = "Names";
			// 
            // barButtonItemNameCollectionView
            // 
			this.barButtonItemNameCollectionView.Name = "barButtonItemNameCollectionView";
            this.barButtonItemNameCollectionView.Caption = "Names";
							this.barSubItemTables.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemNameCollectionView));
									
						// 
            // navigationBarItemsysdiagramCollectionView
            // 
			this.navigationBarItemsysdiagramCollectionView.Name = "navigationBarItemsysdiagramCollectionView";
            this.navigationBarItemsysdiagramCollectionView.Text = "sysdiagrams";
			// 
            // barButtonItemsysdiagramCollectionView
            // 
			this.barButtonItemsysdiagramCollectionView.Name = "barButtonItemsysdiagramCollectionView";
            this.barButtonItemsysdiagramCollectionView.Caption = "sysdiagrams";
							this.barSubItemTables.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemsysdiagramCollectionView));
									
									// 
            // navigationBarItemScoreCollectionView
            // 
			this.navigationBarItemScoreCollectionView.Name = "navigationBarItemScoreCollectionView";
            this.navigationBarItemScoreCollectionView.Text = "Scores";
			// 
            // barButtonItemScoreCollectionView
            // 
			this.barButtonItemScoreCollectionView.Name = "barButtonItemScoreCollectionView";
            this.barButtonItemScoreCollectionView.Caption = "Scores";
						this.barSubItemViews.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemScoreCollectionView));
										
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(School_Management.Manager.Student.ViewModels.StudentEntitiesViewModel);
			 // 
            // navigationFrame
            // 
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.navigationFrame.Text = "navigationFrame";
			// 
            // StudentEntitiesView
            // 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.officeNavigationBar);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "StudentEntitiesView";
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
		}
		
        #endregion

		private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup;
		private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupNavigation;
		private DevExpress.XtraBars.BarSubItem barSubItemNavigation;
		private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem;
		private DevExpress.XtraBars.Navigation.OfficeNavigationBar officeNavigationBar;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame; 
				private DevExpress.XtraBars.BarSubItem barSubItemTables;
		private DevExpress.XtraBars.BarSubItem barSubItemViews;
						private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemAdd_StudentCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemAdd_StudentCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemCourseCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemCourseCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemLoginCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemLoginCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemNameCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemNameCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemsysdiagramCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemsysdiagramCollectionView;
						private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemScoreCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemScoreCollectionView;
			}
}
