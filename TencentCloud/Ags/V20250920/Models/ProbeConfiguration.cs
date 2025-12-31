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

namespace TencentCloud.Ags.V20250920.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProbeConfiguration : AbstractModel
    {
        
        /// <summary>
        /// HTTP GET 探测配置
        /// </summary>
        [JsonProperty("HttpGet")]
        public HttpGetAction HttpGet{ get; set; }

        /// <summary>
        /// 健康检查就绪超时
        /// </summary>
        [JsonProperty("ReadyTimeoutMs")]
        public long? ReadyTimeoutMs{ get; set; }

        /// <summary>
        /// 健康检查单次探测超时
        /// </summary>
        [JsonProperty("ProbeTimeoutMs")]
        public long? ProbeTimeoutMs{ get; set; }

        /// <summary>
        /// 健康检查间隔
        /// </summary>
        [JsonProperty("ProbePeriodMs")]
        public long? ProbePeriodMs{ get; set; }

        /// <summary>
        /// 健康检查成功阈值
        /// </summary>
        [JsonProperty("SuccessThreshold")]
        public long? SuccessThreshold{ get; set; }

        /// <summary>
        /// 健康检查失败阈值
        /// </summary>
        [JsonProperty("FailureThreshold")]
        public long? FailureThreshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "HttpGet.", this.HttpGet);
            this.SetParamSimple(map, prefix + "ReadyTimeoutMs", this.ReadyTimeoutMs);
            this.SetParamSimple(map, prefix + "ProbeTimeoutMs", this.ProbeTimeoutMs);
            this.SetParamSimple(map, prefix + "ProbePeriodMs", this.ProbePeriodMs);
            this.SetParamSimple(map, prefix + "SuccessThreshold", this.SuccessThreshold);
            this.SetParamSimple(map, prefix + "FailureThreshold", this.FailureThreshold);
        }
    }
}

