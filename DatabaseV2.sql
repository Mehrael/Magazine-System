--------------------------------------------------------
--  File created - Saturday-April-29-2023   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Sequence ACTID
--------------------------------------------------------

   CREATE SEQUENCE  "ACTID"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Table COMMENTS
--------------------------------------------------------

  CREATE TABLE "COMMENTS" 
   (	"ID" NUMBER(*,0), 
	"USERCOMMENT" VARCHAR2(500), 
	"SUBSCRIBERID" NUMBER(*,0), 
	"MAGAZINEID" NUMBER(*,0)
   ) ;
--------------------------------------------------------
--  DDL for Table FEEDBACKS
--------------------------------------------------------

  CREATE TABLE "FEEDBACKS" 
   (	"ID" NUMBER(*,0), 
	"FEEDBACK" VARCHAR2(500), 
	"SOURCEID" NUMBER(*,0), 
	"DESTID" NUMBER(*,0), 
	"MAGAZINEID" NUMBER(*,0)
   ) ;
--------------------------------------------------------
--  DDL for Table LIKES
--------------------------------------------------------

  CREATE TABLE "LIKES" 
   (	"ID" NUMBER(*,0), 
	"LIKE_DISLIKE" NUMBER(*,0), 
	"SUBSCRIBERID" NUMBER(*,0), 
	"MAGAZINEID" NUMBER(*,0)
   ) ;
--------------------------------------------------------
--  DDL for Table MAGAZINE
--------------------------------------------------------

  CREATE TABLE "MAGAZINE" 
   (	"ID" NUMBER(*,0), 
	"TITLE" VARCHAR2(100), 
	"AUTHORID" NUMBER(*,0), 
	"DESCRIPTION" VARCHAR2(500), 
	"CONTENT" VARCHAR2(500), 
	"APPROVED" NUMBER(*,0), 
	"PUBLISHED" NUMBER(*,0), 
	"MAGAZINECOVER" VARCHAR2(500)
   ) ;
--------------------------------------------------------
--  DDL for Table ROLES
--------------------------------------------------------

  CREATE TABLE "ROLES" 
   (	"ID" NUMBER(*,0), 
	"ROLE" VARCHAR2(50)
   ) ;
--------------------------------------------------------
--  DDL for Table SUBSCRIPTION
--------------------------------------------------------

  CREATE TABLE "SUBSCRIPTION" 
   (	"ID" NUMBER(*,0), 
	"PRICE" NUMBER(10,2), 
	"EXPIRATIONDATE" DATE
   ) ;
--------------------------------------------------------
--  DDL for Table USERS
--------------------------------------------------------

  CREATE TABLE "USERS" 
   (	"ID" NUMBER(*,0), 
	"NAME" VARCHAR2(50), 
	"EMAIL" VARCHAR2(50), 
	"PASSWORD" VARCHAR2(50), 
	"ROLEID" NUMBER(*,0), 
	"SUBSCRIPTIONID" NUMBER(*,0)
   ) ;

