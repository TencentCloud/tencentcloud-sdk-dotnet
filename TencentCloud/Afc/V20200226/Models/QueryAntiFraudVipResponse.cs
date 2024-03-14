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

    public class QueryAntiFraudVipResponse : AbstractModel
    {
        
        /// <summary>
        /// 表示该条记录能否查到：1为能查到，-1为查不到
        /// </summary>
        [JsonProperty("Found")]
        public long? Found{ get; set; }

        /// <summary>
        /// 表示该条Id能否查到：1为能查到，-1为查不到
        /// </summary>
        [JsonProperty("IdFound")]
        public long? IdFound{ get; set; }

        /// <summary>
        /// 0~100;值越高 欺诈可能性越大（注：该字段真实类型为有符号整型）
        /// </summary>
        [JsonProperty("RiskScore")]
        public ulong? RiskScore{ get; set; }

        /// <summary>
        /// 扩展字段，对风险类型的说明
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RiskInfo")]
        public RiskDetail[] RiskInfo{ get; set; }

        /// <summary>
        /// 业务侧错误码。成功时返回Success，错误时返回具体业务错误原因。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CodeDesc")]
        public string CodeDesc{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Found", this.Found);
            this.SetParamSimple(map, prefix + "IdFound", this.IdFound);
            this.SetParamSimple(map, prefix + "RiskScore", this.RiskScore);
            this.SetParamArrayObj(map, prefix + "RiskInfo.", this.RiskInfo);
            this.SetParamSimple(map, prefix + "CodeDesc", this.CodeDesc);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

