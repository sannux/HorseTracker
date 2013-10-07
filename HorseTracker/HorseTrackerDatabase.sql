CREATE TABLE Users
(
	user_ID              VARCHAR(10) NOT NULL,
	username             VARCHAR() NOT NULL,
	fullname             VARCHAR(70) NOT NULL,
	password             NARCHAR(MAX) NOT NULL,
	dob                  TIMESTAMP NOT NULL,
	email                VARCHAR() NOT NULL,
	PRIMARY KEY (user_ID)
);

CREATE TABLE Jockeys
(
	jockey_ID            VARCHAR(10) NOT NULL,
	jockey_name          VARCHAR(70) NOT NULL,
	jockey_rating        DECIMAL(5,2) NULL,
	jockey_form          VARCHAR(30) NULL,
	PRIMARY KEY (jockey_ID)
);

CREATE TABLE Fav_Jockeys
(
	user_ID              VARCHAR(10) NOT NULL,
	jockey_ID            VARCHAR(10) NOT NULL,
	PRIMARY KEY (user_ID,jockey_ID),
	FOREIGN KEY R_3 (user_ID) REFERENCES Users (user_ID),
	FOREIGN KEY R_4 (jockey_ID) REFERENCES Jockeys (jockey_ID)
);

CREATE TABLE Horses
(
	horse_ID             VARCHAR(10) NOT NULL,
	horse_name           VARCHAR(70) NOT NULL,
	horse_age            INTEGER NOT NULL,
	horse_gender         CHAR(1) NOT NULL,
	horse_weight         DECIMAL(5,2) NOT NULL,
	day_since_last_run   INTEGER NULL,
	horse_form           VARCHAR(30) NULL,
	total_wins           INTEGER NULL,
	penalties            INTEGER NULL,
	horse_rating         DECIMAL(5,2) NULL,
	trainer              VARCHAR(70) NOT NULL,
	PRIMARY KEY (horse_ID)
);

CREATE TABLE Fav_Horses
(
	horse_ID             VARCHAR(10) NOT NULL,
	user_ID              VARCHAR(10) NOT NULL,
	PRIMARY KEY (horse_ID,user_ID),
	FOREIGN KEY R_1 (horse_ID) REFERENCES Horses (horse_ID),
	FOREIGN KEY R_2 (user_ID) REFERENCES Users (user_ID)
);

CREATE TABLE Events
(
	enent_ID             VARCHAR(10) NOT NULL,
	datetime             TIMESTAMP NOT NULL,
	event_name           VARCHAR(70) NOT NULL,
	race_type            VARCHAR(70) NOT NULL,
	min_age              INTEGER NOT NULL,
	max_age              INTEGER NOT NULL,
	mean_weight          DECIMAL(5,2) NOT NULL,
	numbers              INTEGER NOT NULL,
	going                VARCHAR(70) NOT NULL,
	PRIMARY KEY (enent_ID,datetime,event_name,race_type)
);

CREATE TABLE Meeting
(
	horse_ID             VARCHAR(10) NOT NULL,
	jockey_ID            VARCHAR(10) NOT NULL,
	enent_ID             VARCHAR(10) NOT NULL,
	result               INTEGER NULL,
	state                CHAR(1) NULL,
	datetime             BINARY(8) NULL,
	event_name           VARCHAR(70) NULL,
	race_type            VARCHAR(70) NULL,
	PRIMARY KEY (horse_ID,jockey_ID,enent_ID),
	FOREIGN KEY R_5 (horse_ID) REFERENCES Horses (horse_ID),
	FOREIGN KEY R_6 (jockey_ID) REFERENCES Jockeys (jockey_ID),
	FOREIGN KEY R_13 (enent_ID, datetime, event_name, race_type) REFERENCES Events (enent_ID, datetime, event_name, race_type)
);
