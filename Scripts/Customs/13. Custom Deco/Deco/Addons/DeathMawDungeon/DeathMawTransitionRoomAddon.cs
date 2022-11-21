
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
	public class DeathMawTransitionRoomAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1314, -1, -2, 0}, {1314, -1, -1, 0}, {1314, -1, 0, 0}// 1	2	3	
			, {1314, -1, 1, 0}, {1314, -1, 2, 0}, {1314, -1, 3, 0}// 4	5	6	
			, {1314, 0, -2, 0}, {1314, 0, -1, 0}, {1314, 0, 0, 0}// 7	8	9	
			, {1314, 0, 1, 0}, {1314, 0, 2, 0}, {1314, 0, 3, 0}// 10	11	12	
			, {1314, 1, -2, 0}, {1314, 1, -1, 0}, {1314, 1, 0, 0}// 13	14	15	
			, {1314, 1, 1, 0}, {1314, 1, 2, 0}, {1314, 1, 3, 0}// 16	17	18	
			, {466, -2, -3, 0}, {465, -2, -2, 0}, {465, -2, -1, 0}// 19	20	21	
			, {465, -2, 0, 0}, {465, -2, 1, 0}, {465, -2, 2, 0}// 22	23	24	
			, {465, -2, 3, 0}, {464, -1, -3, 0}, {464, 0, -3, 0}// 25	26	27	
			, {464, 1, -3, 0}, {1314, 2, -2, 0}, {1314, 2, -1, 0}// 28	29	30	
			, {1314, 2, 0, 0}, {1314, 2, 1, 0}, {1314, 2, 2, 0}// 31	32	33	
			, {1314, 2, 3, 0}, {464, 2, -3, 0}// 34	35	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new DeathMawTransitionRoomAddonDeed();
			}
		}

		[ Constructable ]
		public DeathMawTransitionRoomAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public DeathMawTransitionRoomAddon( Serial serial ) : base( serial )
		{
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

	public class DeathMawTransitionRoomAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new DeathMawTransitionRoomAddon();
			}
		}

		[Constructable]
		public DeathMawTransitionRoomAddonDeed()
		{
			Name = "DeathMawTransitionRoom";
		}

		public DeathMawTransitionRoomAddonDeed( Serial serial ) : base( serial )
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