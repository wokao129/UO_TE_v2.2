using System;
using Server;

namespace Server.Items
{
	public class TunicOfTheFallenKing : LeatherChest
	{
		public override int LabelNumber{ get{ return 1061094; } } // Tunic of the Fallen King
		public override SetItem SetID{ get{ return SetItem.FallenKing; } }
		public override int Pieces{ get{ return 6; } }
		
		public override int ArtifactRarity{ get{ return 11; } }

		public override int BaseColdResistance{ get{ return 15; } }
		public override int BaseEnergyResistance{ get{ return 15; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public TunicOfTheFallenKing()
		{
			Name = "Tunic of the Fallen King";
			Hue = 0x76D;
			
			SetAttributes.RegenHits = 5;
			SetPhysicalBonus = 2;
			SetFireBonus = 1;
			SetPoisonBonus = 1;
		}

		public TunicOfTheFallenKing( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 1 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			if ( version < 1 )
			{
				if ( Hue == 0x551 )
					Hue = 0x76D;

				ColdBonus = 0;
				EnergyBonus = 0;
			}
		}
	}
}