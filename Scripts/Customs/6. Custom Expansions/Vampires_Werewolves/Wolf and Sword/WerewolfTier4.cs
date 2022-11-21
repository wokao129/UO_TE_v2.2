using System;
using Server;
using System.Collections;
using Server.Items;
using Server.Network;
using Server.Targeting;

namespace Server.Mobiles
{
	[CorpseName( "a werewolf corpse" )]
	public class WerewolfTier4 : BaseCreature
	{
		private bool m_TrueForm;

		[Constructable]
		public WerewolfTier4() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "werewolf";
			Body = 719;
			SetStr( 1000, 1200 );
			SetDex( 450, 600 );
			SetInt( 1200, 1500 );
			SetHits( 2400, 3200 );
			SetDamage( 20, 32 );

			SetDamageType( ResistanceType.Physical, 100 );
			SetResistance( ResistanceType.Physical, 50, 80 );
			SetResistance( ResistanceType.Fire, 35, 40 );
			SetResistance( ResistanceType.Cold, 60, 90 );
			SetResistance( ResistanceType.Poison, 60, 90 );
			SetResistance( ResistanceType.Energy, 50, 80 );
			SetSkill( SkillName.EvalInt, 140.0, 165.0 );
			SetSkill( SkillName.Magery, 140.0, 165.0 );
			SetSkill( SkillName.Necromancy, 130.0, 160.0 );
			SetSkill( SkillName.SpiritSpeak, 100.0, 105.0 );
			SetSkill( SkillName.MagicResist, 140.0, 180.0 );
			SetSkill( SkillName.Tactics, 160.0, 200.0 );
			SetSkill( SkillName.Wrestling, 160.1, 200.0 );
			SetSkill( SkillName.DetectHidden, 85.0, 95.0 );

