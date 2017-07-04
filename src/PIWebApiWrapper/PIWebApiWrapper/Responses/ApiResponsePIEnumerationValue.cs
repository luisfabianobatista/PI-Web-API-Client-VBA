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
	[Guid("B6F59436-54F2-4A09-BA96-4777FFB24B08")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIEnumerationValue
	{
		[DispId(1)]
		PIEnumerationValue Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("83E03411-5DDA-491A-A94D-068EFFD99EC1")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIEnumerationValue))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIEnumerationValue")]
	public class ApiResponsePIEnumerationValue : ApiParentResponse, IApiResponsePIEnumerationValue
	{
		public PIEnumerationValue Data { get; set; }
		public ApiResponsePIEnumerationValue(int statusCode, IDictionary<string, string> headers, PIEnumerationValue data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
