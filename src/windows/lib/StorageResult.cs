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

using Newtonsoft.Json;

namespace JSONStoreWin8
{

    public sealed class StorageResult
    {
        public string value { get; private set; }
        public Status statusCode { get; private set; }

        private static readonly string[] StatusMessages = new string[] 
		{
			"No result",
			"OK",
			"Error"
		};

        public bool isSuccess
        {
            get { return this.statusCode == Status.NO_RESULT || this.statusCode == Status.OK; }
        }

        public StorageResult(Status status)
            : this(status, StorageResult.StatusMessages[(int) status])
        {
        }

        public StorageResult(Status status, object message)
        {
            this.value = JsonConvert.SerializeObject(message);
            this.statusCode = status;
        }
    }

    public enum Status : int
    {
        NO_RESULT = 0,
        OK,
        ERROR
    }

}