-- Table: public.User

-- DROP TABLE IF EXISTS public."User";

CREATE TABLE IF NOT EXISTS public."User"
(
    j integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    id uuid NOT NULL,
    username character varying(64) COLLATE pg_catalog."default" NOT NULL,
    password character varying(128) COLLATE pg_catalog."default" NOT NULL,
    createdon timestamp with time zone NOT NULL,
    updatedon timestamp with time zone NOT NULL,
    statusbit integer NOT NULL,
    createdby uuid,
    updatedby uuid,
    CONSTRAINT "User_pkey" PRIMARY KEY (id),
    CONSTRAINT createdby_fkey FOREIGN KEY (createdby)
        REFERENCES public."User" (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID,
    CONSTRAINT updatedby_fkey FOREIGN KEY (updatedby)
        REFERENCES public."User" (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public."User"
    OWNER to postgres;