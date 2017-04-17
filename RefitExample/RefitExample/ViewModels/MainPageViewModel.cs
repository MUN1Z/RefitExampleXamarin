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

        private Person person { get; set; }

        public Person Person
        {
            get { return person; }
            set { person = value; OnPropertyChanged();}
        }
        
        public MainPageViewModel()
        {
            Title = "Main Page";
            
            Timer timer = new Timer((e) =>
            {
                GetPerson();
            }, null, 0, 3000);

        }

        public async void GetPerson()
        {
            var service = RefitServiceGenerator.GetService();
            Person = await service.GetPerson();
        }
    }
}
