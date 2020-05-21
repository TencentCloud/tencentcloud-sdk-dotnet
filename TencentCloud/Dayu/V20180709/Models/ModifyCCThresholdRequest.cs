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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyCCThresholdRequest : AbstractModel
    {
        
        /// <summary>
        /// 大禹子产品代号（bgpip表示高防IP；bgp表示独享包；bgp-multip表示共享包；net表示高防IP专业版；basic表示基础防护）
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// CC防护阈值，取值(0 100 150 240 350 480 550 700 850 1000 1500 2000 3000 5000 10000 20000);
        /// 当Business为高防IP、高防IP专业版时，其CC防护最大阈值跟资源的保底防护带宽有关，对应关系如下：
        ///   保底带宽: 最大C防护阈值
        ///   10:  20000,
        ///   20:  40000,
        ///   30:  70000,
        ///   40:  100000,
        ///   50:  150000,
        ///   60:  200000,
        ///   80:  250000,
        ///   100: 300000,
        /// </summary>
        [JsonProperty("Threshold")]
        public ulong? Threshold{ get; set; }

        /// <summary>
        /// 资源ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 可选字段，代表CC防护类型，取值[http（HTTP协议的CC防护），https（HTTPS协议的CC防护）]；当不填时，默认为HTTP协议的CC防护；当填写https时还需要填写RuleId字段；
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 可选字段，表示HTTPS协议的7层转发规则ID（通过获取7层转发规则接口可以获取规则ID）；
        /// 当Protocol=https时必须填写；
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 查询的IP地址（仅基础防护提供），取值如：1.1.1.1
        /// </summary>
        [JsonProperty("BasicIp")]
        public string BasicIp{ get; set; }

        /// <summary>
        /// 查询IP所属地域（仅基础防护提供），取值如：gz、bj、sh、hk等地域缩写
        /// </summary>
        [JsonProperty("BasicRegion")]
        public string BasicRegion{ get; set; }

        /// <summary>
        /// 专区类型（仅基础防护提供），取值如：公有云专区：public，黑石专区：bm, NAT服务器专区：nat，互联网通道：channel。
        /// </summary>
        [JsonProperty("BasicBizType")]
        public string BasicBizType{ get; set; }

        /// <summary>
        /// 设备类型（仅基础防护提供），取值如：服务器：cvm，公有云负载均衡：clb，黑石负载均衡：lb，NAT服务器：nat，互联网通道：channel.
        /// </summary>
        [JsonProperty("BasicDeviceType")]
        public string BasicDeviceType{ get; set; }

        /// <summary>
        /// 仅基础防护提供。可选，IPInstance Nat 网关（如果查询的设备类型是NAT服务器，需要传此参数，通过nat资源查询接口获取）
        /// </summary>
        [JsonProperty("BasicIpInstance")]
        public string BasicIpInstance{ get; set; }

        /// <summary>
        /// 仅基础防护提供。可选，运营商线路（如果查询的设备类型是NAT服务器，需要传此参数为5）
        /// </summary>
        [JsonProperty("BasicIspCode")]
        public ulong? BasicIspCode{ get; set; }

        /// <summary>
        /// 可选字段，当协议取值HTTPS时，必填
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamSimple(map, prefix + "Threshold", this.Threshold);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "BasicIp", this.BasicIp);
            this.SetParamSimple(map, prefix + "BasicRegion", this.BasicRegion);
            this.SetParamSimple(map, prefix + "BasicBizType", this.BasicBizType);
            this.SetParamSimple(map, prefix + "BasicDeviceType", this.BasicDeviceType);
            this.SetParamSimple(map, prefix + "BasicIpInstance", this.BasicIpInstance);
            this.SetParamSimple(map, prefix + "BasicIspCode", this.BasicIspCode);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
        }
    }
}

