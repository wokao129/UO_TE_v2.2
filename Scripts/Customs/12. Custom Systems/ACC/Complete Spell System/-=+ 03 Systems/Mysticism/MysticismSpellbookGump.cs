using System;
using Server;
using Server.Gumps;

namespace Server.ACC.CSS.Systems.Mysticism
{
	public class MysticismSpellbookGump : MysticismGump
	{
		public override string TextHue  { get{ return "670404"; } }
		public override int    BGImage  { get{ return 11058; } }
		public override int    SpellBtn { get{ return 2362; } }
		public override int    SpellBtnP{ get{ return 2361; } }
		public override string Label1   { get{ return "INDEX"; } }
		public override string Label2   { get{ return "INDEX"; } }
		public override Type   GumpType { get{ return typeof( MysticismSpellbookGump ); } }
		public override School School{ get{ return School.Mysticism; } }


		public MysticismSpellbookGump( CSpellbook book ) : base( book )
		{
		}
	}
}