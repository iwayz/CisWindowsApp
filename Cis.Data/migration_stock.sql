-- Migration: 202606160001_AddStockManagement
-- Run this script via sqlcmd or SQL Server Management Studio

-- Supplier
CREATE TABLE [dbo].[Supplier] (
    [Id]            NVARCHAR(36)    NOT NULL,
    [SupplierCode]  NVARCHAR(20)    NOT NULL,
    [SupplierName]  NVARCHAR(100)   NOT NULL,
    [Address]       NVARCHAR(MAX)   NULL,
    [Phone]         NVARCHAR(20)    NULL,
    [Email]         NVARCHAR(100)   NULL,
    [ContactPerson] NVARCHAR(100)   NULL,
    [Npwp]          NVARCHAR(30)    NULL,
    [Status]        INT             NOT NULL DEFAULT(0),
    [CreatedBy]     NVARCHAR(36)    NOT NULL,
    [CreatedAt]     DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    [ModifiedBy]    NVARCHAR(36)    NOT NULL,
    [ModifiedAt]    DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    CONSTRAINT [PK_Supplier] PRIMARY KEY ([Id])
);
CREATE UNIQUE INDEX [IX_Supplier_SupplierCode] ON [dbo].[Supplier] ([SupplierCode]);
GO

-- PurchaseOrder
CREATE TABLE [dbo].[PurchaseOrder] (
    [Id]                  NVARCHAR(36)    NOT NULL,
    [PONumber]            NVARCHAR(20)    NOT NULL,
    [SupplierId]          NVARCHAR(36)    NOT NULL,
    [SupplierName]        NVARCHAR(100)   NOT NULL,
    [SupplierAddress]     NVARCHAR(MAX)   NULL,
    [SupplierPhone]       NVARCHAR(20)    NULL,
    [OrderDate]           DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    [ExpectedDate]        DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    [ReceivedDate]        DATETIME2       NULL,
    [SubTotalAmount]      DECIMAL(15,5)   NOT NULL DEFAULT(0),
    [TaxBaseAmount]       DECIMAL(15,5)   NOT NULL DEFAULT(0),
    [ValueAddedTaxAmount] DECIMAL(15,5)   NOT NULL DEFAULT(0),
    [GrandTotalAmount]    DECIMAL(15,5)   NOT NULL DEFAULT(0),
    [Notes]               NVARCHAR(MAX)   NULL,
    [PostingStatus]       INT             NOT NULL DEFAULT(0),
    [UserId]              NVARCHAR(36)    NOT NULL,
    [Username]            NVARCHAR(50)    NOT NULL,
    [CreatedBy]           NVARCHAR(36)    NOT NULL,
    [CreatedAt]           DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    [ModifiedBy]          NVARCHAR(36)    NOT NULL,
    [ModifiedAt]          DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    CONSTRAINT [PK_PurchaseOrder] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_PurchaseOrder_Supplier] FOREIGN KEY ([SupplierId]) REFERENCES [dbo].[Supplier]([Id]),
    CONSTRAINT [FK_PurchaseOrder_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User]([Id])
);
CREATE UNIQUE INDEX [IX_PurchaseOrder_PONumber] ON [dbo].[PurchaseOrder] ([PONumber]);
CREATE INDEX [IX_PurchaseOrder_SupplierId] ON [dbo].[PurchaseOrder] ([SupplierId]);
CREATE INDEX [IX_PurchaseOrder_UserId] ON [dbo].[PurchaseOrder] ([UserId]);
GO

