using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Server.Engines.Quests
{	
	public class Brae : MondainQuester
	{		
		public override Type[] Quests
		{ 
			get{ return new Type[] 
			{ 
				typeof( AllThatGlittersIsNotGoodQuest ),
				typeof( FiendishFriendsQuest )
			};} 
		}
		
		[Constructable]
		public Brae() : base( "Elder Brae", "the wise" )
		{			
		}
		
		public Brae( Serial serial ) : base( serial )
		{
		}		
		
		public override void InitBody()
		{
			InitStats( 100, 100, 25 );
			
			Female = true;
			Race = Race.Elf;
			
			Hue = 0x80BF;
			HairItemID = 0x2FC2;
			HairHue = 0x8E;
		}
		
		public override void InitOutfit()
		{
			AddItem( new ElvenBoots( 0x901 ) );
			AddItem( new GemmedCirclet() );
			AddItem( new FemaleElvenRobe( 0x44 ) );
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