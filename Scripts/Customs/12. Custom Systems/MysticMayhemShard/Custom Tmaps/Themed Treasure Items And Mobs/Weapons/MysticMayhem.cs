using System;
using Server.Items;

namespace Server.Items
{
    public class MysticMayhem : BladedStaff, ITokunoDyable
	{
		//public override int LabelNumber{ get{ return 1072080; } } // Scepter of the Chief
		public override int ArtifactRarity{ get{ return 14; } }

		[Constructable]
		public MysticMayhem() : base()
		{
			Name = "Mystic Mayhem";
			Hue = 214;
			EngravedText = "Recovered From Shadow Guardians";
			
			//Slayer = SlayerName.Repond;
			
			//Attributes.BonusInt = 30;
			Attributes.SpellDamage = 50;
			
			Attributes.RegenMana = 5;
			WeaponAttributes.HitHarm = 50;
			WeaponAttributes.HitFireball = 50;
			WeaponAttributes.HitLightning = 50;
			WeaponAttributes.MageWeapon = 25;
		}

		public MysticMayhem( Serial serial ) : base( serial )
		{
		}		
		
		#region Mondain's Legacy
		public override void GetDamageTypes( Mobile wielder, out int phys, out int fire, out int cold, out int pois, out int nrgy, out int chaos, out int direct )
		{
			phys = 20; fire = 20; cold = 20; nrgy = 20; chaos = 0; direct = 0;
			pois = 20;
		}
		#endregion

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