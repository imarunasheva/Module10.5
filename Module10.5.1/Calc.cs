using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10._5._1
{
    public class Calc : ICalculate
    {
        
        ILogger Logger { get;}
        
        public Calc(ILogger logger)
        {
            Logger = logger;
        }
        
        public void CalLog()
        {
            Logger.Event("Выполняется расчет значения...");
            Thread.Sleep(1000);
        }

        public decimal Sum(decimal a, decimal b) => a + b;
        
    }
}
     