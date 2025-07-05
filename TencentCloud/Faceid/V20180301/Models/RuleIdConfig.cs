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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleIdConfig : AbstractModel
    {
        
        /// <summary>
        /// 意愿核身过程中识别用户的回答意图，开启后除了IntentionQuestions的Answers列表中的标准回答会通过，近似意图的回答也会通过，默认开启。
        /// </summary>
        [JsonProperty("IntentionRecognition")]
        public bool? IntentionRecognition{ get; set; }

        /// <summary>
        /// 意愿核身类型，默认为0：
        /// 0：问答模式，DetectAuth接口需要传入IntentionQuestions字段；
        /// 1：点头模式，DetectAuth接口需要传入IntentionActions字段；
        /// </summary>
        [JsonProperty("IntentionType")]
        public long? IntentionType{ get; set; }

        /// <summary>
        /// 用户语音回答过程中是否开启张嘴识别检测，默认不开启，仅在意愿核身问答模式中使用。
        /// </summary>
        [JsonProperty("MouthOpenRecognition")]
        public bool? MouthOpenRecognition{ get; set; }

        /// <summary>
        /// 意愿核身语音播报速度，配置后问答模式和点头模式的语音播报环节都会生效，默认值为0：
        /// 0：智能语速（根据播报文案的长度自动调整语音播报速度）
        /// 1：固定1倍速
        /// 2：固定1.2倍速
        /// 3：固定1.5倍速
        /// </summary>
        [JsonProperty("Speed")]
        public ulong? Speed{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IntentionRecognition", this.IntentionRecognition);
            this.SetParamSimple(map, prefix + "IntentionType", this.IntentionType);
            this.SetParamSimple(map, prefix + "MouthOpenRecognition", this.MouthOpenRecognition);
            this.SetParamSimple(map, prefix + "Speed", this.Speed);
        }
    }
}

