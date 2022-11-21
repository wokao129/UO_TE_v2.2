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
	public class HauntedTableAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2520, 0, -1, 5}, {2520, 0, 1, 7}, {5625, 0, 0, 8}// 4	5	6	
			, {2493, 0, 0, 6}, {2520, 1, 0, 7}, {2549, 1, 1, 7}// 7	14	15	
			, {8081, 1, 1, 6}// 20	
		};

		public override BaseAddonDeed Deed
		{
			get
			{
				return new HauntedTableAddonDeed();
			}
		}

		[ Constructable ]
		public HauntedTableAddon()
		{
            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );

			AddComplexComponent( (BaseAddon) this, 2928, 0, 1, 0, 2308, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 2931, 0, 0, 0, 2308, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 2931, 0, -1, 0, 2308, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 3100, -1, 1, 0, 2308, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 3100, -1, 0, 0, 2308, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 3100, -1, -1, 0, 2308, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 2929, 1, 1, 0, 2308, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 2930, 1, -1, 0, 2308, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 2931, 1, 0, 0, 2308, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 2444, 1, -1, 6, 1811, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 3101, 2, 1, 0, 2308, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 3101, 2, 0, 0, 2308, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 3101, 2, -1, 0, 2308, -1, "", 1);// 19
		}

		public HauntedTableAddon( Serial serial ) : base( serial )
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

	public class HauntedTableAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new HauntedTableAddon();
			}
		}

		[Constructable]
		public HauntedTableAddonDeed()
		{
			Name = "Haunted Table";
		}

		public HauntedTableAddonDeed( Serial serial ) : base( serial )
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