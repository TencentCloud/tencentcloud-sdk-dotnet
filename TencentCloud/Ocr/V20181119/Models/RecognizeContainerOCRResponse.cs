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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecognizeContainerOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// 集装箱箱号
        /// </summary>
        [JsonProperty("ContainerId")]
        public string ContainerId{ get; set; }

        /// <summary>
        /// 集装箱类型
        /// </summary>
        [JsonProperty("ContainerType")]
        public string ContainerType{ get; set; }

        /// <summary>
        /// 集装箱总重量，单位：千克（KG）
        /// </summary>
        [JsonProperty("GrossKG")]
        public string GrossKG{ get; set; }

        /// <summary>
        /// 集装箱总重量，单位：磅（LB）
        /// </summary>
        [JsonProperty("GrossLB")]
        public string GrossLB{ get; set; }

        /// <summary>
        /// 集装箱有效承重，单位：千克（KG）
        /// </summary>
        [JsonProperty("PayloadKG")]
        public string PayloadKG{ get; set; }

        /// <summary>
        /// 集装箱有效承重，单位：磅（LB）
        /// </summary>
        [JsonProperty("PayloadLB")]
        public string PayloadLB{ get; set; }

        /// <summary>
        /// 集装箱容量，单位：立方米
        /// </summary>
        [JsonProperty("CapacityM3")]
        public string CapacityM3{ get; set; }

        /// <summary>
        /// 集装箱容量，单位：立英尺
        /// </summary>
        [JsonProperty("CapacityFT3")]
        public string CapacityFT3{ get; set; }

        /// <summary>
        /// 告警码
        /// -9926	集装箱箱号不完整或者不清晰
        /// -9927	集装箱类型不完整或者不清晰
        /// </summary>
        [JsonProperty("Warn")]
        public long?[] Warn{ get; set; }

        /// <summary>
        /// 集装箱自身重量，单位：千克（KG）
        /// </summary>
        [JsonProperty("TareKG")]
        public string TareKG{ get; set; }

        /// <summary>
        /// 集装箱自身重量，单位：磅（LB）
        /// </summary>
        [JsonProperty("TareLB")]
        public string TareLB{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ContainerId", this.ContainerId);
            this.SetParamSimple(map, prefix + "ContainerType", this.ContainerType);
            this.SetParamSimple(map, prefix + "GrossKG", this.GrossKG);
            this.SetParamSimple(map, prefix + "GrossLB", this.GrossLB);
            this.SetParamSimple(map, prefix + "PayloadKG", this.PayloadKG);
            this.SetParamSimple(map, prefix + "PayloadLB", this.PayloadLB);
            this.SetParamSimple(map, prefix + "CapacityM3", this.CapacityM3);
            this.SetParamSimple(map, prefix + "CapacityFT3", this.CapacityFT3);
            this.SetParamArraySimple(map, prefix + "Warn.", this.Warn);
            this.SetParamSimple(map, prefix + "TareKG", this.TareKG);
            this.SetParamSimple(map, prefix + "TareLB", this.TareLB);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

