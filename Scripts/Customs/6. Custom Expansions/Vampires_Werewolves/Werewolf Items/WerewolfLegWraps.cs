using System;
using Server;

namespace Server.Items
{
	[FlipableAttribute( 0x2FCA, 0x3180 )]
	public class WerewolfLegWraps1 : BaseArmor
	{
		public override int BasePhysicalResistance{ get{ return 8; } }
		public override int BaseFireResistance{ get{ return 8; } }
		public override int BaseEnergyResistance{ get{ return 8; } }
		public override int Hue{ get{ return 1905; } }
		public override int InitMinHits{ get{ return 60; } }
		public override int InitMaxHits{ get{ return 60; } }
		public override int AosStrReq{ get{ return 10; } }
		public override int OldStrReq{ get{ return 10; } }
		public override int ArmorBase{ get{ return 24; } }
		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Leather; } }
		public override CraftResource DefaultResource{ get{ return CraftResource.RegularLeather; } }
		public override ArmorMeditationAllowance DefMedAllowance{ get{ return ArmorMeditationAllowance.All; } }

		[Constructable]
		public WerewolfLegWraps1() : base( 0x2FCA )
		{
            Name = "Werewolf Fledgling Legwraps";
			Weight = 2.0;
		}

		public WerewolfLegWraps1( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.WriteEncodedInt( 0 );
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			int version = reader.ReadEncodedInt();
		}
	}

	[FlipableAttribute( 0x2FCA, 0x3180 )]
	public class WerewolfLegWraps2 : BaseArmor
	{
		public override int BasePhysicalResistance{ get{ return 10; } }
		public override int BaseFireResistance{ get{ return 10; } }
		public override int BaseEnergyResistance{ get{ return 10; } }
		public override int ArmorBase{ get{ return 30; } }
		public override int Hue{ get{ return 1905; } }
		public override int InitMinHits{ get{ return 100; } }
		public override int InitMaxHits{ get{ return 100; } }
		public override int AosStrReq{ get{ return 10; } }
		public override int OldStrReq{ get{ return 10; } }
		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Leather; } }
		public override CraftResource DefaultResource{ get{ return CraftResource.RegularLeather; } }
		public override ArmorMeditationAllowance DefMedAllowance{ get{ return ArmorMeditationAllowance.All; } }

		[Constructable]
		public WerewolfLegWraps2() : base( 0x2FCA )
		{
	        Name = "Werewolf Legwraps";
			Weight = 2.0;
		}

		public WerewolfLegWraps2( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.WriteEncodedInt( 0 );
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			int version = reader.ReadEncodedInt();
		}
	}

	[FlipableAttribute( 0x2FCA, 0x3180 )]
	public class WerewolfLegWraps3 : BaseArmor
	{
		public override int BasePhysicalResistance{ get{ return 12; } }
		public override int BaseFireResistance{ get{ return 12; } }
		public override int BaseEnergyResistance{ get{ return 12; } }
		public override int ArmorBase{ get{ return 35; } }
		public override int Hue{ get{ return 1905; } }
		public override int InitMinHits{ get{ return 120; } }
		public override int InitMaxHits{ get{ return 120; } }
		public override int AosStrReq{ get{ return 10; } }
		public override int OldStrReq{ get{ return 10; } }
		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Leather; } }
		public override CraftResource DefaultResource{ get{ return CraftResource.RegularLeather; } }
		public override ArmorMeditationAllowance DefMedAllowance{ get{ return ArmorMeditationAllowance.All; } }

		[Constructable]
		public WerewolfLegWraps3() : base( 0x2FCA )
		{
	        Name = "Werewolf Elder Legwraps";
			Weight = 2.0;
			Attributes.LowerManaCost = 3;
			Attributes.RegenMana = 2;
			Attributes.SpellDamage = 2;
		}

		public WerewolfLegWraps3( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.WriteEncodedInt( 0 );
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			int version = reader.ReadEncodedInt();
		}
	}

	[FlipableAttribute( 0x2FCA, 0x3180 )]
	public class WerewolfLegWraps4 : BaseArmor
	{
		public override int BasePhysicalResistance{ get{ return 14; } }
		public override int BaseFireResistance{ get{ return 14; } }
		public override int BaseEnergyResistance{ get{ return 14; } }
		public override int ArmorBase{ get{ return 40; } }
		public override int Hue{ get{ return 1905; } }
		public override int InitMinHits{ get{ return 140; } }
		public override int InitMaxHits{ get{ return 140; } }
		public override int AosStrReq{ get{ return 10; } }
		public override int OldStrReq{ get{ return 10; } }
		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Leather; } }
		public override CraftResource DefaultResource{ get{ return CraftResource.RegularLeather; } }
		public override ArmorMeditationAllowance DefMedAllowance{ get{ return ArmorMeditationAllowance.All; } }

		[Constructable]
		public WerewolfLegWraps4() : base( 0x2FCA )
		{
	        Name = "Werewolf Patrician Legwraps";
			Weight = 2.0;
			Attributes.LowerManaCost = 8;
			Attributes.RegenMana = 5;
			Attributes.SpellDamage = 2;
		}

		public WerewolfLegWraps4( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.WriteEncodedInt( 0 );
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			int version = reader.ReadEncodedInt();
		}
	}

	[FlipableAttribute( 0x2FCA, 0x3180 )]
	public class WerewolfLegWraps5 : BaseArmor
	{
		public override SetItem SetID{ get{ return SetItem.Werewolf; } }
		public override int Pieces{ get{ return 5; } }
		public override int BasePhysicalResistance{ get{ return 20; } }
		public override int BaseFireResistance{ get{ return 20; } }
		public override int BaseEnergyResistance{ get{ return 20; } }
		public override int ArmorBase{ get{ return 60; } }
		public override int Hue{ get{ return 1905; } }
		public override int InitMinHits{ get{ return 200; } }
		public override int InitMaxHits{ get{ return 200; } }
		public override int AosStrReq{ get{ return 10; } }
		public override int OldStrReq{ get{ return 10; } }
		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Leather; } }
		public override CraftResource DefaultResource{ get{ return CraftResource.RegularLeather; } }
		public override ArmorMeditationAllowance DefMedAllowance{ get{ return ArmorMeditationAllowance.All; } }

		[Constructable]
		public WerewolfLegWraps5() : base( 0x2FCA )
		{
	        Name = "Ancient Werewolf Legwraps";
			Weight = 2.0;
			Attributes.ReflectPhysical = 8;
			Attributes.BonusStam = 2;
			SetAttributes.BonusStr = 10;
			SetSkillBonuses.SetValues( 0, SkillName.AnimalLore, 40 );
			SetAttributes.Luck = 100;
			SetAttributes.NightSight = 1;
			SetPoisonBonus = 8;
		}

		public WerewolfLegWraps5( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.WriteEncodedInt( 0 );
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			int version = reader.ReadEncodedInt();
		}
	}
}