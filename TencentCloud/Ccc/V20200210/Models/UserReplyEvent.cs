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

    public class UserReplyEvent : AbstractModel
    {
        
        /// <summary>
        /// <p>ASR语音识别引擎将用户语音转换成的原始文本结果</p>
        /// </summary>
        [JsonProperty("ASRTranscript")]
        public string ASRTranscript{ get; set; }

        /// <summary>
        /// <p>命中画布中该对话节点配置的回复分类</p>
        /// </summary>
        [JsonProperty("MatchedIntent")]
        public string MatchedIntent{ get; set; }

        /// <summary>
        /// <p>用户回复分类的标签， json序列化后的信息</p>
        /// </summary>
        [JsonProperty("ExtractedSlots")]
        public string ExtractedSlots{ get; set; }

        /// <summary>
        /// <p>用户回复命中的分支类型</p><p>枚举值：</p><ul><li>Intent： 用户意图</li><li>Fallback： 兜底分支</li><li>NoResponse： 无响应跳转分支</li><li>SlotCollectionSuccess： 词槽收集完成跳转分支</li><li>SlotCollectionFail： 词槽收集失败跳转分支</li><li>GlobalIntent： 全局节点意图</li><li>LogicAnd： 逻辑判断节点 and</li><li>LogicOr： 逻辑判断节点 or</li><li>DTMF成功： DTMFSuccess</li><li>DTMF失败： DTMFFail</li><li>DTMF导航： DTMFNavigation</li><li>DTMF分机： DTMFExtension</li><li>DTMF收号： DTMFCollection</li><li>转接智能体节点失败： TransferAgentFail</li></ul>
        /// </summary>
        [JsonProperty("BranchType")]
        public string BranchType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ASRTranscript", this.ASRTranscript);
            this.SetParamSimple(map, prefix + "MatchedIntent", this.MatchedIntent);
            this.SetParamSimple(map, prefix + "ExtractedSlots", this.ExtractedSlots);
            this.SetParamSimple(map, prefix + "BranchType", this.BranchType);
        }
    }
}

