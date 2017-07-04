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
	[Guid("4E2F008C-8855-4598-A392-445FCBF9B46D")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsItemAttribute
	{
		[DispId(1)]
		PIItemsItemAttribute Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("961DF4D7-4DF5-409B-A450-DC5DB053757E")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsItemAttribute))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsItemAttribute")]
	public class ApiResponsePIItemsItemAttribute : ApiParentResponse, IApiResponsePIItemsItemAttribute
	{
		public PIItemsItemAttribute Data { get; set; }
		public ApiResponsePIItemsItemAttribute(int statusCode, IDictionary<string, string> headers, PIItemsItemAttribute data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
