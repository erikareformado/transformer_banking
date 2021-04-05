PGDMP         .                y            transformer_banking    11.11    11.11 X    �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                       false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                       false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                       false            �           1262    16393    transformer_banking    DATABASE     �   CREATE DATABASE transformer_banking WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'English_United States.1252' LC_CTYPE = 'English_United States.1252';
 #   DROP DATABASE transformer_banking;
             postgres    false            �            1259    16454    delta_delta_lines    TABLE     �   CREATE TABLE public.delta_delta_lines (
    id integer NOT NULL,
    btn character varying,
    points character varying,
    color character varying,
    clamp_meter character varying,
    transformer_details_id character varying
);
 %   DROP TABLE public.delta_delta_lines;
       public         postgres    false            �            1259    16452    delta_delta_lines_id_seq    SEQUENCE     �   CREATE SEQUENCE public.delta_delta_lines_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public.delta_delta_lines_id_seq;
       public       postgres    false    207            �           0    0    delta_delta_lines_id_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE public.delta_delta_lines_id_seq OWNED BY public.delta_delta_lines.id;
            public       postgres    false    206            �            1259    16492    delta_wye_lines    TABLE     �   CREATE TABLE public.delta_wye_lines (
    id integer NOT NULL,
    btn character varying,
    points character varying,
    color character varying,
    clamp_meter character varying,
    transformer_details_id character varying
);
 #   DROP TABLE public.delta_wye_lines;
       public         postgres    false            �            1259    16490    delta_wye_lines_id_seq    SEQUENCE     �   CREATE SEQUENCE public.delta_wye_lines_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.delta_wye_lines_id_seq;
       public       postgres    false    211            �           0    0    delta_wye_lines_id_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.delta_wye_lines_id_seq OWNED BY public.delta_wye_lines.id;
            public       postgres    false    210            �            1259    16418    exercise_lines    TABLE     �   CREATE TABLE public.exercise_lines (
    id integer NOT NULL,
    btn character varying,
    points character varying,
    color character varying,
    transformer_details_id character varying,
    clamp_meter character varying
);
 "   DROP TABLE public.exercise_lines;
       public         postgres    false            �            1259    16544    exercise_transformer_details    TABLE     �   CREATE TABLE public.exercise_transformer_details (
    id integer NOT NULL,
    polarity character varying,
    rating character varying,
    exercise_no character varying,
    primary_voltage character varying,
    secondary_voltage character varying
);
 0   DROP TABLE public.exercise_transformer_details;
       public         postgres    false            �            1259    16542 #   exercise_transformer_details_id_seq    SEQUENCE     �   CREATE SEQUENCE public.exercise_transformer_details_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 :   DROP SEQUENCE public.exercise_transformer_details_id_seq;
       public       postgres    false    217            �           0    0 #   exercise_transformer_details_id_seq    SEQUENCE OWNED BY     k   ALTER SEQUENCE public.exercise_transformer_details_id_seq OWNED BY public.exercise_transformer_details.id;
            public       postgres    false    216            �            1259    16505    open_delta_lines    TABLE     �   CREATE TABLE public.open_delta_lines (
    id integer NOT NULL,
    btn character varying,
    points character varying,
    color character varying,
    clamp_meter character varying,
    transformer_details_id character varying
);
 $   DROP TABLE public.open_delta_lines;
       public         postgres    false            �            1259    16503    open_delta_lines_id_seq    SEQUENCE     �   CREATE SEQUENCE public.open_delta_lines_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE public.open_delta_lines_id_seq;
       public       postgres    false    213            �           0    0    open_delta_lines_id_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public.open_delta_lines_id_seq OWNED BY public.open_delta_lines.id;
            public       postgres    false    212            �            1259    16520    openwye_opendelta_lines    TABLE     �   CREATE TABLE public.openwye_opendelta_lines (
    id integer NOT NULL,
    btn character varying,
    points character varying,
    color character varying,
    clamp_meter character varying,
    transformer_details_id character varying
);
 +   DROP TABLE public.openwye_opendelta_lines;
       public         postgres    false            �            1259    16518    openwye_opendelta_lines_id_seq    SEQUENCE     �   CREATE SEQUENCE public.openwye_opendelta_lines_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 5   DROP SEQUENCE public.openwye_opendelta_lines_id_seq;
       public       postgres    false    215            �           0    0    openwye_opendelta_lines_id_seq    SEQUENCE OWNED BY     a   ALTER SEQUENCE public.openwye_opendelta_lines_id_seq OWNED BY public.openwye_opendelta_lines.id;
            public       postgres    false    214            �            1259    16394    points    TABLE     �   CREATE TABLE public.points (
    id bigint NOT NULL,
    points character varying,
    btn_1 character varying,
    btn_2 character varying
);
    DROP TABLE public.points;
       public         postgres    false            �            1259    16400    points_id_seq    SEQUENCE     v   CREATE SEQUENCE public.points_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 $   DROP SEQUENCE public.points_id_seq;
       public       postgres    false    196            �           0    0    points_id_seq    SEQUENCE OWNED BY     ?   ALTER SEQUENCE public.points_id_seq OWNED BY public.points.id;
            public       postgres    false    197            �            1259    16402    results_activity    TABLE       CREATE TABLE public.results_activity (
    id bigint NOT NULL,
    transformer_id character varying,
    primary_phase_current character varying,
    primary_line_current character varying,
    primary_line_voltage character varying,
    primary_phase_voltage character varying,
    apparent_power character varying,
    real_power character varying,
    secondary_phase_current character varying,
    secondary_line_current character varying,
    secondary_line_voltage character varying,
    secondary_phase_voltage character varying
);
 $   DROP TABLE public.results_activity;
       public         postgres    false            �            1259    16555    results_exercises    TABLE       CREATE TABLE public.results_exercises (
    id integer NOT NULL,
    transformer_id character varying,
    primary_phase_current character varying,
    primary_line_current character varying,
    primary_line_voltage character varying,
    primary_phase_voltage character varying,
    apparent_power character varying,
    real_power character varying,
    secondary_phase_current character varying,
    secondary_line_current character varying,
    secondary_line_voltage character varying,
    secondary_phase_voltage character varying
);
 %   DROP TABLE public.results_exercises;
       public         postgres    false            �            1259    16553    results_exercises_id_seq    SEQUENCE     �   CREATE SEQUENCE public.results_exercises_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public.results_exercises_id_seq;
       public       postgres    false    219            �           0    0    results_exercises_id_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE public.results_exercises_id_seq OWNED BY public.results_exercises.id;
            public       postgres    false    218            �            1259    16408    results_id_seq    SEQUENCE     w   CREATE SEQUENCE public.results_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 %   DROP SEQUENCE public.results_id_seq;
       public       postgres    false    198            �           0    0    results_id_seq    SEQUENCE OWNED BY     J   ALTER SEQUENCE public.results_id_seq OWNED BY public.results_activity.id;
            public       postgres    false    199            �            1259    16410    transformer_details    TABLE     �   CREATE TABLE public.transformer_details (
    id smallint NOT NULL,
    polarity character varying,
    rating character varying,
    connection character varying,
    primary_voltage character varying,
    secondary_voltage character varying
);
 '   DROP TABLE public.transformer_details;
       public         postgres    false            �            1259    16416    transformer_details_id_seq    SEQUENCE     �   CREATE SEQUENCE public.transformer_details_id_seq
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public.transformer_details_id_seq;
       public       postgres    false    200            �           0    0    transformer_details_id_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public.transformer_details_id_seq OWNED BY public.transformer_details.id;
            public       postgres    false    201            �            1259    16481    wye_delta_lines    TABLE     �   CREATE TABLE public.wye_delta_lines (
    id integer NOT NULL,
    btn character varying,
    points character varying,
    color character varying,
    clamp_meter character varying,
    transformer_details_id character varying
);
 #   DROP TABLE public.wye_delta_lines;
       public         postgres    false            �            1259    16479    wye_delta_lines_id_seq    SEQUENCE     �   CREATE SEQUENCE public.wye_delta_lines_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.wye_delta_lines_id_seq;
       public       postgres    false    209            �           0    0    wye_delta_lines_id_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.wye_delta_lines_id_seq OWNED BY public.wye_delta_lines.id;
            public       postgres    false    208            �            1259    16424    wye_wye_activity_id_seq    SEQUENCE     �   CREATE SEQUENCE public.wye_wye_activity_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE public.wye_wye_activity_id_seq;
       public       postgres    false    202            �           0    0    wye_wye_activity_id_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.wye_wye_activity_id_seq OWNED BY public.exercise_lines.id;
            public       postgres    false    203            �            1259    16426    wye_wye_lines    TABLE     �   CREATE TABLE public.wye_wye_lines (
    id integer NOT NULL,
    btn character varying,
    points character varying,
    color character varying,
    clamp_meter character varying,
    transformer_details_id character varying
);
 !   DROP TABLE public.wye_wye_lines;
       public         postgres    false            �            1259    16432    wye_wye_lines_id_seq    SEQUENCE     �   CREATE SEQUENCE public.wye_wye_lines_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public.wye_wye_lines_id_seq;
       public       postgres    false    204            �           0    0    wye_wye_lines_id_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public.wye_wye_lines_id_seq OWNED BY public.wye_wye_lines.id;
            public       postgres    false    205            �
           2604    16457    delta_delta_lines id    DEFAULT     |   ALTER TABLE ONLY public.delta_delta_lines ALTER COLUMN id SET DEFAULT nextval('public.delta_delta_lines_id_seq'::regclass);
 C   ALTER TABLE public.delta_delta_lines ALTER COLUMN id DROP DEFAULT;
       public       postgres    false    207    206    207            �
           2604    16495    delta_wye_lines id    DEFAULT     x   ALTER TABLE ONLY public.delta_wye_lines ALTER COLUMN id SET DEFAULT nextval('public.delta_wye_lines_id_seq'::regclass);
 A   ALTER TABLE public.delta_wye_lines ALTER COLUMN id DROP DEFAULT;
       public       postgres    false    210    211    211            �
           2604    16437    exercise_lines id    DEFAULT     x   ALTER TABLE ONLY public.exercise_lines ALTER COLUMN id SET DEFAULT nextval('public.wye_wye_activity_id_seq'::regclass);
 @   ALTER TABLE public.exercise_lines ALTER COLUMN id DROP DEFAULT;
       public       postgres    false    203    202            �
           2604    16547    exercise_transformer_details id    DEFAULT     �   ALTER TABLE ONLY public.exercise_transformer_details ALTER COLUMN id SET DEFAULT nextval('public.exercise_transformer_details_id_seq'::regclass);
 N   ALTER TABLE public.exercise_transformer_details ALTER COLUMN id DROP DEFAULT;
       public       postgres    false    216    217    217            �
           2604    16508    open_delta_lines id    DEFAULT     z   ALTER TABLE ONLY public.open_delta_lines ALTER COLUMN id SET DEFAULT nextval('public.open_delta_lines_id_seq'::regclass);
 B   ALTER TABLE public.open_delta_lines ALTER COLUMN id DROP DEFAULT;
       public       postgres    false    212    213    213            �
           2604    16523    openwye_opendelta_lines id    DEFAULT     �   ALTER TABLE ONLY public.openwye_opendelta_lines ALTER COLUMN id SET DEFAULT nextval('public.openwye_opendelta_lines_id_seq'::regclass);
 I   ALTER TABLE public.openwye_opendelta_lines ALTER COLUMN id DROP DEFAULT;
       public       postgres    false    214    215    215            �
           2604    16434 	   points id    DEFAULT     f   ALTER TABLE ONLY public.points ALTER COLUMN id SET DEFAULT nextval('public.points_id_seq'::regclass);
 8   ALTER TABLE public.points ALTER COLUMN id DROP DEFAULT;
       public       postgres    false    197    196            �
           2604    16435    results_activity id    DEFAULT     q   ALTER TABLE ONLY public.results_activity ALTER COLUMN id SET DEFAULT nextval('public.results_id_seq'::regclass);
 B   ALTER TABLE public.results_activity ALTER COLUMN id DROP DEFAULT;
       public       postgres    false    199    198            �
           2604    16558    results_exercises id    DEFAULT     |   ALTER TABLE ONLY public.results_exercises ALTER COLUMN id SET DEFAULT nextval('public.results_exercises_id_seq'::regclass);
 C   ALTER TABLE public.results_exercises ALTER COLUMN id DROP DEFAULT;
       public       postgres    false    219    218    219            �
           2604    16436    transformer_details id    DEFAULT     �   ALTER TABLE ONLY public.transformer_details ALTER COLUMN id SET DEFAULT nextval('public.transformer_details_id_seq'::regclass);
 E   ALTER TABLE public.transformer_details ALTER COLUMN id DROP DEFAULT;
       public       postgres    false    201    200            �
           2604    16484    wye_delta_lines id    DEFAULT     x   ALTER TABLE ONLY public.wye_delta_lines ALTER COLUMN id SET DEFAULT nextval('public.wye_delta_lines_id_seq'::regclass);
 A   ALTER TABLE public.wye_delta_lines ALTER COLUMN id DROP DEFAULT;
       public       postgres    false    208    209    209            �
           2604    16438    wye_wye_lines id    DEFAULT     t   ALTER TABLE ONLY public.wye_wye_lines ALTER COLUMN id SET DEFAULT nextval('public.wye_wye_lines_id_seq'::regclass);
 ?   ALTER TABLE public.wye_wye_lines ALTER COLUMN id DROP DEFAULT;
       public       postgres    false    205    204            s          0    16454    delta_delta_lines 
   TABLE DATA               h   COPY public.delta_delta_lines (id, btn, points, color, clamp_meter, transformer_details_id) FROM stdin;
    public       postgres    false    207   Sk       w          0    16492    delta_wye_lines 
   TABLE DATA               f   COPY public.delta_wye_lines (id, btn, points, color, clamp_meter, transformer_details_id) FROM stdin;
    public       postgres    false    211   �m       n          0    16418    exercise_lines 
   TABLE DATA               e   COPY public.exercise_lines (id, btn, points, color, transformer_details_id, clamp_meter) FROM stdin;
    public       postgres    false    202   q       }          0    16544    exercise_transformer_details 
   TABLE DATA               }   COPY public.exercise_transformer_details (id, polarity, rating, exercise_no, primary_voltage, secondary_voltage) FROM stdin;
    public       postgres    false    217   Eu       y          0    16505    open_delta_lines 
   TABLE DATA               g   COPY public.open_delta_lines (id, btn, points, color, clamp_meter, transformer_details_id) FROM stdin;
    public       postgres    false    213   �u       {          0    16520    openwye_opendelta_lines 
   TABLE DATA               n   COPY public.openwye_opendelta_lines (id, btn, points, color, clamp_meter, transformer_details_id) FROM stdin;
    public       postgres    false    215   w       h          0    16394    points 
   TABLE DATA               :   COPY public.points (id, points, btn_1, btn_2) FROM stdin;
    public       postgres    false    196   sx       j          0    16402    results_activity 
   TABLE DATA                 COPY public.results_activity (id, transformer_id, primary_phase_current, primary_line_current, primary_line_voltage, primary_phase_voltage, apparent_power, real_power, secondary_phase_current, secondary_line_current, secondary_line_voltage, secondary_phase_voltage) FROM stdin;
    public       postgres    false    198   �{                 0    16555    results_exercises 
   TABLE DATA                 COPY public.results_exercises (id, transformer_id, primary_phase_current, primary_line_current, primary_line_voltage, primary_phase_voltage, apparent_power, real_power, secondary_phase_current, secondary_line_current, secondary_line_voltage, secondary_phase_voltage) FROM stdin;
    public       postgres    false    219   �|       l          0    16410    transformer_details 
   TABLE DATA               s   COPY public.transformer_details (id, polarity, rating, connection, primary_voltage, secondary_voltage) FROM stdin;
    public       postgres    false    200   .}       u          0    16481    wye_delta_lines 
   TABLE DATA               f   COPY public.wye_delta_lines (id, btn, points, color, clamp_meter, transformer_details_id) FROM stdin;
    public       postgres    false    209   9~       p          0    16426    wye_wye_lines 
   TABLE DATA               d   COPY public.wye_wye_lines (id, btn, points, color, clamp_meter, transformer_details_id) FROM stdin;
    public       postgres    false    204   �~       �           0    0    delta_delta_lines_id_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public.delta_delta_lines_id_seq', 517, true);
            public       postgres    false    206            �           0    0    delta_wye_lines_id_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.delta_wye_lines_id_seq', 337, true);
            public       postgres    false    210            �           0    0 #   exercise_transformer_details_id_seq    SEQUENCE SET     Q   SELECT pg_catalog.setval('public.exercise_transformer_details_id_seq', 8, true);
            public       postgres    false    216            �           0    0    open_delta_lines_id_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public.open_delta_lines_id_seq', 297, true);
            public       postgres    false    212            �           0    0    openwye_opendelta_lines_id_seq    SEQUENCE SET     N   SELECT pg_catalog.setval('public.openwye_opendelta_lines_id_seq', 402, true);
            public       postgres    false    214            �           0    0    points_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.points_id_seq', 241, true);
            public       postgres    false    197            �           0    0    results_exercises_id_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.results_exercises_id_seq', 3, true);
            public       postgres    false    218            �           0    0    results_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.results_id_seq', 31, true);
            public       postgres    false    199            �           0    0    transformer_details_id_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public.transformer_details_id_seq', 40, true);
            public       postgres    false    201            �           0    0    wye_delta_lines_id_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.wye_delta_lines_id_seq', 463, true);
            public       postgres    false    208            �           0    0    wye_wye_activity_id_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public.wye_wye_activity_id_seq', 881, true);
            public       postgres    false    203            �           0    0    wye_wye_lines_id_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.wye_wye_lines_id_seq', 1622, true);
            public       postgres    false    205            �
           2606    16462 (   delta_delta_lines delta_delta_lines_pkey 
   CONSTRAINT     f   ALTER TABLE ONLY public.delta_delta_lines
    ADD CONSTRAINT delta_delta_lines_pkey PRIMARY KEY (id);
 R   ALTER TABLE ONLY public.delta_delta_lines DROP CONSTRAINT delta_delta_lines_pkey;
       public         postgres    false    207            �
           2606    16500 $   delta_wye_lines delta_wye_lines_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public.delta_wye_lines
    ADD CONSTRAINT delta_wye_lines_pkey PRIMARY KEY (id);
 N   ALTER TABLE ONLY public.delta_wye_lines DROP CONSTRAINT delta_wye_lines_pkey;
       public         postgres    false    211            �
           2606    16552 >   exercise_transformer_details exercise_transformer_details_pkey 
   CONSTRAINT     |   ALTER TABLE ONLY public.exercise_transformer_details
    ADD CONSTRAINT exercise_transformer_details_pkey PRIMARY KEY (id);
 h   ALTER TABLE ONLY public.exercise_transformer_details DROP CONSTRAINT exercise_transformer_details_pkey;
       public         postgres    false    217            �
           2606    16513 &   open_delta_lines open_delta_lines_pkey 
   CONSTRAINT     d   ALTER TABLE ONLY public.open_delta_lines
    ADD CONSTRAINT open_delta_lines_pkey PRIMARY KEY (id);
 P   ALTER TABLE ONLY public.open_delta_lines DROP CONSTRAINT open_delta_lines_pkey;
       public         postgres    false    213            �
           2606    16528 4   openwye_opendelta_lines openwye_opendelta_lines_pkey 
   CONSTRAINT     r   ALTER TABLE ONLY public.openwye_opendelta_lines
    ADD CONSTRAINT openwye_opendelta_lines_pkey PRIMARY KEY (id);
 ^   ALTER TABLE ONLY public.openwye_opendelta_lines DROP CONSTRAINT openwye_opendelta_lines_pkey;
       public         postgres    false    215            �
           2606    16440    points points_pkey 
   CONSTRAINT     P   ALTER TABLE ONLY public.points
    ADD CONSTRAINT points_pkey PRIMARY KEY (id);
 <   ALTER TABLE ONLY public.points DROP CONSTRAINT points_pkey;
       public         postgres    false    196            �
           2606    16563 (   results_exercises results_exercises_pkey 
   CONSTRAINT     f   ALTER TABLE ONLY public.results_exercises
    ADD CONSTRAINT results_exercises_pkey PRIMARY KEY (id);
 R   ALTER TABLE ONLY public.results_exercises DROP CONSTRAINT results_exercises_pkey;
       public         postgres    false    219            �
           2606    16442    results_activity results_pkey 
   CONSTRAINT     [   ALTER TABLE ONLY public.results_activity
    ADD CONSTRAINT results_pkey PRIMARY KEY (id);
 G   ALTER TABLE ONLY public.results_activity DROP CONSTRAINT results_pkey;
       public         postgres    false    198            �
           2606    16444 ,   transformer_details transformer_details_pkey 
   CONSTRAINT     j   ALTER TABLE ONLY public.transformer_details
    ADD CONSTRAINT transformer_details_pkey PRIMARY KEY (id);
 V   ALTER TABLE ONLY public.transformer_details DROP CONSTRAINT transformer_details_pkey;
       public         postgres    false    200            �
           2606    16489 $   wye_delta_lines wye_delta_lines_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public.wye_delta_lines
    ADD CONSTRAINT wye_delta_lines_pkey PRIMARY KEY (id);
 N   ALTER TABLE ONLY public.wye_delta_lines DROP CONSTRAINT wye_delta_lines_pkey;
       public         postgres    false    209            �
           2606    16446 $   exercise_lines wye_wye_activity_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public.exercise_lines
    ADD CONSTRAINT wye_wye_activity_pkey PRIMARY KEY (id);
 N   ALTER TABLE ONLY public.exercise_lines DROP CONSTRAINT wye_wye_activity_pkey;
       public         postgres    false    202            �
           2606    16448     wye_wye_lines wye_wye_lines_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public.wye_wye_lines
    ADD CONSTRAINT wye_wye_lines_pkey PRIMARY KEY (id);
 J   ALTER TABLE ONLY public.wye_wye_lines DROP CONSTRAINT wye_wye_lines_pkey;
       public         postgres    false    204            s   �  x����n1���gY!ό��}Vi�T��RD���m��2��9��׀W��?�WX�P��j��VhOBf�>�BG�=l���/ub������J��[<���2(��ѦE�=��rr����*����H�Cb�PҭkT����2����m��V�ѽ��j�	� ��'0��7Y8,�%���7Y�O�[���Jl���Ԝ��i7���P�g�}����b�룩5�;�7mL+�7B�wf�X�pBz���ی]_�)�#��ؗ���|������~I�g���/&bːW�a���h��VO�-��\ߣ��w�m�@*X�-C��FR�;H�]}3�.ۣR?����:=�V�e��-,�u��Ϸ�r��	�η�>�U�,|��]ف� ~㲃"�%CZ��>ލ���|t�0]z3E��?4��W�,YA/���u�DZL)�U�EE�'��ϫ�ljg�t`g�̄�c���]������W��Ίpd���&+�#��_�ё�
�����}+lvߊ�ȣ�M<�qԣ�XX[��eEAEe;�1���b»���s��QT�����'�[��87yw�zbӂ�ML^0Σin�"�ش�j�����q�{���e.ld��c��ŢExh�?Ztʁ�Z��,Z���D�g�����t����      w   �  x�}V�n�0<{��(LR�k?!��d�@�:i���~~E�����r�152&��_�׷����4�ix�|��	U�;��a �'�:�D_0�1/r����ϥ��o�����9ۑRo�A���^
���eY~�UF�vk�n<�4PcD;vƝ����<��%�F�{v�s�z�,������� ʣ��=w׮���:��V�<���g�t�|��)ϫ8��G���i��]��`�i�.����d��*��rZթ8�	F�i�M�7({X����K�C��y�?L#e����ap.T������k�(%��A�@Q����|�U���ձ��`�j����Ǎ<����a+/�-��1H������c�V�H�+�i+�ž��zz,)#ޓ�y/�I+���V��{9������n!Pv�^�����9sa��;9'lW�N1���ؚ27�p�dN�!���`�����0��M�a,� S�iE�fH��܍ ��� �!��q0�l�a���AL�G�%�k�ŝ�jX:|z�l��K\�qoݴ3�Gm�Yb��F�ɮ�6v������ld4��F��]�m62����Ph:�'����݌m62L���w Oj����ה�Nbl�w�a�+��7Œ��r����� ��TL=/�ϯ�Y�ʕ��u�(D�Q"�ʲ8
���=�w��Pi��u�zg�E�,����B�Jk3�D�(�ӄ5j� ����\� Z����t��*�(      n   0  x�}W���6=k��($���k?����R�Ii���K��M�H��M�z�P������w���(�9t�F�4�����{t��ku��/ouF݃��!�`�{�
wd4,H��{g����`2'aA�mfJ{pp�ʆ-��̱E�%��~_׿v�v��o�8�Č�7��.1z4��;9D\0��Z{�k+�0��8fdoʗ����BK]$5�3X�$65�:{����9:�R�Ujm��:S�`2�O�ijѭ�]��S���u��.�ͤ�c�]`�ؖe��1)�P��֗/w��U����n�����
�_f��`>!��Bk_�M�-XE��ю2w��"�}�tB��Z�@�����L{�B�{,�@�cq�UU~���r9�'EF�8)C���-ij�[Va��Y�-C~R-!C�*c��X,� �ֽ5�P����b��zV�N��֔'(\��[�(j������R"+O6��?s͙���g�c��Λb,g����b=��,v衜��?됄�y$[ztQ�����8�C~(�m�~�\
�{�ͤ�H�`�t|�U��y"��dR}��CF�7q�Kœ�c�Ӈ����:�%yӬy�n�ߞ��$���p�;]�˱�I��jf�Q`:3�ǫ�S
N�N�tuvJ���)~��R��+T�'���O^�0{�a4�
őm*������~rJ��B�V���e���Be��F�:�J�����T���p�B`��ٓKq@��i�])'M�+�4F�*m�+E��l�])�/�I����e)����X�|_Kǟ�}3o`ʈ�5JQ��`���X�X���������L�R���b5|����q���e&y\s'/^fe��E���㠠c�G;$��{0�����8]Y�R��B/S#S|x$
~�J#q27�ٹ�����
�o���k� �����[OR(�`���͟Me���cY��`�c��x,�{i�ί��}Y s�A2go�����X�B��.=���I M�4����7�oc+U���:H�T4�΍M*Z.lR�"u��]R�`u3.�(\��2�<��_n�����+P      }   ]   x�3�tLI�,�,K�44P�s�4�425�46�2�.M*)JL�*k��hn
��000�4�0�2Eъ)o�]��$oj�e�M����r$�=... �G4Y      y   R  x����j�0��γ�bɶ_��
fwh���v���׿��=�O3�L0'���u~}��,�˳P�	���/  A�R�1X
`;0,�Igv~���o�lG��H2j��Qh��UM���0
%(+�>���ӯ%���̾��;����])nU����T;횂qf��;�1�6�O�(��koה�����-�cr*�8�8JjW�ق�O�Z�׉����&�`���_u��9�	o9����3f=l���C)+�����p��2J��ʨC�z�,�Lt��,L�
q��ߐ���R¦`���*�*�]��ⲿ���C���n���Z��      {   O  x����N�0��γXȻ^��+��	�jK$�R������HpK2�����ދ��-|O�`t�X��G-��H���!<� ��Kՠ��ewx̴���L`�Q�5�u������@ Y	��Wyf�/���.�J�� mU/��Q�3��9�k�������C\�Y����kt���*��fL�tw&U��TN��K�ظ�UQ��bc�Jl���̆\����|���A�ᑶŪ�:��FI��w�y���J���I�Qc>"n�e�A��([�+#8�XMl��G\q�T#޺�fq�p��!����۫���.���~^���:�oc�k��eh�{<�L��e��      h   x  x�u�K�1D׭��H�{��` #�M�� ����%S��Kl�$�T���n$�x��������s�@��A>a)�|��nD�x�>� �HÄo"�q���A�/Az
=M)u�
+L(OU�S��f��щ�}mXx��]kCQISɨ*XQ*X�q������z �F�:P���͌4SPP�}�����s��R��J��ъNK+~Z�[D����.l�>B{чE���il�i
J�`B�G��[��o��HV�MG��V���Jx��!������)H�ݐ�k������`^��93���p�/�G"Jb�u~��a��CT^^*	�瓣/��8����DmeN��O�^�:퐌(g9%imӰ�.?��U�/���H뺑Ӻ���2|�:_B�#�Ѵ����(^��j��H{CR:�Wp�[��P�a0���Z�eKh�8{)��v$��ʠ$�s6�Ө¦E<&�ёtpߴ�B�6S(#b��8¡-�
mhm ѹB8*�#h�΁��j\G�<
J]וyb�������9|Aud� �x�酝 ����kIg$kP����~�؞����dV7��z��H6�x�n(���HH� #Y��"?�
Ǆdf$k��N��&�B�`;�Cv�}u��E$k���A^� Ӳ�z�����d�	��=�L�Ϧ��t�i��`vW�2�� k�"Y������sG�
KD�ɭ՗�����Ln�y��t= ��5Xݖ�45��dv$kKD^� �"�T��Vd0�m-�L�SG�
9"Y��A�U����AA�
u
g�|ڄE\���Ow���9E�)���� ��^w$������C\�;tEJq]��[�(!�����i �V���5����~ft�!�7���D���-���M��      j   �   x�eP[!���(>�{���9u�̬	1��NW�>�"d2^�H�O������Re���q��7P�nմ;èU�Y���v�7+e�l����ݬ�P��� �]*m�wĠ�\5gW���(��h���V��������f
�z3�~@2��m�g����&\m��J.N)}��TO         ]   x�}���0C�f��Od�N���h���J�����,!��#�����n[I|�5��BO&CԺ�w���4Y��Po�G8������FDO�?      l   �   x���M�0���)��f�G˒(&��ƝQ��JE��R�y3}�ͯ��y��o& :-S�Zg��Q���h1)r&0\$-�4}zK`R�#-���^.��>����"� 0��-G4Fu�T�j(h� ��J�ữg勋}#:dC�\�10!�q��,�6R��渂 U�����n��rI�ۗZQ2��1�֡�����6T3�:�>AlX��F툳>W��4��zb3���%�      u   �   x�u�=�0��9K��8t�lHH��l��II�P�?�g��{��0`	��c� ��p���Q��+~�Q�"��Y�Yǋq�tŎ�VYZ5��ٶ�kQQ-v�)=�uB7&��b�x���wK�����/W�`��y�z���_�񚦒�Nz�z�yg�� ��Ws      p   
  x�}U�n�0<k��(D����Oȭ@#�.��N�)��/e�2%���h4�@.����������8�A�Y�p�a��trq����@� �i������'4_���-I�64X�!�O3�q
�便`��� ��z��;� ����8�=��E����vY���Z�/.� �N
�D�8����ː6�>Ee���=�E�?�󼀨.M�^w���g��zl��[9��m}f�C@;��8Q��� Dc�=�W
�#����f�ɶ ��c�9�@*��&�JPO�81xhOg N���ܣ��/�.r{'���\x{���F��v��}�Z��+B!��E�B�>-\���JA�w��O�k�x���P2.��B��B�hq�B�@Qn��j=c�뫊�RH$q���(p�(�dP�ZzI�8˸��,�9Fӂ^�3�0�������R�T�l%5b�Sx�bj�G�v����ލ͓\'����m7{k��	� �6Q�6�����6�r
�����6��#塷UE�y���j�I�mQR(�x+�l�l�-�+�jLr]}���.ԽY>���z�b�:67�[Ij���,��]����z�l��@��3��щ��8%N��@v@8�&�;��K1��j&�i��đ�i��^�|-��g��,����ޜ�� �r���t��!����"z�Y�ADo�m=��Ȩ�re}�8h��u��8�� l��8%E��-L�(�������Ho{
W��#IS�˩��xDF
�w(|�r:��Y���     