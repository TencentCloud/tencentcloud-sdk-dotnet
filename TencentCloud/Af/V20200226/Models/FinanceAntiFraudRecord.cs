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

namespace TencentCloud.Af.V20200226.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FinanceAntiFraudRecord : AbstractModel
    {
        
        /// <summary>
        /// 表示该条记录能否查到：1为能查到，-1为查不到
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Found")]
        public string Found{ get; set; }

        /// <summary>
        /// 表示该条Id能否查到：1为能查到，-1为查不到
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IdFound")]
        public string IdFound{ get; set; }

        /// <summary>
        /// 评分0~100;值越高 欺诈可能性越大
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RiskScore")]
        public string RiskScore{ get; set; }

        /// <summary>
        /// 扩展字段，对风险类型的说明
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RiskInfo")]
        public RiskDetailInfo[] RiskInfo{ get; set; }

        /// <summary>
        /// 多模型返回结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OtherModelScores")]
        public FinanceOtherModelScores[] OtherModelScores{ get; set; }

        /// <summary>
        /// 业务侧错误码。成功时返回0，错误时返回非0值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// 业务侧错误信息。成功时返回Success，错误时返回具体业务错误原因。
        /// 注意：此字段可能返回 null，表示取不到有效值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Found", this.Found);
            this.SetParamSimple(map, prefix + "IdFound", this.IdFound);
            this.SetParamSimple(map, prefix + "RiskScore", this.RiskScore);
            this.SetParamArrayObj(map, prefix + "RiskInfo.", this.RiskInfo);
            this.SetParamArrayObj(map, prefix + "OtherModelScores.", this.OtherModelScores);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Message", this.Message);
        }
    }
}

