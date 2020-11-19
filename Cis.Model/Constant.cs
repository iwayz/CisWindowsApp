using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Model
{
    public class Constant
    {
        public enum Gender
        {
            Female = 0,
            Male = 1
        }

        public enum LocationType
        {
            Province = 1,
            District = 2, // Kota/ Kecamatan
            SubDistrict = 3 // Kelurahan
        }
    }
}
