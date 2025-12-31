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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CcnSwitchInfo : AbstractModel
    {
        
        /// <summary>
        /// ccn的id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// 开关接入模式，1:自动接入,2:手动接入
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SwitchMode")]
        public ulong? SwitchMode{ get; set; }

        /// <summary>
        /// 引流路由方法 0:多路由表, 1:策略路由
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RoutingMode")]
        public long? RoutingMode{ get; set; }

        /// <summary>
        /// 地域级别CIDR配置
        /// </summary>
        [JsonProperty("RegionCidrConfigs")]
        public RegionCidrConfig[] RegionCidrConfigs{ get; set; }

        /// <summary>
        /// 互联集合对列表
        /// </summary>
        [JsonProperty("InterconnectPairs")]
        public InterconnectPair[] InterconnectPairs{ get; set; }

        /// <summary>
        /// 引流通用CIDR(废弃)
        /// </summary>
        [JsonProperty("FwVpcCidr")]
        public string FwVpcCidr{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
            this.SetParamSimple(map, prefix + "SwitchMode", this.SwitchMode);
            this.SetParamSimple(map, prefix + "RoutingMode", this.RoutingMode);
            this.SetParamArrayObj(map, prefix + "RegionCidrConfigs.", this.RegionCidrConfigs);
            this.SetParamArrayObj(map, prefix + "InterconnectPairs.", this.InterconnectPairs);
            this.SetParamSimple(map, prefix + "FwVpcCidr", this.FwVpcCidr);
        }
    }
}

