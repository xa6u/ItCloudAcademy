using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork07._12._18.Contract
{
    interface IFuel
    {
        /// <summary>
        /// type of fuel (disel,gasoline,lpg)
        /// </summary>
        FuelType Type { get; }
        /// <summary>
        /// volume of fuel tank
        /// </summary>
        int TankVolume { get; }
        /// <summary>
        /// volume of fuel in tank
        /// </summary>
        int TankState { get; }
        /// <summary>
        /// adding a fuel in tank
        /// </summary>
        /// <param name="newFuel"></param>
        void FillTank(int newFuel);
    }
}
