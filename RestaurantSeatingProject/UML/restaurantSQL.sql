CREATE TABLE customer(
	lastName VARCHAR(30) NOT NULL,
	custTime  TIME NOT NULL,
	custID INT NOT NULL IDENTITY(1,1),
	CONSTRAINT custPK  PRIMARY KEY(custID)
);
CREATE TABLE server(
	firstName VARCHAR(25) NOT NULL,
	lastName VARCHAR(30) NOT NULL,
	serverID INT NOT NULL IDENTITY(1,1),
	empNum TIME NULL,
	CONSTRAINT serverPK PRIMARY KEY(serverID)
);

CREATE TABLE restaurants(
	name VARCHAR(25) NOT NULL,
	address VARCHAR(30) NOT NULL,
	city VARCHAR(25) NOT NULL,
	restState VARCHAR(2) NOT NULL,
	zip VARCHAR(5) NOT NULL,
	restaurantID INT NOT NULL IDENTITY(1,1),
	CONSTRAINT restaurantPK PRIMARY KEY(restaurantID)
);

CREATE TABLE reservations(
	theDate DATE NOT NULL,
	theTime TIME NOT NULL,
	groupSize INT NOT NULL,
	reservationID INT NOT NULL IDENTITY(1,1),
	CONSTRAINT reservationPK PRIMARY KEY(reservationID)
);

CREATE TABLE waitList(
	waitListID INT NOT NULL IDENTITY(1,1),
	custID INT NOT NULL,
	CONSTRAINT waitListPK PRIMARY KEY(waitListID),
	CONSTRAINT wCustFK FOREIGN KEY(custID) REFERENCES customer (custID)
);
CREATE TABLE tables(
	tableID INT NOT NULL IDENTITY(1,1),
	tableNum INT NOT NULL,
	numSeat INT NOT NULL,
	xposition INT NOT NULL,
	yposition INT NOT NULL,
	CONSTRAINT tablePK PRIMARY KEY(tableID)
);
CREATE TABLE sections(
	sectionID INT NOT NULL IDENTITY(1,1),
	sectionNum INT NOT NULL,
	CONSTRAINT sectionsPK PRIMARY KEY(sectionID)

);
CREATE TABLE assignSection(
	assignID INT NOT NULL IDENTITY(1,1),
	sectionNum INT NOT NULL,
	tableNum INT NOT NULL,
	CONSTRAINT assignPK PRIMARY KEY(assignID),
	CONSTRAINT atableFK FOREIGN KEY(tableNum) REFERENCES tables (tableNum),
	CONSTRAINT aSectionFK FOREIGN KEY(sectionNum) REFERENCES sections (sectionNum)
);