using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorsDataaResult<T> : DataResult<T>
    {
        public ErrorsDataaResult(T data, string message) : base(data, false, message)
        {

        }

        public ErrorsDataaResult(T data) : base(data, false)
        {

        }

        public ErrorsDataaResult(string message) : base(default, false, message)
        {

        }

        public ErrorsDataaResult() : base(default, false)
        {

        }
    }
}
