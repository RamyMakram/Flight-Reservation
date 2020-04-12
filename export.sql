--------------------------------------------------------
--  File created - Sunday-April-12-2020   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Sequence SEQUENCE1
--------------------------------------------------------

   CREATE SEQUENCE  "HR"."SEQUENCE1"  MINVALUE 1 MAXVALUE 9999 INCREMENT BY 1 START WITH 101 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Table ADMINISTRATOR
--------------------------------------------------------

  CREATE TABLE "HR"."ADMINISTRATOR" 
   (	"ADMINISTRATOR_ID" NUMBER(10,0), 
	"ADMINISTRATOR_USER" VARCHAR2(250), 
	"ADMINISTRATOR_PASSWORD" VARCHAR2(250)
   ) ;
--------------------------------------------------------
--  DDL for Table AIRPLANE_INFO
--------------------------------------------------------

  CREATE TABLE "HR"."AIRPLANE_INFO" 
   (	"AIRPLANE_ID" NUMBER(10,0), 
	"AIRPLANE_NUMSEATS" VARCHAR2(250), 
	"AIRPLANETYPE_NAME" VARCHAR2(50)
   ) ;
--------------------------------------------------------
--  DDL for Table AIRPORT
--------------------------------------------------------

  CREATE TABLE "HR"."AIRPORT" 
   (	"AIRPORT_CODE" NUMBER(10,0), 
	"AIRPORT_NAME" VARCHAR2(50), 
	"AIRPORT_CITY" VARCHAR2(50)
   ) ;
--------------------------------------------------------
--  DDL for Table FLIGHT
--------------------------------------------------------

  CREATE TABLE "HR"."FLIGHT" 
   (	"FLIGHT_NUM" NUMBER(10,0), 
	"FROM_CODE" NUMBER(10,0), 
	"FROM_TIME" TIMESTAMP (6), 
	"TO_TIME" TIMESTAMP (6), 
	"TO_CODE" NUMBER(10,0), 
	"PRICE" NUMBER, 
	"STATUE" VARCHAR2(50), 
	"AIRPLAN_ID" NUMBER
   ) ;
 

   COMMENT ON COLUMN "HR"."FLIGHT"."FROM_CODE" IS 'from city ';
 
   COMMENT ON COLUMN "HR"."FLIGHT"."FROM_TIME" IS 'arrive time';
 
   COMMENT ON COLUMN "HR"."FLIGHT"."TO_TIME" IS 'leave time';
 
   COMMENT ON COLUMN "HR"."FLIGHT"."TO_CODE" IS 'to city';
--------------------------------------------------------
--  DDL for Table PASSENGER
--------------------------------------------------------

  CREATE TABLE "HR"."PASSENGER" 
   (	"PASSENGER_ID" NUMBER(10,0), 
	"PASSENGER_FNAME" VARCHAR2(250), 
	"PASSENGER_LNAME" VARCHAR2(250), 
	"PASSENGER_EMAIL" VARCHAR2(250), 
	"PASSENGER_PASSWORD" VARCHAR2(250), 
	"PASSENGER_PHONE" VARCHAR2(250)
   ) ;
--------------------------------------------------------
--  DDL for Table PASSENGER_FLIGHT
--------------------------------------------------------

  CREATE TABLE "HR"."PASSENGER_FLIGHT" 
   (	"PASSENGER_ID" NUMBER(10,0), 
	"FLIGHT_NUM" NUMBER(10,0), 
	"PRICE" NUMBER
   ) ;
--------------------------------------------------------
--  DDL for Table PROBLEM
--------------------------------------------------------

  CREATE TABLE "HR"."PROBLEM" 
   (	"PASSENGER_ID" NUMBER(10,0), 
	"PROBLEM_NAME" VARCHAR2(250), 
	"PROBLEM_DEFINE" VARCHAR2(250)
   ) ;
--------------------------------------------------------
--  DDL for Table SOLVE
--------------------------------------------------------

  CREATE TABLE "HR"."SOLVE" 
   (	"ADMINISTRATOR_ID" NUMBER(10,0), 
	"PROBLEM_NAME" VARCHAR2(250)
   ) ;

---------------------------------------------------
--   DATA FOR TABLE PROBLEM
--   FILTER = none used
---------------------------------------------------
REM INSERTING into HR.PROBLEM

---------------------------------------------------
--   END DATA FOR TABLE PROBLEM
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE SOLVE
--   FILTER = none used
---------------------------------------------------
REM INSERTING into HR.SOLVE

