using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Zzkluck
{
	public class StringPlus
	{
		private string label;

		public string Label
		{
			get { return label; }
			set { label = value; }
		}

		public string ConvertWithXml(XmlElement rootElem)
		{
			XmlNodeList labelNodes = rootElem.GetElementsByTagName(label);
			if (labelNodes.Count != 0) {
				Label = labelNodes[0].InnerText;
			}
			return label;
		}
	}

}
