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
    public class JSONStoreProvisionOptions
    {
        // security
        public string username { get; set; }
        public string collectionPassword { get; set; }
        public string secureRandom { get; set; }
        public bool localKeyGen { get; set; }

        public IDictionary<string, string> additionalSearchFields { get; set; }
        public bool dropCollection { get; set; }
    }
}
