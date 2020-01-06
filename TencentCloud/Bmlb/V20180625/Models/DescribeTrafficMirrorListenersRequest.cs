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

    public class DescribeTrafficMirrorListenersRequest : AbstractModel
    {
        
        /// <summary>
        /// 流量镜像实例ID。
        /// </summary>
        [JsonProperty("TrafficMirrorId")]
        public string TrafficMirrorId{ get; set; }

        /// <summary>
        /// 分页的偏移量，也即从第几条记录开始查询
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 单次查询返回的条目数，默认值：500。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 待搜索的负载均衡Id。
        /// </summary>
        [JsonProperty("SearchLoadBalancerIds")]
        public string[] SearchLoadBalancerIds{ get; set; }

        /// <summary>
        /// 待搜索的负载均衡名称。
        /// </summary>
        [JsonProperty("SearchLoadBalancerNames")]
        public string[] SearchLoadBalancerNames{ get; set; }

        /// <summary>
        /// 待搜索的Vip。
        /// </summary>
        [JsonProperty("SearchVips")]
        public string[] SearchVips{ get; set; }

        /// <summary>
        /// 待搜索的监听器ID。
        /// </summary>
        [JsonProperty("SearchListenerIds")]
        public string[] SearchListenerIds{ get; set; }

        /// <summary>
        /// 待搜索的监听器名称。
        /// </summary>
        [JsonProperty("SearchListenerNames")]
        public string[] SearchListenerNames{ get; set; }

        /// <summary>
        /// 待搜索的协议名称。
        /// </summary>
        [JsonProperty("SearchProtocols")]
        public string[] SearchProtocols{ get; set; }

        /// <summary>
        /// 待搜索的端口。
        /// </summary>
        [JsonProperty("SearchLoadBalancerPorts")]
        public ulong?[] SearchLoadBalancerPorts{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TrafficMirrorId", this.TrafficMirrorId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "SearchLoadBalancerIds.", this.SearchLoadBalancerIds);
            this.SetParamArraySimple(map, prefix + "SearchLoadBalancerNames.", this.SearchLoadBalancerNames);
            this.SetParamArraySimple(map, prefix + "SearchVips.", this.SearchVips);
            this.SetParamArraySimple(map, prefix + "SearchListenerIds.", this.SearchListenerIds);
            this.SetParamArraySimple(map, prefix + "SearchListenerNames.", this.SearchListenerNames);
            this.SetParamArraySimple(map, prefix + "SearchProtocols.", this.SearchProtocols);
            this.SetParamArraySimple(map, prefix + "SearchLoadBalancerPorts.", this.SearchLoadBalancerPorts);
        }
    }
}

