using Client.Callout;
using Client.Dtos.Product;
using Client.Enumerates;
using Client.Utills;
using System;
using System.Threading.Tasks;

namespace Client.View
{
    public partial class ProductFrom : DevExpress.XtraEditors.XtraForm
    {
        private StateEnum _state = StateEnum.NONE;
        public object _dataRow = null;

        public ProductFrom()
        {
            _state = BaseForm._instanceBaseForm._state;
            _dataRow = BaseForm._instanceBaseForm._dataRow;

            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_state == StateEnum.INSERT)
                    await InsertData();

                if (_state == StateEnum.UPDATE)
                    await UpdateData();
            }
            catch
            {
                MessageBoxUtil.ShowMessageBox("Error", "Hệ thống tạm thời gián đoạn, vui lòng thử lại sau.", MessageBoxType.Error);
            }
        }
        private async Task InsertData()
        {
            var result = await new ProductsService().CreateProduct(new ProductCreateRequest()
            {
                
            });

            AfterCommitAsync(result);
        }

        private async Task UpdateData()
        {
            var product = (_dataRow as ProductVm);

            var result = await new ProductsService().UpdateProduct(product.Id, new ProductUpdateRequest()
            {
                Id = product.Id
            });

            AfterCommitAsync(result);
        }

        private async void AfterCommitAsync(int result)
        {
            if (result == 1)
            {
                await BaseForm._instanceBaseForm.LoadDataGrid();
                this.Close();
            }
            else
                MessageBoxUtil.ShowMessageBox("Error", "Hệ thống tạm thời gián đoạn, vui lòng thử lại sau.", MessageBoxType.Error);
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}