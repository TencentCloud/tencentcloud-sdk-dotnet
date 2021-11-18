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

namespace TencentCloud.Afc.V20200226.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AntiFraudVipRecord : AbstractModel
    {
        
        /// <summary>
        /// 公共错误码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// 业务侧错误码。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CodeDesc")]
        public string CodeDesc{ get; set; }

        /// <summary>
        /// 业务侧错误信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// 表示该条记录能否查到：1 为能查到；-1 为查不到，此时 RiskScore 返回-1；
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Found")]
        public string Found{ get; set; }

        /// <summary>
        /// 表示该条记录中的身份 ID 能否查到
        /// 1 为能查到
        /// -1 为查不到
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IdFound")]
        public string IdFound{ get; set; }

        /// <summary>
        /// 当可查到时，返回 0~100 区间，值越高 欺诈可
        /// 能性越大。
        /// 当查不到时（即 found=-1），返回-1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RiskScore")]
        public string RiskScore{ get; set; }

        /// <summary>
        /// 扩展字段，对风险类型的说明。扩展字段并非必
        /// 然出现。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RiskInfo")]
        public SimpleKindRiskDetail[] RiskInfo{ get; set; }

        /// <summary>
        /// 默认出现，提供模型版本号说明及多模型返回需
        /// 要时用到；
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OtherModelScores")]
        public OtherModelScores[] OtherModelScores{ get; set; }

        /// <summary>
        /// 表示请求时间，标准 sunix 时间戳，非必然出现
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PostTime")]
        public string PostTime{ get; set; }

        /// <summary>
        /// 拓展字段，非必然出现，和 ExtensionIn 对应；
        /// 注：非必然出现，需要返回时天御侧将说明；
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtensionOut")]
        public string ExtensionOut{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "CodeDesc", this.CodeDesc);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "Found", this.Found);
            this.SetParamSimple(map, prefix + "IdFound", this.IdFound);
            this.SetParamSimple(map, prefix + "RiskScore", this.RiskScore);
            this.SetParamArrayObj(map, prefix + "RiskInfo.", this.RiskInfo);
            this.SetParamArrayObj(map, prefix + "OtherModelScores.", this.OtherModelScores);
            this.SetParamSimple(map, prefix + "PostTime", this.PostTime);
            this.SetParamSimple(map, prefix + "ExtensionOut", this.ExtensionOut);
        }
    }
}

