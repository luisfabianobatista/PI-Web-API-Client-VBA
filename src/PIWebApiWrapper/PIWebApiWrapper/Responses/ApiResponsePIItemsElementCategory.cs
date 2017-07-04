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
	[Guid("985B2716-0A2C-4084-AC69-24D8030C0107")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsElementCategory
	{
		[DispId(1)]
		PIItemsElementCategory Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("B29BF010-49D5-4EA0-876F-4263CA195288")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsElementCategory))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsElementCategory")]
	public class ApiResponsePIItemsElementCategory : ApiParentResponse, IApiResponsePIItemsElementCategory
	{
		public PIItemsElementCategory Data { get; set; }
		public ApiResponsePIItemsElementCategory(int statusCode, IDictionary<string, string> headers, PIItemsElementCategory data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
