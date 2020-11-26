using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    static class InputHelper
    {
        // TODO: handle input
        // for example 3+4-5 or only the operator

        public static double ReadDouble(string userInfo)
        {
            return ReadDouble(userInfo, double.MinValue, double.MaxValue);
        }
  
        /// <summary>
        /// Liest eine Kommazahl als Double von der Console und gibt als Hilfe den Text userInfo aus
        /// </summary>
        /// <param name="userInfo">Text der für den User ausgegeben wird.</param>
        /// <returns></returns>
        public static double ReadDouble(string userInfo, double min, double max)
        {
            double retValue = default;
            bool IsNumber = false;

            do
            {
                Console.WriteLine(userInfo);
                string line = Console.ReadLine();
                IsNumber = double.TryParse(line, out retValue);

            } while (IsNumber == false ||
                     (retValue < min || retValue > max));

            return retValue;
        }

    }
}
