-- Table: public.Product

-- DROP TABLE IF EXISTS public."Product";

CREATE TABLE IF NOT EXISTS public."Product"
(
    j integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    id uuid NOT NULL,
    productcode character varying(64) COLLATE pg_catalog."default" NOT NULL,
    name character varying(256) COLLATE pg_catalog."default" NOT NULL,
    price double precision NOT NULL,
    createdon timestamp with time zone NOT NULL,
    updatedon timestamp with time zone NOT NULL,
    statusbit integer NOT NULL,
    createdby uuid NOT NULL,
    updatedby uuid NOT NULL,
    productcategoryid uuid NOT NULL,
    description character varying(512) COLLATE pg_catalog."default",
    reorderlevel integer NOT NULL DEFAULT 0,
    size character varying(16) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT "Product_pkey" PRIMARY KEY (id),
    CONSTRAINT createdby_fkey FOREIGN KEY (createdby)
        REFERENCES public."User" (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT "productcategory_fKey" FOREIGN KEY (productcategoryid)
        REFERENCES public."ProductCategory" (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT updatedby_fkey FOREIGN KEY (updatedby)
        REFERENCES public."User" (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public."Product"
    OWNER to postgres;