/////////////////////////////////////////////////
//
// Automatically generated by the
// AddonGenerator script by Arya
//
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class MWCouch3Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new MWCouch3AddonDeed();
			}
		}

		[ Constructable ]
		public MWCouch3Addon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 1222 );
			AddComponent( ac, 1, 2, 2 );
			ac = new AddonComponent( 1222 );
			AddComponent( ac, 1, -2, 2 );
			ac = new AddonComponent( 1222 );
			AddComponent( ac, 0, 2, 2 );
			ac = new AddonComponent( 1222 );
			AddComponent( ac, 0, 1, 2 );
			ac = new AddonComponent( 1222 );
			AddComponent( ac, 0, 0, 2 );
			ac = new AddonComponent( 1222 );
			AddComponent( ac, 0, -1, 2 );
			ac = new AddonComponent( 1222 );
			AddComponent( ac, 0, -2, 2 );
			ac = new AddonComponent( 5691 );
			ac.Hue = 2892;
			AddComponent( ac, 1, -2, 7 );
			ac = new AddonComponent( 5691 );
			ac.Hue = 2892;
			AddComponent( ac, 1, 2, 7 );
			ac = new AddonComponent( 3125 );
			ac.Hue = 2892;
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 3125 );
			ac.Hue = 2892;
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 3125 );
			ac.Hue = 2892;
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 2892;
			AddComponent( ac, 1, 2, 2 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 2892;
			AddComponent( ac, 0, 2, 2 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 2892;
			AddComponent( ac, 1, -2, 2 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 2892;
			AddComponent( ac, 0, 1, 2 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 2892;
			AddComponent( ac, 0, 0, 2 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 2892;
			AddComponent( ac, 0, -1, 2 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 2892;
			AddComponent( ac, 0, -2, 2 );
			ac = new AddonComponent( 2916 );
			ac.Hue = 2892;
			AddComponent( ac, 1, 1, 2 );
			ac = new AddonComponent( 2916 );
			ac.Hue = 2892;
			AddComponent( ac, 1, 0, 2 );
			ac = new AddonComponent( 2916 );
			ac.Hue = 2892;
			AddComponent( ac, 1, -1, 2 );

		}

		public MWCouch3Addon( Serial serial ) : base( serial )
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

	public class MWCouch3AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new MWCouch3Addon();
			}
		}

		[Constructable]
		public MWCouch3AddonDeed()
		{
			Name = "Couch3";
		}

		public MWCouch3AddonDeed( Serial serial ) : base( serial )
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