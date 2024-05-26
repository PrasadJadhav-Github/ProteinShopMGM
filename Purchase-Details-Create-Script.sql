-- Table: public.PurchaseDetails

-- DROP TABLE IF EXISTS public."PurchaseDetails";

CREATE TABLE IF NOT EXISTS public."PurchaseDetails"
(
    n bigint NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 9223372036854775807 CACHE 1 ),
    id uuid NOT NULL,
    purchaseid uuid NOT NULL,
    productid uuid NOT NULL,
    packingdate date NOT NULL,
    expirydate date NOT NULL,
    quantity integer NOT NULL,
    rate double precision NOT NULL,
    createdon timestamp with time zone NOT NULL,
    updatedon timestamp with time zone NOT NULL,
    createdby uuid NOT NULL,
    updatedby uuid NOT NULL,
    statusbit integer NOT NULL,
    mrp double precision NOT NULL DEFAULT 0,
    CONSTRAINT "PurchaseDetails_pkey" PRIMARY KEY (id),
    CONSTRAINT createdby_fkey FOREIGN KEY (createdby)
        REFERENCES public."User" (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT product_fkey FOREIGN KEY (productid)
        REFERENCES public."Product" (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT purchase_fkey FOREIGN KEY (purchaseid)
        REFERENCES public."Purchase" (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT updatedby_fkey FOREIGN KEY (updatedby)
        REFERENCES public."User" (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public."PurchaseDetails"
    OWNER to postgres;