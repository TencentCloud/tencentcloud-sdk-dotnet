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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DDoSEventRecord : AbstractModel
    {
        
        /// <summary>
        /// 大禹子产品代号（shield表示棋牌；bgpip表示高防IP；bgp表示独享包；bgp-multip表示共享包；net表示高防IP专业版；basic表示DDoS基础防护）
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// 资源ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 资源的IP
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// 攻击开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 攻击结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 攻击最大带宽
        /// </summary>
        [JsonProperty("Mbps")]
        public ulong? Mbps{ get; set; }

        /// <summary>
        /// 攻击最大包速率
        /// </summary>
        [JsonProperty("Pps")]
        public ulong? Pps{ get; set; }

        /// <summary>
        /// 攻击类型
        /// </summary>
        [JsonProperty("AttackType")]
        public string AttackType{ get; set; }

        /// <summary>
        /// 是否被封堵，取值[1（是），0（否），2（无效值）]
        /// </summary>
        [JsonProperty("BlockFlag")]
        public ulong? BlockFlag{ get; set; }

        /// <summary>
        /// 是否超过弹性防护峰值，取值取值[yes(是)，no(否)，空字符串（未知值）]
        /// </summary>
        [JsonProperty("OverLoad")]
        public string OverLoad{ get; set; }

        /// <summary>
        /// 攻击状态，取值[0（攻击中）, 1（攻击结束）]
        /// </summary>
        [JsonProperty("AttackStatus")]
        public ulong? AttackStatus{ get; set; }

        /// <summary>
        /// 资源名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Mbps", this.Mbps);
            this.SetParamSimple(map, prefix + "Pps", this.Pps);
            this.SetParamSimple(map, prefix + "AttackType", this.AttackType);
            this.SetParamSimple(map, prefix + "BlockFlag", this.BlockFlag);
            this.SetParamSimple(map, prefix + "OverLoad", this.OverLoad);
            this.SetParamSimple(map, prefix + "AttackStatus", this.AttackStatus);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
        }
    }
}

