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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AllocateAddressesRequest : AbstractModel
    {
        
        /// <summary>
        /// EIP数量。默认值：1。
        /// </summary>
        [JsonProperty("AddressCount")]
        public long? AddressCount{ get; set; }

        /// <summary>
        /// EIP线路类型。默认值：BGP。
        /// <ul style="margin:0"><li>已开通静态单线IP白名单的用户，可选值：<ul><li>CMCC：中国移动</li>
        /// <li>CTCC：中国电信</li>
        /// <li>CUCC：中国联通</li></ul>注意：仅部分地域支持静态单线IP。</li></ul>
        /// </summary>
        [JsonProperty("InternetServiceProvider")]
        public string InternetServiceProvider{ get; set; }

        /// <summary>
        /// EIP计费方式。
        /// <ul style="margin:0"><li>已开通带宽上移白名单的用户，可选值：<ul><li>BANDWIDTH_PACKAGE：[共享带宽包](https://cloud.tencent.com/document/product/684/15255)付费（需额外开通共享带宽包白名单）</li>
        /// <li>BANDWIDTH_POSTPAID_BY_HOUR：带宽按小时后付费</li>
        /// <li>TRAFFIC_POSTPAID_BY_HOUR：流量按小时后付费</li></ul>默认值：TRAFFIC_POSTPAID_BY_HOUR。</li>
        /// <li>未开通带宽上移白名单的用户，EIP计费方式与其绑定的实例的计费方式一致，无需传递此参数。</li></ul>
        /// </summary>
        [JsonProperty("InternetChargeType")]
        public string InternetChargeType{ get; set; }

        /// <summary>
        /// EIP出带宽上限，单位：Mbps。
        /// <ul style="margin:0"><li>已开通带宽上移白名单的用户，可选值范围取决于EIP计费方式：<ul><li>BANDWIDTH_PACKAGE：1 Mbps 至 1000 Mbps</li>
        /// <li>BANDWIDTH_POSTPAID_BY_HOUR：1 Mbps 至 100 Mbps</li>
        /// <li>TRAFFIC_POSTPAID_BY_HOUR：1 Mbps 至 100 Mbps</li></ul>默认值：1 Mbps。</li>
        /// <li>未开通带宽上移白名单的用户，EIP出带宽上限取决于与其绑定的实例的公网出带宽上限，无需传递此参数。</li></ul>
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public long? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// EIP类型。默认值：EIP。
        /// <ul style="margin:0"><li>已开通Anycast公网加速白名单的用户，可选值：<ul><li>AnycastEIP：加速IP，可参见 [Anycast 公网加速](https://cloud.tencent.com/document/product/644)</li></ul>注意：仅部分地域支持加速IP。</li></ul>
        /// </summary>
        [JsonProperty("AddressType")]
        public string AddressType{ get; set; }

        /// <summary>
        /// Anycast发布域。
        /// <ul style="margin:0"><li>已开通Anycast公网加速白名单的用户，可选值：<ul><li>ANYCAST_ZONE_GLOBAL：全球发布域（需要额外开通Anycast全球加速白名单）</li><li>ANYCAST_ZONE_OVERSEAS：境外发布域</li><li><b>[已废弃]</b> ANYCAST_ZONE_A：发布域A（已更新为全球发布域）</li><li><b>[已废弃]</b> ANYCAST_ZONE_B：发布域B（已更新为全球发布域）</li></ul>默认值：ANYCAST_ZONE_OVERSEAS。</li></ul>
        /// </summary>
        [JsonProperty("AnycastZone")]
        public string AnycastZone{ get; set; }

        /// <summary>
        /// <b>[已废弃]</b> AnycastEIP不再区分是否负载均衡。原参数说明如下：
        /// AnycastEIP是否用于绑定负载均衡。
        /// <ul style="margin:0"><li>已开通Anycast公网加速白名单的用户，可选值：<ul><li>TRUE：AnycastEIP可绑定对象为负载均衡</li>
        /// <li>FALSE：AnycastEIP可绑定对象为云服务器、NAT网关、高可用虚拟IP等</li></ul>默认值：FALSE。</li></ul>
        /// </summary>
        [JsonProperty("ApplicableForCLB")]
        public bool? ApplicableForCLB{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AddressCount", this.AddressCount);
            this.SetParamSimple(map, prefix + "InternetServiceProvider", this.InternetServiceProvider);
            this.SetParamSimple(map, prefix + "InternetChargeType", this.InternetChargeType);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "AddressType", this.AddressType);
            this.SetParamSimple(map, prefix + "AnycastZone", this.AnycastZone);
            this.SetParamSimple(map, prefix + "ApplicableForCLB", this.ApplicableForCLB);
        }
    }
}

