﻿using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
 public class SuccessDataResult<T>: DataResult<T>
    {
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {

        }

        public SuccessDataResult(T data) : base(data, true)
        {

        }

        public SuccessDataResult(String message) : base(default, true, message)
        {

        }

        public SuccessDataResult() : base(default, true)
        {

        }


    }
}
