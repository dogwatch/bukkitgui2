﻿namespace bukkitgui2.Core.Util
{
	internal static class FsUtil
	{
		public static void CreateDirectoryIfNotExists(string directory)
		{
			if (System.IO.Directory.Exists(directory)) return;

			System.IO.Directory.CreateDirectory(directory);
		}
	}
}