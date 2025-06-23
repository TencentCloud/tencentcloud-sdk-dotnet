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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCloudNativeAPIGatewayResult : AbstractModel
    {
        
        /// <summary>
        /// 云原生API网关ID。
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// 云原生API网关状态。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 云原生API网关名。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 云原生API网关类型。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 实例版本：
        /// - 2.4.1
        /// - 2.5.1
        /// </summary>
        [JsonProperty("GatewayVersion")]
        public string GatewayVersion{ get; set; }

        /// <summary>
        /// 云原生API网关节点信息。
        /// </summary>
        [JsonProperty("NodeConfig")]
        public CloudNativeAPIGatewayNodeConfig NodeConfig{ get; set; }

        /// <summary>
        /// 云原生API网关vpc配置。
        /// </summary>
        [JsonProperty("VpcConfig")]
        public CloudNativeAPIGatewayVpcConfig VpcConfig{ get; set; }

        /// <summary>
        /// 云原生API网关描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 云原生API网关创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 实例的标签信息
        /// </summary>
        [JsonProperty("Tags")]
        public InstanceTagInfo[] Tags{ get; set; }

        /// <summary>
        /// 是否开启 cls 日志
        /// </summary>
        [JsonProperty("EnableCls")]
        public bool? EnableCls{ get; set; }

        /// <summary>
        /// 付费模式，0表示后付费，1预付费
        /// </summary>
        [JsonProperty("TradeType")]
        public long? TradeType{ get; set; }

        /// <summary>
        /// 实例版本，当前支持开发版、标准版、专业版【TRIAL、STANDARD、PROFESSIONAL】
        /// </summary>
        [JsonProperty("FeatureVersion")]
        public string FeatureVersion{ get; set; }

        /// <summary>
        /// 公网出流量带宽，[1,2048]Mbps
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public ulong? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// 自动续费标记，0表示默认状态(用户未设置，即初始状态)；
        /// 1表示自动续费，2表示明确不自动续费(用户设置)，若业务无续费概念或无需自动续费，需要设置为0
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 到期时间，预付费时使用
        /// </summary>
        [JsonProperty("CurDeadline")]
        public string CurDeadline{ get; set; }

        /// <summary>
        /// 隔离时间，实例隔离时使用
        /// </summary>
        [JsonProperty("IsolateTime")]
        public string IsolateTime{ get; set; }

        /// <summary>
        /// 是否开启客户端公网。
        /// </summary>
        [JsonProperty("EnableInternet")]
        public bool? EnableInternet{ get; set; }

        /// <summary>
        /// 实例实际的地域信息
        /// </summary>
        [JsonProperty("EngineRegion")]
        public string EngineRegion{ get; set; }

        /// <summary>
        /// Ingress class名称
        /// </summary>
        [JsonProperty("IngressClassName")]
        public string IngressClassName{ get; set; }

        /// <summary>
        /// 公网计费方式。可选取值 BANDWIDTH | TRAFFIC ，表示按带宽和按流量计费。
        /// </summary>
        [JsonProperty("InternetPayMode")]
        public string InternetPayMode{ get; set; }

        /// <summary>
        /// 云原生API网关小版本号
        /// </summary>
        [JsonProperty("GatewayMinorVersion")]
        public string GatewayMinorVersion{ get; set; }

        /// <summary>
        /// 实例监听的端口信息
        /// </summary>
        [JsonProperty("InstancePort")]
        public InstancePort InstancePort{ get; set; }

        /// <summary>
        /// 公网CLB默认类型
        /// </summary>
        [JsonProperty("LoadBalancerType")]
        public string LoadBalancerType{ get; set; }

        /// <summary>
        /// 公网IP地址列表
        /// </summary>
        [JsonProperty("PublicIpAddresses")]
        public string[] PublicIpAddresses{ get; set; }

        /// <summary>
        /// 是否开启删除保护
        /// </summary>
        [JsonProperty("DeleteProtect")]
        public bool? DeleteProtect{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "GatewayVersion", this.GatewayVersion);
            this.SetParamObj(map, prefix + "NodeConfig.", this.NodeConfig);
            this.SetParamObj(map, prefix + "VpcConfig.", this.VpcConfig);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "EnableCls", this.EnableCls);
            this.SetParamSimple(map, prefix + "TradeType", this.TradeType);
            this.SetParamSimple(map, prefix + "FeatureVersion", this.FeatureVersion);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "CurDeadline", this.CurDeadline);
            this.SetParamSimple(map, prefix + "IsolateTime", this.IsolateTime);
            this.SetParamSimple(map, prefix + "EnableInternet", this.EnableInternet);
            this.SetParamSimple(map, prefix + "EngineRegion", this.EngineRegion);
            this.SetParamSimple(map, prefix + "IngressClassName", this.IngressClassName);
            this.SetParamSimple(map, prefix + "InternetPayMode", this.InternetPayMode);
            this.SetParamSimple(map, prefix + "GatewayMinorVersion", this.GatewayMinorVersion);
            this.SetParamObj(map, prefix + "InstancePort.", this.InstancePort);
            this.SetParamSimple(map, prefix + "LoadBalancerType", this.LoadBalancerType);
            this.SetParamArraySimple(map, prefix + "PublicIpAddresses.", this.PublicIpAddresses);
            this.SetParamSimple(map, prefix + "DeleteProtect", this.DeleteProtect);
        }
    }
}

