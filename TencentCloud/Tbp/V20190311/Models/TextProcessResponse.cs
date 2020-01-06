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

    public class TextProcessResponse : AbstractModel
    {
        
        /// <summary>
        /// 当前会话状态{会话开始: START; 会话中: COUTINUE; 会话结束: COMPLETE}。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DialogStatus")]
        public string DialogStatus{ get; set; }

        /// <summary>
        /// 匹配到的机器人名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BotName")]
        public string BotName{ get; set; }

        /// <summary>
        /// 匹配到的意图名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IntentName")]
        public string IntentName{ get; set; }

        /// <summary>
        /// 槽位信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SlotInfoList")]
        public SlotInfo[] SlotInfoList{ get; set; }

        /// <summary>
        /// 原始的用户说法。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InputText")]
        public string InputText{ get; set; }

        /// <summary>
        /// 透传字段，由用户自定义的WebService服务返回。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SessionAttributes")]
        public string SessionAttributes{ get; set; }

        /// <summary>
        /// 机器人对话的应答文本。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResponseText")]
        public string ResponseText{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "SlotInfoList.", this.SlotInfoList);
            this.SetParamSimple(map, prefix + "InputText", this.InputText);
            this.SetParamSimple(map, prefix + "SessionAttributes", this.SessionAttributes);
            this.SetParamSimple(map, prefix + "ResponseText", this.ResponseText);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

