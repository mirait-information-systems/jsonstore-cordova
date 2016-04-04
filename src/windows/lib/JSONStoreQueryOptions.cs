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
    public class JSONStoreQueryOptions
    {
        public int limit 
        { 
            get { return _limit.GetValueOrDefault(0); }
            set { _limit = value; } 
        }
        private int? _limit;

        public int offset { get; set; }
        public bool exact { get; set; }
        public string[] filter { get; set; }
        public JArray sort { get; set; }

        public bool hasLimit{ get {return _limit.HasValue; } }
    }
}
