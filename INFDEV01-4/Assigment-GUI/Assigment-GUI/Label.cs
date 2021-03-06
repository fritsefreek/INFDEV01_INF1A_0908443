﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AssigmentGUI
{
	public class Label: IControl
	{
		public Vector2 position;
		public Vector2 size;
		public string texture;
	
		#region IControl implementation

		public void Update ()
		{
			throw new NotImplementedException ();
		}

		public void Draw (SpriteBatch spritebatch, SpriteFont font, Dictionary<string, Texture2D> buttonStates)
		{
			string output = "Hello World";
			Vector2 FontOrigin = font.MeasureString(output) / 2;

			spritebatch.DrawString(font, output, position, Color.LightGreen, 0, FontOrigin, size, SpriteEffects.None, 0.5f);
		}

		public bool Visit(IControlVisitor IControlVisitor)
		{
			return IControlVisitor.OnLabel (this);
		}

		public Vector2 Position {
			get {
				return this.position;
			}
			set {
				this.position = value;
			}
		}

		public Vector2 Size {
			get {
				return this.size;
			}
			set {
				this.size = value;
			}
		}

		public string Texture
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		#endregion


	}
}

