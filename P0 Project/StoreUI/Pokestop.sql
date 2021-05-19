drop table Managers;
drop table Customer;
drop table Product;
drop table Storefront;
drop table Inventory;
drop table Orders;
drop table LineItems;


create table Managers			--GOOD--
(
	managerName nvarchar(100) not null,
	managerID int primary key not null
);

create table Customer		    --GOOD--
( 
	customerName nvarchar(100) not null,
	customerPassword int primary key not null,
	Customerhometown nvarchar(100) not null
);
create table Product			--GOOD--
(
	productName varchar(20) not null,
	productPrice float not null,
	productCode int primary key not null
);
create table Storefront			--GOOD--
(
	storefrontTown nvarchar(100) not null,
	storefrontID int primary key not null
);
create table Inventory          --GOOD--
(
	inventoryID int primary key not null,
	inventoryQuantity int not null, 
	inventoryName int references Product(productCode),
	storeID int references Storefront(StorefrontID)
);
	

create table Orders				--GOOD--
(
	orderTiming int identity not null,
	orderID int primary key not null, 
    orderTotal float,
	orderCustomerID int references Customer(customerPassword),
	orderStroreFrontID int references Storefront(storefrontID)
	
);
create table LineItems			--GOOD--
(
	lineitemID int primary key not null,
	lineitemQuantity int not null,
	lineorderID int references Orders(orderID),
	lineproductID int references Product(productCode)
);


insert into Storefront(storefrontTown,storefrontID) values
('Viridian City', 10001) , ('Pewter City', 10002) , ('Mt. Moon', 10003) , ('Cerulean City', 10004) , ('Lavender Town', 10005) , ('Celadon City', 10006) , ('Vermillion City', 10007) , ('Fushia City', 10008) , ('Saffron City', 10009) , ('Cinnabar Island', 10010), ('Indigo Plateau', 10011);

select * From Storefront;

insert into Managers(managerName, managerID) values
('Brock', 1001), ('Misty', 1002), ('Lt. Surge', 1003), ('Erika', 1004), ('Janine', 1005), ('Sabrina', 1006), ('Blaine', 1007), ('Giovanni', 1008) , ('Lorelei', 1009), ('Bruno', 1010) , ('Agatha' , 1011), ('Lance', 1012), ('Blue', 1013); 

insert into Product(productName,productPrice,productCode) values
('Bicycle', 1000000, 000) , ('Pokeball', 200, 001), ('Great Ball', 600, 002), ('Utra Ball',1200,003), ('Antidote', 100, 004), ('Paralyze Heal', 200, 005), ('Burn Heal', 250, 006), ('Awakening', 200, 007), ('Escape Rope', 550, 008) , ('Repel', 350, 009) , ('Super Repel', 500, 010), ('Max Repel', 700, 011), ('Potion',300, 012), ('Super Potion', 700, 013), ('Hyper Potion', 1500, 014), ('Full Restore', 3000, 015);