---------------------------------------------------
--   DATA FOR TABLE COMMENTS
--   FILTER = none used
---------------------------------------------------
REM INSERTING into COMMENTS
Insert into COMMENTS (ID,USERCOMMENT,SUBSCRIBERID,MAGAZINEID) values (1,'This is a great article!',3,1);
Insert into COMMENTS (ID,USERCOMMENT,SUBSCRIBERID,MAGAZINEID) values (2,'I disagree with some points made here.',6,2);
Insert into COMMENTS (ID,USERCOMMENT,SUBSCRIBERID,MAGAZINEID) values (3,'This is an insightful analysis.',9,3);
Insert into COMMENTS (ID,USERCOMMENT,SUBSCRIBERID,MAGAZINEID) values (4,'I love this magazine!',11,4);
Insert into COMMENTS (ID,USERCOMMENT,SUBSCRIBERID,MAGAZINEID) values (5,'This article needs more research.',1,5);
Insert into COMMENTS (ID,USERCOMMENT,SUBSCRIBERID,MAGAZINEID) values (6,'This is an interesting perspective.',3,15);
Insert into COMMENTS (ID,USERCOMMENT,SUBSCRIBERID,MAGAZINEID) values (7,'I found this article very helpful!',14,6);
Insert into COMMENTS (ID,USERCOMMENT,SUBSCRIBERID,MAGAZINEID) values (8,'Great writing!',18,7);
Insert into COMMENTS (ID,USERCOMMENT,SUBSCRIBERID,MAGAZINEID) values (9,'Interesting topic, but could use more depth.',3,8);
Insert into COMMENTS (ID,USERCOMMENT,SUBSCRIBERID,MAGAZINEID) values (10,'This magazine always has the best content.',6,9);
Insert into COMMENTS (ID,USERCOMMENT,SUBSCRIBERID,MAGAZINEID) values (11,'I enjoyed reading this article.',9,10);
Insert into COMMENTS (ID,USERCOMMENT,SUBSCRIBERID,MAGAZINEID) values (12,'This is a great source of information.',11,11);
Insert into COMMENTS (ID,USERCOMMENT,SUBSCRIBERID,MAGAZINEID) values (13,'I would love to see more articles like this.',1,12);
Insert into COMMENTS (ID,USERCOMMENT,SUBSCRIBERID,MAGAZINEID) values (14,'This magazine is really inspiring!',14,13);
Insert into COMMENTS (ID,USERCOMMENT,SUBSCRIBERID,MAGAZINEID) values (15,'I think the author could have done more research.',18,14);

---------------------------------------------------
--   END DATA FOR TABLE COMMENTS
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE FEEDBACKS
--   FILTER = none used
---------------------------------------------------
REM INSERTING into FEEDBACKS
Insert into FEEDBACKS (ID,FEEDBACK,SOURCEID,DESTID,MAGAZINEID) values (1,'Great magazine, keep up the good work!',2,8,1);
Insert into FEEDBACKS (ID,FEEDBACK,SOURCEID,DESTID,MAGAZINEID) values (2,'I really enjoyed the latest issue.',7,19,2);
Insert into FEEDBACKS (ID,FEEDBACK,SOURCEID,DESTID,MAGAZINEID) values (3,'The articles in this magazine are top-notch.',2,19,3);
Insert into FEEDBACKS (ID,FEEDBACK,SOURCEID,DESTID,MAGAZINEID) values (4,'I found a few typos in the latest issue.',8,20,4);
Insert into FEEDBACKS (ID,FEEDBACK,SOURCEID,DESTID,MAGAZINEID) values (5,'This magazine is too expensive for what it offers.',12,4,5);
Insert into FEEDBACKS (ID,FEEDBACK,SOURCEID,DESTID,MAGAZINEID) values (6,'The layout and design of this magazine are excellent.',7,19,6);
Insert into FEEDBACKS (ID,FEEDBACK,SOURCEID,DESTID,MAGAZINEID) values (7,'I would like to see more articles on technology in this magazine.',2,20,7);
Insert into FEEDBACKS (ID,FEEDBACK,SOURCEID,DESTID,MAGAZINEID) values (8,'The customer service at this magazine is terrible.',8,4,8);
Insert into FEEDBACKS (ID,FEEDBACK,SOURCEID,DESTID,MAGAZINEID) values (9,'I appreciate the variety of topics covered in this magazine.',12,15,9);
Insert into FEEDBACKS (ID,FEEDBACK,SOURCEID,DESTID,MAGAZINEID) values (10,'Overall, I am very satisfied with this magazine.',8,15,10);

---------------------------------------------------
--   END DATA FOR TABLE FEEDBACKS
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE LIKES
--   FILTER = none used
---------------------------------------------------
REM INSERTING into LIKES
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (1,1,3,1);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (2,0,6,2);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (3,2,9,3);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (4,1,11,4);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (5,0,1,5);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (6,2,14,6);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (7,1,18,7);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (8,0,3,8);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (9,2,6,9);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (10,1,9,10);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (11,0,11,11);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (12,2,1,12);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (13,1,14,13);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (14,0,18,14);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (15,2,3,15);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (16,1,6,1);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (17,0,9,2);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (18,2,11,3);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (19,1,1,4);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (20,0,14,5);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (21,2,18,6);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (22,1,3,7);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (23,0,6,8);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (24,2,9,9);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (25,1,11,10);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (26,0,1,11);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (27,2,14,12);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (28,1,18,13);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (29,0,3,14);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (30,2,6,15);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (31,1,9,1);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (32,0,11,2);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (33,2,1,3);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (34,1,14,4);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (35,0,18,5);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (36,2,3,6);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (37,1,6,7);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (38,0,9,8);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (39,2,11,9);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (40,1,1,10);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (41,0,14,11);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (42,2,18,12);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (43,1,3,13);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (44,0,6,14);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (45,2,9,15);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (46,1,11,1);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (47,0,1,2);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (48,2,14,3);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (49,1,18,4);
Insert into LIKES (ID,LIKE_DISLIKE,SUBSCRIBERID,MAGAZINEID) values (50,0,3,5);

