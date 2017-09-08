﻿using System;
using System.IO;

namespace worldWizards.core.entity.utils
{
	public static class FileIO
	{


		public static string testPath = "Assets/Resources/test.json";
		public static void SaveJSONToFile(string json, string filePath){
			File.WriteAllText(filePath, json);
		}


		public static string LoadJsonFromFile(string filePath){
			return File.ReadAllText (filePath);
		}
	}
}

