
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
	public class Magincia8Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {353, -3, -8, 0}, {3319, -4, -3, 0}, {351, -3, 7, 0}// 1	2	3	
			, {351, -3, 8, 0}, {351, -3, 6, 0}, {351, -3, -7, 0}// 4	5	6	
			, {351, -3, -2, 0}, {351, -3, -1, 0}, {351, -3, -3, 0}// 7	8	9	
			, {351, -3, -6, 0}, {351, -3, -5, 0}, {351, -3, -4, 0}// 10	11	12	
			, {351, -3, 4, 0}, {351, -3, 5, 0}, {351, -3, 3, 0}// 13	14	15	
			, {351, -3, 2, 0}, {352, 1, -8, 0}, {352, 0, -8, 0}// 16	17	18	
			, {352, 2, -8, 0}, {352, -1, -8, 0}, {352, 3, -8, 0}// 19	20	21	
			, {352, 4, -8, 0}, {352, -2, -8, 0}, {1473, 1, -8, 17}// 22	23	24	
			, {1473, 2, -8, 17}, {1473, 0, -8, 17}, {1473, 5, -8, 17}// 25	26	27	
			, {1473, -1, -8, 17}, {1473, 4, -8, 17}, {1473, 3, -8, 17}// 28	29	30	
			, {1473, -2, -8, 17}, {1327, -2, -7, 0}, {1327, 5, 8, 0}// 31	32	33	
			, {1327, 5, 7, 0}, {1327, 5, 6, 0}, {1327, 5, 5, 0}// 34	35	36	
			, {1327, 5, 4, 0}, {1327, 5, 3, 0}, {1327, 5, 2, 0}// 37	38	39	
			, {1327, 5, 1, 0}, {1327, 5, 0, 0}, {1327, 5, -1, 0}// 40	41	42	
			, {1327, 5, -2, 0}, {1327, 5, -3, 0}, {1327, 5, -4, 0}// 43	44	45	
			, {1327, 5, -5, 0}, {1327, 5, -6, 0}, {1327, 5, -7, 0}// 46	47	48	
			, {1327, 4, 8, 0}, {1327, 4, 7, 0}, {1327, 4, 6, 0}// 49	50	51	
			, {1327, 4, 5, 0}, {1327, 4, 4, 0}, {1327, 4, 3, 0}// 52	53	54	
			, {2880, 2, -4, 0}, {2880, -2, -4, 0}, {2878, -1, -4, 0}// 55	56	57	
			, {2878, 1, -4, 0}, {2878, 0, -4, 0}, {351, 5, -1, 0}// 58	59	60	
			, {351, 5, -3, 0}, {351, 5, 0, 0}, {351, 5, -2, 0}// 61	62	63	
			, {351, 5, -7, 0}, {350, 5, 8, 0}, {351, 5, 7, 0}// 64	65	66	
			, {351, 5, 1, 0}, {351, 5, 5, 0}, {351, 5, 6, 0}// 67	68	69	
			, {351, 5, 4, 0}, {351, 5, 2, 0}, {351, 5, 3, 0}// 70	71	72	
			, {352, 3, 8, 0}, {352, 4, 8, 0}, {352, -2, 8, 0}// 73	74	75	
			, {353, 5, 0, 0}, {365, 2, 8, 0}, {368, -1, 8, 0}// 76	77	78	
			, {370, 1, 8, 0}, {370, 0, 8, 0}, {1459, 2, 2, 32}// 79	80	81	
			, {1459, 2, 1, 32}, {1459, 2, 3, 32}, {1459, 2, 5, 32}// 82	83	84	
			, {1459, 2, 4, 32}, {1459, 2, -2, 32}, {1459, 2, 0, 32}// 85	86	87	
			, {1459, 2, -1, 32}, {1459, 2, 6, 32}, {1459, 2, 8, 32}// 88	89	90	
			, {1459, 2, 7, 32}, {1460, 4, 3, 26}, {1460, 4, 2, 26}// 91	92	93	
			, {1460, 4, 6, 26}, {1460, 4, 5, 26}, {1460, 4, 4, 26}// 94	95	96	
			, {1460, 4, 1, 26}, {1460, 4, 0, 26}, {1460, 3, 8, 29}// 97	98	99	
			, {1460, 3, 7, 29}, {1460, 5, 8, 23}, {1460, 5, 7, 23}// 100	101	102	
			, {1460, 5, 6, 23}, {1460, 5, 3, 23}, {1460, 5, 5, 23}// 103	104	105	
			, {1460, 5, 4, 23}, {1460, 4, 8, 26}, {1460, 4, 7, 26}// 106	107	108	
			, {1460, 5, 2, 23}, {1460, 5, 1, 23}, {1460, 3, 6, 29}// 109	110	111	
			, {1460, 3, 2, 29}, {1460, 3, 1, 29}, {1460, 3, 0, 29}// 112	113	114	
			, {1460, 3, 5, 29}, {1460, 3, 4, 29}, {1460, 3, 3, 29}// 115	116	117	
			, {1460, 3, -1, 29}, {1461, 1, -1, 29}, {1461, 1, 6, 29}// 118	119	120	
			, {1461, 1, 7, 29}, {1461, 1, 8, 29}, {1461, 1, 5, 29}// 121	122	123	
			, {1461, 1, 3, 29}, {1461, 1, 0, 29}, {1461, 1, 1, 29}// 124	125	126	
			, {1461, 1, 2, 29}, {1461, 1, 4, 29}, {1461, -2, 4, 20}// 127	128	129	
			, {1461, -1, 6, 23}, {1461, -1, 7, 23}, {1461, -1, 5, 23}// 130	131	132	
			, {1461, -1, 4, 23}, {1461, -1, 8, 23}, {1461, -1, 1, 23}// 133	134	135	
			, {1461, -1, 3, 23}, {1461, -1, 2, 23}, {1461, -2, 3, 20}// 136	137	138	
			, {1461, -2, 2, 20}, {1461, 0, 2, 26}, {1461, 0, 3, 26}// 139	140	141	
			, {1461, 0, 1, 26}, {1461, 0, 0, 26}, {1461, 0, 4, 26}// 142	143	144	
			, {1461, -2, 7, 20}, {1461, -2, 5, 20}, {1461, -2, 6, 20}// 145	146	147	
			, {1461, -2, 8, 20}, {1461, 0, 5, 26}, {1461, 0, 6, 26}// 148	149	150	
			, {1461, 0, 7, 26}, {1461, 0, 8, 26}, {1462, -1, 0, 23}// 151	152	153	
			, {1462, 0, -1, 26}, {1462, -2, 1, 20}, {1462, 1, -2, 29}// 154	155	156	
			, {1465, 5, 0, 23}, {1465, 3, -2, 29}, {1465, 4, -1, 26}// 157	158	159	
			, {1468, 2, -3, 32}, {1471, -1, -3, 32}, {1471, -2, -3, 32}// 160	161	162	
			, {1471, 0, -3, 32}, {1471, 5, -3, 32}, {1471, 4, -3, 32}// 163	164	165	
			, {1471, 1, -3, 32}, {1471, 3, -3, 32}, {1472, -1, -2, 29}// 166	167	168	
			, {1472, -1, -1, 26}, {1472, 4, -2, 29}, {1472, 5, -1, 26}// 169	170	171	
			, {1472, 5, -2, 29}, {1472, 0, -2, 29}, {1472, -2, -1, 26}// 172	173	174	
			, {1472, -2, 0, 23}, {1472, -2, -2, 29}, {1473, 2, -4, 29}// 175	176	177	
			, {1473, 2, -5, 26}, {1473, 1, -6, 23}, {1473, 1, -7, 20}// 178	179	180	
			, {1473, 1, -5, 26}, {1473, 2, -6, 23}, {1473, 2, -7, 20}// 181	182	183	
			, {1473, 0, -5, 26}, {1473, 0, -4, 29}, {1473, 0, -7, 20}// 184	185	186	
			, {1473, 0, -6, 23}, {1473, 5, -4, 29}, {1473, 5, -7, 20}// 187	188	189	
			, {1473, 5, -6, 23}, {1473, 5, -5, 26}, {1473, 3, -4, 29}// 190	191	192	
			, {1473, 3, -5, 26}, {1473, 4, -7, 20}, {1473, 4, -6, 23}// 193	194	195	
			, {1473, 4, -4, 29}, {1473, 4, -5, 26}, {1473, -1, -4, 29}// 196	197	198	
			, {1473, 1, -4, 29}, {1473, -2, -4, 29}, {1473, -1, -7, 20}// 199	200	201	
			, {1473, -1, -6, 23}, {1473, 3, -6, 23}, {1473, 3, -7, 20}// 202	203	204	
			, {1473, -1, -5, 26}, {1473, -2, -6, 23}, {1473, -2, -7, 20}// 205	206	207	
			, {1473, -2, -5, 26}, {1327, 4, 2, 0}, {1327, 4, 1, 0}// 208	209	210	
			, {1327, 4, 0, 0}, {1327, 4, -1, 0}, {1327, 4, -2, 0}// 211	212	213	
			, {1327, 4, -3, 0}, {1327, 4, -4, 0}, {1327, 4, -5, 0}// 214	215	216	
			, {1327, 4, -6, 0}, {1327, 4, -7, 0}, {1327, 3, 8, 0}// 217	218	219	
			, {1327, 3, 7, 0}, {1327, 3, 6, 0}, {1327, 3, 5, 0}// 220	221	222	
			, {1327, 3, 4, 0}, {1327, 3, 3, 0}, {1327, 3, 2, 0}// 223	224	225	
			, {1327, 3, 1, 0}, {1327, 3, 0, 0}, {1327, 3, -1, 0}// 226	227	228	
			, {1327, 3, -2, 0}, {1327, 3, -3, 0}, {1327, 3, -4, 0}// 229	230	231	
			, {1327, 3, -5, 0}, {1327, 3, -6, 0}, {1327, 3, -7, 0}// 232	233	234	
			, {1327, 2, 8, 0}, {1327, 2, 7, 0}, {1327, 2, 6, 0}// 235	236	237	
			, {1327, 2, 5, 0}, {1327, 2, 4, 0}, {1327, 2, 3, 0}// 238	239	240	
			, {1327, 2, 2, 0}, {1327, 2, 1, 0}, {1327, 2, 0, 0}// 241	242	243	
			, {1327, 2, -1, 0}, {1327, 2, -2, 0}, {1327, 2, -3, 0}// 244	245	246	
			, {1327, 2, -4, 0}, {1327, 2, -5, 0}, {1327, 2, -6, 0}// 247	248	249	
			, {1327, 2, -7, 0}, {1327, 1, 8, 0}, {1327, 1, 7, 0}// 250	251	252	
			, {1327, 1, 6, 0}, {1327, 1, 5, 0}, {1327, 1, 4, 0}// 253	254	255	
			, {1327, 1, 3, 0}, {1327, 1, 2, 0}, {1327, 1, 1, 0}// 256	257	258	
			, {1327, 1, 0, 0}, {1327, 1, -1, 0}, {1327, 1, -2, 0}// 259	260	261	
			, {1327, 1, -3, 0}, {1327, 1, -4, 0}, {1327, 1, -5, 0}// 262	263	264	
			, {1327, 1, -6, 0}, {1327, 1, -7, 0}, {1327, 0, 8, 0}// 265	266	267	
			, {1327, 0, 7, 0}, {1327, 0, 6, 0}, {1327, 0, 5, 0}// 268	269	270	
			, {1327, 0, 4, 0}, {1327, 0, 3, 0}, {1327, 0, 2, 0}// 271	272	273	
			, {1327, 0, 1, 0}, {1327, 0, 0, 0}, {1327, 0, -1, 0}// 274	275	276	
			, {1327, 0, -2, 0}, {1327, 0, -3, 0}, {1327, 0, -4, 0}// 277	278	279	
			, {1327, 0, -5, 0}, {1327, 0, -6, 0}, {1327, 0, -7, 0}// 280	281	282	
			, {1327, -1, 8, 0}, {1327, -1, 7, 0}, {1327, -1, 6, 0}// 283	284	285	
			, {1327, -1, 5, 0}, {1327, -1, 4, 0}, {1327, -1, 3, 0}// 286	287	288	
			, {1327, -1, 2, 0}, {1327, -1, 1, 0}, {1327, -2, -6, 0}// 289	290	291	
			, {1327, -1, 0, 0}, {1327, -1, -1, 0}, {1327, -1, -2, 0}// 292	293	294	
			, {1327, -1, -3, 0}, {1327, -1, -4, 0}, {1327, -1, -5, 0}// 295	296	297	
			, {1327, -1, -6, 0}, {1327, -1, -7, 0}, {1327, -2, 8, 0}// 298	299	300	
			, {1327, -2, 7, 0}, {1327, -2, 6, 0}, {1327, -2, 5, 0}// 301	302	303	
			, {1327, -2, 4, 0}, {1327, -2, 3, 0}, {1327, -2, 2, 0}// 304	305	306	
			, {1327, -2, 1, 0}, {1327, -2, 0, 0}, {1327, -2, -1, 0}// 307	308	309	
			, {1327, -2, -2, 0}, {1327, -2, -3, 0}, {1327, -2, -4, 0}// 310	311	312	
			, {1327, -2, -5, 0}, {2474, -2, -4, 6}, {6226, 2, -4, 6}// 313	314	315	
			, {3823, -1, -4, 7}, {351, 5, -6, 0}, {351, 5, -5, 0}// 316	317	318	
			, {351, 5, -4, 0}// 319	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Magincia8AddonDeed();
			}
		}

		[ Constructable ]
		public Magincia8Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public Magincia8Addon( Serial serial ) : base( serial )
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

	public class Magincia8AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Magincia8Addon();
			}
		}

		[Constructable]
		public Magincia8AddonDeed()
		{
			Name = "Magincia8";
		}

		public Magincia8AddonDeed( Serial serial ) : base( serial )
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