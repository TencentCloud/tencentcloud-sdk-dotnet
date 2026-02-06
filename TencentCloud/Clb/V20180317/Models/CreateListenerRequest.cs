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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateListenerRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>负载均衡实例 ID，可以通过 <a href="https://cloud.tencent.com/document/product/214/30685">DescribeLoadBalancers</a> 接口获取。</p>
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// <p>要将监听器创建到哪些端口，每个端口对应一个新的监听器。<br>端口范围：1~65535</p>
        /// </summary>
        [JsonProperty("Ports")]
        public long?[] Ports{ get; set; }

        /// <summary>
        /// <p>监听器协议： TCP | UDP | HTTP | HTTPS | TCP_SSL | QUIC。</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>要创建的监听器名称列表，名称与Ports数组按序一一对应，如不需立即命名，则无需提供此参数。命名规则：1-80 个英文字母、汉字等国际通用语言字符，数字，连接线“-”、下划线“_”等常见字符（禁止Unicode补充字符，如emoji表情、生僻汉字等）。</p>
        /// </summary>
        [JsonProperty("ListenerNames")]
        public string[] ListenerNames{ get; set; }

        /// <summary>
        /// <p>健康检查相关参数，此参数仅适用于TCP/UDP/TCP_SSL/QUIC监听器。</p>
        /// </summary>
        [JsonProperty("HealthCheck")]
        public HealthCheck HealthCheck{ get; set; }

        /// <summary>
        /// <p>证书相关信息。参数限制如下：</p><li>此参数仅适用于TCP_SSL监听器和未开启SNI特性的HTTPS监听器。</li><li>创建TCP_SSL监听器和未开启SNI特性的HTTPS监听器时，此参数和参数MultiCertInfo至少需要传一个， 但不能同时传入。</li>
        /// </summary>
        [JsonProperty("Certificate")]
        public CertificateInput Certificate{ get; set; }

        /// <summary>
        /// <p>会话保持时间，单位：秒。可选值：30~3600，默认为0，默认不开启。此参数仅适用于TCP/UDP监听器。</p>
        /// </summary>
        [JsonProperty("SessionExpireTime")]
        public long? SessionExpireTime{ get; set; }

        /// <summary>
        /// <p>监听器转发的方式。可选值：WRR（按权重轮询）、LEAST_CONN（按最小连接数）<br>默认为 WRR。此参数仅适用于TCP/UDP/TCP_SSL/QUIC监听器。</p>
        /// </summary>
        [JsonProperty("Scheduler")]
        public string Scheduler{ get; set; }

        /// <summary>
        /// <p>是否开启SNI特性，此参数仅适用于HTTPS监听器。0表示未开启，1表示开启。</p>
        /// </summary>
        [JsonProperty("SniSwitch")]
        public long? SniSwitch{ get; set; }

        /// <summary>
        /// <p>后端目标类型，NODE表示绑定普通节点，TARGETGROUP表示绑定目标组。此参数仅适用于TCP/UDP监听器。七层监听器应在转发规则中设置。</p>
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// <p>会话保持类型。不传或传NORMAL表示默认会话保持类型。QUIC_CID 表示根据Quic Connection ID做会话保持。QUIC_CID只支持UDP协议。此参数仅适用于TCP/UDP监听器。七层监听器应在转发规则中设置。（若选择QUIC_CID，则Protocol必须为UDP，Scheduler必须为WRR，同时只支持ipv4）</p>
        /// </summary>
        [JsonProperty("SessionType")]
        public string SessionType{ get; set; }

        /// <summary>
        /// <p>是否开启长连接，此参数仅适用于HTTP/HTTPS监听器，0:关闭；1:开启， 默认关闭。<br>若后端服务对连接数上限有限制，则建议谨慎开启。此功能目前处于内测中，如需使用，请提交 <a href="https://cloud.tencent.com/apply/p/tsodp6qm21">内测申请</a>。</p>
        /// </summary>
        [JsonProperty("KeepaliveEnable")]
        public long? KeepaliveEnable{ get; set; }

        /// <summary>
        /// <p>创建端口段监听器时必须传入此参数，用以标识结束端口。同时，入参Ports只允许传入一个成员，用以标识开始端口。【如果您需要体验端口段功能，请通过 <a href="https://console.cloud.tencent.com/workorder/category">工单申请</a>】。</p>
        /// </summary>
        [JsonProperty("EndPort")]
        public ulong? EndPort{ get; set; }

        /// <summary>
        /// <p>重新调度功能，解绑后端服务开关，打开此开关，当解绑后端服务时触发重新调度。仅TCP/UDP监听器支持。</p>
        /// </summary>
        [JsonProperty("DeregisterTargetRst")]
        public bool? DeregisterTargetRst{ get; set; }

        /// <summary>
        /// <p>证书信息，支持同时传入不同算法类型的多本服务端证书，参数限制如下：</p><li>此参数仅适用于TCP_SSL监听器和未开启SNI特性的HTTPS监听器。</li><li>创建TCP_SSL监听器和未开启SNI特性的HTTPS监听器时，此参数和参数Certificate至少需要传一个， 但不能同时传入。</li>
        /// </summary>
        [JsonProperty("MultiCertInfo")]
        public MultiCertInfo MultiCertInfo{ get; set; }

        /// <summary>
        /// <p>监听器最大连接数，当前仅性能容量型实例且仅TCP/UDP/TCP_SSL/QUIC监听器支持，不传或者传-1表示监听器维度不限速。基础网络实例不支持该参数。</p>
        /// </summary>
        [JsonProperty("MaxConn")]
        public long? MaxConn{ get; set; }

        /// <summary>
        /// <p>监听器最大新增连接数，当前仅性能容量型实例且仅TCP/UDP/TCP_SSL/QUIC监听器支持，不传或者传-1表示监听器维度不限速。基础网络实例不支持该参数。</p>
        /// </summary>
        [JsonProperty("MaxCps")]
        public long? MaxCps{ get; set; }

        /// <summary>
        /// <p>空闲连接超时时间，此参数仅适用于TCP/UDP监听器，单位：秒。默认值：TCP监听器默认值为900s，UDP监听器默认值为300s。取值范围：共享型实例和独占型实例支持：10-900，性能容量型实例支持：10-1980。如需设置超过取值范围的值请通过 <a href="https://console.cloud.tencent.com/workorder/category">工单申请</a>。</p><p>取值范围：[10, 1980]</p><p>单位：秒</p><p>默认值：900</p><p>TCP监听器默认值为900s，UDP监听器默认值为300s。取值范围：共享型实例和独占型实例支持：10-900，性能容量型实例支持：10-1980。</p>
        /// </summary>
        [JsonProperty("IdleConnectTimeout")]
        public long? IdleConnectTimeout{ get; set; }

        /// <summary>
        /// <p>TCP_SSL和QUIC是否支持PP</p>
        /// </summary>
        [JsonProperty("ProxyProtocol")]
        public bool? ProxyProtocol{ get; set; }

        /// <summary>
        /// <p>是否开启SNAT（源IP替换），True（开启）、False（关闭）。默认为关闭。注意：SnatEnable开启时会替换客户端源IP，此时<code>透传客户端源IP</code>选项关闭，反之亦然。</p>
        /// </summary>
        [JsonProperty("SnatEnable")]
        public bool? SnatEnable{ get; set; }

        /// <summary>
        /// <p>全端口段监听器的结束端口，端口范围：2 - 65535</p>
        /// </summary>
        [JsonProperty("FullEndPorts")]
        public long?[] FullEndPorts{ get; set; }

        /// <summary>
        /// <p>内网http监听器开启h2c开关，True（开启）、False（关闭）。<br>默认为关闭。</p>
        /// </summary>
        [JsonProperty("H2cSwitch")]
        public bool? H2cSwitch{ get; set; }

        /// <summary>
        /// <p>控制 TCP_SSL 类型的监听器是否移除 SSL 加密层。开启后，监听器将作为普通 TCP 协议运行。 可选值：</p><ul><li>True： 关闭 SSL 功能（协议降级为纯文本 TCP）。</li><li>False（默认）： 保持 SSL 功能开启。</li></ul>
        /// </summary>
        [JsonProperty("SslCloseSwitch")]
        public bool? SslCloseSwitch{ get; set; }

        /// <summary>
        /// <p>数据压缩模式。可选值：transparent（透传模式）、compatibility（兼容模式）</p>
        /// </summary>
        [JsonProperty("DataCompressMode")]
        public string DataCompressMode{ get; set; }

        /// <summary>
        /// <p>重新调度功能，权重调为0开关，打开此开关，后端服务器权重调为0时触发重新调度。仅TCP/UDP监听器支持。</p>
        /// </summary>
        [JsonProperty("RescheduleTargetZeroWeight")]
        public bool? RescheduleTargetZeroWeight{ get; set; }

        /// <summary>
        /// <p>重新调度功能，健康检查异常开关，打开此开关，后端服务器健康检查异常时触发重新调度。仅TCP/UDP监听器支持。</p>
        /// </summary>
        [JsonProperty("RescheduleUnhealthy")]
        public bool? RescheduleUnhealthy{ get; set; }

        /// <summary>
        /// <p>重新调度功能，扩容后端服务开关，打开此开关，后端服务器增加或者减少时触发重新调度。仅TCP/UDP监听器支持。</p>
        /// </summary>
        [JsonProperty("RescheduleExpandTarget")]
        public bool? RescheduleExpandTarget{ get; set; }

        /// <summary>
        /// <p>重新调度触发开始时间，取值0~3600s。仅TCP/UDP监听器支持。</p>
        /// </summary>
        [JsonProperty("RescheduleStartTime")]
        public long? RescheduleStartTime{ get; set; }

        /// <summary>
        /// <p>重新调度触发持续时间，取值0~3600s。仅TCP/UDP监听器支持。</p>
        /// </summary>
        [JsonProperty("RescheduleInterval")]
        public long? RescheduleInterval{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamArraySimple(map, prefix + "Ports.", this.Ports);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamArraySimple(map, prefix + "ListenerNames.", this.ListenerNames);
            this.SetParamObj(map, prefix + "HealthCheck.", this.HealthCheck);
            this.SetParamObj(map, prefix + "Certificate.", this.Certificate);
            this.SetParamSimple(map, prefix + "SessionExpireTime", this.SessionExpireTime);
            this.SetParamSimple(map, prefix + "Scheduler", this.Scheduler);
            this.SetParamSimple(map, prefix + "SniSwitch", this.SniSwitch);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "SessionType", this.SessionType);
            this.SetParamSimple(map, prefix + "KeepaliveEnable", this.KeepaliveEnable);
            this.SetParamSimple(map, prefix + "EndPort", this.EndPort);
            this.SetParamSimple(map, prefix + "DeregisterTargetRst", this.DeregisterTargetRst);
            this.SetParamObj(map, prefix + "MultiCertInfo.", this.MultiCertInfo);
            this.SetParamSimple(map, prefix + "MaxConn", this.MaxConn);
            this.SetParamSimple(map, prefix + "MaxCps", this.MaxCps);
            this.SetParamSimple(map, prefix + "IdleConnectTimeout", this.IdleConnectTimeout);
            this.SetParamSimple(map, prefix + "ProxyProtocol", this.ProxyProtocol);
            this.SetParamSimple(map, prefix + "SnatEnable", this.SnatEnable);
            this.SetParamArraySimple(map, prefix + "FullEndPorts.", this.FullEndPorts);
            this.SetParamSimple(map, prefix + "H2cSwitch", this.H2cSwitch);
            this.SetParamSimple(map, prefix + "SslCloseSwitch", this.SslCloseSwitch);
            this.SetParamSimple(map, prefix + "DataCompressMode", this.DataCompressMode);
            this.SetParamSimple(map, prefix + "RescheduleTargetZeroWeight", this.RescheduleTargetZeroWeight);
            this.SetParamSimple(map, prefix + "RescheduleUnhealthy", this.RescheduleUnhealthy);
            this.SetParamSimple(map, prefix + "RescheduleExpandTarget", this.RescheduleExpandTarget);
            this.SetParamSimple(map, prefix + "RescheduleStartTime", this.RescheduleStartTime);
            this.SetParamSimple(map, prefix + "RescheduleInterval", this.RescheduleInterval);
        }
    }
}

