using System;
using System.Data;

namespace USC.GISResearchLab.Geocoding.Core.Metadata.FeatureMatchingResults
{



    public class FeatureMatchingResultTypeManager
    {
        public static DataTable GetAllFeatureMatchingGeographyTypes()
        {
            DataTable ret = new DataTable();
            ret.Columns.Add(new DataColumn("value", typeof(string)));

            foreach (FeatureMatchingGeographyType item in Enum.GetValues(typeof(FeatureMatchingGeographyType)))
            {
                DataRow row = ret.NewRow();
                row["value"] = item.ToString();
                ret.Rows.Add(row);
            }

            return ret;
        }

        public static DataTable GetAllFeatureMatchingResultType()
        {
            DataTable ret = new DataTable();
            ret.Columns.Add(new DataColumn("value", typeof(string)));

            foreach (FeatureMatchingResultType item in Enum.GetValues(typeof(FeatureMatchingResultType)))
            {
                DataRow row = ret.NewRow();
                row["value"] = item.ToString();
                ret.Rows.Add(row);
            }

            return ret;
        }
    }
}
