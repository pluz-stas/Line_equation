// <copyright file="Line_eq_formTest.cs">Copyright ©  2018</copyright>
using System;
using Line_equation;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Line_equation.Tests
{
    /// <summary>Этот класс содержит параметризованные модульные тесты для Line_eq_form</summary>
    [PexClass(typeof(Line_eq_form))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class Line_eq_formTest
    {
        /// <summary>Тестовая заглушка для .ctor()</summary>
        [PexMethod]
        public Line_eq_form ConstructorTest()
        {
            Line_eq_form target = new Line_eq_form();
            return target;
            // TODO: добавление проверочных утверждений в метод Line_eq_formTest.ConstructorTest()
        }
    }
}
