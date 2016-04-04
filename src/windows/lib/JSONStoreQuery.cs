/*
 * IBM Confidential OCO Source Materials
 * 
 * 5725-I43 Copyright IBM Corp. 2014
 * 
 * The source code for this program is not published or otherwise
 * divested of its trade secrets, irrespective of what has
 * been deposited with the U.S. Copyright Office.
 * 
*/

using Newtonsoft.Json.Linq;

namespace JSONStoreWin8Lib.JSONStore
{
    public class JSONStoreQuery
    {
        public JArray lessThan { get; set; }
        public JArray lessOrEqualThan { get; set; }
        public JArray greaterThan { get; set; }
        public JArray greaterOrEqualThan { get; set; }
        public JArray like { get; set; }
        public JArray notLike { get; set; }
        public JArray rightLike { get; set; }
        public JArray leftLike { get; set; }
        public JArray notRightLike { get; set; }
        public JArray notLeftLike { get; set; }
        public JArray equal { get; set; }
        public JArray notEqual { get; set; }
        public JArray inside { get; set; }
        public JArray notInside { get; set; }
        public JArray between { get; set; }
        public JArray notBetween { get; set; }
        public JArray ids { get; set; }
    }
}
