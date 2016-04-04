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
using System.Linq;

namespace JSONStoreWin8Lib.JSONStore
{
    class JSONStoreSchema
    {
        private IDictionary<string, string> searchFields;
        private IDictionary<string, string> additionalSearchFields;

        public JSONStoreSchema(IDictionary<string, string> searchFields, IDictionary<string, string> additionalSearchFields)
        {
            this.searchFields = searchFields;
            this.additionalSearchFields = additionalSearchFields;
        }

        public IDictionary<string, string> getCombinedDictionary()
        {
            if (searchFields == null && additionalSearchFields == null)
            {
                return new Dictionary<string, string>();
            } 
            else if (additionalSearchFields == null)
            {
                return searchFields;
            } 
            else if (searchFields == null)
            {
                return additionalSearchFields;
            }
            return searchFields.Union(additionalSearchFields).ToDictionary(s => s.Key, s => s.Value);
        }

        public ICollection<string> getKeys()
        {
            return searchFields.Keys;
        }
    }
}
