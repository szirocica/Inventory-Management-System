# Inventory-Management-System-2
Professional looking inventory management system using c#.Net, Bunifu and Guna UI elements, Sql server<br>

The Application allows to:<br>
-Create, delete and update users<br>
-Create, delete and update products.<br>
-Create, delete and update products categories.<br>
-Create, delete and update customers<br>
-Add Orders <br>
When a user orders a product, the product quantity is updated<br>
-The Order can be printed<br>
-A dashboard presents the Number of orders made by a particular customer, The total amount of the orders by the given customer and the date of the last order.<br>

How to use the application:<br>
-create an mdf database file and update sql connection<br>
-create the following tables:

CREATE TABLE [dbo].[CategoryTable] (
    [CategoryId]   INT          NOT NULL,
    [CategoryName] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([CategoryId] ASC)
);

CREATE TABLE [dbo].[CustomerTable] (
    [CustomerId]    INT          NOT NULL,
    [CustomerName]  VARCHAR (50) NOT NULL,
    [CustomerPhone] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([CustomerId] ASC)
);

CREATE TABLE [dbo].[OrderTable] (
    [OrderId]      INT          NOT NULL,
    [CustomerId]   INT          NOT NULL,
    [CustomerName] VARCHAR (50) NOT NULL,
    [OrderDate]    VARCHAR (50) NOT NULL,
    [TotalAmount]  INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([OrderId] ASC)
);

CREATE TABLE [dbo].[ProductTable] (
    [ProductId]          INT           NOT NULL,
    [ProductName]        VARCHAR (50)  NOT NULL,
    [ProductQuantity]    INT           NOT NULL,
    [ProductPrice]       INT           NOT NULL,
    [ProductDescription] VARCHAR (100) NOT NULL,
    [ProductCategory]    VARCHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([ProductId] ASC)
);

CREATE TABLE [dbo].[UserTable] (
    [Uname]     VARCHAR (50) NOT NULL,
    [Ufullname] VARCHAR (50) NOT NULL,
    [Upassword] VARCHAR (50) NOT NULL,
    [Uphone]    NCHAR (10)   NOT NULL,
    CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED ([Uphone] ASC)
);

-Insert a user to users table<br>
-start the app<br>
-login with the previously inserted user<br>


