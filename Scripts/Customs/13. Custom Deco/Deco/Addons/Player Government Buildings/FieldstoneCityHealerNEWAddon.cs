
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
	public class FieldstoneCityHealerNEWAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {102, -3, -3, 0}, {100, -3, -2, 0}, {100, -3, -1, 0}// 1	2	3	
			, {99, -2, -3, 0}, {99, -1, -3, 0}, {99, 0, -3, 0}// 4	5	6	
			, {99, 1, -3, 0}, {99, 2, -3, 0}, {100, 2, -2, 0}// 7	8	9	
			, {100, 2, -1, 0}, {29, -3, -3, 7}, {28, -2, -3, 7}// 10	11	13	
			, {28, -1, -3, 7}, {28, 0, -3, 7}, {28, 1, -3, 7}// 14	15	16	
			, {28, 2, -3, 7}, {1238, -2, -2, 7}, {1239, -2, -1, 7}// 17	18	19	
			, {1239, -1, -2, 7}, {1236, -1, -1, 7}, {1239, 0, -2, 7}// 20	21	22	
			, {1237, 0, -1, 7}, {1236, 1, -2, 7}, {1239, 1, -1, 7}// 23	24	25	
			, {1237, 2, -2, 7}, {1236, 2, -1, 7}, {2659, -1, -2, 7}// 26	27	28	
			, {2652, -1, -1, 7}, {2659, 1, -2, 7}, {2652, 1, -1, 7}// 29	30	31	
			, {27, 2, -2, 7}, {27, -3, -2, 7}, {3618, -2, -1, 7}// 32	34	35	
			, {3619, -2, -1, 8}, {3617, -1, -1, 9}, {4651, -1, -1, 9}// 36	37	40	
			, {7371, -2, -2, 7}, {4089, -2, -2, 15}, {1476, -2, -2, 24}// 41	42	43	
			, {1476, -2, -1, 24}, {1475, 3, -2, 23}, {1475, 3, -1, 23}// 44	45	46	
			, {1474, 0, -2, 30}, {1474, 0, -1, 30}, {1474, 1, -2, 30}// 47	48	49	
			, {1474, 1, -1, 30}, {8565, -1, -2, 27}, {8565, -1, -1, 27}// 50	51	52	
			, {1475, 2, -2, 26}, {1475, 2, -1, 27}, {100, -3, 0, 0}// 53	54	55	
			, {100, 2, 0, 0}, {27, -3, 0, 7}, {1237, -2, 0, 7}// 56	57	58	
			, {1238, 0, 0, 7}, {1236, 1, 0, 7}, {1236, 2, 0, 7}// 59	60	61	
			, {27, 2, 0, 7}, {100, -3, 1, 0}, {100, -3, 2, 0}// 62	63	64	
			, {99, -2, 2, 0}, {99, -1, 2, 0}, {99, 0, 2, 0}// 65	66	67	
			, {99, 1, 2, 0}, {1880, -2, 3, 0}, {1873, -1, 3, 0}// 68	69	70	
			, {1873, 0, 3, 0}, {1878, 1, 3, 0}, {100, 2, 1, 0}// 71	72	73	
			, {100, 2, 2, 0}, {101, 2, 2, 0}, {27, -3, 1, 7}// 74	75	76	
			, {1238, -2, 2, 7}, {1237, -1, 1, 7}, {1239, -1, 2, 7}// 78	79	80	
			, {1236, 0, 1, 7}, {1239, 0, 2, 7}, {1236, 1, 1, 7}// 81	82	83	
			, {1239, 1, 2, 7}, {1238, 2, 1, 7}, {1238, 2, 2, 7}// 84	85	86	
			, {1239, -2, 1, 7}, {33, -1, 2, 7}, {30, 1, 2, 7}// 87	88	89	
			, {27, 2, 2, 7}, {7807, 1, 0, 7}, {1237, -1, 0, 7}// 91	94	95	
			, {3618, -2, 1, 7}, {3618, -1, 1, 7}, {1476, -2, 0, 24}// 96	97	98	
			, {1476, -2, 1, 24}, {1476, -2, 2, 24}, {1476, -2, 3, 24}// 99	100	101	
			, {1475, 3, 0, 23}, {1475, 3, 1, 23}, {1475, 3, 2, 23}// 102	103	104	
			, {1475, 3, 3, 23}, {1476, -1, 0, 27}, {1476, -1, 1, 27}// 105	106	107	
			, {1476, -1, 2, 27}, {1476, -1, 3, 27}, {1475, 2, 0, 26}// 108	109	110	
			, {1475, 2, 1, 26}, {1475, 2, 2, 26}, {1475, 2, 3, 26}// 111	112	113	
			, {1474, 0, 0, 30}, {1474, 0, 1, 30}, {1474, 0, 2, 30}// 114	115	116	
			, {1474, 0, 3, 30}, {1474, 1, 0, 30}, {1474, 1, 1, 30}// 117	118	119	
			, {1474, 1, 2, 30}, {1474, 1, 3, 30}, {2988, -1, 3, 2}// 120	121	122	
			, {2972, -1, 3, 2}// 123	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new FieldstoneCityHealerNEWAddonDeed();
			}
		}

		[ Constructable ]
		public FieldstoneCityHealerNEWAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 35, -3, -1, 7, 0, 0, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 35, 2, -1, 7, 0, 0, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 5463, 0, -2, 7, 1150, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 5463, 0, -1, 7, 1150, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 35, -3, 2, 7, 0, 0, "", 1);// 77
			AddComplexComponent( (BaseAddon) this, 34, 2, 2, 7, 0, 0, "", 1);// 90
			AddComplexComponent( (BaseAddon) this, 35, 2, 1, 7, 0, 0, "", 1);// 92
			AddComplexComponent( (BaseAddon) this, 34, -2, 2, 7, 0, 0, "", 1);// 93

		}

		public FieldstoneCityHealerNEWAddon( Serial serial ) : base( serial )
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

	public class FieldstoneCityHealerNEWAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new FieldstoneCityHealerNEWAddon();
			}
		}

		[Constructable]
		public FieldstoneCityHealerNEWAddonDeed()
		{
			Name = "FieldstoneCityHealerNEW";
		}

		public FieldstoneCityHealerNEWAddonDeed( Serial serial ) : base( serial )
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