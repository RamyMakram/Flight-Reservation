--------------------------------------------------------
--  File created - Tuesday-April-21-2020   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Sequence SEQUENCE1
--------------------------------------------------------

   CREATE SEQUENCE  "SEQUENCE1"  MINVALUE 1 MAXVALUE 9999 INCREMENT BY 1 START WITH 221 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Table ADMINISTRATOR
--------------------------------------------------------

  CREATE TABLE "ADMINISTRATOR" 
   (	"ADMINISTRATOR_ID" NUMBER(10,0), 
	"ADMINISTRATOR_USER" VARCHAR2(250), 
	"ADMINISTRATOR_PASSWORD" VARCHAR2(250)
   ) ;
--------------------------------------------------------
--  DDL for Table AIRPLANE_INFO
--------------------------------------------------------

  CREATE TABLE "AIRPLANE_INFO" 
   (	"AIRPLANE_ID" NUMBER(10,0), 
	"AIRPLANE_NUMSEATS" VARCHAR2(250), 
	"AIRPLANETYPE_NAME" VARCHAR2(50)
   ) ;
--------------------------------------------------------
--  DDL for Table AIRPORT
--------------------------------------------------------

  CREATE TABLE "AIRPORT" 
   (	"AIRPORT_CODE" NUMBER(10,0), 
	"AIRPORT_NAME" VARCHAR2(50), 
	"AIRPORT_CITY" VARCHAR2(50)
   ) ;
--------------------------------------------------------
--  DDL for Table FLIGHT
--------------------------------------------------------

  CREATE TABLE "FLIGHT" 
   (	"FLIGHT_NUM" NUMBER(10,0), 
	"FROM_CODE" NUMBER(10,0), 
	"FROM_TIME" TIMESTAMP (6), 
	"TO_TIME" TIMESTAMP (6), 
	"TO_CODE" NUMBER(10,0), 
	"PRICE" NUMBER, 
	"STATUE" VARCHAR2(50), 
	"AIRPLAN_ID" NUMBER
   ) ;
 

   COMMENT ON COLUMN "FLIGHT"."FROM_CODE" IS 'from city ';
 
   COMMENT ON COLUMN "FLIGHT"."FROM_TIME" IS 'arrive time';
 
   COMMENT ON COLUMN "FLIGHT"."TO_TIME" IS 'leave time';
 
   COMMENT ON COLUMN "FLIGHT"."TO_CODE" IS 'to city';
--------------------------------------------------------
--  DDL for Table PASSENGER
--------------------------------------------------------

  CREATE TABLE "PASSENGER" 
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

  CREATE TABLE "PASSENGER_FLIGHT" 
   (	"PASSENGER_ID" NUMBER(10,0) DEFAULT 1, 
	"FLIGHT_NUM" NUMBER(10,0), 
	"PRICE" NUMBER, 
	"ID" NUMBER, 
	"N_SETS" NUMBER DEFAULT 1
   ) ;
--------------------------------------------------------
--  DDL for Table PROBLEM
--------------------------------------------------------

  CREATE TABLE "PROBLEM" 
   (	"PASSENGER_ID" NUMBER(10,0), 
	"PROBLEM_NAME" VARCHAR2(250), 
	"PROBLEM_DEFINE" VARCHAR2(250)
   ) ;
--------------------------------------------------------
--  DDL for Table SOLVE
--------------------------------------------------------

  CREATE TABLE "SOLVE" 
   (	"ADMINISTRATOR_ID" NUMBER(10,0), 
	"PROBLEM_NAME" VARCHAR2(250)
   ) ;

---------------------------------------------------
--   DATA FOR TABLE PROBLEM
--   FILTER = none used
---------------------------------------------------
REM INSERTING into PROBLEM
Insert into PROBLEM (PASSENGER_ID,PROBLEM_NAME,PROBLEM_DEFINE) values (182,'dwddw','wdwd');

---------------------------------------------------
--   END DATA FOR TABLE PROBLEM
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE SOLVE
--   FILTER = none used
---------------------------------------------------
REM INSERTING into SOLVE

