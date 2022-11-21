using System;
using Server;
using Server.Items;

namespace Server.ACC.CSS.Systems.LightForce
{
   public class ForceWeaponDisc : CSpellScroll
   {
      [Constructable]
      public ForceWeaponDisc() : base( typeof( ForceWeaponSpell ), 0x01CB )
      {
         Name = "Force Weapon";
         Hue = 1185;
		 Stackable = false;
      }

      public ForceWeaponDisc( Serial serial ) : base( serial )
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

