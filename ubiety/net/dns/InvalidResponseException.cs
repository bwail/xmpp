// InvalidResponseException.cs
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

//
// Bdev.Net.Dns by Rob Philpott, Big Developments Ltd. Please send all bugs/enhancements to
// rob@bigdevelopments.co.uk  This file and the code contained within is freeware and may be
// distributed and edited without restriction.
// 

using System;

namespace ubiety.net.dns
{
	/// <summary>
	/// Thrown when the server delivers a response we are not expecting to hear
	/// </summary>	
	public class InvalidResponseException : SystemException
	{
		public InvalidResponseException()
		{
			// no implementation
		}

		public InvalidResponseException(Exception innerException) :  base(null, innerException) 
		{
			// no implementation
		}

		public InvalidResponseException(string message, Exception innerException) : base (message, innerException)
		{
			// no implementation
		}
        
        //protected InvalidResponseException(SerializationInfo info, StreamingContext context) : base(info, context)
        //{
        //    // no implementation
        //}
	}
}
