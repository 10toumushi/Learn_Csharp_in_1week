using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;


namespace Learn_Csharp_in_1week {
    // 基底クラス
    class Base {
        private int base_int_;
        private double base_double_;
        private string base_string_;

        public int public_int_ = 1;
        public static int s_base_int_;

        public Base() {
            Console.WriteLine("Base class generated.");
        }
        public Base(int base_int) {
            base_int_ = base_int;
        }
        public Base(int base_int, double base_double) {
            base_int_ = base_int;
            base_double_ = base_double;
        }
        ~Base() {
            Console.WriteLine("Base class deleted.");
        }

        public virtual void FuncWithVirtual() {
            Console.WriteLine("Virtual func of Base.");
        }
        public void FuncWithoutVirtual() {
            Console.WriteLine("Non virtual func of Base.");
        }
        public void BaseFunc() {
            Console.WriteLine("Base Func.");
        }

        public int PropertyBaseInt { get; set; } = 0;
        public string PropertyString { get; set; } = "Base property";
        public void UsePropertyBaseInt() {
             PropertyBaseInt = 5;
             Console.WriteLine("PropertyBaseInt = {0}", PropertyBaseInt);
        }
        public static void StaticBaseFunc() {
            Console.WriteLine("s_base_int_ = {0}", s_base_int_);
        }
    }

    // 派生クラス
    class Sub : Base {
        private int sub_int_;
        private double sub_double_;
        private string sub_string_;

        int public_int_ = 3;
        static int s_sub_int_;
        public Sub() { 
            Console.WriteLine("Sub class generated.");
        }
        public Sub(int sub_int) {
            sub_int_ = sub_int;
        }
        public Sub(int sub_int, double sub_double) {
            sub_int_ = sub_int;
            sub_double_ = sub_double;
        }
        ~Sub() {
            Console.WriteLine("Sub class deleted.");
        }

        public override void FuncWithVirtual() {
            Console.WriteLine("Virtual func of Sub.");
        }
        public void FuncWithoutVirtual() {
            Console.WriteLine("Non virtual func of Sub.");
        }
        public void SubFunc() {
            Console.WriteLine("Sub Func.");
        }

        public int PropertySubInt { get; set; } = 0;
        public string PropertyString { get; set; } = "Sub property";
        public void UsePropertySubInt() {
            PropertySubInt = 5;
            Console.WriteLine("PropertyBaseInt = {0}", PropertySubInt);
        }
        public static void StaticSubFunc() {
            Console.WriteLine("s_sub_int_ = {0}", s_sub_int_);
        }
    }


} // Learn_Csharp_in_1week
