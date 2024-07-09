/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PolicyStatistics : AbstractModel
    {
        
        /// <summary>
        /// 入站IPv4总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IngressIPv4TotalCount")]
        public ulong? IngressIPv4TotalCount{ get; set; }

        /// <summary>
        /// 入站IPv6总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IngressIPv6TotalCount")]
        public ulong? IngressIPv6TotalCount{ get; set; }

        /// <summary>
        /// 出站IPv4总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EgressIPv4TotalCount")]
        public ulong? EgressIPv4TotalCount{ get; set; }

        /// <summary>
        /// 出站IPv6总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EgressIPv6TotalCount")]
        public ulong? EgressIPv6TotalCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IngressIPv4TotalCount", this.IngressIPv4TotalCount);
            this.SetParamSimple(map, prefix + "IngressIPv6TotalCount", this.IngressIPv6TotalCount);
            this.SetParamSimple(map, prefix + "EgressIPv4TotalCount", this.EgressIPv4TotalCount);
            this.SetParamSimple(map, prefix + "EgressIPv6TotalCount", this.EgressIPv6TotalCount);
        }
    }
}

