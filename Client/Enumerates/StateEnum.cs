
using System.ComponentModel;


namespace Client.Enumerates
{
    public enum StateEnum
    {
        [Description("INSERT")] INSERT, //thêm
        [Description("UPDATE")] UPDATE, //sửa
        [Description("NONE")] NONE,
    }
}
