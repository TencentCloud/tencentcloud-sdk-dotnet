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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAIAgentCallRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用 ID（必填），可以查看 https://console.cloud.tencent.com/ccc
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// AI智能体ID
        /// </summary>
        [JsonProperty("AIAgentId")]
        public ulong? AIAgentId{ get; set; }

        /// <summary>
        /// 被叫号码
        /// </summary>
        [JsonProperty("Callee")]
        public string Callee{ get; set; }

        /// <summary>
        /// 主叫号码列表
        /// </summary>
        [JsonProperty("Callers")]
        public string[] Callers{ get; set; }

        /// <summary>
        /// 提示词变量
        /// </summary>
        [JsonProperty("PromptVariables")]
        [System.Obsolete]
        public Variable[] PromptVariables{ get; set; }

        /// <summary>
        /// 通用变量： <p>提示词变量</p> <p>欢迎语变量</p> <p> 欢迎语延迟播放(秒级)：welcome-message-delay</p>  <p> dify变量</p>  
        /// 
        /// 1. dify-inputs-xxx 为dify的inputs变量
        /// 2.  dify-inputs-user 为dify的user值
        /// 3.  dify-inputs-conversation_id 为dify的conversation_id值
        /// </summary>
        [JsonProperty("Variables")]
        public Variable[] Variables{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "AIAgentId", this.AIAgentId);
            this.SetParamSimple(map, prefix + "Callee", this.Callee);
            this.SetParamArraySimple(map, prefix + "Callers.", this.Callers);
            this.SetParamArrayObj(map, prefix + "PromptVariables.", this.PromptVariables);
            this.SetParamArrayObj(map, prefix + "Variables.", this.Variables);
        }
    }
}

