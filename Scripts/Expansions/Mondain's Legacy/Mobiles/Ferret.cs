using System;
using Server;
using Server.Engines.Quests;

namespace Server.Mobiles
{
	[CorpseName( "a ferret corpse" )]	
	public class Ferret : BaseCreature
	{
		[Constructable]
		public Ferret() : base( AIType.AI_Animal, FightMode.Aggressor, 10, 1, 0.2, 0.4 )
		{
			Name = "a ferret";
			Body = 0x117;			

			SetStr( 41, 48 );
			SetDex( 55 );
			SetInt( 75 );

			SetHits( 45, 50 );

			SetDamage( 7, 9 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 45, 50 );
			SetResistance( ResistanceType.Fire, 10, 14 );
			SetResistance( ResistanceType.Cold, 30, 40 );
			SetResistance( ResistanceType.Poison, 21, 25 );
			SetResistance( ResistanceType.Energy, 20, 25 );

			SetSkill( SkillName.MagicResist, 4.0 );
			SetSkill( SkillName.Tactics, 4.0 );
			SetSkill( SkillName.Wrestling, 4.0 );

			Tamable = true;	
			ControlSlots = 1;
			MinTameSkill = 29.1;
			
			m_CanTalk = true;
		}

		public override int Meat{ get{ return 1; } }
		public override FoodType FavoriteFood{ get{ return FoodType.Fish; } }

		public Ferret( Serial serial ) : base( serial )
		{
		}
		
		public override void OnMovement( Mobile m, Point3D oldLocation ) 
		{
			if ( m is Ferret && m.InRange( this, 3 ) && m.Alive )
				Talk( (Ferret) m );
		}
		
		private static string[] m_Vocabulary = new string[]
		{
			"dook",
			"dook dook",
			"dook dook dook!"
		};
		
		private bool m_CanTalk;
		
		public void Talk()
		{
			Talk( null );
		}
		
		public void Talk( Ferret to )
		{		
			if ( m_CanTalk )
			{
				if ( to != null )
					QuestSystem.FocusTo( this, to );
					
				Say( m_Vocabulary[ Utility.Random( m_Vocabulary.Length ) ] );
			
				if ( to != null && Utility.RandomBool() )
					Timer.DelayCall( TimeSpan.FromSeconds( Utility.RandomMinMax( 5, 8 ) ), new TimerCallback( delegate() { to.Talk(); } ) );
			
				m_CanTalk = false;
				
				Timer.DelayCall( TimeSpan.FromSeconds( Utility.RandomMinMax( 20, 30 ) ), new TimerCallback( delegate() { m_CanTalk = true; } ) );
			}
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
			
			m_CanTalk = true;
		}
	}
}