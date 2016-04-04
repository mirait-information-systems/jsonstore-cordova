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

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace JSONStoreWin8Lib.JSONStore
{
    public class JSONStoreException : System.Exception
    {
        public int errorCode { get; set; }
        public JArray data { get; set; }

        public JSONStoreException()
        {
        }

        public JSONStoreException(string message)
        {
        }

        public JSONStoreException(string message, Exception inner)
        {
        }

        public JSONStoreException(int errorCode)
        {
            this.errorCode = errorCode;
        }

        public JSONStoreException(int errorCode, JArray data)
        {
            this.errorCode = errorCode;
            this.data = data;
        }
    }
}
