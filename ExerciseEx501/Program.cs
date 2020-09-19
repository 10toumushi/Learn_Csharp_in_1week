using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEx501 {
    class Program {
        static void Main(string[] args) {
            Data d = new Data();
            d.Write(1);    //  データの書き込み
            int num = d.Read();
            Console.WriteLine("data={0}", num);
        }
    }
}
