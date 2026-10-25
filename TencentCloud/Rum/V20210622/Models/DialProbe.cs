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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DialProbe : AbstractModel
    {
        
        /// <summary>
        /// <p>探测目标 IP</p>
        /// </summary>
        [JsonProperty("TargetIp")]
        public string TargetIp{ get; set; }

        /// <summary>
        /// <p>本次探测是否成功</p>
        /// </summary>
        [JsonProperty("PingSuccess")]
        public bool? PingSuccess{ get; set; }

        /// <summary>
        /// <p>发送包数</p>
        /// </summary>
        [JsonProperty("Sent")]
        public float? Sent{ get; set; }

        /// <summary>
        /// <p>接收包数</p>
        /// </summary>
        [JsonProperty("Received")]
        public float? Received{ get; set; }

        /// <summary>
        /// <p>丢包率，0 到 100</p>
        /// </summary>
        [JsonProperty("Loss")]
        public float? Loss{ get; set; }

        /// <summary>
        /// <p>最小时延，单位毫秒</p>
        /// </summary>
        [JsonProperty("Min")]
        public float? Min{ get; set; }

        /// <summary>
        /// <p>最大时延，单位毫秒</p>
        /// </summary>
        [JsonProperty("Max")]
        public float? Max{ get; set; }

        /// <summary>
        /// <p>平均时延，单位毫秒</p>
        /// </summary>
        [JsonProperty("Avg")]
        public float? Avg{ get; set; }

        /// <summary>
        /// <p>探测协议</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>探测目标域名或地址</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>未探测原因</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SkipReason")]
        public string SkipReason{ get; set; }

        /// <summary>
        /// <p>目标 IP 所在地区。与客户端地区无关。无法解析时为未知。</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>目标 IP 所属运营商。与客户端运营商无关。无法解析时为未知。</p>
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetIp", this.TargetIp);
            this.SetParamSimple(map, prefix + "PingSuccess", this.PingSuccess);
            this.SetParamSimple(map, prefix + "Sent", this.Sent);
            this.SetParamSimple(map, prefix + "Received", this.Received);
            this.SetParamSimple(map, prefix + "Loss", this.Loss);
            this.SetParamSimple(map, prefix + "Min", this.Min);
            this.SetParamSimple(map, prefix + "Max", this.Max);
            this.SetParamSimple(map, prefix + "Avg", this.Avg);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "SkipReason", this.SkipReason);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

