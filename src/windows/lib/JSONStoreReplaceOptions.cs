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

using System.Collections.Generic;

namespace JSONStoreWin8Lib.JSONStore
{
    public class JSONStoreReplaceOptions
    {
        public bool isRefresh { get; set; }
        public bool markDirty { get; set; }
        public bool addNew { get; set; }
        public string[] replaceCriteria { get; set; }
    }
}
