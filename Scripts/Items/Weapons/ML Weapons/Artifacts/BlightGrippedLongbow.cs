using System;
using Server.Items;

namespace Server.Items
{
    public class BlightGrippedLongbow : ElvenCompositeLongbow, ITokunoDyable
	{
		public override int LabelNumber{ get{ return 1072907; } } // Blight Gripped Longbow

        public override int InitMinHits { get { return 255; } }
        public override int InitMaxHits { get { return 255; } }

		[Constructable]
		public BlightGrippedLongbow()
		{
			Hue = 0x8A4;

			WeaponAttributes.HitPoisonArea = 20;
			Attributes.RegenStam = 3;
			Attributes.NightSight = 1;
			Attributes.WeaponSpeed = 20;
			Attributes.WeaponDamage = 35;
		}

		public BlightGrippedLongbow( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}
}