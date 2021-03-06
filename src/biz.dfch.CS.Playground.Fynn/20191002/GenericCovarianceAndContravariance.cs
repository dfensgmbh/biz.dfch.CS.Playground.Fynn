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

using System;
using System.Collections;
using System.Collections.Generic;

namespace biz.dfch.CS.Playground.Fynn._20191002
{
    public class GenericCovarianceAndContravariance : IEnumerable<GenericCovarianceAndContravariance>
    {
        public IEnumerator<GenericCovarianceAndContravariance> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class HelperGenericCovarianceAndContravariance
    {
        public IEnumerable<GenericCovarianceAndContravariance> MyEnumerable = null;

        public void ObjectEnumerableGenericType(IEnumerable<object> objects)
        {
            // Do Stuff
        }

        public IEnumerable<GenericCovarianceAndContravariance> ReturnEnumerable()
        {
            // IEnumerable<Object> resultObject = new List<object>();
            // return resultObject;

            IEnumerable<GenericCovarianceAndContravariance> resultMyType =
                new List<GenericCovarianceAndContravariance>();
            return resultMyType;
        }
    }
}