---------------------------------------------------
--   END DATA FOR TABLE LIKES
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE MAGAZINE
--   FILTER = none used
---------------------------------------------------
REM INSERTING into MAGAZINE
Insert into MAGAZINE (ID,TITLE,AUTHORID,DESCRIPTION,CONTENT,APPROVED,PUBLISHED,MAGAZINECOVER) values (1,'The Best Travel Destinations',20,'Discover the most amazing travel destinations in the world.','Lorem ipsum dolor sit amet, consectetur adipiscing elit.',1,1,'https://example.com/magazine1.jpg');
Insert into MAGAZINE (ID,TITLE,AUTHORID,DESCRIPTION,CONTENT,APPROVED,PUBLISHED,MAGAZINECOVER) values (2,'The Secrets of Successful Entrepreneurs',5,'Learn what it takes to be a successful entrepreneur from the pros.','Lorem ipsum dolor sit amet, consectetur adipiscing elit.',1,0,'https://example.com/magazine2.jpg');
Insert into MAGAZINE (ID,TITLE,AUTHORID,DESCRIPTION,CONTENT,APPROVED,PUBLISHED,MAGAZINECOVER) values (3,'The Best Recipes for a Healthier You',15,'Get inspired to cook healthy meals with these amazing recipes.','Lorem ipsum dolor sit amet, consectetur adipiscing elit.',0,1,'https://example.com/magazine3.jpg');
Insert into MAGAZINE (ID,TITLE,AUTHORID,DESCRIPTION,CONTENT,APPROVED,PUBLISHED,MAGAZINECOVER) values (4,'The Top 10 Fashion Trends of the Year',5,'Stay up-to-date with the latest fashion trends.','Lorem ipsum dolor sit amet, consectetur adipiscing elit.',1,1,'https://example.com/magazine4.jpg');
Insert into MAGAZINE (ID,TITLE,AUTHORID,DESCRIPTION,CONTENT,APPROVED,PUBLISHED,MAGAZINECOVER) values (5,'The Best Yoga Poses for Stress Relief',20,'Relax and de-stress with these amazing yoga poses.','Lorem ipsum dolor sit amet, consectetur adipiscing elit.',1,1,'https://example.com/magazine5.jpg');
Insert into MAGAZINE (ID,TITLE,AUTHORID,DESCRIPTION,CONTENT,APPROVED,PUBLISHED,MAGAZINECOVER) values (6,'The Best Travel Tips from Around the World',15,'Discover the best travel tips from experienced travelers.','Lorem ipsum dolor sit amet, consectetur adipiscing elit.',1,0,'https://example.com/magazine6.jpg');
Insert into MAGAZINE (ID,TITLE,AUTHORID,DESCRIPTION,CONTENT,APPROVED,PUBLISHED,MAGAZINECOVER) values (7,'The Benefits of Meditation',5,'Discover the many benefits of meditation for your mind and body.','Lorem ipsum dolor sit amet, consectetur adipiscing elit.',0,1,'https://example.com/magazine7.jpg');
Insert into MAGAZINE (ID,TITLE,AUTHORID,DESCRIPTION,CONTENT,APPROVED,PUBLISHED,MAGAZINECOVER) values (8,'The Top 10 Beaches in the World',20,'Escape to paradise with these amazing beach destinations.','Lorem ipsum dolor sit amet, consectetur adipiscing elit.',1,1,'https://example.com/magazine8.jpg');
Insert into MAGAZINE (ID,TITLE,AUTHORID,DESCRIPTION,CONTENT,APPROVED,PUBLISHED,MAGAZINECOVER) values (9,'The Best Tips for Running a Marathon',15,'Get ready for your next marathon with these helpful tips.','Lorem ipsum dolor sit amet, consectetur adipiscing elit.',1,1,'https://example.com/magazine9.jpg');
Insert into MAGAZINE (ID,TITLE,AUTHORID,DESCRIPTION,CONTENT,APPROVED,PUBLISHED,MAGAZINECOVER) values (10,'The Best Beauty Tips from Around the World',20,'Discover beauty secrets from different cultures around','Lorem ipsum dolor sit amet, consectetur adipiscing elit.',1,1,'https://example.com/magazine9.jpg');
Insert into MAGAZINE (ID,TITLE,AUTHORID,DESCRIPTION,CONTENT,APPROVED,PUBLISHED,MAGAZINECOVER) values (11,'The Benefits of Yoga for Mind and Body',15,'Discover how practicing yoga can improve your mental and physical health.','Lorem ipsum dolor sit amet, consectetur adipiscing elit.',1,1,'https://example.com/magazine16.jpg');
Insert into MAGAZINE (ID,TITLE,AUTHORID,DESCRIPTION,CONTENT,APPROVED,PUBLISHED,MAGAZINECOVER) values (12,'The Top 10 Travel Destinations of the Year',15,'Get inspired for your next travel adventure with these amazing destinations.','Lorem ipsum dolor sit amet, consectetur adipiscing elit.',1,0,'https://example.com/magazine17.jpg');
Insert into MAGAZINE (ID,TITLE,AUTHORID,DESCRIPTION,CONTENT,APPROVED,PUBLISHED,MAGAZINECOVER) values (13,'The Benefits of Meditation for Stress Relief',5,'Learn how practicing meditation can help reduce stress and improve your overall well-being.','Lorem ipsum dolor sit amet, consectetur adipiscing elit.',1,1,'https://example.com/magazine18.jpg');
Insert into MAGAZINE (ID,TITLE,AUTHORID,DESCRIPTION,CONTENT,APPROVED,PUBLISHED,MAGAZINECOVER) values (14,'The Best Recipes for a Healthy Breakfast',20,'Start your day off right with these delicious and healthy breakfast recipes.','Lorem ipsum dolor sit amet, consectetur adipiscing elit.',1,1,'https://example.com/magazine19.jpg');
Insert into MAGAZINE (ID,TITLE,AUTHORID,DESCRIPTION,CONTENT,APPROVED,PUBLISHED,MAGAZINECOVER) values (15,'The Top 10 Movies of the Year',5,'Get ready for a movie marathon with the best films of the year.','Lorem ipsum dolor sit amet, consectetur adipiscing elit.',0,0,'https://example.com/magazine20.jpg');

