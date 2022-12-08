using Client.Callout;
using Client.Dtos.Category;
using Client.Dtos.Common;
using Client.Enumerates;
using Client.Extensions;
using Client.Utills;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.View
{
    public partial class CategoryForm : DevExpress.XtraEditors.XtraForm
    {
        private StateEnum _state = StateEnum.NONE;
        public object _dataRow = null;

        public CategoryForm()
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
                MessageBoxUtil.ShowMessageBox("Lỗi", "Hệ thống tạm thời gián đoạn, vui lòng thử lại sau.", MessageBoxType.Error);
            }
        }

        private async Task InsertData()
        {
            var result = await new CategoriesService().GetCategories("vi");

            //AfterCommitAsync(result);
        }

        private async Task UpdateData()
        {
            var user = (_dataRow as CategoryVm);

            var result = await new CategoriesService().GetCategories("vi");

            //AfterCommitAsync(result);
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