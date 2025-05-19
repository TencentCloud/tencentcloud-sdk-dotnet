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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AICallConfig : AbstractModel
    {
        
        /// <summary>
        /// 启用语音互动功能
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableVoiceInteract")]
        public bool? EnableVoiceInteract{ get; set; }

        /// <summary>
        /// 启用语音通话
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableVoiceCall")]
        public bool? EnableVoiceCall{ get; set; }

        /// <summary>
        /// 启用数智人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableDigitalHuman")]
        public bool? EnableDigitalHuman{ get; set; }

        /// <summary>
        /// 音色配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Voice")]
        public VoiceConfig Voice{ get; set; }

        /// <summary>
        /// 数智人配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DigitalHuman")]
        public DigitalHumanConfig DigitalHuman{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableVoiceInteract", this.EnableVoiceInteract);
            this.SetParamSimple(map, prefix + "EnableVoiceCall", this.EnableVoiceCall);
            this.SetParamSimple(map, prefix + "EnableDigitalHuman", this.EnableDigitalHuman);
            this.SetParamObj(map, prefix + "Voice.", this.Voice);
            this.SetParamObj(map, prefix + "DigitalHuman.", this.DigitalHuman);
        }
    }
}

