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
	[Guid("F3CF99CC-C889-4B25-B05F-5413C8B79C25")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsPoint
	{
		[DispId(1)]
		PIItemsPoint Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("BEFD7F46-711F-4E18-833A-B120E441A301")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsPoint))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsPoint")]
	public class ApiResponsePIItemsPoint : ApiParentResponse, IApiResponsePIItemsPoint
	{
		public PIItemsPoint Data { get; set; }
		public ApiResponsePIItemsPoint(int statusCode, IDictionary<string, string> headers, PIItemsPoint data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
