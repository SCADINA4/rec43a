using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rec43a.ViewsModels.Base;


namespace rec43a.ViewsModels
{
    public class MainWindowViewModel : ViewModel
    {
        private int number;
        public int Number 
        { 
            get { return number; }
            set { Set(ref number, value); }
        }
        
        public int Summ(int n)
        {
            if (n == 0)
                return 0;

            return Number = n % 10 + Summ(n / 10);
        }
    
    }
}