---------------------------------------------------
--   END DATA FOR TABLE SOLVE
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE PASSENGER_FLIGHT
--   FILTER = none used
---------------------------------------------------
REM INSERTING into HR.PASSENGER_FLIGHT
Insert into HR.PASSENGER_FLIGHT (PASSENGER_ID,FLIGHT_NUM,PRICE) values (26,84,100);
Insert into HR.PASSENGER_FLIGHT (PASSENGER_ID,FLIGHT_NUM,PRICE) values (26,84,100);
Insert into HR.PASSENGER_FLIGHT (PASSENGER_ID,FLIGHT_NUM,PRICE) values (26,84,100);
Insert into HR.PASSENGER_FLIGHT (PASSENGER_ID,FLIGHT_NUM,PRICE) values (26,84,100);
Insert into HR.PASSENGER_FLIGHT (PASSENGER_ID,FLIGHT_NUM,PRICE) values (26,84,100);
Insert into HR.PASSENGER_FLIGHT (PASSENGER_ID,FLIGHT_NUM,PRICE) values (26,84,100);
Insert into HR.PASSENGER_FLIGHT (PASSENGER_ID,FLIGHT_NUM,PRICE) values (26,84,100);
Insert into HR.PASSENGER_FLIGHT (PASSENGER_ID,FLIGHT_NUM,PRICE) values (26,84,100);
Insert into HR.PASSENGER_FLIGHT (PASSENGER_ID,FLIGHT_NUM,PRICE) values (26,84,100);
Insert into HR.PASSENGER_FLIGHT (PASSENGER_ID,FLIGHT_NUM,PRICE) values (26,84,100);
Insert into HR.PASSENGER_FLIGHT (PASSENGER_ID,FLIGHT_NUM,PRICE) values (26,84,100);
Insert into HR.PASSENGER_FLIGHT (PASSENGER_ID,FLIGHT_NUM,PRICE) values (26,84,100);
Insert into HR.PASSENGER_FLIGHT (PASSENGER_ID,FLIGHT_NUM,PRICE) values (26,84,100);
Insert into HR.PASSENGER_FLIGHT (PASSENGER_ID,FLIGHT_NUM,PRICE) values (26,84,100);
Insert into HR.PASSENGER_FLIGHT (PASSENGER_ID,FLIGHT_NUM,PRICE) values (26,84,100);
Insert into HR.PASSENGER_FLIGHT (PASSENGER_ID,FLIGHT_NUM,PRICE) values (26,84,100);
Insert into HR.PASSENGER_FLIGHT (PASSENGER_ID,FLIGHT_NUM,PRICE) values (26,84,100);
Insert into HR.PASSENGER_FLIGHT (PASSENGER_ID,FLIGHT_NUM,PRICE) values (26,84,100);
Insert into HR.PASSENGER_FLIGHT (PASSENGER_ID,FLIGHT_NUM,PRICE) values (26,84,100);
Insert into HR.PASSENGER_FLIGHT (PASSENGER_ID,FLIGHT_NUM,PRICE) values (26,84,100);
Insert into HR.PASSENGER_FLIGHT (PASSENGER_ID,FLIGHT_NUM,PRICE) values (26,84,100);
Insert into HR.PASSENGER_FLIGHT (PASSENGER_ID,FLIGHT_NUM,PRICE) values (26,84,100);
Insert into HR.PASSENGER_FLIGHT (PASSENGER_ID,FLIGHT_NUM,PRICE) values (26,84,100);
Insert into HR.PASSENGER_FLIGHT (PASSENGER_ID,FLIGHT_NUM,PRICE) values (26,84,100);
Insert into HR.PASSENGER_FLIGHT (PASSENGER_ID,FLIGHT_NUM,PRICE) values (26,84,100);
Insert into HR.PASSENGER_FLIGHT (PASSENGER_ID,FLIGHT_NUM,PRICE) values (26,84,100);
Insert into HR.PASSENGER_FLIGHT (PASSENGER_ID,FLIGHT_NUM,PRICE) values (26,84,100);
Insert into HR.PASSENGER_FLIGHT (PASSENGER_ID,FLIGHT_NUM,PRICE) values (26,84,100);

