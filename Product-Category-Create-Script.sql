-- Table: public.ProductCategory

-- DROP TABLE IF EXISTS public."ProductCategory";

CREATE TABLE IF NOT EXISTS public."ProductCategory"
(
    j integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    id uuid NOT NULL,
    name character varying(64) COLLATE pg_catalog."default" NOT NULL,
    description character varying(1024) COLLATE pg_catalog."default",
    createdon timestamp with time zone NOT NULL,
    updatedon timestamp with time zone NOT NULL,
    statusbit integer NOT NULL,
    createdby uuid,
    updatedby uuid,
    subcategoryname character varying(64) COLLATE pg_catalog."default",
    CONSTRAINT "ProductCategory_pkey" PRIMARY KEY (id),
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

ALTER TABLE IF EXISTS public."ProductCategory"
    OWNER to postgres;