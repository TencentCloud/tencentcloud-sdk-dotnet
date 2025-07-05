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

    public class QueryRewriteRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要改写的问题
        /// </summary>
        [JsonProperty("Question")]
        public string Question{ get; set; }

        /// <summary>
        /// 需要改写的多轮历史会话，每轮历史对话需要包含user（问）和assistant（答）成对输入，由于模型字符限制，最多提供4轮对话。
        /// </summary>
        [JsonProperty("Messages")]
        public Message[] Messages{ get; set; }

        /// <summary>
        /// 模型名称
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Question", this.Question);
            this.SetParamArrayObj(map, prefix + "Messages.", this.Messages);
            this.SetParamSimple(map, prefix + "Model", this.Model);
        }
    }
}

