using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RefitExample.Models;
using RefitExample.Service;
using System.Threading;

namespace RefitExample.ViewModels
{
    public class MainPageViewModel : BaseModel
    {
        public string Title { get; set; }

        private int number { get; set; }

        public int Number
        {
            get { return number; }
            set { number = value; OnPropertyChanged();}
        }
        
        public MainPageViewModel()
        {
            Title = "Main Page";
            
            Timer timer = new Timer((e) =>
            {
                GetNumber();
            }, null, 0, 3000);

        }

        public async void GetNumber()
        {
            var service = RefitServiceGenerator.GetService();
            Number = await service.GetNumber();
        }
    }
}
