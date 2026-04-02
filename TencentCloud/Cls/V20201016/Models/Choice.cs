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

    public class Choice : AbstractModel
    {
        
        /// <summary>
        /// <p>结束标志位，可能为 stop、 sensitive或者tool_calls。<br>stop 表示输出正常结束。<br>sensitive 表示安全审核未通过。<br>tool_calls 标识函数调用。</p><p>注意：<br>可能会出现部分内容已输出，但中间某一段响应中的 FinishReason 值为 sensitive，此时说明安全审核未通过。如果业务场景有实时文字上屏的需求，需要自行撤回已上屏的内容，并建议自定义替换为一条提示语，如 “这个问题我不方便回答，不如我们换个话题试试”，以保障终端体验。</p>
        /// </summary>
        [JsonProperty("FinishReason")]
        public string FinishReason{ get; set; }

        /// <summary>
        /// <p>增量返回值，流式调用时使用该字段。</p>
        /// </summary>
        [JsonProperty("Delta")]
        public Delta Delta{ get; set; }

        /// <summary>
        /// <p>返回值，非流式调用时使用该字段。</p>
        /// </summary>
        [JsonProperty("Message")]
        public Message Message{ get; set; }

        /// <summary>
        /// <p>索引值，流式调用时使用该字段。</p>
        /// </summary>
        [JsonProperty("Index")]
        public long? Index{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FinishReason", this.FinishReason);
            this.SetParamObj(map, prefix + "Delta.", this.Delta);
            this.SetParamObj(map, prefix + "Message.", this.Message);
            this.SetParamSimple(map, prefix + "Index", this.Index);
        }
    }
}

