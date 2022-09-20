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

    public class DDoSAttackSourceEvent : AbstractModel
    {
        
        /// <summary>
        /// 攻击源ip。
        /// </summary>
        [JsonProperty("AttackSourceIp")]
        public string AttackSourceIp{ get; set; }

        /// <summary>
        /// 地区（国家）。
        /// </summary>
        [JsonProperty("AttackRegion")]
        public string AttackRegion{ get; set; }

        /// <summary>
        /// 累计攻击流量。
        /// </summary>
        [JsonProperty("AttackFlow")]
        public ulong? AttackFlow{ get; set; }

        /// <summary>
        /// 累计攻击包量。
        /// </summary>
        [JsonProperty("AttackPacketNum")]
        public ulong? AttackPacketNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AttackSourceIp", this.AttackSourceIp);
            this.SetParamSimple(map, prefix + "AttackRegion", this.AttackRegion);
            this.SetParamSimple(map, prefix + "AttackFlow", this.AttackFlow);
            this.SetParamSimple(map, prefix + "AttackPacketNum", this.AttackPacketNum);
        }
    }
}

