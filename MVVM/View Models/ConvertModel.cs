using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp2.MVVM.Models;

namespace MauiApp2.MVVM.View_Models
{
    public class ConvertModel
    {
        public Data data { get; set; }  
        public ConvertModel()
        { 
            data = new Data
            {
                Married="yes"
            };
        }
    }
}
