
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class CrystalCave1Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1340, -4, -8, 0}, {1340, -3, -8, 0}, {1340, -2, -8, 0}// 1	2	3	
			, {1340, -1, -8, 0}, {1340, 0, -8, 0}, {1340, 1, -8, 0}// 4	5	6	
			, {1340, 2, -8, 0}, {1340, 3, -8, 0}, {1340, 4, -8, 0}// 7	8	9	
			, {1340, 5, -8, 0}, {1340, -2, -11, 0}, {1340, -2, -10, 0}// 10	11	12	
			, {1340, -2, -9, 0}, {1340, -1, -11, 0}, {1340, -1, -10, 0}// 13	14	15	
			, {1340, -1, -9, 0}, {1340, 0, -11, 0}, {1340, 0, -10, 0}// 16	17	18	
			, {1340, 0, -9, 0}, {1340, 1, -11, 0}, {1340, 1, -10, 0}// 19	20	21	
			, {1340, 1, -9, 0}, {1352, 2, -12, 0}, {1353, -3, -12, 0}// 22	23	24	
			, {1353, -5, -9, 0}, {1354, -5, -8, 0}, {1354, -3, -11, 0}// 25	26	27	
			, {1354, -3, -10, 0}, {1357, 3, -9, 0}, {1357, 4, -9, 0}// 28	29	30	
			, {1357, 5, -9, 0}, {1357, -2, -12, 0}, {1357, -1, -12, 0}// 31	32	33	
			, {1357, 0, -12, 0}, {1357, 1, -12, 0}, {2280, -3, -9, 0}// 34	35	36	
			, {2272, 2, -9, 0}, {1357, -4, -9, 0}, {1349, 2, -11, 0}// 37	38	39	
			, {1349, 2, -10, 0}, {605, -3, -8, 0}, {606, -2, -9, 0}// 40	41	42	
			, {612, -2, -8, 0}, {1340, -4, 1, 0}, {1340, -4, 2, 0}// 43	44	45	
			, {1340, -4, 3, 0}, {1340, -4, 4, 0}, {1340, -4, 5, 0}// 46	47	48	
			, {1340, -4, 6, 0}, {1340, -4, 7, 0}, {1340, -4, 8, 0}// 49	50	51	
			, {1340, -3, 1, 0}, {1340, -3, 2, 0}, {1340, -3, 3, 0}// 52	53	54	
			, {1340, -3, 4, 0}, {1340, -3, 5, 0}, {1340, -3, 6, 0}// 55	56	57	
			, {1340, -3, 7, 0}, {1340, -3, 8, 0}, {1340, -2, 1, 0}// 58	59	60	
			, {1340, -2, 2, 0}, {1340, -2, 3, 0}, {1340, -2, 4, 0}// 61	62	63	
			, {1340, -2, 5, 0}, {1340, -2, 6, 0}, {1340, -2, 7, 0}// 64	65	66	
			, {1340, -2, 8, 0}, {1340, -1, 1, 0}, {1340, -1, 2, 0}// 67	68	69	
			, {1340, -1, 3, 0}, {1340, -1, 4, 0}, {1340, -1, 5, 0}// 70	71	72	
			, {1340, -1, 6, 0}, {1340, -1, 7, 0}, {1340, -1, 8, 0}// 73	74	75	
			, {1340, 0, 1, 0}, {1340, 0, 2, 0}, {1340, 0, 3, 0}// 76	77	78	
			, {1340, 0, 4, 0}, {1340, 0, 5, 0}, {1340, 0, 6, 0}// 79	80	81	
			, {1340, 0, 7, 0}, {1340, 0, 8, 0}, {1340, 1, 1, 0}// 82	83	84	
			, {1340, 1, 2, 0}, {1340, 1, 3, 0}, {1340, 1, 4, 0}// 85	86	87	
			, {1340, 1, 5, 0}, {1340, 1, 6, 0}, {1340, 1, 7, 0}// 88	89	90	
			, {1340, 1, 8, 0}, {1340, 2, 1, 0}, {1340, 2, 2, 0}// 91	92	93	
			, {1340, 2, 3, 0}, {1340, 2, 4, 0}, {1340, 2, 5, 0}// 94	95	96	
			, {1340, 2, 6, 0}, {1340, 2, 7, 0}, {1340, 2, 8, 0}// 97	98	99	
			, {1340, 3, 1, 0}, {1340, 3, 2, 0}, {1340, 3, 3, 0}// 100	101	102	
			, {1340, 3, 4, 0}, {1340, 3, 5, 0}, {1340, 3, 6, 0}// 103	104	105	
			, {1340, 3, 7, 0}, {1340, 3, 8, 0}, {1340, 4, 1, 0}// 106	107	108	
			, {1340, 4, 2, 0}, {1340, 4, 3, 0}, {1340, 4, 4, 0}// 109	110	111	
			, {1340, 4, 5, 0}, {1340, 4, 6, 0}, {1340, 4, 7, 0}// 112	113	114	
			, {1340, 4, 8, 0}, {1340, 5, 1, 0}, {1340, 5, 2, 0}// 115	116	117	
			, {1340, 5, 3, 0}, {1340, 5, 4, 0}, {1340, 5, 5, 0}// 118	119	120	
			, {1340, 5, 6, 0}, {1340, 5, 7, 0}, {1340, 5, 8, 0}// 121	122	123	
			, {1340, -4, -7, 0}, {1340, -4, -6, 0}, {1340, -4, -5, 0}// 124	125	126	
			, {1340, -4, -4, 0}, {1340, -4, -3, 0}, {1340, -4, -2, 0}// 127	128	129	
			, {1340, -4, -1, 0}, {1340, -4, 0, 0}, {1340, -3, -7, 0}// 130	131	132	
			, {1340, -3, -6, 0}, {1340, -3, -5, 0}, {1340, -3, -4, 0}// 133	134	135	
			, {1340, -3, -3, 0}, {1340, -3, -2, 0}, {1340, -3, -1, 0}// 136	137	138	
			, {1340, -3, 0, 0}, {1340, -2, -7, 0}, {1340, -2, -6, 0}// 139	140	141	
			, {1340, -2, -5, 0}, {1340, -2, -4, 0}, {1340, -2, -3, 0}// 142	143	144	
			, {1340, -2, -2, 0}, {1340, -2, -1, 0}, {1340, -2, 0, 0}// 145	146	147	
			, {1340, -1, -7, 0}, {1340, -1, -6, 0}, {1340, -1, -5, 0}// 148	149	150	
			, {1340, -1, -4, 0}, {1340, -1, -3, 0}, {1340, -1, -2, 0}// 151	152	153	
			, {1340, -1, -1, 0}, {1340, -1, 0, 0}, {1340, 0, -7, 0}// 154	155	156	
			, {1340, 0, -6, 0}, {1340, 0, -5, 0}, {1340, 0, -4, 0}// 157	158	159	
			, {1340, 0, -3, 0}, {1340, 0, -2, 0}, {1340, 0, -1, 0}// 160	161	162	
			, {1340, 0, 0, 0}, {1340, 1, -7, 0}, {1340, 1, -6, 0}// 163	164	165	
			, {1340, 1, -5, 0}, {1340, 1, -4, 0}, {1340, 1, -3, 0}// 166	167	168	
			, {1340, 1, -2, 0}, {1340, 1, -1, 0}, {1340, 1, 0, 0}// 169	170	171	
			, {1340, 2, -7, 0}, {1340, 2, -6, 0}, {1340, 2, -5, 0}// 172	173	174	
			, {1340, 2, -4, 0}, {1340, 2, -3, 0}, {1340, 2, -2, 0}// 175	176	177	
			, {1340, 2, -1, 0}, {1340, 2, 0, 0}, {1340, 3, -7, 0}// 178	179	180	
			, {1340, 3, -6, 0}, {1340, 3, -5, 0}, {1340, 3, -4, 0}// 181	182	183	
			, {1340, 3, -3, 0}, {1340, 3, -2, 0}, {1340, 3, -1, 0}// 184	185	186	
			, {1340, 3, 0, 0}, {1340, 4, -7, 0}, {1340, 4, -6, 0}// 187	188	189	
			, {1340, 4, -5, 0}, {1340, 4, -4, 0}, {1340, 4, -3, 0}// 190	191	192	
			, {1340, 4, -2, 0}, {1340, 4, -1, 0}, {1340, 4, 0, 0}// 193	194	195	
			, {1340, 5, -7, 0}, {1340, 5, -6, 0}, {1340, 5, -5, 0}// 196	197	198	
			, {1340, 5, -4, 0}, {1340, 5, -3, 0}, {1340, 5, -2, 0}// 199	200	201	
			, {1340, 5, -1, 0}, {1340, 5, 0, 0}, {1340, -7, 3, 0}// 202	203	204	
			, {1340, -7, 4, 0}, {1340, -7, 5, 0}, {1340, -7, 6, 0}// 205	206	207	
			, {1340, -6, 3, 0}, {1340, -6, 4, 0}, {1340, -6, 5, 0}// 208	209	210	
			, {1340, -6, 6, 0}, {1340, -5, 3, 0}, {1340, -5, 4, 0}// 211	212	213	
			, {1340, -5, 5, 0}, {1340, -5, 6, 0}, {1351, -8, 7, 0}// 214	215	216	
			, {1353, -8, 2, 0}, {1354, -5, -7, 0}, {1354, -5, -6, 0}// 217	218	219	
			, {1354, -5, -5, 0}, {1354, -5, -4, 0}, {1354, -5, -3, 0}// 220	221	222	
			, {1354, -5, -2, 0}, {1354, -5, -1, 0}, {1354, -5, 0, 0}// 223	224	225	
			, {1354, -8, 3, 0}, {1354, -8, 4, 0}, {1354, -8, 5, 0}// 226	227	228	
			, {1354, -8, 6, 0}, {1354, -5, 8, 0}, {2273, -5, 7, 0}// 229	230	231	
			, {2276, 3, 2, 0}, {2273, -2, -3, 0}, {2277, 0, 6, 0}// 232	233	234	
			, {2282, 1, 5, 0}, {2278, 0, 5, 0}, {1356, -5, 1, 0}// 235	236	237	
			, {1359, -7, 2, 0}, {1359, -6, 2, 0}, {1346, -7, 7, 0}// 238	239	240	
			, {1346, -6, 7, 0}, {2275, -5, 2, 0}, {611, 4, 8, 0}// 241	242	243	
			, {613, 5, 8, 0}, {616, -2, 1, 0}, {615, -1, 0, 0}// 244	245	246	
			, {613, -3, 2, 0}, {612, -2, 2, 0}, {612, -1, 1, 0}// 247	248	249	
			, {619, -2, 2, 22}, {2280, -2, 0, 0}, {1340, -4, 9, 0}// 250	251	252	
			, {1340, -4, 10, 0}, {1340, -4, 11, 0}, {1340, -3, 9, 0}// 253	254	255	
			, {1340, -3, 10, 0}, {1340, -3, 11, 0}, {1340, -2, 9, 0}// 256	257	258	
			, {1340, -2, 10, 0}, {1340, -2, 11, 0}, {1340, -1, 9, 0}// 259	260	261	
			, {1340, -1, 10, 0}, {1340, -1, 11, 0}, {1340, 0, 9, 0}// 262	263	264	
			, {1340, 0, 10, 0}, {1340, 0, 11, 0}, {1340, 1, 9, 0}// 265	266	267	
			, {1340, 1, 10, 0}, {1340, 1, 11, 0}, {1340, 2, 9, 0}// 268	269	270	
			, {1340, 2, 10, 0}, {1340, 2, 11, 0}, {1340, 3, 9, 0}// 271	272	273	
			, {1340, 3, 10, 0}, {1340, 3, 11, 0}, {1340, 4, 9, 0}// 274	275	276	
			, {1340, 4, 10, 0}, {1340, 4, 11, 0}, {1340, 5, 9, 0}// 277	278	279	
			, {1340, 5, 10, 0}, {1340, 5, 11, 0}, {1345, 3, 12, 0}// 280	281	282	
			, {1345, 4, 12, 0}, {1345, 5, 12, 0}, {1351, -5, 12, 0}// 283	284	285	
			, {1354, -5, 9, 0}, {1354, -5, 10, 0}, {1354, -5, 11, 0}// 286	287	288	
			, {1346, -4, 12, 0}, {1346, -3, 12, 0}, {1346, -2, 12, 0}// 289	290	291	
			, {1346, -1, 12, 0}, {1346, 0, 12, 0}, {1346, 1, 12, 0}// 292	293	294	
			, {1346, 2, 12, 0}, {609, 3, 9, 0}, {612, 4, 9, 0}// 295	296	297	
			, {1352, 6, -9, 0}, {1348, 6, -8, 0}, {1348, 6, 3, 0}// 298	299	300	
			, {1348, 6, 4, 0}, {1348, 6, 5, 0}, {1348, 6, 6, 0}// 301	302	303	
			, {1348, 6, 7, 0}, {1348, 6, 8, 0}, {1340, 6, -4, 0}// 304	305	306	
			, {1340, 6, -3, 0}, {1340, 6, -2, 0}, {1340, 6, -1, 0}// 307	308	309	
			, {1340, 7, -4, 0}, {1340, 7, -3, 0}, {1340, 7, -2, 0}// 310	311	312	
			, {1340, 7, -1, 0}, {1340, 8, -4, 0}, {1340, 8, -3, 0}// 313	314	315	
			, {1340, 8, -2, 0}, {1340, 8, -1, 0}, {1344, 9, 0, 0}// 316	317	318	
			, {1345, 7, 0, 0}, {1348, 6, 1, 0}, {1348, 9, -4, 0}// 319	320	321	
			, {1348, 9, -3, 0}, {1348, 9, -2, 0}, {1348, 9, -1, 0}// 322	323	324	
			, {1352, 9, -5, 0}, {1359, 7, -5, 0}, {1359, 8, -5, 0}// 325	326	327	
			, {2274, 6, 0, 0}, {2275, 6, -5, 0}, {1348, 6, -7, 0}// 328	329	330	
			, {1348, 6, -6, 0}, {604, 7, 0, 0}, {612, 7, 1, 0}// 331	332	333	
			, {607, 6, 1, 0}, {1344, 8, 2, 0}, {1345, 7, 2, 0}// 334	335	336	
			, {1339, 6, 2, 0}, {1348, 8, 1, 0}, {1341, 8, 0, 0}// 337	338	339	
			, {1344, 6, 12, 0}, {1348, 6, 9, 0}, {1348, 6, 10, 0}// 340	341	342	
			, {1348, 6, 11, 0}// 343	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CrystalCave1AddonDeed();
			}
		}

		[ Constructable ]
		public CrystalCave1Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public CrystalCave1Addon( Serial serial ) : base( serial )
		{
		}


		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class CrystalCave1AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CrystalCave1Addon();
			}
		}

		[Constructable]
		public CrystalCave1AddonDeed()
		{
			Name = "CrystalCave1";
		}

		public CrystalCave1AddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}