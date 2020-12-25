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

namespace TencentCloud.Dc.V20180410.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInternetAddressQuotaResponse : AbstractModel
    {
        
        /// <summary>
        /// IPv6互联网公网允许的最小前缀长度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Ipv6PrefixLen")]
        public long? Ipv6PrefixLen{ get; set; }

        /// <summary>
        /// BGP类型IPv4互联网地址配额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Ipv4BgpQuota")]
        public long? Ipv4BgpQuota{ get; set; }

        /// <summary>
        /// 非BGP类型IPv4互联网地址配额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Ipv4OtherQuota")]
        public long? Ipv4OtherQuota{ get; set; }

        /// <summary>
        /// BGP类型IPv4互联网地址已使用数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Ipv4BgpNum")]
        public long? Ipv4BgpNum{ get; set; }

        /// <summary>
        /// 非BGP类型互联网地址已使用数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Ipv4OtherNum")]
        public long? Ipv4OtherNum{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Ipv6PrefixLen", this.Ipv6PrefixLen);
            this.SetParamSimple(map, prefix + "Ipv4BgpQuota", this.Ipv4BgpQuota);
            this.SetParamSimple(map, prefix + "Ipv4OtherQuota", this.Ipv4OtherQuota);
            this.SetParamSimple(map, prefix + "Ipv4BgpNum", this.Ipv4BgpNum);
            this.SetParamSimple(map, prefix + "Ipv4OtherNum", this.Ipv4OtherNum);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

