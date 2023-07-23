
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
	public class MarbleCityTavernNEWAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2603, -1, -3, 7}, {698, -1, -4, 27}, {698, -2, -4, 27}// 1	2	3	
			, {699, -3, 1, 27}, {699, -3, 0, 27}, {699, -3, -1, 27}// 4	5	6	
			, {699, -3, -2, 27}, {699, -3, -3, 27}, {700, -3, -4, 27}// 7	8	9	
			, {1173, -1, 1, 27}, {1173, -1, 0, 27}, {1173, -1, -1, 27}// 10	11	12	
			, {1173, -1, -2, 27}, {1173, -1, -3, 27}, {1173, -2, 1, 27}// 13	14	15	
			, {1173, -2, 0, 27}, {1173, -2, -1, 27}, {1173, -2, -2, 27}// 16	17	18	
			, {1173, -2, -3, 27}, {660, -3, -4, 7}, {658, -2, -4, 7}// 19	20	21	
			, {658, -1, -4, 7}, {659, -3, -1, 7}, {659, -3, 1, 7}// 22	23	24	
			, {659, -3, -2, 7}, {99, -1, -4, 0}, {1173, -2, -3, 7}// 25	28	29	
			, {1175, -2, -2, 7}, {1174, -2, -1, 7}, {1176, -2, 0, 7}// 30	31	32	
			, {1173, -1, -3, 7}, {1173, -2, 1, 7}, {1176, -1, -2, 7}// 33	34	35	
			, {1175, -1, -1, 7}, {1175, -1, 0, 7}, {99, -2, -4, 0}// 36	37	38	
			, {100, -3, -3, 0}, {100, -3, -2, 0}, {100, -3, -1, 0}// 40	41	42	
			, {100, -3, 0, 0}, {100, -3, 1, 0}, {2603, -1, -2, 7}// 43	44	45	
			, {1176, -1, 1, 7}, {3749, -3, 1, 7}, {3784, -2, -1, 7}// 46	47	48	
			, {2603, -1, -1, 7}, {4099, -1, -3, 7}, {2603, -1, -1, 7}// 49	50	51	
			, {2603, -1, 1, 7}, {2603, -1, 0, 7}, {2603, -1, 1, 7}// 52	53	54	
			, {1883, -2, 4, 0}, {1173, -2, 2, 27}, {1173, -2, 3, 27}// 65	67	68	
			, {1173, -1, 2, 27}, {1173, -1, 3, 27}, {659, -3, 2, 7}// 69	70	71	
			, {658, -2, 3, 7}, {100, -3, 2, 0}, {100, -3, 3, 0}// 72	74	75	
			, {99, -2, 3, 0}, {1174, -2, 2, 7}, {1174, -1, 2, 7}// 76	77	78	
			, {698, -1, 3, 27}, {698, -2, 3, 27}, {699, -3, 3, 27}// 79	80	81	
			, {699, -3, 2, 27}, {1176, -2, 3, 7}, {99, -1, 3, 0}// 82	83	84	
			, {690, -1, 3, 7}, {1873, -1, 4, 0}, {2603, 1, 1, 7}// 87	88	91	
			, {699, 4, -2, 27}, {699, 3, -3, 27}, {2445, 2, -3, 12}// 92	93	94	
			, {659, 3, 0, 7}, {698, 3, -4, 27}, {698, 2, -4, 27}// 95	97	98	
			, {698, 1, -4, 27}, {698, 0, -4, 27}, {1173, 3, 1, 27}// 99	100	101	
			, {1173, 3, 0, 27}, {1173, 3, -1, 27}, {1173, 3, -2, 27}// 102	103	104	
			, {1173, 3, -3, 27}, {1173, 2, 1, 27}, {1173, 2, 0, 27}// 105	106	107	
			, {1173, 2, -1, 27}, {1173, 2, -2, 27}, {1173, 2, -3, 27}// 108	109	110	
			, {1173, 1, 1, 27}, {1173, 1, 0, 27}, {1173, 1, -1, 27}// 111	112	113	
			, {1173, 1, -2, 27}, {1173, 1, -3, 27}, {1173, 0, 1, 27}// 114	115	116	
			, {1173, 0, -1, 27}, {1173, 0, -2, 27}, {1173, 0, -3, 27}// 117	118	119	
			, {6870, 1, -3, 7}, {658, 1, -4, 7}, {658, 2, -4, 7}// 120	121	122	
			, {99, 1, -4, 0}, {99, 2, -4, 0}, {1176, 2, -2, 7}// 125	126	127	
			, {2466, 2, -3, 20}, {2500, 2, -3, 8}, {100, 3, -3, 0}// 128	129	130	
			, {100, 3, -2, 0}, {100, 3, -1, 0}, {100, 3, 0, 0}// 131	132	133	
			, {100, 3, 1, 0}, {1176, 2, 0, 7}, {1174, 3, -3, 7}// 134	135	136	
			, {1174, 3, -2, 7}, {1174, 3, -1, 7}, {1175, 0, -3, 7}// 137	138	139	
			, {1176, 0, -2, 7}, {1176, 0, -1, 7}, {1173, 1, -3, 7}// 140	141	142	
			, {1173, 1, -2, 7}, {1173, 1, -1, 7}, {1174, 0, 0, 7}// 143	144	145	
			, {1175, 2, -3, 7}, {1176, 1, 0, 7}, {1175, 2, -1, 7}// 146	147	148	
			, {99, 3, -4, 0}, {99, 0, -4, 0}, {8078, 2, 1, 15}// 149	150	151	
			, {6870, 1, -3, 13}, {2462, 2, -3, 24}, {2603, 1, -1, 7}// 152	153	154	
			, {1174, 3, 1, 7}, {1176, 2, 1, 7}, {1175, 1, 1, 7}// 156	157	158	
			, {1176, 0, 1, 7}, {6418, 0, 1, 7}, {6424, 0, 0, 7}// 159	160	161	
			, {6430, 1, 1, 7}, {6424, 0, -1, 7}, {6430, 2, 1, 7}// 162	163	164	
			, {1173, 3, 0, 7}, {6424, 0, -3, 7}, {6424, 0, -2, 7}// 165	166	167	
			, {6870, 1, -3, 15}, {2919, 2, -3, 7}, {2919, 2, -3, 15}// 168	169	170	
			, {2919, 2, -3, 11}, {2919, 2, -3, 19}, {2919, 2, -3, 23}// 171	172	173	
			, {2462, 2, -3, 16}, {8088, 0, -2, 15}, {2542, 0, -3, 15}// 174	175	176	
			, {8078, 0, -1, 15}, {2463, 0, 1, 15}, {8069, 0, 0, 15}// 177	178	179	
			, {8078, 1, 1, 15}, {699, 3, 1, 27}, {9942, 4, -2, 7}// 180	186	187	
			, {699, 3, 0, 27}, {1173, 0, 0, 27}, {658, 4, -3, 7}// 188	190	191	
			, {100, 4, -2, 0}, {100, 4, -1, 0}, {99, 4, -3, 0}// 192	193	194	
			, {658, 4, -1, 7}, {697, 4, -1, 27}, {698, 4, -3, 27}// 195	196	197	
			, {659, 4, -1, 7}, {99, 4, -1, 0}, {1173, 4, -1, 27}// 198	199	200	
			, {1173, 4, -2, 27}, {1173, 4, -1, 7}, {1173, 4, -2, 7}// 201	202	203	
			, {696, 3, -1, 27}, {699, 3, 2, 27}, {697, 3, 3, 27}// 204	205	206	
			, {659, 3, 3, 7}, {100, 3, 2, 0}, {100, 3, 3, 0}// 207	208	209	
			, {1882, 1, 4, 0}, {1173, 0, 2, 27}, {1173, 0, 3, 27}// 210	211	212	
			, {1173, 1, 2, 27}, {1173, 1, 3, 27}, {1173, 2, 2, 27}// 213	214	215	
			, {1173, 2, 3, 27}, {1173, 3, 2, 27}, {1173, 3, 3, 27}// 216	217	218	
			, {658, 3, 3, 7}, {2603, 0, 2, 7}, {2603, 2, 2, 7}// 219	221	222	
			, {99, 0, 3, 0}, {99, 1, 3, 0}, {99, 2, 3, 0}// 223	224	225	
			, {99, 3, 3, 0}, {1175, 0, 2, 7}, {1175, 1, 2, 7}// 226	227	228	
			, {1174, 3, 2, 7}, {1175, 2, 2, 7}, {698, 2, 3, 27}// 229	230	231	
			, {698, 1, 3, 27}, {698, 0, 3, 27}, {1873, 0, 4, 0}// 232	233	234	
			, {2603, 1, 2, 7}, {689, 1, 3, 7}// 235	241	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new MarbleCityTavernNEWAddonDeed();
			}
		}

		[ Constructable ]
		public MarbleCityTavernNEWAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 662, -3, 0, 7, 0, 0, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 662, -3, -3, 7, 0, 0, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 102, -3, -4, 0, 1175, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 18260, -1, 1, 7, 1473, -1, "", 1);// 55
			AddComplexComponent( (BaseAddon) this, 18260, -1, 0, 7, 1473, -1, "", 1);// 56
			AddComplexComponent( (BaseAddon) this, 18260, -1, -1, 7, 1473, -1, "", 1);// 57
			AddComplexComponent( (BaseAddon) this, 18260, -1, -2, 7, 1473, -1, "", 1);// 58
			AddComplexComponent( (BaseAddon) this, 18260, -1, -3, 7, 1473, -1, "", 1);// 59
			AddComplexComponent( (BaseAddon) this, 2806, -2, -3, 7, 1467, -1, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 2806, -2, -1, 7, 1467, -1, "", 1);// 61
			AddComplexComponent( (BaseAddon) this, 2806, -2, 0, 7, 1467, -1, "", 1);// 62
			AddComplexComponent( (BaseAddon) this, 2806, -2, 1, 7, 1467, -1, "", 1);// 63
			AddComplexComponent( (BaseAddon) this, 2806, -2, -2, 7, 1467, -1, "", 1);// 64
			AddComplexComponent( (BaseAddon) this, 2976, -2, 4, 5, 2958, -1, "", 1);// 66
			AddComplexComponent( (BaseAddon) this, 662, -3, 3, 7, 0, 0, "", 1);// 73
			AddComplexComponent( (BaseAddon) this, 18260, -1, 2, 7, 1473, -1, "", 1);// 85
			AddComplexComponent( (BaseAddon) this, 2806, -2, 2, 7, 1467, -1, "", 1);// 86
			AddComplexComponent( (BaseAddon) this, 18260, -1, 3, 7, 1473, -1, "", 1);// 89
			AddComplexComponent( (BaseAddon) this, 2806, -2, 3, 7, 1467, -1, "", 1);// 90
			AddComplexComponent( (BaseAddon) this, 662, 3, -3, 7, 0, 0, "", 1);// 96
			AddComplexComponent( (BaseAddon) this, 661, 0, -4, 7, 0, 0, "", 1);// 123
			AddComplexComponent( (BaseAddon) this, 661, 3, -4, 7, 0, 0, "", 1);// 124
			AddComplexComponent( (BaseAddon) this, 5172, 0, 0, 15, 0, 0, "", 1);// 155
			AddComplexComponent( (BaseAddon) this, 5172, 2, -3, 24, 0, 0, "", 1);// 181
			AddComplexComponent( (BaseAddon) this, 18260, 3, 1, 7, 1471, -1, "", 1);// 182
			AddComplexComponent( (BaseAddon) this, 18260, 2, 1, 7, 1471, -1, "", 1);// 183
			AddComplexComponent( (BaseAddon) this, 18260, 1, 1, 7, 1471, -1, "", 1);// 184
			AddComplexComponent( (BaseAddon) this, 18260, 0, 1, 7, 1471, -1, "", 1);// 185
			AddComplexComponent( (BaseAddon) this, 9941, 3, 1, 7, 0, 1, "", 1);// 189
			AddComplexComponent( (BaseAddon) this, 661, 2, 3, 7, 0, 0, "", 1);// 220
			AddComplexComponent( (BaseAddon) this, 18260, 0, 2, 7, 1473, -1, "", 1);// 236
			AddComplexComponent( (BaseAddon) this, 18260, 1, 2, 7, 1473, -1, "", 1);// 237
			AddComplexComponent( (BaseAddon) this, 18260, 2, 2, 7, 1473, -1, "", 1);// 238
			AddComplexComponent( (BaseAddon) this, 18260, 3, 2, 7, 1473, -1, "", 1);// 239
			AddComplexComponent( (BaseAddon) this, 662, 3, 2, 7, 0, 0, "", 1);// 240
			AddComplexComponent( (BaseAddon) this, 18260, 0, 3, 7, 1473, -1, "", 1);// 242
			AddComplexComponent( (BaseAddon) this, 18260, 1, 3, 7, 1473, -1, "", 1);// 243
			AddComplexComponent( (BaseAddon) this, 18260, 2, 3, 7, 1473, -1, "", 1);// 244
			AddComplexComponent( (BaseAddon) this, 18260, 3, 3, 7, 1473, -1, "", 1);// 245

		}

		public MarbleCityTavernNEWAddon( Serial serial ) : base( serial )
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

	public class MarbleCityTavernNEWAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new MarbleCityTavernNEWAddon();
			}
		}

		[Constructable]
		public MarbleCityTavernNEWAddonDeed()
		{
			Name = "MarbleCityTavernNEW";
		}

		public MarbleCityTavernNEWAddonDeed( Serial serial ) : base( serial )
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