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

namespace TencentCloud.Bmlb.V20180625.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UnbindL4BackendsRequest : AbstractModel
    {
        
        /// <summary>
        /// 负载均衡实例ID，可通过接口DescribeLoadBalancers查询。
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// 负载均衡四层监听器ID，可通过接口DescribeL4Listeners查询。
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// 待解绑的主机信息。可以绑定多个主机端口。目前一个四层监听器下面最多允许绑定255个主机端口。
        /// </summary>
        [JsonProperty("BackendSet")]
        public UnbindL4Backend[] BackendSet{ get; set; }

        /// <summary>
        /// 绑定类型。0：物理机 1：虚拟机 2：半托管机器
        /// </summary>
        [JsonProperty("BindType")]
        public long? BindType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamArrayObj(map, prefix + "BackendSet.", this.BackendSet);
            this.SetParamSimple(map, prefix + "BindType", this.BindType);
        }
    }
}

