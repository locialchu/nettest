// <copyright file="CalculatorTest.cs" company="Microsoft">版权所有(C) Microsoft 2018</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebTest.Controllers;

namespace WebTest.Controllers.Tests
{
    /// <summary>此类包含 Calculator 的参数化单元测试</summary>
    [PexClass(typeof(Calculator))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class CalculatorTest
    {
        /// <summary>测试 Addition(Decimal, Decimal) 的存根</summary>
        [PexMethod]
        public decimal AdditionTest(
            [PexAssumeUnderTest]Calculator target,
            decimal x,
            decimal y
        )
        {
            decimal result = target.Addition(x, y);
            return result;
            // TODO: 将断言添加到 方法 CalculatorTest.AdditionTest(Calculator, Decimal, Decimal)
        }
    }
}
