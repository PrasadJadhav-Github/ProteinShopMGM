-- Table: public.Customer

-- DROP TABLE IF EXISTS public."Customer";

CREATE TABLE IF NOT EXISTS public."Customer"
(
    j integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    id uuid NOT NULL,
    name character varying(64) COLLATE pg_catalog."default" NOT NULL,
    contact character varying(16) COLLATE pg_catalog."default" NOT NULL,
    address character varying(1024) COLLATE pg_catalog."default",
    customertype integer NOT NULL,
    createdon timestamp with time zone NOT NULL,
    updatedon timestamp with time zone NOT NULL,
    statusbit integer NOT NULL,
    createdby uuid,
    updatedby uuid,
    CONSTRAINT customer_pkey PRIMARY KEY (id),
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

ALTER TABLE IF EXISTS public."Customer"
    OWNER to postgres;