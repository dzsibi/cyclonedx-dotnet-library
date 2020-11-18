﻿// This file is part of the CycloneDX Tool for .NET
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// Copyright (c) Steve Springett. All Rights Reserved.

using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;
using CycloneDX.Models.v1_2;

namespace CycloneDX.Xml
{

    public static class XmlBomSerializer
    {
        public static string Serialize(Bom bom)
        {
            Contract.Requires(bom != null);

            var serializer = new XmlSerializer(typeof(Bom));

            using (var writer = new Utf8StringWriter())
            {
                serializer.Serialize(writer, bom);
                return writer.ToString();
            }
        }
    }
}
