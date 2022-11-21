
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
	public class TombofTheKingsBridgeAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new TombofTheKingsBridgeAddonDeed();
			}
		}

		[ Constructable ]
		public TombofTheKingsBridgeAddon()
		{



			AddComplexComponent( (BaseAddon) this, 20339, 1, -3, 0, 656, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 20343, 0, -3, 0, 656, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 20336, -1, -3, 0, 656, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 20340, 1, -2, 0, 656, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 20340, 1, -1, 0, 656, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 20340, 1, 0, 0, 656, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 20340, 1, 1, 0, 656, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 20340, 1, 2, 0, 656, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 20340, 1, 3, 0, 656, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 20344, 0, -2, 0, 656, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 20344, 0, -1, 0, 656, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 20344, 0, 0, 0, 656, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 20344, 0, 1, 0, 656, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 20344, 0, 2, 0, 656, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 20344, 0, 3, 0, 656, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 20341, -1, -2, 0, 656, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 20341, -1, -1, 0, 656, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 20341, -1, 0, 0, 656, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 20341, -1, 1, 0, 656, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 20341, -1, 2, 0, 656, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 20341, -1, 3, 0, 656, -1, "", 1);// 21

		}

		public TombofTheKingsBridgeAddon( Serial serial ) : base( serial )
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

	public class TombofTheKingsBridgeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new TombofTheKingsBridgeAddon();
			}
		}

		[Constructable]
		public TombofTheKingsBridgeAddonDeed()
		{
			Name = "TombofTheKingsBridge";
		}

		public TombofTheKingsBridgeAddonDeed( Serial serial ) : base( serial )
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