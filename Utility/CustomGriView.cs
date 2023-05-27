using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using DevExpress.XtraGrid.Views.Grig;

namespace Utility
{
    public class CustomGriView
    {
        private static CustomGriView _instance;
        private CustomGriView()
        {

        }
        public static CustomGriView Instance
        {
            get
            {
                if(_instance != null) return _instance;
                _instance = new CustomGriView();
                return _instance;
            }
            private set { _instance = value; }
        }

        //public void CustomDrawRowIndicator (RowIndicatorCustomDrawEventArge rowIndicatorCustomDrawEventArge)
        //{
        //    if(!e.Info.is)
        //}
    }
}
