using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace MyApp.Core
{
    public class DataService
    {
        public async Task<string> GetSomethingFromAnApi()
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            return "Lorem ipsum...";
        }
    }
}
