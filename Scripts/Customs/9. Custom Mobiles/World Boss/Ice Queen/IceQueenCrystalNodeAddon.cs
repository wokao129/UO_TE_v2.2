
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
	public class IceQueenCrystalNodeAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {13803, -2, 2, 0}, {13803, -2, -2, 0}, {13752, -2, -2, 0}// 1	2	3	
			, {13752, -2, -1, 0}, {13752, -2, 0, 0}, {13752, -2, 1, 0}// 4	5	6	
			, {13752, -2, 2, 0}, {13752, -1, -2, 0}, {13752, -1, -1, 0}// 7	8	9	
			, {13752, -1, 0, 0}, {13752, -1, 1, 0}, {13752, -1, 2, 0}// 10	11	12	
			, {14265, -2, -2, 10}, {14265, -2, 2, 10}, {13778, 0, 0, 0}// 13	14	15	
			, {13803, 2, -2, 0}, {13803, 2, 2, 0}, {13752, 0, -2, 0}// 17	18	19	
			, {13752, 0, -1, 0}, {13752, 0, 0, 0}, {13752, 0, 1, 0}// 20	21	22	
			, {13752, 0, 2, 0}, {13752, 1, -2, 0}, {13752, 1, -1, 0}// 23	24	25	
			, {13752, 1, 0, 0}, {13752, 1, 1, 0}, {13752, 1, 2, 0}// 26	27	28	
			, {13752, 2, -2, 0}, {13752, 2, -1, 0}, {13752, 2, 0, 0}// 29	30	31	
			, {13752, 2, 1, 0}, {13752, 2, 2, 0}, {14265, 2, 2, 10}// 32	33	34	
			, {14265, 2, -2, 10}// 35	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new IceQueenCrystalNodeAddonDeed();
			}
		}

		[ Constructable ]
		public IceQueenCrystalNodeAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 13807, 0, 0, 5, 0, 1, "", 1);// 16

		}

		public IceQueenCrystalNodeAddon( Serial serial ) : base( serial )
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

	public class IceQueenCrystalNodeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new IceQueenCrystalNodeAddon();
			}
		}

		[Constructable]
		public IceQueenCrystalNodeAddonDeed()
		{
			Name = "IceQueenCrystalNode";
		}

		public IceQueenCrystalNodeAddonDeed( Serial serial ) : base( serial )
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