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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VoiceConversationInvokeTTS : AbstractModel
    {
        
        /// <summary>
        /// <p>注入的内容。</p>
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// <p>优先级。如果不处于对话中则将注入的内容送给TTS，否则由优先级决定。</p><p>枚举值：</p><ul><li>0： 高优先级，打断当前对话，并清空等待队列将注入的内容送给TTS。</li><li>1： 中优先级，不会打断当前对话，清空等待队列将注入的内容排队。如果不处于对话中则将注入的内容排队。</li><li>2： 低优先级，丢弃注入的内容。</li></ul><p>默认值：0</p><p>InvokeLLM和InvokeTTS的任务队列是同一队列，最多支持一个Invoke事件排队。</p>
        /// </summary>
        [JsonProperty("Priority")]
        public ulong? Priority{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
        }
    }
}

