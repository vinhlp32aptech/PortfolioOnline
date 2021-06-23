create DATABASE portfolio

use portfolio


CREATE TABLE account(
	id_acc varchar(20) PRIMARY KEY ,
	username varchar(50),
	pass varchar(200),
	email varchar(70),
	id_role varchar(20),
	datecreated datetime,
	dateupdated datetime,
	stat bit
)

create table [user](
	id_user varchar(20) PRIMARY KEY,
	first_name nvarchar(30) ,
	last_name nvarchar(30) ,
	avatar varchar(255),
	dob datetime,
	phone_number varchar(15),
	addr nvarchar(200) ,
	website varchar(200),
	job nvarchar(50)  ,
	project smallint,
	datecreated datetime,
	dateupdated datetime,
	id_acc varchar(20) references account(id_acc) on delete cascade on update cascade,
	constraint account_user unique(id_acc)

);

create table social_user
(
	id_social_user  varchar(20) primary key,
	name_soc varchar(30) ,
	icon_soc varchar(100),
	url_soc varchar(255),
	id_acc varchar(20),
	datecreated datetime,
	dateupdated datetime

);



create table rating
(
	id_rating  varchar(20) primary key,	
	id_acc varchar(20),
	id_reviewer  varchar(20),
	star_of_rating bit,
	num_of_rating char default(1),
	datecreated datetime,
	dateupdated datetime
	
);

create table [view]
(
	id_view varchar(20) primary key ,
	id_acc varchar(20),
	id_viewer varchar(20),
	num_of_view bit default(1),
	datecreated datetime,
	dateupdated datetime

);

create table follow
(
	id_follow  varchar(20) primary key,
	id_acc varchar(20),
	id_follower varchar(20),
	num_of_follow bit default(1),
	datecreated datetime,
	dateupdated datetime

);

create table hashtag
(
	id_hashtag varchar(20) primary key ,
	name_hashtag varchar(30),
	stat bit,
	datecreated datetime,
	dateupdated datetime
);

create table hashtag_user
(
	id_hashtag varchar(20),
	id_acc varchar(20),
	name_hashtag varchar(30),
	datecreated datetime,
	dateupdated datetime,
	primary key(id_hashtag, id_acc)
);



create table [role]
(
	id_role varchar(20) primary key,
	name_role nvarchar(100),
	[desc] nvarchar(1000),
	datecreated datetime,
	dateupdated datetime
	
);

create table send_mail
(
	id_sendmail varchar(20) primary key,
	fullname nvarchar(100),
	mail nvarchar(100),
	mess nvarchar(1000),
	datesend datetime,
	stat bit
)

create table feedback
(
	id_feedback varchar(20) primary key,
	fullname nvarchar(100),
	mail nvarchar(100),
	mess nvarchar(1000),
	reply_mail nvarchar(1000),
	datesend datetime,
	datereply datetime,
	id_acc varchar(20),
	stat bit
)
-- manage web

create table footer_contact
(
	id_web_contact varchar(20) primary key,
	name_contact varchar(50) ,
	icon_contact varchar(200),
	content_contact varchar(100) ,
	datecreated datetime,
	dateupdated datetime
);

create table menu
(
	id_menu varchar(20) primary key,
	name_menu varchar(50) ,
	url_menu varchar(200),
	datecreated datetime,
	dateupdated datetime
);

create table social_web
(
	id_soccial_web varchar(20) primary key,
	name_soc varchar(30) ,
	icon_soc varchar(100),
	url_soc varchar(255),
	datecreated datetime,
	dateupdated datetime
	
);

create table slider 
(
	id_slider  varchar(20) primary key,
	datecreated datetime,
	dateupdated datetime

)

create table slider_part
(
	id_slider_part varchar(20) primary key,
	title_part nvarchar(100),
	content_part varchar(1000),
	name_url nvarchar(100),
	url_slider varchar(1000),
	photo varchar(255),
	id_slider varchar(20),
	datecreated datetime,
	dateupdated datetime
	
)

