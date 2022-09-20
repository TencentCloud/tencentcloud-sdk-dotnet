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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ShieldArea : AbstractModel
    {
        
        /// <summary>
        /// 站点Id。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// DDoS策略Id。
        /// </summary>
        [JsonProperty("PolicyId")]
        public long? PolicyId{ get; set; }

        /// <summary>
        /// 防护类型，参考值：
        /// <li>domain：7层子域；</li>
        /// <li>application：4层应用。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 7层站点名。
        /// </summary>
        [JsonProperty("EntityName")]
        public string EntityName{ get; set; }

        /// <summary>
        /// 该防护分区下的7层子域名。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DDoSHosts")]
        public DDoSHost[] DDoSHosts{ get; set; }

        /// <summary>
        /// 四层tcp转发规则数。
        /// </summary>
        [JsonProperty("TcpNum")]
        public long? TcpNum{ get; set; }

        /// <summary>
        /// 四层udp转发规则数。
        /// </summary>
        [JsonProperty("UdpNum")]
        public long? UdpNum{ get; set; }

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("Entity")]
        public string Entity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "EntityName", this.EntityName);
            this.SetParamArrayObj(map, prefix + "DDoSHosts.", this.DDoSHosts);
            this.SetParamSimple(map, prefix + "TcpNum", this.TcpNum);
            this.SetParamSimple(map, prefix + "UdpNum", this.UdpNum);
            this.SetParamSimple(map, prefix + "Entity", this.Entity);
        }
    }
}

