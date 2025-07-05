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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HealthChecker : AbstractModel
    {
        
        /// <summary>
        /// 健康检查策略，取值有：
        /// <li>HTTP；</li>
        /// <li>HTTPS；</li>
        /// <li>TCP；</li>
        /// <li>UDP；</li>
        /// <li>ICMP Ping；</li>
        /// <li>NoCheck。</li>
        /// 注意：NoCheck 表示不启用健康检查策略。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 检查端口。当 Type=HTTP 或 Type=HTTPS 或 Type=TCP 或 Type=UDP 时为必填。
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// 检查频率，表示多久发起一次健康检查任务，单位为秒。可取值有：30，60，180，300 或 600。
        /// </summary>
        [JsonProperty("Interval")]
        public ulong? Interval{ get; set; }

        /// <summary>
        /// 每一次健康检查的超时时间，若健康检查消耗时间大于此值，则检查结果判定为”不健康“， 单位为秒，默认值为 5s，取值必须小于 Interval。
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// 健康阈值，表示连续几次健康检查结果为"健康"，则判断源站为"健康"，单位为次，默认 3 次，最小取值 1 次。
        /// </summary>
        [JsonProperty("HealthThreshold")]
        public ulong? HealthThreshold{ get; set; }

        /// <summary>
        /// 不健康阈值，表示连续几次健康检查结果为"不健康"，则判断源站为"不健康"，单位为次，默认 2 次。
        /// </summary>
        [JsonProperty("CriticalThreshold")]
        public ulong? CriticalThreshold{ get; set; }

        /// <summary>
        /// 该参数仅当 Type=HTTP 或 Type=HTTPS 时有效，表示探测路径，需要填写完整的 host/path，不包含协议部分，例如：www.example.com/test。
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// 该参数仅当 Type=HTTP 或 Type=HTTPS 时有效，表示请求方法，取值有：
        /// <li>GET；</li>
        /// <li>HEAD。</li>
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// 该参数仅当 Type=HTTP 或 Type=HTTPS 时有效，表示探测节点向源站发起健康检查时，响应哪些状态码可用于认定探测结果为健康。
        /// </summary>
        [JsonProperty("ExpectedCodes")]
        public string[] ExpectedCodes{ get; set; }

        /// <summary>
        /// 该参数仅当 Type=HTTP 或 Type=HTTPS 时有效，表示探测请求携带的自定义  HTTP 请求头，至多可配置 10 个。
        /// </summary>
        [JsonProperty("Headers")]
        public CustomizedHeader[] Headers{ get; set; }

        /// <summary>
        /// 该参数仅当 Type=HTTP 或 Type=HTTPS 时有效，表示是否启用遵循 301/302 重定向。启用后，301/302 默认为"健康"的状态码，默认跳转 3 次。
        /// </summary>
        [JsonProperty("FollowRedirect")]
        public string FollowRedirect{ get; set; }

        /// <summary>
        /// 该参数仅当 Type=UDP 时有效，表示健康检查发送的内容。只允许 ASCII 可见字符，最大长度限制 500 个字符。
        /// </summary>
        [JsonProperty("SendContext")]
        public string SendContext{ get; set; }

        /// <summary>
        /// 该参数仅当 Type=UDP 时有效，表示健康检查期望源站返回结果。只允许 ASCII 可见字符，最大长度限制 500 个字符。
        /// </summary>
        [JsonProperty("RecvContext")]
        public string RecvContext{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "HealthThreshold", this.HealthThreshold);
            this.SetParamSimple(map, prefix + "CriticalThreshold", this.CriticalThreshold);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamArraySimple(map, prefix + "ExpectedCodes.", this.ExpectedCodes);
            this.SetParamArrayObj(map, prefix + "Headers.", this.Headers);
            this.SetParamSimple(map, prefix + "FollowRedirect", this.FollowRedirect);
            this.SetParamSimple(map, prefix + "SendContext", this.SendContext);
            this.SetParamSimple(map, prefix + "RecvContext", this.RecvContext);
        }
    }
}

