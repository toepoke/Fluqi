using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.IO;

namespace Fluqi.Tests.Mocks
{

	public class MockWriter: TextWriter
	{
		private StringBuilder _Resp = new StringBuilder();

		public System.IO.TextWriter Output
		{
			get
			{
				var sw = new System.IO.StringWriter(_Resp);
				return sw;					
			}
		}

		public override void Write(string s)
		{
			_Resp.Append(s);
		}

		public override Encoding Encoding {
			get { throw new NotImplementedException(); }
		}
	}

}
