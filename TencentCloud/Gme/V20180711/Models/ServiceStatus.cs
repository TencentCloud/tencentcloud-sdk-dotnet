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

namespace TencentCloud.Gme.V20180711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServiceStatus : AbstractModel
    {
        
        /// <summary>
        /// 实时语音服务开关状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealTimeSpeech")]
        public StatusInfo RealTimeSpeech{ get; set; }

        /// <summary>
        /// 语音消息服务开关状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VoiceMessage")]
        public StatusInfo VoiceMessage{ get; set; }

        /// <summary>
        /// 语音内容安全服务开关状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Porn")]
        public StatusInfo Porn{ get; set; }

        /// <summary>
        /// 语音录制服务开关状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Live")]
        public StatusInfo Live{ get; set; }

        /// <summary>
        /// 语音转文本服务开关状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealTimeAsr")]
        public StatusInfo RealTimeAsr{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "RealTimeSpeech.", this.RealTimeSpeech);
            this.SetParamObj(map, prefix + "VoiceMessage.", this.VoiceMessage);
            this.SetParamObj(map, prefix + "Porn.", this.Porn);
            this.SetParamObj(map, prefix + "Live.", this.Live);
            this.SetParamObj(map, prefix + "RealTimeAsr.", this.RealTimeAsr);
        }
    }
}

