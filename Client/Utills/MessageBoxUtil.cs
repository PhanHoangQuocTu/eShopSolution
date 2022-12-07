using Client.Enumerates;
using System.Windows.Forms;

namespace Client.Utills
{
    public static class MessageBoxUtil
    {
        public static void ShowMessageBox(string mesTitle, string mesBody, MessageBoxType type)
        {
            var mesIcon = new MessageBoxIcon();

            switch (type)
            {
                case MessageBoxType.Information: // Thông báo
                    mesIcon = MessageBoxIcon.Information;
                    break;
                case MessageBoxType.Warning: // cảnh báo
                    mesIcon = MessageBoxIcon.Warning;
                    break;
                case MessageBoxType.Error: // Lỗi
                    mesIcon = MessageBoxIcon.Error;
                    break;
                default:
                    mesIcon = MessageBoxIcon.Information;
                    break;
            }

            MessageBox.Show(mesBody, mesTitle, MessageBoxButtons.OK, mesIcon);
        }
    }
}
