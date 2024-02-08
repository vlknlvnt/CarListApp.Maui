
namespace CarListApp.Maui.ViewModels
{
    internal class AlsoNotifyChangeForAttribute : Attribute
    {
        private string v;

        public AlsoNotifyChangeForAttribute(string v)
        {
            this.v = v;
        }
    }
}