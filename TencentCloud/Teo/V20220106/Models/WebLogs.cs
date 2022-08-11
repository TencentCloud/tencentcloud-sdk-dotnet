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

    public class WebLogs : AbstractModel
    {
        
        /// <summary>
        /// 该字段已废弃。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttackContent")]
        public string AttackContent{ get; set; }

        /// <summary>
        /// 攻击源（客户端）Ip。
        /// </summary>
        [JsonProperty("AttackIp")]
        public string AttackIp{ get; set; }

        /// <summary>
        /// 该字段已废弃。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttackType")]
        public string AttackType{ get; set; }

        /// <summary>
        /// 受攻击子域名。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 该字段已废弃。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Msuuid")]
        public string Msuuid{ get; set; }

        /// <summary>
        /// 该字段已废弃。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestMethod")]
        public string RequestMethod{ get; set; }

        /// <summary>
        /// URI
        /// </summary>
        [JsonProperty("RequestUri")]
        public string RequestUri{ get; set; }

        /// <summary>
        /// 该字段已废弃。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// 该字段已废弃。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleId")]
        public ulong? RuleId{ get; set; }

        /// <summary>
        /// IP所在国家iso-3166中alpha-2编码，编码信息请参考[ISO-3166](https://git.woa.com/edgeone/iso-3166/blob/master/all/all.json)
        /// </summary>
        [JsonProperty("SipCountryCode")]
        public string SipCountryCode{ get; set; }

        /// <summary>
        /// 请求（事件）ID。
        /// </summary>
        [JsonProperty("EventId")]
        public string EventId{ get; set; }

        /// <summary>
        /// 该字段已废弃。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DisposalMethod")]
        public string DisposalMethod{ get; set; }

        /// <summary>
        /// http log。
        /// </summary>
        [JsonProperty("HttpLog")]
        public string HttpLog{ get; set; }

        /// <summary>
        /// 该字段已废弃。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Ua")]
        public string Ua{ get; set; }

        /// <summary>
        /// 攻击时间，采用unix秒级时间戳。
        /// </summary>
        [JsonProperty("AttackTime")]
        public ulong? AttackTime{ get; set; }

        /// <summary>
        /// 规则相关信息列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleDetailList")]
        public SecRuleRelatedInfo[] RuleDetailList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AttackContent", this.AttackContent);
            this.SetParamSimple(map, prefix + "AttackIp", this.AttackIp);
            this.SetParamSimple(map, prefix + "AttackType", this.AttackType);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Msuuid", this.Msuuid);
            this.SetParamSimple(map, prefix + "RequestMethod", this.RequestMethod);
            this.SetParamSimple(map, prefix + "RequestUri", this.RequestUri);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "SipCountryCode", this.SipCountryCode);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "DisposalMethod", this.DisposalMethod);
            this.SetParamSimple(map, prefix + "HttpLog", this.HttpLog);
            this.SetParamSimple(map, prefix + "Ua", this.Ua);
            this.SetParamSimple(map, prefix + "AttackTime", this.AttackTime);
            this.SetParamArrayObj(map, prefix + "RuleDetailList.", this.RuleDetailList);
        }
    }
}

