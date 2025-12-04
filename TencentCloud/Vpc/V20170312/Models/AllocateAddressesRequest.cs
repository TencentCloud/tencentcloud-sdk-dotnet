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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AllocateAddressesRequest : AbstractModel
    {
        
        /// <summary>
        /// EIP数量。可申请的数量限制参考：[EIP 配额限制](https://cloud.tencent.com/document/product/1199/41648)。默认值：1。
        /// </summary>
        [JsonProperty("AddressCount")]
        public long? AddressCount{ get; set; }

        /// <summary>
        /// EIP线路类型。各种线路类型详情可参考：[EIP 的 IP 地址类型](https://cloud.tencent.com/document/product/1199/41646)。默认值：BGP。
        /// <ul style="margin:0"><li>BGP：常规 BGP 线路</li>
        /// <li>已开通静态单线IP白名单的用户，可选值：<ul><li>CMCC：中国移动</li>
        /// <li>CTCC：中国电信</li>
        /// <li>CUCC：中国联通</li></ul></li>注意：仅部分地域支持静态单线IP。</ul>
        /// </summary>
        [JsonProperty("InternetServiceProvider")]
        public string InternetServiceProvider{ get; set; }

        /// <summary>
        /// EIP计费方式。
        /// <ul style="margin:0"><li>标准账户类型，可选值：<ul><li>BANDWIDTH_PACKAGE：[共享带宽包](https://cloud.tencent.com/document/product/684/15255)付费</li>
        /// <li>BANDWIDTH_POSTPAID_BY_HOUR：带宽按小时后付费</li>
        /// <li>BANDWIDTH_PREPAID_BY_MONTH：包月按带宽预付费</li>
        /// <li>TRAFFIC_POSTPAID_BY_HOUR：流量按小时后付费</li></ul>默认值：TRAFFIC_POSTPAID_BY_HOUR。</li>
        /// <li>传统账户类型，无需传递此参数，EIP计费方式与其绑定的实例的计费方式一致，无需传递此参数。</li></ul>
        /// </summary>
        [JsonProperty("InternetChargeType")]
        public string InternetChargeType{ get; set; }

        /// <summary>
        /// IP 资源计费模式，当前仅支持原生 IP。
        /// <ul style="margin:0"><li>账号为标准账户类型的用户，可选值：<ul><li>IP_POSTPAID_BY_HOUR：IP资源按小时后付费</li><li>IP_PREPAID_BY_MONTH：IP资源包月预付费</li></ul></li></ul>
        /// </summary>
        [JsonProperty("IPChargeType")]
        public string IPChargeType{ get; set; }

        /// <summary>
        /// EIP出带宽上限，单位：Mbps。
        /// <ul style="margin:0"><li>标准账户类型EIP出带宽上限，可选值范围取决于EIP计费方式：<ul><li>BANDWIDTH_PACKAGE：1 Mbps 至 2000 Mbps</li>
        /// <li>BANDWIDTH_POSTPAID_BY_HOUR：1 Mbps 至 100 Mbps</li>
        /// <li>BANDWIDTH_PREPAID_BY_MONTH：1 Mbps 至 200 Mbps</li>
        /// <li>TRAFFIC_POSTPAID_BY_HOUR：1 Mbps 至 100 Mbps</li></ul>默认值：1 Mbps。</li>
        /// <li>传统账户类型无需传递此参数，EIP出带宽上限取决于与其绑定的实例的公网出带宽上限，无需传递此参数。</li></ul>
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public long? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// 包月按带宽预付费EIP的计费参数。EIP为包月按带宽预付费时，该参数必传，其余场景不需传递
        /// </summary>
        [JsonProperty("AddressChargePrepaid")]
        public AddressChargePrepaid AddressChargePrepaid{ get; set; }

        /// <summary>
        /// EIP类型。各种EIP类型详情可参考：[EIP 的 IP 地址类型](https://cloud.tencent.com/document/product/1199/41646)。默认值：EIP。
        /// <li>EIP：弹性公网 IP。 </li>
        /// <li>AnycastEIP：加速 IP，已开通 [Anycast 公网加速](https://cloud.tencent.com/document/product/644)白名单的用户可选。仅部分地域支持加速IP，详情可见Anycast公网加速[购买指南](https://cloud.tencent.com/document/product/644/12617)。</li>
        /// <li>HighQualityEIP：精品 IP。仅新加坡和中国香港支持精品IP。</li>
        /// <li>AntiDDoSEIP：高防 IP。仅部分地域支持高防IP。</li>
        /// <li>ResidentialEIP：原生 IP。仅部分地域支持原生IP。</li>
        /// 关于弹性公网 IP 支持的 IP 类型，请见[产品概述](https://cloud.tencent.com/document/product/1199/41646)。
        /// </summary>
        [JsonProperty("AddressType")]
        public string AddressType{ get; set; }

        /// <summary>
        /// Anycast发布域。
        /// <ul style="margin:0"><li>已开通Anycast公网加速白名单的用户，可选值：<ul><li>ANYCAST_ZONE_GLOBAL：全球发布域（需要额外开通Anycast全球加速白名单）</li><li>ANYCAST_ZONE_OVERSEAS：境外发布域</li></ul>默认值：ANYCAST_ZONE_OVERSEAS。</li></ul>
        /// </summary>
        [JsonProperty("AnycastZone")]
        public string AnycastZone{ get; set; }

        /// <summary>
        /// 指定IP地址申请EIP，每个账户每个月只有三次配额
        /// </summary>
        [JsonProperty("VipCluster")]
        public string[] VipCluster{ get; set; }

        /// <summary>
        /// <b>[已废弃]</b> AnycastEIP不再区分是否负载均衡。原参数说明如下：
        /// AnycastEIP是否用于绑定负载均衡。
        /// <ul style="margin:0"><li>已开通Anycast公网加速白名单的用户，可选值：<ul><li>TRUE：AnycastEIP可绑定对象为负载均衡</li>
        /// <li>FALSE：AnycastEIP可绑定对象为云服务器、NAT网关、高可用虚拟IP等</li></ul>默认值：FALSE。</li></ul>
        /// </summary>
        [JsonProperty("ApplicableForCLB")]
        [System.Obsolete]
        public bool? ApplicableForCLB{ get; set; }

        /// <summary>
        /// 需要关联的标签列表。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// BGP带宽包唯一ID参数。设定该参数且InternetChargeType为BANDWIDTH_PACKAGE，则表示创建的EIP加入该BGP带宽包并采用带宽包计费
        /// </summary>
        [JsonProperty("BandwidthPackageId")]
        public string BandwidthPackageId{ get; set; }

        /// <summary>
        /// EIP名称，用于申请EIP时用户自定义该EIP的个性化名称，默认值：未命名
        /// </summary>
        [JsonProperty("AddressName")]
        public string AddressName{ get; set; }

        /// <summary>
        /// CDC唯一ID
        /// </summary>
        [JsonProperty("DedicatedClusterId")]
        public string DedicatedClusterId{ get; set; }

        /// <summary>
        /// 是否使用独占资源池，默认值：True
        /// - True：表示使用独占资源池
        /// - False：表示使用共享资源池
        /// 
        /// 说明：如需使用独占资源池，请 提交工单(https://console.cloud.tencent.com/workorder/category) 咨询，具体费用请咨询商务经理。
        /// </summary>
        [JsonProperty("IsDedicatedAddressPool")]
        public bool? IsDedicatedAddressPool{ get; set; }

        /// <summary>
        /// 网络出口，当前仅支持精品BGP、静态单线，这2种IP 地址类型的指定出口传入，默认值：center_egress1，其它可选值：center_egress2、center_egress3
        /// </summary>
        [JsonProperty("Egress")]
        public string Egress{ get; set; }

        /// <summary>
        /// 高防包ID， 申请高防IP时，该字段必传。
        /// </summary>
        [JsonProperty("AntiDDoSPackageId")]
        public string AntiDDoSPackageId{ get; set; }

        /// <summary>
        /// 保证请求幂等性。从您的客户端生成一个参数值，确保不同请求间该参数值唯一。ClientToken只支持ASCII字符，且不能超过64个字符。
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AddressCount", this.AddressCount);
            this.SetParamSimple(map, prefix + "InternetServiceProvider", this.InternetServiceProvider);
            this.SetParamSimple(map, prefix + "InternetChargeType", this.InternetChargeType);
            this.SetParamSimple(map, prefix + "IPChargeType", this.IPChargeType);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamObj(map, prefix + "AddressChargePrepaid.", this.AddressChargePrepaid);
            this.SetParamSimple(map, prefix + "AddressType", this.AddressType);
            this.SetParamSimple(map, prefix + "AnycastZone", this.AnycastZone);
            this.SetParamArraySimple(map, prefix + "VipCluster.", this.VipCluster);
            this.SetParamSimple(map, prefix + "ApplicableForCLB", this.ApplicableForCLB);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "BandwidthPackageId", this.BandwidthPackageId);
            this.SetParamSimple(map, prefix + "AddressName", this.AddressName);
            this.SetParamSimple(map, prefix + "DedicatedClusterId", this.DedicatedClusterId);
            this.SetParamSimple(map, prefix + "IsDedicatedAddressPool", this.IsDedicatedAddressPool);
            this.SetParamSimple(map, prefix + "Egress", this.Egress);
            this.SetParamSimple(map, prefix + "AntiDDoSPackageId", this.AntiDDoSPackageId);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
        }
    }
}

