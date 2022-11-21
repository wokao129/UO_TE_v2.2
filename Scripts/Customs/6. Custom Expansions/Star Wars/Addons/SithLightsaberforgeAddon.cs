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
	public class SithLightSaberForgeAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SithLightSaberForgeAddonDeed();
			}
		}

		[ Constructable ]
		public SithLightSaberForgeAddon()
		{
			AddComplexComponent( (BaseAddon) this, 12560, -1, -2, 3, 2051, -1, "Lightsaber Forge", 1);// 1
			AddComplexComponent( (BaseAddon) this, 117, -1, -1, 23, 2052, -1, "Lightsaber Forge", 1);// 2
			AddComplexComponent( (BaseAddon) this, 12566, -1, -1, 3, 2053, -1, "Lightsaber Forge", 1);// 3
			AddComplexComponent( (BaseAddon) this, 17708, -1, -2, 0, 2051, -1, "Lightsaber Forge", 1);// 4
			AddComplexComponent( (BaseAddon) this, 16958, 0, -1, 2, 2052, -1, "Lightsaber Forge", 1);// 5
			AddComplexComponent( (BaseAddon) this, 18757, 0, -2, 3, 2051, -1, "Lightsaber Forge", 1);// 6
			AddComplexComponent( (BaseAddon) this, 12975, 1, -2, 3, 1467, -1, "Lightsaber Forge", 1);// 7
			AddComplexComponent( (BaseAddon) this, 12954, 1, -1, 3, 1467, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 4028, 1, -1, 4, 0, -1, "Lightsaber Forge", 1);// 9
			AddComplexComponent( (BaseAddon) this, 1952, 1, -1, 3, 2051, -1, "Lightsaber Forge", 1);// 10
			AddComplexComponent( (BaseAddon) this, 4020, 1, -1, 4, 0, -1, "Lightsaber Forge", 1);// 11
			AddComplexComponent( (BaseAddon) this, 10989, -1, 0, 2, 1471, 0, "Lightsaber Forge", 1);// 12
			AddComplexComponent( (BaseAddon) this, 12563, -1, 1, 3, 2053, -1, "Lightsaber Forge", 1);// 13
			AddComplexComponent( (BaseAddon) this, 115, -1, 1, 22, 2052, -1, "Lightsaber Forge", 1);// 14
			AddComplexComponent( (BaseAddon) this, 1872, -1, 0, 22, 2051, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 17918, -1, 0, 23, 2051, -1, "Lightsaber Forge", 1);// 16
			AddComplexComponent( (BaseAddon) this, 18770, 0, 2, 5, 2051, -1, "Lightsaber Forge", 1);// 17
			AddComplexComponent( (BaseAddon) this, 16958, 0, 1, 2, 2051, -1, "Lightsaber Forge", 1);// 18
			AddComplexComponent( (BaseAddon) this, 16960, 0, 0, 2, 2054, -1, "Lightsaber Forge", 1);// 19
			AddComplexComponent( (BaseAddon) this, 17706, -1, 2, 2, 2051, -1, "Lightsaber Forge", 1);// 20
			AddComplexComponent( (BaseAddon) this, 16981, 1, 1, 5, 1461, -1, "Lightsaber Forge", 1);// 21
			AddComplexComponent( (BaseAddon) this, 8704, -1, 0, 3, 2052, -1, "Lightsaber", 1);// 22
			AddComplexComponent( (BaseAddon) this, 2439, -1, 1, 19, 1478, -1, "Lightsaber Forge", 1);// 23
			AddComplexComponent( (BaseAddon) this, 16980, 1, 0, 5, 1461, -1, "Lightsaber Forge", 1);// 24
			AddComplexComponent( (BaseAddon) this, 12973, 1, 2, 3, 1467, -1, "Lightsaber Forge", 1);// 25
			AddComplexComponent( (BaseAddon) this, 12954, 1, 0, 3, 1467, -1, "Lightsaber Forge", 1);// 26
			AddComplexComponent( (BaseAddon) this, 12954, 1, 1, 3, 1467, -1, "Lightsaber Forge", 1);// 27
		}

		public SithLightSaberForgeAddon( Serial serial ) : base( serial )
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

	public class SithLightSaberForgeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SithLightSaberForgeAddon();
			}
		}

		[Constructable]
		public SithLightSaberForgeAddonDeed()
		{
			Name = "Sith Lightsaber Forge";
		}

		public SithLightSaberForgeAddonDeed( Serial serial ) : base( serial )
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