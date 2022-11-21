
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
	public class CaveEntrance3Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4544, -1, 2, 2}, {4547, -2, 2, 2}, {7025, -1, 3, 2}// 1	2	3	
			, {12791, -1, 1, 2}, {12791, -2, 1, 2}, {6915, -1, 2, 2}// 6	7	8	
			, {12791, -2, 0, 2}, {7979, -2, 2, 2}, {3392, -2, -2, 11}// 9	14	19	
			, {3234, -2, 3, 2}, {3245, -1, -2, 9}, {3230, -1, 1, 5}// 20	21	22	
			, {7949, -2, -1, 13}, {7949, -1, -2, 9}, {7950, -2, -1, 11}// 23	24	25	
			, {3259, -3, 1, 2}, {3270, -2, 3, 2}, {3249, -1, 4, 2}// 26	27	28	
			, {3210, -3, 2, 2}, {4545, 1, 2, 2}, {12791, 0, 1, 2}// 29	30	33	
			, {12791, 1, 1, 2}, {4544, 0, 2, 2}, {7025, 0, 3, 2}// 34	35	36	
			, {6916, 0, 2, 2}, {12791, 1, 0, 2}, {4945, 2, 0, 2}// 37	38	41	
			, {7979, 1, 2, 2}, {4948, 1, -2, 2}, {4964, 2, -1, 6}// 42	44	46	
			, {3391, 1, -1, 17}, {3224, 3, 1, 2}, {3324, 0, -2, 4}// 47	48	49	
			, {3323, 0, -2, 2}, {3230, 3, -1, 2}, {3307, 0, 1, 2}// 50	51	52	
			, {3308, 1, 1, 2}, {3310, 3, 3, 17}, {3311, 2, -1, 2}// 53	54	55	
			, {3309, 1, 1, 12}, {7951, 2, 0, 24}, {3380, 0, 0, 23}// 56	57	58	
			, {3380, 3, 1, 35}, {3259, 3, 0, 5}, {3270, 1, 3, 2}// 59	60	61	
			, {3250, 0, 4, 2}, {3204, 2, 2, 2}// 62	63	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CaveEntrance3AddonDeed();
			}
		}

		[ Constructable ]
		public CaveEntrance3Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 6571, -2, 2, 5, 0, 1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 8552, -1, 0, 2, 2002, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 4946, -3, 0, 1, 2002, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 4947, -2, 0, 0, 2002, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 4949, -2, 2, 2, 2002, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 4950, -2, 1, 1, 2002, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 4952, -1, -2, 2, 2002, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 4953, -1, -3, 2, 2002, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 4954, -2, -1, 3, 2002, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 4963, -2, -2, 8, 2002, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 6571, 1, 2, 5, 0, 1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 8553, 0, 0, 2, 2002, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 4943, 1, 1, 2, 2002, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 4944, 2, 1, 2, 2002, -1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 4947, 1, -1, 2, 2002, -1, "", 1);// 43
			AddComplexComponent( (BaseAddon) this, 4963, 2, -1, 2, 2002, -1, "", 1);// 45

		}

		public CaveEntrance3Addon( Serial serial ) : base( serial )
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

	public class CaveEntrance3AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CaveEntrance3Addon();
			}
		}

		[Constructable]
		public CaveEntrance3AddonDeed()
		{
			Name = "CaveEntrance3";
		}

		public CaveEntrance3AddonDeed( Serial serial ) : base( serial )
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