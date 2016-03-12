	using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System;

public class MonsterDatabase{

	// Script to parse data file and store every monster

	private List<Monster> MonsterList = new List<Monster>();

	public MonsterDatabase()
	{

	}

	public bool Initialize(string fileName)
	{
		if (LoadMonster (fileName)) {
			Debug.Log("Monster Database Initialized");
			return true;
		}

		return false;
	}

	private bool LoadMonster(string fileName)
	{
		// Handle any problems that might arise when reading the text
		try
		{
			string line;
			// Create a new StreamReader, tell it which file to read and what encoding the file
			// was saved as
			StreamReader theReader = new StreamReader(fileName, Encoding.Default);
			// Immediately clean up the reader after this block of code is done.
			// You generally use the "using" statement for potentially memory-intensive objects
			// instead of relying on garbage collection.
			// (Do not confuse this with the using directive for namespace at the 
			// beginning of a class!)
			using (theReader)
			{
				// While there's lines left in the text file, do this:
				do
				{
					line = theReader.ReadLine();
					
					if (line != null)
					{
						// Do whatever you need to do with the text line, it's a string now
						// In this example, I split it into arguments based on comma
						// deliniators, then send that array to DoStuff()
						string[] entries = line.Split(',');
						if(entries[0][0] == '/' && entries[0][1] == '/')
							continue;
						if (entries.Length > 0)
						{
							Monster monster = new Monster();
							monster.Set(entries[0], (Monster.MonsterType)(int.Parse((entries[1]))),
							            float.Parse(entries[2]),
										int.Parse(entries[3]),
										int.Parse(entries[4]),
							            float.Parse(entries[5]));
							MonsterList.Add(monster);
						}
					}
				}
				while (line != null);
				// Done reading, close the reader and return true to broadcast success    
				theReader.Close();
				return true;
			}
		}
		// If anything broke in the try block, we throw an exception with information
		// on what didn't work
		catch (Exception e)
		{
			Debug.Log ("Failed to initialize monster database");
			Debug.Log(e.Message);
			return false;
		}
	}

	public void Print()
	{
		foreach (Monster m in MonsterList) {
			Debug.Log(m.GetName());
		}
	}

	// id starts from 0
	public Monster GetMonster(int id)
	{
		return MonsterList [id];
	}

	public Monster GetMonster(string name)
	{
		foreach (Monster m in MonsterList) {
			if(m.GetName() == name)
			{
				return m;
			}
		}
		return null;
	}
}
