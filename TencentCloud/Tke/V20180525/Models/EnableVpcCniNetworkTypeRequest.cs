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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EnableVpcCniNetworkTypeRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 开启vpc-cni的模式，tke-route-eni开启的是策略路由模式，tke-direct-eni开启的是独立网卡模式
        /// </summary>
        [JsonProperty("VpcCniType")]
        public string VpcCniType{ get; set; }

        /// <summary>
        /// 是否开启固定IP模式
        /// </summary>
        [JsonProperty("EnableStaticIp")]
        public bool? EnableStaticIp{ get; set; }

        /// <summary>
        /// 使用的容器子网
        /// </summary>
        [JsonProperty("Subnets")]
        public string[] Subnets{ get; set; }

        /// <summary>
        /// 在固定IP模式下，Pod销毁后退还IP的时间，传参必须大于300；不传默认IP永不销毁。
        /// </summary>
        [JsonProperty("ExpiredSeconds")]
        public ulong? ExpiredSeconds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "VpcCniType", this.VpcCniType);
            this.SetParamSimple(map, prefix + "EnableStaticIp", this.EnableStaticIp);
            this.SetParamArraySimple(map, prefix + "Subnets.", this.Subnets);
            this.SetParamSimple(map, prefix + "ExpiredSeconds", this.ExpiredSeconds);
        }
    }
}

