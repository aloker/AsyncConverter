﻿using System;
using System.Threading.Tasks;

namespace AsyncConverter.Tests.Test.Data.FixReturnValueToTaskTests
{
    public class Class
    {
        public Func<Task<int>> Test()
        {
            return () => {caret}null;
        }
    }
}
