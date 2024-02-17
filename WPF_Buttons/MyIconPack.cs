using System.Collections.Generic;
using System.Windows;
using Xceed.Wpf.Themes.MaterialDesign.ControlzEx;

namespace WPF_Buttons
{
    public class MyIconPack : PackIconBase<IconPackEnum>
    {
        static MyIconPack()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MyIconPack), new FrameworkPropertyMetadata(typeof(MyIconPack)));
        }

        public MyIconPack() : base (CreateIconData) { }

        private static IDictionary<IconPackEnum, string> CreateIconData()
        {
            return new Dictionary<IconPackEnum, string>
            {
                { IconPackEnum.PointPlus, "M 11.21875 2.527344 L 11.21875 5.050781 L 6.292969 5.050781 L 6.292969 10.144531 L 11.21875 10.144531 L 11.21875 15.195312 L 16.105469 15.195312 L 16.105469 10.144531 L 20.992188 10.144531 L 20.992188 5.050781 L 16.105469 5.050781 L 16.105469 0 L 11.21875 0 Z M 11.21875 2.527344 M 2.113281 14.339844 C 0.984375 15.019531 0.0625 15.59375 0.0625 15.613281 C 0.0625 15.628906 0.601562 16.605469 1.257812 17.777344 C 2.144531 19.355469 2.476562 19.90625 2.523438 19.894531 C 2.59375 19.875 6.582031 17.484375 6.636719 17.425781 C 6.679688 17.382812 4.269531 13.097656 4.207031 13.105469 C 4.183594 13.105469 3.238281 13.660156 2.113281 14.339844 Z M 2.113281 14.339844"}
            };
        }
    }
}
