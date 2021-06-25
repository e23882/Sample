using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.DataModel
{
    public class TestModel:ViewModelBase
    {
        #region Declarations
        private int _A = 0;
        private int _B = 0;
        private int _C = 0;
        #endregion

        #region Property
        /// <summary>
        /// Property A = B + C
        /// </summary>
        public int A
        {
            get
            {
                return B+C;
            }
            set
            {
                _A = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Property B
        /// </summary>
        public int B
        {
            get
            {
                return _B;
            }
            set
            {
                _B = value;
                OnPropertyChanged();
                OnPropertyChanged("A");
            }
        }

        /// <summary>
        /// Property C
        /// </summary>
        public int C
        {
            get
            {
                return _C;
            }
            set
            {
                _C = value;
                OnPropertyChanged();
                OnPropertyChanged("A");
            }
        }
        #endregion
    }
}
