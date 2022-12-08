using Client.Callout;
using Client.Dtos.Common;
using Client.Dtos.UserDto;
using Client.Enumerates;
using Client.Extensions;
using Client.Utills;
using DevExpress.XtraLayout.Utils;
using System;
using System.Threading.Tasks;

namespace Client.View
{
    public partial class UserFrom : DevExpress.XtraEditors.XtraForm
    {
        private StateEnum _state = StateEnum.NONE;
        public object _dataRow = null;

        public UserFrom()
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
                layoutControlUserName.Visibility = LayoutVisibility.Never;
                layoutControlPassword.Visibility = LayoutVisibility.Never;
                layoutControlPasswordConfirm.Visibility = LayoutVisibility.Never;

                var user = (_dataRow as UserVm);
                txtFirstName.Text = user.FirstName;
                txtLastName.Text = user.LastName;
                dateBirthday.DateTime = user.Dob;
                txtEmail.Text = user.Email;
                txtNumberPhone.Text = user.PhoneNumber;
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
                MessageBoxUtil.ShowMessageBox("Lỗi", "Hệ thống tạm thời gián đoạn, vui lòng thử lại sau.", MessageBoxType.Error);
            }
        }

        private async Task InsertData()
        {
            var result = await new UsersService().RegisterUser(new RegisterRequest()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Dob = dateBirthday.DateTime,
                Email = txtEmail.Text,
                PhoneNumber = txtNumberPhone.Text,
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
                ConfirmPassword = txtPasswordConfirm.Text
            });

            AfterCommitAsync(result);
        }

        private async Task UpdateData()
        {
            var user = (_dataRow as UserVm);

            var result = await new UsersService().UpdateUser(user.Id, new UserUpdateRequest()
            {
                Id = user.Id,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Dob = dateBirthday.DateTime,
                Email = txtEmail.Text,
                PhoneNumber = txtNumberPhone.Text
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