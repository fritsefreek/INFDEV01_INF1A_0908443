﻿using System;


/*
 *	- Visitor: Detect if control is of type IControl
 *  - Factory: Create buttons and labels
 *  - Iterator: Iterrate trough a list of buttons/labels
 *  - Adapter: ?
 * 	- Decorater: To change the background collor of a button  
*/


/*
 *  - Create a list of buttons with the factory
 * 	- Iterrate torugh them and use the visitor to check if the IControl is a button or label
 *	- Use a Decorater/map to change the background of a button
*/

namespace AssigmentGUI
{
	class MainClass
	{
		public static void Main (string[] args) 
		{
			using (Application app = new Application())
			{
				app.Run();
			}
		}
	}
}
