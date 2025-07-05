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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateVpnConnectionRequest : AbstractModel
    {
        
        /// <summary>
        /// VPN网关实例ID。
        /// </summary>
        [JsonProperty("VpnGatewayId")]
        public string VpnGatewayId{ get; set; }

        /// <summary>
        /// 对端网关ID。例如：cgw-2wqq41m9，可通过[DescribeCustomerGateways](https://cloud.tencent.com/document/product/215/17516)接口查询对端网关。
        /// </summary>
        [JsonProperty("CustomerGatewayId")]
        public string CustomerGatewayId{ get; set; }

        /// <summary>
        /// 通道名称，可任意命名，但不得超过60个字符。
        /// </summary>
        [JsonProperty("VpnConnectionName")]
        public string VpnConnectionName{ get; set; }

        /// <summary>
        /// 预共享密钥。
        /// </summary>
        [JsonProperty("PreShareKey")]
        public string PreShareKey{ get; set; }

        /// <summary>
        /// VPC实例ID。可通过[DescribeVpcs](https://cloud.tencent.com/document/product/215/15778)接口返回值中的VpcId获取。
        /// CCN VPN 形的通道 可以不传VPCID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// SPD策略组，例如：{"10.0.0.5/24":["172.123.10.5/16"]}，10.0.0.5/24是vpc内网段172.123.10.5/16是IDC网段。用户指定VPC内哪些网段可以和您IDC中哪些网段通信。
        /// </summary>
        [JsonProperty("SecurityPolicyDatabases")]
        public SecurityPolicyDatabase[] SecurityPolicyDatabases{ get; set; }

        /// <summary>
        /// IKE配置（Internet Key Exchange，因特网密钥交换），IKE具有一套自我保护机制，用户配置网络安全协议
        /// </summary>
        [JsonProperty("IKEOptionsSpecification")]
        public IKEOptionsSpecification IKEOptionsSpecification{ get; set; }

        /// <summary>
        /// IPSec配置，腾讯云提供IPSec安全会话设置
        /// </summary>
        [JsonProperty("IPSECOptionsSpecification")]
        public IPSECOptionsSpecification IPSECOptionsSpecification{ get; set; }

        /// <summary>
        /// 指定绑定的标签列表，例如：[{"Key": "city", "Value": "shanghai"}]
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 是否支持隧道内健康检查，默认为False。
        /// </summary>
        [JsonProperty("EnableHealthCheck")]
        public bool? EnableHealthCheck{ get; set; }

        /// <summary>
        /// 健康检查本端地址，默认值为随机在169.254.128.0/17分配一个IP。
        /// </summary>
        [JsonProperty("HealthCheckLocalIp")]
        public string HealthCheckLocalIp{ get; set; }

        /// <summary>
        /// 健康检查对端地址，默认值为随机在169.254.128.0/17分配一个IP。
        /// </summary>
        [JsonProperty("HealthCheckRemoteIp")]
        public string HealthCheckRemoteIp{ get; set; }

        /// <summary>
        /// 通道类型, 例如:["STATIC", "StaticRoute", "Policy"]
        /// </summary>
        [JsonProperty("RouteType")]
        public string RouteType{ get; set; }

        /// <summary>
        /// 协商类型，默认为active（主动协商）。可选值：active（主动协商），passive（被动协商），flowTrigger（流量协商）
        /// </summary>
        [JsonProperty("NegotiationType")]
        public string NegotiationType{ get; set; }

        /// <summary>
        /// DPD探测开关。默认为0，表示关闭DPD探测。可选值：0（关闭），1（开启）
        /// </summary>
        [JsonProperty("DpdEnable")]
        public long? DpdEnable{ get; set; }

        /// <summary>
        /// DPD超时时间。即探测确认对端不存在需要的时间。dpdEnable为1（开启）时有效。默认30，单位为秒
        /// </summary>
        [JsonProperty("DpdTimeout")]
        public string DpdTimeout{ get; set; }

        /// <summary>
        /// DPD超时后的动作。默认为clear。dpdEnable为1（开启）时有效。可取值为clear（断开）和restart（重试）
        /// </summary>
        [JsonProperty("DpdAction")]
        public string DpdAction{ get; set; }

        /// <summary>
        /// 创建通道路由信息。
        /// </summary>
        [JsonProperty("Route")]
        public CreateVpnConnRoute Route{ get; set; }

        /// <summary>
        /// BGP配置。
        /// </summary>
        [JsonProperty("BgpConfig")]
        public BgpConfig BgpConfig{ get; set; }

        /// <summary>
        /// 健康检查NQA配置。
        /// </summary>
        [JsonProperty("HealthCheckConfig")]
        public HealthCheckConfig HealthCheckConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpnGatewayId", this.VpnGatewayId);
            this.SetParamSimple(map, prefix + "CustomerGatewayId", this.CustomerGatewayId);
            this.SetParamSimple(map, prefix + "VpnConnectionName", this.VpnConnectionName);
            this.SetParamSimple(map, prefix + "PreShareKey", this.PreShareKey);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamArrayObj(map, prefix + "SecurityPolicyDatabases.", this.SecurityPolicyDatabases);
            this.SetParamObj(map, prefix + "IKEOptionsSpecification.", this.IKEOptionsSpecification);
            this.SetParamObj(map, prefix + "IPSECOptionsSpecification.", this.IPSECOptionsSpecification);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "EnableHealthCheck", this.EnableHealthCheck);
            this.SetParamSimple(map, prefix + "HealthCheckLocalIp", this.HealthCheckLocalIp);
            this.SetParamSimple(map, prefix + "HealthCheckRemoteIp", this.HealthCheckRemoteIp);
            this.SetParamSimple(map, prefix + "RouteType", this.RouteType);
            this.SetParamSimple(map, prefix + "NegotiationType", this.NegotiationType);
            this.SetParamSimple(map, prefix + "DpdEnable", this.DpdEnable);
            this.SetParamSimple(map, prefix + "DpdTimeout", this.DpdTimeout);
            this.SetParamSimple(map, prefix + "DpdAction", this.DpdAction);
            this.SetParamObj(map, prefix + "Route.", this.Route);
            this.SetParamObj(map, prefix + "BgpConfig.", this.BgpConfig);
            this.SetParamObj(map, prefix + "HealthCheckConfig.", this.HealthCheckConfig);
        }
    }
}

