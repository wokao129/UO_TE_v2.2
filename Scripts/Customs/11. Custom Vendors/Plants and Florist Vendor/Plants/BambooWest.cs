using System;

namespace Server.Items
{

public class BambooWest : Item
	{
		[Constructable]
		public BambooWest() : base( 9328 )
		{
			Name = "Bamboo";
			Weight = 1.0;
		}

		public BambooWest( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}
