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

    public class DescribeOverviewIndexResponse : AbstractModel
    {
        
        /// <summary>
        /// IP总数
        /// </summary>
        [JsonProperty("AllIpCount")]
        public ulong? AllIpCount{ get; set; }

        /// <summary>
        /// 高防IP总数（包含高防包+高防IP）
        /// </summary>
        [JsonProperty("AntiddosIpCount")]
        public ulong? AntiddosIpCount{ get; set; }

        /// <summary>
        /// 攻击IP总数
        /// </summary>
        [JsonProperty("AttackIpCount")]
        public ulong? AttackIpCount{ get; set; }

        /// <summary>
        /// 封堵IP总数
        /// </summary>
        [JsonProperty("BlockIpCount")]
        public ulong? BlockIpCount{ get; set; }

        /// <summary>
        /// 高防域名总数
        /// </summary>
        [JsonProperty("AntiddosDomainCount")]
        public ulong? AntiddosDomainCount{ get; set; }

        /// <summary>
        /// 攻击域名总数
        /// </summary>
        [JsonProperty("AttackDomainCount")]
        public ulong? AttackDomainCount{ get; set; }

        /// <summary>
        /// 攻击流量峰值
        /// </summary>
        [JsonProperty("MaxAttackFlow")]
        public ulong? MaxAttackFlow{ get; set; }

        /// <summary>
        /// 当前最近一条攻击中的起始时间
        /// </summary>
        [JsonProperty("NewAttackTime")]
        public string NewAttackTime{ get; set; }

        /// <summary>
        /// 当前最近一条攻击中的IP
        /// </summary>
        [JsonProperty("NewAttackIp")]
        public string NewAttackIp{ get; set; }

        /// <summary>
        /// 当前最近一条攻击中的攻击类型
        /// </summary>
        [JsonProperty("NewAttackType")]
        public string NewAttackType{ get; set; }

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
            this.SetParamSimple(map, prefix + "AllIpCount", this.AllIpCount);
            this.SetParamSimple(map, prefix + "AntiddosIpCount", this.AntiddosIpCount);
            this.SetParamSimple(map, prefix + "AttackIpCount", this.AttackIpCount);
            this.SetParamSimple(map, prefix + "BlockIpCount", this.BlockIpCount);
            this.SetParamSimple(map, prefix + "AntiddosDomainCount", this.AntiddosDomainCount);
            this.SetParamSimple(map, prefix + "AttackDomainCount", this.AttackDomainCount);
            this.SetParamSimple(map, prefix + "MaxAttackFlow", this.MaxAttackFlow);
            this.SetParamSimple(map, prefix + "NewAttackTime", this.NewAttackTime);
            this.SetParamSimple(map, prefix + "NewAttackIp", this.NewAttackIp);
            this.SetParamSimple(map, prefix + "NewAttackType", this.NewAttackType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

