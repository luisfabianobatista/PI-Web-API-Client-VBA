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
	[Guid("8CE9414D-59D4-46A5-BAAA-F661BD76A4F9")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePISubstatus
	{
		[DispId(1)]
		PISubstatus Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("64852459-8C44-48F5-993D-40F4E7D20DF0")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePISubstatus))]
	[ProgId("PIWebAPIWrapper.ApiResponsePISubstatus")]
	public class ApiResponsePISubstatus : ApiParentResponse, IApiResponsePISubstatus
	{
		public PISubstatus Data { get; set; }
		public ApiResponsePISubstatus(int statusCode, IDictionary<string, string> headers, PISubstatus data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
