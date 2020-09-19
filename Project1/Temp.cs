using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;


namespace Learn_Csharp_in_1week {
    /// <summary>
    /// 一時コード実行用
    /// </summary>
    class Temp {

        public static void ExeTemp() {
            Console.WriteLine("-------- ExeTemp --------\n");
            string name = "Fred";
            string.Format("Name = {0}, hours = {1:hh}", name, DateTime.Now);

            Console.WriteLine();
        }


    }

   

} // Learn_Csharp_in_1week
