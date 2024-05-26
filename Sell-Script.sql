-- Table: public.Sell

-- DROP TABLE IF EXISTS public."Sell";

CREATE TABLE IF NOT EXISTS public."Sell"
(
    n bigint NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 9223372036854775807 CACHE 1 ),
    id uuid NOT NULL,
    billdate date NOT NULL,
    customerid uuid NOT NULL,
    totalamount double precision NOT NULL,
    discount double precision NOT NULL,
    finalamount double precision NOT NULL,
    createdon timestamp with time zone NOT NULL,
    updatedon timestamp with time zone NOT NULL,
    createdby uuid NOT NULL,
    updatedby uuid NOT NULL,
    statusbit integer NOT NULL,
    CONSTRAINT "Sell_pkey" PRIMARY KEY (id),
    CONSTRAINT createdby_fkey FOREIGN KEY (createdby)
        REFERENCES public."User" (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT customer_fkey FOREIGN KEY (customerid)
        REFERENCES public."Customer" (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT updatedby_fkey FOREIGN KEY (updatedby)
        REFERENCES public."User" (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public."Sell"
    OWNER to postgres;