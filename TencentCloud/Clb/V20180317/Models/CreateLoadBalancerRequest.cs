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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateLoadBalancerRequest : AbstractModel
    {
        
        /// <summary>
        /// 负载均衡实例的网络类型：
        /// OPEN：公网属性， INTERNAL：内网属性。
        /// </summary>
        [JsonProperty("LoadBalancerType")]
        public string LoadBalancerType{ get; set; }

        /// <summary>
        /// 负载均衡实例的类型。1：通用的负载均衡实例，目前只支持传入1。
        /// </summary>
        [JsonProperty("Forward")]
        public long? Forward{ get; set; }

        /// <summary>
        /// 负载均衡实例的名称，只在创建一个实例的时候才会生效。规则：1-60 个英文、汉字、数字、连接线“-”或下划线“_”。
        /// 注意：如果名称与系统中已有负载均衡实例的名称相同，则系统将会自动生成此次创建的负载均衡实例的名称。
        /// </summary>
        [JsonProperty("LoadBalancerName")]
        public string LoadBalancerName{ get; set; }

        /// <summary>
        /// 负载均衡后端目标设备所属的网络 ID，如vpc-12345678，可以通过 [DescribeVpcEx](https://cloud.tencent.com/document/product/215/1372) 接口获取。 不填此参数则默认为DefaultVPC。创建内网负载均衡实例时，此参数必填。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 在私有网络内购买内网负载均衡实例的情况下，必须指定子网 ID，内网负载均衡实例的 VIP 将从这个子网中产生。创建内网负载均衡实例时，此参数必填。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 负载均衡实例所属的项目 ID，可以通过 [DescribeProject](https://cloud.tencent.com/document/api/651/78725) 接口获取。不填此参数则视为默认项目。
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 仅适用于公网负载均衡。IP版本，可取值：IPV4、IPV6、IPv6FullChain，不区分大小写，默认值 IPV4。说明：取值为IPV6表示为IPV6 NAT64版本；取值为IPv6FullChain，表示为IPv6版本。
        /// </summary>
        [JsonProperty("AddressIPVersion")]
        public string AddressIPVersion{ get; set; }

        /// <summary>
        /// 创建负载均衡的个数，默认值 1。
        /// </summary>
        [JsonProperty("Number")]
        public ulong? Number{ get; set; }

        /// <summary>
        /// 仅适用于公网负载均衡。设置跨可用区容灾时的主可用区ID，例如 100001 或 ap-guangzhou-1
        /// 注：主可用区是需要承载流量的可用区，备可用区默认不承载流量，主可用区不可用时才使用备可用区。目前仅广州、上海、南京、北京、成都、深圳金融、中国香港、首尔、法兰克福、新加坡地域的 IPv4 版本的 CLB 支持主备可用区。可通过 [DescribeResources](https://cloud.tencent.com/document/api/214/70213) 接口查询一个地域的主可用区的列表。
        /// </summary>
        [JsonProperty("MasterZoneId")]
        public string MasterZoneId{ get; set; }

        /// <summary>
        /// 仅适用于公网负载均衡。可用区ID，指定可用区以创建负载均衡实例。如：ap-guangzhou-1。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 网络计费模式，最大出带宽。仅对内网属性的性能容量型实例和公网属性的所有实例生效。
        /// </summary>
        [JsonProperty("InternetAccessible")]
        public InternetAccessible InternetAccessible{ get; set; }

        /// <summary>
        /// 仅适用于公网负载均衡。目前仅广州、上海、南京、济南、杭州、福州、北京、石家庄、武汉、长沙、成都、重庆地域支持静态单线 IP 线路类型，如需体验，请联系商务经理申请。申请通过后，即可选择中国移动（CMCC）、中国联通（CUCC）或中国电信（CTCC）的运营商类型，网络计费模式只能使用按带宽包计费(BANDWIDTH_PACKAGE)。 如果不指定本参数，则默认使用BGP。可通过 [DescribeResources](https://cloud.tencent.com/document/api/214/70213)  接口查询一个地域所支持的Isp。
        /// </summary>
        [JsonProperty("VipIsp")]
        public string VipIsp{ get; set; }

        /// <summary>
        /// 购买负载均衡的同时，给负载均衡打上标签，最大支持20个标签键值对。
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// 指定VIP申请负载均衡。此参数选填，不填写此参数时自动分配VIP。IPv4和IPv6类型支持此参数，IPv6 NAT64类型不支持。
        /// 注意：当指定VIP创建内网实例、或公网IPv6 BGP实例时，若VIP不属于指定VPC子网的网段内时，会创建失败；若VIP已被占用，也会创建失败。
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// 带宽包ID，指定此参数时，网络计费方式（InternetAccessible.InternetChargeType）只支持按带宽包计费（BANDWIDTH_PACKAGE），带宽包的属性即为其结算方式。非上移用户购买的 IPv6 负载均衡实例，且运营商类型非 BGP 时 ，不支持指定具体带宽包id。
        /// </summary>
        [JsonProperty("BandwidthPackageId")]
        public string BandwidthPackageId{ get; set; }

        /// <summary>
        /// 独占型实例信息。若创建独占型的内网负载均衡实例，则此参数必填。
        /// </summary>
        [JsonProperty("ExclusiveCluster")]
        public ExclusiveCluster ExclusiveCluster{ get; set; }

        /// <summary>
        /// 性能容量型规格。
        /// <ul><li>若需要创建性能容量型实例，则此参数必填，取值范围：<ul><li> clb.c2.medium：标准型规格 </li><li> clb.c3.small：高阶型1规格 </li><li> clb.c3.medium：高阶型2规格 </li><li> clb.c4.small：超强型1规格 </li><li> clb.c4.medium：超强型2规格 </li><li> clb.c4.large：超强型3规格 </li><li> clb.c4.xlarge：超强型4规格 </li></ul></li><li>若需要创建共享型实例，则无需填写此参数。</li></ul>如需了解规格详情，请参见[实例规格对比](https://cloud.tencent.com/document/product/214/84689)。
        /// </summary>
        [JsonProperty("SlaType")]
        public string SlaType{ get; set; }

        /// <summary>
        /// 集群ID，集群标识，在需要配置公有云独占集群或本地专有集群时使用。公有云独占集群申请请[提交工单](https://console.cloud.tencent.com/workorder/category)，本地专有集群请参考[本地专有集群](https://cloud.tencent.com/document/product/1346)描述。
        /// </summary>
        [JsonProperty("ClusterIds")]
        public string[] ClusterIds{ get; set; }

        /// <summary>
        /// 用于保证请求幂等性的字符串。该字符串由客户生成，需保证不同请求之间唯一，最大值不超过64个ASCII字符。若不指定该参数，则无法保证请求的幂等性。
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// 是否支持绑定跨地域/跨Vpc绑定IP的功能。
        /// </summary>
        [JsonProperty("SnatPro")]
        public bool? SnatPro{ get; set; }

        /// <summary>
        /// 开启绑定跨地域/跨Vpc绑定IP的功能后，创建SnatIp。
        /// </summary>
        [JsonProperty("SnatIps")]
        public SnatIp[] SnatIps{ get; set; }

        /// <summary>
        /// Stgw独占集群的标签。
        /// </summary>
        [JsonProperty("ClusterTag")]
        public string ClusterTag{ get; set; }

        /// <summary>
        /// 仅适用于公网负载均衡。设置跨可用区容灾时的备可用区ID，例如 100001 或 ap-guangzhou-1
        /// 注：备可用区是主可用区故障后，需要承载流量的可用区。可通过 [DescribeResources](https://cloud.tencent.com/document/api/214/70213) 接口查询一个地域的主/备可用区的列表。
        /// </summary>
        [JsonProperty("SlaveZoneId")]
        public string SlaveZoneId{ get; set; }

        /// <summary>
        /// EIP 的唯一 ID，形如：eip-11112222，仅适用于内网负载均衡绑定EIP。
        /// </summary>
        [JsonProperty("EipAddressId")]
        public string EipAddressId{ get; set; }

        /// <summary>
        /// Target是否放通来自CLB的流量。开启放通（true）：只验证CLB上的安全组；不开启放通（false）：需同时验证CLB和后端实例上的安全组。
        /// </summary>
        [JsonProperty("LoadBalancerPassToTarget")]
        public bool? LoadBalancerPassToTarget{ get; set; }

        /// <summary>
        /// 创建域名化负载均衡。
        /// </summary>
        [JsonProperty("DynamicVip")]
        public bool? DynamicVip{ get; set; }

        /// <summary>
        /// 网络出口
        /// </summary>
        [JsonProperty("Egress")]
        public string Egress{ get; set; }

        /// <summary>
        /// 负载均衡实例的预付费相关属性
        /// </summary>
        [JsonProperty("LBChargePrepaid")]
        public LBChargePrepaid LBChargePrepaid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerType", this.LoadBalancerType);
            this.SetParamSimple(map, prefix + "Forward", this.Forward);
            this.SetParamSimple(map, prefix + "LoadBalancerName", this.LoadBalancerName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "AddressIPVersion", this.AddressIPVersion);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "MasterZoneId", this.MasterZoneId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamObj(map, prefix + "InternetAccessible.", this.InternetAccessible);
            this.SetParamSimple(map, prefix + "VipIsp", this.VipIsp);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "BandwidthPackageId", this.BandwidthPackageId);
            this.SetParamObj(map, prefix + "ExclusiveCluster.", this.ExclusiveCluster);
            this.SetParamSimple(map, prefix + "SlaType", this.SlaType);
            this.SetParamArraySimple(map, prefix + "ClusterIds.", this.ClusterIds);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamSimple(map, prefix + "SnatPro", this.SnatPro);
            this.SetParamArrayObj(map, prefix + "SnatIps.", this.SnatIps);
            this.SetParamSimple(map, prefix + "ClusterTag", this.ClusterTag);
            this.SetParamSimple(map, prefix + "SlaveZoneId", this.SlaveZoneId);
            this.SetParamSimple(map, prefix + "EipAddressId", this.EipAddressId);
            this.SetParamSimple(map, prefix + "LoadBalancerPassToTarget", this.LoadBalancerPassToTarget);
            this.SetParamSimple(map, prefix + "DynamicVip", this.DynamicVip);
            this.SetParamSimple(map, prefix + "Egress", this.Egress);
            this.SetParamObj(map, prefix + "LBChargePrepaid.", this.LBChargePrepaid);
        }
    }
}

