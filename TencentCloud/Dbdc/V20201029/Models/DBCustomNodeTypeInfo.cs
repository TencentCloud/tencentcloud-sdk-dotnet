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

namespace TencentCloud.Dbdc.V20201029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DBCustomNodeTypeInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>可用区标识，如 ap-guangzhou-6</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>机型标识</p><p>枚举值：</p><ul><li>DB.SA5.2XLARGE32： DB.SA5机型</li><li>DB.AT5.8XLARGE128： DB.AT5机型</li></ul>
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// <p>机型系列，如 DB.AT5、DB.SA5</p>
        /// </summary>
        [JsonProperty("NodeFamily")]
        public string NodeFamily{ get; set; }

        /// <summary>
        /// <p>CPU 核数</p><p>单位：核</p>
        /// </summary>
        [JsonProperty("CPU")]
        public ulong? CPU{ get; set; }

        /// <summary>
        /// <p>内存大小</p><p>单位：GiB</p>
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// <p>机型售卖状态</p><p>枚举值：</p><ul><li>SELL： 正常售卖</li><li>SOLD_OUT： 售罄</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>该机型允许的系统盘类型列表（如 CLOUD_BSSD、CLOUD_HSSD）；</p>
        /// </summary>
        [JsonProperty("SystemDiskTypes")]
        public string[] SystemDiskTypes{ get; set; }

        /// <summary>
        /// <p>该机型允许的数据盘类型列表（如 CLOUD_BSSD、CLOUD_HSSD）；</p>
        /// </summary>
        [JsonProperty("DataDiskTypes")]
        public string[] DataDiskTypes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "NodeFamily", this.NodeFamily);
            this.SetParamSimple(map, prefix + "CPU", this.CPU);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "SystemDiskTypes.", this.SystemDiskTypes);
            this.SetParamArraySimple(map, prefix + "DataDiskTypes.", this.DataDiskTypes);
        }
    }
}

