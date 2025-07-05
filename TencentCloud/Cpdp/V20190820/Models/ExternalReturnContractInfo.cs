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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExternalReturnContractInfo : AbstractModel
    {
        
        /// <summary>
        /// 第三方渠道协议id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExternalReturnAgreementId")]
        public string ExternalReturnAgreementId{ get; set; }

        /// <summary>
        /// 第三方渠道协议生效时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExternalReturnContractEffectiveTimestamp")]
        public string ExternalReturnContractEffectiveTimestamp{ get; set; }

        /// <summary>
        /// 第三方渠道协议解约时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExternalReturnContractTerminationTimestamp")]
        public string ExternalReturnContractTerminationTimestamp{ get; set; }

        /// <summary>
        /// 平台合约状态
        /// 协议状态，枚举值：
        /// CONTRACT_STATUS_SIGNED：已签约
        /// CONTRACT_STATUS_TERMINATED：未签约
        /// CONTRACT_STATUS_PENDING：签约进行中
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExternalReturnContractStatus")]
        public string ExternalReturnContractStatus{ get; set; }

        /// <summary>
        /// 第三方渠道请求序列号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExternalReturnRequestId")]
        public string ExternalReturnRequestId{ get; set; }

        /// <summary>
        /// 第三方渠道协议签署时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExternalReturnContractSignedTimestamp")]
        public string ExternalReturnContractSignedTimestamp{ get; set; }

        /// <summary>
        /// 第三方渠道协议到期时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExternalReturnContractExpiredTimestamp")]
        public string ExternalReturnContractExpiredTimestamp{ get; set; }

        /// <summary>
        /// 第三方渠道返回的合约数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExternalReturnContractData")]
        public string ExternalReturnContractData{ get; set; }

        /// <summary>
        /// 第三方渠道解约备注
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExternalReturnContractTerminationRemark")]
        public string ExternalReturnContractTerminationRemark{ get; set; }

        /// <summary>
        /// 第三方渠道协议解约方式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExternalReturnContractTerminationMode")]
        public string ExternalReturnContractTerminationMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExternalReturnAgreementId", this.ExternalReturnAgreementId);
            this.SetParamSimple(map, prefix + "ExternalReturnContractEffectiveTimestamp", this.ExternalReturnContractEffectiveTimestamp);
            this.SetParamSimple(map, prefix + "ExternalReturnContractTerminationTimestamp", this.ExternalReturnContractTerminationTimestamp);
            this.SetParamSimple(map, prefix + "ExternalReturnContractStatus", this.ExternalReturnContractStatus);
            this.SetParamSimple(map, prefix + "ExternalReturnRequestId", this.ExternalReturnRequestId);
            this.SetParamSimple(map, prefix + "ExternalReturnContractSignedTimestamp", this.ExternalReturnContractSignedTimestamp);
            this.SetParamSimple(map, prefix + "ExternalReturnContractExpiredTimestamp", this.ExternalReturnContractExpiredTimestamp);
            this.SetParamSimple(map, prefix + "ExternalReturnContractData", this.ExternalReturnContractData);
            this.SetParamSimple(map, prefix + "ExternalReturnContractTerminationRemark", this.ExternalReturnContractTerminationRemark);
            this.SetParamSimple(map, prefix + "ExternalReturnContractTerminationMode", this.ExternalReturnContractTerminationMode);
        }
    }
}

