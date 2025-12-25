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

    public class ModifyLoadBalancerAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>负载均衡的唯一ID，可以通过 <a href="https://cloud.tencent.com/document/product/214/30685">DescribeLoadBalancers</a> 接口获取。</p>
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// <p>负载均衡实例名称，规则：1-60 个英文、汉字、数字、连接线“-”或下划线“_”。</p>
        /// </summary>
        [JsonProperty("LoadBalancerName")]
        public string LoadBalancerName{ get; set; }

        /// <summary>
        /// <p>设置负载均衡跨地域绑定1.0的后端服务信息</p>
        /// </summary>
        [JsonProperty("TargetRegionInfo")]
        public TargetRegionInfo TargetRegionInfo{ get; set; }

        /// <summary>
        /// <p>网络计费相关参数</p>
        /// </summary>
        [JsonProperty("InternetChargeInfo")]
        public InternetAccessible InternetChargeInfo{ get; set; }

        /// <summary>
        /// <p>Target是否放通来自CLB的流量。开启放通（true）：只验证CLB上的安全组；不开启放通（false）：需同时验证CLB和后端实例上的安全组。不填则不修改。</p>
        /// </summary>
        [JsonProperty("LoadBalancerPassToTarget")]
        public bool? LoadBalancerPassToTarget{ get; set; }

        /// <summary>
        /// <p>不同计费模式之间的切换：0表示不切换，1表示预付费和后付费切换，2表示后付费之间切换。默认值：0</p>
        /// </summary>
        [JsonProperty("SwitchFlag")]
        public ulong? SwitchFlag{ get; set; }

        /// <summary>
        /// <p>是否开启跨地域绑定2.0功能。不填则不修改。</p>
        /// </summary>
        [JsonProperty("SnatPro")]
        public bool? SnatPro{ get; set; }

        /// <summary>
        /// <p>是否开启删除保护，不填则不修改。</p>
        /// </summary>
        [JsonProperty("DeleteProtect")]
        public bool? DeleteProtect{ get; set; }

        /// <summary>
        /// <p>将负载均衡二级域名由mycloud.com改为tencentclb.com，子域名也会变换，修改后mycloud.com域名将失效。不填则不修改。</p>
        /// </summary>
        [JsonProperty("ModifyClassicDomain")]
        public bool? ModifyClassicDomain{ get; set; }

        /// <summary>
        /// <p>关联的终端节点Id，可通过<a href="https://cloud.tencent.com/document/product/215/54679">DescribeVpcEndPoint</a>接口查询。传空字符串代表解除关联。</p>
        /// </summary>
        [JsonProperty("AssociateEndpoint")]
        public string AssociateEndpoint{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "LoadBalancerName", this.LoadBalancerName);
            this.SetParamObj(map, prefix + "TargetRegionInfo.", this.TargetRegionInfo);
            this.SetParamObj(map, prefix + "InternetChargeInfo.", this.InternetChargeInfo);
            this.SetParamSimple(map, prefix + "LoadBalancerPassToTarget", this.LoadBalancerPassToTarget);
            this.SetParamSimple(map, prefix + "SwitchFlag", this.SwitchFlag);
            this.SetParamSimple(map, prefix + "SnatPro", this.SnatPro);
            this.SetParamSimple(map, prefix + "DeleteProtect", this.DeleteProtect);
            this.SetParamSimple(map, prefix + "ModifyClassicDomain", this.ModifyClassicDomain);
            this.SetParamSimple(map, prefix + "AssociateEndpoint", this.AssociateEndpoint);
        }
    }
}

