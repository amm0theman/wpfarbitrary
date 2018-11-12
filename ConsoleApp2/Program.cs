using System;
using ClassLibrary1;
using Ooui;
using Xamarin.Forms;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Forms.Init();
            var vm = new EntryFieldVM();
            UI.Publish("/", new MainPage() { BindingContext = vm }.GetOouiElement());
        }
    }
}
