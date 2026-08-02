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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TalkAgentInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>主账号UIN</p>
        /// </summary>
        [JsonProperty("Uin")]
        public long? Uin{ get; set; }

        /// <summary>
        /// <p>账号AppId</p>
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// <p>实例 ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>智能体ID</p>
        /// </summary>
        [JsonProperty("AgentId")]
        public string AgentId{ get; set; }

        /// <summary>
        /// <p>智能体名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>智能体描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>语音识别配置</p>
        /// </summary>
        [JsonProperty("STTConfig")]
        public TalkSTTConfig STTConfig{ get; set; }

        /// <summary>
        /// <p>大模型配置</p>
        /// </summary>
        [JsonProperty("LLMConfig")]
        public TalkLLMConfig LLMConfig{ get; set; }

        /// <summary>
        /// <p>语音合成配置</p>
        /// </summary>
        [JsonProperty("TTSConfig")]
        public TalkTTSConfig TTSConfig{ get; set; }

        /// <summary>
        /// <p>对话行为配置</p>
        /// </summary>
        [JsonProperty("ConversationConfig")]
        public TalkConversationConfig ConversationConfig{ get; set; }

        /// <summary>
        /// <p>长期记忆配置</p>
        /// </summary>
        [JsonProperty("MemoryConfig")]
        public TalkMemoryConfig MemoryConfig{ get; set; }

        /// <summary>
        /// <p>IoT 工具列表</p>
        /// </summary>
        [JsonProperty("IOTTools")]
        public TalkIOTTool[] IOTTools{ get; set; }

        /// <summary>
        /// <p>Webhook 工具列表</p>
        /// </summary>
        [JsonProperty("WebhookTools")]
        public TalkWebhookTool[] WebhookTools{ get; set; }

        /// <summary>
        /// <p>元信息JSON object 字符串</p>
        /// </summary>
        [JsonProperty("Metadata")]
        public string Metadata{ get; set; }

        /// <summary>
        /// <p>绑定关系列表</p>
        /// </summary>
        [JsonProperty("Bindings")]
        public TalkAgentBinding[] Bindings{ get; set; }

        /// <summary>
        /// <p>创建时间，Unix 秒</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间，Unix 秒</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }

        /// <summary>
        /// <p>事件回调配置</p>
        /// </summary>
        [JsonProperty("EventCallbackConfig")]
        public TalkEventCallbackConfig EventCallbackConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "AgentId", this.AgentId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamObj(map, prefix + "STTConfig.", this.STTConfig);
            this.SetParamObj(map, prefix + "LLMConfig.", this.LLMConfig);
            this.SetParamObj(map, prefix + "TTSConfig.", this.TTSConfig);
            this.SetParamObj(map, prefix + "ConversationConfig.", this.ConversationConfig);
            this.SetParamObj(map, prefix + "MemoryConfig.", this.MemoryConfig);
            this.SetParamArrayObj(map, prefix + "IOTTools.", this.IOTTools);
            this.SetParamArrayObj(map, prefix + "WebhookTools.", this.WebhookTools);
            this.SetParamSimple(map, prefix + "Metadata", this.Metadata);
            this.SetParamArrayObj(map, prefix + "Bindings.", this.Bindings);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamObj(map, prefix + "EventCallbackConfig.", this.EventCallbackConfig);
        }
    }
}

