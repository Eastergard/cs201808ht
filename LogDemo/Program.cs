using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogDemo
{
    class Program
    {
        private static NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();


        static void Main(string[] args)
        {
            log.Debug("App startet");

            try
            {
                string g = null;
                g.ToString();
            }
            catch (Exception e)
            {
                log.Error(e);
            }
        }
    }
}
