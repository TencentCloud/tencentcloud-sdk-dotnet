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

    public class ModifyLoadBalancerAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// 负载均衡的唯一ID
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// 负载均衡实例名称
        /// </summary>
        [JsonProperty("LoadBalancerName")]
        public string LoadBalancerName{ get; set; }

        /// <summary>
        /// 设置负载均衡跨地域绑定1.0的后端服务信息
        /// </summary>
        [JsonProperty("TargetRegionInfo")]
        public TargetRegionInfo TargetRegionInfo{ get; set; }

        /// <summary>
        /// 网络计费相关参数
        /// </summary>
        [JsonProperty("InternetChargeInfo")]
        public InternetAccessible InternetChargeInfo{ get; set; }

        /// <summary>
        /// Target是否放通来自CLB的流量。开启放通（true）：只验证CLB上的安全组；不开启放通（false）：需同时验证CLB和后端实例上的安全组。
        /// </summary>
        [JsonProperty("LoadBalancerPassToTarget")]
        public bool? LoadBalancerPassToTarget{ get; set; }

        /// <summary>
        /// 是否开启跨地域绑定2.0功能
        /// </summary>
        [JsonProperty("SnatPro")]
        public bool? SnatPro{ get; set; }

        /// <summary>
        /// 是否开启删除保护
        /// </summary>
        [JsonProperty("DeleteProtect")]
        public bool? DeleteProtect{ get; set; }


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
            this.SetParamSimple(map, prefix + "SnatPro", this.SnatPro);
            this.SetParamSimple(map, prefix + "DeleteProtect", this.DeleteProtect);
        }
    }
}

