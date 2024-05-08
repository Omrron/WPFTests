using Microsoft.Toolkit.Mvvm.Input;
using System.Collections.Generic;
using WPF_Buttons.UserControls.ContentPresenters;

namespace WPF_Buttons.Windows
{
    class ButtonsTestViewModel
    {
        CheckableWrapper CategoriesWrapper { get; set; }
        public IEnumerable<string> Categories { get; set; }
        public IEnumerable<object> CheckedCategoreis { get; set; }

        public ButtonsTestViewModel() 
        {
            Categories = new List<string>() { "רכב", "רחפן", "תשתיות" };
            CategoriesWrapper = new CheckableWrapper();
        }

        public RelayCommand hitIt => new RelayCommand(() => HitIt());

        public void HitIt()
        {
            CheckedCategoreis = CategoriesWrapper.CheckedItems;
        }

    }
}
