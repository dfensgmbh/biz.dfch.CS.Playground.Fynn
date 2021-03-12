﻿/**
 * Copyright 2021 d-fens GmbH
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Collections.Generic;
using biz.dfch.CS.Playground.Fynn._20210304;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace biz.dfch.CS.Playground.Fynn.Tests._20210304
{
    [TestClass]

    public class FileCheckerTest
    {


        [TestMethod]
        [DataRow("texttext.txt")]
        [DataRow("texttext.csv")]
        [DataRow("texttext.docx")]
        public void Test(string filePath)
        {
            var sut = new FileChecker();
            var allowedFileEndings = new List<string>() {"txt", "csv", "docx"};

            sut.CheckFileEnding(allowedFileEndings, filePath);
        }
    }
}