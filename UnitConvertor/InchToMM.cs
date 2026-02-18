using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Geometry;

namespace UnitConvertor
{
    public class InchToMM : GH_Component
    {
        /// <summary>
        /// Initializes a new instance of the InchToMM class.
        /// </summary>
        public InchToMM()
          : base("InchToMM", "IN",
              "Converts Inch to MM",
              "UnitConverter", "Utilities")
        {
            
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddNumberParameter("Inches", "IN", "Value in Inches", GH_ParamAccess.item);

        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddNumberParameter("Millimeters", "MM", "Value in Millimeters", GH_ParamAccess.item);

        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object is used to retrieve from inputs and store in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            double inches = 0.0;
            if (!DA.GetData(0, ref inches)) return;  //retreiving the data
            double millimeters = inches * 25.4;
            DA.SetData(0, millimeters);
        }

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                //You can add image files to your project resources and access them like this:
                // return Resources.IconForThisComponent;
                return null;
            }
        }

        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("5754F93E-FDE6-4CD8-80BD-27EA3C0E07B7"); }
        }
    }
}