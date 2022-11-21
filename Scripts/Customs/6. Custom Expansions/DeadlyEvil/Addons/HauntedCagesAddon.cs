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
	public class HauntedCagesAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {6660, -5, 0, 3}, {2083, -5, 0, 0}, {6666, -4, -1, 1}// 1	2	4	
			, {2083, -4, 0, 0}, {8175, 3, 0, 1}, {6659, 1, -1, 1}// 6	7	8	
			, {8175, -3, 0, 1}, {6942, 3, -1, 1}, {2083, -2, 0, 0}// 9	10	12	
			, {2083, 2, 0, 0}, {2083, 1, 0, 0}, {2083, 4, 0, 0}// 13	14	15	
			, {2083, 5, 0, 0}, {6942, -2, -1, 1}, {2083, -2, 0, 0}// 16	17	21	
			, {2083, 0, 0, 0}, {2083, -1, 0, 0}// 22	23	
		};

		public override BaseAddonDeed Deed
		{
			get
			{
				return new HauntedCagesAddonDeed();
			}
		}

		[ Constructable ]
		public HauntedCagesAddon()
		{
            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );

			AddComplexComponent( (BaseAddon) this, 7677, -5, 1, 1, 794, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 7677, -4, 1, 2, 794, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 7677, -1, 0, 1, 794, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 7678, 1, 1, 1, 794, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 7678, 2, 1, 1, 1807, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 7677, 3, 1, 1, 794, -1, "", 1);// 20
		}

		public HauntedCagesAddon( Serial serial ) : base( serial )
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

	public class HauntedCagesAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new HauntedCagesAddon();
			}
		}

		[Constructable]
		public HauntedCagesAddonDeed()
		{
			Name = "Haunted Cages";
		}

		public HauntedCagesAddonDeed( Serial serial ) : base( serial )
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