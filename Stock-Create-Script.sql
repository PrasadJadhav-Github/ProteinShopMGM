-- Table: public.Stock

-- DROP TABLE IF EXISTS public."Stock";

CREATE TABLE IF NOT EXISTS public."Stock"
(
    n bigint NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 9223372036854775807 CACHE 1 ),
    id uuid NOT NULL,
    productid uuid NOT NULL,
    quantity integer NOT NULL,
    createdon timestamp with time zone NOT NULL,
    updatedon timestamp with time zone NOT NULL,
    createdby uuid NOT NULL,
    updatedby uuid NOT NULL,
    statusbit integer NOT NULL,
    CONSTRAINT "Stock_pkey" PRIMARY KEY (id),
    CONSTRAINT createdby_fkey FOREIGN KEY (createdby)
        REFERENCES public."User" (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT product_fkey FOREIGN KEY (productid)
        REFERENCES public."Product" (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT updatedby_fkey FOREIGN KEY (updatedby)
        REFERENCES public."User" (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public."Stock"
    OWNER to postgres;