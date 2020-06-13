﻿// Authors:
//   jmedrano <josmed@microsoft.com>
//
// Copyright (C) 2020 Microsoft, Corp
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to permit
// persons to whom the Software is furnished to do so, subject to the
// following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
// OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN
// NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
// OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE
// USE OR OTHER DEALINGS IN THE SOFTWARE.
using System;
using FigmaSharp.Models;
using FigmaSharp.Services;
using NUnit.Framework;

namespace Services
{
    [TestFixture (TestName = "CodeNameService")]
    public class CodeNameServiceTest
    {
        [Test]
        public void HasName()
        {
            var codeGenerator = new CodeNameService ();
            var node = new FigmaNode() { name = "node" };
            var codeNode = new CodeNode(node);
            Assert.IsFalse (codeGenerator.NodeHasName(codeNode));
            codeNode.Name = "myCustom";
            Assert.IsTrue(codeGenerator.NodeHasName(codeNode));
        }
    }
}
