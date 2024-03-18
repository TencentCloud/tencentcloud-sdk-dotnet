/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Intention : AbstractModel
    {
        
        /// <summary>
        /// 视频认证类型，支持以下类型
        /// <ul><li>1 : 问答模式</li>
        /// <li>2 : 点头模式</li></ul>
        /// 
        /// 注: `视频认证为白名单功能，使用前请联系对接的客户经理沟通。`
        /// </summary>
        [JsonProperty("IntentionType")]
        public long? IntentionType{ get; set; }

        /// <summary>
        /// 意愿核身语音问答模式（即语音播报+语音回答）使用的文案，包括：系统语音播报的文本、需要核验的标准文本。当前仅支持1轮问答。
        /// 
        /// 注：`选择问答模式时，此字段可不传，不传则使用默认语音文本：请问，您是否同意签署本协议？可语音回复“同意”或“不同意”。`
        /// </summary>
        [JsonProperty("IntentionQuestions")]
        public IntentionQuestion[] IntentionQuestions{ get; set; }

        /// <summary>
        /// 意愿核身（点头确认模式）使用的文案，若未使用意愿核身（点头确认模式），则该字段无需传入。当前仅支持一个提示文本。
        /// 
        /// 注：`选择点头模式时，此字段可不传，不传则使用默认语音文本：请问，您是否同意签署本协议？可点头同意。`
        /// </summary>
        [JsonProperty("IntentionActions")]
        public IntentionAction[] IntentionActions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IntentionType", this.IntentionType);
            this.SetParamArrayObj(map, prefix + "IntentionQuestions.", this.IntentionQuestions);
            this.SetParamArrayObj(map, prefix + "IntentionActions.", this.IntentionActions);
        }
    }
}

