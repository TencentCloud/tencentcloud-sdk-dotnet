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

    public class CreateAppRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>应用类型；<code>&quot;knowledge_qa&quot;</code> 知识问答应用（包含标准模式 单工作流 Multi-Agent 等模式）</p>
        /// </summary>
        [JsonProperty("AppType")]
        public string AppType{ get; set; }

        /// <summary>
        /// <p>应用基础配置</p>
        /// </summary>
        [JsonProperty("BaseConfig")]
        public BaseConfig BaseConfig{ get; set; }

        /// <summary>
        /// <p>应用模式 standard:标准模式, agent: agent模式，single_workflow：单工作流模式,ClawAgent:Claw模式</p>
        /// </summary>
        [JsonProperty("Pattern")]
        public string Pattern{ get; set; }

        /// <summary>
        /// <p>智能体类型，用于区分应用最终以何种智能体形态对外服务（对话(&quot;dialogue&quot;) / 公众号(&quot;wechat&quot;)）。当前 ADP 创建页面不区分对话/公众号智能体，ADP 创建页默认走对话智能体。</p>
        /// </summary>
        [JsonProperty("AgentType")]
        public string AgentType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppType", this.AppType);
            this.SetParamObj(map, prefix + "BaseConfig.", this.BaseConfig);
            this.SetParamSimple(map, prefix + "Pattern", this.Pattern);
            this.SetParamSimple(map, prefix + "AgentType", this.AgentType);
        }
    }
}