---------------------------------------------------
--   END DATA FOR TABLE MAGAZINE
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE ROLES
--   FILTER = none used
---------------------------------------------------
REM INSERTING into ROLES
Insert into ROLES (ID,ROLE) values (1,'subscriber');
Insert into ROLES (ID,ROLE) values (2,'manager');
Insert into ROLES (ID,ROLE) values (3,'reviewer');
Insert into ROLES (ID,ROLE) values (4,'author');
Insert into ROLES (ID,ROLE) values (5,'guest');

---------------------------------------------------
--   END DATA FOR TABLE ROLES
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE SUBSCRIPTION
--   FILTER = none used
---------------------------------------------------
REM INSERTING into SUBSCRIPTION
Insert into SUBSCRIPTION (ID,PRICE,EXPIRATIONDATE) values (1,10.99,to_timestamp('30-JUN-22 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'));
Insert into SUBSCRIPTION (ID,PRICE,EXPIRATIONDATE) values (2,9.99,to_timestamp('15-JAN-23 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'));
Insert into SUBSCRIPTION (ID,PRICE,EXPIRATIONDATE) values (3,12.99,to_timestamp('31-DEC-24 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'));
Insert into SUBSCRIPTION (ID,PRICE,EXPIRATIONDATE) values (4,8.99,to_timestamp('30-NOV-23 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'));
Insert into SUBSCRIPTION (ID,PRICE,EXPIRATIONDATE) values (5,14.99,to_timestamp('31-AUG-22 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'));

