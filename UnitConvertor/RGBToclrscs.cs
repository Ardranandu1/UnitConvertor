using Grasshopper.Kernel;
using Rhino.Geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Claims;

namespace UnitConvertor
{
    public class RGBToclrscs : GH_Component
    {
        /// <summary>
        /// Initializes a new instance of the RGBToclrscs class.
        /// </summary>
        public RGBToclrscs()
          : base("RGBToclrscs", "Nickname",
              "Converts RGB Values into a Color",
              "UnitConvertor", "Display")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {

            pManager.AddIntegerParameter("R1", "R", "Red value (0-255)", GH_ParamAccess.item,255);
            pManager.AddIntegerParameter("G1", "G", "Green value (0-255)", GH_ParamAccess.item,255);
            pManager.AddIntegerParameter("B1", "B", "Blue value (0-255)", GH_ParamAccess.item,255); 
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddColourParameter("Color", "C", "Output color", GH_ParamAccess.item);
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object is used to retrieve from inputs and store in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            int r = 0, g = 0, b = 0;
            if (!DA.GetData(0, ref r)) return;
            if (!DA.GetData(1, ref g)) return;
            if (!DA.GetData(2, ref b)) return;


            // Clamp values to the valid range of 0-255
            r = Clamp255(r);
            g = Clamp255(g);
            b = Clamp255(b);
            Color color = Color.FromArgb(r, g, b);
            DA.SetData(0, color);
        }


        private int Clamp255(int value)
        {
            if (value < 0) return 0;
            if (value > 255) return 255;
            return value;
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
            get { return new Guid("E6B13CCF-17BF-4280-AC3E-DF5D6149201F"); }
        }
    }
}