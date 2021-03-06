﻿using System;
using System.Collections.Generic;

namespace AssigmentGUI
{
	public class ListIterator<T>: Iterator<T> 
	{
		private List<T> list;
		private int index = -1;
		public T Current;

		public ListIterator(List<T> list) {
			this.list = list;
		}

		public IOption<T> GetNext() {
			this.index += 1;
			if (index == list.Count) {
				return new None<T> ();
			} else {
				return new Some<T> (this.list [this.index]);
			}
		}
	}
}