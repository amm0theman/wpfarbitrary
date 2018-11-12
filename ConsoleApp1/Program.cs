using System;
using Ooui;
using System.Diagnostics;
using Xamarin.Forms;



namespace ClassLibrary1
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
