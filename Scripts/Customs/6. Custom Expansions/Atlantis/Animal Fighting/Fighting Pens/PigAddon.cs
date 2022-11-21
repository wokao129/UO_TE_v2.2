
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
	public class PigAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {12907, -4, -4, 1}// 10	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new PigAddonDeed();
			}
		}

		[ Constructable ]
		public PigAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 12907, 5, -3, 1, 2944, -1, "Pig Sty", 1);// 1
			AddComplexComponent( (BaseAddon) this, 12907, 5, 2, 1, 2944, -1, "Pig Sty", 1);// 2
			AddComplexComponent( (BaseAddon) this, 12907, 5, 1, 1, 2944, -1, "Pig Sty", 1);// 3
			AddComplexComponent( (BaseAddon) this, 12907, 5, -1, 1, 2944, -1, "Pig Sty", 1);// 4
			AddComplexComponent( (BaseAddon) this, 12907, 5, 0, 1, 2944, -1, "Pig Sty", 1);// 5
			AddComplexComponent( (BaseAddon) this, 12907, 5, -2, 1, 2944, -1, "Pig Sty", 1);// 6
			AddComplexComponent( (BaseAddon) this, 12906, -5, 1, 1, 2944, -1, "Pig Sty", 1);// 7
			AddComplexComponent( (BaseAddon) this, 12906, -5, 2, 1, 2944, -1, "Pig Sty", 1);// 8
			AddComplexComponent( (BaseAddon) this, 12906, -5, 3, 1, 2944, -1, "Pig Sty", 1);// 9
			AddComplexComponent( (BaseAddon) this, 12907, -4, 1, 1, 2944, -1, "Pig Sty", 1);// 11
			AddComplexComponent( (BaseAddon) this, 12907, -4, 2, 1, 2944, -1, "Pig Sty", 1);// 12
			AddComplexComponent( (BaseAddon) this, 12907, -4, 3, 1, 2944, -1, "Pig Sty", 1);// 13
			AddComplexComponent( (BaseAddon) this, 12907, -4, 5, 1, 2944, -1, "Pig Sty", 1);// 14
			AddComplexComponent( (BaseAddon) this, 12908, -3, 0, 1, 2944, -1, "Pig Sty", 1);// 15
			AddComplexComponent( (BaseAddon) this, 12908, -3, 1, 1, 2944, -1, "Pig Sty", 1);// 16
			AddComplexComponent( (BaseAddon) this, 12908, -3, 2, 1, 2944, -1, "Pig Sty", 1);// 17
			AddComplexComponent( (BaseAddon) this, 12908, -3, 3, 1, 2944, -1, "Pig Sty", 1);// 18
			AddComplexComponent( (BaseAddon) this, 12908, -3, 4, 1, 2944, -1, "Pig Sty", 1);// 19
			AddComplexComponent( (BaseAddon) this, 12908, -3, 5, 1, 2944, -1, "Pig Sty", 1);// 20
			AddComplexComponent( (BaseAddon) this, 12909, -2, 2, 1, 2944, -1, "Pig Sty", 1);// 21
			AddComplexComponent( (BaseAddon) this, 12909, -2, 3, 1, 2944, -1, "Pig Sty", 1);// 22
			AddComplexComponent( (BaseAddon) this, 12909, -2, 4, 1, 2944, -1, "Pig Sty", 1);// 23
			AddComplexComponent( (BaseAddon) this, 12909, -2, 5, 1, 2944, -1, "Pig Sty", 1);// 24
			AddComplexComponent( (BaseAddon) this, 12910, -1, -4, 1, 2944, -1, "Pig Sty", 1);// 25
			AddComplexComponent( (BaseAddon) this, 12910, -1, -3, 1, 2944, -1, "Pig Sty", 1);// 26
			AddComplexComponent( (BaseAddon) this, 12910, -1, -2, 1, 2944, -1, "Pig Sty", 1);// 27
			AddComplexComponent( (BaseAddon) this, 12910, -1, -1, 1, 2944, -1, "Pig Sty", 1);// 28
			AddComplexComponent( (BaseAddon) this, 12910, -1, 0, 1, 2944, -1, "Pig Sty", 1);// 29
			AddComplexComponent( (BaseAddon) this, 12910, -1, 1, 1, 2944, -1, "Pig Sty", 1);// 30
			AddComplexComponent( (BaseAddon) this, 12910, -1, 2, 1, 2944, -1, "Pig Sty", 1);// 31
			AddComplexComponent( (BaseAddon) this, 12910, -1, 3, 1, 2944, -1, "Pig Sty", 1);// 32
			AddComplexComponent( (BaseAddon) this, 12910, -1, 4, 1, 2944, -1, "Pig Sty", 1);// 33
			AddComplexComponent( (BaseAddon) this, 12911, 0, -4, 1, 2944, -1, "Pig Sty", 1);// 34
			AddComplexComponent( (BaseAddon) this, 12911, 0, -2, 1, 2944, -1, "Pig Sty", 1);// 35
			AddComplexComponent( (BaseAddon) this, 12911, 0, -1, 1, 2944, -1, "Pig Sty", 1);// 36
			AddComplexComponent( (BaseAddon) this, 12911, 0, 0, 1, 2944, -1, "Pig Sty", 1);// 37
			AddComplexComponent( (BaseAddon) this, 12911, 0, 1, 1, 2944, -1, "Pig Sty", 1);// 38
			AddComplexComponent( (BaseAddon) this, 12911, 0, 2, 1, 2944, -1, "Pig Sty", 1);// 39
			AddComplexComponent( (BaseAddon) this, 12911, 0, 3, 1, 2944, -1, "Pig Sty", 1);// 40
			AddComplexComponent( (BaseAddon) this, 12911, 0, 5, 1, 2944, -1, "Pig Sty", 1);// 41
			AddComplexComponent( (BaseAddon) this, 12910, 1, -2, 1, 2944, -1, "Pig Sty", 1);// 42
			AddComplexComponent( (BaseAddon) this, 12910, 1, -1, 1, 2944, -1, "Pig Sty", 1);// 43
			AddComplexComponent( (BaseAddon) this, 12910, 1, 0, 1, 2944, -1, "Pig Sty", 1);// 44
			AddComplexComponent( (BaseAddon) this, 12910, 1, 1, 1, 2944, -1, "Pig Sty", 1);// 45
			AddComplexComponent( (BaseAddon) this, 12910, 1, 2, 1, 2944, -1, "Pig Sty", 1);// 46
			AddComplexComponent( (BaseAddon) this, 12910, 1, 3, 1, 2944, -1, "Pig Sty", 1);// 47
			AddComplexComponent( (BaseAddon) this, 12910, 1, 4, 1, 2944, -1, "Pig Sty", 1);// 48
			AddComplexComponent( (BaseAddon) this, 12909, 2, -3, 1, 2944, -1, "Pig Sty", 1);// 49
			AddComplexComponent( (BaseAddon) this, 12909, 2, -2, 1, 2944, -1, "Pig Sty", 1);// 50
			AddComplexComponent( (BaseAddon) this, 12909, 2, -1, 1, 2944, -1, "Pig Sty", 1);// 51
			AddComplexComponent( (BaseAddon) this, 12909, 2, 2, 1, 2944, -1, "Pig Sty", 1);// 52
			AddComplexComponent( (BaseAddon) this, 12909, 2, 3, 1, 2944, -1, "Pig Sty", 1);// 53
			AddComplexComponent( (BaseAddon) this, 12909, 2, 4, 1, 2944, -1, "Pig Sty", 1);// 54
			AddComplexComponent( (BaseAddon) this, 12908, 3, -3, 1, 2944, -1, "Pig Sty", 1);// 55
			AddComplexComponent( (BaseAddon) this, 12908, 3, -2, 1, 2944, -1, "Pig Sty", 1);// 56
			AddComplexComponent( (BaseAddon) this, 12908, 3, -1, 1, 2944, -1, "Pig Sty", 1);// 57
			AddComplexComponent( (BaseAddon) this, 12908, 3, 0, 1, 2944, -1, "Pig Sty", 1);// 58
			AddComplexComponent( (BaseAddon) this, 12908, 3, 1, 1, 2944, -1, "Pig Sty", 1);// 59
			AddComplexComponent( (BaseAddon) this, 12908, 3, 2, 1, 2944, -1, "Pig Sty", 1);// 60
			AddComplexComponent( (BaseAddon) this, 12908, 3, 3, 1, 2944, -1, "Pig Sty", 1);// 61
			AddComplexComponent( (BaseAddon) this, 12908, 3, 4, 1, 2944, -1, "Pig Sty", 1);// 62
			AddComplexComponent( (BaseAddon) this, 12908, 3, 5, 1, 2944, -1, "Pig Sty", 1);// 63
			AddComplexComponent( (BaseAddon) this, 12907, 4, -3, 1, 2944, -1, "Pig Sty", 1);// 64
			AddComplexComponent( (BaseAddon) this, 12907, 4, -2, 1, 2944, -1, "Pig Sty", 1);// 65
			AddComplexComponent( (BaseAddon) this, 12907, 4, -1, 1, 2944, -1, "Pig Sty", 1);// 66
			AddComplexComponent( (BaseAddon) this, 12907, 4, 0, 1, 2944, -1, "Pig Sty", 1);// 67
			AddComplexComponent( (BaseAddon) this, 12907, 4, 1, 1, 2944, -1, "Pig Sty", 1);// 68
			AddComplexComponent( (BaseAddon) this, 12907, 4, 2, 1, 2944, -1, "Pig Sty", 1);// 69
			AddComplexComponent( (BaseAddon) this, 12907, 4, 3, 1, 2944, -1, "Pig Sty", 1);// 70
			AddComplexComponent( (BaseAddon) this, 12907, 4, 4, 1, 2944, -1, "Pig Sty", 1);// 71
			AddComplexComponent( (BaseAddon) this, 12907, 4, 5, 1, 2944, -1, "Pig Sty", 1);// 72
			AddComplexComponent( (BaseAddon) this, 12809, -5, -4, 1, 2944, -1, "Pig Sty", 1);// 73
			AddComplexComponent( (BaseAddon) this, 12897, -4, -4, 1, 2944, -1, "Pig Sty", 1);// 74
			AddComplexComponent( (BaseAddon) this, 12898, -5, -3, 1, 2944, -1, "Pig Sty", 1);// 75
			AddComplexComponent( (BaseAddon) this, 12899, -5, -2, 1, 2944, -1, "Pig Sty", 1);// 76
			AddComplexComponent( (BaseAddon) this, 12903, -5, -1, 1, 2944, -1, "Pig Sty", 1);// 77
			AddComplexComponent( (BaseAddon) this, 12904, -3, -4, 1, 2944, -1, "Pig Sty", 1);// 78
			AddComplexComponent( (BaseAddon) this, 12899, -2, -4, 1, 2944, -1, "Pig Sty", 1);// 79
			AddComplexComponent( (BaseAddon) this, 12903, -2, -3, 1, 2944, -1, "Pig Sty", 1);// 80
			AddComplexComponent( (BaseAddon) this, 12902, -3, -3, 1, 2944, -1, "Pig Sty", 1);// 81
			AddComplexComponent( (BaseAddon) this, 12901, -2, -2, 1, 2944, -1, "Pig Sty", 1);// 82
			AddComplexComponent( (BaseAddon) this, 12899, -3, -2, 1, 2944, -1, "Pig Sty", 1);// 83
			AddComplexComponent( (BaseAddon) this, 12893, -3, -1, 1, 2944, -1, "Pig Sty", 1);// 84
			AddComplexComponent( (BaseAddon) this, 12891, -2, -1, 1, 2944, -1, "Pig Sty", 1);// 85
			AddComplexComponent( (BaseAddon) this, 12892, -5, 5, 1, 2944, -1, "Pig Sty", 1);// 86
			AddComplexComponent( (BaseAddon) this, 12894, 1, 5, 1, 2944, -1, "Pig Sty", 1);// 87
			AddComplexComponent( (BaseAddon) this, 12889, -2, 1, 1, 2944, -1, "Pig Sty", 1);// 88
			AddComplexComponent( (BaseAddon) this, 12888, 4, -4, 1, 2944, -1, "Pig Sty", 1);// 89
			AddComplexComponent( (BaseAddon) this, 12891, 5, -4, 1, 2944, -1, "Pig Sty", 1);// 90
			AddComplexComponent( (BaseAddon) this, 12893, 5, 5, 1, 2944, -1, "Pig Sty", 1);// 91
			AddComplexComponent( (BaseAddon) this, 12895, 2, 5, 1, 2944, -1, "Pig Sty", 1);// 92
			AddComplexComponent( (BaseAddon) this, 12896, -1, 5, 1, 2944, -1, "Pig Sty", 1);// 93
			AddComplexComponent( (BaseAddon) this, 12897, 2, -4, 1, 2944, -1, "Pig Sty", 1);// 94
			AddComplexComponent( (BaseAddon) this, 12900, 1, -4, 1, 2944, -1, "Pig Sty", 1);// 95
			AddComplexComponent( (BaseAddon) this, 12901, 5, 4, 1, 2944, -1, "Pig Sty", 1);// 96
			AddComplexComponent( (BaseAddon) this, 12891, 1, -3, 1, 2944, -1, "Pig Sty", 1);// 97
			AddComplexComponent( (BaseAddon) this, 12893, 0, -3, 1, 2944, -1, "Pig Sty", 1);// 98
			AddComplexComponent( (BaseAddon) this, 12896, 5, 3, 1, 2944, -1, "Pig Sty", 1);// 99
			AddComplexComponent( (BaseAddon) this, 12876, 0, 4, 1, 2944, -1, "Pig Sty", 1);// 100
			AddComplexComponent( (BaseAddon) this, 12877, -2, 0, 1, 2944, -1, "Pig Sty", 1);// 101
			AddComplexComponent( (BaseAddon) this, 12878, 2, 1, 1, 2944, -1, "Pig Sty", 1);// 102
			AddComplexComponent( (BaseAddon) this, 12880, -4, 4, 1, 2944, -1, "Pig Sty", 1);// 103
			AddComplexComponent( (BaseAddon) this, 12881, -5, 4, 1, 2944, -1, "Pig Sty", 1);// 104
			AddComplexComponent( (BaseAddon) this, 12879, 2, 0, 1, 2944, -1, "Pig Sty", 1);// 105
			AddComplexComponent( (BaseAddon) this, 12884, -1, -3, 1, 2944, -1, "Pig Sty", 1);// 106
			AddComplexComponent( (BaseAddon) this, 12886, 0, -4, 1, 2944, -1, "Pig Sty", 1);// 107
			AddComplexComponent( (BaseAddon) this, 12890, -4, -3, 1, 2944, -1, "Pig Sty", 1);// 108
			AddComplexComponent( (BaseAddon) this, 12893, -4, -2, 1, 2944, -1, "Pig Sty", 1);// 109
			AddComplexComponent( (BaseAddon) this, 12875, -5, 0, 1, 2944, -1, "Pig Sty", 1);// 110
			AddComplexComponent( (BaseAddon) this, 12888, 3, -4, 1, 2944, -1, "Pig Sty", 1);// 111
			AddComplexComponent( (BaseAddon) this, 12892, -4, -1, 1, 2944, -1, "Pig Sty", 1);// 112
			AddComplexComponent( (BaseAddon) this, 12891, -4, 0, 1, 2944, -1, "Pig Sty", 1);// 113
			AddComplexComponent( (BaseAddon) this, 543, -5, -5, 1, 2944, -1, "Pig Sty", 1);// 114
			AddComplexComponent( (BaseAddon) this, 543, -4, -5, 1, 2944, -1, "Pig Sty", 1);// 115
			AddComplexComponent( (BaseAddon) this, 543, -3, -5, 1, 2944, -1, "Pig Sty", 1);// 116
			AddComplexComponent( (BaseAddon) this, 543, -2, -5, 1, 2944, -1, "Pig Sty", 1);// 117
			AddComplexComponent( (BaseAddon) this, 543, -1, -5, 1, 2944, -1, "Pig Sty", 1);// 118
			AddComplexComponent( (BaseAddon) this, 543, 0, -5, 1, 2944, -1, "Pig Sty", 1);// 119
			AddComplexComponent( (BaseAddon) this, 543, 1, -5, 1, 2944, -1, "Pig Sty", 1);// 120
			AddComplexComponent( (BaseAddon) this, 543, 2, -5, 1, 2944, -1, "Pig Sty", 1);// 121
			AddComplexComponent( (BaseAddon) this, 543, 3, -5, 1, 2944, -1, "Pig Sty", 1);// 122
			AddComplexComponent( (BaseAddon) this, 543, 4, -5, 1, 2944, -1, "Pig Sty", 1);// 123
			AddComplexComponent( (BaseAddon) this, 543, 5, -5, 1, 2944, -1, "Pig Sty", 1);// 124
			AddComplexComponent( (BaseAddon) this, 12885, -5, -5, 0, 2944, -1, "Pig Sty", 1);// 125
			AddComplexComponent( (BaseAddon) this, 12886, -4, -5, 1, 2944, -1, "Pig Sty", 1);// 126
			AddComplexComponent( (BaseAddon) this, 12886, -2, -5, 1, 2944, -1, "Pig Sty", 1);// 127
			AddComplexComponent( (BaseAddon) this, 12886, 1, -5, 1, 2944, -1, "Pig Sty", 1);// 128
			AddComplexComponent( (BaseAddon) this, 12886, 2, -5, 1, 2944, -1, "Pig Sty", 1);// 129
			AddComplexComponent( (BaseAddon) this, 12886, 5, -5, 1, 2944, -1, "Pig Sty", 1);// 130
			AddComplexComponent( (BaseAddon) this, 12885, -1, -5, 1, 2944, -1, "Pig Sty", 1);// 131
			AddComplexComponent( (BaseAddon) this, 12885, 0, -5, 1, 2944, -1, "Pig Sty", 1);// 132
			AddComplexComponent( (BaseAddon) this, 12885, 3, -5, 1, 2944, -1, "Pig Sty", 1);// 133
			AddComplexComponent( (BaseAddon) this, 12885, 4, -5, 1, 2944, -1, "Pig Sty", 1);// 134
			AddComplexComponent( (BaseAddon) this, 12885, -3, -5, 1, 2944, -1, "Pig Sty", 1);// 135
			AddComplexComponent( (BaseAddon) this, 12918, -6, -4, 1, 2944, -1, "Pig Sty", 1);// 136
			AddComplexComponent( (BaseAddon) this, 12918, -6, -1, 1, 2944, -1, "Pig Sty", 1);// 137
			AddComplexComponent( (BaseAddon) this, 12918, -6, 3, 1, 2944, -1, "Pig Sty", 1);// 138
			AddComplexComponent( (BaseAddon) this, 12918, -6, 4, 1, 2944, -1, "Pig Sty", 1);// 139
			AddComplexComponent( (BaseAddon) this, 12918, -6, 5, 1, 2944, -1, "Pig Sty", 1);// 140
			AddComplexComponent( (BaseAddon) this, 12919, -6, 0, 1, 2944, -1, "Pig Sty", 1);// 141
			AddComplexComponent( (BaseAddon) this, 12919, -6, 1, 1, 2944, -1, "Pig Sty", 1);// 142
			AddComplexComponent( (BaseAddon) this, 12919, -6, 2, 1, 2944, -1, "Pig Sty", 1);// 143
			AddComplexComponent( (BaseAddon) this, 12919, -6, -3, 1, 2944, -1, "Pig Sty", 1);// 144
			AddComplexComponent( (BaseAddon) this, 12919, -6, -2, 1, 2944, -1, "Pig Sty", 1);// 145
			AddComplexComponent( (BaseAddon) this, 12921, -6, -5, 0, 2944, -1, "Pig Sty", 1);// 146
			AddComplexComponent( (BaseAddon) this, 12928, -5, 1, 1, 2944, -1, "Pig Sty", 1);// 147
			AddComplexComponent( (BaseAddon) this, 12929, -5, 2, 1, 2944, -1, "Pig Sty", 1);// 148
			AddComplexComponent( (BaseAddon) this, 12930, -5, 1, 1, 2944, -1, "Pig Sty", 1);// 149
			AddComplexComponent( (BaseAddon) this, 12932, -4, 2, 1, 2944, -1, "Pig Sty", 1);// 150
			AddComplexComponent( (BaseAddon) this, 12933, -4, 1, 1, 2944, -1, "Pig Sty", 1);// 151
			AddComplexComponent( (BaseAddon) this, 12932, -5, 2, 1, 2944, -1, "Pig Sty", 1);// 152
			AddComplexComponent( (BaseAddon) this, 12913, -5, 3, 1, 2944, -1, "Pig Sty", 1);// 153
			AddComplexComponent( (BaseAddon) this, 12920, -5, 2, 1, 2944, -1, "Pig Sty", 1);// 154
			AddComplexComponent( (BaseAddon) this, 12922, -5, 4, 1, 2944, -1, "Pig Sty", 1);// 155
			AddComplexComponent( (BaseAddon) this, 12916, -2, 6, 1, 2944, -1, "Pig Sty", 1);// 156
			AddComplexComponent( (BaseAddon) this, 12916, -1, 6, 1, 2944, -1, "Pig Sty", 1);// 157
			AddComplexComponent( (BaseAddon) this, 12916, 3, 6, 1, 2944, -1, "Pig Sty", 1);// 158
			AddComplexComponent( (BaseAddon) this, 12916, 5, 6, 1, 2944, -1, "Pig Sty", 1);// 159
			AddComplexComponent( (BaseAddon) this, 12917, -5, 6, 1, 2944, -1, "Pig Sty", 1);// 160
			AddComplexComponent( (BaseAddon) this, 12917, -4, 6, 1, 2944, -1, "Pig Sty", 1);// 161
			AddComplexComponent( (BaseAddon) this, 12917, -3, 6, 1, 2944, -1, "Pig Sty", 1);// 162
			AddComplexComponent( (BaseAddon) this, 12917, 0, 6, 1, 2944, -1, "Pig Sty", 1);// 163
			AddComplexComponent( (BaseAddon) this, 12917, 1, 6, 1, 2944, -1, "Pig Sty", 1);// 164
			AddComplexComponent( (BaseAddon) this, 12917, 2, 6, 1, 2944, -1, "Pig Sty", 1);// 165
			AddComplexComponent( (BaseAddon) this, 12917, 4, 6, 1, 2944, -1, "Pig Sty", 1);// 166
			AddComplexComponent( (BaseAddon) this, 12923, -6, 6, 1, 2944, -1, "Pig Sty", 1);// 167
			AddComplexComponent( (BaseAddon) this, 12913, 6, -4, 1, 2944, -1, "Pig Sty", 1);// 168
			AddComplexComponent( (BaseAddon) this, 12913, 6, -2, 1, 2944, -1, "Pig Sty", 1);// 169
			AddComplexComponent( (BaseAddon) this, 12913, 6, 0, 1, 2944, -1, "Pig Sty", 1);// 170
			AddComplexComponent( (BaseAddon) this, 12913, 6, 1, 1, 2944, -1, "Pig Sty", 1);// 171
			AddComplexComponent( (BaseAddon) this, 12913, 6, 5, 1, 2944, -1, "Pig Sty", 1);// 172
			AddComplexComponent( (BaseAddon) this, 12912, 6, 2, 1, 2944, -1, "Pig Sty", 1);// 173
			AddComplexComponent( (BaseAddon) this, 12912, 6, 3, 1, 2944, -1, "Pig Sty", 1);// 174
			AddComplexComponent( (BaseAddon) this, 12912, 6, 4, 1, 2944, -1, "Pig Sty", 1);// 175
			AddComplexComponent( (BaseAddon) this, 12912, 6, -3, 1, 2944, -1, "Pig Sty", 1);// 176
			AddComplexComponent( (BaseAddon) this, 12912, 6, -1, 1, 2944, -1, "Pig Sty", 1);// 177
			AddComplexComponent( (BaseAddon) this, 12922, 6, 6, 1, 2944, -1, "Pig Sty", 1);// 178
			AddComplexComponent( (BaseAddon) this, 12920, 6, -5, 1, 2944, -1, "Pig Sty", 1);// 179
			AddComplexComponent( (BaseAddon) this, 12917, 0, -4, 1, 2944, -1, "Pig Sty", 1);// 180
			AddComplexComponent( (BaseAddon) this, 12917, -1, -4, 1, 2944, -1, "Pig Sty", 1);// 181
			AddComplexComponent( (BaseAddon) this, 12922, -1, -2, 1, 2944, -1, "Pig Sty", 1);// 182
			AddComplexComponent( (BaseAddon) this, 12922, -1, -1, 1, 2944, -1, "Pig Sty", 1);// 183
			AddComplexComponent( (BaseAddon) this, 12920, -1, -2, 1, 2944, -1, "Pig Sty", 1);// 184
			AddComplexComponent( (BaseAddon) this, 12927, 5, -3, 1, 2944, -1, "Pig Sty", 1);// 185
			AddComplexComponent( (BaseAddon) this, 12929, 5, -2, 1, 2944, -1, "Pig Sty", 1);// 186
			AddComplexComponent( (BaseAddon) this, 12921, 4, -3, 1, 2944, -1, "Pig Sty", 1);// 187
			AddComplexComponent( (BaseAddon) this, 12929, 5, 1, 1, 2944, -1, "Pig Sty", 1);// 188
			AddComplexComponent( (BaseAddon) this, 12930, 5, 0, 1, 2944, -1, "Pig Sty", 1);// 189
			AddComplexComponent( (BaseAddon) this, 12933, 5, 0, 1, 2944, -1, "Pig Sty", 1);// 190
			AddComplexComponent( (BaseAddon) this, 12930, 4, 0, 1, 2944, -1, "Pig Sty", 1);// 191
			AddComplexComponent( (BaseAddon) this, 12929, 5, 0, 1, 2944, -1, "Pig Sty", 1);// 192
			AddComplexComponent( (BaseAddon) this, 12924, 5, -1, 1, 2944, -1, "Pig Sty", 1);// 193
			AddComplexComponent( (BaseAddon) this, 12919, 4, -1, 1, 2944, -1, "Pig Sty", 1);// 194
			AddComplexComponent( (BaseAddon) this, 12928, 3, 5, 1, 2944, -1, "Pig Sty", 1);// 195
			AddComplexComponent( (BaseAddon) this, 12924, -3, 5, 1, 2944, -1, "Pig Sty", 1);// 196
			AddComplexComponent( (BaseAddon) this, 12933, -2, 5, 1, 2944, -1, "Pig Sty", 1);// 197
			AddComplexComponent( (BaseAddon) this, 12930, -2, 5, 1, 2944, -1, "Pig Sty", 1);// 198
			AddComplexComponent( (BaseAddon) this, 12930, -4, 5, 1, 2944, -1, "Pig Sty", 1);// 199
			AddComplexComponent( (BaseAddon) this, 12921, 3, 5, 1, 2944, -1, "Pig Sty", 1);// 200
			AddComplexComponent( (BaseAddon) this, 12920, 4, 5, 1, 2944, -1, "Pig Sty", 1);// 201
			AddComplexComponent( (BaseAddon) this, 12915, 5, 5, 1, 2944, -1, "Pig Sty", 1);// 202
			AddComplexComponent( (BaseAddon) this, 12921, 4, 5, 1, 2944, -1, "Pig Sty", 1);// 203
			AddComplexComponent( (BaseAddon) this, 12920, 0, 5, 1, 2944, -1, "Pig Sty", 1);// 204
			AddComplexComponent( (BaseAddon) this, 12921, 0, 5, 1, 2944, -1, "Pig Sty", 1);// 205
			AddComplexComponent( (BaseAddon) this, 544, -6, -5, 1, 2944, -1, "Pig Sty", 1);// 206
			AddComplexComponent( (BaseAddon) this, 544, -6, -4, 1, 2944, -1, "Pig Sty", 1);// 207
			AddComplexComponent( (BaseAddon) this, 544, -6, -3, 1, 2944, -1, "Pig Sty", 1);// 208
			AddComplexComponent( (BaseAddon) this, 544, -6, -2, 1, 2944, -1, "Pig Sty", 1);// 209
			AddComplexComponent( (BaseAddon) this, 544, -6, -1, 1, 2944, -1, "Pig Sty", 1);// 210
			AddComplexComponent( (BaseAddon) this, 544, -6, 0, 1, 2944, -1, "Pig Sty", 1);// 211
			AddComplexComponent( (BaseAddon) this, 544, -6, 1, 1, 2944, -1, "Pig Sty", 1);// 212
			AddComplexComponent( (BaseAddon) this, 544, -6, 2, 1, 2944, -1, "Pig Sty", 1);// 213
			AddComplexComponent( (BaseAddon) this, 544, -6, 3, 1, 2944, -1, "Pig Sty", 1);// 214
			AddComplexComponent( (BaseAddon) this, 544, -6, 4, 1, 2944, -1, "Pig Sty", 1);// 215
			AddComplexComponent( (BaseAddon) this, 544, -6, 5, 1, 2944, -1, "Pig Sty", 1);// 216
			AddComplexComponent( (BaseAddon) this, 541, -6, 6, 1, 2944, -1, "Pig Sty", 1);// 217
			AddComplexComponent( (BaseAddon) this, 541, -5, 6, 1, 2944, -1, "Pig Sty", 1);// 218
			AddComplexComponent( (BaseAddon) this, 541, -4, 6, 1, 2944, -1, "Pig Sty", 1);// 219
			AddComplexComponent( (BaseAddon) this, 541, -3, 6, 1, 2944, -1, "Pig Sty", 1);// 220
			AddComplexComponent( (BaseAddon) this, 541, -2, 6, 1, 2944, -1, "Pig Sty", 1);// 221
			AddComplexComponent( (BaseAddon) this, 541, -1, 6, 1, 2944, -1, "Pig Sty", 1);// 222
			AddComplexComponent( (BaseAddon) this, 541, 0, 6, 1, 2944, -1, "Pig Sty", 1);// 223
			AddComplexComponent( (BaseAddon) this, 541, 1, 6, 1, 2944, -1, "Pig Sty", 1);// 224
			AddComplexComponent( (BaseAddon) this, 541, 2, 6, 1, 2944, -1, "Pig Sty", 1);// 225
			AddComplexComponent( (BaseAddon) this, 541, 3, 6, 1, 2944, -1, "Pig Sty", 1);// 226
			AddComplexComponent( (BaseAddon) this, 541, 4, 6, 1, 2944, -1, "Pig Sty", 1);// 227
			AddComplexComponent( (BaseAddon) this, 541, 5, 6, 1, 2944, -1, "Pig Sty", 1);// 228
			AddComplexComponent( (BaseAddon) this, 542, 6, -5, 1, 2944, -1, "Pig Sty", 1);// 229
			AddComplexComponent( (BaseAddon) this, 542, 6, -4, 1, 2944, -1, "Pig Sty", 1);// 230
			AddComplexComponent( (BaseAddon) this, 542, 6, -3, 1, 2944, -1, "Pig Sty", 1);// 231
			AddComplexComponent( (BaseAddon) this, 542, 6, -2, 1, 2944, -1, "Pig Sty", 1);// 232
			AddComplexComponent( (BaseAddon) this, 542, 6, -1, 1, 2944, -1, "Pig Sty", 1);// 233
			AddComplexComponent( (BaseAddon) this, 542, 6, 0, 1, 2944, -1, "Pig Sty", 1);// 234
			AddComplexComponent( (BaseAddon) this, 542, 6, 1, 1, 2944, -1, "Pig Sty", 1);// 235
			AddComplexComponent( (BaseAddon) this, 542, 6, 2, 1, 2944, -1, "Pig Sty", 1);// 236
			AddComplexComponent( (BaseAddon) this, 542, 6, 3, 1, 2944, -1, "Pig Sty", 1);// 237
			AddComplexComponent( (BaseAddon) this, 542, 6, 4, 1, 2944, -1, "Pig Sty", 1);// 238
			AddComplexComponent( (BaseAddon) this, 542, 6, 5, 1, 2944, -1, "Pig Sty", 1);// 239
			AddComplexComponent( (BaseAddon) this, 542, 6, 6, 1, 2944, -1, "Pig Sty", 1);// 240

		}

		public PigAddon( Serial serial ) : base( serial )
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

	public class PigAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new PigAddon();
			}
		}

		[Constructable]
		public PigAddonDeed()
		{
			Name = "Pig Fighting";
		}

		public PigAddonDeed( Serial serial ) : base( serial )
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