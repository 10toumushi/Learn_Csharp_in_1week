using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;


namespace Learn_Csharp_in_1week {

    class Program {
        static void Main(string[] args) {
            TestFunction obj = new TestFunction();
            obj.CheckPrint();

            obj.CheckSubstitution();

            //obj.CheckString();

            obj.CheckcConvertToNumberString();

            //obj.CheckcLargeAndSmallOfNumber();

            obj.CheckArray();

            obj.CheckExercise701();

            obj.CheckExerciseEx201();

            //obj.CheckExerciseEx202();

            //obj.CheckExerciseEx203();

            obj.CheckExerciseEx301();

            //obj.CheckExerciseEx601();

            //obj.CheckExerciseEx602();

            //obj.CheckExerciseEx603();

            obj.CheckClass();

            obj.CheckClass2();



            //////// 一時コード実行 /////////
            //Temp.ExeTemp();


            //////// 終了処理 /////////
            Console.WriteLine("プログラム終了。Enterを押してください...");
            Console.ReadLine();


            //////// デストラクタ処理の検出 /////////
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }


    }

} // Learn_Csharp_in_1week
