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

    public class DescribeClassicalLBListenersRequest : AbstractModel
    {
        
        /// <summary>
        /// 负载均衡实例ID。
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// 负载均衡监听器ID列表。
        /// </summary>
        [JsonProperty("ListenerIds")]
        public string[] ListenerIds{ get; set; }

        /// <summary>
        /// 负载均衡监听的协议：'TCP', 'UDP', 'HTTP', 'HTTPS'。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 负载均衡监听端口，范围为[1-65535]。
        /// </summary>
        [JsonProperty("ListenerPort")]
        public long? ListenerPort{ get; set; }

        /// <summary>
        /// 监听器的状态，0：创建中，1：运行中。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamArraySimple(map, prefix + "ListenerIds.", this.ListenerIds);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "ListenerPort", this.ListenerPort);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

