﻿/**
 * Copyright 2019 d-fens GmbH
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

using System.Linq;
using System.Reflection;
using biz.dfch.CS.Playground.Fynn._20190830;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace biz.dfch.CS.Playground.Fynn.Tests._20190830
{
    [TestClass]
    public class MiddleManNoRegistrationAttributeTest
    {
        [TestMethod]
        public void SearchForTypesWithMiddleManNoRegistrationAttributeFindsClassWithMiddleManNoRegistrationAttribute()
        {
            // Arrange
            var types = typeof(MiddleManNoRegistrationAttribute).Assembly.GetTypes();

            // Act
            var result = types.Where(t => t.GetCustomAttributes<MiddleManNoRegistrationAttribute>().Any());

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Contains(typeof(ClassWithMiddleManNoRegistrationAttribute)));
        }
    }
}