---------------------------------------------------
--   END DATA FOR TABLE SUBSCRIPTION
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE USERS
--   FILTER = none used
---------------------------------------------------
REM INSERTING into USERS
Insert into USERS (ID,NAME,EMAIL,PASSWORD,ROLEID,SUBSCRIPTIONID) values (2,'Jane Doe','jane.doe@example.com','password456',2,null);
Insert into USERS (ID,NAME,EMAIL,PASSWORD,ROLEID,SUBSCRIPTIONID) values (3,'Bob Johnson','bob.johnson@example.com','password789',1,3);
Insert into USERS (ID,NAME,EMAIL,PASSWORD,ROLEID,SUBSCRIPTIONID) values (4,'Samantha Lee','samantha.lee@example.com','password123',2,null);
Insert into USERS (ID,NAME,EMAIL,PASSWORD,ROLEID,SUBSCRIPTIONID) values (5,'David Wilson','david.wilson@example.com','password456',4,null);
Insert into USERS (ID,NAME,EMAIL,PASSWORD,ROLEID,SUBSCRIPTIONID) values (6,'Alice Green','alice.green@example.com','password789',1,1);
Insert into USERS (ID,NAME,EMAIL,PASSWORD,ROLEID,SUBSCRIPTIONID) values (7,'Frank Brown','frank.brown@example.com','password123',2,null);
Insert into USERS (ID,NAME,EMAIL,PASSWORD,ROLEID,SUBSCRIPTIONID) values (8,'Olivia Taylor','olivia.taylor@example.com','password456',3,null);
Insert into USERS (ID,NAME,EMAIL,PASSWORD,ROLEID,SUBSCRIPTIONID) values (9,'Connor Davis','connor.davis@example.com','password789',1,3);
Insert into USERS (ID,NAME,EMAIL,PASSWORD,ROLEID,SUBSCRIPTIONID) values (10,'Avery Lee','avery.lee@example.com','password123',2,null);
Insert into USERS (ID,NAME,EMAIL,PASSWORD,ROLEID,SUBSCRIPTIONID) values (11,'Emily Johnson','emily.johnson@example.com','password456',1,5);
Insert into USERS (ID,NAME,EMAIL,PASSWORD,ROLEID,SUBSCRIPTIONID) values (12,'Carter Brown','carter.brown@example.com','password789',3,null);
Insert into USERS (ID,NAME,EMAIL,PASSWORD,ROLEID,SUBSCRIPTIONID) values (13,'Abby Wilson','abby.wilson@example.com','password123',5,null);
Insert into USERS (ID,NAME,EMAIL,PASSWORD,ROLEID,SUBSCRIPTIONID) values (1,'John Smith','john.smith@example.com','password123',1,1);
Insert into USERS (ID,NAME,EMAIL,PASSWORD,ROLEID,SUBSCRIPTIONID) values (14,'Henry Green','henry.green@example.com','password456',1,5);
Insert into USERS (ID,NAME,EMAIL,PASSWORD,ROLEID,SUBSCRIPTIONID) values (15,'Sophie Brown','sophie.brown@example.com','password789',4,null);
Insert into USERS (ID,NAME,EMAIL,PASSWORD,ROLEID,SUBSCRIPTIONID) values (16,'Lucas Wilson','lucas.wilson@example.com','password123',2,null);
Insert into USERS (ID,NAME,EMAIL,PASSWORD,ROLEID,SUBSCRIPTIONID) values (17,'Grace Lee','grace.lee@example.com','password123',5,null);
Insert into USERS (ID,NAME,EMAIL,PASSWORD,ROLEID,SUBSCRIPTIONID) values (18,'Noah Johnson','noah.johnson@example.com','password456',1,2);
Insert into USERS (ID,NAME,EMAIL,PASSWORD,ROLEID,SUBSCRIPTIONID) values (19,'Chloe Davis','chloe.davis@example.com','password789',3,null);
Insert into USERS (ID,NAME,EMAIL,PASSWORD,ROLEID,SUBSCRIPTIONID) values (20,'Ethan Taylor','ethan.taylor@example.com','password123',4,null);

