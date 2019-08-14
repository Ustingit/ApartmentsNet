using Apartments.Constants.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Apartments.Models.Postgres
{
    public class Apartment    //done v v2
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Название")]
        public string Name { get; set; }
        [Required]
        public string AuthorId { get; set; }  //public Client Author { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Дата создания")]
        public DateTime? DateCreated { get; set; } = DateTime.Now;
        [Display(Name = "Дата окончания действия")]
        public Nullable<DateTime> DateActualTo { get; set; }
        public bool IsActive { get; set; } = false;
        public bool IsDonated { get; set; } = false;
        public Nullable<DateTime> DonateDueDate { get; set; }
        public string FollowersIds { get; set; }  //public List<string> FollowersIds { get; set; }   //public List<Client> Followers { get; set; }
        [Required]
        public string AddressId { get; set; }  //public Adress Address { get; set; }

        [Display(Name = "Источник объявления")]
        public ParsingSources? ParsingSource { get; set; }
        public string ShortId { get; set; }
        public string SourceURL { get; set; }
        public string mainPhotoUrl { get; set; } //TODO: main possible to keep in main list but add "main" in name or smth like that
        public string photosListUrls { get; set; }   //public List<string> photosListUrls { get; set; }
        public string phoneImgURL { get; set; }
        public string Comment { get; set; }
        public string Information { get; set; }
    }
}

/*
 *
 * 
 * 
 * 
 * -- Database: ApartmentsDBv2

-- DROP DATABASE "ApartmentsDBv2";

CREATE DATABASE "ApartmentsDBv2"
    WITH 
    OWNER = postgres
    ENCODING = 'UTF8'
    LC_COLLATE = 'English_United States.1252'
    LC_CTYPE = 'English_United States.1252'
    TABLESPACE = pg_default
    CONNECTION LIMIT = -1;



    

#######################################################

-- Table: public."Adress"

-- DROP TABLE public."Adress";

CREATE TABLE public."Adress"
(
    "Id" integer NOT NULL DEFAULT nextval('"Adress_Id_seq"'::regclass) ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    "Street" character(1) COLLATE pg_catalog."default" NOT NULL,
    "Country" character(1) COLLATE pg_catalog."default" NOT NULL,
    "City" character(1) COLLATE pg_catalog."default" NOT NULL,
    "PlaceName" character(1) COLLATE pg_catalog."default",
    "Traffic" double precision,
    "District" character(1) COLLATE pg_catalog."default",
    "MetroLine" character(1) COLLATE pg_catalog."default",
    "GeoLong" double precision,
    "GeoLat" double precision,
    "Information" character(1) COLLATE pg_catalog."default",
    "Comment" character(1) COLLATE pg_catalog."default",
    CONSTRAINT "Adress_pkey" PRIMARY KEY ("Id")
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public."Adress"
    OWNER to postgres;

############################################

    -- Table: public."Apartment"

-- DROP TABLE public."Apartment";

CREATE TABLE public."Apartment"
(
    "Id" integer NOT NULL DEFAULT nextval('"Apartment_Id_seq"'::regclass) ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    "Name" character(400) COLLATE pg_catalog."default" NOT NULL,
    "AuthorId" character(10) COLLATE pg_catalog."default" NOT NULL,
    "Price" character(10) COLLATE pg_catalog."default" NOT NULL,
    "Description" character(2000) COLLATE pg_catalog."default" NOT NULL,
    "IsActive" boolean,
    "IsDonated" boolean,
    "FollowersIds" character(2000) COLLATE pg_catalog."default",
    "AddressId" character(10) COLLATE pg_catalog."default" NOT NULL,
    "ParsingSource" bigint,
    "ShortId" character(10) COLLATE pg_catalog."default",
    "SourceURL" character(100) COLLATE pg_catalog."default",
    "mainPhotoUrl" character(100) COLLATE pg_catalog."default",
    "photosListUrls" character(300) COLLATE pg_catalog."default",
    "phoneImgURL" character(100) COLLATE pg_catalog."default",
    "Comment" character(5000) COLLATE pg_catalog."default",
    "Information" character(2000) COLLATE pg_catalog."default",
    "Phone" character(15) COLLATE pg_catalog."default" NOT NULL,
    "DateCreated" time without time zone,
    "DonateDueDate" timestamp without time zone,
    "DateActualTo" timestamp without time zone,
    CONSTRAINT "Apartment_pkey" PRIMARY KEY ("Id")
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public."Apartment"
    OWNER to postgres;

###############################################

    -- Table: public."Client"

-- DROP TABLE public."Client";

CREATE TABLE public."Client"
(
    "Id" integer NOT NULL DEFAULT nextval('"Client_Id_seq"'::regclass) ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    "Name" character(1) COLLATE pg_catalog."default" NOT NULL,
    "SurName" character(1) COLLATE pg_catalog."default" NOT NULL,
    "FatherName" character(1) COLLATE pg_catalog."default",
    "PaymentsIds" character(1) COLLATE pg_catalog."default",
    "IsVip" boolean,
    "Email" character(1) COLLATE pg_catalog."default" NOT NULL,
    "AddressId" character(1) COLLATE pg_catalog."default",
    "Agency" character(1) COLLATE pg_catalog."default",
    "InternalComment" character(1) COLLATE pg_catalog."default",
    "Phone" bigint NOT NULL,
    "IsAgent" boolean,
    "IsDonated" boolean,
    "AvatarId" bigint,
    "ApartmentsIds" character(1) COLLATE pg_catalog."default",
    "RegistrationDate" timestamp without time zone,
    "BirthDate" timestamp without time zone NOT NULL,
    CONSTRAINT "Client_pkey" PRIMARY KEY ("Id")
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public."Client"
    OWNER to postgres;
###################################

    -- Table: public."Company"

-- DROP TABLE public."Company";

CREATE TABLE public."Company"
(
    "Id" integer NOT NULL DEFAULT nextval('"Company_Id_seq"'::regclass) ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    "Name" character(100) COLLATE pg_catalog."default" NOT NULL,
    "OfficialName" character(100) COLLATE pg_catalog."default" NOT NULL,
    "INN" bigint NOT NULL,
    "Phone" bigint NOT NULL,
    "AddressId" character(10) COLLATE pg_catalog."default" NOT NULL,
    "IsBelCompany" boolean,
    "Comment" character(3000) COLLATE pg_catalog."default",
    "IsVIP" boolean,
    "Information" character(2000) COLLATE pg_catalog."default",
    CONSTRAINT "Company_pkey" PRIMARY KEY ("Id")
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public."Company"
    OWNER to postgres;

#########################################

-- Table: public."Payment"

-- DROP TABLE public."Payment";

CREATE TABLE public."Payment"
(
    "Id" integer NOT NULL DEFAULT nextval('"Payment_Id_seq"'::regclass) ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    "Sum" double precision NOT NULL,
    "SenderId" character(10) COLLATE pg_catalog."default" NOT NULL,
    "IsCompleted" boolean,
    "Information" character(2000) COLLATE pg_catalog."default",
    "Check" character(3000) COLLATE pg_catalog."default",
    "Comment" character(3000) COLLATE pg_catalog."default",
    "StartDate" timestamp without time zone NOT NULL,
    "FinishDate" timestamp without time zone,
    CONSTRAINT "Payment_pkey" PRIMARY KEY ("Id")
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public."Payment"
    OWNER to postgres;











 * 
 * 
 * 
 * 
 *
 *
 *
 *   */
