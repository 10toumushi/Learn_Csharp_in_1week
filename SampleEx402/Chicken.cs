using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx402 {
    class Chicken: Bird {

        public Chicken() : base("にわとり") {
        }

        //  カラスがなく
        public override void Sing()
        {
            Console.WriteLine("コケコッコー");
        }
    }
}
