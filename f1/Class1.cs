using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace f1
{
    public class bank_acc
    {
        string fio;
        double balance;
        public string _fio
        {
            get { return fio; }
            set { fio = value; }

        }
        public double _balance
        {
            get { return balance; }
            set { balance = value; }
        }

       public void add(double _add)
        {
            _balance += _add;
        }
       public void off(double _off)
        {
            if (_off <= balance)
            {
                _balance -= _off;
            }
        }
        delegate void amogus();
        amogus ss;
  
    }
}
