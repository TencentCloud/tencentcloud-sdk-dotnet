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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AvailableType : AbstractModel
    {
        
        /// <summary>
        /// <p>协议与售卖详情</p>
        /// </summary>
        [JsonProperty("Protocols")]
        public AvailableProtoStatus[] Protocols{ get; set; }

        /// <summary>
        /// <p>存储类型。返回值中 SD 为通用标准型存储， HP为通用性能型存储， TB为Turbo标准型， TP 为Turbo性能型。</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>是否支持预付费。返回值中 true 为支持、false 为不支持</p>
        /// </summary>
        [JsonProperty("Prepayment")]
        public bool? Prepayment{ get; set; }

        /// <summary>
        /// <p>文件系统版本</p><p>枚举值：</p><ul><li>v1.5： 通用系列</li><li>v3.1： 通用系列（增强型）</li><li>v4.0： Turbo系列</li></ul>
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Protocols.", this.Protocols);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Prepayment", this.Prepayment);
            this.SetParamSimple(map, prefix + "Version", this.Version);
        }
    }
}

