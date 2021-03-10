PGDMP     -    8        
        y            transformer_banking    11.11    11.11 J    j           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                       false            k           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                       false            l           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                       false            m           1262    16393    transformer_banking    DATABASE     �   CREATE DATABASE transformer_banking WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'English_United States.1252' LC_CTYPE = 'English_United States.1252';
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
       public       postgres    false    207            n           0    0    delta_delta_lines_id_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE public.delta_delta_lines_id_seq OWNED BY public.delta_delta_lines.id;
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
       public       postgres    false    211            o           0    0    delta_wye_lines_id_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.delta_wye_lines_id_seq OWNED BY public.delta_wye_lines.id;
            public       postgres    false    210            �            1259    16505    open_delta_lines    TABLE     �   CREATE TABLE public.open_delta_lines (
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
       public       postgres    false    213            p           0    0    open_delta_lines_id_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public.open_delta_lines_id_seq OWNED BY public.open_delta_lines.id;
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
       public       postgres    false    215            q           0    0    openwye_opendelta_lines_id_seq    SEQUENCE OWNED BY     a   ALTER SEQUENCE public.openwye_opendelta_lines_id_seq OWNED BY public.openwye_opendelta_lines.id;
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
       public       postgres    false    196            r           0    0    points_id_seq    SEQUENCE OWNED BY     ?   ALTER SEQUENCE public.points_id_seq OWNED BY public.points.id;
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
       public         postgres    false            �            1259    16408    results_id_seq    SEQUENCE     w   CREATE SEQUENCE public.results_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 %   DROP SEQUENCE public.results_id_seq;
       public       postgres    false    198            s           0    0    results_id_seq    SEQUENCE OWNED BY     J   ALTER SEQUENCE public.results_id_seq OWNED BY public.results_activity.id;
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
       public       postgres    false    200            t           0    0    transformer_details_id_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public.transformer_details_id_seq OWNED BY public.transformer_details.id;
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
       public       postgres    false    209            u           0    0    wye_delta_lines_id_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.wye_delta_lines_id_seq OWNED BY public.wye_delta_lines.id;
            public       postgres    false    208            �            1259    16418    wye_wye_activity    TABLE     �   CREATE TABLE public.wye_wye_activity (
    id integer NOT NULL,
    btn character varying,
    points character varying,
    colors character varying,
    transformer_details_id character varying
);
 $   DROP TABLE public.wye_wye_activity;
       public         postgres    false            �            1259    16424    wye_wye_activity_id_seq    SEQUENCE     �   CREATE SEQUENCE public.wye_wye_activity_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE public.wye_wye_activity_id_seq;
       public       postgres    false    202            v           0    0    wye_wye_activity_id_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public.wye_wye_activity_id_seq OWNED BY public.wye_wye_activity.id;
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
       public       postgres    false    204            w           0    0    wye_wye_lines_id_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public.wye_wye_lines_id_seq OWNED BY public.wye_wye_lines.id;
            public       postgres    false    205            �
           2604    16457    delta_delta_lines id    DEFAULT     |   ALTER TABLE ONLY public.delta_delta_lines ALTER COLUMN id SET DEFAULT nextval('public.delta_delta_lines_id_seq'::regclass);
 C   ALTER TABLE public.delta_delta_lines ALTER COLUMN id DROP DEFAULT;
       public       postgres    false    206    207    207            �
           2604    16495    delta_wye_lines id    DEFAULT     x   ALTER TABLE ONLY public.delta_wye_lines ALTER COLUMN id SET DEFAULT nextval('public.delta_wye_lines_id_seq'::regclass);
 A   ALTER TABLE public.delta_wye_lines ALTER COLUMN id DROP DEFAULT;
       public       postgres    false    210    211    211            �
           2604    16508    open_delta_lines id    DEFAULT     z   ALTER TABLE ONLY public.open_delta_lines ALTER COLUMN id SET DEFAULT nextval('public.open_delta_lines_id_seq'::regclass);
 B   ALTER TABLE public.open_delta_lines ALTER COLUMN id DROP DEFAULT;
       public       postgres    false    213    212    213            �
           2604    16523    openwye_opendelta_lines id    DEFAULT     �   ALTER TABLE ONLY public.openwye_opendelta_lines ALTER COLUMN id SET DEFAULT nextval('public.openwye_opendelta_lines_id_seq'::regclass);
 I   ALTER TABLE public.openwye_opendelta_lines ALTER COLUMN id DROP DEFAULT;
       public       postgres    false    215    214    215            �
           2604    16434 	   points id    DEFAULT     f   ALTER TABLE ONLY public.points ALTER COLUMN id SET DEFAULT nextval('public.points_id_seq'::regclass);
 8   ALTER TABLE public.points ALTER COLUMN id DROP DEFAULT;
       public       postgres    false    197    196            �
           2604    16435    results_activity id    DEFAULT     q   ALTER TABLE ONLY public.results_activity ALTER COLUMN id SET DEFAULT nextval('public.results_id_seq'::regclass);
 B   ALTER TABLE public.results_activity ALTER COLUMN id DROP DEFAULT;
       public       postgres    false    199    198            �
           2604    16436    transformer_details id    DEFAULT     �   ALTER TABLE ONLY public.transformer_details ALTER COLUMN id SET DEFAULT nextval('public.transformer_details_id_seq'::regclass);
 E   ALTER TABLE public.transformer_details ALTER COLUMN id DROP DEFAULT;
       public       postgres    false    201    200            �
           2604    16484    wye_delta_lines id    DEFAULT     x   ALTER TABLE ONLY public.wye_delta_lines ALTER COLUMN id SET DEFAULT nextval('public.wye_delta_lines_id_seq'::regclass);
 A   ALTER TABLE public.wye_delta_lines ALTER COLUMN id DROP DEFAULT;
       public       postgres    false    209    208    209            �
           2604    16437    wye_wye_activity id    DEFAULT     z   ALTER TABLE ONLY public.wye_wye_activity ALTER COLUMN id SET DEFAULT nextval('public.wye_wye_activity_id_seq'::regclass);
 B   ALTER TABLE public.wye_wye_activity ALTER COLUMN id DROP DEFAULT;
       public       postgres    false    203    202            �
           2604    16438    wye_wye_lines id    DEFAULT     t   ALTER TABLE ONLY public.wye_wye_lines ALTER COLUMN id SET DEFAULT nextval('public.wye_wye_lines_id_seq'::regclass);
 ?   ALTER TABLE public.wye_wye_lines ALTER COLUMN id DROP DEFAULT;
       public       postgres    false    205    204            _          0    16454    delta_delta_lines 
   TABLE DATA               h   COPY public.delta_delta_lines (id, btn, points, color, clamp_meter, transformer_details_id) FROM stdin;
    public       postgres    false    207   aW       c          0    16492    delta_wye_lines 
   TABLE DATA               f   COPY public.delta_wye_lines (id, btn, points, color, clamp_meter, transformer_details_id) FROM stdin;
    public       postgres    false    211   ~W       e          0    16505    open_delta_lines 
   TABLE DATA               g   COPY public.open_delta_lines (id, btn, points, color, clamp_meter, transformer_details_id) FROM stdin;
    public       postgres    false    213   Y       g          0    16520    openwye_opendelta_lines 
   TABLE DATA               n   COPY public.openwye_opendelta_lines (id, btn, points, color, clamp_meter, transformer_details_id) FROM stdin;
    public       postgres    false    215   �Z       T          0    16394    points 
   TABLE DATA               :   COPY public.points (id, points, btn_1, btn_2) FROM stdin;
    public       postgres    false    196   :\       V          0    16402    results_activity 
   TABLE DATA                 COPY public.results_activity (id, transformer_id, primary_phase_current, primary_line_current, primary_line_voltage, primary_phase_voltage, apparent_power, real_power, secondary_phase_current, secondary_line_current, secondary_line_voltage, secondary_phase_voltage) FROM stdin;
    public       postgres    false    198   �_       X          0    16410    transformer_details 
   TABLE DATA               s   COPY public.transformer_details (id, polarity, rating, connection, primary_voltage, secondary_voltage) FROM stdin;
    public       postgres    false    200   �_       a          0    16481    wye_delta_lines 
   TABLE DATA               f   COPY public.wye_delta_lines (id, btn, points, color, clamp_meter, transformer_details_id) FROM stdin;
    public       postgres    false    209   �`       Z          0    16418    wye_wye_activity 
   TABLE DATA               [   COPY public.wye_wye_activity (id, btn, points, colors, transformer_details_id) FROM stdin;
    public       postgres    false    202   �a       \          0    16426    wye_wye_lines 
   TABLE DATA               d   COPY public.wye_wye_lines (id, btn, points, color, clamp_meter, transformer_details_id) FROM stdin;
    public       postgres    false    204   �a       x           0    0    delta_delta_lines_id_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public.delta_delta_lines_id_seq', 257, true);
            public       postgres    false    206            y           0    0    delta_wye_lines_id_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.delta_wye_lines_id_seq', 53, true);
            public       postgres    false    210            z           0    0    open_delta_lines_id_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.open_delta_lines_id_seq', 86, true);
            public       postgres    false    212            {           0    0    openwye_opendelta_lines_id_seq    SEQUENCE SET     N   SELECT pg_catalog.setval('public.openwye_opendelta_lines_id_seq', 118, true);
            public       postgres    false    214            |           0    0    points_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.points_id_seq', 241, true);
            public       postgres    false    197            }           0    0    results_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.results_id_seq', 16, true);
            public       postgres    false    199            ~           0    0    transformer_details_id_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public.transformer_details_id_seq', 9, true);
            public       postgres    false    201                       0    0    wye_delta_lines_id_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.wye_delta_lines_id_seq', 29, true);
            public       postgres    false    208            �           0    0    wye_wye_activity_id_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.wye_wye_activity_id_seq', 1, false);
            public       postgres    false    203            �           0    0    wye_wye_lines_id_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.wye_wye_lines_id_seq', 1246, true);
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
           2606    16446 &   wye_wye_activity wye_wye_activity_pkey 
   CONSTRAINT     d   ALTER TABLE ONLY public.wye_wye_activity
    ADD CONSTRAINT wye_wye_activity_pkey PRIMARY KEY (id);
 P   ALTER TABLE ONLY public.wye_wye_activity DROP CONSTRAINT wye_wye_activity_pkey;
       public         postgres    false    202            �
           2606    16448     wye_wye_lines wye_wye_lines_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public.wye_wye_lines
    ADD CONSTRAINT wye_wye_lines_pkey PRIMARY KEY (id);
 J   ALTER TABLE ONLY public.wye_wye_lines DROP CONSTRAINT wye_wye_lines_pkey;
       public         postgres    false    204            _      x������ � �      c   �  x�u�IN�0E��Y,�<d��!!Y�M$aP����J�u�?/���/o�����r�����h�	���	@�0��4}	P� V��v��Z7�1��lTq�¶ \O�:��$TV	n�S��Zpl�y~��Oh�]��eBO�pt[Y�ԸViW5�p��ևZ�:�O9�%��b��N��<��2��N/�r-qT(AGgXY��H��[��"II������H	�B�&�Ƣe�بߣX�B����T����:ZZ�ʂ�Z�2����R���e��e�����ھ���
�9��$�<�Icce���W�/p�K2YwƦMe��oڨ˪dleI�R���'����[�]륪��6AW��Ӗ�1.��-ڑ�����!U�3���f�_��       e   �  x���݊1F��g1�����GػB�$i���6l��}�ڒgƅ�\���O�3������_���s��=�|���'"�oP���!8#�t��D��
)y�nF�I�(�B�D|��̛�� 5���浰�Bt�o����%m�1��"��k�hmE��x@��i~߮�b�7@�ˬ��n��ȴ�Ў�x��]��M۰(i2�ݤn2��y�4ڦ^[7��i�αC���1˖��|���'��?�/-�o�� �[k�m]Q�sl~�ۧ�y���O����A�����'1m/�����_��y���oDL��{I:�?9��xn��x-���z~��(z�0F�^ģh̘��6��85�P�Y/�2
�<�u��Ĉ=��}�������|�)Y��/��{=����%v��j��&!ոC:Ҕġ�cFmN-���w����t��!6�      g   M  x����N�0��γD��c�s��!!Ym��������&��p�f���1�ٟ�����5�"�0�5w�f��|��F�֨�|����hn���ncр����G2��(��U���⊞��u�JC�+��@2��
�y���#Y^-�s>�D����a0�sJ��:B�¼�1������� ��'TO��F�f��y���N���l�{AU�#.W�ԡ�$8���qE�>�7�~�[uZ�}�
�Xq��:��}Y ;hW	�}p�wm�����V�_z����P�O.#`��D%�x]�F �؀ˆ%��yG�b���E�+��p3���      T   x  x�u�K�1D׭��H�{��` #�M�� ����%S��Kl�$�T���n$�x��������s�@��A>a)�|��nD�x�>� �HÄo"�q���A�/Az
=M)u�
+L(OU�S��f��щ�}mXx��]kCQISɨ*XQ*X�q������z �F�:P���͌4SPP�}�����s��R��J��ъNK+~Z�[D����.l�>B{чE���il�i
J�`B�G��[��o��HV�MG��V���Jx��!������)H�ݐ�k������`^��93���p�/�G"Jb�u~��a��CT^^*	�瓣/��8����DmeN��O�^�:퐌(g9%imӰ�.?��U�/���H뺑Ӻ���2|�:_B�#�Ѵ����(^��j��H{CR:�Wp�[��P�a0���Z�eKh�8{)��v$��ʠ$�s6�Ө¦E<&�ёtpߴ�B�6S(#b��8¡-�
mhm ѹB8*�#h�΁��j\G�<
J]וyb�������9|Aud� �x�酝 ����kIg$kP����~�؞����dV7��z��H6�x�n(���HH� #Y��"?�
Ǆdf$k��N��&�B�`;�Cv�}u��E$k���A^� Ӳ�z�����d�	��=�L�Ϧ��t�i��`vW�2�� k�"Y������sG�
KD�ɭ՗�����Ln�y��t= ��5Xݖ�45��dv$kKD^� �"�T��Vd0�m-�L�SG�
9"Y��A�U����AA�
u
g�|ڄE\���Ow���9E�)���� ��^w$������C\�;tEJq]��[�(!�����i �V���5����~ft�!�7���D���-���M��      V   (   x�34�4�4�3�&�Fz��F����1~Ȉ+F��� �4}      X   }   x�3�tLI�,�,K�42U�s��t�bg??W�O?��2B(54��Ԙ3�4��(1�(�&�ldj�il�e�����'�QLbQo�C=v�ͱ�����\�p*�Ī\d��K_� ��m�      a   "  x�u��N1���g�P���^ynHHQ[V�E���&j��<�2�q@��1~���]�K�YzX�ɒ���'��[GE�����;���H&D������>I&n��R�P9�9H�����YQG���L¶��=dO.��.���oA�e�u�G�@�M!�er�$��Z�HS�%�$���B����V����
�2�C���dQ�m�F2���0��*�9o�d���^욣6Bߑ}GE/&�9��s�	ǖ��Ēh$��ou$�s_h��q��i�Ҵ�      Z      x������ � �      \   %  x�}�Mn1���Y�HQ�!��k�E'���I�_J�h8���㣞( D��r���|��r�S��=����  ����O�2'G���٭���r<�v���}��4��
-@��@�����A�)x��CoH��jI�;$�%� �q����n#�@�R���.X�c�JFж��cʖ�۶�!\���i��<NT�Ｆ��CS'�;�=8,��W�G������Q��շ��y�$�q�?�|�'�\ �X��~��ILX&�4��l�#�8Ƞ�LaJ�Xi\3�.IL<y]D�N�B�p^gS`��(�
����ȉ�Ͽ��#ۂ�M��@ �[�i,\`��$�-Xc��i9>]giN@띢��5'5/�kOnFS���+��[Д�|_ 6
���=�K��1���١��t�ô��
�U?�]@/��1�������9hs��P?�װ�֠Tv���7Oa����� u�G6���^�]�ϥ/<6�lf�����ʫf�u4	;o7�������߂]�Om��˦ѹ/�5�֩B���>����/���?�#��     