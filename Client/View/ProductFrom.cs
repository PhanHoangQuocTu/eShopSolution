using Client.Callout;
using Client.Dtos.Common;
using Client.Dtos.Product;
using Client.Enumerates;
using Client.Extensions;
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
            InitDefaultFrom();
        }

        private void InitDefaultFrom()
        {
            if (_state == StateEnum.UPDATE)
            {
                txtCode.Enabled = false;

                var product = (_dataRow as ProductVm);
                txtCode.Text = product.Code;
                txtName.Text = product.Name;
                spinInputPrice.Text = product.ImportPrice.ToString();
                spinPrice.Text = product.Price.ToString();
                spinQuantity.Text = product.QuantityInStock.ToString();
            }
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
                Code = txtCode.Text,
                Name = txtName.Text,
                ImportPrice = decimal.Parse(spinInputPrice.Text),
                Price = decimal.Parse(spinPrice.Text),
                QuantityInStock = int.Parse(spinQuantity.Text)
            });

            AfterCommitAsync(result);
        }

        private async Task UpdateData()
        {
            var product = (_dataRow as ProductVm);

            var result = await new ProductsService().UpdateProduct(new ProductUpdateRequest()
            {
                Id = product.Id,
                Name = txtName.Text,
                ImportPrice = decimal.Parse(spinInputPrice.Text),
                Price = decimal.Parse(spinPrice.Text),
                QuantityInStock = int.Parse(spinQuantity.Text)
            });

            AfterCommitAsync(result);
        }

        private async void AfterCommitAsync(ApiResult<bool> result)
        {
            if (result.IsSuccessed)
            {
                await BaseForm._instanceBaseForm.LoadDataGrid();
                this.Close();
            }
            else
                MessageBoxUtil.ShowMessageBox("Error", !result.Message.IsNullOrEmpty() ? result.Message : "Dữ liệu nhập không đúng. Vui lòng kiểm tra lại.", MessageBoxType.Error);
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}