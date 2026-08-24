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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DDoSAttackEvent : AbstractModel
    {
        
        /// <summary>
        /// <p>事件 ID。</p>
        /// </summary>
        [JsonProperty("EventId")]
        public string EventId{ get; set; }

        /// <summary>
        /// <p>攻击类型。</p>
        /// </summary>
        [JsonProperty("AttackType")]
        public string AttackType{ get; set; }

        /// <summary>
        /// <p>攻击状态。</p><p>枚举值：</p><ul><li>0： 观察中</li><li>1： 攻击中</li><li>2： 攻击结束</li></ul>
        /// </summary>
        [JsonProperty("AttackStatus")]
        public long? AttackStatus{ get; set; }

        /// <summary>
        /// <p>攻击最大带宽，单位为 bps。</p>
        /// </summary>
        [JsonProperty("AttackMaxBandWidth")]
        public long? AttackMaxBandWidth{ get; set; }

        /// <summary>
        /// <p>攻击包速率峰值，单位为 pps。</p>
        /// </summary>
        [JsonProperty("AttackPacketMaxRate")]
        public long? AttackPacketMaxRate{ get; set; }

        /// <summary>
        /// <p>攻击开始时间戳。</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("AttackStartTime")]
        public long? AttackStartTime{ get; set; }

        /// <summary>
        /// <p>攻击结束时间戳。</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("AttackEndTime")]
        public long? AttackEndTime{ get; set; }

        /// <summary>
        /// <p>DDoS 策略组 ID。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PolicyId")]
        public long? PolicyId{ get; set; }

        /// <summary>
        /// <p>站点 ID。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>攻击事件所属地区。</p><p>枚举值：</p><ul><li>overseas： 全球（除中国大陆地区）数据；</li><li>mainland： 中国大陆地区数据。</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// <p>封禁解封信息。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DDoSBlockData")]
        public DDoSBlockData[] DDoSBlockData{ get; set; }

        /// <summary>
        /// <p>被 DDoS 攻击的目的 IP 列表。</p>
        /// </summary>
        [JsonProperty("DDoSAttackDips")]
        public string[] DDoSAttackDips{ get; set; }


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
            this.SetParamArraySimple(map, prefix + "DDoSAttackDips.", this.DDoSAttackDips);
        }
    }
}

