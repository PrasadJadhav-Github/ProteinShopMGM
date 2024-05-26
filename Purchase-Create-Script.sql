-- Table: public.Purchase

-- DROP TABLE IF EXISTS public."Purchase";

CREATE TABLE IF NOT EXISTS public."Purchase"
(
    n bigint NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 9223372036854775807 CACHE 1 ),
    id uuid NOT NULL,
    supplierid uuid NOT NULL,
    purchasedate date NOT NULL,
    createdon timestamp with time zone NOT NULL,
    updatedon timestamp with time zone NOT NULL,
    createdby uuid NOT NULL,
    updatedby uuid NOT NULL,
    statusbit integer NOT NULL,
    purchasestatus integer NOT NULL,
    CONSTRAINT "Purchase_pkey" PRIMARY KEY (id),
    CONSTRAINT createdby_fkey FOREIGN KEY (createdby)
        REFERENCES public."User" (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT supplier_fkey FOREIGN KEY (supplierid)
        REFERENCES public."Supplier" (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT updatedby_fkey FOREIGN KEY (updatedby)
        REFERENCES public."User" (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public."Purchase"
    OWNER to postgres;