using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
    public class BarabTarget : Target
    {
        private BarabDeed m_Deed;
        public BarabTarget(BarabDeed deed): base(1, false, TargetFlags.None)
        {
            m_Deed = deed;
        }

        protected override void OnTarget(Mobile from, object target)
        {
            if (m_Deed.Deleted || m_Deed.RootParent != from)
            {
                from.SendMessage("You cannot empower that with the Barab ore.");
                return;
            }

            if (target is Lightsaber)
            {
                Lightsaber item = (Lightsaber)target;

                if (item is Lightsaber)
                {
                    if (((Lightsaber)item).WeaponAttributes.HitLightning >= 50 && ((Lightsaber)item).WeaponAttributes.HitMagicArrow >= 30 || ((Lightsaber)item).TimesEmpowered > 1)
                    {
                        from.SendMessage("That lightsaber has already been empowered.");
                    }
                    else
                    {
                        ((Lightsaber)item).WeaponAttributes.HitLightning += Utility.RandomMinMax(5, 50);
						((Lightsaber)item).WeaponAttributes.HitMagicArrow += Utility.RandomMinMax(10, 30);

						if (((Lightsaber)item).TimesEmpowered == 1)
						{
							((Lightsaber)item).TimesEmpowered += 2;
							from.SendMessage("Your lightsaber has now been fully empowered.");
							return;
						}
						else
						{
							((Lightsaber)item).TimesEmpowered +=1;
							from.SendMessage("Your lightsaber can only be empowered with one more focusing crystal.");
						}
                        from.SendMessage("The Barab ore has empowered your lightsaber.");
                        m_Deed.Delete();
                    }
                }
            }
            else
            {
                from.SendMessage("You cannot empower that.");
            }
        }
    }

    public class BarabDeed : EmpoweringDeed
    {
        [Constructable]
        public BarabDeed()
        {
            Name = "Barab Ore";
            Hue = 2040;
        }

		public override void AddNameProperties( ObjectPropertyList list )
 		{
			base.AddNameProperties( list );
			list.Add( "Hit Lightning, Hit Magic Arrow" );
 		}
		
        public BarabDeed(Serial serial): base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }

        public override void OnDoubleClick(Mobile from)
        {
            if (!IsChildOf(from.Backpack))
            {
                from.SendMessage("The lightsaber needs to be in your pack.");
            }
            else
            {
                from.SendMessage("Which lightsaber would you like to empower with the Barab ore?");
                from.Target = new BarabTarget(this);
            }
        }
    }
}