using Microsoft.Toolkit.Mvvm.Input;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WPF_Buttons.UserControls.ContentPresenters
{
    public class CheckableWrapper : ItemsControl
    {
        public CheckableWrapper()
        {
            SetValue(CheckedItemsProperty, new List<object>());
        }

        public List<object> CheckedItems 
        {
            get => (List<object>)GetValue(CheckedItemsProperty); 
            set => SetValue(CheckedItemsProperty, value);
        }

        public static readonly DependencyProperty CheckedItemsProperty =
            DependencyProperty.Register("CheckedItems", typeof(IEnumerable<object>), typeof(CheckableWrapper));

        public RelayCommand<object> m_ItemChecked => new RelayCommand<object>((_) => CheckItem(_)); 
        public RelayCommand<object> m_ItemUnchecked => new RelayCommand<object>((_) => UncheckItem(_)); 

        public void CheckItem(object item)
        {
            CheckedItems.Add(item);
        }

        public void UncheckItem(object item)
        {
            CheckedItems.Remove(item);
        }
    }
}
