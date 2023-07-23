
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
	public class GarlandsNorthAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2485, 0, 1, 10}, {4176, 0, 1, 12}, {3976, 0, 0, 5}// 2	3	4	
			, {4175, 0, 1, 11}, {3195, 0, 0, 9}, {7107, 0, 1, 0}// 5	6	7	
			, {2886, 0, 1, 4}, {3208, 0, 1, 8}, {5019, 0, 1, 3}// 8	9	10	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new GarlandsNorthAddonDeed();
			}
		}

		[ Constructable ]
		public GarlandsNorthAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 3615, 0, 0, 7, 757, -1, "", 1);// 1

		}

		public GarlandsNorthAddon( Serial serial ) : base( serial )
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

	public class GarlandsNorthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new GarlandsNorthAddon();
			}
		}

		[Constructable]
		public GarlandsNorthAddonDeed()
		{
			Name = "GarlandsNorth";
		}

		public GarlandsNorthAddonDeed( Serial serial ) : base( serial )
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