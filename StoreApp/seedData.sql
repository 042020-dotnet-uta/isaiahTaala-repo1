insert into Products ( Name, Price )
values 
	( 'slinky', 3.99 ),
	( 'rubik''s cube', 7.99 ),
	( 'etch-a-sketch', 11.99 ),
	( 'yo-yo', 4.49 ),
	( 'hula hoop', 2.59 ),
	( 'frisbee', 1.29 ),
	( 'simon', 17.79 );

-- Locations generated from https://www.randomlists.com/random-addresses
insert into Locations ( Address, City, State )
values
	( '789 Hillcrest Ave.', 'Lawrenceville', 'GA' ),
	( '498 North White Ave.', 'Ontario', 'CA' ),
	( '56 Gainsway Drive', 'Fremont', 'OH' );

insert into Inventories( ProductID, Quantity, LocationID )
values 
	( 1, 500, 1 ),
	( 1, 400, 2 ),
	( 1, 300, 3 ),
	( 2, 10, 1 ),
	( 2, 5, 2 ),
	( 2, 15, 3 ),
	( 3, 20, 1 ),
	( 3, 15, 2 ),
	( 3, 4, 3 ),
	( 4, 40, 1 ),
	( 4, 30, 2 ),
	( 4, 35, 3 ),
	( 5, 100, 1 ),
	( 5, 200, 2 ),
	( 5, 10, 3 ),
	( 6, 40, 1 ),
	( 6, 30, 2 ),
	( 6, 35, 3 ),
	( 7, 100, 1 ),
	( 7, 200, 2 ),
	( 7, 10, 3 );

--to reset users
--delete from users;
--DBCC CHECKIDENT (N'Users', RESEED, 0);

insert into Users ( FirstName, LastName, Email, Password )
values 
	( 'Admin', 'Admin', 'admin@gmail.com', 'adminadmin' ),
	( 'Fernando', 'Roberson', 'frob@gmail.com', 'ferr06on' ),
    ( 'Mike', 'Mclaughlin', 'mmcl@yahoo.com', 'mikmc1in' ),
    ( 'Lena', 'Spencer', 'lspe@aol.com', 'lensp3er' ),
    ( 'Don', 'Webster', 'dweb@gmail.com', 'donwe6er' ),
    ( 'Arlene', 'Lawrence', 'alaw@yahoo.com', 'arlla3ce' );

insert into Admins ( UserID )
values ( 1 );