-- PurchaseOrderItem
CREATE TABLE [dbo].[PurchaseOrderItem] (
    [Id]                 NVARCHAR(36)    NOT NULL,
    [PurchaseOrderId]    NVARCHAR(36)    NOT NULL,
    [ProductId]          NVARCHAR(36)    NOT NULL,
    [ProductCode]        NVARCHAR(50)    NOT NULL,
    [ProductName]        NVARCHAR(100)   NOT NULL,
    [BatchId]            NVARCHAR(36)    NULL,
    [BatchCode]          NVARCHAR(50)    NULL,
    [ExpiredDate]        DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    [Quantity]           INT             NOT NULL DEFAULT(0),
    [UomId]              NVARCHAR(36)    NOT NULL,
    [UomCode]            NVARCHAR(20)    NOT NULL,
    [Price]              DECIMAL(15,5)   NOT NULL DEFAULT(0),
    [DiscountPercentage] REAL            NOT NULL DEFAULT(0),
    [TotalAmount]        DECIMAL(15,5)   NOT NULL DEFAULT(0),
    [CreatedBy]          NVARCHAR(36)    NOT NULL,
    [CreatedAt]          DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    [ModifiedBy]         NVARCHAR(36)    NOT NULL,
    [ModifiedAt]         DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    CONSTRAINT [PK_PurchaseOrderItem] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_PurchaseOrderItem_PurchaseOrder] FOREIGN KEY ([PurchaseOrderId]) REFERENCES [dbo].[PurchaseOrder]([Id]),
    CONSTRAINT [FK_PurchaseOrderItem_Product] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product]([Id]),
    CONSTRAINT [FK_PurchaseOrderItem_UOM] FOREIGN KEY ([UomId]) REFERENCES [dbo].[UnitOfMeasurement]([Id])
);
CREATE INDEX [IX_PurchaseOrderItem_PurchaseOrderId] ON [dbo].[PurchaseOrderItem] ([PurchaseOrderId]);
CREATE INDEX [IX_PurchaseOrderItem_ProductId] ON [dbo].[PurchaseOrderItem] ([ProductId]);
GO

-- PurchaseReturn
CREATE TABLE [dbo].[PurchaseReturn] (
    [Id]            NVARCHAR(36)    NOT NULL,
    [ReturnNumber]  NVARCHAR(20)    NOT NULL,
    [PurchaseOrderId] NVARCHAR(36)  NOT NULL,
    [PONumber]      NVARCHAR(20)    NOT NULL,
    [SupplierId]    NVARCHAR(36)    NOT NULL,
    [SupplierName]  NVARCHAR(100)   NOT NULL,
    [ReturnDate]    DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    [Reason]        NVARCHAR(MAX)   NULL,
    [TotalAmount]   DECIMAL(15,5)   NOT NULL DEFAULT(0),
    [PostingStatus] INT             NOT NULL DEFAULT(0),
    [UserId]        NVARCHAR(36)    NOT NULL,
    [Username]      NVARCHAR(50)    NOT NULL,
    [CreatedBy]     NVARCHAR(36)    NOT NULL,
    [CreatedAt]     DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    [ModifiedBy]    NVARCHAR(36)    NOT NULL,
    [ModifiedAt]    DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    CONSTRAINT [PK_PurchaseReturn] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_PurchaseReturn_PurchaseOrder] FOREIGN KEY ([PurchaseOrderId]) REFERENCES [dbo].[PurchaseOrder]([Id]),
    CONSTRAINT [FK_PurchaseReturn_Supplier] FOREIGN KEY ([SupplierId]) REFERENCES [dbo].[Supplier]([Id]),
    CONSTRAINT [FK_PurchaseReturn_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User]([Id])
);
CREATE UNIQUE INDEX [IX_PurchaseReturn_ReturnNumber] ON [dbo].[PurchaseReturn] ([ReturnNumber]);
CREATE INDEX [IX_PurchaseReturn_PurchaseOrderId] ON [dbo].[PurchaseReturn] ([PurchaseOrderId]);
GO

-- PurchaseReturnItem
CREATE TABLE [dbo].[PurchaseReturnItem] (
    [Id]               NVARCHAR(36)    NOT NULL,
    [PurchaseReturnId] NVARCHAR(36)    NOT NULL,
    [ProductId]        NVARCHAR(36)    NOT NULL,
    [ProductCode]      NVARCHAR(50)    NOT NULL,
    [ProductName]      NVARCHAR(100)   NOT NULL,
    [BatchId]          NVARCHAR(36)    NULL,
    [BatchCode]        NVARCHAR(50)    NULL,
    [ExpiredDate]      DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    [Quantity]         INT             NOT NULL DEFAULT(0),
    [UomId]            NVARCHAR(36)    NOT NULL,
    [UomCode]          NVARCHAR(20)    NOT NULL,
    [Price]            DECIMAL(15,5)   NOT NULL DEFAULT(0),
    [TotalAmount]      DECIMAL(15,5)   NOT NULL DEFAULT(0),
    [CreatedBy]        NVARCHAR(36)    NOT NULL,
    [CreatedAt]        DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    [ModifiedBy]       NVARCHAR(36)    NOT NULL,
    [ModifiedAt]       DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    CONSTRAINT [PK_PurchaseReturnItem] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_PurchaseReturnItem_PurchaseReturn] FOREIGN KEY ([PurchaseReturnId]) REFERENCES [dbo].[PurchaseReturn]([Id]),
    CONSTRAINT [FK_PurchaseReturnItem_Product] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product]([Id]),
    CONSTRAINT [FK_PurchaseReturnItem_UOM] FOREIGN KEY ([UomId]) REFERENCES [dbo].[UnitOfMeasurement]([Id])
);
CREATE INDEX [IX_PurchaseReturnItem_PurchaseReturnId] ON [dbo].[PurchaseReturnItem] ([PurchaseReturnId]);
GO

