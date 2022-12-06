using Client.Callout;
using Client.Dtos.Product;
using DevExpress.XtraBars;
using System;


namespace Client.View
{
    public partial class AdminForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AdminForm()
        {
            InitializeComponent();

            var aaaa = ribbon.SelectedPage.Name;
        }

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
    }
}