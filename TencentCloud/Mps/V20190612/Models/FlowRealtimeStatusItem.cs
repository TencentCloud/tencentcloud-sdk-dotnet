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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FlowRealtimeStatusItem : AbstractModel
    {
        
        /// <summary>
        /// 类型，Input|Output。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 输入Id，如果Type为Input，此字段不为空。
        /// </summary>
        [JsonProperty("InputId")]
        public string InputId{ get; set; }

        /// <summary>
        /// 输出Id，如果Type为Output，此字段不为空。
        /// </summary>
        [JsonProperty("OutputId")]
        public string OutputId{ get; set; }

        /// <summary>
        /// 流Id。
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 协议， SRT | RTMP。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 共同状态信息。
        /// </summary>
        [JsonProperty("CommonStatus")]
        public FlowRealtimeStatusCommon CommonStatus{ get; set; }

        /// <summary>
        /// 如果是SRT协议则有此字段。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SRTStatus")]
        public FlowRealtimeStatusSRT SRTStatus{ get; set; }

        /// <summary>
        /// 如果是RTMP协议则有此字段。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RTMPStatus")]
        public FlowRealtimeStatusRTMP RTMPStatus{ get; set; }

        /// <summary>
        /// 服务器IP。
        /// </summary>
        [JsonProperty("ConnectServerIP")]
        public string ConnectServerIP{ get; set; }

        /// <summary>
        /// 如果是RTP协议则有此字段。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RTPStatus")]
        public FlowRealtimeStatusRTP RTPStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "InputId", this.InputId);
            this.SetParamSimple(map, prefix + "OutputId", this.OutputId);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamObj(map, prefix + "CommonStatus.", this.CommonStatus);
            this.SetParamObj(map, prefix + "SRTStatus.", this.SRTStatus);
            this.SetParamObj(map, prefix + "RTMPStatus.", this.RTMPStatus);
            this.SetParamSimple(map, prefix + "ConnectServerIP", this.ConnectServerIP);
            this.SetParamObj(map, prefix + "RTPStatus.", this.RTPStatus);
        }
    }
}

