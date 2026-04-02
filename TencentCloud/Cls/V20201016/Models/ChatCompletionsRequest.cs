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

    public class ChatCompletionsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>功能名称</p><p>枚举值：</p><ul><li>text2sql： 智能生成检索分析语句</li><li>text2sql-reasoning： 智能生成检索分析语句-深度思考</li></ul>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// <p>聊天上下文信息。<br>说明：</p><ol><li>长度最多为 11 (5轮历史会话 + user新提问) ，按对话时间从旧到新在数组中排列。超出此长度会丢弃旧会话数据。</li><li>Message.Role 可选值：user、assistant。<br>user 和 assistant 需交替出现，以 user 提问开始，user 提问结束，Content 不能为空。Role 的顺序示例：[user assistant user assistant user ...]。</li></ol>
        /// </summary>
        [JsonProperty("Messages")]
        public Message[] Messages{ get; set; }

        /// <summary>
        /// <p>流式调用开关。<br>说明：</p><ol><li>未传值时默认为非流式调用（false）。</li><li>流式调用时以 SSE 协议增量返回结果（返回值取 Choices[n].Delta 中的值，需要拼接增量数据才能获得完整结果）。</li><li>非流式调用时：<br>调用方式与普通 HTTP 请求无异。<br>接口响应耗时较长，如需更低时延建议设置为 true。<br>只返回一次最终结果（返回值取 Choices[n].Message 中的值）。</li></ol><p>注意：</p><ol><li>通过 SDK 调用时，流式和非流式调用需用不同的方式获取返回值，具体参考 SDK 中的注释或示例（在各语言 SDK 代码仓库的 examples/hunyuan/v20230901/ 目录中）。</li><li>可能会出现部分内容已输出，但中间某一段响应中的 FinishReason 值为 sensitive，此时说明安全审核未通过。如果业务场景有实时文字上屏的需求，需要自行撤回已上屏的内容，并建议自定义替换为一条提示语，如 “这个问题我不方便回答，不如我们换个话题试试”，以保障终端体验。</li></ol>
        /// </summary>
        [JsonProperty("Stream")]
        public bool? Stream{ get; set; }

        /// <summary>
        /// <p>额外元数据信息。例如：[{&quot;Key&quot;:&quot;topic_id&quot;,&quot;Value&quot;:&quot;xxxxxxxx-xxxx&quot;},{&quot;Key&quot;:&quot;topic_region&quot;,&quot;Value&quot;:&quot;ap-guangzhou&quot;}]</p>
        /// </summary>
        [JsonProperty("Metadata")]
        public MetadataItem[] Metadata{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamArrayObj(map, prefix + "Messages.", this.Messages);
            this.SetParamSimple(map, prefix + "Stream", this.Stream);
            this.SetParamArrayObj(map, prefix + "Metadata.", this.Metadata);
        }
    }
}