			VirtualArmor = 55;
		}
		public void Morph()
		{
			if (m_TrueForm)
				return;

			m_TrueForm = true;
			if ( this.Female = Utility.RandomBool() )
			{
				Body = 0x191;
				Name = NameList.RandomName( "female" );
				WerewolfLegWraps1 LegWraps = new WerewolfLegWraps1();
				LegWraps.Name = "Werewolf Patrician Legwraps";
				LegWraps.Movable = false;
				AddItem(LegWraps);
			}
			else
			{
				Body = 0x190;
				Name = NameList.RandomName( "male" );
				WerewolfLegs1 Legs = new WerewolfLegs1();
				Legs.Name = "Werewolf Patrician Leggings";
				Legs.Movable = false;
				AddItem(Legs);
			}
			Title = "the Werewolf";
			SpeechHue = Utility.RandomDyedHue();
			Hue = Utility.RandomSkinHue();
			SetStr( 500, 600 );
			SetDex( 225, 300 );
			SetInt( 600, 750 );
			Hits = HitsMax;
			Stam = StamMax;
			Mana = ManaMax;
			SetDamage( 18, 30 );
			
			SetDamageType( ResistanceType.Physical, 100 );
			SetResistance( ResistanceType.Physical, 50, 80 );
			SetResistance( ResistanceType.Fire, 35, 40 );
			SetResistance( ResistanceType.Cold, 60, 90 );
			SetResistance( ResistanceType.Poison, 60, 90 );
			SetResistance( ResistanceType.Energy, 50, 80 );
			SetSkill( SkillName.EvalInt, 140.0, 165.0 );
			SetSkill( SkillName.Magery, 140.0, 165.0 );
			SetSkill( SkillName.Necromancy, 130.0, 160.0 );
			SetSkill( SkillName.SpiritSpeak, 100.0, 105.0 );
			SetSkill( SkillName.MagicResist, 140.0, 180.0 );
			SetSkill( SkillName.Tactics, 160.0, 200.0 );
			SetSkill( SkillName.Wrestling, 160.1, 200.0 );
			SetSkill( SkillName.DetectHidden, 85.0, 95.0 );

			Fame = 1000;
			Karma = -1000;

			VirtualArmor = 45;
			Tamable = false;
			ProcessDelta();

			WerewolfGorget1 Gorget = new WerewolfGorget1();
			Gorget.Movable = false;
			Gorget.Name = "Werewolf Patrician Collar";
			AddItem(Gorget);

			WerewolfChest1 Chest = new WerewolfChest1();
			Chest.Name = "Werewolf Patrician Tunic";
			Chest.Movable = false;
			AddItem(Chest);

			WerewolfArms1 Arms = new WerewolfArms1();
			Arms.Name = "Werewolf Patrician Armguards";
			Arms.Movable = false;
			AddItem(Arms);

			WerewolfGloves1 Gloves = new WerewolfGloves1();
			Gloves.Movable = false;
			Gloves.Name = "Werewolf Patrician Gloves";
			AddItem(Gloves);
			
			// This dresses the Werewolf, Note TatteredClothes are not movable and do not show up on the corpse
			switch ( Utility.Random( 2 ))
			{
				case 0: AddItem( new  TatteredCloak() ); break;
				default: break;
			}
			switch ( Utility.Random( 4 ))
			{
			//Assassin Only
				//case 0: AddItem( new  TatteredClothNinjaHood() ); break;
				case 0: AddItem( new  TatteredCap() ); break;
				case 1: AddItem( new  TatteredSkullCap() ); break;
				case 2: AddItem( new  TatteredBandana() ); break;
				case 3: AddItem( new  TatteredBonnet() ); break;
			// Archmage Only
				//case 5: AddItem( new  TatteredMagicWizardsHat() ); break;
				default: break;
			}
			switch ( Utility.Random( 3 ))
			{
				case 0: AddItem( new  TatteredFullApron() ); break;
				case 1: AddItem( new  TatteredDoublet() ); break;
				// Knight Only
				//case 2: AddItem( new  TatteredSurcoat() ); break;
				// Knight Only
				//case 3: AddItem( new  TatteredTunic() ); break;
				case 2: AddItem( new  TatteredJinBaori() ); break;
				default: break;
			}
			switch ( Utility.Random( 2 ))
			{
				// Patrician Only
				//case 0: AddItem( new  TatteredFancyDress () ); break;
				// Patrician Only
				//case 1: AddItem( new  TatteredKamishimo  () ); break;
				case 0: AddItem( new  TatteredHakamaShita  () ); break;
				case 1: AddItem( new  TatteredPlainDress  () ); break;
				// Elder Only
				//case 4: AddItem( new  TatteredMaleKimono  () ); break;
				// Elder Only
				//case 5: AddItem( new  TatteredFemaleKimono () ); break;
				default: break;
			}

			switch ( Utility.Random( 3 ))
			{
				case 0: AddItem( new  TatteredFancyShirt() ); break;
				//Assassin Only
				//case 1: AddItem( new  TatteredClothNinjaJacket() ); break;
				case 1: AddItem( new  TatteredShirt() ); break;
				case 2: AddItem( new  TatteredElvenDarkShirt() ); break;	
				default: break;
			}
			switch ( Utility.Random( 5 ))
			{
				case 0: AddItem( new  TatteredThighBoots () ); break;
				case 1: AddItem( new  TatteredSandals () ); break;
				case 2: AddItem( new  TatteredNinjaTabi  () ); break;
				case 3: AddItem( new  TatteredElvenBoots() ); break;
				case 4: AddItem( new  TatteredShoes() ); break;
				default: break;
			}
			switch ( Utility.Random( 3 ))
			{
				case 0: AddItem( new  TatteredWoodlandBelt() ); break;
				case 1: AddItem( new  TatteredObi() ); break;
				case 2: AddItem( new  TatteredHalfApron () ); break;
				default: break;
			}
			// End Werewolf Dressing Block
			Utility.AssignRandomHair( this );
		}
		[CommandProperty( AccessLevel.GameMaster )]
		public override int HitsMax{ get{ return m_TrueForm ? 1200 : 1600; } }
		
