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

namespace TencentCloud.Igtm.V20231024.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddressPoolDetail : AbstractModel
    {
        
        /// <summary>
        /// 地址池 id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PoolId")]
        public ulong? PoolId{ get; set; }

        /// <summary>
        /// 地址池名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PoolName")]
        public string PoolName{ get; set; }

        /// <summary>
        /// 地址池地址类型：IPV4、IPV6、DOMAIN
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AddrType")]
        public string AddrType{ get; set; }

        /// <summary>
        /// 流量策略: WEIGHT负载均衡，ALL解析全部
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TrafficStrategy")]
        public string TrafficStrategy{ get; set; }

        /// <summary>
        /// 监控器id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MonitorId")]
        public ulong? MonitorId{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// 更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdatedOn")]
        public string UpdatedOn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PoolId", this.PoolId);
            this.SetParamSimple(map, prefix + "PoolName", this.PoolName);
            this.SetParamSimple(map, prefix + "AddrType", this.AddrType);
            this.SetParamSimple(map, prefix + "TrafficStrategy", this.TrafficStrategy);
            this.SetParamSimple(map, prefix + "MonitorId", this.MonitorId);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "UpdatedOn", this.UpdatedOn);
        }
    }
}

