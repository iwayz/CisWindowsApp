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
                Master = 1,
                Transaction = 2,
                Reporting =3
            }

            public enum MasterData
            {
                Role = 100,
                User = 101,
                Location = 102,
                Uom = 103,
                OutletType = 104,
                MedicineType = 105,
                UsageType = 106,
                Principal = 107,
                Product = 108,
                Batch = 109,
                Customer = 110,
                SalesArea = 111,
                Salesman = 112,
                TermOfPayment = 113
            }

            public enum Transaction
            {
                Sales = 200,
                Order = 201
            }

            public enum Reporting
            {
                Sales,
                Order // TODO: add other reporting form
            }
        }


    }
}
