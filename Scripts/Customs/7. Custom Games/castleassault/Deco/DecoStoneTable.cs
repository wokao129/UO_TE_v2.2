using System;
using Server;

namespace Server.Items
{
	public class DecoStoneTable : Item
	{
		[Constructable]
		public DecoStoneTable() : base( 0x1202 )
		{
			Name = "a stone table";
			Movable = false;
		}

		public DecoStoneTable(Serial serial ) : base( serial )
		{
		}

		public override bool Decays
		{
			get	{ return false;	}
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