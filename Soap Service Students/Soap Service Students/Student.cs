using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Soap_Service_Students
{
	[DataContract]
	public class Student
	{
		[DataMember]
		public string Name { get; set; }

		[DataMember]
		public int ID { get; set; }
	}
}