-- SalesReturn
CREATE TABLE [dbo].[SalesReturn] (
    [Id]            NVARCHAR(36)    NOT NULL,
    [ReturnNumber]  NVARCHAR(20)    NOT NULL,
    [SalesOrderId]  NVARCHAR(36)    NOT NULL,
    [SalesNo]       NVARCHAR(20)    NOT NULL,
    [CustomerId]    NVARCHAR(36)    NOT NULL,
    [CustomerName]  NVARCHAR(100)   NOT NULL,
    [ReturnDate]    DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    [Reason]        NVARCHAR(MAX)   NULL,
    [TotalAmount]   DECIMAL(15,5)   NOT NULL DEFAULT(0),
    [PostingStatus] INT             NOT NULL DEFAULT(0),
    [UserId]        NVARCHAR(36)    NOT NULL,
    [Username]      NVARCHAR(50)    NOT NULL,
    [CreatedBy]     NVARCHAR(36)    NOT NULL,
    [CreatedAt]     DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    [ModifiedBy]    NVARCHAR(36)    NOT NULL,
    [ModifiedAt]    DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    CONSTRAINT [PK_SalesReturn] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SalesReturn_SalesOrder] FOREIGN KEY ([SalesOrderId]) REFERENCES [dbo].[SalesOrder]([Id]),
    CONSTRAINT [FK_SalesReturn_Customer] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customer]([Id]),
    CONSTRAINT [FK_SalesReturn_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User]([Id])
);
CREATE UNIQUE INDEX [IX_SalesReturn_ReturnNumber] ON [dbo].[SalesReturn] ([ReturnNumber]);
CREATE INDEX [IX_SalesReturn_SalesOrderId] ON [dbo].[SalesReturn] ([SalesOrderId]);
GO

-- SalesReturnItem
CREATE TABLE [dbo].[SalesReturnItem] (
    [Id]            NVARCHAR(36)    NOT NULL,
    [SalesReturnId] NVARCHAR(36)    NOT NULL,
    [ProductId]     NVARCHAR(36)    NOT NULL,
    [ProductCode]   NVARCHAR(50)    NOT NULL,
    [ProductName]   NVARCHAR(100)   NOT NULL,
    [BatchId]       NVARCHAR(36)    NULL,
    [BatchCode]     NVARCHAR(50)    NULL,
    [ExpiredDate]   DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    [Quantity]      INT             NOT NULL DEFAULT(0),
    [UomId]         NVARCHAR(36)    NOT NULL,
    [UomCode]       NVARCHAR(20)    NOT NULL,
    [Price]         DECIMAL(15,5)   NOT NULL DEFAULT(0),
    [TotalAmount]   DECIMAL(15,5)   NOT NULL DEFAULT(0),
    [CreatedBy]     NVARCHAR(36)    NOT NULL,
    [CreatedAt]     DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    [ModifiedBy]    NVARCHAR(36)    NOT NULL,
    [ModifiedAt]    DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    CONSTRAINT [PK_SalesReturnItem] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SalesReturnItem_SalesReturn] FOREIGN KEY ([SalesReturnId]) REFERENCES [dbo].[SalesReturn]([Id]),
    CONSTRAINT [FK_SalesReturnItem_Product] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product]([Id]),
    CONSTRAINT [FK_SalesReturnItem_UOM] FOREIGN KEY ([UomId]) REFERENCES [dbo].[UnitOfMeasurement]([Id])
);
CREATE INDEX [IX_SalesReturnItem_SalesReturnId] ON [dbo].[SalesReturnItem] ([SalesReturnId]);
GO

