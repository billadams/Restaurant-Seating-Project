CREATE TABLE assignSection(
	assignID INT NOT NULL IDENTITY(1,1),
	sectionNum INT NOT NULL,
	tableNum INT NOT NULL,
	CONSTRAINT assignPK PRIMARY KEY(assignID),
	CONSTRAINT atableFK FOREIGN KEY(tableNum) REFERENCES thetable (tableNum),
	CONSTRAINT aSectionFK FOREIGN KEY(sectionNum) REFERENCES sections (sectionNum)
);