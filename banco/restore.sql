--
-- NOTE:
--
-- File paths need to be edited. Search for C:/dev/Gougli2.0/banco and
-- replace it with the path to the directory containing
-- the extracted data files.
--
--
-- PostgreSQL database dump
--

-- Dumped from database version 11.4
-- Dumped by pg_dump version 11.4

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

DROP DATABASE banco;
--
-- Name: banco; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE banco WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'Portuguese_Brazil.1252' LC_CTYPE = 'Portuguese_Brazil.1252';


ALTER DATABASE banco OWNER TO postgres;

\connect banco

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- Name: conteudo; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.conteudo (
    id integer,
    palavra character varying
);


ALTER TABLE public.conteudo OWNER TO postgres;

--
-- Name: pagina; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.pagina (
    id integer NOT NULL,
    titulo character varying,
    link character varying
);


ALTER TABLE public.pagina OWNER TO postgres;

--
-- Data for Name: conteudo; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.conteudo (id, palavra) FROM stdin;
\.
COPY public.conteudo (id, palavra) FROM 'C:/dev/Gougli2.0/banco/2812.dat';

--
-- Data for Name: pagina; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.pagina (id, titulo, link) FROM stdin;
\.
COPY public.pagina (id, titulo, link) FROM 'C:/dev/Gougli2.0/banco/2813.dat';

--
-- Name: pagina pagina_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pagina
    ADD CONSTRAINT pagina_pkey PRIMARY KEY (id);


--
-- PostgreSQL database dump complete
--

