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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateLoadBalancerRequest : AbstractModel
    {
        
        /// <summary>
        /// ECM区域，形如ap-xian-ecm。
        /// </summary>
        [JsonProperty("EcmRegion")]
        public string EcmRegion{ get; set; }

        /// <summary>
        /// 负载均衡实例的网络类型。目前只支持传入OPEN，表示公网属性。
        /// </summary>
        [JsonProperty("LoadBalancerType")]
        public string LoadBalancerType{ get; set; }

        /// <summary>
        /// CMCC | CTCC | CUCC，分别对应 移动 | 电信 | 联通。
        /// </summary>
        [JsonProperty("VipIsp")]
        public string VipIsp{ get; set; }

        /// <summary>
        /// 负载均衡实例的名称，只在创建一个实例的时候才会生效。规则：1-50 个英文、汉字、数字、连接线“-”或下划线“_”。
        /// 注意：如果名称与系统中已有负载均衡实例的名称相同，则系统将会自动生成此次创建的负载均衡实例的名称。
        /// </summary>
        [JsonProperty("LoadBalancerName")]
        public string LoadBalancerName{ get; set; }

        /// <summary>
        /// 负载均衡后端目标设备所属的网络 ID，如vpc-12345678。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 创建负载均衡的个数，默认值 1。
        /// </summary>
        [JsonProperty("Number")]
        public long? Number{ get; set; }

        /// <summary>
        /// 负载均衡的带宽限制等信息。
        /// </summary>
        [JsonProperty("InternetAccessible")]
        public LoadBalancerInternetAccessible InternetAccessible{ get; set; }

        /// <summary>
        /// 标签。
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// 安全组。
        /// </summary>
        [JsonProperty("SecurityGroups")]
        public string[] SecurityGroups{ get; set; }

        /// <summary>
        /// 仅适用于公网负载均衡。IP版本，可取值：IPV4、IPv6FullChain，默认值 IPV4。说明：取值为IPv6FullChain，表示为IPv6版本。
        /// </summary>
        [JsonProperty("AddressIPVersion")]
        public string AddressIPVersion{ get; set; }

        /// <summary>
        /// 在购买IPV6负载均衡实例的情况下，必须指定子网 ID, 此参数必填；IPv4实例不支持该参数。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EcmRegion", this.EcmRegion);
            this.SetParamSimple(map, prefix + "LoadBalancerType", this.LoadBalancerType);
            this.SetParamSimple(map, prefix + "VipIsp", this.VipIsp);
            this.SetParamSimple(map, prefix + "LoadBalancerName", this.LoadBalancerName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamObj(map, prefix + "InternetAccessible.", this.InternetAccessible);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArraySimple(map, prefix + "SecurityGroups.", this.SecurityGroups);
            this.SetParamSimple(map, prefix + "AddressIPVersion", this.AddressIPVersion);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
        }
    }
}

