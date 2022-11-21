//Created By Milva//
using System;
using Server;

namespace Server.Items
{

	public class WaxSpider : Item
	{

		[Constructable]
		public  WaxSpider() : base( 0x2153 )
		{
			Name = "Wax Spider";
			Weight = 0.5;
             Hue = Utility.RandomList ( 1153, 38, 1260, 2478, 2479 );
                        
                 	}
		
		

		public  WaxSpider( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}
