using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Model
{
    public static class Constant
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


        public static class Permission
        {
            public enum PermissionType
            {
                Master,
                Transaction,
                Reporting
            }

            public enum MasterData
            {
                Product,
                Customer // TODO: add other master form
            }

            public enum Trasnsaction
            {
                Sales,
                Order,
                Return // TODO: add other transaction form
            }

            public enum Reporting
            {
                Sales,
                Order // TODO: add other reporting form
            }
        }


    }
}
