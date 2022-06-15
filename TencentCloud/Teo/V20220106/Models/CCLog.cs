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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CCLog : AbstractModel
    {
        
        /// <summary>
        /// 攻击时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttackTime")]
        public ulong? AttackTime{ get; set; }

        /// <summary>
        /// 攻击源ip
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttackSip")]
        public string AttackSip{ get; set; }

        /// <summary>
        /// 攻击域名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttackDomain")]
        public string AttackDomain{ get; set; }

        /// <summary>
        /// 请求uri
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestUri")]
        public string RequestUri{ get; set; }

        /// <summary>
        /// 命中次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HitCount")]
        public ulong? HitCount{ get; set; }

        /// <summary>
        /// IP所在国家
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SipCountryCode")]
        public string SipCountryCode{ get; set; }

        /// <summary>
        /// 事件id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EventId")]
        public string EventId{ get; set; }

        /// <summary>
        /// 处置方式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DisposalMethod")]
        public string DisposalMethod{ get; set; }

        /// <summary>
        /// http_log
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HttpLog")]
        public string HttpLog{ get; set; }

        /// <summary>
        /// 规则编号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleId")]
        public ulong? RuleId{ get; set; }

        /// <summary>
        /// 风险等级
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AttackTime", this.AttackTime);
            this.SetParamSimple(map, prefix + "AttackSip", this.AttackSip);
            this.SetParamSimple(map, prefix + "AttackDomain", this.AttackDomain);
            this.SetParamSimple(map, prefix + "RequestUri", this.RequestUri);
            this.SetParamSimple(map, prefix + "HitCount", this.HitCount);
            this.SetParamSimple(map, prefix + "SipCountryCode", this.SipCountryCode);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "DisposalMethod", this.DisposalMethod);
            this.SetParamSimple(map, prefix + "HttpLog", this.HttpLog);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
        }
    }
}