---------------------------------------------------
--   END DATA FOR TABLE PASSENGER_FLIGHT
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE ADMINISTRATOR
--   FILTER = none used
---------------------------------------------------
REM INSERTING into HR.ADMINISTRATOR
Insert into HR.ADMINISTRATOR (ADMINISTRATOR_ID,ADMINISTRATOR_USER,ADMINISTRATOR_PASSWORD) values (70,'1','1');
Insert into HR.ADMINISTRATOR (ADMINISTRATOR_ID,ADMINISTRATOR_USER,ADMINISTRATOR_PASSWORD) values (80,'6','6');
Insert into HR.ADMINISTRATOR (ADMINISTRATOR_ID,ADMINISTRATOR_USER,ADMINISTRATOR_PASSWORD) values (82,'8','8');
Insert into HR.ADMINISTRATOR (ADMINISTRATOR_ID,ADMINISTRATOR_USER,ADMINISTRATOR_PASSWORD) values (81,'7','7');
Insert into HR.ADMINISTRATOR (ADMINISTRATOR_ID,ADMINISTRATOR_USER,ADMINISTRATOR_PASSWORD) values (83,'9','9');

---------------------------------------------------
--   END DATA FOR TABLE ADMINISTRATOR
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE AIRPLANE_INFO
--   FILTER = none used
---------------------------------------------------
REM INSERTING into HR.AIRPLANE_INFO
Insert into HR.AIRPLANE_INFO (AIRPLANE_ID,AIRPLANE_NUMSEATS,AIRPLANETYPE_NAME) values (31,'44','TypeX');
Insert into HR.AIRPLANE_INFO (AIRPLANE_ID,AIRPLANE_NUMSEATS,AIRPLANETYPE_NAME) values (32,'31','TypeA');
Insert into HR.AIRPLANE_INFO (AIRPLANE_ID,AIRPLANE_NUMSEATS,AIRPLANETYPE_NAME) values (29,'15','AirBas');
Insert into HR.AIRPLANE_INFO (AIRPLANE_ID,AIRPLANE_NUMSEATS,AIRPLANETYPE_NAME) values (30,'15','TypeR');

