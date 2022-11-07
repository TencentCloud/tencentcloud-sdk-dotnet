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

    public class FlowLogInfo : AbstractModel
    {
        
        /// <summary>
        /// 时间戳，单位为秒。
        /// </summary>
        [JsonProperty("Timestamp")]
        public long? Timestamp{ get; set; }

        /// <summary>
        /// 输入输出类型（input/output）。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 输入或输出Id。
        /// </summary>
        [JsonProperty("InputOutputId")]
        public string InputOutputId{ get; set; }

        /// <summary>
        /// 协议。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 事件代码。
        /// </summary>
        [JsonProperty("EventCode")]
        public string EventCode{ get; set; }

        /// <summary>
        /// 事件信息。
        /// </summary>
        [JsonProperty("EventMessage")]
        public string EventMessage{ get; set; }

        /// <summary>
        /// 对端IP。
        /// </summary>
        [JsonProperty("RemoteIp")]
        public string RemoteIp{ get; set; }

        /// <summary>
        /// 对端端口。
        /// </summary>
        [JsonProperty("RemotePort")]
        public string RemotePort{ get; set; }

        /// <summary>
        /// 主备通道，0为主通道，1为备通道。
        /// </summary>
        [JsonProperty("Pipeline")]
        public string Pipeline{ get; set; }

        /// <summary>
        /// 输入或输出的名称。
        /// </summary>
        [JsonProperty("InputOutputName")]
        public string InputOutputName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "InputOutputId", this.InputOutputId);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "EventCode", this.EventCode);
            this.SetParamSimple(map, prefix + "EventMessage", this.EventMessage);
            this.SetParamSimple(map, prefix + "RemoteIp", this.RemoteIp);
            this.SetParamSimple(map, prefix + "RemotePort", this.RemotePort);
            this.SetParamSimple(map, prefix + "Pipeline", this.Pipeline);
            this.SetParamSimple(map, prefix + "InputOutputName", this.InputOutputName);
        }
    }
}

