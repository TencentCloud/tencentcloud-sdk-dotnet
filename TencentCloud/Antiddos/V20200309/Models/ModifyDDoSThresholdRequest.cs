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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDDoSThresholdRequest : AbstractModel
    {
        
        /// <summary>
        /// DDoS清洗阈值，取值[0, 60, 80, 100, 150, 200, 250, 300, 400, 500, 700, 1000];
        /// 当设置值为0时，表示采用默认值；
        /// </summary>
        [JsonProperty("Threshold")]
        public ulong? Threshold{ get; set; }

        /// <summary>
        /// 资源ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// DDoS防护子产品代号（bgpip表示高防IP；bgp表示独享包；bgp-multip表示共享包；net表示高防IP专业版）
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// 配置其他阈值标志位，1表示配置其他阈值
        /// </summary>
        [JsonProperty("OtherThresholdFlag")]
        public long? OtherThresholdFlag{ get; set; }

        /// <summary>
        /// SYN FLOOD流量阈值
        /// </summary>
        [JsonProperty("SynFloodThreshold")]
        public ulong? SynFloodThreshold{ get; set; }

        /// <summary>
        /// SYN FLOOD包量阈值
        /// </summary>
        [JsonProperty("SynFloodPktThreshold")]
        public ulong? SynFloodPktThreshold{ get; set; }

        /// <summary>
        /// UDP FLOOD流量阈值
        /// </summary>
        [JsonProperty("UdpFloodThreshold")]
        public ulong? UdpFloodThreshold{ get; set; }

        /// <summary>
        /// UDP FLOOD包量阈值
        /// </summary>
        [JsonProperty("UdpFloodPktThreshold")]
        public ulong? UdpFloodPktThreshold{ get; set; }

        /// <summary>
        /// ACK FLOOD流量阈值
        /// </summary>
        [JsonProperty("AckFloodThreshold")]
        public ulong? AckFloodThreshold{ get; set; }

        /// <summary>
        /// ACK FLOOD包量阈值
        /// </summary>
        [JsonProperty("AckFloodPktThreshold")]
        public ulong? AckFloodPktThreshold{ get; set; }

        /// <summary>
        /// SYNACK FLOOD流量阈值
        /// </summary>
        [JsonProperty("SynAckFloodThreshold")]
        public ulong? SynAckFloodThreshold{ get; set; }

        /// <summary>
        /// SYNACK FLOOD包量阈值
        /// </summary>
        [JsonProperty("SynAckFloodPktThreshold")]
        public ulong? SynAckFloodPktThreshold{ get; set; }

        /// <summary>
        /// RST FLOOD流量阈值
        /// </summary>
        [JsonProperty("RstFloodThreshold")]
        public ulong? RstFloodThreshold{ get; set; }

        /// <summary>
        /// RST FLOOD包量阈值
        /// </summary>
        [JsonProperty("RstFloodPktThreshold")]
        public ulong? RstFloodPktThreshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Threshold", this.Threshold);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamSimple(map, prefix + "OtherThresholdFlag", this.OtherThresholdFlag);
            this.SetParamSimple(map, prefix + "SynFloodThreshold", this.SynFloodThreshold);
            this.SetParamSimple(map, prefix + "SynFloodPktThreshold", this.SynFloodPktThreshold);
            this.SetParamSimple(map, prefix + "UdpFloodThreshold", this.UdpFloodThreshold);
            this.SetParamSimple(map, prefix + "UdpFloodPktThreshold", this.UdpFloodPktThreshold);
            this.SetParamSimple(map, prefix + "AckFloodThreshold", this.AckFloodThreshold);
            this.SetParamSimple(map, prefix + "AckFloodPktThreshold", this.AckFloodPktThreshold);
            this.SetParamSimple(map, prefix + "SynAckFloodThreshold", this.SynAckFloodThreshold);
            this.SetParamSimple(map, prefix + "SynAckFloodPktThreshold", this.SynAckFloodPktThreshold);
            this.SetParamSimple(map, prefix + "RstFloodThreshold", this.RstFloodThreshold);
            this.SetParamSimple(map, prefix + "RstFloodPktThreshold", this.RstFloodPktThreshold);
        }
    }
}