insert into Customer (customerName, customerPassword, Customerhometown) values
('Ash', 2001, 'Pallet Town'), ('May', 2002, 'Littleroot Town')
insert into Inventory(inventoryID, inventoryQuantity,inventoryName, storeID) values
(100000, 0, 000, 10001), (100001, 0 , 001, 10001), (100002, 0, 002, 10001), (100003, 0 , 003, 10001),(100004, 0, 004, 10001), (100005, 0 , 005, 10001),(100006, 0, 006, 10001), (100007, 0 , 007, 10001),(100008, 0, 008, 10001), (100009, 0 , 009, 10001),(100010, 0, 010, 10001), (100011, 0 , 011, 10001), (100012, 0, 012, 10001),(100013, 0, 013, 10001),(100014, 0, 014, 10001),(100015, 0, 015, 10001),
(200000, 0, 000, 10002), (200001, 0 , 001, 10002), (200002, 0, 002, 10002), (200003, 0 , 003, 10002),(200004, 0, 004, 10002), (200005, 0 , 005, 10002), (200006, 0, 006, 10002), (200007, 0 , 007, 10002),(200008, 0, 008, 10002), (200009, 0 , 009, 10002),(200010, 0, 010, 10002), (200011, 0 , 011, 10002), (200012, 0, 012, 10002),(200013, 0, 013, 10002),(200014, 0, 014, 10002),(200015, 0, 015, 10002),
(300000, 0, 000, 10003), (300001, 0 , 001, 10003), (300002, 0, 002, 10003), (300003, 0 , 003, 10003),(300004, 0, 004, 10003), (300005, 0 , 005, 10003),(300006, 0, 006, 10003), (300007, 0 , 007, 10003),(300008, 0, 008, 10003), (300009, 0 , 009, 10003),(300010, 0, 010, 10003), (300011, 0 , 011, 10003), (300012, 0, 012, 10003),(300013, 0, 013, 10003),(300014, 0, 014, 10003),(300015, 0, 015, 10003),
(400000, 0, 000, 10004), (400001, 0 , 001, 10004), (400002, 0, 002, 10004), (400003, 0 , 003, 10004),(400004, 0, 004, 10004), (400005, 0 , 005, 10004),(400006, 0, 006, 10004), (400007, 0 , 007, 10004),(400008, 0, 008, 10004), (400009, 0 , 009, 10004),(400010, 0, 010, 10004), (400011, 0 , 011, 10004), (400012, 0, 012, 10004),(400013, 0, 013, 10004),(400014, 0, 014, 10004),(400015, 0, 015, 10004),
(500000, 0, 000, 10005), (500001, 0 , 001, 10005), (500002, 0, 002, 10005), (500003, 0 , 003, 10005),(500004, 0, 004, 10005), (500005, 0 , 005, 10005),(500006, 0, 006, 10005), (500007, 0 , 007, 10005),(500008, 0, 008, 10005), (500009, 0 , 009, 10005),(500010, 0, 010, 10005), (500011, 0 , 011, 10005), (500012, 0, 012, 10005),(500013, 0, 013, 10005),(500014, 0, 014, 10005),(500015, 0, 015, 10005),
(600000, 0, 000, 10006), (600001, 0 , 001, 10006), (600002, 0, 002, 10006), (600003, 0 , 003, 10006),(600004, 0, 004, 10006), (600005, 0 , 005, 10006),(600006, 0, 006, 10006), (600007, 0 , 007, 10006),(600008, 0, 008, 10006), (600009, 0 , 009, 10006),(600010, 0, 010, 10006), (600011, 0 , 011, 10006), (600012, 0, 012, 10006),(600013, 0, 013, 10006),(600014, 0, 014, 10006),(600015, 0, 015, 10006),
(700000, 0, 000, 10007), (700001, 0 , 001, 10007), (700002, 0, 002, 10007), (700003, 0 , 003, 10007),(700004, 0, 004, 10007), (700005, 0 , 005, 10007),(700006, 0, 006, 10007), (700007, 0 , 007, 10007),(700008, 0, 008, 10007), (700009, 0 , 009, 10007),(700010, 0, 010, 10007), (700011, 0 , 011, 10007), (700012, 0, 012, 10007),(700013, 0, 013, 10007),(700014, 0, 014, 10007),(700015, 0, 015, 10007),
(800000, 0, 000, 10008), (800001, 0 , 001, 10008), (800002, 0, 002, 10008), (800003, 0 , 003, 10008),(800004, 0, 004, 10008), (800005, 0 , 005, 10008),(800006, 0, 006, 10008), (800007, 0 , 007, 10008),(800008, 0, 008, 10008), (800009, 0 , 009, 10008),(800010, 0, 010, 10008), (800011, 0 , 011, 10008), (800012, 0, 012, 10008),(800013, 0, 013, 10008),(800014, 0, 014, 10008),(800015, 0, 015, 10008),
(900000, 0, 000, 10009), (900001, 0 , 001, 10009), (900002, 0, 002, 10009), (900003, 0 , 003, 10009),(900004, 0, 004, 10009), (900005, 0 , 005, 10009),(900006, 0, 006, 10009), (900007, 0 , 007, 10009),(900008, 0, 008, 10009), (900009, 0 , 009, 10009),(900010, 0, 010, 10009), (900011, 0 , 011, 10009), (900012, 0, 012, 10009),(900013, 0, 013, 10009),(900014, 0, 014, 10009),(900015, 0, 015, 10009),
(1000000, 0, 000, 10010), (1000001, 0 , 001, 10010), (1000002, 0, 002, 10010), (1000003, 0 , 003, 10010),(1000004, 0, 004, 10010), (1000005, 0 , 005, 10010),(1000006, 0, 006, 10010), (1000007, 0 , 007, 10010),(1000008, 0, 008, 10010), (1000009, 0 , 009, 10010),(1000010, 0, 010, 10010), (1000011, 0 , 011, 10010), (1000012, 0, 012, 10010),(1000013, 0, 013, 10010),(1000014, 0, 014, 10010),(1000015, 0, 015, 10010),
(1100000, 0, 000, 10011), (1100001, 0 , 001, 10011), (1100002, 0, 002, 10011), (1100003, 0 , 003, 10011),(1100004, 0, 004, 10011), (1100005, 0 , 005, 10011),(1100006, 0, 006, 10011), (1100007, 0 , 007, 10011),(1100008, 0, 008, 10011), (1100009, 0 , 009, 10011),(1100010, 0, 010, 10011), (1100011, 0 , 011, 10011), (1100012, 0, 012, 10011),(1100013, 0, 013, 10011),(1100014, 0, 014, 10011),(1100015, 0, 015, 10011);


insert into Orders (orderID, orderCustomerID, orderStroreFrontID) values
(11111, 2002, 10001), (11121, 2002, 10005);


select * from Product;
select * From Managers;
select * From Storefront;
select * from Customer;
select * from Orders;
select * from Inventory;
select * from Inventory where storeID = 10001;
select * from Inventory where storeID = 10002;
select * from Inventory where storeID = 10003;
select * from Inventory where storeID = 10004;
select * from Inventory where storeID = 10005;
select * from Inventory where storeID = 10006;
select * from Inventory where storeID = 10007;
select * from Inventory where storeID = 10008;
select * from Inventory where storeID = 10009;
select * from Inventory where storeID = 10010;
select * from Inventory where storeID = 10011;
