using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_V0._1.Model.Fishes
{
    class Gudgeon:Fish
    {

        public Gudgeon ()
        {
            Id = 0;
            TypeName = "Пескарь";
            Size = this.GetSize(0.01, 0.1); //MinSize/MaxSize in metrs
            Weight = this.GetWeight(0.01, 0.1);//MinWeighht/MaxWeight in kl
            Power = Size*Weight;

        }

        

    }
}
