using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Dependecy_Xam.ViewModels
{
    public class MyEntryViewModel
    {
        public string Title { get; set; } = "My Entry";
        public string Text { get; set; }
        public string TextUser { get; set; }
        public ICommand EntryCommand { get; }
        public MyEntryViewModel()
        {
            EntryCommand = new DelegateCommand(() => Modify());
        }

        private void Modify()
        {
            if (!string.IsNullOrWhiteSpace(Text))
            {
                TextUser = Text;
            }
        }
    }
}
