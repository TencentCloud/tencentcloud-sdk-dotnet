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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServerPushText : AbstractModel
    {
        
        /// <summary>
        /// 服务端推送播报文本
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 是否允许该文本打断机器人说话
        /// </summary>
        [JsonProperty("Interrupt")]
        public bool? Interrupt{ get; set; }

        /// <summary>
        /// 播报完文本后，是否自动关闭对话任务
        /// </summary>
        [JsonProperty("StopAfterPlay")]
        public bool? StopAfterPlay{ get; set; }

        /// <summary>
        /// 服务端推送播报音频
        ///     格式说明：音频必须为单声道，采样率必须跟对应TTS的采样率保持一致，编码为Base64字符串。
        ///     输入规则：当提供Audio字段时，将不接受Text字段的输入。系统将直接播放Audio字段中的音频内容。
        /// </summary>
        [JsonProperty("Audio")]
        public string Audio{ get; set; }

        /// <summary>
        /// 默认为0，仅在Interrupt为false时有效
        /// - 0表示当前有交互发生时，会丢弃Interrupt为false的消息
        /// - 1表示当前有交互发生时，不会丢弃Interrupt为false的消息，而是缓存下来，等待当前交互结束后，再去处理
        /// 
        /// 注意：DropMode为1时，允许缓存多个消息，如果后续出现了打断，缓存的消息会被清空
        /// </summary>
        [JsonProperty("DropMode")]
        public ulong? DropMode{ get; set; }

        /// <summary>
        /// ServerPushText消息的优先级，0表示可被打断，1表示不会被打断。
        /// 注意：在接收到Priority=1的消息后，后续其他任何消息都会被忽略（包括Priority=1的消息），直到Priority=1的消息处理结束。该字段可与Interrupt、DropMode字段配合使用。
        /// 例子：
        /// - Priority=1、Interrupt=true，会打断现有交互，立刻播报，播报过程中不会被打断
        /// - Priority=1、Interrupt=false、DropMode=1，会等待当前交互结束，再进行播报，播报过程中不会被打断
        /// </summary>
        [JsonProperty("Priority")]
        public ulong? Priority{ get; set; }

        /// <summary>
        /// 是否将文本加入到llm历史上下文中
        /// </summary>
        [JsonProperty("AddHistory")]
        public bool? AddHistory{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "Interrupt", this.Interrupt);
            this.SetParamSimple(map, prefix + "StopAfterPlay", this.StopAfterPlay);
            this.SetParamSimple(map, prefix + "Audio", this.Audio);
            this.SetParamSimple(map, prefix + "DropMode", this.DropMode);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "AddHistory", this.AddHistory);
        }
    }
}

