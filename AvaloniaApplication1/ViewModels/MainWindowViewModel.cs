using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1;

namespace AvaloniaApplication1.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public databaseSQLite db = new databaseSQLite();
        public string Greeting => db.SelectData();
    }
}
