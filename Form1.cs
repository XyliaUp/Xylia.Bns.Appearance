using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using Xylia.Extension;

namespace Xylia.Bns.Appearance
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//GoExec(@"C:\Users\Cherub\Pictures\BnS\CharacterCustomize\外形_灵_女_201013_090.jpg");
		}

		Core.Data LastData = null;


		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog FileDialog = new OpenFileDialog();

			if (FileDialog.ShowDialog() == DialogResult.OK)
			{
				GoExec(FileDialog.FileName);
			}
		}



		private void GoExec(string FilePath)
		{
			string Info = Exec.SpiltString(FilePath);


			Core.Data data = new Core.Data();

			data.race = byte.Parse(new Regex("<race>.*?</race>", RegexOptions.IgnoreCase).Match(Info).Value.Replace("<race>", null).Replace("</race>", null));
			data.sex = byte.Parse(new Regex("<sex>.*?</sex>", RegexOptions.IgnoreCase).Match(Info).Value.Replace("<sex>", null).Replace("</sex>", null));


			string ParaInfo = new Regex("<data>.*?</data>", RegexOptions.IgnoreCase).Match(Info).Value.Replace("<data>", null).Replace("</data>", null);
			data.Param8 = ParaInfo.ToBytes();


			string ParamResult = null;
			byte[] Test = new byte[data.Param8.Length];


			Debug.WriteLine(ParaInfo);

			for (int i = 1; i <= 92; i++)
			{
				sbyte Byte = sbyte.Parse(data.GetProperty("param8_" + i).ToString());
				sbyte Byte2 = 0;

				if (LastData != null) Byte2 = sbyte.Parse(LastData.GetProperty("param8_" + i).ToString());



				if (Byte != 0) ParamResult += $"param8-{ i }=\"{ Byte }\" ";


				if (Range.Contains(i)) Test[i - 1] = BitConverter.GetBytes(Byte)[0];


				//检测发生变更的属性
				if (LastData != null && Byte2 != Byte)
				{
					Debug.WriteLine("param8-" + i + $"发生变更 { Byte } => {  Byte2 }");
				}
			}


			Debug.WriteLine(Test.ToHex(true));


			this.richOut.Text = $" <record alias=\"\" race=\"{ (Core.Enums.Race)data.race }\" sex=\"{ (Core.Enums.Sex)data.sex }\" anim-tree-name=\"NewAnimTree.TwoLegsTreeForNonPC\" body-material-name=\"\" body-mesh-name=\"\" decal-radius=\"1.00\" enable-physbrst=\"y\" face-anim-set-name=\"\" face-material-name=\"\" face-mesh-name=\"\" npc-dialogue-set=\"\" npcattach1=\"CommonNPC_Acc_HandFan.Mesh.CommonNPC_Acc_HandFan_Open_Juria\" sound-attenuation-scale=\"1.00\" sound-volume-scale=\"1.00\" unique-soundcue=\"\" unique-soundculldist=\"0.00\" unique-soundfadetime=\"0.00\" voice-set-name=\"00007975.NPC.Female_Young3\" { ParamResult }/>";

			LastData = data;
		}





		private List<int> Range { get; set; } = new List<int>()
		{
			1,2,4,5,6,7,8,9,
			//10,11,12,13,14,15,16,17,18,19,
			//20,21,22,23,24,24,26,27,28,29,
			
			//30,31,32,33,34,35,36,
			
			37,38,
			39,40,21,42,42,

			44,45,46,47,48,49,
			//50,51,52,53,54,55,56,57,58,59,
			
			60,61,


			91
		};

	}
}
