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
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using PIWebAPIWrapper.Client;
using System.Runtime.InteropServices;

namespace PIWebAPIWrapper.Model
{

	[Guid("8F9D016E-D7E3-4F1B-B03E-386FF93D051A")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsItemPoint
	{
		[DispId(1)]
		PIItemPoint[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIItemPoint GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIItemPoint values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("BBF8AAE2-DCAF-484E-8329-7AE5E47E0898")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsItemPoint))]
	[ProgId("PIWebAPIWrapper.PIItemsItemPoint")]
	[DataContract]

	public class PIItemsItemPoint : IPIItemsItemPoint
	{
		public PIItemsItemPoint()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIItemPoint[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIItemPoint GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIItemPoint values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIItemPoint[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
