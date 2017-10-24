using Marvin.JsonPatch.Operations;

namespace Marvin.JsonPatch.Adapters
{
    public interface IObjectAdapterNew
    {
        void Add(OperationNew operation, object objectToApplyTo);
        void Copy(OperationNew operation, object objectToApplyTo);
        void Move(OperationNew operation, object objectToApplyTo);
        void Remove(OperationNew operation, object objectToApplyTo);
        void Replace(OperationNew operation, object objectToApplyTo);
    }
}
