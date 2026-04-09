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

namespace TencentCloud.Hai.V20230812.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProbeConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>HTTP GET请求进行健康检查</p>
        /// </summary>
        [JsonProperty("HttpGet")]
        public HttpConfig HttpGet{ get; set; }

        /// <summary>
        /// <p>容器启动后，等待多少秒开始第一次探测</p>
        /// </summary>
        [JsonProperty("InitialDelaySeconds")]
        public long? InitialDelaySeconds{ get; set; }

        /// <summary>
        /// <p>每次执行探测的间隔时间（秒）</p>
        /// </summary>
        [JsonProperty("PeriodSeconds")]
        public long? PeriodSeconds{ get; set; }

        /// <summary>
        /// <p>每次探测等待响应的超时时间（秒）</p>
        /// </summary>
        [JsonProperty("TimeoutSeconds")]
        public long? TimeoutSeconds{ get; set; }

        /// <summary>
        /// <p>探测失败后，最小连续成功次数才被认为成功</p>
        /// </summary>
        [JsonProperty("SuccessThreshold")]
        public long? SuccessThreshold{ get; set; }

        /// <summary>
        /// <p>探测失败后，Kubernetes的重试次数</p>
        /// </summary>
        [JsonProperty("FailureThreshold")]
        public long? FailureThreshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "HttpGet.", this.HttpGet);
            this.SetParamSimple(map, prefix + "InitialDelaySeconds", this.InitialDelaySeconds);
            this.SetParamSimple(map, prefix + "PeriodSeconds", this.PeriodSeconds);
            this.SetParamSimple(map, prefix + "TimeoutSeconds", this.TimeoutSeconds);
            this.SetParamSimple(map, prefix + "SuccessThreshold", this.SuccessThreshold);
            this.SetParamSimple(map, prefix + "FailureThreshold", this.FailureThreshold);
        }
    }
}

