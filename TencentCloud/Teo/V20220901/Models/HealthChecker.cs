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
        /// <p>健康检查策略，取值有：</p><li>HTTP；</li><li>HTTPS；</li><li>TCP；</li><li>UDP；</li><li>ICMP Ping；</li><li>NoCheck。</li>注意：NoCheck 表示不启用健康检查策略。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>检查端口。当 Type=HTTP 或 Type=HTTPS 或 Type=TCP 或 Type=UDP 时为必填。</p>
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// <p>检查频率，表示多久发起一次健康检查任务，单位为秒。可配置 10-600 秒。</p>
        /// </summary>
        [JsonProperty("Interval")]
        public ulong? Interval{ get; set; }

        /// <summary>
        /// <p>每一次健康检查的超时时间，若健康检查消耗时间大于此值，则检查结果判定为“不健康”， 单位为秒，默认值为 5s，取值必须小于 Interval。</p>
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// <p>健康阈值，表示连续几次健康检查结果为&quot;健康&quot;，则判断源站为&quot;健康&quot;，单位为次，默认 3 次，最小取值 1 次。</p>
        /// </summary>
        [JsonProperty("HealthThreshold")]
        public ulong? HealthThreshold{ get; set; }

        /// <summary>
        /// <p>不健康阈值，表示连续几次健康检查结果为&quot;不健康&quot;，则判断源站为&quot;不健康&quot;，单位为次，默认 2 次。</p>
        /// </summary>
        [JsonProperty("CriticalThreshold")]
        public ulong? CriticalThreshold{ get; set; }

        /// <summary>
        /// <p>该参数仅当 Type=HTTP 或 Type=HTTPS 时有效，表示探测路径，需要填写完整的 host/path，不包含协议部分，例如：www.example.com/test。</p>
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// <p>该参数仅当 Type=HTTP 或 Type=HTTPS 时有效，表示请求方法，取值有：</p><li>GET；</li><li>HEAD。</li>
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// <p>该参数仅当 Type=HTTP 或 Type=HTTPS 时有效，表示探测节点向源站发起健康检查时，响应哪些状态码可用于认定探测结果为健康。</p>
        /// </summary>
        [JsonProperty("ExpectedCodes")]
        public string[] ExpectedCodes{ get; set; }

        /// <summary>
        /// <p>该参数仅当 Type=HTTP 或 Type=HTTPS 时有效，表示探测请求携带的自定义  HTTP 请求头，至多可配置 10 个。</p>
        /// </summary>
        [JsonProperty("Headers")]
        public CustomizedHeader[] Headers{ get; set; }

        /// <summary>
        /// <p>该参数仅当 Type=HTTP 或 Type=HTTPS 时有效，表示是否启用遵循 301/302 重定向。启用后，301/302 默认为&quot;健康&quot;的状态码，默认跳转 3 次。</p>
        /// </summary>
        [JsonProperty("FollowRedirect")]
        public string FollowRedirect{ get; set; }

        /// <summary>
        /// <p>该参数仅当 Type=UDP 时有效，表示健康检查发送的内容。只允许 ASCII 可见字符，最大长度限制 500 个字符。</p>
        /// </summary>
        [JsonProperty("SendContext")]
        public string SendContext{ get; set; }

        /// <summary>
        /// <p>该参数仅当 Type=UDP 时有效，表示健康检查期望源站返回结果。只允许 ASCII 可见字符，最大长度限制 500 个字符。</p>
        /// </summary>
        [JsonProperty("RecvContext")]
        public string RecvContext{ get; set; }

        /// <summary>
        /// <p>健康检查探测集群。指定本负载均衡实例发起健康探测的集群区域范围，探测集群地区分布详见<a href="https://cloud.tencent.com/document/product/1552/104228">健康检查策略介绍</a>，仅 HTTP 专用型（V2）版本负载均衡实例支持设置。取值有：<br>global：由全球所有区域的探测集群发起探测，包括中国大陆区域以及非中国大陆区域，各个区域的集群独立维护各自的探测结果；<br>mainland_china：仅由中国大陆区域的探测集群发起探测，当前中国大陆区域共用一个探测集群，探测结果由中国大陆区域的探测集群维护，其他区域跟随中国大陆区域的集群的探测结果；<br>overseas：仅由非中国大陆区域的探测集群发起探测，当前非中国大陆区域包含多个地区的探测集群，探测结果由各个地区的探测集群独立维护，中国大陆区域的探测结果由所有其他地区的探测集群的探测结果汇总生成。<br>默认为 global。</p>
        /// </summary>
        [JsonProperty("ProbeCluster")]
        public string ProbeCluster{ get; set; }


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
            this.SetParamSimple(map, prefix + "ProbeCluster", this.ProbeCluster);
        }
    }
}

