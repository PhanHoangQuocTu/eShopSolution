using Client.Callout;
using Client.Dtos.UserDto;
using Client.Security;
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
                UserName = "admin",
                Password = "Abcd1234$",
                RememberMe = true,
            });

            var bc = Convert.FromBase64String(result.ResultObj);
            var val = Base64Security.Decode(result.ResultObj);

            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
            this.Hide();
        }
    }
}