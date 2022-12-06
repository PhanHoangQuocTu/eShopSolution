using Client.Callout;
using Client.Dtos.Common;
using Client.Dtos.Product;
using Client.Dtos.UserDto;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.View
{
    public partial class AdminForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public int _pageIndex = 1;
        public int _pageSize = 50;
        public object _dataRow = null;

        public AdminForm()
        {
            InitializeComponent();

            _= LoadDataGrid();
        }

        private void Clear()
        {
            labTotal.Enabled = false;
            labCombPageSize.Enabled = false;
            btnBackPage.Enabled = false;
            btnNextPage.Enabled = false;

            _pageIndex = 1;
            _pageSize = 50;
            dataGrid.DataSource = null;
            gridView1.Columns.Clear();
            _dataRow = null;
        }

        private async Task LoadDataGrid()
        {
            if (ribbon.SelectedPage == ribbonPageManagerProducts)
            {
                var result = await new ProductsService().GetProducts(new GetManageProductPagingRequest()
                {
                    PageIndex = _pageIndex,
                    PageSize = _pageSize,
                    Keyword = String.Empty,
                });

                dataGrid.DataSource = result.Items;
                _dataRow = result.Items.Count > 0 ? result.Items[0] : null;
                SetPaging(result.TotalRecords, result.PageIndex, result.PageSize);
            }

            if (ribbon.SelectedPage == ribbonPageCarts)
            {

            }

            if (ribbon.SelectedPage == ribbonPageCategories)
            {
                var result = await new CategoriesService().GetCategories("vi");
                dataGrid.DataSource = result;
                gridView1.Columns[0].Visible = false;
            }

            if (ribbon.SelectedPage == ribbonPageUsers)
            {
                var result = await new UsersService().GetPagingUsers(new GetUserPagingRequest()
                {
                    PageIndex = _pageIndex,
                    PageSize = _pageSize,
                    Keyword = String.Empty,
                });

                dataGrid.DataSource = result.ResultObj.Items;
                _dataRow = result.ResultObj.Items.Count > 0 ? result.ResultObj.Items[0] : null;
                SetPaging(result.ResultObj.TotalRecords, result.ResultObj.PageIndex, result.ResultObj.PageSize);
            }
        }

        private void SetPaging(int totalRecords, int pageIndex, int pageSize)
        {
            labTotal.Enabled = true;
            labCombPageSize.Enabled = true;
            btnBackPage.Enabled = true;
            btnNextPage.Enabled = true;

            gridView1.Columns[0].Visible = false;
            labTotal.Text = "Tổng số bản ghi: " + totalRecords.ToString();
            labCombPageSize.Text = "Số bản ghi trang " + pageIndex;
            combPageSize.SelectedItem = pageSize;
        }

        private async void ribbon_SelectedPageChanged(object sender, EventArgs e)
        {
            Clear();
            await LoadDataGrid();
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e) => _dataRow = (sender as GridView).FocusedRowObject;

        private async void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            var a = new ProductsService();
            var result = await a.GetProducts(new GetManageProductPagingRequest()
            {
                PageIndex = 1,
                PageSize = 50,
                Keyword = String.Empty,
            });
        }

        private void btnUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private async void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ribbon.SelectedPage == ribbonPageManagerProducts)
            {
                var result = await new ProductsService().DeleteProduct((_dataRow as ProductVm).Id);
            }

            if (ribbon.SelectedPage == ribbonPageUsers)
            {
                var result = await new UsersService().DeleteUser((_dataRow as UserVm).Id);
            }

            await LoadDataGrid();
        }

        private async void btnNextPage_Click(object sender, EventArgs e)
        {
            _pageIndex ++;
            await LoadDataGrid();
        }

        private async void btnBackPage_Click(object sender, EventArgs e)
        {
            if (_pageIndex > 0)
            {
                _pageIndex--;
                await LoadDataGrid();
            }    
        }
    }
}