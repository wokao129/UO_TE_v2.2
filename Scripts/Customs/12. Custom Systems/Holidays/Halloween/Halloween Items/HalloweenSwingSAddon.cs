
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
	public class HalloweenSwingSAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3894, -3, 0, 1}, {6664, 0, 1, 11}, {3892, 2, 1, 0}// 1	6	12	
			, {8700, -2, 0, 0}, {8700, 2, 0, 0}, {4108, -3, 1, 0}// 13	15	16	
			, {4108, 3, 1, 0}, {8457, 2, 0, 15}, {4651, 0, 0, 2}// 17	18	19	
			, {3892, -3, 0, 0}, {3892, -2, 1, 0}, {3894, 3, 0, 1}// 20	21	22	
			, {3892, 3, 0, 0}, {3178, 2, 1, 0}, {3179, 2, 1, 0}// 23	24	25	
			, {3180, 2, 1, 0}, {6664, 2, 1, 11}, {6664, 2, 1, 5}// 26	27	28	
			, {6664, 2, 1, 1}, {6664, 0, 1, 5}, {6664, 0, 1, 1}// 29	30	31	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new HalloweenSwingSAddonDeed();
			}
		}

		[ Constructable ]
		public HalloweenSwingSAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 2919, 1, 0, 0, 1256, -1, "Swing", 1);// 2
			AddComplexComponent( (BaseAddon) this, 9376, 1, 0, 25, 1, -1, "Swing", 1);// 3
			AddComplexComponent( (BaseAddon) this, 9376, 0, 0, 25, 1, -1, "Swing", 1);// 4
			AddComplexComponent( (BaseAddon) this, 9376, -1, 0, 25, 1, -1, "Swing", 1);// 5
			AddComplexComponent( (BaseAddon) this, 10809, 2, 0, 6, 1109, -1, "Swing", 1);// 7
			AddComplexComponent( (BaseAddon) this, 10809, -2, 0, 6, 1109, -1, "Swing", 1);// 8
			AddComplexComponent( (BaseAddon) this, 2919, -1, 0, 0, 1256, -1, "Swing", 1);// 9
			AddComplexComponent( (BaseAddon) this, 2919, 0, 0, 0, 1256, -1, "Swing", 1);// 10
			AddComplexComponent( (BaseAddon) this, 9376, 2, 0, 25, 1, -1, "Swing", 1);// 11
			AddComplexComponent( (BaseAddon) this, 18069, -1, 0, 13, 0, 0, "Scary Glowing Round Eye Pumpkin", 1);// 14

		}

		public HalloweenSwingSAddon( Serial serial ) : base( serial )
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

	public class HalloweenSwingSAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new HalloweenSwingSAddon();
			}
		}

		[Constructable]
		public HalloweenSwingSAddonDeed()
		{
			Name = "Halloween Swing South";
		}

		public HalloweenSwingSAddonDeed( Serial serial ) : base( serial )
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