---------------------------------------------------
--   END DATA FOR TABLE SOLVE
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE PASSENGER_FLIGHT
--   FILTER = none used
---------------------------------------------------
REM INSERTING into PASSENGER_FLIGHT
Insert into PASSENGER_FLIGHT (PASSENGER_ID,FLIGHT_NUM,PRICE,ID,N_SETS) values (26,204,115,209,1);
Insert into PASSENGER_FLIGHT (PASSENGER_ID,FLIGHT_NUM,PRICE,ID,N_SETS) values (26,204,5635,208,49);

---------------------------------------------------
--   END DATA FOR TABLE PASSENGER_FLIGHT
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE ADMINISTRATOR
--   FILTER = none used
---------------------------------------------------
REM INSERTING into ADMINISTRATOR
Insert into ADMINISTRATOR (ADMINISTRATOR_ID,ADMINISTRATOR_USER,ADMINISTRATOR_PASSWORD) values (186,'9','15');
Insert into ADMINISTRATOR (ADMINISTRATOR_ID,ADMINISTRATOR_USER,ADMINISTRATOR_PASSWORD) values (70,'1','1');
Insert into ADMINISTRATOR (ADMINISTRATOR_ID,ADMINISTRATOR_USER,ADMINISTRATOR_PASSWORD) values (80,'6','12');
Insert into ADMINISTRATOR (ADMINISTRATOR_ID,ADMINISTRATOR_USER,ADMINISTRATOR_PASSWORD) values (82,'8','84');
Insert into ADMINISTRATOR (ADMINISTRATOR_ID,ADMINISTRATOR_USER,ADMINISTRATOR_PASSWORD) values (81,'7','999');

---------------------------------------------------
--   END DATA FOR TABLE ADMINISTRATOR
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE AIRPLANE_INFO
--   FILTER = none used
---------------------------------------------------
REM INSERTING into AIRPLANE_INFO
Insert into AIRPLANE_INFO (AIRPLANE_ID,AIRPLANE_NUMSEATS,AIRPLANETYPE_NAME) values (184,'50','Type45');
Insert into AIRPLANE_INFO (AIRPLANE_ID,AIRPLANE_NUMSEATS,AIRPLANETYPE_NAME) values (31,'44','TypeX');
Insert into AIRPLANE_INFO (AIRPLANE_ID,AIRPLANE_NUMSEATS,AIRPLANETYPE_NAME) values (32,'31','TypeA');
Insert into AIRPLANE_INFO (AIRPLANE_ID,AIRPLANE_NUMSEATS,AIRPLANETYPE_NAME) values (29,'15','AirBas');
Insert into AIRPLANE_INFO (AIRPLANE_ID,AIRPLANE_NUMSEATS,AIRPLANETYPE_NAME) values (30,'30','Type R');

