﻿#region License

/*
Licensed to Blue Chilli Technology Pty Ltd and the contributors under the MIT License (the "License").
You may not use this file except in compliance with the License.
See the LICENSE file in the project root for more information.
*/

#endregion

using System;
using System.IO;

namespace ChilliSource.Core.Extensions
{
	/// <summary>
	/// Stream extensions.
	/// </summary>
	public static class StreamExtensions
	{
		/// <summary>
		/// Converts the specified stream to a byte array
		/// </summary>
		/// <returns>The byte array.</returns>
		/// <param name="stream">Stream to convert.</param>
		public static byte[] ToArray(this Stream stream)
		{
			if (stream == null)
			{
				return null;
			}

            if (stream is MemoryStream)
            {
                return ((MemoryStream)stream).ToArray();
            }

            using (MemoryStream ms = new MemoryStream())
			{
				stream.CopyTo(ms);
				return ms.ToArray();
			}
		}
	}
}
