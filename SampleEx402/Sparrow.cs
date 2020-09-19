using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx402
{
    class Sparrow : Bird
    {
        //  コンストラクタ
        public Sparrow() : base("すずめ")
        {
        }
        //  すずめがなく
        public override void Sing()
        {
            Console.WriteLine("チュンチュン");
        }
    }
}
