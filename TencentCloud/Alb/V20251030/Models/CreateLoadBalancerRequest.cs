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

    public class CreateLoadBalancerRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用型负载均衡的地址类型。取值：
        /// 
        /// - **Internet**：负载均衡具有公网IP地址，DNS域名被解析到公网IP，因此可以在公网环境访问。
        /// 
        /// - **Intranet**：负载均衡只有私网IP地址，DNS域名被解析到私网IP，因此只能被负载均衡所在VPC的内网环境访问。
        /// </summary>
        [JsonProperty("AddressType")]
        public string AddressType{ get; set; }

        /// <summary>
        /// 应用型负载均衡实例计费配置。
        /// </summary>
        [JsonProperty("LoadBalancerBillingConfig")]
        public LoadBalancerBillingConfig LoadBalancerBillingConfig{ get; set; }

        /// <summary>
        /// 私有网络 ID。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 可用区及私有网络子网映射列表，最多支持添加10个可用区。若当前地域支持2个及以上的可用区，至少需要添加2个可用区。
        /// </summary>
        [JsonProperty("ZoneMappings")]
        public ZoneMappingsItem[] ZoneMappings{ get; set; }

        /// <summary>
        /// IP 地址版本，取值 IPv4 或 IPv6。
        /// </summary>
        [JsonProperty("AddressIpVersion")]
        public string AddressIpVersion{ get; set; }

        /// <summary>
        /// 客户端Token，用于保证请求的幂等性。
        /// 
        /// 从您的客户端生成一个参数值，确保不同请求间该参数值唯一。ClientToken只支持ASCII字符。
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// 删除保护配置。
        /// </summary>
        [JsonProperty("DeleteProtection")]
        public DeletionProtectionConfig DeleteProtection{ get; set; }

        /// <summary>
        /// 是否只预检此次请求，取值：
        /// 
        /// - **true**：发送检查请求，不会创建应用型负载均衡实例。检查项包括是否填写了必需参数、请求格式和业务限制。如果检查不通过，则返回对应错误。如果检查通过，则返回错误码`DryRunOperation`。
        /// 
        /// - **false**（默认值）：发送正常请求，通过检查后返回HTTP 2xx状态码并直接进行操作。
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// EIP 地址类型，可取值：
        /// - **EIP**: 普通弹性公网 IP
        /// - **AntiDDoSEIP**: 高防EIP
        /// - **AnycastEIP**: 加速 EIP
        /// - **HighQualityEIP**: 精品 IP。仅新加坡和中国香港支持精品IP。
        /// - **ResidentialEIP**: 原生 IP
        /// 
        /// 不传默认是EIP。
        /// </summary>
        [JsonProperty("InternetAddressType")]
        public string InternetAddressType{ get; set; }

        /// <summary>
        /// 应用型负载均衡实例名称。长度为1~80个字符，可包含中文、字母、数字、短划线（-）、正斜线（/）、半角句号（.）和下划线（_）。
        /// </summary>
        [JsonProperty("LoadBalancerName")]
        public string LoadBalancerName{ get; set; }

        /// <summary>
        /// 标签。
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AddressType", this.AddressType);
            this.SetParamObj(map, prefix + "LoadBalancerBillingConfig.", this.LoadBalancerBillingConfig);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamArrayObj(map, prefix + "ZoneMappings.", this.ZoneMappings);
            this.SetParamSimple(map, prefix + "AddressIpVersion", this.AddressIpVersion);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamObj(map, prefix + "DeleteProtection.", this.DeleteProtection);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamSimple(map, prefix + "InternetAddressType", this.InternetAddressType);
            this.SetParamSimple(map, prefix + "LoadBalancerName", this.LoadBalancerName);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

