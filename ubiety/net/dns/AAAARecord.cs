// ANameRecord.cs
//
//Ubiety XMPP Library Copyright (C) 2006 - 2009 Dieter Lunn
// 
// This library is free software; you can redistribute it and/or modify it under
// the terms of the GNU Lesser General Public License as published by the Free
// Software Foundation; either version 3 of the License, or (at your option)
// any later version.
// 
// This library is distributed in the hope that it will be useful, but WITHOUT
// ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
// FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public License for more
// 
// You should have received a copy of the GNU Lesser General Public License along
// with this library; if not, write to the Free Software Foundation, Inc., 59
// Temple Place, Suite 330, Boston, MA 02111-1307 USA

#region
//
// Bdev.Net.Dns by Rob Philpott, Big Developments Ltd. Please send all bugs/enhancements to
// rob@bigdevelopments.co.uk  This file and the code contained within is freeware and may be
// distributed and edited without restriction.
// 

#endregion

using System.Net;

namespace ubiety.net.dns
{
	/// <summary>
	/// AAAA Resource Record (RR) (RFC1035 3.4.1)
	/// </summary>
	public class AAAARecord : RecordBase
	{
		// An ANAME records consists simply of an IP address
		internal IPAddress _ipAddress;

		// expose this IP address r/o to the world
		public IPAddress IPAddress
		{
			get { return _ipAddress; }
		}

		/// <summary>
		/// Constructs an ANAME record by reading bytes from a return message
		/// </summary>
		/// <param name="pointer">A logical pointer to the bytes holding the record</param>
		internal AAAARecord(Pointer pointer)
		{
			byte b1 = pointer.ReadByte();
			byte b2 = pointer.ReadByte();
			byte b3 = pointer.ReadByte();
			byte b4 = pointer.ReadByte();
            byte b5 = pointer.ReadByte();
            byte b6 = pointer.ReadByte();
            byte b7 = pointer.ReadByte();
            byte b8 = pointer.ReadByte();

			// this next line's not brilliant - couldn't find a better way though
			_ipAddress = IPAddress.Parse(string.Format("{0}:{1}:{2}:{3}:{4}:{5}:{6}:{7}", b1, b2, b3, b4, b5, b6, b7, b8));
		}

		public override string ToString()
		{
			return _ipAddress.ToString();
		}
	}
}
