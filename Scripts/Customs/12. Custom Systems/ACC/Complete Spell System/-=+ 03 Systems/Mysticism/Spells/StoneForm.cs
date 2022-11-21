using System;
using System.Collections;
using Server.Network;
using Server.Items;
using Server.Targeting;
using Server.Spells;

namespace Server.ACC.CSS.Systems.Mysticism
{
	public class StoneFormSpell : MysticismForm
	{
		private static SpellInfo m_Info = new SpellInfo(
				"Stone Form", "In Rel Ylem",
				230,
				9022,
				Reagent.Bloodmoss,
				Reagent.FertileDirt,
				Reagent.Garlic
			);
		
		public override SpellCircle Circle
    {
      get { return SpellCircle.Fourth; }
    }
			
    public override double CastDelay{ get{ return 2.0; } }
		public override double RequiredSkill{ get{ return 33.0; } }
		public override int RequiredMana{ get{ return 11; } }

		public override int Body{ get{ return 705; } }

		public StoneFormSpell( Mobile caster, Item scroll ) : base( caster, scroll, m_Info )
		{
		}

		private static Hashtable m_Table = new Hashtable();
		
		public override void DoEffect( Mobile m )
		{
            ResistanceMod[] mods = (ResistanceMod[])m_Table[m];

            if (mods == null)
            {
                m.PlaySound(0x65B);
                m.FixedParticles(0x3728, 1, 13, 9918, 92, 3, EffectLayer.Head);
                m.Delta(MobileDelta.WeaponDamage);

                int otherMod = 0 + (int)(m.Skills[SkillName.Mysticism].Value / 20);

                mods = new ResistanceMod[5]
				{
					new ResistanceMod( ResistanceType.Physical, otherMod ),
					new ResistanceMod( ResistanceType.Fire,		otherMod ),
				    new ResistanceMod( ResistanceType.Cold,		otherMod ),
					new ResistanceMod( ResistanceType.Poison,	otherMod ),
					new ResistanceMod( ResistanceType.Energy,	otherMod )			
				};

                m_Table[m] = mods;

                for (int i = 0; i < mods.Length; ++i)
                    m.AddResistanceMod(mods[i]);
            }
		}

		public override void RemoveEffect( Mobile m )
		{
           ResistanceMod[] mods = (ResistanceMod[])m_Table[m];

            if (mods != null)
            {
                m.PlaySound(0x65B);
                m.FixedParticles(0x3728, 1, 13, 9918, 92, 3, EffectLayer.Head);
                m.Delta(MobileDelta.WeaponDamage);

                m_Table.Remove(m);

                m_Table[m] = mods;

                for (int i = 0; i < mods.Length; ++i)
                    m.RemoveResistanceMod(mods[i]);

                m.Delta(MobileDelta.WeaponDamage);
            }
		}
	}
}