using Marvin.JsonPatch.Operations;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace Marvin.JsonPatch
{
    public interface IJsonPatchDocumentNew
    {
        IContractResolver ContractResolver { get; set; }

        IList<OperationNew> GetOperations();
    }
}