-- StockCard
CREATE TABLE [dbo].[StockCard] (
    [Id]           NVARCHAR(36)    NOT NULL,
    [ProductId]    NVARCHAR(36)    NOT NULL,
    [ProductCode]  NVARCHAR(50)    NOT NULL,
    [ProductName]  NVARCHAR(100)   NOT NULL,
    [BatchId]      NVARCHAR(36)    NULL,
    [BatchCode]    NVARCHAR(50)    NULL,
    [QtyOnHand]    DECIMAL(15,5)   NOT NULL DEFAULT(0),
    [QtyReserved]  DECIMAL(15,5)   NOT NULL DEFAULT(0),
    [CreatedBy]    NVARCHAR(36)    NOT NULL,
    [CreatedAt]    DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    [ModifiedBy]   NVARCHAR(36)    NOT NULL,
    [ModifiedAt]   DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    CONSTRAINT [PK_StockCard] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_StockCard_Product] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product]([Id])
);
CREATE UNIQUE INDEX [IX_StockCard_ProductBatch] ON [dbo].[StockCard] ([ProductId], [BatchId]);
GO

-- StockMovement
CREATE TABLE [dbo].[StockMovement] (
    [Id]            NVARCHAR(36)    NOT NULL,
    [MovementDate]  DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    [MovementType]  INT             NOT NULL DEFAULT(0),
    [Direction]     INT             NOT NULL DEFAULT(0),
    [ProductId]     NVARCHAR(36)    NOT NULL,
    [ProductCode]   NVARCHAR(50)    NOT NULL,
    [ProductName]   NVARCHAR(100)   NOT NULL,
    [BatchId]       NVARCHAR(36)    NULL,
    [BatchCode]     NVARCHAR(50)    NULL,
    [Qty]           DECIMAL(15,5)   NOT NULL DEFAULT(0),
    [ReferenceType] NVARCHAR(50)    NULL,
    [ReferenceId]   NVARCHAR(36)    NULL,
    [Remarks]       NVARCHAR(MAX)   NULL,
    [CreatedBy]     NVARCHAR(36)    NOT NULL,
    [CreatedAt]     DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    [ModifiedBy]    NVARCHAR(36)    NOT NULL,
    [ModifiedAt]    DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    CONSTRAINT [PK_StockMovement] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_StockMovement_Product] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product]([Id])
);
CREATE INDEX [IX_StockMovement_ProductId] ON [dbo].[StockMovement] ([ProductId]);
CREATE INDEX [IX_StockMovement_MovementDate] ON [dbo].[StockMovement] ([MovementDate]);
GO

-- StockTransfer
CREATE TABLE [dbo].[StockTransfer] (
    [Id]             NVARCHAR(36)    NOT NULL,
    [TransferNumber] NVARCHAR(20)    NOT NULL,
    [TransferType]   INT             NOT NULL DEFAULT(0),
    [BranchName]     NVARCHAR(100)   NOT NULL,
    [TransferDate]   DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    [Notes]          NVARCHAR(MAX)   NULL,
    [PostingStatus]  INT             NOT NULL DEFAULT(0),
    [UserId]         NVARCHAR(36)    NOT NULL,
    [Username]       NVARCHAR(50)    NOT NULL,
    [CreatedBy]      NVARCHAR(36)    NOT NULL,
    [CreatedAt]      DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    [ModifiedBy]     NVARCHAR(36)    NOT NULL,
    [ModifiedAt]     DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    CONSTRAINT [PK_StockTransfer] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_StockTransfer_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User]([Id])
);
CREATE UNIQUE INDEX [IX_StockTransfer_TransferNumber] ON [dbo].[StockTransfer] ([TransferNumber]);
GO

