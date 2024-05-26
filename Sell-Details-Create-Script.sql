-- Table: public.SellDetails

-- DROP TABLE IF EXISTS public."SellDetails";

CREATE TABLE IF NOT EXISTS public."SellDetails"
(
    n bigint NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 9223372036854775807 CACHE 1 ),
    id uuid NOT NULL,
    sellid uuid NOT NULL,
    productid uuid NOT NULL,
    quantity double precision NOT NULL,
    createdon timestamp with time zone NOT NULL,
    updatedon timestamp with time zone NOT NULL,
    createdby uuid NOT NULL,
    updatedby uuid NOT NULL,
    statusbit integer NOT NULL,
    price double precision NOT NULL,
    CONSTRAINT "SellDetails_pkey" PRIMARY KEY (id),
    CONSTRAINT createdby_fkey FOREIGN KEY (createdby)
        REFERENCES public."User" (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT product_fkey FOREIGN KEY (productid)
        REFERENCES public."Product" (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT sell_fkey FOREIGN KEY (sellid)
        REFERENCES public."Sell" (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID,
    CONSTRAINT updatedby_fkey FOREIGN KEY (updatedby)
        REFERENCES public."User" (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public."SellDetails"
    OWNER to postgres;