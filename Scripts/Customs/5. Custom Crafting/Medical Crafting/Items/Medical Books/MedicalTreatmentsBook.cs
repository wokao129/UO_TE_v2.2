using System;
using Server;

namespace Server.Items
{
	public class MedicalTreatmentsBook : BaseBook
	{

		[Constructable]
		public MedicalTreatmentsBook() : base( 0xFF2 )
		{
			Name = "Physician's Desk Reference";
			Weight = 2.0;
		}

		public MedicalTreatmentsBook( Serial serial ) : base( serial )
		{
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int)0 ); // version
		}
	}
}