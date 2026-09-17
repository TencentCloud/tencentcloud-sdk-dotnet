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

namespace TencentCloud.Edgezone.V20260401.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePublicIpsRequest : AbstractModel
    {
        
        /// <summary>
        /// 按公网实例 ID 过滤（子串匹配，多个值取并集）
        /// </summary>
        [JsonProperty("NetworkInstanceId")]
        public string[] NetworkInstanceId{ get; set; }

        /// <summary>
        /// 按可用区/机房过滤
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 按 IP 过滤（子串匹配，多个值取并集）
        /// </summary>
        [JsonProperty("Ip")]
        public string[] Ip{ get; set; }

        /// <summary>
        /// 按状态过滤，可选值：`InUse`、`Unbound`（多个值取并集）
        /// </summary>
        [JsonProperty("State")]
        public string[] State{ get; set; }

        /// <summary>
        /// 按 IP 版本过滤，可选值：`Ipv4`、`Ipv6`（多个值取并集）
        /// </summary>
        [JsonProperty("Type")]
        public string[] Type{ get; set; }

        /// <summary>
        /// 按创建时间排序，可选值：`asc`、`desc`（默认 `desc`）
        /// </summary>
        [JsonProperty("OrderByCreateTime")]
        public string OrderByCreateTime{ get; set; }

        /// <summary>
        /// 按更新时间排序，可选值：`asc`、`desc`（优先级高于创建时间排序）
        /// </summary>
        [JsonProperty("OrderByUpdateTime")]
        public string OrderByUpdateTime{ get; set; }

        /// <summary>
        /// 分页偏移量，默认 0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 每页数量，默认 20，最大 100
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "NetworkInstanceId.", this.NetworkInstanceId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArraySimple(map, prefix + "Ip.", this.Ip);
            this.SetParamArraySimple(map, prefix + "State.", this.State);
            this.SetParamArraySimple(map, prefix + "Type.", this.Type);
            this.SetParamSimple(map, prefix + "OrderByCreateTime", this.OrderByCreateTime);
            this.SetParamSimple(map, prefix + "OrderByUpdateTime", this.OrderByUpdateTime);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

