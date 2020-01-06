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

namespace TencentCloud.Tbp.V20190311.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResetResponse : AbstractModel
    {
        
        /// <summary>
        /// 当前会话状态。取值:"start"/"continue"/"complete"
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DialogStatus")]
        public string DialogStatus{ get; set; }

        /// <summary>
        /// 匹配到的机器人名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BotName")]
        public string BotName{ get; set; }

        /// <summary>
        /// 匹配到的意图名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IntentName")]
        public string IntentName{ get; set; }

        /// <summary>
        /// 机器人回答
        /// </summary>
        [JsonProperty("ResponseText")]
        public string ResponseText{ get; set; }

        /// <summary>
        /// 语义解析的槽位结果列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SlotInfoList")]
        public SlotInfo[] SlotInfoList{ get; set; }

        /// <summary>
        /// 透传字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SessionAttributes")]
        public string SessionAttributes{ get; set; }

        /// <summary>
        /// 用户说法。该说法是用户原生说法或ASR识别结果，未经过语义优化
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Question")]
        public string Question{ get; set; }

        /// <summary>
        /// tts合成pcm音频存储链接。仅当请求参数NeedTts=true时返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WaveUrl")]
        public string WaveUrl{ get; set; }

        /// <summary>
        /// tts合成的pcm音频。二进制数组经过base64编码(暂时不返回)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WaveData")]
        public string WaveData{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DialogStatus", this.DialogStatus);
            this.SetParamSimple(map, prefix + "BotName", this.BotName);
            this.SetParamSimple(map, prefix + "IntentName", this.IntentName);
            this.SetParamSimple(map, prefix + "ResponseText", this.ResponseText);
            this.SetParamArrayObj(map, prefix + "SlotInfoList.", this.SlotInfoList);
            this.SetParamSimple(map, prefix + "SessionAttributes", this.SessionAttributes);
            this.SetParamSimple(map, prefix + "Question", this.Question);
            this.SetParamSimple(map, prefix + "WaveUrl", this.WaveUrl);
            this.SetParamSimple(map, prefix + "WaveData", this.WaveData);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

