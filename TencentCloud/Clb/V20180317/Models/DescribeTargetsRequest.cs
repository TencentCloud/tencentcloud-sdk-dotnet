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

    public class DescribeTargetsRequest : AbstractModel
    {
        
        /// <summary>
        /// 负载均衡实例 ID。
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// 监听器 ID 列表。ID 数量上限为20个。
        /// </summary>
        [JsonProperty("ListenerIds")]
        public string[] ListenerIds{ get; set; }

        /// <summary>
        /// 监听器协议类型。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 监听器端口。
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// 查询负载均衡绑定的后端服务列表，过滤条件如下：
        /// <li> location-id - String - 是否必填：否 - （过滤条件）按照 规则ID 过滤，如："loc-12345678"。</li>
        /// <li> private-ip-address - String - 是否必填：否 - （过滤条件）按照 后端服务内网IP 过滤，如："172.16.1.1"。</li>
        /// <li> tag - String - 是否必填：否 - （过滤条件）按照 标签 过滤，如："tag-test"。</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamArraySimple(map, prefix + "ListenerIds.", this.ListenerIds);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

