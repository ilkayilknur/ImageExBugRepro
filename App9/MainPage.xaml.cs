using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App9
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Item> list = new ObservableCollection<Item>()
            {
                new Item(){Uri="https://xomnistorage4077.blob.core.windows.net/images/8e588c5a-38ed-429a-b23d-6c6440c6bbba"},
                new Item(){Uri="https://xomnistorage4077.blob.core.windows.net/images/60a3b879-0cde-48ce-8077-bcb9ef384b35"},
                new Item(){Uri="https://xomnistorage4077.blob.core.windows.net/images/ebbedc8a-d07f-4521-961e-2263b1c822fc"},
                new Item(){Uri="https://xomnistorage4077.blob.core.windows.net/images/a8f8a625-061c-47c8-b67e-cb27392579f9"},
                new Item(){Uri=""},
                new Item(){Uri="https://xomnistorage4077.blob.core.windows.net/images/b939f597-a5d1-413a-9bda-0b19def47520"},
                new Item(){Uri="https://xomnistorage4077.blob.core.windows.net/images/ce28d428-b009-4695-8f7e-e756dce30627"},
                new Item(){Uri="https://xomnistorage4077.blob.core.windows.net/images/9c427423-5539-48a4-9605-c25fd219d12c"},
                new Item(){Uri="https://xomnistorage4077.blob.core.windows.net/images/2bc78f07-0e35-40c3-80ea-2d7a074789ed"},
                new Item(){Uri="https://xomnistorage4077.blob.core.windows.net/images/dfc3f1a0-169a-4e34-9991-8b117c96212f"},
                new Item(){Uri="https://xomnistorage4077.blob.core.windows.net/images/56287a46-4241-424a-90e4-9e675f700145"},
                new Item(){Uri="https://xomnistorage4077.blob.core.windows.net/images/1fe2c8d1-0aed-4af6-9348-0d47e254b19c"},
                new Item(){Uri="https://xomnistorage4077.blob.core.windows.net/images/c46751f4-7394-4e9a-8a2a-9faab1ce2001"},
                new Item(){Uri="https://xomnistorage4077.blob.core.windows.net/images/90f72881-0439-4596-b09b-6f5dff3dd6d8"},
                new Item(){Uri="https://xomnistorage4077.blob.core.windows.net/images/c224a4cb-a598-4163-8875-32ab7709bd6a"},
                new Item(){Uri="https://xomnistorage4077.blob.core.windows.net/images/9021152e-c962-4a37-983e-339fa10517c3"},
                new Item(){Uri="https://xomnistorage4077.blob.core.windows.net/images/28a402ec-72a3-4084-b0da-537e1ef34058"},
                new Item(){Uri="https://xomnistorage4077.blob.core.windows.net/images/567fd0ed-32bb-4c95-b394-4c99f686a199"},
                new Item(){Uri="https://xomnistorage4077.blob.core.windows.net/images/9fd0ae5d-24e2-447f-b9fd-5c901282e1e6"},
                new Item(){Uri="https://xomnistorage4077.blob.core.windows.net/images/ae16cafe-82ec-40ca-835c-b5f5f10e145d"},
            };

            lst.ItemsSource = list;
        }
    }


    public class Item
    {
        public string Uri { get; set; }
    }
}