---------------------------------------------------
--   END DATA FOR TABLE AIRPLANE_INFO
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE FLIGHT
--   FILTER = none used
---------------------------------------------------
REM INSERTING into FLIGHT
Insert into FLIGHT (FLIGHT_NUM,FROM_CODE,FROM_TIME,TO_TIME,TO_CODE,PRICE,STATUE,AIRPLAN_ID) values (63,20,to_timestamp('10-APR-20 02.21.12.598748000 PM','DD-MON-RR HH.MI.SS.FF AM'),to_timestamp('19-APR-20 02.21.12.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),21,100,'Class A',29);
Insert into FLIGHT (FLIGHT_NUM,FROM_CODE,FROM_TIME,TO_TIME,TO_CODE,PRICE,STATUE,AIRPLAN_ID) values (84,20,to_timestamp('10-APR-20 06.31.14.388724000 PM','DD-MON-RR HH.MI.SS.FF AM'),to_timestamp('16-APR-20 06.31.14.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),21,100,'Class A',29);
Insert into FLIGHT (FLIGHT_NUM,FROM_CODE,FROM_TIME,TO_TIME,TO_CODE,PRICE,STATUE,AIRPLAN_ID) values (185,20,to_timestamp('14-APR-20 09.33.10.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),to_timestamp('15-APR-20 09.33.10.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),21,100,'Class A',31);
Insert into FLIGHT (FLIGHT_NUM,FROM_CODE,FROM_TIME,TO_TIME,TO_CODE,PRICE,STATUE,AIRPLAN_ID) values (205,20,to_timestamp('22-APR-20 02.11.29.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),to_timestamp('25-APR-20 02.11.29.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),21,100,'Class A',30);
Insert into FLIGHT (FLIGHT_NUM,FROM_CODE,FROM_TIME,TO_TIME,TO_CODE,PRICE,STATUE,AIRPLAN_ID) values (105,23,to_timestamp('22-APR-20 03.32.09.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),to_timestamp('30-APR-20 03.32.09.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),22,156,'VIP',30);
Insert into FLIGHT (FLIGHT_NUM,FROM_CODE,FROM_TIME,TO_TIME,TO_CODE,PRICE,STATUE,AIRPLAN_ID) values (106,21,to_timestamp('22-APR-20 03.32.09.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),to_timestamp('30-APR-20 03.32.09.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),103,100,'Economy',30);
Insert into FLIGHT (FLIGHT_NUM,FROM_CODE,FROM_TIME,TO_TIME,TO_CODE,PRICE,STATUE,AIRPLAN_ID) values (85,20,to_timestamp('18-APR-20 06.33.38.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),to_timestamp('24-APR-20 06.33.38.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),21,100,'Class A',31);
Insert into FLIGHT (FLIGHT_NUM,FROM_CODE,FROM_TIME,TO_TIME,TO_CODE,PRICE,STATUE,AIRPLAN_ID) values (107,21,to_timestamp('22-APR-20 03.32.09.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),to_timestamp('30-APR-20 03.32.09.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),103,120,'Class A',30);
Insert into FLIGHT (FLIGHT_NUM,FROM_CODE,FROM_TIME,TO_TIME,TO_CODE,PRICE,STATUE,AIRPLAN_ID) values (108,21,to_timestamp('22-APR-20 03.32.09.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),to_timestamp('30-APR-20 03.32.09.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),103,101,'Class B',29);
Insert into FLIGHT (FLIGHT_NUM,FROM_CODE,FROM_TIME,TO_TIME,TO_CODE,PRICE,STATUE,AIRPLAN_ID) values (109,20,to_timestamp('22-APR-20 03.32.09.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),to_timestamp('30-APR-20 03.32.09.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),21,101,'Class B',30);
Insert into FLIGHT (FLIGHT_NUM,FROM_CODE,FROM_TIME,TO_TIME,TO_CODE,PRICE,STATUE,AIRPLAN_ID) values (110,20,to_timestamp('22-APR-20 03.32.09.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),to_timestamp('30-APR-20 03.32.09.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),24,150,'VIP',30);
Insert into FLIGHT (FLIGHT_NUM,FROM_CODE,FROM_TIME,TO_TIME,TO_CODE,PRICE,STATUE,AIRPLAN_ID) values (201,183,to_timestamp('23-APR-20 01.48.21.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),to_timestamp('25-APR-20 01.48.21.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),20,100,'Class A',184);
Insert into FLIGHT (FLIGHT_NUM,FROM_CODE,FROM_TIME,TO_TIME,TO_CODE,PRICE,STATUE,AIRPLAN_ID) values (202,183,to_timestamp('23-APR-20 01.48.21.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),to_timestamp('25-APR-20 01.48.21.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),20,200,'VIP',184);
Insert into FLIGHT (FLIGHT_NUM,FROM_CODE,FROM_TIME,TO_TIME,TO_CODE,PRICE,STATUE,AIRPLAN_ID) values (204,20,to_timestamp('23-APR-20 02.06.13.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),to_timestamp('24-APR-20 02.06.13.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),21,100,'Class A',184);
Insert into FLIGHT (FLIGHT_NUM,FROM_CODE,FROM_TIME,TO_TIME,TO_CODE,PRICE,STATUE,AIRPLAN_ID) values (207,20,to_timestamp('23-APR-20 02.36.02.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),to_timestamp('24-APR-20 02.36.02.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),21,100,'Class A',184);

---------------------------------------------------
--   END DATA FOR TABLE FLIGHT
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE PASSENGER
--   FILTER = none used
---------------------------------------------------
REM INSERTING into PASSENGER
Insert into PASSENGER (PASSENGER_ID,PASSENGER_FNAME,PASSENGER_LNAME,PASSENGER_EMAIL,PASSENGER_PASSWORD,PASSENGER_PHONE) values (182,'a','b','b@.com','a','0121000345655');
Insert into PASSENGER (PASSENGER_ID,PASSENGER_FNAME,PASSENGER_LNAME,PASSENGER_EMAIL,PASSENGER_PASSWORD,PASSENGER_PHONE) values (26,'Ramy','Makram','ramy','ramy','000000');

---------------------------------------------------
--   END DATA FOR TABLE PASSENGER
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE AIRPORT
--   FILTER = none used
---------------------------------------------------
REM INSERTING into AIRPORT
Insert into AIRPORT (AIRPORT_CODE,AIRPORT_NAME,AIRPORT_CITY) values (183,'ZOMM','Cairo');
Insert into AIRPORT (AIRPORT_CODE,AIRPORT_NAME,AIRPORT_CITY) values (20,'Cairo','Egypt');
Insert into AIRPORT (AIRPORT_CODE,AIRPORT_NAME,AIRPORT_CITY) values (21,'Safaga','Egypt');
Insert into AIRPORT (AIRPORT_CODE,AIRPORT_NAME,AIRPORT_CITY) values (22,'El3Arkaa','Egypt');
Insert into AIRPORT (AIRPORT_CODE,AIRPORT_NAME,AIRPORT_CITY) values (23,'ElOxur','Egypt');
Insert into AIRPORT (AIRPORT_CODE,AIRPORT_NAME,AIRPORT_CITY) values (24,'Sharm ElShek','Egypt');
Insert into AIRPORT (AIRPORT_CODE,AIRPORT_NAME,AIRPORT_CITY) values (103,'Londo','Canada');

---------------------------------------------------
--   END DATA FOR TABLE AIRPORT
---------------------------------------------------
--------------------------------------------------------
--  Constraints for Table ADMINISTRATOR
--------------------------------------------------------

  ALTER TABLE "ADMINISTRATOR" MODIFY ("ADMINISTRATOR_ID" NOT NULL ENABLE);
 
  ALTER TABLE "ADMINISTRATOR" MODIFY ("ADMINISTRATOR_USER" NOT NULL ENABLE);
 
  ALTER TABLE "ADMINISTRATOR" MODIFY ("ADMINISTRATOR_PASSWORD" NOT NULL ENABLE);
 
  ALTER TABLE "ADMINISTRATOR" ADD PRIMARY KEY ("ADMINISTRATOR_ID") ENABLE;
--------------------------------------------------------
--  Constraints for Table AIRPLANE_INFO
--------------------------------------------------------

  ALTER TABLE "AIRPLANE_INFO" MODIFY ("AIRPLANE_ID" NOT NULL ENABLE);
 
  ALTER TABLE "AIRPLANE_INFO" MODIFY ("AIRPLANE_NUMSEATS" NOT NULL ENABLE);
 
  ALTER TABLE "AIRPLANE_INFO" MODIFY ("AIRPLANETYPE_NAME" NOT NULL ENABLE);
 
  ALTER TABLE "AIRPLANE_INFO" ADD PRIMARY KEY ("AIRPLANE_ID") ENABLE;
--------------------------------------------------------
--  Constraints for Table AIRPORT
--------------------------------------------------------

  ALTER TABLE "AIRPORT" MODIFY ("AIRPORT_CODE" NOT NULL ENABLE);
 
  ALTER TABLE "AIRPORT" MODIFY ("AIRPORT_NAME" NOT NULL ENABLE);
 
  ALTER TABLE "AIRPORT" MODIFY ("AIRPORT_CITY" NOT NULL ENABLE);
 
  ALTER TABLE "AIRPORT" ADD PRIMARY KEY ("AIRPORT_CODE") ENABLE;
--------------------------------------------------------
--  Constraints for Table FLIGHT
--------------------------------------------------------

  ALTER TABLE "FLIGHT" MODIFY ("FLIGHT_NUM" NOT NULL ENABLE);
 
  ALTER TABLE "FLIGHT" MODIFY ("FROM_CODE" NOT NULL ENABLE);
 
  ALTER TABLE "FLIGHT" MODIFY ("FROM_TIME" NOT NULL ENABLE);
 
  ALTER TABLE "FLIGHT" MODIFY ("TO_TIME" NOT NULL ENABLE);
 
  ALTER TABLE "FLIGHT" MODIFY ("TO_CODE" NOT NULL ENABLE);
 
  ALTER TABLE "FLIGHT" ADD PRIMARY KEY ("FLIGHT_NUM") ENABLE;
 
  ALTER TABLE "FLIGHT" MODIFY ("PRICE" NOT NULL ENABLE);
 
  ALTER TABLE "FLIGHT" MODIFY ("STATUE" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table PASSENGER
--------------------------------------------------------

  ALTER TABLE "PASSENGER" ADD CONSTRAINT "PHONE_IS_UNIQUE" UNIQUE ("PASSENGER_PHONE") ENABLE;
 
  ALTER TABLE "PASSENGER" MODIFY ("PASSENGER_ID" NOT NULL ENABLE);
 
  ALTER TABLE "PASSENGER" MODIFY ("PASSENGER_FNAME" NOT NULL ENABLE);
 
  ALTER TABLE "PASSENGER" MODIFY ("PASSENGER_LNAME" NOT NULL ENABLE);
 
  ALTER TABLE "PASSENGER" MODIFY ("PASSENGER_EMAIL" NOT NULL ENABLE);
 
  ALTER TABLE "PASSENGER" MODIFY ("PASSENGER_PASSWORD" NOT NULL ENABLE);
 
  ALTER TABLE "PASSENGER" MODIFY ("PASSENGER_PHONE" NOT NULL ENABLE);
 
  ALTER TABLE "PASSENGER" ADD PRIMARY KEY ("PASSENGER_ID") ENABLE;
--------------------------------------------------------
--  Constraints for Table PASSENGER_FLIGHT
--------------------------------------------------------

  ALTER TABLE "PASSENGER_FLIGHT" ADD CONSTRAINT "PASSENGER_FLIGHT_PK" PRIMARY KEY ("ID") ENABLE;
 
  ALTER TABLE "PASSENGER_FLIGHT" MODIFY ("PRICE" NOT NULL ENABLE);
 
  ALTER TABLE "PASSENGER_FLIGHT" MODIFY ("ID" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table PROBLEM
--------------------------------------------------------

  ALTER TABLE "PROBLEM" ADD CONSTRAINT "PROBNAME_IS_UNIQUE" UNIQUE ("PROBLEM_NAME") ENABLE;
 
  ALTER TABLE "PROBLEM" MODIFY ("PROBLEM_DEFINE" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table SOLVE
--------------------------------------------------------

  ALTER TABLE "SOLVE" ADD PRIMARY KEY ("ADMINISTRATOR_ID", "PROBLEM_NAME") ENABLE;
--------------------------------------------------------
--  DDL for Index PASSENGER_FLIGHT_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "PASSENGER_FLIGHT_PK" ON "PASSENGER_FLIGHT" ("ID") 
  ;
--------------------------------------------------------
--  DDL for Index PHONE_IS_UNIQUE
--------------------------------------------------------

  CREATE UNIQUE INDEX "PHONE_IS_UNIQUE" ON "PASSENGER" ("PASSENGER_PHONE") 
  ;
--------------------------------------------------------
--  DDL for Index PROBNAME_IS_UNIQUE
--------------------------------------------------------

  CREATE UNIQUE INDEX "PROBNAME_IS_UNIQUE" ON "PROBLEM" ("PROBLEM_NAME") 
  ;



--------------------------------------------------------
--  Ref Constraints for Table FLIGHT
--------------------------------------------------------

  ALTER TABLE "FLIGHT" ADD CONSTRAINT "FK_AIRPORT" FOREIGN KEY ("FROM_CODE")
	  REFERENCES "AIRPORT" ("AIRPORT_CODE") ON DELETE CASCADE ENABLE;
 
  ALTER TABLE "FLIGHT" ADD CONSTRAINT "FLIGHT_AIRPLANE_INFO_FK1" FOREIGN KEY ("AIRPLAN_ID")
	  REFERENCES "AIRPLANE_INFO" ("AIRPLANE_ID") ENABLE;

--------------------------------------------------------
--  Ref Constraints for Table PASSENGER_FLIGHT
--------------------------------------------------------

  ALTER TABLE "PASSENGER_FLIGHT" ADD FOREIGN KEY ("PASSENGER_ID")
	  REFERENCES "PASSENGER" ("PASSENGER_ID") ENABLE;
 
  ALTER TABLE "PASSENGER_FLIGHT" ADD FOREIGN KEY ("FLIGHT_NUM")
	  REFERENCES "FLIGHT" ("FLIGHT_NUM") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table PROBLEM
--------------------------------------------------------

  ALTER TABLE "PROBLEM" ADD FOREIGN KEY ("PASSENGER_ID")
	  REFERENCES "PASSENGER" ("PASSENGER_ID") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table SOLVE
--------------------------------------------------------

  ALTER TABLE "SOLVE" ADD FOREIGN KEY ("ADMINISTRATOR_ID")
	  REFERENCES "ADMINISTRATOR" ("ADMINISTRATOR_ID") ENABLE;
 
  ALTER TABLE "SOLVE" ADD FOREIGN KEY ("PROBLEM_NAME")
	  REFERENCES "PROBLEM" ("PROBLEM_NAME") ENABLE;
--------------------------------------------------------
--  DDL for Function FN_GETSETS
--------------------------------------------------------

  CREATE OR REPLACE FUNCTION "FN_GETSETS" (FlightID in NUMBER,planID in NUMBER) RETURN number
AS
max_sets number;
taked_sets number;
A_S NUMBER;
BEGIN
select airplane_numseats into max_sets from airplane_info where airplane_id= planID;
select nvl(SUM(n_sets),0) into taked_sets FROM passenger_flight where flight_num= flightid;
A_S:= max_sets- taked_sets;
RETURN A_S;
END;

/

--------------------------------------------------------
--  DDL for Function GET_PRICE_SUM_PASS
--------------------------------------------------------

  CREATE OR REPLACE FUNCTION "GET_PRICE_SUM_PASS" (PassID IN NUMBER)RETURN NUMBER
AS
sum_ NUMBER;
BEGIN
  select NVL(sum(price),0) into sum_ from passenger_flight where passenger_id= passid;
  RETURN sum_;
END GET_PRICE_SUM_PASS;

/

--------------------------------------------------------
--  DDL for Function GET_SQ_VAL
--------------------------------------------------------

  CREATE OR REPLACE FUNCTION "GET_SQ_VAL" 
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

  CREATE OR REPLACE FUNCTION "GET_TICKETSNUM" ( passid IN NUMBER) RETURN number
AS
count_ NUMBER;
BEGIN
select NVL(sum(n_sets),0) into count_ from passenger_flight where passenger_id= passid;
  RETURN count_;
END get_TicketsNum;

/

--------------------------------------------------------
--  DDL for Procedure ADD_PLANE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "ADD_PLANE" (plane in AIRPLANE_INFO%rowtype,plane_id out NUMBER)
is
begin
plane_id:=get_sq_val();
insert into AIRPLANE_INFO values(plane_id,plane.AIRPLANE_NUMSEATS,plane.AIRPLANETYPE_NAME);
end Add_Plane;

/

--------------------------------------------------------
--  DDL for Procedure CANCEL_RESERV
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "CANCEL_RESERV" (F_ID IN NUMBER, P_ID IN NUMBER, N IN NUMBER) AS
BEGIN
  IF N=0 THEN
    delete from PASSENGER_FLIGHT where flight_num= f_id and PASSENGER_ID= p_id;
  ELSE
    UPDATE PASSENGER_FLIGHT set price=price-(price/ n_sets)* n , n_sets= n_sets- n where flight_num= f_id and PASSENGER_ID= p_id;
  END IF;
END;

/

--------------------------------------------------------
--  DDL for Procedure FLIGTHS_PRINT
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "FLIGTHS_PRINT" (from_ in number,to_ in number,fligths out sys_refcursor)
is
begin
open fligths for
select e.FLIGHT_NUM,e.AIRPLAN_ID, e.FROM_TIME "From Time", e.TO_TIME "To Time" 
, e.PRICE "Price" , e.STATUE "Class",FN_GetSets(e.FLIGHT_NUM,e.AIRPLAN_ID) "Avaible Sets" from FLIGHT e where FROM_CODE=from_ and TO_CODE=to_ and FROM_TIME> sysdate;        
end;

/

--------------------------------------------------------
--  DDL for Procedure FLIGTH_FROMTO_PRINT
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "FLIGTH_FROMTO_PRINT" (from_ in FLIGHT.FROM_TIME%type ,to_ in FLIGHT.TO_TIME%type,fligths out sys_refcursor)
is
begin
open fligths for
select e.FLIGHT_NUM,e.AIRPLAN_ID, e.FROM_TIME "From Time", e.TO_TIME "To Time" 
, e.PRICE "Price" , e.STATUE "Class",t.AIRPORT_NAME "To",fr.AIRPORT_NAME "From", fn_getsets(e.FLIGHT_NUM,e.AIRPLAN_ID) "Avaible Sets"
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

  CREATE OR REPLACE PROCEDURE "GET_AIRPORTS" (planes out sys_refcursor)is
BEGIN
open  planes  for
select AIRPORT_CODE "ID" ,AIRPORT_NAME "Name", AIRPORT_CITY "City"
from   airport ORDER BY AIRPORT_CODE;
END;

/

--------------------------------------------------------
--  DDL for Procedure GET_NUMBER_OF_FLIGTHS_OF_PASSS
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "GET_NUMBER_OF_FLIGTHS_OF_PASSS" (F_ID in NUMBER,P_ID in NUMBER,N OUT NUMBER) AS
BEGIN
  SELECT sum(n_sets) into n from passenger_flight where passenger_id= p_id and flight_num= f_id;
END GET_NUMBER_OF_FLIGTHS_OF_PASSS;

/

--------------------------------------------------------
--  DDL for Procedure GET_NUMBER_OF_SETS
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "GET_NUMBER_OF_SETS" (FlightID in NUMBER,planID in NUMBER,N out number)
is
max_sets number;
taked_sets number;
BEGIN
select airplane_numseats into max_sets from airplane_info where airplane_id= planID;
select nvl(sum(n_sets),0) into taked_sets FROM passenger_flight where flight_num= flightid;
n:= max_sets- taked_sets;
END;

/

--------------------------------------------------------
--  DDL for Procedure GET_PLANES
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "GET_PLANES" (planes out sys_refcursor)is
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

  CREATE OR REPLACE PROCEDURE "PASSANGER_PRINT" (passId in number,pass out sys_refcursor)
is
begin
open  pass  for
select p.passenger_id,p.passenger_fname,p.passenger_lname,p.passenger_email,p.passenger_phone
, GET_PRICE_SUM_PASS(p.passenger_id) "Total Price",get_TicketsNum(p.passenger_id) "Tikets"
FROM passenger p where p.passenger_id= passid;
end;

/

--------------------------------------------------------
--  DDL for Procedure REMOVE_PLANE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "REMOVE_PLANE" (plane in NUMBER,rows_del out number)
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

  CREATE OR REPLACE PROCEDURE "RESERVE_" (FlightID in NUMBER,u_ID in number,n_of_sets in number, price in number)
is
Temp_price number;
total_price NUMBER;
BEGIN
    Temp_price:=(price* n_of_sets);
    total_price:= temp_price+(temp_price * 0.15);
    INSERT INTO PASSENGER_FLIGHT (id, passenger_id, flight_num, price, n_sets) VALUES (SEQUENCE1.nextval,u_id, flightid, total_price, n_of_sets);
END;

/

--------------------------------------------------------
--  DDL for Procedure UPDATE_PLANE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "UPDATE_PLANE" (plane in AIRPLANE_INFO%rowtype)
is
begin
update AIRPLANE_INFO set airplane_numseats= plane.airplane_numseats, airplanetype_name= plane.airplanetype_name where airplane_id= plane.airplane_id;
end update_Plane;

/

