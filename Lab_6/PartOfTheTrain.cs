using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class PartOfTheTrain
    {
        private int passangerQuantity;
        private int baggageQuantity;
        private int comfortLevel;

        public PartOfTheTrain(int passanger, int baggage, int comfort)
        {
            this.passangerQuantity = passanger;
            this.baggageQuantity = baggage;
            this.comfortLevel = comfort;
        }

        public int PassangerQuantity
        {
            get
            {
                return passangerQuantity;
            }
        }

        public int BaggageQuantity
        {
            get
            {
                return baggageQuantity;
            }
        }

        public int ComfortLevel
        {
            get
            {
                return comfortLevel;
            }
        }

    }
}
