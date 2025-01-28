using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiApp2.MVVM.View_Models
{
    public class Commandmodel
    {
            public ICommand clickcommand { get; }
        public ICommand searchcommand{ get; }
        public string searchterm { get; set; }
        public Commandmodel() 
        {
            clickcommand=new Command(()=>
            {
                App.Current.MainPage.DisplayAlert("title", "message", "ok");
            });
            searchcommand = new Command(() =>
            {
                var data = searchterm;
            });
        }
    }
}
