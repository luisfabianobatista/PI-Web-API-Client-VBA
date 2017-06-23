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

	[Guid("1D6F0E86-6A8C-4A49-A748-66CD116AF2D6")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPITimeRulePlugIn
	{
		[DispId(1)]
		string WebId { get; set; }

		[DispId(2)]
		string Id { get; set; }

		[DispId(3)]
		string Name { get; set; }

		[DispId(4)]
		string Description { get; set; }

		[DispId(5)]
		string Path { get; set; }

		[DispId(6)]
		string AssemblyFileName { get; set; }

		[DispId(7)]
		string AssemblyID { get; set; }

		[DispId(8)]
		string[] AssemblyLoadProperties { get; set; }

		[DispId(9)]
		string AssemblyTime { get; set; }

		[DispId(10)]
		int CompatibilityVersion { get; set; }

		[DispId(11)]
		bool IsBrowsable { get; set; }

		[DispId(12)]
		bool IsNonEditableConfig { get; set; }

		[DispId(13)]
		string LoadedAssemblyTime { get; set; }

		[DispId(14)]
		string LoadedVersion { get; set; }

		[DispId(15)]
		string Version { get; set; }

		[DispId(16)]
		object Links { get; set; }

	}

	[Guid("637CAF6B-B625-49C4-B098-82FD331074EF")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPITimeRulePlugIn))]
	[ProgId("PIWebAPIWrapper.PITimeRulePlugIn")]
	[DataContract]

	public class PITimeRulePlugIn : IPITimeRulePlugIn
	{
		public PITimeRulePlugIn()
		{
		}

		[DataMember(Name = "WebId", EmitDefaultValue = false)]
		public string WebId { get; set; }

		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public string Id { get; set; }

		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

		[DataMember(Name = "AssemblyFileName", EmitDefaultValue = false)]
		public string AssemblyFileName { get; set; }

		[DataMember(Name = "AssemblyID", EmitDefaultValue = false)]
		public string AssemblyID { get; set; }

		[DataMember(Name = "AssemblyLoadProperties", EmitDefaultValue = false)]
		public string[] AssemblyLoadProperties { get; set; }

		[DataMember(Name = "AssemblyTime", EmitDefaultValue = false)]
		public string AssemblyTime { get; set; }

		[DataMember(Name = "CompatibilityVersion", EmitDefaultValue = false)]
		public int CompatibilityVersion { get; set; }

		[DataMember(Name = "IsBrowsable", EmitDefaultValue = false)]
		public bool IsBrowsable { get; set; }

		[DataMember(Name = "IsNonEditableConfig", EmitDefaultValue = false)]
		public bool IsNonEditableConfig { get; set; }

		[DataMember(Name = "LoadedAssemblyTime", EmitDefaultValue = false)]
		public string LoadedAssemblyTime { get; set; }

		[DataMember(Name = "LoadedVersion", EmitDefaultValue = false)]
		public string LoadedVersion { get; set; }

		[DataMember(Name = "Version", EmitDefaultValue = false)]
		public string Version { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}