show databases;
CREATE DATABASE LC;
use LC; 
drop table LC.ADMIN_USER;
CREATE TABLE LC.ADMIN_USER (
admin_id varchar(30) NOT NULL,
admin_pw varchar(30) NOT NULL,
admin_name varchar(30) NOT NULL,
alias varchar(100),   -- 별칭
tel varchar(30),
email varchar(100),
description varchar(1000),
active varchar(1), 
gubun varchar(2),
craete_date DATETIME,
modify_date DATETIME,
CONSTRAINT TBLADMINUSER_PK PRIMARY KEY (admin_id)
);

INSERT INTO LC.ADMIN_USER VALUES ('admin','admin','관리자','관리자별칭','01054707098','mistymis@naver.com','test','Y','1','2015-12-12 12:12:12','2015-12-12 12:12:12'); 

select * from LC.ADMIN_USER;

drop table LC.VISIT_USER;
CREATE TABLE LC.VISIT_USER (
user_seq int NOT NULL AUTO_INCREMENT,  -- 사번
cardnum varchar(4000),  -- 출입카드정보
user_name varchar(30) NOT NULL,
alias varchar(100),   -- 소속
tel varchar(30),
email varchar(100),
description varchar(1000),
img_dir varchar(1000),
img_filename varchar(1000),
active varchar(1), 
gubun varchar(2),
create_admin_id varchar(30),
modify_admin_id varchar(30),
craete_date DATETIME,
modify_date DATETIME,
CONSTRAINT TBLVISITUSER_PK PRIMARY KEY (user_seq)
);

select * from LC.VISIT_USER;
INSERT INTO LC.VISIT_USER (cardnum,user_name,alias,tel,email,description,img_dir,img_filename,active, gubun,create_admin_id,modify_admin_id,craete_date,modify_date) VALUES ('888','8','8','8','8','8','C:\\myWorkspace\\catsee\\data','8_0_1.jpg','Y','1','','','2015-10-04 08:42:52','2015-10-04 08:42:52');