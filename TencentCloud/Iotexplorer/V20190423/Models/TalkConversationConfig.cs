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

    public class TalkConversationConfig : AbstractModel
    {
        
        /// <summary>
        /// 欢迎语
        /// </summary>
        [JsonProperty("WelcomeMessage")]
        public string WelcomeMessage{ get; set; }

        /// <summary>
        /// 欢迎语优先级。`0`=默认，`1`=高优不可打断
        /// </summary>
        [JsonProperty("WelcomeMessagePriority")]
        public long? WelcomeMessagePriority{ get; set; }

        /// <summary>
        /// 智能打断模式。`0`=服务端自动打断，`1`=端上发送打断信令
        /// </summary>
        [JsonProperty("InterruptMode")]
        public long? InterruptMode{ get; set; }

        /// <summary>
        /// 打断词列表。AI 说话期间，仅当用户说出列表中的词才打断 AI；不会触发新的回复
        /// </summary>
        [JsonProperty("InterruptWordList")]
        public string[] InterruptWordList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WelcomeMessage", this.WelcomeMessage);
            this.SetParamSimple(map, prefix + "WelcomeMessagePriority", this.WelcomeMessagePriority);
            this.SetParamSimple(map, prefix + "InterruptMode", this.InterruptMode);
            this.SetParamArraySimple(map, prefix + "InterruptWordList.", this.InterruptWordList);
        }
    }
}

