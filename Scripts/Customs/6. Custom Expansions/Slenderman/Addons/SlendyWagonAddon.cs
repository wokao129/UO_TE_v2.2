
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
	public class SlendyWagonAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SlendyWagonAddonDeed();
			}
		}

		[ Constructable ]
		public SlendyWagonAddon()
		{



			AddComplexComponent( (BaseAddon) this, 10351, 0, -1, 9, 1805, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 17, -1, -1, 9, 1445, -1, "Abandoned Wagon", 1);// 2
			AddComplexComponent( (BaseAddon) this, 17, -1, 0, 9, 1445, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 18, 0, -2, 9, 1445, -1, "Abandoned Wagon", 1);// 4
			AddComplexComponent( (BaseAddon) this, 10351, 0, 0, 9, 1805, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 18, 1, -2, 9, 1445, -1, "Abandoned Wagon", 1);// 6
			AddComplexComponent( (BaseAddon) this, 10351, 1, 1, 10, 1445, -1, "Abandoned Wagon", 1);// 7
			AddComplexComponent( (BaseAddon) this, 17, 1, 0, 11, 1445, -1, "Abandoned Wagon", 1);// 8
			AddComplexComponent( (BaseAddon) this, 17, 1, -1, 11, 1445, -1, "Abandoned Wagon", 1);// 9
			AddComplexComponent( (BaseAddon) this, 10351, 1, 0, 10, 1445, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 10351, 1, -1, 10, 1445, -1, "Abandoned Wagon", 1);// 11
			AddComplexComponent( (BaseAddon) this, 5712, 1, -1, 3, 1443, -1, "Abandoned Wagon", 1);// 12
			AddComplexComponent( (BaseAddon) this, 5712, 1, 1, 4, 1443, -1, "Abandoned Wagon", 1);// 13
			AddComplexComponent( (BaseAddon) this, 5723, -1, 1, 3, 1443, -1, "Abandoned Wagon", 1);// 14
			AddComplexComponent( (BaseAddon) this, 4166, 0, -1, 9, 1805, -1, "Spoiled Goods", 1);// 15
			AddComplexComponent( (BaseAddon) this, 4338, 0, 0, 9, 1805, -1, "Spoiled Goods", 1);// 16
			AddComplexComponent( (BaseAddon) this, 4339, 0, -1, 9, 1805, -1, "Spoiled Goods", 1);// 17
			AddComplexComponent( (BaseAddon) this, 7129, 0, 0, 9, 1805, -1, "Spoiled Goods", 1);// 18
			AddComplexComponent( (BaseAddon) this, 7131, 0, -1, 11, 1805, -1, "Spoiled Goods", 1);// 19
			AddComplexComponent( (BaseAddon) this, 7604, 1, 1, 0, 1445, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 7605, 0, 2, 0, 1445, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 3117, 1, 2, 0, 1445, -1, "Abandoned Wagon", 1);// 22
			AddComplexComponent( (BaseAddon) this, 10351, 0, 1, 10, 1445, -1, "Abandoned Wagon", 1);// 23
			AddComplexComponent( (BaseAddon) this, 8654, 1, 1, 11, 1445, -1, "Abandoned Wagon", 1);// 24
			AddComplexComponent( (BaseAddon) this, 8654, -1, 1, 9, 1445, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 2181, -1, 1, 9, 1445, -1, "Abandoned Wagon", 1);// 26
			AddComplexComponent( (BaseAddon) this, 2181, 1, 1, 11, 1445, -1, "Abandoned Wagon", 1);// 27
			AddComplexComponent( (BaseAddon) this, 926, 1, 2, 9, 1445, -1, "Abandoned Wagon", 1);// 28
			AddComplexComponent( (BaseAddon) this, 926, -1, 2, 8, 1445, -1, "Abandoned Wagon", 1);// 29
			AddComplexComponent( (BaseAddon) this, 4980, 0, 3, 0, 1805, -1, "", 1);// 30

		}

		public SlendyWagonAddon( Serial serial ) : base( serial )
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

	public class SlendyWagonAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SlendyWagonAddon();
			}
		}

		[Constructable]
		public SlendyWagonAddonDeed()
		{
			Name = "SlendyWagon";
		}

		public SlendyWagonAddonDeed( Serial serial ) : base( serial )
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