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

    public class ComponentReference : AbstractModel
    {
        
        /// <summary>
        /// 引用的实例类型。取值有：
        /// <li>edge-function：边缘函数。</li>
        /// </summary>
        [JsonProperty("ReferenceType")]
        public string ReferenceType{ get; set; }

        /// <summary>
        /// 引用的实例 ID。根据 ReferenceType 的取值不同，返回对应的实例 ID：
        /// <li>当 ReferenceType 为 edge-function 时：返回边缘函数 ID，格式形如：ef-2vc5oe9mzqhm。</li>
        /// </summary>
        [JsonProperty("ReferenceId")]
        public string ReferenceId{ get; set; }

        /// <summary>
        /// 引用的实例名称。根据 ReferenceType 的取值不同，返回对应的实例名称：
        /// <li>当 ReferenceType 为 edge-function 时：返回边缘函数名称。</li>
        /// </summary>
        [JsonProperty("ReferenceName")]
        public string ReferenceName{ get; set; }

        /// <summary>
        /// 站点 ID。引用该命名空间的实例所属的站点标识。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 站点名称。引用该命名空间的实例所属的站点名称。
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// 引用该命名空间的实例所属站点的别名。若未设置站点别名，则返回空字符串。
        /// </summary>
        [JsonProperty("AliasZoneName")]
        public string AliasZoneName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReferenceType", this.ReferenceType);
            this.SetParamSimple(map, prefix + "ReferenceId", this.ReferenceId);
            this.SetParamSimple(map, prefix + "ReferenceName", this.ReferenceName);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "AliasZoneName", this.AliasZoneName);
        }
    }
}

