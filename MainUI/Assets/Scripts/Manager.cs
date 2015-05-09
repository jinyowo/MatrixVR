﻿using UnityEngine;
using System.Collections;

public class Manager {

	private static Manager _instance;
	public static Manager Instance
	{
		get
		{
			if(_instance == null)
			{
				_instance = new Manager();
			}
			return _instance;
		}
	}
	// FOR STREETVIEWER.SCENE VARIABLES AND FUNCTIONS
	public string panoramaID;
	public string[] nextIDs;
	public string[] nextDegrees;

	// FOR MainUI.scene VARIABLES AND FUNCTIONS
}