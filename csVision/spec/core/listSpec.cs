using NUnit.Framework;
using System;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using static csVision.Static;
namespace csVision {
	[TestFixture ()]
    public class listSpec {
		[Test ()]
        public void list ()
		{
            
		    list msg = new num[] {3, 4};
		    
            Assert.AreEqual(msg.asNum,3);
			Assert.AreEqual(msg.rest.asNum,4);

            last last = msg;
            Assert.AreEqual(last.asNum,4);
		}

	}

    public static class Static
    {
        
    }
}
