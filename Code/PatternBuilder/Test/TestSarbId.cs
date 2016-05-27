using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PatternAssembler;

namespace PatternBuilder.Test
{
   public class TestSarbId : Segment
   {
      public TestSarbId(string value, int ordinal)
         : base(value, ordinal)
      {
      }

      public override string GetCode()
      {
         return "[#SARB_ID_" + base.Ordinal.ToString() + "#]";
      }
   }
}
