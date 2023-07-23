
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
	public class FieldStoneCityTavernNEWAddon : BaseAddon
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
			, {1882, -1, 4, 0}, {6430, -3, 0, 7}, {6430, -2, 0, 7}// 37	38	39	
			, {6419, -1, 0, 7}, {1236, -2, 1, 7}, {6418, -4, 0, 7}// 40	41	42	
			, {2603, -1, 1, 7}, {2603, -2, 1, 7}, {2603, -3, 1, 7}// 43	44	45	
			, {2603, -4, 1, 7}, {2876, 5, -1, 7}, {2876, 3, -1, 7}// 46	47	48	
			, {2895, 5, -2, 7}, {2895, 3, -2, 7}, {2896, 5, 0, 7}// 49	50	51	
			, {2896, 3, 0, 7}, {2464, -3, 0, 15}, {2464, -2, 0, 15}// 52	53	54	
			, {2542, -4, 0, 14}, {2542, -4, -1, 14}, {2542, 3, -1, 13}// 55	56	57	
			, {2542, 5, -1, 13}, {4091, 3, -1, 13}, {4091, -1, 0, 15}// 58	59	60	
			, {4091, -1, -1, 15}, {4091, -4, -1, 15}, {2797, 1, 3, 8}// 61	62	63	
			, {2797, 1, 2, 8}, {1474, -1, 3, 32}, {2797, 1, -1, 8}// 64	65	66	
			, {2797, 1, -2, 8}, {99, -1, 3, 0}, {99, 0, 3, 0}// 69	70	71	
			, {100, 2, -2, 0}, {100, 2, 3, 0}, {1236, 0, 0, 7}// 72	73	74	
			, {1238, 0, 3, 7}, {1238, 2, -2, 7}, {1237, 2, 3, 7}// 75	76	77	
			, {1239, 4, -1, 7}, {28, -4, 3, 7}, {2603, 0, 0, 8}// 78	79	80	
			, {1236, 3, 1, 7}, {2797, -4, 3, 7}, {28, 2, 3, 7}// 81	82	83	
			, {1236, 0, 2, 7}, {99, -2, 3, 0}, {99, -3, 3, 0}// 84	86	87	
			, {99, 1, 3, 0}, {99, 2, 3, 0}, {99, 3, 3, 0}// 88	89	90	
			, {99, 4, 3, 0}, {99, 5, 3, 0}, {1873, -2, 4, 0}// 91	92	93	
			, {1873, 4, 4, 0}, {100, 2, -1, 0}, {100, 2, 0, 0}// 94	95	96	
			, {100, 2, 1, 0}, {100, 2, 2, 0}, {1239, -3, -2, 7}// 97	98	99	
			, {1237, -3, -1, 7}, {1239, -3, 0, 7}, {1236, -2, -2, 7}// 100	101	102	
			, {1237, -2, -1, 7}, {1236, -2, 0, 7}, {1237, -3, 2, 7}// 103	104	105	
			, {1236, -2, 2, 7}, {1237, -1, -2, 7}, {1237, -1, -1, 7}// 106	107	108	
			, {1237, -1, 0, 7}, {1237, -1, 1, 7}, {1236, -1, 2, 7}// 109	110	111	
			, {1237, -1, 3, 7}, {1239, 0, -2, 7}, {1236, 0, -1, 7}// 112	113	114	
			, {1239, 0, 1, 7}, {1239, 1, -2, 7}, {1236, 1, -1, 7}// 115	116	117	
			, {1238, 1, 2, 7}, {1238, 1, 3, 7}, {631, -1, 3, 27}// 118	119	120	
			, {8565, -4, -1, 30}, {8565, -4, -2, 30}, {1239, 2, -1, 7}// 121	122	123	
			, {1238, 2, 0, 7}, {1236, 2, 1, 7}, {1239, 2, 2, 7}// 124	125	126	
			, {2804, 2, 2, 8}, {1237, 3, 3, 7}, {1236, 3, -1, 7}// 127	128	129	
			, {1236, 3, -2, 7}, {1238, 4, -2, 7}, {1236, 3, 0, 7}// 130	131	132	
			, {1239, 3, 2, 7}, {1236, 5, -1, 7}, {1239, 5, 0, 7}// 133	134	135	
			, {1236, 5, 1, 7}, {1239, 4, 2, 7}, {1237, 5, 3, 7}// 136	137	138	
			, {2802, 0, -2, 8}, {1237, 5, -2, 7}, {1237, 4, 0, 7}// 139	140	141	
			, {1236, 4, 1, 7}, {1239, 5, 2, 7}, {1236, 4, 3, 7}// 142	143	144	
			, {27, 2, -2, 7}, {31, 2, 3, 7}, {32, 2, 1, 7}// 145	146	147	
			, {27, 2, 0, 7}, {99, 5, -3, 0}, {99, -3, -3, 0}// 148	151	152	
			, {99, -2, -3, 0}, {99, -1, -3, 0}, {99, 0, -3, 0}// 153	154	155	
			, {99, 1, -3, 0}, {99, 2, -3, 0}, {99, 3, -3, 0}// 156	157	158	
			, {99, 4, -3, 0}, {28, -3, -3, 7}, {28, -1, -3, 7}// 159	160	161	
			, {28, 0, -3, 7}, {28, 2, -3, 7}, {635, -4, 3, 23}// 162	163	166	
			, {1883, -3, 4, 0}, {2797, 2, -2, 7}, {100, -5, 2, 0}// 167	168	169	
			, {99, -4, 3, 0}, {33, -3, 3, 7}, {4555, 3, 3, 15}// 170	171	172	
			, {100, -5, -2, 0}, {100, -5, -1, 0}, {100, -5, 0, 0}// 173	174	175	
			, {100, -5, 1, 0}, {100, -5, 3, 0}, {632, 1, 3, 25}// 176	177	178	
			, {1239, -4, -2, 7}, {1238, -4, -1, 7}, {1237, -4, 0, 7}// 179	180	181	
			, {1238, -4, 1, 7}, {1238, -4, 2, 7}, {1237, -4, 3, 7}// 182	183	184	
			, {27, -5, -1, 7}, {27, -5, 0, 7}, {27, -5, 2, 7}// 185	186	187	
			, {27, -5, 3, 7}, {102, -5, -3, 0}, {99, -4, -3, 0}// 188	191	192	
			, {28, -4, -3, 7}, {29, -5, -3, 7}, {631, 3, 3, 7}// 193	194	195	
			, {1475, 2, 2, 23}, {1475, 2, 1, 23}, {1475, 2, 3, 23}// 196	197	198	
			, {1476, -3, -1, 26}, {1476, -3, 1, 26}, {1476, -4, 3, 23}// 199	200	201	
			, {1475, 2, 0, 23}, {1475, 2, -2, 23}, {1475, 2, -1, 23}// 202	203	204	
			, {1474, -1, 3, 32}, {1474, -1, 2, 32}, {1476, 4, 1, 26}// 205	206	207	
			, {8560, 1, 2, 26}, {8565, -2, 2, 29}, {8565, -2, 1, 29}// 208	209	210	
			, {8565, -2, -2, 29}, {2804, 2, -2, 8}, {2804, 2, -1, 8}// 211	212	213	
			, {2804, 2, 0, 8}, {2804, 2, 1, 8}, {2802, 0, 1, 8}// 214	215	216	
			, {1474, 4, 3, 26}, {1474, -1, -1, 32}, {8565, -2, -3, 29}// 217	218	219	
			, {635, -3, 3, 27}, {635, 5, -3, 5}, {635, 5, 3, 7}// 220	221	222	
			, {1474, 5, 1, 26}, {2804, 2, 3, 8}, {1475, 1, 0, 26}// 224	225	226	
			, {1476, -4, -3, 23}, {1474, 4, -2, 26}, {1476, -3, 0, 26}// 227	228	229	
			, {1476, -5, 2, 20}, {1475, 0, 0, 29}, {1475, 1, -1, 26}// 230	231	232	
			, {1475, 2, -3, 23}, {6414, -2, -3, 7}, {1476, 3, 2, 23}// 233	234	235	
			, {2972, -3, 4, 5}, {1476, -4, -1, 23}, {1476, -2, 0, 29}// 236	237	238	
			, {2796, 1, 1, 8}, {8565, -3, 3, 27}, {8565, -3, 2, 26}// 239	240	241	
			, {3926, 5, 4, 5}, {6871, -4, -2, 7}, {2802, 0, 0, 8}// 242	243	244	
			, {8560, 0, -3, 29}, {1476, -4, 1, 23}, {1476, -4, 2, 23}// 245	246	247	
			, {1476, -4, 0, 23}, {2802, 0, -1, 8}, {1475, 5, -1, 26}// 248	249	250	
			, {1476, 4, -1, 26}, {1476, 3, -1, 23}, {1475, 5, 2, 26}// 251	252	253	
			, {8565, -3, -3, 26}, {1475, 5, 1, 26}, {8565, -2, 3, 30}// 254	255	256	
			, {1474, -1, 1, 32}, {8565, -3, -2, 26}, {8565, 3, 0, 23}// 257	258	259	
			, {1476, 3, 1, 23}, {1474, 4, 0, 27}, {1474, -1, -3, 32}// 260	261	262	
			, {1474, -1, -2, 32}, {1476, -5, 0, 20}, {1476, -5, 3, 20}// 263	264	265	
			, {1476, -5, -1, 20}, {1237, -2, 3, 7}, {28, 0, 3, 7}// 266	267	268	
			, {30, -1, 3, 7}, {1238, -3, 3, 7}, {1238, -3, 1, 7}// 269	270	271	
			, {1475, 6, 2, 23}, {1475, 6, 1, 23}, {2149, 6, -3, 17}// 272	273	274	
			, {2149, 6, 0, 19}, {2149, 6, -3, 11}, {1475, 6, -3, 23}// 275	276	277	
			, {4099, 6, -2, 7}, {100, 6, -2, 0}, {99, 6, 3, 0}// 278	279	280	
			, {100, 6, -1, 0}, {100, 6, 0, 0}, {100, 6, 1, 0}// 281	282	283	
			, {100, 6, 2, 0}, {100, 6, 3, 0}, {1239, 6, 3, 7}// 284	285	286	
			, {1236, 6, 2, 7}, {1239, 6, 0, 7}, {1236, 6, 1, 7}// 287	288	289	
			, {1239, 6, -2, 7}, {1237, 6, -1, 7}, {99, 6, -3, 0}// 290	291	292	
			, {636, 6, -2, 7}, {2149, 6, 3, 19}, {2149, 6, 3, 13}// 293	294	295	
			, {636, 6, 0, 7}, {636, 6, -1, 7}, {631, 6, -3, 5}// 296	297	298	
			, {636, 6, 3, 7}, {636, 6, 2, 7}, {2149, 6, 0, 13}// 299	300	301	
			, {1475, 6, -1, 23}, {1475, 6, -2, 23}, {631, 6, 3, 7}// 302	303	304	
			, {1475, 6, 3, 23}, {1475, 6, 0, 24}, {636, 6, 1, 7}// 305	306	307	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new FieldStoneCityTavernNEWAddonDeed();
			}
		}

		[ Constructable ]
		public FieldStoneCityTavernNEWAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 2854, -4, 2, 7, 0, 0, "", 1);// 67
			AddComplexComponent( (BaseAddon) this, 2854, 0, -2, 7, 0, 0, "", 1);// 68
			AddComplexComponent( (BaseAddon) this, 5168, 5, -1, 14, 0, 0, "", 1);// 85
			AddComplexComponent( (BaseAddon) this, 10672, 1, 3, 7, 0, 0, "", 1);// 149
			AddComplexComponent( (BaseAddon) this, 10677, 2, -1, 7, 0, 0, "", 1);// 150
			AddComplexComponent( (BaseAddon) this, 10672, -2, -3, 7, 0, 0, "", 1);// 164
			AddComplexComponent( (BaseAddon) this, 10672, 1, -3, 7, 0, 0, "", 1);// 165
			AddComplexComponent( (BaseAddon) this, 10677, -5, 1, 7, 0, 0, "", 1);// 189
			AddComplexComponent( (BaseAddon) this, 10677, -5, -2, 7, 0, 0, "", 1);// 190
			AddComplexComponent( (BaseAddon) this, 3012, -3, 4, 5, 0, -1, "Ivy's Tavern", 1);// 223

		}

		public FieldStoneCityTavernNEWAddon( Serial serial ) : base( serial )
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

	public class FieldStoneCityTavernNEWAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new FieldStoneCityTavernNEWAddon();
			}
		}

		[Constructable]
		public FieldStoneCityTavernNEWAddonDeed()
		{
			Name = "FieldStoneCityTavernNEW";
		}

		public FieldStoneCityTavernNEWAddonDeed( Serial serial ) : base( serial )
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