---------------------------------------------------
--   END DATA FOR TABLE USERS
---------------------------------------------------

--------------------------------------------------------
--  Constraints for Table LIKES
--------------------------------------------------------

  ALTER TABLE "LIKES" MODIFY ("ID" NOT NULL ENABLE);
 
  ALTER TABLE "LIKES" MODIFY ("LIKE_DISLIKE" NOT NULL ENABLE);
 
  ALTER TABLE "LIKES" MODIFY ("SUBSCRIBERID" NOT NULL ENABLE);
 
  ALTER TABLE "LIKES" MODIFY ("MAGAZINEID" NOT NULL ENABLE);
 
  ALTER TABLE "LIKES" ADD PRIMARY KEY ("ID") ENABLE;
--------------------------------------------------------
--  Constraints for Table USERS
--------------------------------------------------------

  ALTER TABLE "USERS" MODIFY ("ID" NOT NULL ENABLE);
 
  ALTER TABLE "USERS" MODIFY ("NAME" NOT NULL ENABLE);
 
  ALTER TABLE "USERS" MODIFY ("EMAIL" NOT NULL ENABLE);
 
  ALTER TABLE "USERS" MODIFY ("PASSWORD" NOT NULL ENABLE);
 
  ALTER TABLE "USERS" MODIFY ("ROLEID" NOT NULL ENABLE);
 
  ALTER TABLE "USERS" ADD PRIMARY KEY ("ID") ENABLE;
--------------------------------------------------------
--  Constraints for Table FEEDBACKS
--------------------------------------------------------

  ALTER TABLE "FEEDBACKS" MODIFY ("ID" NOT NULL ENABLE);
 
  ALTER TABLE "FEEDBACKS" MODIFY ("FEEDBACK" NOT NULL ENABLE);
 
  ALTER TABLE "FEEDBACKS" MODIFY ("SOURCEID" NOT NULL ENABLE);
 
  ALTER TABLE "FEEDBACKS" MODIFY ("DESTID" NOT NULL ENABLE);
 
  ALTER TABLE "FEEDBACKS" MODIFY ("MAGAZINEID" NOT NULL ENABLE);
 
  ALTER TABLE "FEEDBACKS" ADD PRIMARY KEY ("ID") ENABLE;
--------------------------------------------------------
--  Constraints for Table ROLES
--------------------------------------------------------

  ALTER TABLE "ROLES" MODIFY ("ID" NOT NULL ENABLE);
 
  ALTER TABLE "ROLES" MODIFY ("ROLE" NOT NULL ENABLE);
 
  ALTER TABLE "ROLES" ADD PRIMARY KEY ("ID") ENABLE;
--------------------------------------------------------
--  Constraints for Table SUBSCRIPTION
--------------------------------------------------------

  ALTER TABLE "SUBSCRIPTION" MODIFY ("ID" NOT NULL ENABLE);
 
  ALTER TABLE "SUBSCRIPTION" MODIFY ("PRICE" NOT NULL ENABLE);
 
  ALTER TABLE "SUBSCRIPTION" MODIFY ("EXPIRATIONDATE" NOT NULL ENABLE);
 
  ALTER TABLE "SUBSCRIPTION" ADD PRIMARY KEY ("ID") ENABLE;
--------------------------------------------------------
--  Constraints for Table COMMENTS
--------------------------------------------------------

  ALTER TABLE "COMMENTS" MODIFY ("ID" NOT NULL ENABLE);
 
  ALTER TABLE "COMMENTS" MODIFY ("USERCOMMENT" NOT NULL ENABLE);
 
  ALTER TABLE "COMMENTS" MODIFY ("SUBSCRIBERID" NOT NULL ENABLE);
 
  ALTER TABLE "COMMENTS" MODIFY ("MAGAZINEID" NOT NULL ENABLE);
 
  ALTER TABLE "COMMENTS" ADD PRIMARY KEY ("ID") ENABLE;
