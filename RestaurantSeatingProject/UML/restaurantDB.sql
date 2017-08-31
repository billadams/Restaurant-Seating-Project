CREATE TABLE customer{
	lastName VARCHAR(30) NOT NULL,
	groupSize VARCHAR(20) NOT NULL,
	custTime  TIME NOT NULL,
	custID INT NOT NULL AUTO_INCREMENT,
	CONSTRAINT custPK  PRIMARY KEY(custID)
};
CREATE TABLE server{
	serverID INT NOT NULL AUTO_INCREMENT,
	personID INT NOT NULL,
	break TIME NULL,
	CONSTRAINT serverPK PRIMARY KEY(serverID),
	CONSTRAINT serverFK FOREIGN KEY(personID) REFERENCES persons(personID)
};
CREATE TABLE restTable{
	numChairs INT NOT NULL,
	restID INT NOT NULL,
	tableID INT NOT NULL AUTO_INCREMENT,
	CONSTRAINT tablePK PRIMARY KEY(tableID),
	CONSTRAINT restFK FOREIGN KEY(restID) REFERENCES restaurant (restID)
};
CREATE TABLE restaurant{
	name
	address
	city
	restState
	zip
	restID
};
CREATE TABLE section{
	tableID
	restID
};
CREATE TABLE reservation{
	lastName
	theDate
	theTime
	groupSize
	restID
	reservationID
};
CREATE TABLE persons{
	firstName
	lastName
	email
	personID
	restID
};
CREATE TABLE waitList{
	reservationID
	custID
};