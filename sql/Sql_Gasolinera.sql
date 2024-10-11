CREATE DATABASE GASOLINERA

CREATE TABLE Admin (
  admin_id VARCHAR(50),
  admin_password INT,
)

CREATE TABLE Deposits (
  deposits_id INT PRIMARY KEY,
  fuel_type VARCHAR(50),
  fuel_capacity FLOAT,
  price FLOAT,
);

CREATE TABLE Outlet(
  Outlet_id INT PRIMARY KEY,
  Outlet_Active VARCHAR(50),
  deposits_id INT,
  FOREIGN KEY(deposits_id) REFERENCES Deposits(deposits_id)
);

CREATE TABLE Sales(
  sales_id INT IDENTITY(1,1)PRIMARY KEY,
  Outlet_id INT,
  sale_date DATE,
  fuel_type VARCHAR(50),
  quantity FLOAT,
  FOREIGN KEY (Outlet_id) REFERENCES Outlet(Outlet_id)
  );

  CREATE TABLE Electric_charging(
  electric_id INT PRIMARY KEY,	
  charging_date DATE,
  energy_consumed FLOAT,
);


--CREATE TABLE Client (
  --client_fname VARCHAR(50),
  --client_telephone VARCHAR(50),
  --client_code INT,
  --sales_id INT,
  --FOREIGN KEY(sales_id) REFERENCES Sales(sales_id)
--);
 


Drop Table Admin
Drop Table Deposits
Drop Table Outlet
Drop Table Sales
Drop Table Electric_charging


Select*
from Admin

Select*
from Deposits

Select*
from Outlet

Select*
from Sales

SELECT admin_password FROM Admin WHERE admin_id = 'admin'

Select*
from Electric_charging



Insert into Deposits Values(1,'Gasolina 98',5000.00,1.70)
Insert into Deposits Values(2,'Gasolina 95',5000.00,2.10)
Insert into Deposits Values(3,'Biodiesel',5000.00,1.50)
Insert into Deposits Values(4,'Electric',null,2.00)


Insert into Outlet Values(1,'active',1)
Insert into Outlet Values(2,'active',2)
Insert into Outlet Values(3,'active',3)
Insert into Outlet Values(4,'active',4)

Insert into Admin Values('admin',1234)

Delete from Admin
Delete from Sales
Delete from Electric_charging
