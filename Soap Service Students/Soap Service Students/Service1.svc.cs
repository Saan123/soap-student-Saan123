﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Soap_Service_Students
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
	public class Service1 : IService1
	{
		public Student AddStudent(Student student)
		{
			throw new NotImplementedException();
		}

		public Student RemoveStudent(Student student)
		{
			throw new NotImplementedException();
		}

		public Student EditStudent(Student student)
		{
			throw new NotImplementedException();
		}

		public Student FindStudent(string name)
		{
			throw new NotImplementedException();
		}

		public List<Student> GetAllStudents(Student student)
		{
			throw new NotImplementedException();
		}

		public string GetData(int value)
		{
			return string.Format("You entered: {0}", value);
		}

		public CompositeType GetDataUsingDataContract(CompositeType composite)
		{
			if (composite == null)
			{
				throw new ArgumentNullException("composite");
			}
			if (composite.BoolValue)
			{
				composite.StringValue += "Suffix";
			}
			return composite;
		}

	}
}