create table content_page
(
	id_content_page  varchar(20) primary key,
	name_page varchar(50) ,
	datecreated datetime,
	dateupdated datetime
);

create table session_page
(
	id_sess  varchar(20) PRIMARY KEY,
	id_content_page  varchar(20),
	name_sess varchar(100) ,
	title_sess varchar(500) ,	
	content_sess varchar(1000) ,	
	datecreated datetime,
	dateupdated datetime
);


create table subtitle_session_page
(
	id_subtitle_sess  varchar(20) PRIMARY KEY,
	id_sess varchar(20),
	subtitle_sess varchar(500),
	content_subtitle varchar(1000) ,
   	datecreated datetime,
	dateupdated datetime
);

create table photo_session_page
(
	id_photo_sess varchar(20) PRIMARY KEY,
	id_sess varchar(20),
	photo_sess varchar(500),
	datecreated datetime,
	dateupdated datetime
);

create table icon_session_page
(
	id_icon_sess  varchar(20) PRIMARY KEY,
	id_sess  varchar(20),
	icon_sess varchar(500),
	datecreated datetime,
	dateupdated datetime
);

create table url_session_page
(
	id_url_sess varchar(20) PRIMARY KEY,
	id_sess varchar(20),
	url_sess varchar(500),
	datecreated datetime,
	dateupdated datetime
);

-- manage user

--ALTER TABLE [user]  WITH CHECK add  CONSTRAINT FK_user_account FOREIGN KEY(id_user)
--REFERENCES account(id_acc) on delete cascade on update cascade

ALTER TABLE social_user
ADD CONSTRAINT FK_social_user_account
FOREIGN KEY (id_acc) REFERENCES account(id_acc);

ALTER TABLE rating
ADD CONSTRAINT FK_rating_account
FOREIGN KEY (id_acc) REFERENCES account(id_acc);

ALTER TABLE [view]
ADD CONSTRAINT FK_view_account
FOREIGN KEY (id_acc) REFERENCES account(id_acc);

ALTER TABLE follow
ADD CONSTRAINT FK_follow_account
FOREIGN KEY (id_acc) REFERENCES account(id_acc);

ALTER TABLE hashtag_user
ADD CONSTRAINT FK_hashtag_user_account
FOREIGN KEY (id_acc) REFERENCES account(id_acc);

ALTER TABLE hashtag_user
ADD CONSTRAINT FK_hashtag_user_hashtag
FOREIGN KEY (id_hashtag) REFERENCES hashtag(id_hashtag);

ALTER TABLE feedback
ADD CONSTRAINT FK_feedback_account
FOREIGN KEY (id_acc) REFERENCES account(id_acc);
-- manage web

ALTER TABLE slider_part
ADD CONSTRAINT FK_slider_part_slider
FOREIGN KEY (id_slider) REFERENCES slider(id_slider);


ALTER TABLE session_page
ADD CONSTRAINT FK_session_page_content_page
FOREIGN KEY (id_content_page) REFERENCES content_page(id_content_page);

ALTER TABLE subtitle_session_page
ADD CONSTRAINT FK_subtitle_session_page_session_page
FOREIGN KEY (id_sess) REFERENCES session_page(id_sess);

ALTER TABLE photo_session_page
ADD CONSTRAINT FK_photo_session_page_session_page
FOREIGN KEY (id_sess) REFERENCES session_page(id_sess);


ALTER TABLE icon_session_page
ADD CONSTRAINT FK_icon_session_page_session_page
FOREIGN KEY (id_sess) REFERENCES session_page(id_sess);


ALTER TABLE url_session_page
ADD CONSTRAINT FK_url_session_page_session_page
FOREIGN KEY (id_sess) REFERENCES session_page(id_sess);


ALTER TABLE account
ADD CONSTRAINT FK_account_role
FOREIGN KEY (id_role) REFERENCES [role](id_role);

