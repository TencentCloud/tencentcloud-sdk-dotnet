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

    public class VpnConnection : AbstractModel
    {
        
        /// <summary>
        /// 通道实例ID。
        /// </summary>
        [JsonProperty("VpnConnectionId")]
        public string VpnConnectionId{ get; set; }

        /// <summary>
        /// 通道名称。
        /// </summary>
        [JsonProperty("VpnConnectionName")]
        public string VpnConnectionName{ get; set; }

        /// <summary>
        /// VPC实例ID。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// VPN网关实例ID。
        /// </summary>
        [JsonProperty("VpnGatewayId")]
        public string VpnGatewayId{ get; set; }

        /// <summary>
        /// 对端网关实例ID。
        /// </summary>
        [JsonProperty("CustomerGatewayId")]
        public string CustomerGatewayId{ get; set; }

        /// <summary>
        /// 预共享密钥。
        /// </summary>
        [JsonProperty("PreShareKey")]
        public string PreShareKey{ get; set; }

        /// <summary>
        /// 通道传输协议。
        /// </summary>
        [JsonProperty("VpnProto")]
        public string VpnProto{ get; set; }

        /// <summary>
        /// 通道加密协议。
        /// </summary>
        [JsonProperty("EncryptProto")]
        public string EncryptProto{ get; set; }

        /// <summary>
        /// 路由类型。
        /// </summary>
        [JsonProperty("RouteType")]
        public string RouteType{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 通道的生产状态，PENDING：生产中，AVAILABLE：运行中，DELETING：删除中。
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 通道连接状态，AVAILABLE：已连接。
        /// </summary>
        [JsonProperty("NetStatus")]
        public string NetStatus{ get; set; }

        /// <summary>
        /// SPD。
        /// </summary>
        [JsonProperty("SecurityPolicyDatabaseSet")]
        public SecurityPolicyDatabase[] SecurityPolicyDatabaseSet{ get; set; }

        /// <summary>
        /// IKE选项。
        /// </summary>
        [JsonProperty("IKEOptionsSpecification")]
        public IKEOptionsSpecification IKEOptionsSpecification{ get; set; }

        /// <summary>
        /// IPSEC选择。
        /// </summary>
        [JsonProperty("IPSECOptionsSpecification")]
        public IPSECOptionsSpecification IPSECOptionsSpecification{ get; set; }

        /// <summary>
        /// 是否支持健康状态探测
        /// </summary>
        [JsonProperty("EnableHealthCheck")]
        public bool? EnableHealthCheck{ get; set; }

        /// <summary>
        /// 本端探测ip
        /// </summary>
        [JsonProperty("HealthCheckLocalIp")]
        public string HealthCheckLocalIp{ get; set; }

        /// <summary>
        /// 对端探测ip
        /// </summary>
        [JsonProperty("HealthCheckRemoteIp")]
        public string HealthCheckRemoteIp{ get; set; }

        /// <summary>
        /// 通道健康检查状态，AVAILABLE：正常，UNAVAILABLE：不正常。 未配置健康检查不返回该对象
        /// </summary>
        [JsonProperty("HealthCheckStatus")]
        public string HealthCheckStatus{ get; set; }

        /// <summary>
        /// DPD探测开关。默认为0，表示关闭DPD探测。可选值：0（关闭），1（开启）
        /// </summary>
        [JsonProperty("DpdEnable")]
        public long? DpdEnable{ get; set; }

        /// <summary>
        /// DPD超时时间。即探测确认对端不存在需要的时间。
        /// </summary>
        [JsonProperty("DpdTimeout")]
        public string DpdTimeout{ get; set; }

        /// <summary>
        /// DPD超时后的动作。默认为clear。dpdEnable为1（开启）时有效。可取值为clear（断开）和restart（重试）
        /// </summary>
        [JsonProperty("DpdAction")]
        public string DpdAction{ get; set; }

        /// <summary>
        /// 标签键值对数组
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }

        /// <summary>
        /// 协商类型
        /// </summary>
        [JsonProperty("NegotiationType")]
        public string NegotiationType{ get; set; }

        /// <summary>
        /// Bgp配置信息
        /// </summary>
        [JsonProperty("BgpConfig")]
        public BgpConfigAndAsn BgpConfig{ get; set; }

        /// <summary>
        /// Nqa配置信息
        /// </summary>
        [JsonProperty("HealthCheckConfig")]
        public HealthCheckConfig HealthCheckConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpnConnectionId", this.VpnConnectionId);
            this.SetParamSimple(map, prefix + "VpnConnectionName", this.VpnConnectionName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpnGatewayId", this.VpnGatewayId);
            this.SetParamSimple(map, prefix + "CustomerGatewayId", this.CustomerGatewayId);
            this.SetParamSimple(map, prefix + "PreShareKey", this.PreShareKey);
            this.SetParamSimple(map, prefix + "VpnProto", this.VpnProto);
            this.SetParamSimple(map, prefix + "EncryptProto", this.EncryptProto);
            this.SetParamSimple(map, prefix + "RouteType", this.RouteType);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "NetStatus", this.NetStatus);
            this.SetParamArrayObj(map, prefix + "SecurityPolicyDatabaseSet.", this.SecurityPolicyDatabaseSet);
            this.SetParamObj(map, prefix + "IKEOptionsSpecification.", this.IKEOptionsSpecification);
            this.SetParamObj(map, prefix + "IPSECOptionsSpecification.", this.IPSECOptionsSpecification);
            this.SetParamSimple(map, prefix + "EnableHealthCheck", this.EnableHealthCheck);
            this.SetParamSimple(map, prefix + "HealthCheckLocalIp", this.HealthCheckLocalIp);
            this.SetParamSimple(map, prefix + "HealthCheckRemoteIp", this.HealthCheckRemoteIp);
            this.SetParamSimple(map, prefix + "HealthCheckStatus", this.HealthCheckStatus);
            this.SetParamSimple(map, prefix + "DpdEnable", this.DpdEnable);
            this.SetParamSimple(map, prefix + "DpdTimeout", this.DpdTimeout);
            this.SetParamSimple(map, prefix + "DpdAction", this.DpdAction);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamSimple(map, prefix + "NegotiationType", this.NegotiationType);
            this.SetParamObj(map, prefix + "BgpConfig.", this.BgpConfig);
            this.SetParamObj(map, prefix + "HealthCheckConfig.", this.HealthCheckConfig);
        }
    }
}

