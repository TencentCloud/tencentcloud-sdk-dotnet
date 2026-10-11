/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EngineConfigDependencies : AbstractModel
    {
        
        /// <summary>
        /// <p>JAR 列表：每行一个 COS 路径或 Maven GAV。</p>
        /// </summary>
        [JsonProperty("Jars")]
        public string[] Jars{ get; set; }

        /// <summary>
        /// <p>files 列表：COS 路径，下载到 executor 工作目录（不解压）。</p>
        /// </summary>
        [JsonProperty("Files")]
        public string[] Files{ get; set; }

        /// <summary>
        /// <p>archives 列表：COS 路径，下载并解压到 executor 工作目录。</p>
        /// </summary>
        [JsonProperty("Archives")]
        public string[] Archives{ get; set; }

        /// <summary>
        /// <p>pyFiles 列表：COS 路径（.py/.zip/.egg/.whl），等价 Spark --py-files。</p>
        /// </summary>
        [JsonProperty("PyFiles")]
        public string[] PyFiles{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Jars.", this.Jars);
            this.SetParamArraySimple(map, prefix + "Files.", this.Files);
            this.SetParamArraySimple(map, prefix + "Archives.", this.Archives);
            this.SetParamArraySimple(map, prefix + "PyFiles.", this.PyFiles);
        }
    }
}

