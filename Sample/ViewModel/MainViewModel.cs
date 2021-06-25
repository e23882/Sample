using Sample.DataModel;
using System.Collections.ObjectModel;

namespace Sample
{
    public class MainViewModel:ViewModelBase
    {
        private ObservableCollection<TestModel> _List = new ObservableCollection<TestModel>();
        public ObservableCollection<TestModel> List 
        {
            get 
            {
                return _List;
            }
            set 
            {
                _List = value;
            }
        }

    }
}
