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

namespace TencentCloud.Hunyuan.V20230901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RunThreadRequest : AbstractModel
    {
        
        /// <summary>
        /// 会话 ID
        /// </summary>
        [JsonProperty("ThreadID")]
        public string ThreadID{ get; set; }

        /// <summary>
        /// 助手 ID（目前未使用，留空）
        /// </summary>
        [JsonProperty("AssistantID")]
        public string AssistantID{ get; set; }

        /// <summary>
        /// 模型名称，可选值包括 hunyuan-lite、hunyuan-standard、hunyuan-standard-256K、hunyuan-pro、 hunyuan-code、 hunyuan-role、 hunyuan-functioncall、 hunyuan-vision、 hunyuan-turbo。各模型介绍请阅读 [产品概述](https://cloud.tencent.com/document/product/1729/104753) 中的说明。注意：不同的模型计费不同，请根据 [购买指南](https://cloud.tencent.com/document/product/1729/97731) 按需调用。
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// 附加消息
        /// </summary>
        [JsonProperty("AdditionalMessages")]
        public ThreadAdditionalMessage[] AdditionalMessages{ get; set; }

        /// <summary>
        /// 说明：1. 影响模型输出多样性，模型已有默认参数，不传值时使用各模型推荐值，不推荐用户修改。2. 取值区间为 [0.0, 2.0]。较高的数值会使输出更加多样化和不可预测，而较低的数值会使其更加集中和确定。
        /// </summary>
        [JsonProperty("Temperature")]
        public float? Temperature{ get; set; }

        /// <summary>
        /// 说明：1. 影响输出文本的多样性。模型已有默认参数，不传值时使用各模型推荐值，不推荐用户修改。2. 取值区间为 [0.0, 1.0]。取值越大，生成文本的多样性越强。
        /// </summary>
        [JsonProperty("TopP")]
        public float? TopP{ get; set; }

        /// <summary>
        /// 是否流式输出，当前只允许 true
        /// </summary>
        [JsonProperty("Stream")]
        public bool? Stream{ get; set; }

        /// <summary>
        /// 运行过程中可使用的 token 最大数量。
        /// </summary>
        [JsonProperty("MaxPromptTokens")]
        public long? MaxPromptTokens{ get; set; }

        /// <summary>
        /// 运行过程中可使用的完成 token 的最大数量。
        /// </summary>
        [JsonProperty("MaxCompletionTokens")]
        public long? MaxCompletionTokens{ get; set; }

        /// <summary>
        /// 可调用的工具列表，仅对 hunyuan-pro、hunyuan-turbo、hunyuan-functioncall 模型生效。
        /// </summary>
        [JsonProperty("Tools")]
        public Tool[] Tools{ get; set; }

        /// <summary>
        /// 工具使用选项，可选值包括 none、auto、custom。说明：1. 仅对 hunyuan-pro、hunyuan-turbo、hunyuan-functioncall 模型生效。2. none：不调用工具；auto：模型自行选择生成回复或调用工具；custom：强制模型调用指定的工具。3. 未设置时，默认值为auto
        /// </summary>
        [JsonProperty("ToolChoice")]
        public string ToolChoice{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ThreadID", this.ThreadID);
            this.SetParamSimple(map, prefix + "AssistantID", this.AssistantID);
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamArrayObj(map, prefix + "AdditionalMessages.", this.AdditionalMessages);
            this.SetParamSimple(map, prefix + "Temperature", this.Temperature);
            this.SetParamSimple(map, prefix + "TopP", this.TopP);
            this.SetParamSimple(map, prefix + "Stream", this.Stream);
            this.SetParamSimple(map, prefix + "MaxPromptTokens", this.MaxPromptTokens);
            this.SetParamSimple(map, prefix + "MaxCompletionTokens", this.MaxCompletionTokens);
            this.SetParamArrayObj(map, prefix + "Tools.", this.Tools);
            this.SetParamSimple(map, prefix + "ToolChoice", this.ToolChoice);
        }
    }
}

