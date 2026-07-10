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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChatCompletionsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>virtual key，用于向代理网关鉴权</p>
        /// </summary>
        [JsonProperty("ApiKey")]
        public string ApiKey{ get; set; }

        /// <summary>
        /// <p>多模态附件列表</p>
        /// </summary>
        [JsonProperty("Attachments")]
        public MultiModalityAttachments[] Attachments{ get; set; }

        /// <summary>
        /// <p>聊天内容</p>
        /// </summary>
        [JsonProperty("ChatContent")]
        public string ChatContent{ get; set; }

        /// <summary>
        /// <p>模型名称，配置的模型标识</p><p>示例：gpt-4o、deepseek-chat</p>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// <p>模型路由实例ID</p>
        /// </summary>
        [JsonProperty("ModelRouterId")]
        public string ModelRouterId{ get; set; }

        /// <summary>
        /// <p>请求路径</p><p>默认值：/v1/chat/completions</p>
        /// </summary>
        [JsonProperty("RequestPath")]
        public string RequestPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApiKey", this.ApiKey);
            this.SetParamArrayObj(map, prefix + "Attachments.", this.Attachments);
            this.SetParamSimple(map, prefix + "ChatContent", this.ChatContent);
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "ModelRouterId", this.ModelRouterId);
            this.SetParamSimple(map, prefix + "RequestPath", this.RequestPath);
        }
    }
}

