
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class TownhouseNS2Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1216, -3, -5, 7}, {6013, -3, 2, 7}, {6013, -3, 4, 7}// 5	7	8	
			, {6013, -3, 3, 7}, {6013, -3, 1, 7}, {6013, -3, 0, 7}// 9	10	11	
			, {2141, -3, 5, 7}, {1214, -3, 1, 7}, {1209, -3, -2, 7}// 12	13	14	
			, {1209, -3, -1, 7}, {1209, -3, 0, 7}, {66, -3, 5, 1}// 15	16	22	
			, {1209, -3, -3, 7}, {1209, -3, -4, 7}, {6013, -3, 5, 7}// 26	27	28	
			, {1215, 1, -5, 7}, {1212, 2, -5, 7}, {1215, 5, -5, 7}// 36	37	38	
			, {67, 5, -5, 1}, {66, 5, -6, 1}, {1212, 0, -5, 7}// 55	56	60	
			, {1212, -1, -5, 7}, {1212, -2, -5, 7}, {1213, 5, 5, 7}// 61	68	71	
			, {1214, 1, 5, 7}, {1215, 4, -2, 7}, {1211, 5, -1, 7}// 72	73	74	
			, {1211, 5, 0, 7}, {1211, 5, 1, 7}, {1211, 5, 2, 7}// 75	76	77	
			, {1211, 5, 3, 7}, {1211, 5, 4, 7}, {1210, 2, 5, 7}// 78	79	80	
			, {1210, 3, 5, 7}, {1210, 4, 5, 7}, {1209, 1, 2, 7}// 81	82	83	
			, {1209, 1, 3, 7}, {1209, 1, 4, 7}, {1207, 0, -2, 7}// 84	85	86	
			, {1207, 0, -1, 7}, {1207, 0, 0, 7}, {1207, 1, -2, 7}// 87	88	89	
			, {1207, 1, -1, 7}, {1207, 1, 0, 7}, {1207, 2, -3, 7}// 90	91	92	
			, {1207, 3, -1, 7}, {1207, 3, 0, 7}, {1207, 3, 1, 7}// 93	94	95	
			, {1207, 2, 1, 7}, {1207, 3, 3, 7}, {1207, 3, 4, 7}// 96	97	98	
			, {1207, 4, -1, 7}, {1207, 4, 0, 7}, {1207, 4, 1, 7}// 99	100	101	
			, {1207, 4, 2, 7}, {1207, 4, 3, 7}, {1207, 4, 4, 7}// 102	103	104	
			, {1207, 1, 1, 7}, {1207, 2, 0, 7}, {1207, 2, 2, 7}// 105	106	107	
			, {1207, 2, 3, 7}, {1207, 1, 4, 7}, {1208, 2, -2, 7}// 108	109	110	
			, {1208, 3, 2, 7}, {1208, 2, 4, 7}, {1208, 3, -3, 7}// 111	112	113	
			, {1208, 2, -1, 7}, {2213, 4, -1, 26}, {66, 1, 5, 1}// 114	183	184	
			, {66, 2, 5, 1}, {66, 3, 5, 1}, {66, 4, 5, 1}// 185	186	187	
			, {66, 5, 5, 1}, {67, 5, -2, 1}, {67, 5, -1, 1}// 188	189	190	
			, {67, 5, 0, 1}, {67, 5, 1, 1}, {67, 5, 2, 1}// 191	192	193	
			, {67, 5, 3, 1}, {67, 5, 4, 1}, {67, 5, 5, 1}// 194	195	196	
			, {66, 0, 5, 1}, {1211, 5, -2, 7}, {1207, -1, -1, 7}// 201	203	212	
			, {1208, -1, -2, 7}, {1207, -2, -2, 7}, {1207, -2, -1, 7}// 213	214	215	
			, {1207, -1, 0, 7}, {1210, 0, 1, 7}, {1210, -1, 1, 7}// 216	217	218	
			, {1207, -2, 0, 7}, {1210, -2, 1, 7}, {1302, -1, 2, 7}// 224	226	231	
			, {1302, -2, 2, 7}, {2141, 0, 5, 7}, {2167, -1, 5, 7}// 232	233	234	
			, {66, -1, 5, 1}, {66, -2, 5, 1}, {1302, -2, 3, 7}// 237	239	240	
			, {1302, -2, 4, 7}, {1302, -2, 5, 7}, {1207, 3, -2, 7}// 241	242	243	
			, {1211, 5, -3, 7}, {1211, 4, -3, 7}, {67, 5, -3, 1}// 245	247	249	
			, {1211, 5, -4, 7}, {1215, 3, -4, 7}, {67, 5, -4, 1}// 251	253	256	
			, {1207, 2, -4, 7}, {1207, 1, -3, 7}, {1207, 1, -4, 7}// 260	261	262	
			, {1207, 0, -3, 7}, {1207, 0, -4, 7}, {1207, -2, -3, 7}// 272	273	274	
			, {1207, -1, -3, 7}, {1207, -2, -4, 7}, {1208, -1, -4, 7}// 275	278	279	
			, {6013, -1, 3, 7}, {6013, 0, 4, 8}, {6013, -1, 4, 7}// 287	288	289	
			, {6013, 0, 5, 7}, {6013, -1, 5, 7}// 290	291	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new TownhouseNS2AddonDeed();
			}
		}

		[ Constructable ]
		public TownhouseNS2Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 517, -3, -6, 7, 1023, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 514, -4, -6, 7, 1023, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 1307, -3, -5, 26, 1023, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 960, -3, -6, 26, 1023, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 1848, -3, 6, 0, 1023, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 512, -3, 1, 7, 1023, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 1307, -3, 1, 26, 1023, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 1307, -3, -2, 26, 1023, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 1307, -3, 0, 26, 1023, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 1307, -3, -1, 26, 1023, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 960, -3, 1, 26, 1023, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 1307, -3, -3, 26, 1023, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 1307, -3, -4, 26, 1023, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 1872, 4, -5, 7, 1036, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 1872, 3, -5, 7, 1036, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 1872, 4, -5, 12, 1036, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 1872, 3, -5, 12, 1036, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 1874, 3, -5, 17, 1036, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 1874, 2, -5, 22, 1036, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 1872, 2, -5, 7, 1036, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 518, 5, -5, 7, 1023, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 512, 5, -6, 7, 1023, -1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 515, 4, -6, 7, 1023, -1, "", 1);// 41
			AddComplexComponent( (BaseAddon) this, 517, 3, -6, 7, 1023, -1, "", 1);// 42
			AddComplexComponent( (BaseAddon) this, 512, 2, -6, 7, 1023, -1, "", 1);// 43
			AddComplexComponent( (BaseAddon) this, 521, 1, -6, 7, 1023, 1, "", 1);// 44
			AddComplexComponent( (BaseAddon) this, 1307, 0, -5, 26, 1023, -1, "", 1);// 45
			AddComplexComponent( (BaseAddon) this, 1307, 1, -5, 26, 1023, -1, "", 1);// 46
			AddComplexComponent( (BaseAddon) this, 968, 3, -6, 26, 1023, -1, "", 1);// 47
			AddComplexComponent( (BaseAddon) this, 968, 4, -6, 26, 1023, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 968, 5, -6, 26, 1023, -1, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 969, 5, -5, 26, 1023, -1, "", 1);// 50
			AddComplexComponent( (BaseAddon) this, 1330, 5, -5, 47, 1036, -1, "", 1);// 51
			AddComplexComponent( (BaseAddon) this, 1330, 4, -5, 47, 1036, -1, "", 1);// 52
			AddComplexComponent( (BaseAddon) this, 1330, 3, -5, 47, 1036, -1, "", 1);// 53
			AddComplexComponent( (BaseAddon) this, 960, 2, -6, 26, 1023, -1, "", 1);// 54
			AddComplexComponent( (BaseAddon) this, 517, 0, -6, 7, 1023, -1, "", 1);// 57
			AddComplexComponent( (BaseAddon) this, 512, -1, -6, 7, 1023, -1, "", 1);// 58
			AddComplexComponent( (BaseAddon) this, 519, -2, -6, 7, 1023, 1, "", 1);// 59
			AddComplexComponent( (BaseAddon) this, 1307, -1, -5, 26, 1023, -1, "", 1);// 62
			AddComplexComponent( (BaseAddon) this, 960, 1, -6, 26, 1023, -1, "", 1);// 63
			AddComplexComponent( (BaseAddon) this, 960, 0, -6, 26, 1023, -1, "", 1);// 64
			AddComplexComponent( (BaseAddon) this, 1307, -2, -5, 26, 1023, -1, "", 1);// 65
			AddComplexComponent( (BaseAddon) this, 960, -1, -6, 26, 1023, -1, "", 1);// 66
			AddComplexComponent( (BaseAddon) this, 960, -2, -6, 26, 1023, -1, "", 1);// 67
			AddComplexComponent( (BaseAddon) this, 1872, 2, -5, 17, 1036, -1, "", 1);// 69
			AddComplexComponent( (BaseAddon) this, 1872, 2, -5, 12, 1036, -1, "", 1);// 70
			AddComplexComponent( (BaseAddon) this, 517, 1, 5, 7, 1023, -1, "", 1);// 115
			AddComplexComponent( (BaseAddon) this, 519, 2, 5, 7, 1023, 1, "", 1);// 116
			AddComplexComponent( (BaseAddon) this, 519, 4, 5, 7, 1023, 1, "", 1);// 117
			AddComplexComponent( (BaseAddon) this, 515, 3, 5, 7, 1023, -1, "", 1);// 118
			AddComplexComponent( (BaseAddon) this, 512, 5, 5, 7, 1023, -1, "", 1);// 119
			AddComplexComponent( (BaseAddon) this, 513, 5, 5, 7, 1023, -1, "", 1);// 120
			AddComplexComponent( (BaseAddon) this, 513, 5, 3, 7, 1023, -1, "", 1);// 121
			AddComplexComponent( (BaseAddon) this, 518, 5, 4, 7, 1023, -1, "", 1);// 122
			AddComplexComponent( (BaseAddon) this, 522, 5, 2, 7, 1023, 1, "", 1);// 123
			AddComplexComponent( (BaseAddon) this, 518, 5, 1, 7, 1023, -1, "", 1);// 124
			AddComplexComponent( (BaseAddon) this, 513, 5, 0, 7, 1023, -1, "", 1);// 125
			AddComplexComponent( (BaseAddon) this, 522, 5, -1, 7, 1023, 1, "", 1);// 126
			AddComplexComponent( (BaseAddon) this, 518, 5, -2, 7, 1023, -1, "", 1);// 127
			AddComplexComponent( (BaseAddon) this, 1307, 1, 4, 26, 1023, -1, "", 1);// 128
			AddComplexComponent( (BaseAddon) this, 1307, 2, 5, 26, 1023, -1, "", 1);// 129
			AddComplexComponent( (BaseAddon) this, 1307, 2, 2, 26, 1023, -1, "", 1);// 130
			AddComplexComponent( (BaseAddon) this, 1307, 3, 3, 26, 1023, -1, "", 1);// 131
			AddComplexComponent( (BaseAddon) this, 1307, 2, 4, 26, 1023, -1, "", 1);// 132
			AddComplexComponent( (BaseAddon) this, 1307, 1, 5, 26, 1023, -1, "", 1);// 133
			AddComplexComponent( (BaseAddon) this, 1307, 3, 2, 26, 1023, -1, "", 1);// 134
			AddComplexComponent( (BaseAddon) this, 1307, 2, 3, 26, 1023, -1, "", 1);// 135
			AddComplexComponent( (BaseAddon) this, 1307, 3, 4, 26, 1023, -1, "", 1);// 136
			AddComplexComponent( (BaseAddon) this, 1307, 3, 5, 26, 1023, -1, "", 1);// 137
			AddComplexComponent( (BaseAddon) this, 1307, 4, 2, 26, 1023, -1, "", 1);// 138
			AddComplexComponent( (BaseAddon) this, 1307, 4, 3, 26, 1023, -1, "", 1);// 139
			AddComplexComponent( (BaseAddon) this, 1307, 4, 4, 26, 1023, -1, "", 1);// 140
			AddComplexComponent( (BaseAddon) this, 1307, 4, 5, 26, 1023, -1, "", 1);// 141
			AddComplexComponent( (BaseAddon) this, 1307, 5, 1, 26, 1023, -1, "", 1);// 142
			AddComplexComponent( (BaseAddon) this, 1307, 5, 2, 26, 1023, -1, "", 1);// 143
			AddComplexComponent( (BaseAddon) this, 1307, 5, 4, 26, 1023, -1, "", 1);// 144
			AddComplexComponent( (BaseAddon) this, 1307, 5, 5, 26, 1023, -1, "", 1);// 145
			AddComplexComponent( (BaseAddon) this, 1307, 3, -4, 26, 1023, -1, "", 1);// 146
			AddComplexComponent( (BaseAddon) this, 1307, 3, 1, 26, 1023, -1, "", 1);// 147
			AddComplexComponent( (BaseAddon) this, 1307, 4, -1, 26, 1023, -1, "", 1);// 148
			AddComplexComponent( (BaseAddon) this, 1307, 4, 1, 26, 1023, -1, "", 1);// 149
			AddComplexComponent( (BaseAddon) this, 1307, 5, -2, 26, 1023, -1, "", 1);// 150
			AddComplexComponent( (BaseAddon) this, 1307, 5, 0, 26, 1023, -1, "", 1);// 151
			AddComplexComponent( (BaseAddon) this, 1307, 5, -1, 26, 1023, -1, "", 1);// 152
			AddComplexComponent( (BaseAddon) this, 1307, 1, 1, 26, 1023, -1, "", 1);// 153
			AddComplexComponent( (BaseAddon) this, 1307, 4, 0, 26, 1023, -1, "", 1);// 154
			AddComplexComponent( (BaseAddon) this, 1307, 3, 0, 26, 1023, -1, "", 1);// 155
			AddComplexComponent( (BaseAddon) this, 1307, 2, 1, 26, 1023, -1, "", 1);// 156
			AddComplexComponent( (BaseAddon) this, 1307, 2, 0, 26, 1023, -1, "", 1);// 157
			AddComplexComponent( (BaseAddon) this, 1307, 1, 0, 26, 1023, -1, "", 1);// 158
			AddComplexComponent( (BaseAddon) this, 1307, 2, -2, 26, 1023, -1, "", 1);// 159
			AddComplexComponent( (BaseAddon) this, 1307, 3, -1, 26, 1023, -1, "", 1);// 160
			AddComplexComponent( (BaseAddon) this, 1307, 2, -1, 26, 1023, -1, "", 1);// 161
			AddComplexComponent( (BaseAddon) this, 1307, 1, -1, 26, 1023, -1, "", 1);// 162
			AddComplexComponent( (BaseAddon) this, 1307, 0, -2, 26, 1023, -1, "", 1);// 163
			AddComplexComponent( (BaseAddon) this, 1307, -1, -2, 26, 1023, -1, "", 1);// 164
			AddComplexComponent( (BaseAddon) this, 958, 5, 5, 26, 1023, -1, "", 1);// 165
			AddComplexComponent( (BaseAddon) this, 960, 1, 5, 26, 1023, -1, "", 1);// 166
			AddComplexComponent( (BaseAddon) this, 960, 2, 5, 26, 1023, -1, "", 1);// 167
			AddComplexComponent( (BaseAddon) this, 960, 3, 5, 26, 1023, -1, "", 1);// 168
			AddComplexComponent( (BaseAddon) this, 960, 4, 5, 26, 1023, -1, "", 1);// 169
			AddComplexComponent( (BaseAddon) this, 961, 5, -1, 26, 1023, -1, "", 1);// 170
			AddComplexComponent( (BaseAddon) this, 961, 5, 0, 26, 1023, -1, "", 1);// 171
			AddComplexComponent( (BaseAddon) this, 961, 5, 1, 26, 1023, -1, "", 1);// 172
			AddComplexComponent( (BaseAddon) this, 961, 5, 2, 26, 1023, -1, "", 1);// 173
			AddComplexComponent( (BaseAddon) this, 961, 5, 3, 26, 1023, -1, "", 1);// 174
			AddComplexComponent( (BaseAddon) this, 961, 5, 4, 26, 1023, -1, "", 1);// 175
			AddComplexComponent( (BaseAddon) this, 1307, 1, -2, 26, 1023, -1, "", 1);// 176
			AddComplexComponent( (BaseAddon) this, 968, 4, -2, 26, 1023, -1, "", 1);// 177
			AddComplexComponent( (BaseAddon) this, 968, 5, -2, 26, 1023, -1, "", 1);// 178
			AddComplexComponent( (BaseAddon) this, 1330, 4, -2, 47, 1036, -1, "", 1);// 179
			AddComplexComponent( (BaseAddon) this, 1330, 5, -2, 47, 1036, -1, "", 1);// 180
			AddComplexComponent( (BaseAddon) this, 969, 5, -2, 26, 1023, -1, "", 1);// 181
			AddComplexComponent( (BaseAddon) this, 969, 3, -2, 26, 1023, -1, "", 1);// 182
			AddComplexComponent( (BaseAddon) this, 961, 0, 5, 26, 1023, -1, "", 1);// 197
			AddComplexComponent( (BaseAddon) this, 961, 0, 4, 26, 1023, -1, "", 1);// 198
			AddComplexComponent( (BaseAddon) this, 961, 0, 3, 26, 1023, -1, "", 1);// 199
			AddComplexComponent( (BaseAddon) this, 960, 0, 1, 26, 1023, -1, "", 1);// 200
			AddComplexComponent( (BaseAddon) this, 513, 0, 5, 7, 1023, -1, "", 1);// 202
			AddComplexComponent( (BaseAddon) this, 960, -1, 1, 26, 1023, -1, "", 1);// 204
			AddComplexComponent( (BaseAddon) this, 1307, 0, 1, 26, 1023, -1, "", 1);// 205
			AddComplexComponent( (BaseAddon) this, 1307, -1, 1, 26, 1023, -1, "", 1);// 206
			AddComplexComponent( (BaseAddon) this, 1307, 0, 0, 26, 1023, -1, "", 1);// 207
			AddComplexComponent( (BaseAddon) this, 1307, -2, 0, 26, 1023, -1, "", 1);// 208
			AddComplexComponent( (BaseAddon) this, 1307, 0, -1, 26, 1023, -1, "", 1);// 209
			AddComplexComponent( (BaseAddon) this, 1307, -1, -1, 26, 1023, -1, "", 1);// 210
			AddComplexComponent( (BaseAddon) this, 1307, -2, -2, 26, 1023, -1, "", 1);// 211
			AddComplexComponent( (BaseAddon) this, 1307, -2, 1, 26, 1023, -1, "", 1);// 219
			AddComplexComponent( (BaseAddon) this, 1307, -1, 0, 26, 1023, -1, "", 1);// 220
			AddComplexComponent( (BaseAddon) this, 1307, -2, -1, 26, 1023, -1, "", 1);// 221
			AddComplexComponent( (BaseAddon) this, 1307, 1, 3, 26, 1023, -1, "", 1);// 222
			AddComplexComponent( (BaseAddon) this, 1307, 1, 2, 26, 1023, -1, "", 1);// 223
			AddComplexComponent( (BaseAddon) this, 960, -2, 1, 26, 1023, -1, "", 1);// 225
			AddComplexComponent( (BaseAddon) this, 522, 0, 4, 7, 1023, 1, "", 1);// 227
			AddComplexComponent( (BaseAddon) this, 518, 0, 3, 7, 1023, -1, "", 1);// 228
			AddComplexComponent( (BaseAddon) this, 513, 0, 2, 7, 1023, -1, "", 1);// 229
			AddComplexComponent( (BaseAddon) this, 517, 0, 1, 7, 1023, -1, "", 1);// 230
			AddComplexComponent( (BaseAddon) this, 1848, -1, 6, 0, 1023, -1, "", 1);// 235
			AddComplexComponent( (BaseAddon) this, 961, 0, 2, 26, 1023, -1, "", 1);// 236
			AddComplexComponent( (BaseAddon) this, 1849, -2, 6, 0, 1023, -1, "", 1);// 238
			AddComplexComponent( (BaseAddon) this, 1307, 4, -2, 7, 1023, -1, "", 1);// 244
			AddComplexComponent( (BaseAddon) this, 1873, 4, -3, 7, 1036, -1, "", 1);// 246
			AddComplexComponent( (BaseAddon) this, 1307, 4, -2, 26, 1023, -1, "", 1);// 248
			AddComplexComponent( (BaseAddon) this, 513, 5, -3, 7, 1023, -1, "", 1);// 250
			AddComplexComponent( (BaseAddon) this, 1872, 4, -4, 7, 1036, -1, "", 1);// 252
			AddComplexComponent( (BaseAddon) this, 969, 5, -3, 26, 1023, -1, "", 1);// 254
			AddComplexComponent( (BaseAddon) this, 1873, 4, -4, 12, 1036, -1, "", 1);// 255
			AddComplexComponent( (BaseAddon) this, 1330, 5, -3, 47, 1036, -1, "", 1);// 257
			AddComplexComponent( (BaseAddon) this, 1330, 4, -3, 47, 1036, -1, "", 1);// 258
			AddComplexComponent( (BaseAddon) this, 969, 3, -3, 26, 1023, -1, "", 1);// 259
			AddComplexComponent( (BaseAddon) this, 1307, -2, -3, 26, 1023, -1, "", 1);// 263
			AddComplexComponent( (BaseAddon) this, 1307, -1, -3, 26, 1023, -1, "", 1);// 264
			AddComplexComponent( (BaseAddon) this, 1307, 0, -3, 26, 1023, -1, "", 1);// 265
			AddComplexComponent( (BaseAddon) this, 1307, 1, -3, 26, 1023, -1, "", 1);// 266
			AddComplexComponent( (BaseAddon) this, 1307, -2, -4, 26, 1023, -1, "", 1);// 267
			AddComplexComponent( (BaseAddon) this, 1307, -1, -4, 26, 1023, -1, "", 1);// 268
			AddComplexComponent( (BaseAddon) this, 1307, 0, -4, 26, 1023, -1, "", 1);// 269
			AddComplexComponent( (BaseAddon) this, 1307, 1, -4, 26, 1023, -1, "", 1);// 270
			AddComplexComponent( (BaseAddon) this, 1307, 2, -3, 26, 1023, -1, "", 1);// 271
			AddComplexComponent( (BaseAddon) this, 1307, 3, -3, 26, 1023, -1, "", 1);// 276
			AddComplexComponent( (BaseAddon) this, 1307, 3, -2, 26, 1023, -1, "", 1);// 277
			AddComplexComponent( (BaseAddon) this, 516, 5, -4, 7, 1023, -1, "", 1);// 280
			AddComplexComponent( (BaseAddon) this, 969, 5, -4, 26, 1023, -1, "", 1);// 281
			AddComplexComponent( (BaseAddon) this, 968, 3, -4, 26, 1023, -1, "", 1);// 282
			AddComplexComponent( (BaseAddon) this, 969, 2, -4, 26, 1023, -1, "", 1);// 283
			AddComplexComponent( (BaseAddon) this, 1330, 5, -4, 47, 1036, -1, "", 1);// 284
			AddComplexComponent( (BaseAddon) this, 1330, 4, -4, 47, 1036, -1, "", 1);// 285
			AddComplexComponent( (BaseAddon) this, 1330, 3, -4, 47, 1036, -1, "", 1);// 286

		}

		public TownhouseNS2Addon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
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

	public class TownhouseNS2AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new TownhouseNS2Addon();
			}
		}

		[Constructable]
		public TownhouseNS2AddonDeed()
		{
			Name = "TownhouseNS2";
		}

		public TownhouseNS2AddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}