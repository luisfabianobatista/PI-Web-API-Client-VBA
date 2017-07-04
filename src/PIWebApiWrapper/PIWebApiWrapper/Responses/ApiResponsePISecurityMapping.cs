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
	[Guid("650DED6F-D41F-4675-840E-1D2889CA1917")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePISecurityMapping
	{
		[DispId(1)]
		PISecurityMapping Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("6CA9EC68-A1BF-42C6-8361-E0C452C8D26A")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePISecurityMapping))]
	[ProgId("PIWebAPIWrapper.ApiResponsePISecurityMapping")]
	public class ApiResponsePISecurityMapping : ApiParentResponse, IApiResponsePISecurityMapping
	{
		public PISecurityMapping Data { get; set; }
		public ApiResponsePISecurityMapping(int statusCode, IDictionary<string, string> headers, PISecurityMapping data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
