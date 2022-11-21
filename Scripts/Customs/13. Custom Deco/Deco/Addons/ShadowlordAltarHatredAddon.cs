
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
	public class ShadowlordAltarHatredAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new ShadowlordAltarHatredAddonDeed();
			}
		}

		[ Constructable ]
		public ShadowlordAltarHatredAddon()
		{



			AddComplexComponent( (BaseAddon) this, 6025, 0, 0, 36, 2051, -1, "Altar to the Shadowlord of Hatred", 1);// 1
			AddComplexComponent( (BaseAddon) this, 13827, -1, 0, 30, 2053, -1, "Altar to the Shadowlord of Hatred", 1);// 2
			AddComplexComponent( (BaseAddon) this, 13902, 1, -1, 30, 1760, -1, "Altar to the Shadowlord of Hatred", 1);// 3
			AddComplexComponent( (BaseAddon) this, 12289, -1, -1, 0, 1779, -1, "Altar to the Shadowlord of Hatred", 1);// 4
			AddComplexComponent( (BaseAddon) this, 13900, 0, 0, 48, 2051, -1, "Altar to the Shadowlord of Hatred", 1);// 5
			AddComplexComponent( (BaseAddon) this, 13902, -1, 1, 29, 1760, -1, "Altar to the Shadowlord of Hatred", 1);// 6
			AddComplexComponent( (BaseAddon) this, 13827, 0, -1, 30, 2053, -1, "Altar to the Shadowlord of Hatred", 1);// 7
			AddComplexComponent( (BaseAddon) this, 6021, 1, 1, 36, 2053, -1, "Altar to the Shadowlord of Hatred", 1);// 8
			AddComplexComponent( (BaseAddon) this, 4963, 1, 0, 34, 2054, -1, "Altar to the Shadowlord of Hatred", 1);// 9
			AddComplexComponent( (BaseAddon) this, 13920, 0, 0, 30, 1760, -1, "Altar to the Shadowlord of Hatred", 1);// 10
			AddComplexComponent( (BaseAddon) this, 6087, 1, 1, 33, 2055, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 16435, 0, 0, 32, 1760, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 16574, 0, 0, 34, 2051, 0, "Altar to the Shadowlord of Hatred", 1);// 13
			AddComplexComponent( (BaseAddon) this, 6020, 1, 1, 36, 2053, -1, "Altar to the Shadowlord of Hatred", 1);// 14
			AddComplexComponent( (BaseAddon) this, 765, 1, 1, 33, 2051, -1, "Altar to the Shadowlord of Hatred", 1);// 15
			AddComplexComponent( (BaseAddon) this, 6025, 0, 0, 37, 2053, -1, "Altar to the Shadowlord of Hatred", 1);// 16
			AddComplexComponent( (BaseAddon) this, 4963, 0, 1, 34, 2054, -1, "Altar to the Shadowlord of Hatred", 1);// 17
			AddComplexComponent( (BaseAddon) this, 7688, 1, 2, 34, 2053, -1, "Altar to the Shadowlord of Hatred", 1);// 18
			AddComplexComponent( (BaseAddon) this, 3633, 1, 1, 33, 0, 0, "Altar to the Shadowlord of Hatred", 1);// 19

		}

		public ShadowlordAltarHatredAddon( Serial serial ) : base( serial )
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

	public class ShadowlordAltarHatredAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new ShadowlordAltarHatredAddon();
			}
		}

		[Constructable]
		public ShadowlordAltarHatredAddonDeed()
		{
			Name = "ShadowlordAltarHatred";
		}

		public ShadowlordAltarHatredAddonDeed( Serial serial ) : base( serial )
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