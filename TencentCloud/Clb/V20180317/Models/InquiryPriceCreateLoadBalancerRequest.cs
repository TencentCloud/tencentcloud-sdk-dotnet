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

    public class InquiryPriceCreateLoadBalancerRequest : AbstractModel
    {
        
        /// <summary>
        /// 询价的负载均衡类型，OPEN为公网类型，INTERNAL为内网类型
        /// </summary>
        [JsonProperty("LoadBalancerType")]
        public string LoadBalancerType{ get; set; }

        /// <summary>
        /// 询价的收费类型，POSTPAID为按量计费，"PREPAID"为预付费包年包月
        /// </summary>
        [JsonProperty("LoadBalancerChargeType")]
        public string LoadBalancerChargeType{ get; set; }

        /// <summary>
        /// 询价的收费周期。（仅包年包月支持该参数）
        /// </summary>
        [JsonProperty("LoadBalancerChargePrepaid")]
        public LBChargePrepaid LoadBalancerChargePrepaid{ get; set; }

        /// <summary>
        /// 询价的网络计费方式
        /// </summary>
        [JsonProperty("InternetAccessible")]
        public InternetAccessible InternetAccessible{ get; set; }

        /// <summary>
        /// 询价的负载均衡实例个数，默认为1
        /// </summary>
        [JsonProperty("GoodsNum")]
        public ulong? GoodsNum{ get; set; }

        /// <summary>
        /// 指定可用区询价。如：ap-guangzhou-1
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 包年包月询价时传性能容量型规格，如：<li>clb.c2.medium（标准型）</li><li>clb.c3.small（高阶型1）</li><li>clb.c3.medium（高阶型2）</li>
        /// <li>clb.c4.small（超强型1）</li><li>clb.c4.medium（超强型2）</li><li>clb.c4.large（超强型3）</li><li>clb.c4.xlarge（超强型4）</li>
        /// 按量付费询价时传SLA
        /// </summary>
        [JsonProperty("SlaType")]
        public string SlaType{ get; set; }

        /// <summary>
        /// IP版本，可取值：IPV4、IPV6、IPv6FullChain，不区分大小写，默认值 IPV4。说明：取值为IPV6表示为IPV6 NAT64版本；取值为IPv6FullChain，表示为IPv6版本。
        /// </summary>
        [JsonProperty("AddressIPVersion")]
        public string AddressIPVersion{ get; set; }

        /// <summary>
        /// 仅适用于公网负载均衡。目前仅广州、上海、南京、济南、杭州、福州、北京、石家庄、武汉、长沙、成都、重庆地域支持静态单线 IP 线路类型，如需体验，请联系商务经理申请。申请通过后，即可选择中国移动（CMCC）、中国联通（CUCC）或中国电信（CTCC）的运营商类型，网络计费模式只能使用按带宽包计费(BANDWIDTH_PACKAGE)。 如果不指定本参数，则默认使用BGP。可通过 DescribeResources 接口查询一个地域所支持的Isp。
        /// </summary>
        [JsonProperty("VipIsp")]
        public string VipIsp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerType", this.LoadBalancerType);
            this.SetParamSimple(map, prefix + "LoadBalancerChargeType", this.LoadBalancerChargeType);
            this.SetParamObj(map, prefix + "LoadBalancerChargePrepaid.", this.LoadBalancerChargePrepaid);
            this.SetParamObj(map, prefix + "InternetAccessible.", this.InternetAccessible);
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "SlaType", this.SlaType);
            this.SetParamSimple(map, prefix + "AddressIPVersion", this.AddressIPVersion);
            this.SetParamSimple(map, prefix + "VipIsp", this.VipIsp);
        }
    }
}

