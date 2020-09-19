using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace Learn_Csharp_in_1week {
    /// <summary>
    /// テストを実行する
    /// </summary>
    class TestFunction {

        /// <summary>
        /// コンソールへの表示確認
        /// </summary>
        /// <param name=void>void</param>
        public void CheckPrint() {
            Console.WriteLine("-------- CheckPrint --------\n");

            //////// Hello world ////////
            Console.WriteLine("Hello World!");
            Console.Write("This is C#.");
            Console.Write("Write function has no a delimiter.");
            Console.WriteLine("\n日本語も表示できる。");
            Console.WriteLine();

            //////// 数字もそのまま表示可能 ////////
            Console.Write(123);
            Console.WriteLine(456);
            Console.WriteLine();

            //////// 演算結果の表示も可能 ////////
            Console.WriteLine(100 + 200);
            Console.WriteLine();

            //////// オーバーロードのWriteLine関数で、フォーマット指定表示 ////////
            Console.WriteLine("{0} + {1} = {2}", 1, 2, 1 + 2);
            Console.WriteLine("{0:d8}, {0:D8}, {0:x8}, {0:X8}", 43981);
            Console.WriteLine("{0:d8}, {1:D8}, {2:x8}, {3:X8}",
                              0, 256, 512, 1024);
            Console.WriteLine();
        }


        /// <summary>
        /// 変数の宣言, 代入の確認
        /// </summary>
        /// <param name=void>void</param>
        public void CheckSubstitution() {
            Console.WriteLine("-------- CheckSubstitution --------\n");

            int a = 1, b = 0x100;
            double c = 3.14, d = 5.0;
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("{0} * {1} = {2}", c, d, c * d);
            Console.WriteLine("Answer = ", c * d);    // 書式指定項目がないので何も表示されない
            Console.WriteLine();
        }


        /// <summary>
        /// string型の確認
        /// </summary>
        /// <param name=void>void</param>
        public void CheckString() {
            Console.WriteLine("-------- CheckString --------\n");

            //////// 文字列型 string ////////
            string str1, str2;
            Console.WriteLine("str1 = ");
            str1 = Console.ReadLine();
            Console.WriteLine("str2 = ");
            str2 = Console.ReadLine();
            Console.WriteLine("str1 + str2 = {0}", str1 + str2);
            Console.WriteLine();
        }


        /// <summary>
        /// 文字列と数値の変換の確認
        /// </summary>
        /// <param name=void>void</param>
        public void CheckcConvertToNumberString() {
            Console.WriteLine("-------- CheckcConvertToNumberString --------\n");

            //////// 文字列から数値の変換(Parse) ////////
            Console.WriteLine("---- Parseメソッド ----\n");
            Console.WriteLine(int.Parse("123"));
            Console.WriteLine(double.Parse("3.14"));
            // Console.WriteLine(int.Parse("3.14"));    // エラーになる

            ////NumberStyles列挙型の使用
            Console.WriteLine(int.Parse("123,456,789", NumberStyles.AllowThousands));
            Console.WriteLine(double.Parse("5E-4", NumberStyles.AllowExponent));
            Console.WriteLine(int.Parse("ffff", NumberStyles.HexNumber));
            Console.WriteLine(double.Parse("123,456-", NumberStyles.AllowThousands | NumberStyles.AllowTrailingSign));
            Console.WriteLine();

            //// NumberStyles列挙型とカルチャの変更
            string price = "$100";

            //デフォルトカルチャはja-JPのため、表示できない
            Console.WriteLine("CurrentCulture:{0}", CultureInfo.CurrentCulture);
            //Console.WriteLine(double.Parse(price, NumberStyles.Any));

            //en-US のCultureInfoオブジェクトを作成し、カルチャを変更
            CultureInfo ci = new CultureInfo("en-US");
            Console.WriteLine(double.Parse(price, NumberStyles.Any, ci));
            Console.WriteLine();

            //////// 文字列から数値の変換(Convert) /////////
            Console.WriteLine("---- Convertメソッド ----\n");
            Console.WriteLine(Convert.ToInt32("123"));
            Console.WriteLine(Convert.ToDouble("456.7"));
            Console.WriteLine(Convert.ToInt32("100", 16));
            Console.WriteLine(Convert.ToString('A'));
            Console.WriteLine(Convert.ToString(789));
            Console.WriteLine();

            //////// 数値から文字列への変換(ToString) /////////
            Console.WriteLine("---- ToStringメソッド ----\n");
            Console.WriteLine((123).ToString());
            Console.WriteLine((456L).ToString());
            Console.WriteLine((789.1).ToString());
            Console.WriteLine(true.ToString());
            Console.WriteLine((21).ToString("0000"));    // フォーマット指定
            Console.WriteLine();
        }


        /// <summary>
        /// 文字列と数値の変換の確認
        /// </summary>
        /// <param name=void>void</param>
        public void CheckcLargeAndSmallOfNumber() {
            Console.WriteLine("-------- CheckcLargeAndSmallOfNumber --------\n");

            //////// 数値判定 ////////
            double num;
            num = double.Parse(Console.ReadLine());
            if (num == 0.0) {
                Console.WriteLine("値は0.0です。");
            } else {
                Console.WriteLine("値は0.0ではありません。");
            }

            if (num > 0.0) {
                Console.WriteLine("値は0.0より大きいです。");
            } else {
                Console.WriteLine("値は0.0以下です。");
            }

            if (num > 0) {
                Console.WriteLine("値は0より大きいです。");
            } else {
                Console.WriteLine("値は0以下です。");
            }
            Console.WriteLine();
        }


        /// <summary>
        /// 配列処理の確認
        /// </summary>
        /// <param name=void>void</param>
        public void CheckArray() {
            Console.WriteLine("-------- CheckArray --------\n");

            //////// Exercise502 /////////
            double[] d = {0.2, 1.4, -0.8};
            for (int i=0; i<d.Length; i++) {
                Console.WriteLine("d[{0}] = {1}", i, d[i]);
            }
            Console.WriteLine();


            //////// Exercise503 /////////
            Random r = new Random(1);
            int[] i_array = new int[10];
            for (int i=0; i<i_array.Length; i++) {
                i_array[i] = r.Next(1, 101);
                Console.WriteLine("i_array[{0}] = {1}", i, i_array[i]);
            }

            // using System.Linq ディレクティブを使用する;
            Console.WriteLine("Sum     = {0}", i_array.Sum());
            Console.WriteLine("Average = {0}", i_array.Average());
            Console.WriteLine("Min     = {0}", i_array.Min());
            Console.WriteLine("MAx     = {0}", i_array.Max());
            Console.WriteLine();


            //////// Exercise503 /////////
            int[,] m = new int[9, 9];
            for (int i=0; i<m.GetLongLength(0); i++) {
                for (int j=0; j<m.GetLength(1); j++) {
                    m[i, j] = (i+1)*(j+1);
                    Console.Write("{0}*{1}={2,2} ", i+1, j+1, m[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }


        /// <summary>
        /// Vector2Dクラスの確認
        /// </summary>
        /// <param name=void>void</param>
        public void CheckExercise701() {
            Console.WriteLine("-------- CheckExercise701 --------\n");

            Vector2D v1 = new Vector2D();
            v1.X = 1.0;
            v1.Y = 1.0;
            Console.WriteLine("v1 = ({0}, {1})", v1.X, v1.Y);
            Vector2D v2 = new Vector2D();
            v2.X = 1.0;
            v2.Y = -1.0;
            Console.WriteLine("v2 = ({0}, {1})", v2.X, v2.Y);
            v1.Add(v2);
            Console.WriteLine("v1 = ({0}, {1})", v1.X, v1.Y);
            v1.Sub(v2);
            Console.WriteLine("v1 = ({0}, {1})", v1.X, v1.Y);
            v1.Mul(2.0);
            Console.WriteLine("v1 = ({0}, {1})", v1.X, v1.Y);
            Console.WriteLine("Dot Product of v1 and v2 = {0}", v1.DotProduct(v2));

            Console.WriteLine();
        }


        /// <summary>
        /// Vector2Dクラスの静的メソッド確認
        /// </summary>
        /// <param name=void>void</param>
        public void CheckExerciseEx201() {
            Console.WriteLine("-------- CheckExerciseEx201 --------\n");

            Vector2D v1 = new Vector2D();
            v1.X = 1.0;
            v1.Y = 1.0;
            Vector2D.Show("v1", v1);
            Vector2D v2 = new Vector2D();
            v2.X = 1.0;
            v2.Y = -1.0;
            Vector2D.Show("v2", v2);
            v1.Add(v2);
            Vector2D.Show("v1", v1);
            v1.Sub(v2);
            Vector2D.Show("v1", v1);
            v1.Mul(2.0);
            Vector2D.Show("v1", v1);
            Console.WriteLine("Dot Product of v1 and v2 = {0}", v1.DotProduct(v2));

            Console.WriteLine();
        }
        
        
        /// <summary>
        /// Numericクラスの静的メソッド確認
        /// </summary>
        /// <param name=void>void</param>
        public void CheckExerciseEx202() {
            Console.WriteLine("-------- CheckExerciseEx202 --------\n");
            Console.Write("Enter 1st integer number > ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd integer number > ");
            int b = int.Parse(Console.ReadLine());
            int max_num = Numeric.Max(a, b);
            Console.WriteLine("Max number is {0}", max_num);
            
            Console.WriteLine();
        }


        /// <summary>
        /// Numericクラスの静的メソッド確認
        /// </summary>
        /// <param name=void>void</param>
        public void CheckExerciseEx203() {
            Console.WriteLine("-------- CheckExerciseEx203 --------\n");
            Console.Write("Enter positive real number > ");
            double squr_num = Numeric.GetSqurNum(double.Parse(Console.ReadLine()));
            Console.WriteLine("Square root is {0}", squr_num);
            
            Console.WriteLine();
        }
        
        
        /// <summary>
        /// Vector2Dクラスの派生クラスPoint2Dクラスの確認
        /// </summary>
        /// <param name=void>void</param>
        public void CheckExerciseEx301() {
            Console.WriteLine("-------- CheckExerciseEx301 --------\n");

            Point2D p1 = new Point2D(1, 0);
            Point2D p2 = new Point2D(3, 2);
            Console.WriteLine("p1 = {0}, p2 = {1}", p1, p2);

            double d = p2.Distance(p1);
            if (d == 0) {
                Console.WriteLine("同じ点です");
            } else {
                Console.WriteLine("Distance = {0}", d);
            }
            
            Console.WriteLine();
        }
        
        
        /// <summary>
        /// Listコレクションの確認
        /// </summary>
        /// <param name=void>void</param>
        public void CheckExerciseEx601() {
            Console.WriteLine("-------- CheckExerciseEx601 --------\n");
            List<int> i_list =new List<int>();

            while (true) {
                Console.Write("1~10の整数を入力してください\n> ");
                int i = int.Parse(Console.ReadLine());
                if (i < 1 || i > 10) {
                    Console.WriteLine("範囲外の値が入力されました");
                    break;
                }
                i_list.Add(i);
            }

            for (int i = 0; i<i_list.Count; i++) {
                    Console.Write("{0} ", i_list[i]);
            }

            // using System.Linq ディレクティブを使用する;
            Console.WriteLine("\nMax = {0}, Min = {1}", i_list.Max(), i_list.Min());


            Console.WriteLine();
        }


        /// <summary>
        /// List, Setコレクションの確認
        /// </summary>
        /// <param name=void>void</param>
        public void CheckExerciseEx602() {
            Console.WriteLine("-------- CheckExerciseEx602 --------\n");
            List<int> i_list = new List<int>();

            while (true) {
                Console.Write("1~10の整数を入力してください\n> ");
                int i = int.Parse(Console.ReadLine());
                if (i < 1 || i > 10) {
                    Console.WriteLine("範囲外の値が入力されました");
                    break;
                }
                i_list.Add(i);
            }

            // Listを昇順ソート
            i_list.Sort();

            // ListをHashSetに変換
            HashSet<int> i_set =  i_list.ToHashSet();
            foreach (int n in i_set) {
                Console.Write("{0} ", n);
            }

            Console.WriteLine("\n");
        }


        /// <summary>
        /// Dictionaryコレクションの確認
        /// </summary>
        /// <param name=void>void</param>
        public void CheckExerciseEx603() {
            Console.WriteLine("-------- CheckExerciseEx603 --------\n");
            //i_dict.Add("January", "1月");
            //i_dict.Add("February", "2月");
            //i_dict.Add("March", "3月");
            //i_dict.Add("April", "4月");
            //i_dict.Add("May", "5月");
            //i_dict.Add("June", "6月");
            //i_dict.Add("July", "7月");
            //i_dict.Add("August", "8月");
            //i_dict.Add("September", "9月");
            //i_dict.Add("October", "10月");
            //i_dict.Add("November", "11月");
            //i_dict.Add("Disember", "12月");
            //Dictionary<string, string> i_dict = new Dictionary<string, string>();
            Dictionary<string, int> i_dict = new Dictionary<string, int>();
            string[] manths = {"January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "Disember"};
            for (int i = 0; i<manths.Length; i++) {
                i_dict[manths[i]] = i + 1;
            }
            Console.Write("月名を英語で入力してください(例: April)\n> ");
            string str = Console.ReadLine();

            if (i_dict.ContainsKey(str)) {
                Console.Write("{0} => {1}月", str, i_dict[str]);
            } else {
                Console.Write("正しい月名を入力してください");
            }


            Console.WriteLine();
        }


        /// <summary>
        /// クラスの確認
        /// </summary>
        /// <param name=void>void</param>
        public void CheckClass() {
            Console.WriteLine("-------- CheckClass --------\n");

            void CallBase(Base b) {
                b.FuncWithVirtual();
                b.FuncWithoutVirtual();
            }

            Base b1 = new Base();
            Sub  s1 = new Sub();
            Console.WriteLine();

            CallBase(b1);
            Console.WriteLine();
            CallBase(s1);

            Console.WriteLine();
        }

    }



} // Learn_Csharp_in_1week
