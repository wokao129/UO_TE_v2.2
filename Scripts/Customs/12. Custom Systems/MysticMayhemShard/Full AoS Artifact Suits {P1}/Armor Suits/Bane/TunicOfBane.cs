using System;
using Server;

namespace Server.Items
{
	public class TunicOfBane : ChainChest
	{
		public override int LabelNumber{ get{ return 1061100; } } // Tunic of Bane
		public override SetItem SetID{ get{ return SetItem.Bane; } }
		public override int Pieces{ get{ return 3; } }
		
		public override int ArtifactRarity{ get{ return 11; } }

		public override int BasePoisonResistance{ get{ return 22; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public TunicOfBane()
		{
			Name = "Tunic of Bane";
			Hue = 0x4F5;
			ArmorAttributes.DurabilityBonus = 100;
			this.HitPoints = this.MaxHitPoints = 255;	//Cause the Durability bonus and such and the min/max hits as well as all other hits being whole #'s...
			
			SetAttributes.BonusStam = 10;
			SetSelfRepair = 2;	
			SetSkillBonuses.SetValues( 0, SkillName.Poisoning, 5 );
		}

		public TunicOfBane( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 2 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			if( version <= 1 )
			{
				if( this.HitPoints > 255 || this.MaxHitPoints > 255 )
					this.HitPoints = this.MaxHitPoints = 255;
			}

			if ( version < 1 )
			{
				if ( Hue == 0x559 )
					Hue = 0x4F5;

				if ( ArmorAttributes.DurabilityBonus == 0 )
					ArmorAttributes.DurabilityBonus = 100;

				PoisonBonus = 0;
			}
		}
	}
}