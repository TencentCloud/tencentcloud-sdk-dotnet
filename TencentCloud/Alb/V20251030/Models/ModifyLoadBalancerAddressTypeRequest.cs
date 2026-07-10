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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyLoadBalancerAddressTypeRequest : AbstractModel
    {
        
        /// <summary>
        /// 目标网络类型。取值：
        /// - **Internet**（公网型）
        /// 负载均衡实例分配公网 IP 地址，域名（DNS）解析至公网 IP，可在公网环境中直接访问，适用于对外提供服务的业务场景。
        /// - **Intranet**（内网型）
        /// 负载均衡实例仅分配私网 IP 地址，域名（DNS）解析至私网 IP，仅支持在负载均衡实例所属 VPC 内的内网环境访问，适用于内部业务或对安全性要求较高的场景。
        /// </summary>
        [JsonProperty("AddressType")]
        public string AddressType{ get; set; }

        /// <summary>
        /// 负载均衡实例 ID，格式为 alb- 后接 8 位字母数字。
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// 共享带宽包 ID。
        /// </summary>
        [JsonProperty("BandwidthPackageId")]
        public string BandwidthPackageId{ get; set; }

        /// <summary>
        /// 是否只预检此次请求。取值：
        /// - **true**：发送检查请求，不会更新实例的网络类型。检查项包括是否填写了必需参数、请求格式、业务限制。如果检查不通过，则返回对应错误。如果检查通过，则返回错误码DryRunOperation。
        /// - **false**（默认值）：发送正常请求，通过检查后返回 HTTP 2xx 状态码并直接进行操作。
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// 可用区及子网映射结构体。
        /// 若当前地域支持 2 个及以上的可用区，至少需要添加 2 个可用区。
        /// </summary>
        [JsonProperty("ZoneMappings")]
        public ZoneMappingsItem[] ZoneMappings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AddressType", this.AddressType);
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "BandwidthPackageId", this.BandwidthPackageId);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamArrayObj(map, prefix + "ZoneMappings.", this.ZoneMappings);
        }
    }
}

