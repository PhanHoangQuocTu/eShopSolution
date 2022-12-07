namespace Client.View
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barSearch = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSearchControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            this.ribbonPageManagerProducts = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonManagerProductGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonManagerProductGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageCarts = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonCartGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonCartGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageCategories = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonCategoriesGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonCategoriesGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageUsers = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonUsersGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonUsersGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dataGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnBackPage = new DevExpress.XtraEditors.SimpleButton();
            this.btnNextPage = new DevExpress.XtraEditors.SimpleButton();
            this.combPageSize = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl_btnBackPage = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlI_btnNextPage = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.labTotal = new DevExpress.XtraLayout.SimpleLabelItem();
            this.emptySpaceItem10 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.labCombPageSize = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combPageSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_btnBackPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlI_btnNextPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labCombPageSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnAdd,
            this.btnUpdate,
            this.btnDelete,
            this.barSearch});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 300;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageManagerProducts,
            this.ribbonPageCarts,
            this.ribbonPageCategories,
            this.ribbonPageUsers});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemSearchControl1});
            this.ribbon.Size = new System.Drawing.Size(1214, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.SelectedPageChanged += new System.EventHandler(this.ribbon_SelectedPageChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm";
            this.btnAdd.Id = 1;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Sửa";
            this.btnUpdate.Id = 2;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdate_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xoá";
            this.btnDelete.Id = 3;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // barSearch
            // 
            this.barSearch.Caption = "Tìm kiếm";
            this.barSearch.Edit = this.repositoryItemSearchControl1;
            this.barSearch.Id = 7;
            this.barSearch.Name = "barSearch";
            // 
            // repositoryItemSearchControl1
            // 
            this.repositoryItemSearchControl1.AutoHeight = false;
            this.repositoryItemSearchControl1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
            // 
            // ribbonPageManagerProducts
            // 
            this.ribbonPageManagerProducts.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonManagerProductGroup1,
            this.ribbonManagerProductGroup2});
            this.ribbonPageManagerProducts.Name = "ribbonPageManagerProducts";
            this.ribbonPageManagerProducts.Text = "Quản lý điện thoại";
            // 
            // ribbonManagerProductGroup1
            // 
            this.ribbonManagerProductGroup1.ItemLinks.Add(this.btnAdd, true);
            this.ribbonManagerProductGroup1.ItemLinks.Add(this.btnUpdate, true);
            this.ribbonManagerProductGroup1.ItemLinks.Add(this.btnDelete, true);
            this.ribbonManagerProductGroup1.Name = "ribbonManagerProductGroup1";
            // 
            // ribbonManagerProductGroup2
            // 
            this.ribbonManagerProductGroup2.ItemLinks.Add(this.barSearch, true);
            this.ribbonManagerProductGroup2.Name = "ribbonManagerProductGroup2";
            // 
            // ribbonPageCarts
            // 
            this.ribbonPageCarts.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonCartGroup1,
            this.ribbonCartGroup2});
            this.ribbonPageCarts.Name = "ribbonPageCarts";
            this.ribbonPageCarts.Text = "Quản lý giỏ hàng";
            // 
            // ribbonCartGroup1
            // 
            this.ribbonCartGroup1.ItemLinks.Add(this.btnAdd, true);
            this.ribbonCartGroup1.ItemLinks.Add(this.btnUpdate, true);
            this.ribbonCartGroup1.ItemLinks.Add(this.btnDelete, true);
            this.ribbonCartGroup1.Name = "ribbonCartGroup1";
            // 
            // ribbonCartGroup2
            // 
            this.ribbonCartGroup2.ItemLinks.Add(this.barSearch, true);
            this.ribbonCartGroup2.Name = "ribbonCartGroup2";
            // 
            // ribbonPageCategories
            // 
            this.ribbonPageCategories.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonCategoriesGroup1,
            this.ribbonCategoriesGroup2});
            this.ribbonPageCategories.Name = "ribbonPageCategories";
            this.ribbonPageCategories.Text = "Quản lý mặt hàng";
            // 
            // ribbonCategoriesGroup1
            // 
            this.ribbonCategoriesGroup1.ItemLinks.Add(this.btnAdd, true);
            this.ribbonCategoriesGroup1.ItemLinks.Add(this.btnUpdate, true);
            this.ribbonCategoriesGroup1.ItemLinks.Add(this.btnDelete, true);
            this.ribbonCategoriesGroup1.Name = "ribbonCategoriesGroup1";
            // 
            // ribbonCategoriesGroup2
            // 
            this.ribbonCategoriesGroup2.ItemLinks.Add(this.barSearch, true);
            this.ribbonCategoriesGroup2.Name = "ribbonCategoriesGroup2";
            // 
            // ribbonPageUsers
            // 
            this.ribbonPageUsers.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonUsersGroup1,
            this.ribbonUsersGroup2});
            this.ribbonPageUsers.Name = "ribbonPageUsers";
            this.ribbonPageUsers.Text = "Quản lý tài khoản";
            // 
            // ribbonUsersGroup1
            // 
            this.ribbonUsersGroup1.ItemLinks.Add(this.btnAdd, true);
            this.ribbonUsersGroup1.ItemLinks.Add(this.btnUpdate, true);
            this.ribbonUsersGroup1.ItemLinks.Add(this.btnDelete, true);
            this.ribbonUsersGroup1.Name = "ribbonUsersGroup1";
            // 
            // ribbonUsersGroup2
            // 
            this.ribbonUsersGroup2.ItemLinks.Add(this.barSearch, true);
            this.ribbonUsersGroup2.Name = "ribbonUsersGroup2";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 688);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1214, 30);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dataGrid);
            this.layoutControl1.Controls.Add(this.btnBackPage);
            this.layoutControl1.Controls.Add(this.btnNextPage);
            this.layoutControl1.Controls.Add(this.combPageSize);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 193);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1056, 197, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1214, 495);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dataGrid
            // 
            this.dataGrid.Location = new System.Drawing.Point(12, 12);
            this.dataGrid.MainView = this.gridView1;
            this.dataGrid.MenuManager = this.ribbon;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(1190, 431);
            this.dataGrid.TabIndex = 4;
            this.dataGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dataGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            // 
            // btnBackPage
            // 
            this.btnBackPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackPage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBackPage.ImageOptions.Image")));
            this.btnBackPage.Location = new System.Drawing.Point(1112, 447);
            this.btnBackPage.Name = "btnBackPage";
            this.btnBackPage.Size = new System.Drawing.Size(38, 36);
            this.btnBackPage.StyleController = this.layoutControl1;
            this.btnBackPage.TabIndex = 5;
            this.btnBackPage.Click += new System.EventHandler(this.btnBackPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextPage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNextPage.ImageOptions.Image")));
            this.btnNextPage.Location = new System.Drawing.Point(1154, 447);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(38, 36);
            this.btnNextPage.StyleController = this.layoutControl1;
            this.btnNextPage.TabIndex = 6;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // combPageSize
            // 
            this.combPageSize.EditValue = "15";
            this.combPageSize.Location = new System.Drawing.Point(1031, 461);
            this.combPageSize.MenuManager = this.ribbon;
            this.combPageSize.Name = "combPageSize";
            this.combPageSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.combPageSize.Properties.Items.AddRange(new object[] {
            "15",
            "25",
            "50",
            "100"});
            this.combPageSize.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.combPageSize.Size = new System.Drawing.Size(67, 22);
            this.combPageSize.StyleController = this.layoutControl1;
            this.combPageSize.TabIndex = 7;
            this.combPageSize.SelectedValueChanged += new System.EventHandler(this.combPageSize_SelectedValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControl_btnBackPage,
            this.layoutControlI_btnNextPage,
            this.emptySpaceItem3,
            this.labTotal,
            this.emptySpaceItem10,
            this.labCombPageSize,
            this.emptySpaceItem1,
            this.emptySpaceItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1214, 495);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dataGrid;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1194, 435);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControl_btnBackPage
            // 
            this.layoutControl_btnBackPage.Control = this.btnBackPage;
            this.layoutControl_btnBackPage.Location = new System.Drawing.Point(1100, 435);
            this.layoutControl_btnBackPage.Name = "layoutControl_btnBackPage";
            this.layoutControl_btnBackPage.Size = new System.Drawing.Size(42, 40);
            this.layoutControl_btnBackPage.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControl_btnBackPage.TextVisible = false;
            // 
            // layoutControlI_btnNextPage
            // 
            this.layoutControlI_btnNextPage.Control = this.btnNextPage;
            this.layoutControlI_btnNextPage.Location = new System.Drawing.Point(1142, 435);
            this.layoutControlI_btnNextPage.Name = "layoutControlI_btnNextPage";
            this.layoutControlI_btnNextPage.Size = new System.Drawing.Size(42, 40);
            this.layoutControlI_btnNextPage.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlI_btnNextPage.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(1184, 435);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(10, 40);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // labTotal
            // 
            this.labTotal.AllowHotTrack = false;
            this.labTotal.CustomizationFormText = "Tổng số bản ghi:";
            this.labTotal.Location = new System.Drawing.Point(10, 435);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(900, 40);
            this.labTotal.Text = "Tổng số bản ghi:";
            this.labTotal.TextSize = new System.Drawing.Size(97, 16);
            // 
            // emptySpaceItem10
            // 
            this.emptySpaceItem10.AllowHotTrack = false;
            this.emptySpaceItem10.Location = new System.Drawing.Point(0, 435);
            this.emptySpaceItem10.Name = "emptySpaceItem10";
            this.emptySpaceItem10.Size = new System.Drawing.Size(10, 40);
            this.emptySpaceItem10.TextSize = new System.Drawing.Size(0, 0);
            // 
            // labCombPageSize
            // 
            this.labCombPageSize.Control = this.combPageSize;
            this.labCombPageSize.Location = new System.Drawing.Point(910, 449);
            this.labCombPageSize.Name = "labCombPageSize";
            this.labCombPageSize.Size = new System.Drawing.Size(180, 26);
            this.labCombPageSize.Text = "Số bản ghi trang";
            this.labCombPageSize.TextSize = new System.Drawing.Size(97, 16);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(1090, 435);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(10, 40);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(910, 435);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(180, 14);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(10, 342);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(1072, 20);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(1628, 593);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(155, 10);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(1486, 553);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(125, 14);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.Location = new System.Drawing.Point(813, 309);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(68, 14);
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 718);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "BaseForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combPageSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_btnBackPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlI_btnNextPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labCombPageSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageManagerProducts;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonManagerProductGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageCarts;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonCartGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageCategories;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonCategoriesGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageUsers;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonUsersGroup1;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl dataGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarEditItem barSearch;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonManagerProductGroup2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonCartGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonCategoriesGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonUsersGroup2;
        private DevExpress.XtraEditors.SimpleButton btnBackPage;
        private DevExpress.XtraLayout.LayoutControlItem layoutControl_btnBackPage;
        private DevExpress.XtraEditors.SimpleButton btnNextPage;
        private DevExpress.XtraEditors.ComboBoxEdit combPageSize;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlI_btnNextPage;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem labCombPageSize;
        private DevExpress.XtraLayout.SimpleLabelItem labTotal;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem10;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
    }
}