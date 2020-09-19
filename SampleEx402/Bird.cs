using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx402
{
    abstract class Bird
    {
        //  名前フィールド
        private string name_;
        //  引数つきコンストラクタ
        public Bird(string name)
        {
            this.name_ = name;
        }
        // 名前を取得
        public string Name
        {
            get { return name_; }
        }
        //  鳴く（抽象メソッド）
        public abstract void Sing();
    }
}