-- StockTransferItem
CREATE TABLE [dbo].[StockTransferItem] (
    [Id]               NVARCHAR(36)    NOT NULL,
    [StockTransferId]  NVARCHAR(36)    NOT NULL,
    [ProductId]        NVARCHAR(36)    NOT NULL,
    [ProductCode]      NVARCHAR(50)    NOT NULL,
    [ProductName]      NVARCHAR(100)   NOT NULL,
    [BatchId]          NVARCHAR(36)    NULL,
    [BatchCode]        NVARCHAR(50)    NULL,
    [Quantity]         DECIMAL(15,5)   NOT NULL DEFAULT(0),
    [UomId]            NVARCHAR(36)    NOT NULL,
    [UomCode]          NVARCHAR(20)    NOT NULL,
    [CreatedBy]        NVARCHAR(36)    NOT NULL,
    [CreatedAt]        DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    [ModifiedBy]       NVARCHAR(36)    NOT NULL,
    [ModifiedAt]       DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    CONSTRAINT [PK_StockTransferItem] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_StockTransferItem_StockTransfer] FOREIGN KEY ([StockTransferId]) REFERENCES [dbo].[StockTransfer]([Id]),
    CONSTRAINT [FK_StockTransferItem_Product] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product]([Id]),
    CONSTRAINT [FK_StockTransferItem_UOM] FOREIGN KEY ([UomId]) REFERENCES [dbo].[UnitOfMeasurement]([Id])
);
CREATE INDEX [IX_StockTransferItem_StockTransferId] ON [dbo].[StockTransferItem] ([StockTransferId]);
GO

-- StockOpname
CREATE TABLE [dbo].[StockOpname] (
    [Id]            NVARCHAR(36)    NOT NULL,
    [OpnameNumber]  NVARCHAR(20)    NOT NULL,
    [OpnameType]    INT             NOT NULL DEFAULT(0),
    [OpnameDate]    DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    [Notes]         NVARCHAR(MAX)   NULL,
    [PostingStatus] INT             NOT NULL DEFAULT(0),
    [UserId]        NVARCHAR(36)    NOT NULL,
    [Username]      NVARCHAR(50)    NOT NULL,
    [CreatedBy]     NVARCHAR(36)    NOT NULL,
    [CreatedAt]     DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    [ModifiedBy]    NVARCHAR(36)    NOT NULL,
    [ModifiedAt]    DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    CONSTRAINT [PK_StockOpname] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_StockOpname_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User]([Id])
);
CREATE UNIQUE INDEX [IX_StockOpname_OpnameNumber] ON [dbo].[StockOpname] ([OpnameNumber]);
GO

-- StockOpnameItem
CREATE TABLE [dbo].[StockOpnameItem] (
    [Id]            NVARCHAR(36)    NOT NULL,
    [StockOpnameId] NVARCHAR(36)    NOT NULL,
    [ProductId]     NVARCHAR(36)    NOT NULL,
    [ProductCode]   NVARCHAR(50)    NOT NULL,
    [ProductName]   NVARCHAR(100)   NOT NULL,
    [BatchId]       NVARCHAR(36)    NULL,
    [BatchCode]     NVARCHAR(50)    NULL,
    [UomId]         NVARCHAR(36)    NOT NULL,
    [UomCode]       NVARCHAR(20)    NOT NULL,
    [QtySystem]     DECIMAL(15,5)   NOT NULL DEFAULT(0),
    [QtyPhysical]   DECIMAL(15,5)   NOT NULL DEFAULT(0),
    [Difference]    DECIMAL(15,5)   NOT NULL DEFAULT(0),
    [CreatedBy]     NVARCHAR(36)    NOT NULL,
    [CreatedAt]     DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    [ModifiedBy]    NVARCHAR(36)    NOT NULL,
    [ModifiedAt]    DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    CONSTRAINT [PK_StockOpnameItem] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_StockOpnameItem_StockOpname] FOREIGN KEY ([StockOpnameId]) REFERENCES [dbo].[StockOpname]([Id]),
    CONSTRAINT [FK_StockOpnameItem_Product] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product]([Id]),
    CONSTRAINT [FK_StockOpnameItem_UOM] FOREIGN KEY ([UomId]) REFERENCES [dbo].[UnitOfMeasurement]([Id])
);
CREATE INDEX [IX_StockOpnameItem_StockOpnameId] ON [dbo].[StockOpnameItem] ([StockOpnameId]);
GO

