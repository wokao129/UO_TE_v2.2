/*
 * Created by SharpDevelop.
 * User: Roger
 * Date: 02/02/2006
 * Time: 9:56 PM
 * 
 */
using System;
using Server;
using Server.Engines.Craft;

namespace Server.Items
{
	[FlipableAttribute( 0x13E4, 0x13E3 )]
	public class AncientCarpenterHammer : BaseTool
	{
		private int m_Bonus;
		private SkillMod m_SkillMod;

		[CommandProperty( AccessLevel.GameMaster )]
		public int Bonus
		{
			get
			{
				return m_Bonus;
			}
			set
			{
				m_Bonus = value;
				InvalidateProperties();

				if ( m_Bonus == 0 )
				{
					if ( m_SkillMod != null )
						m_SkillMod.Remove();

					m_SkillMod = null;
				}
				else if ( m_SkillMod == null && Parent is Mobile )
				{
					m_SkillMod = new DefaultSkillMod( SkillName.Carpentry, true, m_Bonus );
					((Mobile)Parent).AddSkillMod( m_SkillMod );
				}
				else if ( m_SkillMod != null )
				{
					m_SkillMod.Value = m_Bonus;
				}
			}
		}

		public override void OnAdded( object parent )
		{
			base.OnAdded( parent );

			if ( m_Bonus != 0 && parent is Mobile )
			{
				if ( m_SkillMod != null )
					m_SkillMod.Remove();

				m_SkillMod = new DefaultSkillMod( SkillName.Carpentry, true, m_Bonus );
				((Mobile)parent).AddSkillMod( m_SkillMod );
			}
		}

		public override void OnRemoved( object parent )
		{
			base.OnRemoved( parent );

			if ( m_SkillMod != null )
				m_SkillMod.Remove();

			m_SkillMod = null;
		}

		public override CraftSystem CraftSystem{ get{ return DefCarpentry.CraftSystem; } }
		
		[Constructable]
		public AncientCarpenterHammer( int bonus ) : this( bonus, 600 )
		{
			Name = "Ancient Carpenter's Hammer";
			m_Bonus = bonus;
			Weight = 8.0;
			Layer = Layer.OneHanded;
			Hue = 0x482;
		
		}

		[Constructable]
		public AncientCarpenterHammer( int bonus, int uses ) : base( uses, 0x13E4 )
		{
			Name = "Ancient Carpenter's Hammer";
			m_Bonus = bonus;
			Weight = 8.0;
			Layer = Layer.OneHanded;
			Hue = 0x482;
		}

		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			if ( m_Bonus != 0 )
				list.Add( 1060451, "#1044071\t{0}", m_Bonus.ToString() ); // ~1_skillname~ +~2_val~
		}

		public AncientCarpenterHammer( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version

			writer.Write( (int) m_Bonus );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			switch ( version )
			{
				case 0:
				{
					m_Bonus = reader.ReadInt();
					break;
				}
			}

			if ( m_Bonus != 0 && Parent is Mobile )
			{
				if ( m_SkillMod != null )
					m_SkillMod.Remove();

				m_SkillMod = new DefaultSkillMod( SkillName.Carpentry, true, m_Bonus );
				((Mobile)Parent).AddSkillMod( m_SkillMod );
			}

			if ( Hue == 0 )
				Hue = 0x482;
		}
	}
}
