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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAgentApplicationRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>应用名称</p><p>入参限制：</p><ul><li>不能为空字符串</li><li>不能包含字符<code>|</code></li><li>不能超过64字符</li></ul>
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// <p>接入类型</p><p>枚举值：</p><ul><li>Langfuse： Langfuse 是一款开源的 LLM（大语言模型）工程与可观测性平台（LLMOps Tool）</li></ul>
        /// </summary>
        [JsonProperty("AccessType")]
        public string AccessType{ get; set; }

        /// <summary>
        /// <p>日志集Id。通过 <a href="https://cloud.tencent.com/document/product/614/58624">获取日志集列表</a>获取日志集Id。</p>
        /// </summary>
        [JsonProperty("LogsetId")]
        public string LogsetId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamSimple(map, prefix + "LogsetId", this.LogsetId);
        }
    }
}

