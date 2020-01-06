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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyLoadBalancersRequest : AbstractModel
    {
        
        /// <summary>
        /// 伸缩组ID
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// 传统负载均衡器ID列表，目前长度上限为20，LoadBalancerIds 和 ForwardLoadBalancers 二者同时最多只能指定一个
        /// </summary>
        [JsonProperty("LoadBalancerIds")]
        public string[] LoadBalancerIds{ get; set; }

        /// <summary>
        /// 应用型负载均衡器列表，目前长度上限为20，LoadBalancerIds 和 ForwardLoadBalancers 二者同时最多只能指定一个
        /// </summary>
        [JsonProperty("ForwardLoadBalancers")]
        public ForwardLoadBalancer[] ForwardLoadBalancers{ get; set; }

        /// <summary>
        /// 负载均衡器校验策略，取值包括 ALL 和 DIFF，默认取值为 ALL。
        /// <br><li> ALL，所有负载均衡器都合法则通过校验，否则校验报错。
        /// <br><li> DIFF，仅校验负载均衡器参数中实际变化的部分，如果合法则通过校验，否则校验报错。
        /// </summary>
        [JsonProperty("LoadBalancersCheckPolicy")]
        public string LoadBalancersCheckPolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
            this.SetParamArraySimple(map, prefix + "LoadBalancerIds.", this.LoadBalancerIds);
            this.SetParamArrayObj(map, prefix + "ForwardLoadBalancers.", this.ForwardLoadBalancers);
            this.SetParamSimple(map, prefix + "LoadBalancersCheckPolicy", this.LoadBalancersCheckPolicy);
        }
    }
}

