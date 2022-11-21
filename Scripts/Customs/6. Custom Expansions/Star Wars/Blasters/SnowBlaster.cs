using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	[FlipableAttribute( 0x26C3, 0x26CD )]
	public class SnowBlaster : BaseBlaster
	{
		public override int EffectID{ get{ return 0x3E75; } }
		public override Type AmmoType{ get{ return typeof( BlasterCartridge ); } }
		public override Item Ammo{ get{ return new BlasterCartridge(); } }
		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.MovingShot; } }
		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.Dismount; } }
		public override int AosStrengthReq{ get{ return 10; } }
		public override int AosMinDamage{ get{ return Core.ML ? 5 : 4; } }
		public override int AosMaxDamage{ get{ return Core.ML ? 12 : 10; } }
		public override int AosSpeed{ get{ return 22; } }
		public override float MlSpeed{ get{ return 1.00f; } }
		public override int OldStrengthReq{ get{ return 40; } }
		public override int OldMinDamage{ get{ return 11; } }
		public override int OldMaxDamage{ get{ return 56; } }
		public override int OldSpeed{ get{ return 10; } }
		public override int DefMaxRange{ get{ return 10; } }
		public override int InitMinHits{ get{ return 31; } }
		public override int InitMaxHits{ get{ return 100; } }

		[Constructable]
		public SnowBlaster() : base( 0x26C3 )
		{
			Name = "Snow Blaster";
			AosElementDamages.Cold = 100;
			Hue = 2051;
			LootType = LootType.Blessed;
			Weight = 7.0;
			Layer = Layer.TwoHanded;
		}

		public override bool OnFired( Mobile attacker, Mobile defender )
		{
			Container pack = attacker.Backpack;

			if ( attacker.Player )
			{
				if ( pack == null || !pack.ConsumeTotal( AmmoType, 1 ) )
				{
					return false;
				}
			}

			attacker.MovingEffect( defender, EffectID, 18, 1, false, false, 1149, 0  );
			attacker.PlaySound( 0x644 );
			return true;
		}

		public SnowBlaster( Serial serial ) : base( serial )
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