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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biz.dfch.CS.Playground.Fynn._20210304
{
    public class FileChecker
    {
        private const char Dot = '.';

        public bool CheckFileEnding(List<string> allowedFileEndings, string filePath)
        {
            var fileEnding = filePath.Substring(filePath.LastIndexOf(Dot) + 1);

            return allowedFileEndings.Any(allowedFileEnding => allowedFileEnding == fileEnding);
        }
    }
}
