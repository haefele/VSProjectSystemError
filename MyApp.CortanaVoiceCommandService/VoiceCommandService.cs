using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;
using MyApp.Core;

namespace MyApp.CortanaVoiceCommandService
{
    public sealed class VoiceCommandService : IBackgroundTask
    {
        public async void Run(IBackgroundTaskInstance taskInstance)
        {
            var deferral = taskInstance.GetDeferral();

            try
            {
                var dataService = new DataService();
                var message = await dataService.GetSomethingFromAnApi();

                //Do something with the message
            }
            finally
            {
                deferral.Complete();
            }
        }
    }
}
