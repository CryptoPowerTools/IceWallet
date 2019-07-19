﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace IceWallet.Engine.Utils
{
	public class ExceptionUtil
	{
		public static string GetExceptionDetails(Exception exception)
		{
			PropertyInfo[] properties = exception.GetType()
									.GetProperties();
			List<string> fields = new List<string>();
			foreach (PropertyInfo property in properties)
			{
				object value = property.GetValue(exception, null);
				fields.Add(String.Format(
								 "{0} = {1}",
								 property.Name,
								 value != null ? value.ToString() : String.Empty
				));
			}
			return String.Join("\n", fields.ToArray());
		}

	}
}
