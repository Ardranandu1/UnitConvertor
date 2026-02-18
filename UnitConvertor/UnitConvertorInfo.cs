using System;
using System.Drawing;
using Grasshopper;
using Grasshopper.Kernel;

namespace UnitConvertor
{
    public class UnitConvertorInfo : GH_AssemblyInfo
    {
        public override string Name => "UnitConvertor";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("dc9492db-3ac7-4743-83e4-316531ec37ae");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}