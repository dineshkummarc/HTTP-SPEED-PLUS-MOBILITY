﻿//-----------------------------------------------------------------------
// <copyright file="CompressionDictionary.cs" company="Microsoft Open Technologies, Inc.">
//
// The copyright in this software is being made available under the BSD License, included below. 
// This software may be subject to other third party and contributor rights, including patent rights, 
// and no such rights are granted under this license.
//
// Copyright (c) 2012, Microsoft Open Technologies, Inc. 
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without modification, 
// are permitted provided that the following conditions are met:
//
// - Redistributions of source code must retain the above copyright notice, 
//   this list of conditions and the following disclaimer.
// - Redistributions in binary form must reproduce the above copyright notice, 
//   this list of conditions and the following disclaimer in the documentation 
//   and/or other materials provided with the distribution.
// - Neither the name of Microsoft Open Technologies, Inc. nor the names of its contributors 
//   may be used to endorse or promote products derived from this software 
//   without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS “AS IS” AND ANY EXPRESS OR IMPLIED WARRANTIES, 
// INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
// INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, 
// PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) 
// HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, 
// OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, 
// EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
//
// </copyright>
//-----------------------------------------------------------------------

namespace ClientProtocol.ServiceModel.Http2Protocol.MessageProcessing
{
	/// <summary>
	/// Compression dictionary.
	/// </summary>
	public static class CompressionDictionary
	{
		/// <summary>
		/// Gets the dictionary.
		/// </summary>
		public static byte[] Dictionary
		{
			get { return (byte[])dictionary.Clone(); }
		}

