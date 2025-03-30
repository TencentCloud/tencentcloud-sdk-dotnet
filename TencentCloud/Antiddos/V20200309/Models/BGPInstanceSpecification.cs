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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BGPInstanceSpecification : AbstractModel
    {
        
        /// <summary>
        /// 保底防护峰值，单位Gbps
        /// </summary>
        [JsonProperty("ProtectBandwidth")]
        public ulong? ProtectBandwidth{ get; set; }

        /// <summary>
        /// 防护次数，单位次
        /// </summary>
        [JsonProperty("ProtectCountLimit")]
        public ulong? ProtectCountLimit{ get; set; }

        /// <summary>
        /// 防护IP数，单位个
        /// </summary>
        [JsonProperty("ProtectIPNumberLimit")]
        public ulong? ProtectIPNumberLimit{ get; set; }

        /// <summary>
        /// 自动续费状态，取值[
        /// 0：没有开启自动续费
        /// 1：开启了自动续费
        /// ]
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public ulong? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 联合产品标记，0代表普通高防包，1代表联合高防包
        /// </summary>
        [JsonProperty("UnionPackFlag")]
        public ulong? UnionPackFlag{ get; set; }

        /// <summary>
        /// 业务带宽
        /// </summary>
        [JsonProperty("ServiceBandWidth")]
        public ulong? ServiceBandWidth{ get; set; }

        /// <summary>
        /// 战斗服版本标记，0表示普通高防包，1表示战斗服高防包
        /// </summary>
        [JsonProperty("BattleEditionFlag")]
        public ulong? BattleEditionFlag{ get; set; }

        /// <summary>
        /// 渠道版标记，0表示普通高防包，1表示渠道版高防包
        /// </summary>
        [JsonProperty("ChannelEditionFlag")]
        public ulong? ChannelEditionFlag{ get; set; }

        /// <summary>
        /// 高防包企业版标记，0表示普通高防包；1表示企业版高防包
        /// </summary>
        [JsonProperty("EnterpriseFlag")]
        public ulong? EnterpriseFlag{ get; set; }

        /// <summary>
        /// 高防包企业版弹性阈值，0表示未开启；大于0为弹性防护阈值
        /// </summary>
        [JsonProperty("ElasticLimit")]
        public ulong? ElasticLimit{ get; set; }

        /// <summary>
        /// 降配后的防护能力，单位Gbps
        /// </summary>
        [JsonProperty("DownGradeProtect")]
        public ulong? DownGradeProtect{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProtectBandwidth", this.ProtectBandwidth);
            this.SetParamSimple(map, prefix + "ProtectCountLimit", this.ProtectCountLimit);
            this.SetParamSimple(map, prefix + "ProtectIPNumberLimit", this.ProtectIPNumberLimit);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "UnionPackFlag", this.UnionPackFlag);
            this.SetParamSimple(map, prefix + "ServiceBandWidth", this.ServiceBandWidth);
            this.SetParamSimple(map, prefix + "BattleEditionFlag", this.BattleEditionFlag);
            this.SetParamSimple(map, prefix + "ChannelEditionFlag", this.ChannelEditionFlag);
            this.SetParamSimple(map, prefix + "EnterpriseFlag", this.EnterpriseFlag);
            this.SetParamSimple(map, prefix + "ElasticLimit", this.ElasticLimit);
            this.SetParamSimple(map, prefix + "DownGradeProtect", this.DownGradeProtect);
        }
    }
}

