
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
	public class FieldsStoneCityTavernNEWAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4554, 3, 4, 0}, {8560, 0, 2, 29}, {8560, 1, -3, 26}// 1	2	3	
			, {1475, 5, 3, 26}, {8560, 0, 3, 29}, {631, -2, 3, 27}// 4	5	6	
			, {1474, 4, 2, 27}, {2796, 1, 0, 8}, {2802, 0, 2, 8}// 7	8	9	
			, {2802, 0, 3, 8}, {7375, 5, 4, 5}, {8560, 1, 3, 26}// 10	11	12	
			, {1475, 5, -2, 26}, {8560, 1, -2, 26}, {8560, 0, 1, 29}// 13	14	15	
			, {1476, 3, -2, 23}, {4556, 1, -2, 7}, {1474, 4, -3, 26}// 16	17	18	
			, {1475, 5, -3, 26}, {4554, 5, 4, 0}, {632, 0, 3, 27}// 19	20	21	
			, {8565, -2, -1, 29}, {632, 0, 3, 27}, {6428, -4, -1, 7}// 22	23	24	
			, {1475, 5, 0, 27}, {8560, 0, -2, 28}, {1476, -5, 1, 20}// 25	26	27	
			, {8560, 0, -1, 29}, {1474, -1, 0, 32}, {1475, 1, 1, 26}// 28	29	30	
			, {1476, 3, -3, 23}, {1476, 3, 3, 23}, {6428, -1, -1, 7}// 31	32	33	
			, {1474, -1, -3, 32}, {3926, 3, 4, 5}, {1476, -4, -2, 23}// 34	35	36	
			, {2799, -3, 1, 7}, {1882, -1, 4, 0}, {6430, -3, 0, 7}// 37	38	39	
			, {6430, -2, 0, 7}, {6419, -1, 0, 7}, {1236, -2, 1, 7}// 40	41	42	
			, {6418, -4, 0, 7}, {2603, -1, 1, 7}, {2603, -2, 1, 7}// 43	44	45	
			, {2603, -3, 1, 7}, {2603, -4, 1, 7}, {2876, 5, -1, 7}// 46	47	48	
			, {2876, 3, -1, 7}, {2895, 5, -2, 7}, {2895, 3, -2, 7}// 49	50	51	
			, {2896, 5, 0, 7}, {2896, 3, 0, 7}, {2464, -3, 0, 15}// 52	53	54	
			, {2464, -2, 0, 15}, {2542, -4, 0, 14}, {2542, -4, -1, 14}// 55	56	57	
			, {2542, 3, -1, 13}, {2542, 5, -1, 13}, {4091, 3, -1, 13}// 58	59	60	
			, {4091, -1, 0, 15}, {4091, -1, -1, 15}, {4091, -4, -1, 15}// 61	62	63	
			, {2797, 1, 3, 8}, {2797, 1, 2, 8}, {2802, -3, 3, 7}// 64	65	66	
			, {2797, -2, 2, 7}, {2797, -2, 2, 7}, {1474, -1, 3, 32}// 67	68	69	
			, {2797, 1, -1, 8}, {2797, 1, -2, 8}, {99, -1, 3, 0}// 70	73	74	
			, {99, 0, 3, 0}, {100, 2, -2, 0}, {100, 2, 3, 0}// 75	76	77	
			, {1236, 0, 0, 7}, {1238, 0, 3, 7}, {1238, 2, -2, 7}// 78	79	80	
			, {1237, 2, 3, 7}, {1239, 4, -1, 7}, {28, -4, 3, 7}// 81	82	83	
			, {2603, 0, 0, 8}, {1236, 3, 1, 7}, {2797, -4, 3, 7}// 84	85	86	
			, {28, 2, 3, 7}, {1236, 0, 2, 7}, {99, -2, 3, 0}// 87	88	90	
			, {99, -3, 3, 0}, {99, 1, 3, 0}, {99, 2, 3, 0}// 91	92	93	
			, {99, 3, 3, 0}, {99, 4, 3, 0}, {99, 5, 3, 0}// 94	95	96	
			, {1873, -2, 4, 0}, {1873, 4, 4, 0}, {100, 2, -1, 0}// 97	98	99	
			, {100, 2, 0, 0}, {100, 2, 1, 0}, {100, 2, 2, 0}// 100	101	102	
			, {1239, -3, -2, 7}, {1237, -3, -1, 7}, {1239, -3, 0, 7}// 103	104	105	
			, {1236, -3, 3, 7}, {1236, -3, 1, 7}, {1237, -3, 3, 7}// 106	107	108	
			, {1236, -2, -2, 7}, {1237, -2, -1, 7}, {1236, -2, 0, 7}// 109	110	111	
			, {1237, -3, 2, 7}, {1236, -2, 2, 7}, {1237, -1, -2, 7}// 112	113	114	
			, {1237, -1, -1, 7}, {1237, -1, 0, 7}, {1237, -1, 1, 7}// 115	116	117	
			, {1236, -1, 2, 7}, {1237, -1, 3, 7}, {1239, 0, -2, 7}// 118	119	120	
			, {1236, 0, -1, 7}, {1239, 0, 1, 7}, {1239, 1, -2, 7}// 121	122	123	
			, {1236, 1, -1, 7}, {1238, 1, 2, 7}, {1238, 1, 3, 7}// 124	125	126	
			, {631, -1, 3, 27}, {2802, -3, 2, 7}, {8565, -4, -1, 30}// 127	128	129	
			, {8565, -4, -2, 30}, {1239, 2, -1, 7}, {1238, 2, 0, 7}// 130	131	132	
			, {1236, 2, 1, 7}, {1239, 2, 2, 7}, {2804, 2, 2, 8}// 133	134	135	
			, {1237, 3, 3, 7}, {1236, 3, -1, 7}, {1236, 3, -2, 7}// 136	137	138	
			, {1238, 4, -2, 7}, {1236, 3, 0, 7}, {1239, 3, 2, 7}// 139	140	141	
			, {1236, 5, -1, 7}, {1239, 5, 0, 7}, {1236, 5, 1, 7}// 142	143	144	
			, {1239, 4, 2, 7}, {1237, 5, 3, 7}, {2802, 0, -2, 8}// 145	146	147	
			, {1237, 5, -2, 7}, {1237, 4, 0, 7}, {1236, 4, 1, 7}// 148	149	150	
			, {1239, 5, 2, 7}, {1236, 4, 3, 7}, {27, 2, -2, 7}// 151	152	153	
			, {31, 2, 3, 7}, {32, 2, 1, 7}, {27, 2, 0, 7}// 154	155	156	
			, {99, 5, -3, 0}, {99, -3, -3, 0}, {99, -2, -3, 0}// 159	160	161	
			, {99, -1, -3, 0}, {99, 0, -3, 0}, {99, 1, -3, 0}// 162	163	164	
			, {99, 2, -3, 0}, {99, 3, -3, 0}, {99, 4, -3, 0}// 165	166	167	
			, {28, -3, -3, 7}, {28, -1, -3, 7}, {28, 0, -3, 7}// 168	169	170	
			, {28, 2, -3, 7}, {635, -4, 3, 23}, {1883, -3, 4, 0}// 171	174	175	
			, {2797, 2, -2, 7}, {100, -5, 2, 0}, {99, -4, 3, 0}// 176	177	178	
			, {33, -3, 3, 7}, {4555, 3, 3, 15}, {100, -5, -2, 0}// 179	180	181	
			, {100, -5, -1, 0}, {100, -5, 0, 0}, {100, -5, 1, 0}// 182	183	184	
			, {100, -5, 3, 0}, {632, 1, 3, 25}, {1239, -4, -2, 7}// 185	186	187	
			, {1238, -4, -1, 7}, {1237, -4, 0, 7}, {1238, -4, 1, 7}// 188	189	190	
			, {1238, -4, 2, 7}, {1237, -4, 3, 7}, {27, -5, -1, 7}// 191	192	193	
			, {27, -5, 0, 7}, {27, -5, 2, 7}, {27, -5, 3, 7}// 194	195	196	
			, {102, -5, -3, 0}, {99, -4, -3, 0}, {28, -4, -3, 7}// 199	200	201	
			, {29, -5, -3, 7}, {631, 3, 3, 7}, {1475, 2, 2, 23}// 202	203	204	
			, {1475, 2, 1, 23}, {1475, 2, 3, 23}, {1476, -3, -1, 26}// 205	206	207	
			, {1476, -3, 1, 26}, {1476, -4, 3, 23}, {1475, 2, 0, 23}// 208	209	210	
			, {1475, 2, -2, 23}, {1475, 2, -1, 23}, {1474, -1, 3, 32}// 211	212	213	
			, {1474, -1, 2, 32}, {1476, 4, 1, 26}, {8560, 1, 2, 26}// 214	215	216	
			, {8565, -2, 2, 29}, {8565, -2, 1, 29}, {8565, -2, -2, 29}// 217	218	219	
			, {2804, 2, -2, 8}, {2804, 2, -1, 8}, {2804, 2, 0, 8}// 220	221	222	
			, {2804, 2, 1, 8}, {2802, 0, 1, 8}, {1474, 4, 3, 26}// 223	224	225	
			, {1474, -1, -1, 32}, {8565, -2, -3, 29}, {635, -3, 3, 27}// 226	227	228	
			, {635, 5, -3, 5}, {635, 5, 3, 7}, {1474, 5, 1, 26}// 229	230	232	
			, {2804, 2, 3, 8}, {1475, 1, 0, 26}, {1476, -4, -3, 23}// 233	234	235	
			, {1474, 4, -2, 26}, {1476, -3, 0, 26}, {1476, -5, 2, 20}// 236	237	238	
			, {2801, -1, 1, 7}, {2803, -2, 1, 7}, {1475, 0, 0, 29}// 239	240	241	
			, {1475, 1, -1, 26}, {1475, 2, -3, 23}, {6414, -2, -3, 7}// 242	243	244	
			, {2804, -1, 3, 7}, {1476, 3, 2, 23}, {2972, -3, 4, 5}// 245	246	247	
			, {2804, -1, 2, 7}, {1476, -4, -1, 23}, {1476, -2, 0, 29}// 248	249	250	
			, {2796, 1, 1, 8}, {8565, -3, 3, 27}, {8565, -3, 2, 26}// 251	252	253	
			, {3926, 5, 4, 5}, {6871, -4, -2, 7}, {2802, 0, 0, 8}// 254	255	256	
			, {8560, 0, -3, 29}, {1476, -4, 1, 23}, {1476, -4, 2, 23}// 257	258	259	
			, {1476, -4, 0, 23}, {2802, 0, -1, 8}, {1475, 5, -1, 26}// 260	261	262	
			, {1476, 4, -1, 26}, {1476, 3, -1, 23}, {1475, 5, 2, 26}// 263	264	265	
			, {8565, -3, -3, 26}, {1475, 5, 1, 26}, {8565, -2, 3, 30}// 266	267	268	
			, {1474, -1, 1, 32}, {8565, -3, -2, 26}, {8565, 3, 0, 23}// 269	270	271	
			, {1476, 3, 1, 23}, {1474, 4, 0, 27}, {1474, -1, -3, 32}// 272	273	274	
			, {1474, -1, -2, 32}, {1476, -5, 0, 20}, {1476, -5, 3, 20}// 275	276	277	
			, {1476, -5, -1, 20}, {1237, -2, 3, 7}, {2797, -2, 3, 7}// 278	279	280	
			, {28, 0, 3, 7}, {30, -1, 3, 7}, {1475, 6, 2, 23}// 281	282	283	
			, {1475, 6, 1, 23}, {2149, 6, -3, 17}, {2149, 6, 0, 19}// 284	285	286	
			, {2149, 6, -3, 11}, {1475, 6, -3, 23}, {4099, 6, -2, 7}// 287	288	289	
			, {100, 6, -2, 0}, {99, 6, 3, 0}, {100, 6, -1, 0}// 290	291	292	
			, {100, 6, 0, 0}, {100, 6, 1, 0}, {100, 6, 2, 0}// 293	294	295	
			, {100, 6, 3, 0}, {1239, 6, 3, 7}, {1236, 6, 2, 7}// 296	297	298	
			, {1239, 6, 0, 7}, {1236, 6, 1, 7}, {1239, 6, -2, 7}// 299	300	301	
			, {1237, 6, -1, 7}, {99, 6, -3, 0}, {636, 6, -2, 7}// 302	303	304	
			, {2149, 6, 3, 19}, {2149, 6, 3, 13}, {636, 6, 0, 7}// 305	306	307	
			, {636, 6, -1, 7}, {631, 6, -3, 5}, {636, 6, 3, 7}// 308	309	310	
			, {636, 6, 2, 7}, {2149, 6, 0, 13}, {1475, 6, -1, 23}// 311	312	313	
			, {1475, 6, -2, 23}, {631, 6, 3, 7}, {1475, 6, 3, 23}// 314	315	316	
			, {1475, 6, 0, 24}, {636, 6, 1, 7}// 317	318	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new FieldsStoneCityTavernNEWAddonDeed();
			}
		}

		[ Constructable ]
		public FieldsStoneCityTavernNEWAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 2854, -4, 2, 7, 0, 0, "", 1);// 71
			AddComplexComponent( (BaseAddon) this, 2854, 0, -2, 7, 0, 0, "", 1);// 72
			AddComplexComponent( (BaseAddon) this, 5168, 5, -1, 14, 0, 0, "", 1);// 89
			AddComplexComponent( (BaseAddon) this, 10672, 1, 3, 7, 0, 0, "", 1);// 157
			AddComplexComponent( (BaseAddon) this, 10677, 2, -1, 7, 0, 0, "", 1);// 158
			AddComplexComponent( (BaseAddon) this, 10672, -2, -3, 7, 0, 0, "", 1);// 172
			AddComplexComponent( (BaseAddon) this, 10672, 1, -3, 7, 0, 0, "", 1);// 173
			AddComplexComponent( (BaseAddon) this, 10677, -5, 1, 7, 0, 0, "", 1);// 197
			AddComplexComponent( (BaseAddon) this, 10677, -5, -2, 7, 0, 0, "", 1);// 198
			AddComplexComponent( (BaseAddon) this, 3012, -3, 4, 5, 0, -1, "Ivy's Tavern", 1);// 231

		}

		public FieldsStoneCityTavernNEWAddon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
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

	public class FieldsStoneCityTavernNEWAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new FieldsStoneCityTavernNEWAddon();
			}
		}

		[Constructable]
		public FieldsStoneCityTavernNEWAddonDeed()
		{
			Name = "FieldsStoneCityTavernNEW";
		}

		public FieldsStoneCityTavernNEWAddonDeed( Serial serial ) : base( serial )
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