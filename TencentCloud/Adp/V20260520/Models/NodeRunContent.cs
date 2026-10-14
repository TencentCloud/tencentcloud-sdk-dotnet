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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NodeRunContent : AbstractModel
    {
        
        /// <summary>
        /// 输入变量信息
        /// </summary>
        [JsonProperty("Input")]
        public string Input{ get; set; }

        /// <summary>
        /// 输出变量信息
        /// </summary>
        [JsonProperty("Output")]
        public string Output{ get; set; }

        /// <summary>
        /// 原始输出信息。部分节点才有值，如工具节点、代码节点
        /// </summary>
        [JsonProperty("OriginalOutput")]
        public string OriginalOutput{ get; set; }

        /// <summary>
        /// 节点输入的完整内容的链接。（当Input内容超过限制的时候此字段才有值）
        /// </summary>
        [JsonProperty("InputRef")]
        public string InputRef{ get; set; }

        /// <summary>
        /// 节点输出的完整内容的链接。（当Output内容超过限制的时候此字段才有值）
        /// </summary>
        [JsonProperty("OutputRef")]
        public string OutputRef{ get; set; }

        /// <summary>
        /// 任务的原始输出的完整内容的链接。（当TaskOutput内容超过限制的时候此字段才有值）
        /// </summary>
        [JsonProperty("OriginalOutputRef")]
        public string OriginalOutputRef{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Input", this.Input);
            this.SetParamSimple(map, prefix + "Output", this.Output);
            this.SetParamSimple(map, prefix + "OriginalOutput", this.OriginalOutput);
            this.SetParamSimple(map, prefix + "InputRef", this.InputRef);
            this.SetParamSimple(map, prefix + "OutputRef", this.OutputRef);
            this.SetParamSimple(map, prefix + "OriginalOutputRef", this.OriginalOutputRef);
        }
    }
}

