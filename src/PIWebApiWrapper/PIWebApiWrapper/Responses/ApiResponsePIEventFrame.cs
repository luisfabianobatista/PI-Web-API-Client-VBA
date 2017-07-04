// ************************************************************************
//
// * Copyright 2017 OSIsoft, LLC
// * Licensed under the Apache License, Version 2.0 (the "License");
// * you may not use this file except in compliance with the License.
// * You may obtain a copy of the License at
// * 
// *   <http://www.apache.org/licenses/LICENSE-2.0>
// * 
// * Unless required by applicable law or agreed to in writing, software
// * distributed under the License is distributed on an "AS IS" BASIS,
// * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// * See the License for the specific language governing permissions and
// * limitations under the License.
// ************************************************************************

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using PIWebAPIWrapper.Client;
using System.Runtime.InteropServices;
using PIWebAPIWrapper.Model;

namespace PIWebAPIWrapper.Responses
{
	[Guid("94D55A1C-3F7C-4604-9BD5-2A008E7BD77D")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIEventFrame
	{
		[DispId(1)]
		PIEventFrame Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("03CB420E-330B-4946-8C5E-AB49C8881A52")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIEventFrame))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIEventFrame")]
	public class ApiResponsePIEventFrame : ApiParentResponse, IApiResponsePIEventFrame
	{
		public PIEventFrame Data { get; set; }
		public ApiResponsePIEventFrame(int statusCode, IDictionary<string, string> headers, PIEventFrame data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
