using Client.Callout;
using Client.Dtos.Common;
using Client.Dtos.UserDto;
using Client.Enumerates;
using Client.Utills;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;

namespace Client.View
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public static Login _instance;
        public string _role;

        public Login()
        {
            InitializeComponent();
            _instance = this;

            if (Properties.Settings.Default.UserName != string.Empty)
            {
                txtUserNameLogin.Text = Properties.Settings.Default.UserName;
                txtPasswordLogin.Text = Properties.Settings.Default.Password;
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (cboxRemember.Checked)
            {
                Properties.Settings.Default.UserName = txtUserNameLogin.Text;
                Properties.Settings.Default.Password = txtPasswordLogin.Text;
                Properties.Settings.Default.Save();
            }

            var result = await new UsersService().Authenticate(new LoginRequest()
            {
                UserName = txtUserNameLogin.Text,
                Password = txtPasswordLogin.Text,
                //UserName = "admin",
                //Password = "Abcd1234$",
                RememberMe = cboxRemember.Checked,
            });

            AfterLogin(result);
        }

        private void AfterLogin(ApiResult<string> result)
        {
            if (result.IsSuccessed)
            {
                var token = new JwtSecurityTokenHandler().ReadJwtToken(result.ResultObj);
                _role = token.Claims.FirstOrDefault(claim => claim.Type.Contains("role")).Value;

                BaseForm baseForm = new BaseForm();
                baseForm.Show();
            }
            else
            {
                MessageBoxUtil.ShowMessageBox("Thông báo", result.Message, MessageBoxType.Information);
            }    
            
        }

        private void cboxViewPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxViewPass.Checked)
                txtPasswordLogin.Properties.PasswordChar = '\0';
            else
                txtPasswordLogin.Properties.PasswordChar = '*';
        }
    }
}