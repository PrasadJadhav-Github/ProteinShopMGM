-- Table: public.Supplier

-- DROP TABLE IF EXISTS public."Supplier";

CREATE TABLE IF NOT EXISTS public."Supplier"
(
    j integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    id uuid NOT NULL,
    name character varying(64) COLLATE pg_catalog."default" NOT NULL,
    address character varying(1024) COLLATE pg_catalog."default" NOT NULL,
    createdon timestamp with time zone NOT NULL,
    updatedon timestamp with time zone NOT NULL,
    statusbit integer NOT NULL,
    createdby uuid NOT NULL,
    updatedby uuid NOT NULL,
    contact character varying(16) COLLATE pg_catalog."default" NOT NULL,
    suppliertype integer NOT NULL,
    CONSTRAINT "Supplier _pkey" PRIMARY KEY (id),
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

ALTER TABLE IF EXISTS public."Supplier"
    OWNER to postgres;