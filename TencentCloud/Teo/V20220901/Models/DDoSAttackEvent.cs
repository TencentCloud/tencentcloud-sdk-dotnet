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

    public class DDoSAttackEvent : AbstractModel
    {
        
        /// <summary>
        /// 事件ID。
        /// </summary>
        [JsonProperty("EventId")]
        public string EventId{ get; set; }

        /// <summary>
        /// 攻击类型(对应交互事件名称)。
        /// </summary>
        [JsonProperty("AttackType")]
        public string AttackType{ get; set; }

        /// <summary>
        /// 攻击状态。
        /// </summary>
        [JsonProperty("AttackStatus")]
        public long? AttackStatus{ get; set; }

        /// <summary>
        /// 攻击最大带宽。
        /// </summary>
        [JsonProperty("AttackMaxBandWidth")]
        public long? AttackMaxBandWidth{ get; set; }

        /// <summary>
        /// 攻击包速率峰值。
        /// </summary>
        [JsonProperty("AttackPacketMaxRate")]
        public long? AttackPacketMaxRate{ get; set; }

        /// <summary>
        /// 攻击开始时间，单位为s。
        /// </summary>
        [JsonProperty("AttackStartTime")]
        public long? AttackStartTime{ get; set; }

        /// <summary>
        /// 攻击结束时间，单位为s。
        /// </summary>
        [JsonProperty("AttackEndTime")]
        public long? AttackEndTime{ get; set; }

        /// <summary>
        /// DDoS策略组ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PolicyId")]
        public long? PolicyId{ get; set; }

        /// <summary>
        /// 站点ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 攻击事件所属地区，取值有：
        /// <li>overseas：全球（除中国大陆地区）数据；</li>
        /// <li>mainland：中国大陆地区数据。</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// 封禁解封信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DDoSBlockData")]
        public DDoSBlockData[] DDoSBlockData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "AttackType", this.AttackType);
            this.SetParamSimple(map, prefix + "AttackStatus", this.AttackStatus);
            this.SetParamSimple(map, prefix + "AttackMaxBandWidth", this.AttackMaxBandWidth);
            this.SetParamSimple(map, prefix + "AttackPacketMaxRate", this.AttackPacketMaxRate);
            this.SetParamSimple(map, prefix + "AttackStartTime", this.AttackStartTime);
            this.SetParamSimple(map, prefix + "AttackEndTime", this.AttackEndTime);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamArrayObj(map, prefix + "DDoSBlockData.", this.DDoSBlockData);
        }
    }
}

