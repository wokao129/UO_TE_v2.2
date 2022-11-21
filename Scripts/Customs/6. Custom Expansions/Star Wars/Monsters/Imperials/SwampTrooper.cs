using System;
using Server;
using Server.Misc;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a Swamp Trooper's corpse" )]
	public class SwampTrooper : BaseCreature
	{
		[Constructable]
		public SwampTrooper() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a Sea Trooper";
			Body = 183;
			SetStr( 986, 1185 );
			SetDex( 177, 255 );
			SetInt( 151, 250 );
			SetHits( 592, 711 );

			SetDamage( 10, 17 );
			SetDamageType( ResistanceType.Physical, 50 );
			SetDamageType( ResistanceType.Poison, 50 );
			SetResistance( ResistanceType.Physical, 75, 85 );
			SetResistance( ResistanceType.Fire, 10, 20 );
			SetResistance( ResistanceType.Cold, 25, 30 );
			SetResistance( ResistanceType.Poison, 95, 100 );
			SetResistance( ResistanceType.Energy, 70, 80 );
			SetSkill( SkillName.Poisoning, 107.0, 113.5 );
			SetSkill( SkillName.MagicResist, 120.0, 130.0 );
			SetSkill( SkillName.Archery, 160.0, 170.0 );
			SetSkill( SkillName.Tactics, 140.0, 150.0 );

			Fame = 510;
			Karma = 510;

			PackItem( new Bandage( Utility.RandomMinMax( 20, 35 ) ) );
			PackItem( new BlasterCartridge ( 25 ));
			
			SwampBlaster weapon = new SwampBlaster();
			weapon.Movable = false;
			AddItem( weapon );

			Bascinet helmet = new Bascinet();
			helmet.Movable = false;
			helmet.Hue = 2210;
			AddItem( helmet );

			PlateArms arms = new PlateArms();
			arms.Movable = false;
			arms.Hue = 2210;
			AddItem( arms );

			LeatherNinjaJacket tunic = new LeatherNinjaJacket();
			tunic.Movable = false;
			tunic.Hue = 2210;
			AddItem( tunic );
			
			PlateLegs legs = new PlateLegs();
			legs.Movable = false;
			legs.Hue = 2210;
			AddItem( legs );

			LeatherNinjaBelt waist = new LeatherNinjaBelt();
			waist.Movable = false;
			waist.Hue = 2051;
			AddItem( waist );
			
			StuddedMempo neck = new StuddedMempo();
			neck.Movable = false;
			neck.Hue = 2210;
			AddItem( neck );
			
			BoneGloves gloves = new BoneGloves();
			gloves.Movable = false;
			gloves.Hue = 2210;
			AddItem( gloves );
		}

		public override void OnDeath( Container c )
		{
			base.OnDeath( c );
			
			switch ( Utility.Random( 45 ) )
			{
				case 0: c.DropItem( new AllyaExileDeed() ); break;
				case 1: c.DropItem( new AllyaRedemptionDeed() ); break;
				case 2: c.DropItem( new AnkarresDeed() ); break;
				case 3: c.DropItem( new BaasDeed() ); break;
				case 4: c.DropItem( new BarabDeed() ); break;
				case 5: c.DropItem( new BlackwingDeed() ); break;
				case 6: c.DropItem( new BondaraDeed() ); break;
				case 7: c.DropItem( new BondarDeed() ); break;
				case 8: c.DropItem( new DamindDeed() ); break;
				case 9: c.DropItem( new DODDeed() ); break;
				case 10: c.DropItem( new DragiteDeed() ); break;
				case 11: c.DropItem( new DurindfireDeed() ); break;
				case 12: c.DropItem( new EralamDeed() ); break;
				case 13: c.DropItem( new GreenAdeganDeed() ); break;
				case 14: c.DropItem( new HeartDeed() ); break;
				case 15: c.DropItem( new HurrikaineDeed() ); break;
				case 16: c.DropItem( new ImpactDeed() ); break;
				case 17: c.DropItem( new JenruaxDeed() ); break;
				case 18: c.DropItem( new KenobiDeed() ); break;
				case 19: c.DropItem( new KraytDeed() ); break;
				case 20: c.DropItem( new LambentDeed() ); break;
				case 21: c.DropItem( new LavaDeed() ); break;
				case 22: c.DropItem( new LignanDeed() ); break;
				case 23: c.DropItem( new LorridianDeed() ); break;
				case 24: c.DropItem( new MantleDeed() ); break;
				case 25: c.DropItem( new MeditationDeed() ); break;
				case 26: c.DropItem( new NextorDeed() ); break;
				case 27: c.DropItem( new PermafrostDeed() ); break;
				case 28: c.DropItem( new PhondDeed() ); break;
				case 29: c.DropItem( new QixoniDeed() ); break;
				case 30: c.DropItem( new RubatDeed() ); break;
				case 31: c.DropItem( new RuusanDeed() ); break;
				case 32: c.DropItem( new SapithDeed() ); break;
				case 33: c.DropItem( new SigilDeed() ); break;
				case 34: c.DropItem( new SolariDeed() ); break;
				case 35: c.DropItem( new StygiumDeed() ); break;
				case 36: c.DropItem( new SunriderDeed() ); break;
				case 37: c.DropItem( new SyntheticDeed() ); break;
				case 38: c.DropItem( new TyranusDeed() ); break;
				case 39: c.DropItem( new UlricRedemptionDeed() ); break;
				case 40: c.DropItem( new UltimaDeed() ); break;
				case 41: c.DropItem( new UpariDeed() ); break;
				case 42: c.DropItem( new VelmoriteDeed() ); break;
				case 43: c.DropItem( new VexxtalDeed() ); break;
				case 44: c.DropItem( new WinduDeed () ); break;
			}
        }
		
		public override void GenerateLoot()
		{
			AddLoot( LootPack.Meager );
		}

		public override bool AlwaysMurderer{ get{ return true; } }
		public override bool ShowFameTitle{ get{ return false; } }

		public SwampTrooper( Serial serial ) : base( serial )
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