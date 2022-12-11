
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

using Xylia.Extension;
namespace Xylia.Bns.Appearance
{
	public static class Exec
	{
		public static string SpiltString(string FilePath)
		{
			FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.ReadWrite);
			byte[] Bytes = new byte[(int)fs.Length];
			fs.Read(Bytes, 0, Bytes.Length);
			fs.Close();


			if (Bytes.ToHex(true).Contains(new byte[] { (byte)'<', (byte)'?', (byte)'x', (byte)'m', (byte)'l' }.ToHex(true)))
			{
				for (int i = 4; i < Bytes.Length; i++)
				{
					if (Bytes[i - 4] == (byte)'<' && Bytes[i - 3] == (byte)'?' && Bytes[i - 2] == (byte)'x' && Bytes[i - 1] == (byte)'m' && Bytes[i] == (byte)'l')
					{
						byte[] tmp = new byte[Bytes.Length];

						int StartIndex = i - 4;

						Buffer.BlockCopy(Bytes, StartIndex, tmp, 0, Bytes.Length - StartIndex);

						return new Regex("<appearance>.*?</appearance>").Match(Encoding.UTF8.GetString(tmp)).Value;
					}
				}
			}

			throw new Exception("不是有效的捏脸文件");
		}
	}
}
