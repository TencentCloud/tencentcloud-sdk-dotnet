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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClassInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>规格ID</p>
        /// </summary>
        [JsonProperty("SpecCode")]
        public string SpecCode{ get; set; }

        /// <summary>
        /// <p>CPU核数</p>
        /// </summary>
        [JsonProperty("CPU")]
        public ulong? CPU{ get; set; }

        /// <summary>
        /// <p>内存大小，单位：MB</p>
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// <p>该规格所支持最大存储容量，单位：GB</p>
        /// </summary>
        [JsonProperty("MaxStorage")]
        public ulong? MaxStorage{ get; set; }

        /// <summary>
        /// <p>该规格所支持最小存储容量，单位：GB</p>
        /// </summary>
        [JsonProperty("MinStorage")]
        public ulong? MinStorage{ get; set; }

        /// <summary>
        /// <p>该规格的预估QPS</p>
        /// </summary>
        [JsonProperty("QPS")]
        public ulong? QPS{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpecCode", this.SpecCode);
            this.SetParamSimple(map, prefix + "CPU", this.CPU);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "MaxStorage", this.MaxStorage);
            this.SetParamSimple(map, prefix + "MinStorage", this.MinStorage);
            this.SetParamSimple(map, prefix + "QPS", this.QPS);
        }
    }
}

