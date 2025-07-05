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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeFlow : AbstractModel
    {
        
        /// <summary>
        /// 流Id。
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 流名称。
        /// </summary>
        [JsonProperty("FlowName")]
        public string FlowName{ get; set; }

        /// <summary>
        /// 流状态，目前有IDLE/RUNNING。
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 最大带宽值。
        /// </summary>
        [JsonProperty("MaxBandwidth")]
        public long? MaxBandwidth{ get; set; }

        /// <summary>
        /// 输入组。
        /// </summary>
        [JsonProperty("InputGroup")]
        public DescribeInput[] InputGroup{ get; set; }

        /// <summary>
        /// 输出组。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputGroup")]
        public DescribeOutput[] OutputGroup{ get; set; }

        /// <summary>
        /// 该Flow关联的媒体传输事件EventId。
        /// </summary>
        [JsonProperty("EventId")]
        public string EventId{ get; set; }

        /// <summary>
        /// 媒体传输输入流所属的区域，取值和InputRegion相同。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 该Flow允许创建的输入协议
        /// </summary>
        [JsonProperty("AllowedInputProtocols")]
        public string[] AllowedInputProtocols{ get; set; }

        /// <summary>
        /// 该Flow允许创建的输出协议
        /// </summary>
        [JsonProperty("AllowedOutputProtocols")]
        public string[] AllowedOutputProtocols{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "FlowName", this.FlowName);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "MaxBandwidth", this.MaxBandwidth);
            this.SetParamArrayObj(map, prefix + "InputGroup.", this.InputGroup);
            this.SetParamArrayObj(map, prefix + "OutputGroup.", this.OutputGroup);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamArraySimple(map, prefix + "AllowedInputProtocols.", this.AllowedInputProtocols);
            this.SetParamArraySimple(map, prefix + "AllowedOutputProtocols.", this.AllowedOutputProtocols);
        }
    }
}

