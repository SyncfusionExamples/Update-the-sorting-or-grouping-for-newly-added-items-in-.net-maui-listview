# Update-the-sorting-or-grouping-for-newly-added-items-in-.net-maui-listview
This example demonstrates about how to sort or group the newly added items in .NET MAUI ListView(SfListView).

``` 
    public class ContactsViewModel : INotifyPropertyChanged
    {
        public Command ChangeItem { get; set; }

        public ContactsViewModel()
        {
            ChangeItem = new Command(OnChangeItem);
        }
        private void OnChangeItem(object obj)
        {
            if((obj as Syncfusion.Maui.ListView.ItemTappedEventArgs).ItemType == ItemType.GroupHeader)
            {
                return;
            }
            var item = (obj as Syncfusion.Maui.ListView.ItemTappedEventArgs).ItemData as Contacts;
            item.ContactName = "Chan";
        }
    }
```

## Requirements to run the demo

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## Troubleshooting

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.