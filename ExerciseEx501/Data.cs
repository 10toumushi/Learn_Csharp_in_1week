using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEx501 {
    interface IWriteData {
        void Write(int num);
    }
    
    
    interface IReadData {
        int Read();
    }


    class Data : IWriteData, IReadData {
        //  データ
        private int num = 0;
        public void Write(int num) {
            this.num = num;
        }
        public int Read() {
            return num;
        }
    }
}
