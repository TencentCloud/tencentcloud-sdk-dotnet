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

    public class DeleteRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 负载均衡实例ID，可以通过 [DescribeLoadBalancers](https://cloud.tencent.com/document/product/214/30685) 接口查询。
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// 负载均衡监听器ID，可以通过 [DescribeListeners](https://cloud.tencent.com/document/product/214/30686) 接口查询。
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// 要删除的转发规则的ID组成的数组，可以通过 [DescribeListeners](https://cloud.tencent.com/document/product/214/30686) 接口查询。
        /// </summary>
        [JsonProperty("LocationIds")]
        public string[] LocationIds{ get; set; }

        /// <summary>
        /// 要删除的转发规则的域名，如果是多域名，可以指定多域名列表中的任意一个，可以通过 [DescribeListeners](https://cloud.tencent.com/document/product/214/30686) 接口查询。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 要删除的转发规则的转发路径，可以通过 [DescribeListeners](https://cloud.tencent.com/document/product/214/30686) 接口查询。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 监听器下必须配置一个默认域名，当需要删除默认域名时，可以指定另一个域名作为新的默认域名，如果新的默认域名是多域名，可以指定多域名列表中的任意一个，可以通过 [DescribeListeners](https://cloud.tencent.com/document/product/214/30686) 接口查询。
        /// </summary>
        [JsonProperty("NewDefaultServerDomain")]
        public string NewDefaultServerDomain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamArraySimple(map, prefix + "LocationIds.", this.LocationIds);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "NewDefaultServerDomain", this.NewDefaultServerDomain);
        }
    }
}

