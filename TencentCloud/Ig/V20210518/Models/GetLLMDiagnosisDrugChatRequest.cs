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

namespace TencentCloud.Ig.V20210518.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetLLMDiagnosisDrugChatRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>合作方ID</p>
        /// </summary>
        [JsonProperty("PartnerId")]
        public string PartnerId{ get; set; }

        /// <summary>
        /// <p>合作方密钥</p>
        /// </summary>
        [JsonProperty("PartnerSecret")]
        public string PartnerSecret{ get; set; }

        /// <summary>
        /// <p>医院应用ID</p>
        /// </summary>
        [JsonProperty("HospitalAppId")]
        public string HospitalAppId{ get; set; }

        /// <summary>
        /// <p>对话ID，由接入方生成，相同对话ID会保持相同的上下文，接入方根据业务场景使用相同或新建对话ID（建议使用UUID值）</p><p>入参限制：长度限制10-50</p>
        /// </summary>
        [JsonProperty("DialogueId")]
        public string DialogueId{ get; set; }

        /// <summary>
        /// <p>本次问答用户输入的问题，（最大长度1000）</p>
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// <p>返回类型：0:正常返回； 1:流式返回； 默认：0</p>
        /// </summary>
        [JsonProperty("ResultType")]
        public long? ResultType{ get; set; }

        /// <summary>
        /// <p>提示词</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PartnerId", this.PartnerId);
            this.SetParamSimple(map, prefix + "PartnerSecret", this.PartnerSecret);
            this.SetParamSimple(map, prefix + "HospitalAppId", this.HospitalAppId);
            this.SetParamSimple(map, prefix + "DialogueId", this.DialogueId);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "ResultType", this.ResultType);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
        }
    }
}

