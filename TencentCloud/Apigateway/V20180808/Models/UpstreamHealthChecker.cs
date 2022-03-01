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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpstreamHealthChecker : AbstractModel
    {
        
        /// <summary>
        /// 标识是否开启主动健康检查。
        /// </summary>
        [JsonProperty("EnableActiveCheck")]
        public bool? EnableActiveCheck{ get; set; }

        /// <summary>
        /// 标识是否开启被动健康检查。
        /// </summary>
        [JsonProperty("EnablePassiveCheck")]
        public bool? EnablePassiveCheck{ get; set; }

        /// <summary>
        /// 健康检查时，判断为成功请求的 HTTP 状态码。
        /// </summary>
        [JsonProperty("HealthyHttpStatus")]
        public string HealthyHttpStatus{ get; set; }

        /// <summary>
        /// 健康检查时，判断为失败请求的 HTTP 状态码。
        /// </summary>
        [JsonProperty("UnhealthyHttpStatus")]
        public string UnhealthyHttpStatus{ get; set; }

        /// <summary>
        /// TCP连续错误阈值。0 表示禁用 TCP 检查。取值范围：[0, 254]。
        /// </summary>
        [JsonProperty("TcpFailureThreshold")]
        public ulong? TcpFailureThreshold{ get; set; }

        /// <summary>
        /// 连续超时阈值。0 表示禁用超时检查。取值范围：[0, 254]。
        /// </summary>
        [JsonProperty("TimeoutThreshold")]
        public ulong? TimeoutThreshold{ get; set; }

        /// <summary>
        /// HTTP连续错误阈值。0 表示禁用HTTP检查。取值范围：[0, 254]。
        /// </summary>
        [JsonProperty("HttpFailureThreshold")]
        public ulong? HttpFailureThreshold{ get; set; }

        /// <summary>
        /// 主动健康检查时探测请求的路径。默认为"/"。
        /// </summary>
        [JsonProperty("ActiveCheckHttpPath")]
        public string ActiveCheckHttpPath{ get; set; }

        /// <summary>
        /// 主动健康检查的探测请求超时，单位秒。默认为5秒。
        /// </summary>
        [JsonProperty("ActiveCheckTimeout")]
        public ulong? ActiveCheckTimeout{ get; set; }

        /// <summary>
        /// 主动健康检查的时间间隔，默认5秒。
        /// </summary>
        [JsonProperty("ActiveCheckInterval")]
        public ulong? ActiveCheckInterval{ get; set; }

        /// <summary>
        /// 主动健康检查时探测请求的的请求头。
        /// </summary>
        [JsonProperty("ActiveRequestHeader")]
        public UpstreamHealthCheckerReqHeaders[] ActiveRequestHeader{ get; set; }

        /// <summary>
        /// 异常节点的状态自动恢复时间，单位秒。当只开启被动检查的话，必须设置为 > 0 的值，否则被动异常节点将无法恢复。默认30秒。
        /// </summary>
        [JsonProperty("UnhealthyTimeout")]
        public ulong? UnhealthyTimeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableActiveCheck", this.EnableActiveCheck);
            this.SetParamSimple(map, prefix + "EnablePassiveCheck", this.EnablePassiveCheck);
            this.SetParamSimple(map, prefix + "HealthyHttpStatus", this.HealthyHttpStatus);
            this.SetParamSimple(map, prefix + "UnhealthyHttpStatus", this.UnhealthyHttpStatus);
            this.SetParamSimple(map, prefix + "TcpFailureThreshold", this.TcpFailureThreshold);
            this.SetParamSimple(map, prefix + "TimeoutThreshold", this.TimeoutThreshold);
            this.SetParamSimple(map, prefix + "HttpFailureThreshold", this.HttpFailureThreshold);
            this.SetParamSimple(map, prefix + "ActiveCheckHttpPath", this.ActiveCheckHttpPath);
            this.SetParamSimple(map, prefix + "ActiveCheckTimeout", this.ActiveCheckTimeout);
            this.SetParamSimple(map, prefix + "ActiveCheckInterval", this.ActiveCheckInterval);
            this.SetParamArrayObj(map, prefix + "ActiveRequestHeader.", this.ActiveRequestHeader);
            this.SetParamSimple(map, prefix + "UnhealthyTimeout", this.UnhealthyTimeout);
        }
    }
}

