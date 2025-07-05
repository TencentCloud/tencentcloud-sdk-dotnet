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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OriginACLEntity : AbstractModel
    {
        
        /// <summary>
        /// 实例类型，取值有：
        /// - l7：七层加速域名；
        /// - l4：四层代理实例。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 实例详情，取值有：
        /// - 当 Type = l7 时，请填写七层加速域名；
        /// - 当 Type = l4 时，请填写四层代理实例 ID。
        /// </summary>
        [JsonProperty("Instances")]
        public string[] Instances{ get; set; }

        /// <summary>
        /// 操作模式，取值有：
        /// <li>enable：启用；</li>
        /// <li>disable：停用。</li>
        /// </summary>
        [JsonProperty("OperationMode")]
        public string OperationMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArraySimple(map, prefix + "Instances.", this.Instances);
            this.SetParamSimple(map, prefix + "OperationMode", this.OperationMode);
        }
    }
}