		private static readonly byte[] dictionary = {
	0x00, 0x00, 0x00, 0x07, 0x6f, 0x70, 0x74, 0x69,
	0x6f, 0x6e, 0x73, 0x00, 0x00, 0x00, 0x04, 0x68,
	0x65, 0x61, 0x64, 0x00, 0x00, 0x00, 0x04, 0x70,
	0x6f, 0x73, 0x74, 0x00, 0x00, 0x00, 0x03, 0x70,
	0x75, 0x74, 0x00, 0x00, 0x00, 0x06, 0x64, 0x65,
	0x6c, 0x65, 0x74, 0x65, 0x00, 0x00, 0x00, 0x05,
	0x74, 0x72, 0x61, 0x63, 0x65, 0x00, 0x00, 0x00,
	0x06, 0x61, 0x63, 0x63, 0x65, 0x70, 0x74, 0x00,
	0x00, 0x00, 0x0e, 0x61, 0x63, 0x63, 0x65, 0x70,
	0x74, 0x2d, 0x63, 0x68, 0x61, 0x72, 0x73, 0x65,
	0x74, 0x00, 0x00, 0x00, 0x0f, 0x61, 0x63, 0x63,
	0x65, 0x70, 0x74, 0x2d, 0x65, 0x6e, 0x63, 0x6f,
	0x64, 0x69, 0x6e, 0x67, 0x00, 0x00, 0x00, 0x0f,
	0x61, 0x63, 0x63, 0x65, 0x70, 0x74, 0x2d, 0x6c,
	0x61, 0x6e, 0x67, 0x75, 0x61, 0x67, 0x65, 0x00,
	0x00, 0x00, 0x0d, 0x61, 0x63, 0x63, 0x65, 0x70,
	0x74, 0x2d, 0x72, 0x61, 0x6e, 0x67, 0x65, 0x73,
	0x00, 0x00, 0x00, 0x03, 0x61, 0x67, 0x65, 0x00,
	0x00, 0x00, 0x05, 0x61, 0x6c, 0x6c, 0x6f, 0x77,
	0x00, 0x00, 0x00, 0x0d, 0x61, 0x75, 0x74, 0x68,
	0x6f, 0x72, 0x69, 0x7a, 0x61, 0x74, 0x69, 0x6f,
	0x6e, 0x00, 0x00, 0x00, 0x0d, 0x63, 0x61, 0x63,
	0x68, 0x65, 0x2d, 0x63, 0x6f, 0x6e, 0x74, 0x72,
	0x6f, 0x6c, 0x00, 0x00, 0x00, 0x0a, 0x63, 0x6f,
	0x6e, 0x6e, 0x65, 0x63, 0x74, 0x69, 0x6f, 0x6e,
	0x00, 0x00, 0x00, 0x0c, 0x63, 0x6f, 0x6e, 0x74,
	0x65, 0x6e, 0x74, 0x2d, 0x62, 0x61, 0x73, 0x65,
	0x00, 0x00, 0x00, 0x10, 0x63, 0x6f, 0x6e, 0x74,
	0x65, 0x6e, 0x74, 0x2d, 0x65, 0x6e, 0x63, 0x6f,
	0x64, 0x69, 0x6e, 0x67, 0x00, 0x00, 0x00, 0x10,
	0x63, 0x6f, 0x6e, 0x74, 0x65, 0x6e, 0x74, 0x2d,
	0x6c, 0x61, 0x6e, 0x67, 0x75, 0x61, 0x67, 0x65,
	0x00, 0x00, 0x00, 0x0e, 0x63, 0x6f, 0x6e, 0x74,
	0x65, 0x6e, 0x74, 0x2d, 0x6c, 0x65, 0x6e, 0x67,
	0x74, 0x68, 0x00, 0x00, 0x00, 0x10, 0x63, 0x6f,
	0x6e, 0x74, 0x65, 0x6e, 0x74, 0x2d, 0x6c, 0x6f,
	0x63, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x00, 0x00,
	0x00, 0x0b, 0x63, 0x6f, 0x6e, 0x74, 0x65, 0x6e,
	0x74, 0x2d, 0x6d, 0x64, 0x35, 0x00, 0x00, 0x00,
	0x0d, 0x63, 0x6f, 0x6e, 0x74, 0x65, 0x6e, 0x74,
	0x2d, 0x72, 0x61, 0x6e, 0x67, 0x65, 0x00, 0x00,
	0x00, 0x0c, 0x63, 0x6f, 0x6e, 0x74, 0x65, 0x6e,
	0x74, 0x2d, 0x74, 0x79, 0x70, 0x65, 0x00, 0x00,
	0x00, 0x04, 0x64, 0x61, 0x74, 0x65, 0x00, 0x00,
	0x00, 0x04, 0x65, 0x74, 0x61, 0x67, 0x00, 0x00,
	0x00, 0x06, 0x65, 0x78, 0x70, 0x65, 0x63, 0x74,
	0x00, 0x00, 0x00, 0x07, 0x65, 0x78, 0x70, 0x69,
	0x72, 0x65, 0x73, 0x00, 0x00, 0x00, 0x04, 0x66,
	0x72, 0x6f, 0x6d, 0x00, 0x00, 0x00, 0x04, 0x68,
	0x6f, 0x73, 0x74, 0x00, 0x00, 0x00, 0x08, 0x69,
	0x66, 0x2d, 0x6d, 0x61, 0x74, 0x63, 0x68, 0x00,
	0x00, 0x00, 0x11, 0x69, 0x66, 0x2d, 0x6d, 0x6f,
	0x64, 0x69, 0x66, 0x69, 0x65, 0x64, 0x2d, 0x73,
	0x69, 0x6e, 0x63, 0x65, 0x00, 0x00, 0x00, 0x0d,
	0x69, 0x66, 0x2d, 0x6e, 0x6f, 0x6e, 0x65, 0x2d,
	0x6d, 0x61, 0x74, 0x63, 0x68, 0x00, 0x00, 0x00,
	0x08, 0x69, 0x66, 0x2d, 0x72, 0x61, 0x6e, 0x67,
	0x65, 0x00, 0x00, 0x00, 0x13, 0x69, 0x66, 0x2d,
	0x75, 0x6e, 0x6d, 0x6f, 0x64, 0x69, 0x66, 0x69,
	0x65, 0x64, 0x2d, 0x73, 0x69, 0x6e, 0x63, 0x65,
	0x00, 0x00, 0x00, 0x0d, 0x6c, 0x61, 0x73, 0x74,
	0x2d, 0x6d, 0x6f, 0x64, 0x69, 0x66, 0x69, 0x65,
	0x64, 0x00, 0x00, 0x00, 0x08, 0x6c, 0x6f, 0x63,
	0x61, 0x74, 0x69, 0x6f, 0x6e, 0x00, 0x00, 0x00,
	0x0c, 0x6d, 0x61, 0x78, 0x2d, 0x66, 0x6f, 0x72,
	0x77, 0x61, 0x72, 0x64, 0x73, 0x00, 0x00, 0x00,
	0x06, 0x70, 0x72, 0x61, 0x67, 0x6d, 0x61, 0x00,
	0x00, 0x00, 0x12, 0x70, 0x72, 0x6f, 0x78, 0x79,
	0x2d, 0x61, 0x75, 0x74, 0x68, 0x65, 0x6e, 0x74,
	0x69, 0x63, 0x61, 0x74, 0x65, 0x00, 0x00, 0x00,
	0x13, 0x70, 0x72, 0x6f, 0x78, 0x79, 0x2d, 0x61,
	0x75, 0x74, 0x68, 0x6f, 0x72, 0x69, 0x7a, 0x61,
	0x74, 0x69, 0x6f, 0x6e, 0x00, 0x00, 0x00, 0x05,
	0x72, 0x61, 0x6e, 0x67, 0x65, 0x00, 0x00, 0x00,
	0x07, 0x72, 0x65, 0x66, 0x65, 0x72, 0x65, 0x72,
	0x00, 0x00, 0x00, 0x0b, 0x72, 0x65, 0x74, 0x72,
	0x79, 0x2d, 0x61, 0x66, 0x74, 0x65, 0x72, 0x00,
	0x00, 0x00, 0x06, 0x73, 0x65, 0x72, 0x76, 0x65,
	0x72, 0x00, 0x00, 0x00, 0x02, 0x74, 0x65, 0x00,
	0x00, 0x00, 0x07, 0x74, 0x72, 0x61, 0x69, 0x6c,
	0x65, 0x72, 0x00, 0x00, 0x00, 0x11, 0x74, 0x72,
	0x61, 0x6e, 0x73, 0x66, 0x65, 0x72, 0x2d, 0x65,
	0x6e, 0x63, 0x6f, 0x64, 0x69, 0x6e, 0x67, 0x00,
	0x00, 0x00, 0x07, 0x75, 0x70, 0x67, 0x72, 0x61,
	0x64, 0x65, 0x00, 0x00, 0x00, 0x0a, 0x75, 0x73,
	0x65, 0x72, 0x2d, 0x61, 0x67, 0x65, 0x6e, 0x74,
	0x00, 0x00, 0x00, 0x04, 0x76, 0x61, 0x72, 0x79,
	0x00, 0x00, 0x00, 0x03, 0x76, 0x69, 0x61, 0x00,
	0x00, 0x00, 0x07, 0x77, 0x61, 0x72, 0x6e, 0x69,
	0x6e, 0x67, 0x00, 0x00, 0x00, 0x10, 0x77, 0x77,
	0x77, 0x2d, 0x61, 0x75, 0x74, 0x68, 0x65, 0x6e,
	0x74, 0x69, 0x63, 0x61, 0x74, 0x65, 0x00, 0x00,
	0x00, 0x06, 0x6d, 0x65, 0x74, 0x68, 0x6f, 0x64,
	0x00, 0x00, 0x00, 0x03, 0x67, 0x65, 0x74, 0x00,
	0x00, 0x00, 0x06, 0x73, 0x74, 0x61, 0x74, 0x75,
	0x73, 0x00, 0x00, 0x00, 0x06, 0x32, 0x30, 0x30,
	0x20, 0x4f, 0x4b, 0x00, 0x00, 0x00, 0x07, 0x76,
	0x65, 0x72, 0x73, 0x69, 0x6f, 0x6e, 0x00, 0x00,
	0x00, 0x08, 0x48, 0x54, 0x54, 0x50, 0x2f, 0x31,
	0x2e, 0x31, 0x00, 0x00, 0x00, 0x03, 0x75, 0x72,
	0x6c, 0x00, 0x00, 0x00, 0x06, 0x70, 0x75, 0x62,
	0x6c, 0x69, 0x63, 0x00, 0x00, 0x00, 0x0a, 0x73,
	0x65, 0x74, 0x2d, 0x63, 0x6f, 0x6f, 0x6b, 0x69,
	0x65, 0x00, 0x00, 0x00, 0x0a, 0x6b, 0x65, 0x65,
	0x70, 0x2d, 0x61, 0x6c, 0x69, 0x76, 0x65, 0x00,
	0x00, 0x00, 0x06, 0x6f, 0x72, 0x69, 0x67, 0x69,
	0x6e, 0x31, 0x30, 0x30, 0x31, 0x30, 0x31, 0x32,
	0x30, 0x31, 0x32, 0x30, 0x32, 0x32, 0x30, 0x35,
	0x32, 0x30, 0x36, 0x33, 0x30, 0x30, 0x33, 0x30,
	0x32, 0x33, 0x30, 0x33, 0x33, 0x30, 0x34, 0x33,
	0x30, 0x35, 0x33, 0x30, 0x36, 0x33, 0x30, 0x37,
	0x34, 0x30, 0x32, 0x34, 0x30, 0x35, 0x34, 0x30,
	0x36, 0x34, 0x30, 0x37, 0x34, 0x30, 0x38, 0x34,
	0x30, 0x39, 0x34, 0x31, 0x30, 0x34, 0x31, 0x31,
	0x34, 0x31, 0x32, 0x34, 0x31, 0x33, 0x34, 0x31,
	0x34, 0x34, 0x31, 0x35, 0x34, 0x31, 0x36, 0x34,
	0x31, 0x37, 0x35, 0x30, 0x32, 0x35, 0x30, 0x34,
	0x35, 0x30, 0x35, 0x32, 0x30, 0x33, 0x20, 0x4e,
	0x6f, 0x6e, 0x2d, 0x41, 0x75, 0x74, 0x68, 0x6f,
	0x72, 0x69, 0x74, 0x61, 0x74, 0x69, 0x76, 0x65,
	0x20, 0x49, 0x6e, 0x66, 0x6f, 0x72, 0x6d, 0x61,
	0x74, 0x69, 0x6f, 0x6e, 0x32, 0x30, 0x34, 0x20,
	0x4e, 0x6f, 0x20, 0x43, 0x6f, 0x6e, 0x74, 0x65,
	0x6e, 0x74, 0x33, 0x30, 0x31, 0x20, 0x4d, 0x6f,
	0x76, 0x65, 0x64, 0x20, 0x50, 0x65, 0x72, 0x6d,
	0x61, 0x6e, 0x65, 0x6e, 0x74, 0x6c, 0x79, 0x34,
	0x30, 0x30, 0x20, 0x42, 0x61, 0x64, 0x20, 0x52,
	0x65, 0x71, 0x75, 0x65, 0x73, 0x74, 0x34, 0x30,
	0x31, 0x20, 0x55, 0x6e, 0x61, 0x75, 0x74, 0x68,
	0x6f, 0x72, 0x69, 0x7a, 0x65, 0x64, 0x34, 0x30,
	0x33, 0x20, 0x46, 0x6f, 0x72, 0x62, 0x69, 0x64,
	0x64, 0x65, 0x6e, 0x34, 0x30, 0x34, 0x20, 0x4e,
	0x6f, 0x74, 0x20, 0x46, 0x6f, 0x75, 0x6e, 0x64,
	0x35, 0x30, 0x30, 0x20, 0x49, 0x6e, 0x74, 0x65,
	0x72, 0x6e, 0x61, 0x6c, 0x20, 0x53, 0x65, 0x72,
	0x76, 0x65, 0x72, 0x20, 0x45, 0x72, 0x72, 0x6f,
	0x72, 0x35, 0x30, 0x31, 0x20, 0x4e, 0x6f, 0x74,
	0x20, 0x49, 0x6d, 0x70, 0x6c, 0x65, 0x6d, 0x65,
	0x6e, 0x74, 0x65, 0x64, 0x35, 0x30, 0x33, 0x20,
	0x53, 0x65, 0x72, 0x76, 0x69, 0x63, 0x65, 0x20,
	0x55, 0x6e, 0x61, 0x76, 0x61, 0x69, 0x6c, 0x61,
	0x62, 0x6c, 0x65, 0x4a, 0x61, 0x6e, 0x20, 0x46,
	0x65, 0x62, 0x20, 0x4d, 0x61, 0x72, 0x20, 0x41,
	0x70, 0x72, 0x20, 0x4d, 0x61, 0x79, 0x20, 0x4a,
	0x75, 0x6e, 0x20, 0x4a, 0x75, 0x6c, 0x20, 0x41,
	0x75, 0x67, 0x20, 0x53, 0x65, 0x70, 0x74, 0x20,
	0x4f, 0x63, 0x74, 0x20, 0x4e, 0x6f, 0x76, 0x20,
	0x44, 0x65, 0x63, 0x20, 0x30, 0x30, 0x3a, 0x30,
	0x30, 0x3a, 0x30, 0x30, 0x20, 0x4d, 0x6f, 0x6e,
	0x2c, 0x20, 0x54, 0x75, 0x65, 0x2c, 0x20, 0x57,
	0x65, 0x64, 0x2c, 0x20, 0x54, 0x68, 0x75, 0x2c,
	0x20, 0x46, 0x72, 0x69, 0x2c, 0x20, 0x53, 0x61,
	0x74, 0x2c, 0x20, 0x53, 0x75, 0x6e, 0x2c, 0x20,
	0x47, 0x4d, 0x54, 0x63, 0x68, 0x75, 0x6e, 0x6b,
	0x65, 0x64, 0x2c, 0x74, 0x65, 0x78, 0x74, 0x2f,
	0x68, 0x74, 0x6d, 0x6c, 0x2c, 0x69, 0x6d, 0x61,
	0x67, 0x65, 0x2f, 0x70, 0x6e, 0x67, 0x2c, 0x69,
	0x6d, 0x61, 0x67, 0x65, 0x2f, 0x6a, 0x70, 0x67,
	0x2c, 0x69, 0x6d, 0x61, 0x67, 0x65, 0x2f, 0x67,
	0x69, 0x66, 0x2c, 0x61, 0x70, 0x70, 0x6c, 0x69,
	0x63, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x2f, 0x78,
	0x6d, 0x6c, 0x2c, 0x61, 0x70, 0x70, 0x6c, 0x69,
	0x63, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x2f, 0x78,
	0x68, 0x74, 0x6d, 0x6c, 0x2b, 0x78, 0x6d, 0x6c,
	0x2c, 0x74, 0x65, 0x78, 0x74, 0x2f, 0x70, 0x6c,
	0x61, 0x69, 0x6e, 0x2c, 0x74, 0x65, 0x78, 0x74,
	0x2f, 0x6a, 0x61, 0x76, 0x61, 0x73, 0x63, 0x72,
	0x69, 0x70, 0x74, 0x2c, 0x70, 0x75, 0x62, 0x6c,
	0x69, 0x63, 0x70, 0x72, 0x69, 0x76, 0x61, 0x74,
	0x65, 0x6d, 0x61, 0x78, 0x2d, 0x61, 0x67, 0x65,
	0x3d, 0x67, 0x7a, 0x69, 0x70, 0x2c, 0x64, 0x65,
	0x66, 0x6c, 0x61, 0x74, 0x65, 0x2c, 0x73, 0x64,
	0x63, 0x68, 0x63, 0x68, 0x61, 0x72, 0x73, 0x65,
	0x74, 0x3d, 0x75, 0x74, 0x66, 0x2d, 0x38, 0x63,
	0x68, 0x61, 0x72, 0x73, 0x65, 0x74, 0x3d, 0x69,
	0x73, 0x6f, 0x2d, 0x38, 0x38, 0x35, 0x39, 0x2d,
	0x31, 0x2c, 0x75, 0x74, 0x66, 0x2d, 0x2c, 0x2a,
	0x2c, 0x65, 0x6e, 0x71, 0x3d, 0x30, 0x2e
										};
	}
}