---------------------------------------------------
--   END DATA FOR TABLE AIRPLANE_INFO
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE FLIGHT
--   FILTER = none used
---------------------------------------------------
REM INSERTING into HR.FLIGHT
Insert into HR.FLIGHT (FLIGHT_NUM,FROM_CODE,FROM_TIME,TO_TIME,TO_CODE,PRICE,STATUE,AIRPLAN_ID) values (63,20,to_timestamp('10-APR-20 02.21.12.598748000 PM','DD-MON-RR HH.MI.SS.FF AM'),to_timestamp('19-APR-20 02.21.12.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),21,100,'Class A',29);
Insert into HR.FLIGHT (FLIGHT_NUM,FROM_CODE,FROM_TIME,TO_TIME,TO_CODE,PRICE,STATUE,AIRPLAN_ID) values (84,20,to_timestamp('10-APR-20 06.31.14.388724000 PM','DD-MON-RR HH.MI.SS.FF AM'),to_timestamp('16-APR-20 06.31.14.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),21,100,'Class A',29);
Insert into HR.FLIGHT (FLIGHT_NUM,FROM_CODE,FROM_TIME,TO_TIME,TO_CODE,PRICE,STATUE,AIRPLAN_ID) values (85,20,to_timestamp('18-APR-20 06.33.38.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),to_timestamp('24-APR-20 06.33.38.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),21,100,'Class A',31);

---------------------------------------------------
--   END DATA FOR TABLE FLIGHT
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE PASSENGER
--   FILTER = none used
---------------------------------------------------
REM INSERTING into HR.PASSENGER
Insert into HR.PASSENGER (PASSENGER_ID,PASSENGER_FNAME,PASSENGER_LNAME,PASSENGER_EMAIL,PASSENGER_PASSWORD,PASSENGER_PHONE) values (26,'Ramy','Makram','ramy','ramy','000000');

---------------------------------------------------
--   END DATA FOR TABLE PASSENGER
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE AIRPORT
--   FILTER = none used
---------------------------------------------------
REM INSERTING into HR.AIRPORT
Insert into HR.AIRPORT (AIRPORT_CODE,AIRPORT_NAME,AIRPORT_CITY) values (20,'Cairo','Egypt');
Insert into HR.AIRPORT (AIRPORT_CODE,AIRPORT_NAME,AIRPORT_CITY) values (21,'Safaga','Egypt');
Insert into HR.AIRPORT (AIRPORT_CODE,AIRPORT_NAME,AIRPORT_CITY) values (22,'El3Arka','Egypt');
Insert into HR.AIRPORT (AIRPORT_CODE,AIRPORT_NAME,AIRPORT_CITY) values (23,'ElOxur','Egypt');
Insert into HR.AIRPORT (AIRPORT_CODE,AIRPORT_NAME,AIRPORT_CITY) values (24,'Sharm ElShek','Egypt');

---------------------------------------------------
--   END DATA FOR TABLE AIRPORT
---------------------------------------------------
--------------------------------------------------------
--  Constraints for Table ADMINISTRATOR
--------------------------------------------------------

  ALTER TABLE "HR"."ADMINISTRATOR" MODIFY ("ADMINISTRATOR_ID" NOT NULL ENABLE);
 
  ALTER TABLE "HR"."ADMINISTRATOR" MODIFY ("ADMINISTRATOR_USER" NOT NULL ENABLE);
 
  ALTER TABLE "HR"."ADMINISTRATOR" MODIFY ("ADMINISTRATOR_PASSWORD" NOT NULL ENABLE);
 
  ALTER TABLE "HR"."ADMINISTRATOR" ADD PRIMARY KEY ("ADMINISTRATOR_ID") ENABLE;
--------------------------------------------------------
--  Constraints for Table AIRPLANE_INFO
--------------------------------------------------------

  ALTER TABLE "HR"."AIRPLANE_INFO" MODIFY ("AIRPLANE_ID" NOT NULL ENABLE);
 
  ALTER TABLE "HR"."AIRPLANE_INFO" MODIFY ("AIRPLANE_NUMSEATS" NOT NULL ENABLE);
 
  ALTER TABLE "HR"."AIRPLANE_INFO" MODIFY ("AIRPLANETYPE_NAME" NOT NULL ENABLE);
 
  ALTER TABLE "HR"."AIRPLANE_INFO" ADD PRIMARY KEY ("AIRPLANE_ID") ENABLE;
--------------------------------------------------------
--  Constraints for Table AIRPORT
--------------------------------------------------------

  ALTER TABLE "HR"."AIRPORT" MODIFY ("AIRPORT_CODE" NOT NULL ENABLE);
 
  ALTER TABLE "HR"."AIRPORT" MODIFY ("AIRPORT_NAME" NOT NULL ENABLE);
 
  ALTER TABLE "HR"."AIRPORT" MODIFY ("AIRPORT_CITY" NOT NULL ENABLE);
 
  ALTER TABLE "HR"."AIRPORT" ADD PRIMARY KEY ("AIRPORT_CODE") ENABLE;
--------------------------------------------------------
--  Constraints for Table FLIGHT
--------------------------------------------------------

  ALTER TABLE "HR"."FLIGHT" MODIFY ("FLIGHT_NUM" NOT NULL ENABLE);
 
  ALTER TABLE "HR"."FLIGHT" MODIFY ("FROM_CODE" NOT NULL ENABLE);
 
  ALTER TABLE "HR"."FLIGHT" MODIFY ("FROM_TIME" NOT NULL ENABLE);
 
  ALTER TABLE "HR"."FLIGHT" MODIFY ("TO_TIME" NOT NULL ENABLE);
 
  ALTER TABLE "HR"."FLIGHT" MODIFY ("TO_CODE" NOT NULL ENABLE);
 
  ALTER TABLE "HR"."FLIGHT" ADD PRIMARY KEY ("FLIGHT_NUM") ENABLE;
 
  ALTER TABLE "HR"."FLIGHT" MODIFY ("PRICE" NOT NULL ENABLE);
 
  ALTER TABLE "HR"."FLIGHT" MODIFY ("STATUE" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table PASSENGER
--------------------------------------------------------

  ALTER TABLE "HR"."PASSENGER" ADD CONSTRAINT "PHONE_IS_UNIQUE" UNIQUE ("PASSENGER_PHONE") ENABLE;
 
  ALTER TABLE "HR"."PASSENGER" MODIFY ("PASSENGER_ID" NOT NULL ENABLE);
 
  ALTER TABLE "HR"."PASSENGER" MODIFY ("PASSENGER_FNAME" NOT NULL ENABLE);
 
  ALTER TABLE "HR"."PASSENGER" MODIFY ("PASSENGER_LNAME" NOT NULL ENABLE);
 
  ALTER TABLE "HR"."PASSENGER" MODIFY ("PASSENGER_EMAIL" NOT NULL ENABLE);
 
  ALTER TABLE "HR"."PASSENGER" MODIFY ("PASSENGER_PASSWORD" NOT NULL ENABLE);
 
  ALTER TABLE "HR"."PASSENGER" MODIFY ("PASSENGER_PHONE" NOT NULL ENABLE);
 
  ALTER TABLE "HR"."PASSENGER" ADD PRIMARY KEY ("PASSENGER_ID") ENABLE;
--------------------------------------------------------
--  Constraints for Table PASSENGER_FLIGHT
--------------------------------------------------------

  ALTER TABLE "HR"."PASSENGER_FLIGHT" MODIFY ("PRICE" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table PROBLEM
--------------------------------------------------------

  ALTER TABLE "HR"."PROBLEM" ADD CONSTRAINT "PROBNAME_IS_UNIQUE" UNIQUE ("PROBLEM_NAME") ENABLE;
 
  ALTER TABLE "HR"."PROBLEM" MODIFY ("PROBLEM_DEFINE" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table SOLVE
--------------------------------------------------------

  ALTER TABLE "HR"."SOLVE" ADD PRIMARY KEY ("ADMINISTRATOR_ID", "PROBLEM_NAME") ENABLE;
--------------------------------------------------------
--  DDL for Index PHONE_IS_UNIQUE
--------------------------------------------------------

  CREATE UNIQUE INDEX "HR"."PHONE_IS_UNIQUE" ON "HR"."PASSENGER" ("PASSENGER_PHONE") 
  ;
--------------------------------------------------------
--  DDL for Index PROBNAME_IS_UNIQUE
--------------------------------------------------------

  CREATE UNIQUE INDEX "HR"."PROBNAME_IS_UNIQUE" ON "HR"."PROBLEM" ("PROBLEM_NAME") 
  ;



--------------------------------------------------------
--  Ref Constraints for Table FLIGHT
--------------------------------------------------------

  ALTER TABLE "HR"."FLIGHT" ADD CONSTRAINT "FK_AIRPORT" FOREIGN KEY ("FROM_CODE")
	  REFERENCES "HR"."AIRPORT" ("AIRPORT_CODE") ON DELETE CASCADE ENABLE;
 
  ALTER TABLE "HR"."FLIGHT" ADD CONSTRAINT "FLIGHT_AIRPLANE_INFO_FK1" FOREIGN KEY ("AIRPLAN_ID")
	  REFERENCES "HR"."AIRPLANE_INFO" ("AIRPLANE_ID") ENABLE;

--------------------------------------------------------
--  Ref Constraints for Table PASSENGER_FLIGHT
--------------------------------------------------------

  ALTER TABLE "HR"."PASSENGER_FLIGHT" ADD FOREIGN KEY ("PASSENGER_ID")
	  REFERENCES "HR"."PASSENGER" ("PASSENGER_ID") ENABLE;
 
  ALTER TABLE "HR"."PASSENGER_FLIGHT" ADD FOREIGN KEY ("FLIGHT_NUM")
	  REFERENCES "HR"."FLIGHT" ("FLIGHT_NUM") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table PROBLEM
--------------------------------------------------------

  ALTER TABLE "HR"."PROBLEM" ADD FOREIGN KEY ("PASSENGER_ID")
	  REFERENCES "HR"."PASSENGER" ("PASSENGER_ID") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table SOLVE
--------------------------------------------------------

  ALTER TABLE "HR"."SOLVE" ADD FOREIGN KEY ("ADMINISTRATOR_ID")
	  REFERENCES "HR"."ADMINISTRATOR" ("ADMINISTRATOR_ID") ENABLE;
 
  ALTER TABLE "HR"."SOLVE" ADD FOREIGN KEY ("PROBLEM_NAME")
	  REFERENCES "HR"."PROBLEM" ("PROBLEM_NAME") ENABLE;
--------------------------------------------------------
--  DDL for Function GET_SQ_VAL
--------------------------------------------------------

  CREATE OR REPLACE FUNCTION "HR"."GET_SQ_VAL" 
return number
is
val NUMBER:=0;
begin
val:=SEQUENCE1.nextval;
return val;
end;

/

--------------------------------------------------------
--  DDL for Function GET_TICKETSNUM
--------------------------------------------------------

  CREATE OR REPLACE FUNCTION "HR"."GET_TICKETSNUM" ( passid IN NUMBER) RETURN number
AS
count_ NUMBER;
BEGIN
select count(*) into count_ from passenger_flight where passenger_id= passid;
  RETURN count_;
END get_TicketsNum;

/

--------------------------------------------------------
--  DDL for Procedure ADD_PLANE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "HR"."ADD_PLANE" (plane in AIRPLANE_INFO%rowtype,plane_id out NUMBER)
is
begin
plane_id:=get_sq_val();
insert into AIRPLANE_INFO values(plane_id,plane.AIRPLANE_NUMSEATS,plane.AIRPLANETYPE_NAME);
end Add_Plane;

/

--------------------------------------------------------
--  DDL for Procedure FLIGTHS_PRINT
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "HR"."FLIGTHS_PRINT" (from_ in number,to_ in number,fligths out sys_refcursor)
is
begin
open fligths for
select e.FLIGHT_NUM,e.AIRPLAN_ID, e.FROM_TIME "From Time", e.TO_TIME "To Time" 
, e.PRICE "Price" , e.STATUE "Class" from FLIGHT e where FROM_CODE=from_ and TO_CODE=to_ and FROM_TIME> sysdate;        
end;

/

--------------------------------------------------------
--  DDL for Procedure FLIGTH_FROMTO_PRINT
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "HR"."FLIGTH_FROMTO_PRINT" (from_ in FLIGHT.FROM_TIME%type ,to_ in FLIGHT.TO_TIME%type,fligths out sys_refcursor)
is
begin
open fligths for
select e.FLIGHT_NUM,e.AIRPLAN_ID, e.FROM_TIME "From Time", e.TO_TIME "To Time" 
, e.PRICE "Price" , e.STATUE "Class",t.AIRPORT_NAME "To",fr.AIRPORT_NAME "From"
from FLIGHT e 
INNER JOIN airport t ON t.AIRPORT_CODE=e.TO_CODE
INNER JOIN airport fr ON fr.AIRPORT_CODE=e.FROM_CODE
where FROM_TIME>from_ and TO_TIME<to_;        
end;

/

--------------------------------------------------------
--  DDL for Procedure GET_AIRPORTS
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "HR"."GET_AIRPORTS" (planes out sys_refcursor)is
BEGIN
open  planes  for
select  *
from   airport;
END;

/

--------------------------------------------------------
--  DDL for Procedure GET_NUMBER_OF_SETS
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "HR"."GET_NUMBER_OF_SETS" (FlightID in NUMBER,planID in NUMBER,N out number)
is
max_sets number;
taked_sets number;
BEGIN
select airplane_numseats into max_sets from airplane_info where airplane_id= planID;
select count(*) into taked_sets FROM passenger_flight where flight_num= flightid;
n:= max_sets- taked_sets;
END;

/

--------------------------------------------------------
--  DDL for Procedure GET_PLANES
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "HR"."GET_PLANES" (planes out sys_refcursor)is
BEGIN
open  planes  for
select  *
from   AIRPLANE_INFO;
END;

/

--------------------------------------------------------
--  DDL for Procedure PASSANGER_PRINT
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "HR"."PASSANGER_PRINT" (passId in number,pass out sys_refcursor)
is
begin
open  pass  for
select p.passenger_id,p.passenger_fname,p.passenger_lname,p.passenger_email,p.passenger_phone,get_TicketsNum(p.passenger_id) "count"
FROM passenger p where passenger_id= passid;
end;

/

--------------------------------------------------------
--  DDL for Procedure REMOVE_PLANE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "HR"."REMOVE_PLANE" (plane in NUMBER,rows_del out number)
is
begin
delete from AIRPLANE_INFO where airplane_id= plane;
rows_del:=SQL%ROWCOUNT;
end remove_Plane;

/

--------------------------------------------------------
--  DDL for Procedure RESERVE_
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "HR"."RESERVE_" (FlightID in NUMBER,u_ID in number,n_of_sets in number, price in number)
is
counter number;
BEGIN
  counter:= n_of_sets;
  LOOP
    INSERT INTO PASSENGER_FLIGHT VALUES (u_id, flightid, price);
    counter := counter - 1;
    EXIT WHEN counter = 0;
  END LOOP;
END;

/

--------------------------------------------------------
--  DDL for Procedure UPDATE_PLANE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "HR"."UPDATE_PLANE" (plane in AIRPLANE_INFO%rowtype)
is
begin
update AIRPLANE_INFO set airplane_numseats= plane.airplane_numseats, airplanetype_name= plane.airplanetype_name where airplane_id= plane.airplane_id;
end update_Plane;

/

