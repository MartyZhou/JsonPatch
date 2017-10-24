﻿using Marvin.JsonPatch.Adapters;
using Marvin.JsonPatch.Exceptions;
using Marvin.JsonPatch.Properties;
using System;

namespace Marvin.JsonPatch.Operations
{
    public class OperationNew<TModel> : OperationNew where TModel : class
    {
        public OperationNew()
        {

        }

        public OperationNew(string op, string path, string from, object value)
            : base(op, path, from)
        {
            if (op == null)
            {
                throw new ArgumentNullException(nameof(op));
            }

            if (path == null)
            {
                throw new ArgumentNullException(nameof(path));
            }

            this.value = value;
        }

        public OperationNew(string op, string path, string from)
            : base(op, path, from)
        {
            if (op == null)
            {
                throw new ArgumentNullException(nameof(op));
            }
            if (path == null)
            {
                throw new ArgumentNullException(nameof(path));
            }

        }

        public void Apply(TModel objectToApplyTo, IObjectAdapterNew adapter)
        {
            if (objectToApplyTo == null)
            {
                throw new ArgumentNullException(nameof(objectToApplyTo));
            }

            if (adapter == null)
            {
                throw new ArgumentNullException(nameof(adapter));
            }

            switch (OperationType)
            {
                case OperationType.Add:
                    adapter.Add(this, objectToApplyTo);
                    break;
                case OperationType.Remove:
                    adapter.Remove(this, objectToApplyTo);
                    break;
                case OperationType.Replace:
                    adapter.Replace(this, objectToApplyTo);
                    break;
                case OperationType.Move:
                    adapter.Move(this, objectToApplyTo);
                    break;
                case OperationType.Copy:
                    adapter.Copy(this, objectToApplyTo);
                    break;
                case OperationType.Test:
                    throw new NotImplementedException("Test is currently not implemented.");
                case OperationType.Invalid:
                    throw new JsonPatchException(
                        Resources.FormatInvalidJsonPatchOperation(op), innerException: null);
                default:
                    break;
            }
        }

    }
}
