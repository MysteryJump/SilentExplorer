using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using System.ComponentModel;
using System.Collections.ObjectModel;
using SilentExplorer.Library.SilentExplorerCore.Data;
using System.Reactive;

namespace SilentExplorer.Windows.ViewModel
{
    public class ThreadListViewModel : ViewModelBase
    {
        private ObservableCollection<Thread> hasThreads;

        public ThreadListViewModel()
        {
            MessageBus.Current.Listen<string>()
                .Subscribe(async x => 
                    {
                        await Initializer(x);
                    });
        }

        public ObservableCollection<Thread> Threads
        {
            get { return hasThreads; }
            set
            {
                this.RaiseAndSetIfChanged(ref hasThreads, value);
                hasThreads = value;
            }
        }


        public ReactiveCommand<Unit> initialize;

        public IReactiveCommand Initialize
        {
            get
            {
                if (initialize == null)
                    initialize = ReactiveCommand.CreateAsyncTask(Initializer);
                return initialize;
            }
        }

        private async Task Initializer(object url)
        {
            var uri = url.ToString();

            var bbs = Bbs.Load(uri);
            var threads = await bbs.GetThreadList();
            
            threads.ForEach(Threads.Add);            
        }


    }
}
