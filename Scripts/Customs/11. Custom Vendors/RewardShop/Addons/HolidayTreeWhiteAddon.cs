
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
	public class HolidayTreeWhiteAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3286, 0, 0, 0}// 1	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new HolidayTreeWhiteAddonDeed();
			}
		}

		[ Constructable ]
		public HolidayTreeWhiteAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 3287, 0, 0, 0, 2041, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 3885, 0, 1, 8, 0, -1, "Holiday Light", 1);// 3
			AddComplexComponent( (BaseAddon) this, 3865, 0, 1, 9, 0, -1, "Holiday Light", 1);// 4
			AddComplexComponent( (BaseAddon) this, 3859, 0, 1, 11, 0, -1, "Holiday Light", 1);// 5
			AddComplexComponent( (BaseAddon) this, 3856, 0, 1, 18, 0, -1, "Holiday Light", 1);// 6
			AddComplexComponent( (BaseAddon) this, 3878, 0, 1, 7, 0, -1, "Holiday Light", 1);// 7
			AddComplexComponent( (BaseAddon) this, 3861, 1, 1, 13, 0, -1, "Holiday Light", 1);// 8
			AddComplexComponent( (BaseAddon) this, 3862, 0, 1, 9, 0, -1, "Holiday Light", 1);// 9
			AddComplexComponent( (BaseAddon) this, 3885, 1, 1, 16, 0, -1, "Holiday Light", 1);// 10
			AddComplexComponent( (BaseAddon) this, 3865, 1, 1, 20, 0, -1, "Holiday Light", 1);// 11
			AddComplexComponent( (BaseAddon) this, 3859, 1, 1, 27, 0, -1, "Holiday Light", 1);// 12
			AddComplexComponent( (BaseAddon) this, 3856, 0, 0, 23, 0, -1, "Holiday Light", 1);// 13
			AddComplexComponent( (BaseAddon) this, 3878, 0, 0, 8, 0, -1, "Holiday Light", 1);// 14
			AddComplexComponent( (BaseAddon) this, 3861, 1, 1, 25, 0, -1, "Holiday Light", 1);// 15
			AddComplexComponent( (BaseAddon) this, 3862, 0, 1, 27, 0, -1, "Holiday Light", 1);// 16
			AddComplexComponent( (BaseAddon) this, 3878, 0, 1, 32, 0, -1, "Holiday Light", 1);// 17
			AddComplexComponent( (BaseAddon) this, 3878, 0, 1, 18, 0, -1, "Holiday Light", 1);// 18
			AddComplexComponent( (BaseAddon) this, 3873, 0, 1, 35, 0, -1, "Holiday Light", 1);// 19
			AddComplexComponent( (BaseAddon) this, 2842, 0, 1, 12, 2041, 1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 2842, 1, 1, 30, 2041, 1, "", 1);// 21

		}

		public HolidayTreeWhiteAddon( Serial serial ) : base( serial )
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

	public class HolidayTreeWhiteAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new HolidayTreeWhiteAddon();
			}
		}

		[Constructable]
		public HolidayTreeWhiteAddonDeed()
		{
			Name = "HolidayTreeWhite";
		}

		public HolidayTreeWhiteAddonDeed( Serial serial ) : base( serial )
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