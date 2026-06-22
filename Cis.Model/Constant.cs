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

        public enum RecordStatus
        {
            Inactive,
            Active
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
                TermOfPayment = 113,
                Representative = 114
            }

            public enum Transaction
            {
                Sales = 200,
                Purchase = 201,
                PurchaseReturn = 203,
                SalesReturn = 204,
                StockTransfer = 205,
                StockOpname = 206,
                StockAdjustment = 207
            }

            public enum Reporting
            {
                Sales = 300,
                Purchase = 301,
                StockMovement = 302
            }


        }
    }

    public enum SalesOrderStatus
    {
        Draft = 0,
        Invoice = 1,
        Posted = 2,
        Cancelled = 3
    }

    public enum PurchaseOrderStatus
    {
        Draft = 0,
        Confirmed = 1,
        Received = 2,
        Cancelled = 3
    }

    public enum PostingStatus
    {
        Draft = 0,
        Posted = 1,
        Cancelled = 2
    }

    public enum StockMovementType
    {
        OpeningStock = 1,
        PurchaseReceipt = 2,
        SalesOut = 3,
        SalesReturn = 4,
        PurchaseReturn = 5,
        TransferOut = 6,
        TransferIn = 7,
        AdjustmentIn = 8,
        AdjustmentOut = 9
    }

    public enum MovementDirection
    {
        In = 1,
        Out = 2
    }

    public enum StockOpnameType
    {
        OpeningStock = 1,
        PhysicalCount = 2
    }

    public enum AdjustmentReason
    {
        StockOpname = 1,
        Damage = 2,
        Loss = 3,
        Expired = 4,
        Correction = 5,
        Other = 6
    }

    public enum StockTransferType
    {
        Out = 1,
        In = 2
    }
}
