using ContactListSample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactListSample.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Contact Item { get; set; }
        public ItemDetailViewModel(Contact item = null)
        {
            Title = item?.Name;
            Item = item;
        }
    }
}
