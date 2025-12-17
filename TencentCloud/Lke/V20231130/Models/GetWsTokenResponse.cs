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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetWsTokenResponse : AbstractModel
    {
        
        /// <summary>
        /// token值（有效期60s，仅一次有效，多次校验会报错）
        /// </summary>
        [JsonProperty("Token")]
        public string Token{ get; set; }

        /// <summary>
        /// 余额; 余额大于 0 时表示有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Balance")]
        public float? Balance{ get; set; }

        /// <summary>
        /// 对话窗输入字符限制
        /// </summary>
        [JsonProperty("InputLenLimit")]
        public long? InputLenLimit{ get; set; }

        /// <summary>
        /// 应用模式，standard:标准模式, agent: agent模式，single_workflow：单工作流模式
        /// </summary>
        [JsonProperty("Pattern")]
        public string Pattern{ get; set; }

        /// <summary>
        /// SingleWorkflow
        /// </summary>
        [JsonProperty("SingleWorkflow")]
        public KnowledgeQaSingleWorkflow SingleWorkflow{ get; set; }

        /// <summary>
        /// 使用视觉模型时对话窗口输入字符限制
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VisionModelInputLimit")]
        public long? VisionModelInputLimit{ get; set; }

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
            this.SetParamSimple(map, prefix + "Token", this.Token);
            this.SetParamSimple(map, prefix + "Balance", this.Balance);
            this.SetParamSimple(map, prefix + "InputLenLimit", this.InputLenLimit);
            this.SetParamSimple(map, prefix + "Pattern", this.Pattern);
            this.SetParamObj(map, prefix + "SingleWorkflow.", this.SingleWorkflow);
            this.SetParamSimple(map, prefix + "VisionModelInputLimit", this.VisionModelInputLimit);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

