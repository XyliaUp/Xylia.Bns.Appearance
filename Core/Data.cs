using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Xylia.Bns.Appearance.Core
{

	// 注意: 生成的代码可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。
	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class Data
	{

		private string aliasField;

		private string animtreenameField;

		private string bodymaterialnameField;

		private string bodymeshnameField;

		private decimal decalradiusField;

		private string enablephysbrstField;

		private string faceanimsetnameField;

		private string facematerialnameField;

		private string facemeshnameField;

		private string npcdialoguesetField;

		private byte raceField;

		private byte sexField;

		private decimal soundattenuationscaleField;

		private decimal soundvolumescaleField;

		private decimal uniquesoundculldistField;

		private decimal uniquesoundfadetimeField;

		private string uniquesoundcueField;

		private string voicesetnameField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string alias
		{
			get
			{
				return this.aliasField;
			}
			set
			{
				this.aliasField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("anim-tree-name")]
		public string animtreename
		{
			get
			{
				return this.animtreenameField;
			}
			set
			{
				this.animtreenameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("body-material-name")]
		public string bodymaterialname
		{
			get
			{
				return this.bodymaterialnameField;
			}
			set
			{
				this.bodymaterialnameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("body-mesh-name")]
		public string bodymeshname
		{
			get
			{
				return this.bodymeshnameField;
			}
			set
			{
				this.bodymeshnameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("decal-radius")]
		public decimal decalradius
		{
			get
			{
				return this.decalradiusField;
			}
			set
			{
				this.decalradiusField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("enable-physbrst")]
		public string enablephysbrst
		{
			get
			{
				return this.enablephysbrstField;
			}
			set
			{
				this.enablephysbrstField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("face-anim-set-name")]
		public string faceanimsetname
		{
			get
			{
				return this.faceanimsetnameField;
			}
			set
			{
				this.faceanimsetnameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("face-material-name")]
		public string facematerialname
		{
			get
			{
				return this.facematerialnameField;
			}
			set
			{
				this.facematerialnameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("face-mesh-name")]
		public string facemeshname
		{
			get
			{
				return this.facemeshnameField;
			}
			set
			{
				this.facemeshnameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("npc-dialogue-set")]
		public string npcdialogueset
		{
			get
			{
				return this.npcdialoguesetField;
			}
			set
			{
				this.npcdialoguesetField = value;
			}
		}





		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-1")]
		public sbyte param8_1
		{
			get
			{
				return (sbyte)this.Param8[0];
			}
			set
			{
				this.Param8[0] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-10")]
		public sbyte param8_10
		{
			get
			{
				return (sbyte)(sbyte)this.Param8[9];
			}
			set
			{
				this.Param8[9] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-11")]
		public sbyte param8_11
		{
			get
			{
				return (sbyte)this.Param8[10];
			}
			set
			{
				this.Param8[10] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-12")]
		public sbyte param8_12
		{
			get
			{
				return (sbyte)this.Param8[11];
			}
			set
			{
				this.Param8[11] = (byte)value;
			}
		}


		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-13")]
		public sbyte param8_13
		{
			get
			{
				return (sbyte)this.Param8[12];
			}
			set
			{
				this.Param8[12] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-14")]
		public sbyte param8_14
		{
			get
			{
				return (sbyte)this.Param8[13];
			}
			set
			{
				this.Param8[13] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-15")]
		public sbyte param8_15
		{
			get
			{
				return (sbyte)this.Param8[14];
			}
			set
			{
				this.Param8[14] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-16")]
		public sbyte param8_16
		{
			get
			{
				return (sbyte)this.Param8[15];
			}
			set
			{
				this.Param8[15] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-17")]
		public sbyte param8_17
		{
			get
			{
				return (sbyte)this.Param8[16];
			}
			set
			{
				this.Param8[16] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-18")]
		public sbyte param8_18
		{
			get
			{
				return (sbyte)this.Param8[17];
			}
			set
			{
				this.Param8[17] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-19")]
		public sbyte param8_19
		{
			get
			{
				return (sbyte)this.Param8[18];
			}
			set
			{
				this.Param8[18] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-2")]
		public sbyte param8_2
		{
			get
			{
				return (sbyte)this.Param8[1];
			}
			set
			{
				this.Param8[1] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-20")]
		public sbyte param8_20
		{
			get
			{
				return (sbyte)this.Param8[19];
			}
			set
			{
				this.Param8[19] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-21")]
		public sbyte param8_21
		{
			get
			{
				return (sbyte)this.Param8[20];
			}
			set
			{
				this.Param8[20] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-22")]
		public sbyte param8_22
		{
			get
			{
				return (sbyte)this.Param8[21];
			}
			set
			{
				this.Param8[21] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-23")]
		public sbyte param8_23
		{
			get
			{
				return (sbyte)this.Param8[22];
			}
			set
			{
				this.Param8[22] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-24")]
		public sbyte param8_24
		{
			get
			{
				return (sbyte)this.Param8[23];
			}
			set
			{
				this.Param8[23] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-25")]
		public sbyte param8_25
		{
			get
			{
				return (sbyte)this.Param8[24];
			}
			set
			{
				this.Param8[24] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-26")]
		public sbyte param8_26
		{
			get
			{
				return (sbyte)this.Param8[25];
			}
			set
			{
				this.Param8[25] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-27")]
		public sbyte param8_27
		{
			get
			{
				return (sbyte)this.Param8[26];
			}
			set
			{
				this.Param8[26] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-28")]
		public sbyte param8_28
		{
			get
			{
				return (sbyte)this.Param8[27];
			}
			set
			{
				this.Param8[27] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-29")]
		public sbyte param8_29
		{
			get
			{
				return (sbyte)this.Param8[28];
			}
			set
			{
				this.Param8[28] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-3")]
		public sbyte param8_3
		{
			get
			{
				return (sbyte)this.Param8[2];
			}
			set
			{
				this.Param8[2] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-30")]
		public sbyte param8_30
		{
			get
			{
				return (sbyte)this.Param8[29];
			}
			set
			{
				this.Param8[29] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-31")]
		public sbyte param8_31
		{
			get
			{
				return (sbyte)this.Param8[30];
			}
			set
			{
				this.Param8[30] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-32")]
		public sbyte param8_32
		{
			get
			{
				return (sbyte)this.Param8[31];
			}
			set
			{
				this.Param8[31] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-33")]
		public sbyte param8_33
		{
			get
			{
				return (sbyte)this.Param8[32];
			}
			set
			{
				this.Param8[32] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-34")]
		public sbyte param8_34
		{
			get
			{
				return (sbyte)this.Param8[33];
			}
			set
			{
				this.Param8[33] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-35")]
		public sbyte param8_35
		{
			get
			{
				return (sbyte)this.Param8[34];
			}
			set
			{
				this.Param8[34] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-36")]
		public sbyte param8_36
		{
			get
			{
				return (sbyte)this.Param8[35];
			}
			set
			{
				this.Param8[35] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-37")]
		public sbyte param8_37
		{
			get
			{
				return (sbyte)this.Param8[36];
			}
			set
			{
				this.Param8[36] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-38")]
		public sbyte param8_38
		{
			get
			{
				return (sbyte)this.Param8[37];
			}
			set
			{
				this.Param8[37] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-39")]
		public sbyte param8_39
		{
			get
			{
				return (sbyte)this.Param8[38];
			}
			set
			{
				this.Param8[38] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-4")]
		public sbyte param8_4
		{
			get
			{
				return (sbyte)this.Param8[3];
			}
			set
			{
				this.Param8[3] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-40")]
		public sbyte param8_40
		{
			get
			{
				return (sbyte)this.Param8[39];
			}
			set
			{
				this.Param8[39] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-41")]
		public sbyte param8_41
		{
			get
			{
				return (sbyte)this.Param8[40];
			}
			set
			{
				this.Param8[40] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-42")]
		public sbyte param8_42
		{
			get
			{
				return (sbyte)this.Param8[41];
			}
			set
			{
				this.Param8[41] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-43")]
		public sbyte param8_43
		{
			get
			{
				return (sbyte)this.Param8[42];
			}
			set
			{
				this.Param8[42] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-44")]
		public sbyte param8_44
		{
			get
			{
				return (sbyte)this.Param8[43];
			}
			set
			{
				this.Param8[43] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-45")]
		public sbyte param8_45
		{
			get
			{
				return (sbyte)this.Param8[44];
			}
			set
			{
				this.Param8[44] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-46")]
		public sbyte param8_46
		{
			get
			{
				return (sbyte)this.Param8[45];
			}
			set
			{
				this.Param8[45] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-47")]
		public sbyte param8_47
		{
			get
			{
				return (sbyte)this.Param8[46];
			}
			set
			{
				this.Param8[46] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-48")]
		public sbyte param8_48
		{
			get
			{
				return (sbyte)this.Param8[47];
			}
			set
			{
				this.Param8[47] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-49")]
		public sbyte param8_49
		{
			get
			{
				return (sbyte)this.Param8[48];
			}
			set
			{
				this.Param8[48] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-5")]
		public sbyte param8_5
		{
			get
			{
				return (sbyte)this.Param8[4];
			}
			set
			{
				this.Param8[4] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-50")]
		public sbyte param8_50
		{
			get
			{
				return (sbyte)this.Param8[49];
			}
			set
			{
				this.Param8[49] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-51")]
		public sbyte param8_51
		{
			get
			{
				return (sbyte)this.Param8[50];
			}
			set
			{
				this.Param8[50] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-52")]
		public sbyte param8_52
		{
			get
			{
				return (sbyte)this.Param8[51];
			}
			set
			{
				this.Param8[51] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-53")]
		public sbyte param8_53
		{
			get
			{
				return (sbyte)this.Param8[52];
			}
			set
			{
				this.Param8[52] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-54")]
		public sbyte param8_54
		{
			get
			{
				return (sbyte)this.Param8[53];
			}
			set
			{
				this.Param8[53] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-55")]
		public sbyte param8_55
		{
			get
			{
				return (sbyte)this.Param8[54];
			}
			set
			{
				this.Param8[54] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-56")]
		public sbyte param8_56
		{
			get
			{
				return (sbyte)this.Param8[55];
			}
			set
			{
				this.Param8[55] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-57")]
		public sbyte param8_57
		{
			get
			{
				return (sbyte)this.Param8[56];
			}
			set
			{
				this.Param8[56] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-58")]
		public sbyte param8_58
		{
			get
			{
				return (sbyte)this.Param8[57];
			}
			set
			{
				this.Param8[57] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-59")]
		public sbyte param8_59
		{
			get
			{
				return (sbyte)this.Param8[58];
			}
			set
			{
				this.Param8[58] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-6")]
		public sbyte param8_6
		{
			get
			{
				return (sbyte)this.Param8[5];
			}
			set
			{
				this.Param8[5] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-60")]
		public sbyte param8_60
		{
			get
			{
				return (sbyte)this.Param8[59];
			}
			set
			{
				this.Param8[59] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-61")]
		public sbyte param8_61
		{
			get
			{
				return (sbyte)this.Param8[60];
			}
			set
			{
				this.Param8[60] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-62")]
		public sbyte param8_62
		{
			get
			{
				return (sbyte)this.Param8[61];
			}
			set
			{
				this.Param8[61] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-63")]
		public sbyte param8_63
		{
			get
			{
				return (sbyte)this.Param8[62];
			}
			set
			{
				this.Param8[62] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-64")]
		public sbyte param8_64
		{
			get
			{
				return (sbyte)this.Param8[63];
			}
			set
			{
				this.Param8[63] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-65")]
		public sbyte param8_65
		{
			get
			{
				return (sbyte)this.Param8[64];
			}
			set
			{
				this.Param8[64] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-66")]
		public sbyte param8_66
		{
			get
			{
				return (sbyte)this.Param8[65];
			}
			set
			{
				this.Param8[65] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-67")]
		public sbyte param8_67
		{
			get
			{
				return (sbyte)this.Param8[66];
			}
			set
			{
				this.Param8[66] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-68")]
		public sbyte param8_68
		{
			get
			{
				return (sbyte)this.Param8[67];
			}
			set
			{
				this.Param8[67] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-69")]
		public sbyte param8_69
		{
			get
			{
				return (sbyte)this.Param8[68];
			}
			set
			{
				this.Param8[68] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-7")]
		public sbyte param8_7
		{
			get
			{
				return (sbyte)this.Param8[6];
			}
			set
			{
				this.Param8[6] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-70")]
		public sbyte param8_70
		{
			get
			{
				return (sbyte)this.Param8[69];
			}
			set
			{
				this.Param8[69] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-71")]
		public sbyte param8_71
		{
			get
			{
				return (sbyte)this.Param8[70];
			}
			set
			{
				this.Param8[70] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-72")]
		public sbyte param8_72
		{
			get
			{
				return (sbyte)this.Param8[71];
			}
			set
			{
				this.Param8[71] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-73")]
		public sbyte param8_73
		{
			get
			{
				return (sbyte)this.Param8[72];
			}
			set
			{
				this.Param8[72] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-74")]
		public sbyte param8_74
		{
			get
			{
				return (sbyte)this.Param8[73];
			}
			set
			{
				this.Param8[73] = (byte)value;
			}
		}



		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-75")]
		public sbyte param8_75
		{
			get
			{
				return (sbyte)this.Param8[74];
			}
			set
			{
				this.Param8[74] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-76")]
		public sbyte param8_76
		{
			get
			{
				return (sbyte)this.Param8[75];
			}
			set
			{
				this.Param8[75] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-77")]
		public sbyte param8_77
		{
			get
			{
				return (sbyte)this.Param8[76];
			}
			set
			{
				this.Param8[76] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-78")]
		public sbyte param8_78
		{
			get
			{
				return (sbyte)this.Param8[77];
			}
			set
			{
				this.Param8[77] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-79")]
		public sbyte param8_79
		{
			get
			{
				return (sbyte)this.Param8[78];
			}
			set
			{
				this.Param8[78] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-8")]
		public sbyte param8_8
		{
			get
			{
				return (sbyte)this.Param8[7];
			}
			set
			{
				this.Param8[7] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-80")]
		public sbyte param8_80
		{
			get
			{
				return (sbyte)this.Param8[79];
			}
			set
			{
				this.Param8[79] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-81")]
		public sbyte param8_81
		{
			get
			{
				return (sbyte)this.Param8[80];
			}
			set
			{
				this.Param8[80] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-82")]
		public sbyte param8_82
		{
			get
			{
				return (sbyte)this.Param8[81];
			}
			set
			{
				this.Param8[81] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-83")]
		public sbyte param8_83
		{
			get
			{
				return (sbyte)this.Param8[82];
			}
			set
			{
				this.Param8[82] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-84")]
		public sbyte param8_84
		{
			get
			{
				return (sbyte)this.Param8[83];
			}
			set
			{
				this.Param8[83] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-85")]
		public sbyte param8_85
		{
			get
			{
				return (sbyte)this.Param8[84];
			}
			set
			{
				this.Param8[84] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-86")]
		public sbyte param8_86
		{
			get
			{
				return (sbyte)this.Param8[85];
			}
			set
			{
				this.Param8[85] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-87")]
		public sbyte param8_87
		{
			get
			{
				return (sbyte)this.Param8[86];
			}
			set
			{
				this.Param8[86] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-88")]
		public sbyte param8_88
		{
			get
			{
				return (sbyte)this.Param8[87];
			}
			set
			{
				this.Param8[87] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-89")]
		public sbyte param8_89
		{
			get
			{
				return (sbyte)this.Param8[88];
			}
			set
			{
				this.Param8[88] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-9")]
		public sbyte param8_9
		{
			get
			{
				return (sbyte)this.Param8[8];
			}
			set
			{
				this.Param8[8] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-90")]
		public sbyte param8_90
		{
			get
			{
				return (sbyte)this.Param8[89];
			}
			set
			{
				this.Param8[89] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-91")]
		public sbyte param8_91
		{
			get
			{
				return (sbyte)this.Param8[90];
			}
			set
			{
				this.Param8[90] = (byte)value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("param8-92")]
		public sbyte param8_92
		{
			get
			{
				return (sbyte)this.Param8[91];
			}
			set
			{
				this.Param8[91] = (byte)value;
			}
		}




		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte race
		{
			get
			{
				return this.raceField;
			}
			set
			{
				this.raceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte sex
		{
			get
			{
				return this.sexField;
			}
			set
			{
				this.sexField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("sound-attenuation-scale")]
		public decimal soundattenuationscale
		{
			get
			{
				return this.soundattenuationscaleField;
			}
			set
			{
				this.soundattenuationscaleField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("sound-volume-scale")]
		public decimal soundvolumescale
		{
			get
			{
				return this.soundvolumescaleField;
			}
			set
			{
				this.soundvolumescaleField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("unique-soundculldist")]
		public decimal uniquesoundculldist
		{
			get
			{
				return this.uniquesoundculldistField;
			}
			set
			{
				this.uniquesoundculldistField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("unique-soundfadetime")]
		public decimal uniquesoundfadetime
		{
			get
			{
				return this.uniquesoundfadetimeField;
			}
			set
			{
				this.uniquesoundfadetimeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("unique-soundcue")]
		public string uniquesoundcue
		{
			get
			{
				return this.uniquesoundcueField;
			}
			set
			{
				this.uniquesoundcueField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("voice-set-name")]
		public string voicesetname
		{
			get
			{
				return this.voicesetnameField;
			}
			set
			{
				this.voicesetnameField = value;
			}
		}




		private byte[] Param8_Field { get; set; } = new byte[92];

		public byte[] Param8
		{
			get => this.Param8_Field;
			set => this.Param8_Field = value;
		}
	}

}
