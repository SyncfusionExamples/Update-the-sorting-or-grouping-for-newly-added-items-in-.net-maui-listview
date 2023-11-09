using Syncfusion.Maui.DataSource;
using Syncfusion.Maui.ListView;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewMaui
{
    public class Behavior : Behavior<SfListView>
    {
        SfListView listView;
        protected override void OnAttachedTo(SfListView bindable)
        {
            listView = bindable;
            listView.Loaded += Bindable_Loaded;
            base.OnAttachedTo(bindable);
        }

        private void Bindable_Loaded(object sender, ListViewLoadedEventArgs e)
        {
            listView.DataSource.LiveDataUpdateMode = LiveDataUpdateMode.AllowDataShaping;
            listView.DataSource.GroupDescriptors.Add(
                new GroupDescriptor()
                {
                    PropertyName = "ContactName",
                    KeySelector = (object obj1) =>
                    {
                        var item = (obj1 as Contacts);
                        return item.ContactName[0].ToString();
                    }
                });
            listView.DataSource.SortDescriptors.Add(
                new SortDescriptor()
                {
                    PropertyName = "ContactName"
                });
        }
        protected override void OnDetachingFrom(SfListView bindable)
        {
            listView.Loaded -= Bindable_Loaded;
            listView = null;
            base.OnDetachingFrom(bindable);
        }
    }
}
