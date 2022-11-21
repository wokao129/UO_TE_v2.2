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
	public class HauntedTable2Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {7381, 1, -2, 0}, {7385, 1, 1, 0}, {7377, -2, 1, 0}// 1	2	3	
			, {7385, -1, 1, 0}, {7385, -1, 0, 0}, {7385, -1, -1, 0}// 4	5	6	
			, {13851, 1, -1, 0}, {7385, 0, 1, 0}, {7385, 0, -1, 0}// 7	10	11	
			, {7381, -1, -2, 0}, {7586, 0, 1, 6}, {13851, -1, -1, 0}// 13	14	17	
			, {5701, 1, 0, 6}, {7393, 0, 1, 7}, {3619, 0, 0, 8}// 27	29	30	
			, {7385, 0, 0, 0}, {2585, 0, 1, 6}, {2585, 1, 0, 6}// 31	32	33	
			, {7600, 1, -1, 6}, {7385, 1, -1, 0}, {5701, 0, 0, 6}// 34	35	36	
			, {13851, 0, -1, 0}, {13851, 1, 1, 0}, {13851, 1, 0, 0}// 38	39	40	
			, {13851, 0, 1, 0}, {13851, 0, 0, 0}, {13851, -1, 1, 0}// 41	42	43	
			, {13851, -1, 0, 0}, {3790, 1, -1, 4}, {2549, 1, 1, 6}// 44	45	46	
			, {7394, 1, 0, 7}, {7402, 0, -1, 6}, {7385, 1, 0, 0}// 49	50	51	
			, {2585, 0, -1, 6}, {7380, -1, 2, 0}, {7373, -2, 2, 0}// 52	54	55	
			, {7379, 1, 2, 0}, {7379, 0, 2, 0}, {4650, 1, 1, 6}// 56	57	59	
			, {2493, 0, 0, 6}, {7381, 2, -2, 0}, {7371, 2, 1, 0}// 60	62	63	
			, {7385, 2, 0, 0}, {7385, 2, -1, 0}, {13851, 2, -1, 0}// 64	65	68	
			, {7374, 2, 1, 0}, {13851, 2, 0, 0}, {7374, 2, 2, 0}// 70	74	75	
			, {7383, 3, -1, 0}, {7376, 3, -2, 0}, {7374, 3, 0, 0}// 76	77	78	
			, {7383, 3, 0, 0}, {7374, 3, 1, 0}// 79	80	
		}; 

		public override BaseAddonDeed Deed
		{
			get
			{
				return new HauntedTable2AddonDeed();
			}
		}

		[ Constructable ]
		public HauntedTable2Addon()
		{
            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );

			AddComplexComponent( (BaseAddon) this, 4611, 0, 0, 0, 1105, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 4610, 1, -1, 0, 1105, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 4611, 1, 0, 0, 1105, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 4633, -1, 0, 0, 1762, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 4633, -1, 1, 0, 1762, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 2749, -1, 0, 0, 1157, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 2749, -1, -1, 0, 1157, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 2749, -1, 1, 0, 1157, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 2749, 0, -1, 0, 1157, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 2749, 0, 1, 0, 1157, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 2749, 0, 0, 0, 1157, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 2749, 1, 1, 0, 1157, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 2749, 1, 0, 0, 1157, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 2807, 1, -2, 0, 1157, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 4610, 0, -1, 0, 1105, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 4609, 0, 1, 0, 1105, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 2806, -2, 0, 0, 1157, -1, "", 1);// 47
			AddComplexComponent( (BaseAddon) this, 2749, 1, -1, 0, 1157, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 4633, -1, -1, 0, 1762, -1, "", 1);// 53
			AddComplexComponent( (BaseAddon) this, 4609, 1, 1, 0, 1105, -1, "", 1);// 58
			AddComplexComponent( (BaseAddon) this, 8081, 1, 1, 6, 1478, -1, "Flagon of Blood", 1);// 61
			AddComplexComponent( (BaseAddon) this, 4635, 2, -1, 0, 1762, -1, "", 1);// 66
			AddComplexComponent( (BaseAddon) this, 4635, 2, 0, 0, 1762, -1, "", 1);// 67
			AddComplexComponent( (BaseAddon) this, 4635, 2, 1, 0, 1762, -1, "", 1);// 69
			AddComplexComponent( (BaseAddon) this, 2808, 2, -1, 0, 1157, -1, "", 1);// 71
			AddComplexComponent( (BaseAddon) this, 2749, 2, 0, 0, 1157, -1, "", 1);// 72
			AddComplexComponent( (BaseAddon) this, 2749, 2, -1, 0, 1157, -1, "", 1);// 73
		}

		public HauntedTable2Addon( Serial serial ) : base( serial )
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

	public class HauntedTable2AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new HauntedTable2Addon();
			}
		}

		[Constructable]
		public HauntedTable2AddonDeed()
		{
			Name = "Haunted Table 2";
		}

		public HauntedTable2AddonDeed( Serial serial ) : base( serial )
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