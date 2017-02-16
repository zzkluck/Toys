using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zzkluck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Zzkluck.Tests
{
	[TestClass()]
	public class StringPlusTests
	{
		[TestMethod()]
		public void ConvertWithXmlTest()
		{
			StringPlus test = new StringPlus();
			test.Label = "test";

			XmlDocument xd = new XmlDocument();
			xd.Load("../../XmlFile1.xml");
			test.ConvertWithXml(xd.DocumentElement);

			Assert.AreEqual(test.Label, "测试");
		}
	}
}