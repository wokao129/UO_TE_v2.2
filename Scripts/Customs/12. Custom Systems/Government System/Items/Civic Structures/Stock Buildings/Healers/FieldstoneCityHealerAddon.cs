/////////////////////////////////////////////////
//
// Automatically generated by the
// AddonGenerator script by Arya
//
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class FieldstoneCityHealerAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				//return new FieldstoneCityHealerAddonDeed();
				return null;
			}
		}

		[ Constructable ]
		public FieldstoneCityHealerAddon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 102 );
			AddComponent( ac, -5, -5, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, -5, -4, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, -5, -3, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, -5, -2, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, -4, -5, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, -3, -5, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, -2, -5, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, -1, -5, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, 0, -5, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, 1, -5, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, 2, -5, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, 3, -5, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, 4, -5, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, 4, -4, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, 4, -3, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, 4, -2, 0 );
			ac = new AddonComponent( 29 );
			AddComponent( ac, -5, -5, 7 );
			ac = new AddonComponent( 27 );
			AddComponent( ac, -5, -4, 7 );
			ac = new AddonComponent( 35 );
			ac.Light = LightType.ArchedWindowEast;
			AddComponent( ac, -5, -3, 7 );
			ac = new AddonComponent( 27 );
			AddComponent( ac, -5, -2, 7 );
			ac = new AddonComponent( 28 );
			AddComponent( ac, -4, -5, 7 );
			ac = new AddonComponent( 28 );
			AddComponent( ac, -3, -5, 7 );
			ac = new AddonComponent( 28 );
			AddComponent( ac, -2, -5, 7 );
			ac = new AddonComponent( 28 );
			AddComponent( ac, -1, -5, 7 );
			ac = new AddonComponent( 28 );
			AddComponent( ac, 0, -5, 7 );
			ac = new AddonComponent( 28 );
			AddComponent( ac, 1, -5, 7 );
			ac = new AddonComponent( 28 );
			AddComponent( ac, 2, -5, 7 );
			ac = new AddonComponent( 28 );
			AddComponent( ac, 3, -5, 7 );
			ac = new AddonComponent( 28 );
			AddComponent( ac, 4, -5, 7 );
			ac = new AddonComponent( 1238 );
			AddComponent( ac, -4, -4, 7 );
			ac = new AddonComponent( 1239 );
			AddComponent( ac, -4, -3, 7 );
			ac = new AddonComponent( 1237 );
			AddComponent( ac, -4, -2, 7 );
			ac = new AddonComponent( 1239 );
			AddComponent( ac, -3, -4, 7 );
			ac = new AddonComponent( 1236 );
			AddComponent( ac, -3, -3, 7 );
			ac = new AddonComponent( 1238 );
			AddComponent( ac, -3, -2, 7 );
			ac = new AddonComponent( 1239 );
			AddComponent( ac, -2, -4, 7 );
			ac = new AddonComponent( 1237 );
			AddComponent( ac, -2, -3, 7 );
			ac = new AddonComponent( 1238 );
			AddComponent( ac, -2, -2, 7 );
			ac = new AddonComponent( 1236 );
			AddComponent( ac, -1, -4, 7 );
			ac = new AddonComponent( 1239 );
			AddComponent( ac, -1, -3, 7 );
			ac = new AddonComponent( 1236 );
			AddComponent( ac, -1, -2, 7 );
			ac = new AddonComponent( 1237 );
			AddComponent( ac, 0, -4, 7 );
			ac = new AddonComponent( 1236 );
			AddComponent( ac, 0, -3, 7 );
			ac = new AddonComponent( 1236 );
			AddComponent( ac, 0, -2, 7 );
			ac = new AddonComponent( 1239 );
			AddComponent( ac, 1, -4, 7 );
			ac = new AddonComponent( 1239 );
			AddComponent( ac, 1, -3, 7 );
			ac = new AddonComponent( 1237 );
			AddComponent( ac, 1, -2, 7 );
			ac = new AddonComponent( 1237 );
			AddComponent( ac, 2, -4, 7 );
			ac = new AddonComponent( 1237 );
			AddComponent( ac, 2, -3, 7 );
			ac = new AddonComponent( 1239 );
			AddComponent( ac, 2, -2, 7 );
			ac = new AddonComponent( 1236 );
			AddComponent( ac, 3, -4, 7 );
			ac = new AddonComponent( 1239 );
			AddComponent( ac, 3, -3, 7 );
			ac = new AddonComponent( 1237 );
			AddComponent( ac, 3, -2, 7 );
			ac = new AddonComponent( 1239 );
			AddComponent( ac, 4, -4, 7 );
			ac = new AddonComponent( 1237 );
			AddComponent( ac, 4, -3, 7 );
			ac = new AddonComponent( 1239 );
			AddComponent( ac, 4, -2, 7 );
			ac = new AddonComponent( 2659 );
			AddComponent( ac, -3, -4, 7 );
			ac = new AddonComponent( 2652 );
			AddComponent( ac, -3, -3, 7 );
			ac = new AddonComponent( 2659 );
			AddComponent( ac, -1, -4, 7 );
			ac = new AddonComponent( 2652 );
			AddComponent( ac, -1, -3, 7 );
			ac = new AddonComponent( 2659 );
			AddComponent( ac, 1, -4, 7 );
			ac = new AddonComponent( 2652 );
			AddComponent( ac, 1, -3, 7 );
			ac = new AddonComponent( 27 );
			AddComponent( ac, 4, -4, 7 );
			ac = new AddonComponent( 35 );
			ac.Light = LightType.ArchedWindowEast;
			AddComponent( ac, 4, -3, 7 );
			ac = new AddonComponent( 27 );
			AddComponent( ac, 4, -2, 7 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -4, -4, 27 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 5, -4, 27 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -3, -4, 30 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -3, -3, 30 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -3, -2, 30 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -2, -4, 33 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -2, -3, 33 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -2, -2, 33 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -1, -4, 36 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -1, -3, 36 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -1, -2, 36 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, 0, -4, 39 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, 0, -3, 39 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, 0, -2, 39 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 1, -4, 39 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 1, -3, 39 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 1, -2, 39 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 2, -4, 36 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 2, -3, 36 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 2, -2, 36 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 3, -4, 33 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 3, -3, 33 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 3, -2, 33 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 4, -4, 30 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 4, -3, 30 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 4, -2, 30 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -4, -3, 27 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -4, -2, 27 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 5, -3, 27 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 5, -2, 27 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, -5, -1, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, -5, 0, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, -5, 1, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, -5, 2, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, -5, 4, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, -4, 4, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, -3, 4, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, -2, 4, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, -1, 4, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, 0, 4, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, 1, 4, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, 2, 4, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, 3, 4, 0 );
			ac = new AddonComponent( 1880 );
			AddComponent( ac, -4, 5, 0 );
			ac = new AddonComponent( 1873 );
			AddComponent( ac, -3, 5, 0 );
			ac = new AddonComponent( 1873 );
			AddComponent( ac, -2, 5, 0 );
			ac = new AddonComponent( 1878 );
			AddComponent( ac, -1, 5, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, 4, -1, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, 4, 0, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, 4, 1, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, 4, 2, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, 4, 3, 0 );
			ac = new AddonComponent( 101 );
			AddComponent( ac, 4, 4, 0 );
			ac = new AddonComponent( 27 );
			AddComponent( ac, -5, -1, 7 );
			ac = new AddonComponent( 35 );
			ac.Light = LightType.ArchedWindowEast;
			AddComponent( ac, -5, 0, 7 );
			ac = new AddonComponent( 27 );
			AddComponent( ac, -5, 1, 7 );
			ac = new AddonComponent( 27 );
			AddComponent( ac, -5, 2, 7 );
			ac = new AddonComponent( 35 );
			ac.Light = LightType.ArchedWindowEast;
			AddComponent( ac, -5, 3, 7 );
			ac = new AddonComponent( 27 );
			AddComponent( ac, -5, 4, 7 );
			ac = new AddonComponent( 1239 );
			AddComponent( ac, -4, -1, 7 );
			ac = new AddonComponent( 1238 );
			AddComponent( ac, -4, 0, 7 );
			ac = new AddonComponent( 1238 );
			AddComponent( ac, -4, 1, 7 );
			ac = new AddonComponent( 1238 );
			AddComponent( ac, -4, 2, 7 );
			ac = new AddonComponent( 1237 );
			AddComponent( ac, -4, 3, 7 );
			ac = new AddonComponent( 1236 );
			AddComponent( ac, -4, 4, 7 );
			ac = new AddonComponent( 1237 );
			AddComponent( ac, -3, -1, 7 );
			ac = new AddonComponent( 1239 );
			AddComponent( ac, -3, 0, 7 );
			ac = new AddonComponent( 1239 );
			AddComponent( ac, -3, 1, 7 );
			ac = new AddonComponent( 1236 );
			AddComponent( ac, -3, 2, 7 );
			ac = new AddonComponent( 1238 );
			AddComponent( ac, -3, 3, 7 );
			ac = new AddonComponent( 1236 );
			AddComponent( ac, -3, 4, 7 );
			ac = new AddonComponent( 1236 );
			AddComponent( ac, -2, -1, 7 );
			ac = new AddonComponent( 1239 );
			AddComponent( ac, -2, 0, 7 );
			ac = new AddonComponent( 1238 );
			AddComponent( ac, -2, 1, 7 );
			ac = new AddonComponent( 1237 );
			AddComponent( ac, -2, 2, 7 );
			ac = new AddonComponent( 1239 );
			AddComponent( ac, -2, 3, 7 );
			ac = new AddonComponent( 1239 );
			AddComponent( ac, -2, 4, 7 );
			ac = new AddonComponent( 1236 );
			AddComponent( ac, -1, -1, 7 );
			ac = new AddonComponent( 1239 );
			AddComponent( ac, -1, 0, 7 );
			ac = new AddonComponent( 1238 );
			AddComponent( ac, -1, 1, 7 );
			ac = new AddonComponent( 1239 );
			AddComponent( ac, -1, 2, 7 );
			ac = new AddonComponent( 1238 );
			AddComponent( ac, -1, 3, 7 );
			ac = new AddonComponent( 1237 );
			AddComponent( ac, -1, 4, 7 );
			ac = new AddonComponent( 1238 );
			AddComponent( ac, 0, -1, 7 );
			ac = new AddonComponent( 1238 );
			AddComponent( ac, 0, 0, 7 );
			ac = new AddonComponent( 1236 );
			AddComponent( ac, 0, 1, 7 );
			ac = new AddonComponent( 1236 );
			AddComponent( ac, 0, 2, 7 );
			ac = new AddonComponent( 1239 );
			AddComponent( ac, 0, 3, 7 );
			ac = new AddonComponent( 1238 );
			AddComponent( ac, 0, 4, 7 );
			ac = new AddonComponent( 1239 );
			AddComponent( ac, 1, -1, 7 );
			ac = new AddonComponent( 1238 );
			AddComponent( ac, 1, 0, 7 );
			ac = new AddonComponent( 1236 );
			AddComponent( ac, 1, 1, 7 );
			ac = new AddonComponent( 1239 );
			AddComponent( ac, 1, 2, 7 );
			ac = new AddonComponent( 1239 );
			AddComponent( ac, 1, 3, 7 );
			ac = new AddonComponent( 1238 );
			AddComponent( ac, 1, 4, 7 );
			ac = new AddonComponent( 1239 );
			AddComponent( ac, 2, -1, 7 );
			ac = new AddonComponent( 1237 );
			AddComponent( ac, 2, 0, 7 );
			ac = new AddonComponent( 1239 );
			AddComponent( ac, 2, 1, 7 );
			ac = new AddonComponent( 1239 );
			AddComponent( ac, 2, 2, 7 );
			ac = new AddonComponent( 1238 );
			AddComponent( ac, 2, 3, 7 );
			ac = new AddonComponent( 1238 );
			AddComponent( ac, 2, 4, 7 );
			ac = new AddonComponent( 1236 );
			AddComponent( ac, 3, -1, 7 );
			ac = new AddonComponent( 1238 );
			AddComponent( ac, 3, 0, 7 );
			ac = new AddonComponent( 1237 );
			AddComponent( ac, 3, 1, 7 );
			ac = new AddonComponent( 1238 );
			AddComponent( ac, 3, 2, 7 );
			ac = new AddonComponent( 1239 );
			AddComponent( ac, 3, 3, 7 );
			ac = new AddonComponent( 1237 );
			AddComponent( ac, 3, 4, 7 );
			ac = new AddonComponent( 1237 );
			AddComponent( ac, 4, -1, 7 );
			ac = new AddonComponent( 1236 );
			AddComponent( ac, 4, 0, 7 );
			ac = new AddonComponent( 1236 );
			AddComponent( ac, 4, 1, 7 );
			ac = new AddonComponent( 1236 );
			AddComponent( ac, 4, 2, 7 );
			ac = new AddonComponent( 1237 );
			AddComponent( ac, 4, 3, 7 );
			ac = new AddonComponent( 1236 );
			AddComponent( ac, 4, 4, 7 );
			ac = new AddonComponent( 33 );
			AddComponent( ac, -4, 4, 7 );
			ac = new AddonComponent( 30 );
			AddComponent( ac, -1, 4, 7 );
			ac = new AddonComponent( 28 );
			AddComponent( ac, 0, 4, 7 );
			ac = new AddonComponent( 34 );
			ac.Light = LightType.ArchedWindowEast;
			AddComponent( ac, 1, 4, 7 );
			ac = new AddonComponent( 28 );
			AddComponent( ac, 2, 4, 7 );
			ac = new AddonComponent( 28 );
			AddComponent( ac, 3, 4, 7 );
			ac = new AddonComponent( 27 );
			AddComponent( ac, 4, -1, 7 );
			ac = new AddonComponent( 35 );
			ac.Light = LightType.ArchedWindowEast;
			AddComponent( ac, 4, 0, 7 );
			ac = new AddonComponent( 27 );
			AddComponent( ac, 4, 1, 7 );
			ac = new AddonComponent( 27 );
			AddComponent( ac, 4, 2, 7 );
			ac = new AddonComponent( 35 );
			ac.Light = LightType.ArchedWindowEast;
			AddComponent( ac, 4, 3, 7 );
			ac = new AddonComponent( 26 );
			AddComponent( ac, 4, 4, 7 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -4, 5, 27 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 5, 5, 27 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -3, -1, 30 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -3, 0, 30 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -3, 1, 30 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -3, 2, 30 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -3, 3, 30 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -3, 4, 30 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -3, 5, 30 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -2, -1, 33 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -2, 0, 33 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -2, 1, 33 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -2, 2, 33 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -2, 3, 33 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -2, 4, 33 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -2, 5, 33 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -1, -1, 36 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -1, 0, 36 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -1, 1, 36 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -1, 2, 36 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -1, 3, 36 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -1, 4, 36 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -1, 5, 36 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, 0, -1, 39 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, 0, 0, 39 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, 0, 1, 39 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, 0, 2, 39 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, 0, 3, 39 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, 0, 4, 39 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, 0, 5, 39 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 1, -1, 39 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 1, 0, 39 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 1, 1, 39 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 1, 2, 39 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 1, 3, 39 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 1, 4, 39 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 1, 5, 39 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 2, -1, 36 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 2, 0, 36 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 2, 1, 36 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 2, 2, 36 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 2, 3, 36 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 2, 4, 36 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 2, 5, 36 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 3, -1, 33 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 3, 0, 33 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 3, 1, 33 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 3, 2, 33 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 3, 3, 33 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 3, 4, 33 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 3, 5, 33 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 4, -1, 30 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 4, 0, 30 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 4, 1, 30 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 4, 2, 30 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 4, 3, 30 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 4, 4, 30 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 4, 5, 30 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -4, -1, 27 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -4, 0, 27 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -4, 1, 27 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -4, 2, 27 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -4, 3, 27 );
			ac = new AddonComponent( 1461 );
			AddComponent( ac, -4, 4, 27 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 5, -1, 27 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 5, 0, 27 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 5, 1, 27 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 5, 2, 27 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 5, 3, 27 );
			ac = new AddonComponent( 1460 );
			AddComponent( ac, 5, 4, 27 );
			ac = new AddonComponent( 24 );
			AddComponent( ac, -3, 4, 27 );
			ac = new AddonComponent( 24 );
			AddComponent( ac, -2, 4, 27 );
			ac = new AddonComponent( 24 );
			AddComponent( ac, -1, 4, 27 );
			ac = new AddonComponent( 24 );
			AddComponent( ac, 0, 4, 27 );
			ac = new AddonComponent( 24 );
			AddComponent( ac, 1, 4, 27 );
			ac = new AddonComponent( 24 );
			AddComponent( ac, 2, 4, 27 );
			ac = new AddonComponent( 24 );
			AddComponent( ac, -1, 4, 30 );
			ac = new AddonComponent( 24 );
			AddComponent( ac, 0, 4, 30 );

		}

		public FieldstoneCityHealerAddon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	
}
