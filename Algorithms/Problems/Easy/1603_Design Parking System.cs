using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/design-parking-system/
    /// </summary>
    class _1603_Design_Parking_System
    {
        public class ParkingSystem
        {
            private int[] parkingLot;

            public ParkingSystem(int big, int medium, int small)
            {
                parkingLot = new int[4] { 0, big, medium, small };
            }

            public bool AddCar(int carType)
            {
                parkingLot[carType] -= 1;
                return parkingLot[carType] >= 0 ? true : false;
            }
        }
    }
}