		[CommandProperty( AccessLevel.GameMaster )]
		public override int ManaMax{ get{ return 400; } }

		public override void GenerateLoot()
		{
			AddLoot( LootPack.FilthyRich );
			AddLoot( LootPack.MedScrolls, 2 );
		}

		public override bool CanRummageCorpses{ get{ return true; } }
		public override bool BleedImmune{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Deadly; } }
		public override bool AlwaysMurderer{ get{ return true; } }

		public override void OnGaveMeleeAttack( Mobile defender )
		{
			base.OnGaveMeleeAttack( defender );

			if ( Utility.RandomDouble() < 0.15 )
				CacophonicAttack( defender );
		}
		
		public override void OnDamage( int amount, Mobile from, bool willKill )
		{			
			if ( Utility.RandomDouble() < 0.15 )
				CacophonicAttack( from );
			
			base.OnDamage( amount, from, willKill );
		}
		
		private static Hashtable m_Table;
		
		public virtual void CacophonicAttack( Mobile to )
		{
			if ( m_Table == null )
				m_Table = new Hashtable();
		
			if ( to.Alive && to.Player && m_Table[ to ] == null )
			{
				to.Send( SpeedControl.WalkSpeed );
				to.SendMessage( "The werewolf's howl prevents you from running away!" ); // A cacophonic sound lambastes you, suppressing your ability to move.
				to.PlaySound( 0x0A5 );
				m_Table[ to ] = Timer.DelayCall( TimeSpan.FromSeconds( 30 ), new TimerStateCallback( EndCacophonic_Callback ), to );
			}
		}
		
		private void EndCacophonic_Callback( object state )
		{
			if ( state is Mobile )
				CacophonicEnd( (Mobile) state );
		}		
		
		public virtual void CacophonicEnd( Mobile from )
		{
			if ( m_Table == null )
				m_Table = new Hashtable();
				
			m_Table[ from ] = null;
			from.Send( SpeedControl.Disable );
		}
		
		public static bool UnderCacophonicAttack( Mobile from )
		{
			if ( m_Table == null )
				m_Table = new Hashtable();
			
			return m_Table[ from ] != null;
		}
		
		private DateTime m_Delay;

		public override void OnActionCombat()
		{
			if ( DateTime.Now > m_Delay )
			{
                switch (Utility.Random(1))
				{
                    case 0: Ability.BullRush(this);
                        m_Delay = DateTime.Now + TimeSpan.FromSeconds(Utility.RandomMinMax(15, 25)); break;
				}
			}			

			base.OnActionCombat();
		}
		
		public override WeaponAbility GetWeaponAbility()
		{
			return WeaponAbility.WhirlwindAttack;
        }
		
		public WerewolfTier4( Serial serial ) : base( serial )
		{
		}

		public override bool OnBeforeDeath()
		{
			if ( m_TrueForm )
			{
				return base.OnBeforeDeath();
			}
			else
			{
				Morph();
				return false;
			}
		}
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );

			writer.Write( m_TrueForm );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();

			switch ( version )
			{
				case 0:
				{
					m_TrueForm = reader.ReadBool();

					break;
				}
			}
		}

		// these two allow werewolves to reveal hidden players
	    private Mobile FindTarget()
        {
        	foreach (Mobile m in this.GetMobilesInRange(1))
	        {
                if (m.Player && m.Hidden && m.AccessLevel == AccessLevel.Player)
           	    {
                	return m;
        	    }
	        }
	        return null;
	    }

	    private void TryToDetectHidden()
        {
	        Mobile m = FindTarget();

        	if (m != null)
	        {
                if (DateTime.Now >= this.NextSkillTime && UseSkill(SkillName.DetectHidden))
        	    {
	                Target targ = this.Target;

                	if (targ != null)
        	            targ.Invoke(this, this);
	
	                Effects.PlaySound(this.Location, this.Map, 0x340);
                }
        	}
	    }

	    public override void OnThink()
		{
            if (Utility.RandomDouble() < 0.2)
        	    TryToDetectHidden();
	    }
	}
}