--------------------------------------------------------
--  Constraints for Table MAGAZINE
--------------------------------------------------------

  ALTER TABLE "MAGAZINE" MODIFY ("ID" NOT NULL ENABLE);
 
  ALTER TABLE "MAGAZINE" MODIFY ("TITLE" NOT NULL ENABLE);
 
  ALTER TABLE "MAGAZINE" MODIFY ("AUTHORID" NOT NULL ENABLE);
 
  ALTER TABLE "MAGAZINE" MODIFY ("CONTENT" NOT NULL ENABLE);
 
  ALTER TABLE "MAGAZINE" MODIFY ("APPROVED" NOT NULL ENABLE);
 
  ALTER TABLE "MAGAZINE" MODIFY ("PUBLISHED" NOT NULL ENABLE);
 
  ALTER TABLE "MAGAZINE" ADD PRIMARY KEY ("ID") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table COMMENTS
--------------------------------------------------------

  ALTER TABLE "COMMENTS" ADD FOREIGN KEY ("SUBSCRIBERID")
	  REFERENCES "USERS" ("ID") ENABLE;
 
  ALTER TABLE "COMMENTS" ADD FOREIGN KEY ("MAGAZINEID")
	  REFERENCES "MAGAZINE" ("ID") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table FEEDBACKS
--------------------------------------------------------

  ALTER TABLE "FEEDBACKS" ADD CONSTRAINT "FK_FEEDBACKS_DESTID" FOREIGN KEY ("DESTID")
	  REFERENCES "USERS" ("ID") ENABLE;
 
  ALTER TABLE "FEEDBACKS" ADD CONSTRAINT "FK_FEEDBACKS_MAGAZINEID" FOREIGN KEY ("MAGAZINEID")
	  REFERENCES "MAGAZINE" ("ID") ENABLE;
 
  ALTER TABLE "FEEDBACKS" ADD CONSTRAINT "FK_FEEDBACKS_SOURCEID" FOREIGN KEY ("SOURCEID")
	  REFERENCES "USERS" ("ID") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table LIKES
--------------------------------------------------------

  ALTER TABLE "LIKES" ADD FOREIGN KEY ("SUBSCRIBERID")
	  REFERENCES "USERS" ("ID") ENABLE;
 
  ALTER TABLE "LIKES" ADD FOREIGN KEY ("MAGAZINEID")
	  REFERENCES "MAGAZINE" ("ID") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table MAGAZINE
--------------------------------------------------------

  ALTER TABLE "MAGAZINE" ADD FOREIGN KEY ("AUTHORID")
	  REFERENCES "USERS" ("ID") ENABLE;


--------------------------------------------------------
--  Ref Constraints for Table USERS
--------------------------------------------------------

  ALTER TABLE "USERS" ADD FOREIGN KEY ("ROLEID")
	  REFERENCES "ROLES" ("ID") ENABLE;
 
  ALTER TABLE "USERS" ADD FOREIGN KEY ("SUBSCRIPTIONID")
	  REFERENCES "SUBSCRIPTION" ("ID") ENABLE;
--------------------------------------------------------
--  DDL for Procedure GETUNAPPROVEDMAGAZINES
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "GETUNAPPROVEDMAGAZINES" (p_magazines OUT SYS_REFCURSOR)
AS
BEGIN
    OPEN p_magazines FOR SELECT * FROM magazine WHERE approved=0;
END;

/

--------------------------------------------------------
--  DDL for Procedure GET_AUTHORS
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "GET_AUTHORS" (p_cursor OUT SYS_REFCURSOR)
IS
BEGIN
  OPEN p_cursor FOR
    SELECT *
    FROM USERS
    WHERE ROLEID = (SELECT ID FROM ROLES WHERE ROLE = 'author');
END;

/

--------------------------------------------------------
--  DDL for Procedure GET_FEEDS
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "GET_FEEDS" (p_cursor OUT SYS_REFCURSOR)
IS
BEGIN
  OPEN p_cursor FOR
    SELECT *
    FROM FEEDBACKS
    WHERE SOURCEID IN (
      SELECT USERS.ID
      FROM USERS
      JOIN ROLES ON USERS.ROLEID = ROLES.ID
      WHERE ROLES.ROLE IN ('manager', 'subscriber', 'guest')
    );
END;

/