-- StockAdjustment
CREATE TABLE [dbo].[StockAdjustment] (
    [Id]               NVARCHAR(36)    NOT NULL,
    [AdjustmentNumber] NVARCHAR(20)    NOT NULL,
    [AdjustmentDate]   DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    [Reason]           INT             NOT NULL DEFAULT(0),
    [Notes]            NVARCHAR(MAX)   NULL,
    [PostingStatus]    INT             NOT NULL DEFAULT(0),
    [UserId]           NVARCHAR(36)    NOT NULL,
    [Username]         NVARCHAR(50)    NOT NULL,
    [StockOpnameId]    NVARCHAR(36)    NULL,
    [CreatedBy]        NVARCHAR(36)    NOT NULL,
    [CreatedAt]        DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    [ModifiedBy]       NVARCHAR(36)    NOT NULL,
    [ModifiedAt]       DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    CONSTRAINT [PK_StockAdjustment] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_StockAdjustment_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User]([Id]),
    CONSTRAINT [FK_StockAdjustment_StockOpname] FOREIGN KEY ([StockOpnameId]) REFERENCES [dbo].[StockOpname]([Id])
);
CREATE UNIQUE INDEX [IX_StockAdjustment_AdjustmentNumber] ON [dbo].[StockAdjustment] ([AdjustmentNumber]);
GO

-- StockAdjustmentItem
CREATE TABLE [dbo].[StockAdjustmentItem] (
    [Id]                NVARCHAR(36)    NOT NULL,
    [StockAdjustmentId] NVARCHAR(36)    NOT NULL,
    [ProductId]         NVARCHAR(36)    NOT NULL,
    [ProductCode]       NVARCHAR(50)    NOT NULL,
    [ProductName]       NVARCHAR(100)   NOT NULL,
    [BatchId]           NVARCHAR(36)    NULL,
    [BatchCode]         NVARCHAR(50)    NULL,
    [UomId]             NVARCHAR(36)    NOT NULL,
    [UomCode]           NVARCHAR(20)    NOT NULL,
    [QtyBefore]         DECIMAL(15,5)   NOT NULL DEFAULT(0),
    [QtyAdjustment]     DECIMAL(15,5)   NOT NULL DEFAULT(0),
    [QtyAfter]          DECIMAL(15,5)   NOT NULL DEFAULT(0),
    [Direction]         INT             NOT NULL DEFAULT(0),
    [CreatedBy]         NVARCHAR(36)    NOT NULL,
    [CreatedAt]         DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    [ModifiedBy]        NVARCHAR(36)    NOT NULL,
    [ModifiedAt]        DATETIME2       NOT NULL DEFAULT('1900-01-01'),
    CONSTRAINT [PK_StockAdjustmentItem] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_StockAdjustmentItem_StockAdjustment] FOREIGN KEY ([StockAdjustmentId]) REFERENCES [dbo].[StockAdjustment]([Id]),
    CONSTRAINT [FK_StockAdjustmentItem_Product] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product]([Id]),
    CONSTRAINT [FK_StockAdjustmentItem_UOM] FOREIGN KEY ([UomId]) REFERENCES [dbo].[UnitOfMeasurement]([Id])
);
CREATE INDEX [IX_StockAdjustmentItem_StockAdjustmentId] ON [dbo].[StockAdjustmentItem] ([StockAdjustmentId]);
GO

-- Alter SalesOrder: add PostingStatus
IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE Name = N'PostingStatus' AND Object_ID = Object_ID(N'dbo.SalesOrder'))
BEGIN
    ALTER TABLE [dbo].[SalesOrder] ADD [PostingStatus] INT NOT NULL DEFAULT(0);
END
GO

-- Alter Product: add IsBatchTracked
IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE Name = N'IsBatchTracked' AND Object_ID = Object_ID(N'dbo.Product'))
BEGIN
    ALTER TABLE [dbo].[Product] ADD [IsBatchTracked] BIT NOT NULL DEFAULT(0);
END
GO

-- Register migration in __MigrationHistory so EF knows it has been applied
INSERT INTO [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (
    '202606160001_AddStockManagement',
    'Cis.Data.Migrations.Configuration',
    0x1F8B0800000000000400ECBD07601C499625262F6DCA7DB31437953AF3F9D3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B3B,
    '6.4.4'
);
GO
