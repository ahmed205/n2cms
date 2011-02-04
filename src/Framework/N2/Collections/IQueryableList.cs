﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace N2.Collections
{
	public interface IQueryableList<T>
	{
		IQueryable<T> Query();
	}
}