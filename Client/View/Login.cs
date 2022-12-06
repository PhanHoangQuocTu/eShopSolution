using Client.Callout;
using Client.Dtos.UserDto;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;

namespace Client.View
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var a = new UsersService();
            var result = await a.Authenticate(new LoginRequest()
            {
                //UserName = txtUserNameLogin.Text,
                //Password = txtPasswordLogin.Text,
                UserName = "admin",
                Password = "Abcd1234$",
                RememberMe = true,
            });

            var token = new JwtSecurityTokenHandler().ReadJwtToken(result.ResultObj);
            var role = token.Claims.FirstOrDefault(claim => claim.Type.Contains("role")).Value;

            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
        }
    }
}