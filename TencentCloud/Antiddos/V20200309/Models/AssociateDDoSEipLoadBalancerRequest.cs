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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AssociateDDoSEipLoadBalancerRequest : AbstractModel
    {
        
        /// <summary>
        /// 资源实例ID，实例ID形如：bgpip-0000011x。只能填写高防IP实例。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 资源实例ID对应的高防弹性公网IP。
        /// </summary>
        [JsonProperty("Eip")]
        public string Eip{ get; set; }

        /// <summary>
        /// 要绑定的负载均衡ID。负载均衡 ID 形如：lb-0000002i。可通过登录控制台查询，也可通过 DescribeLoadBalancers 接口返回值中的LoadBalancerId获取。
        /// </summary>
        [JsonProperty("LoadBalancerID")]
        public string LoadBalancerID{ get; set; }

        /// <summary>
        /// CLB所在地域，例如：ap-hongkong。
        /// </summary>
        [JsonProperty("LoadBalancerRegion")]
        public string LoadBalancerRegion{ get; set; }

        /// <summary>
        /// CLB内网IP
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Eip", this.Eip);
            this.SetParamSimple(map, prefix + "LoadBalancerID", this.LoadBalancerID);
            this.SetParamSimple(map, prefix + "LoadBalancerRegion", this.LoadBalancerRegion);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
        }
    }
}

