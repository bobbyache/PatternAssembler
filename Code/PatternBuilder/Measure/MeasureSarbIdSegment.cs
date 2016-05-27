using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PatternAssembler;

namespace PatternBuilder.Measure
{
   public class MeasureSarbIdSegment : Segment
   {
      public MeasureSarbIdSegment(string value, int ordinal)
         : base(value, ordinal)
      {
      }

      public override string GetCode()
      {
         return "SARBID" + base.Ordinal;
      }
   }
}
