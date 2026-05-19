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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RabbitMQClusterAccessInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>集群公网接入地址</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublicAccessEndpoint")]
        public string PublicAccessEndpoint{ get; set; }

        /// <summary>
        /// <p>集群 Web 控制台公网访问地址</p>
        /// </summary>
        [JsonProperty("WebConsoleEndpoint")]
        public string WebConsoleEndpoint{ get; set; }

        /// <summary>
        /// <p>集群 Web 控制台登录用户名</p>
        /// </summary>
        [JsonProperty("WebConsoleUsername")]
        public string WebConsoleUsername{ get; set; }

        /// <summary>
        /// <p>集群 Web 控制台登录密码</p>
        /// </summary>
        [JsonProperty("WebConsolePassword")]
        public string WebConsolePassword{ get; set; }

        /// <summary>
        /// <p>已废弃</p>
        /// </summary>
        [JsonProperty("PublicAccessEndpointStatus")]
        public bool? PublicAccessEndpointStatus{ get; set; }

        /// <summary>
        /// <p>已废弃</p>
        /// </summary>
        [JsonProperty("PublicControlConsoleSwitchStatus")]
        public bool? PublicControlConsoleSwitchStatus{ get; set; }

        /// <summary>
        /// <p>已废弃</p>
        /// </summary>
        [JsonProperty("VpcControlConsoleSwitchStatus")]
        public bool? VpcControlConsoleSwitchStatus{ get; set; }

        /// <summary>
        /// <p>Web 管控台 VPC 访问地址</p>
        /// </summary>
        [JsonProperty("VpcWebConsoleEndpoint")]
        public string VpcWebConsoleEndpoint{ get; set; }

        /// <summary>
        /// <p>Web 控制台公网访问开关状态</p><p>枚举值：</p><ul><li>OFF： 已关闭</li><li>ON： 已开启</li><li>CREATING： 创建中</li><li>DELETING： 删除中</li><li>CREATE_FAILURE： 创建失败</li><li>DELETE_FAILURE： 删除失败</li></ul>
        /// </summary>
        [JsonProperty("PublicWebConsoleSwitchStatus")]
        public string PublicWebConsoleSwitchStatus{ get; set; }

        /// <summary>
        /// <p>Web 控制台 VPC 访问开关状态</p><p>枚举值：</p><ul><li>OFF： 已关闭</li><li>ON： 已开启</li><li>CREATING： 创建中</li><li>DELETING： 删除中</li><li>CREATE_FAILURE： 创建失败</li><li>DELETE_FAILURE： 删除失败</li></ul>
        /// </summary>
        [JsonProperty("VpcWebConsoleSwitchStatus")]
        public string VpcWebConsoleSwitchStatus{ get; set; }

        /// <summary>
        /// <p>公网接入点开关状态</p><p>枚举值：</p><ul><li>OFF： 已关闭</li><li>ON： 已开启</li><li>CREATING： 创建中</li><li>DELETING： 删除中</li><li>CREATE_FAILURE： 创建失败</li><li>DELETE_FAILURE： 删除失败</li></ul>
        /// </summary>
        [JsonProperty("PublicDataStreamStatus")]
        public string PublicDataStreamStatus{ get; set; }

        /// <summary>
        /// <p>Prometheus信息</p>
        /// </summary>
        [JsonProperty("PrometheusEndpointInfo")]
        public PrometheusEndpointInfo PrometheusEndpointInfo{ get; set; }

        /// <summary>
        /// <p>公网域名接入点</p>
        /// </summary>
        [JsonProperty("WebConsoleDomainEndpoint")]
        public string WebConsoleDomainEndpoint{ get; set; }

        /// <summary>
        /// <p>控制面所使用的VPC信息</p>
        /// </summary>
        [JsonProperty("ControlPlaneEndpointInfo")]
        public VpcEndpointInfo ControlPlaneEndpointInfo{ get; set; }

        /// <summary>
        /// <p>TLS加密的数据流公网接入点</p>
        /// </summary>
        [JsonProperty("PublicTlsAccessEndpoint")]
        public string PublicTlsAccessEndpoint{ get; set; }

        /// <summary>
        /// <p>公网IP是否复用</p>
        /// </summary>
        [JsonProperty("PublicIpReused")]
        public bool? PublicIpReused{ get; set; }

        /// <summary>
        /// <p>Web 控制台公网访问操作的错误信息</p>
        /// </summary>
        [JsonProperty("PublicWebConsoleErrorMessage")]
        public string PublicWebConsoleErrorMessage{ get; set; }

        /// <summary>
        /// <p>Web 控制台 VPC 访问操作的错误信息</p>
        /// </summary>
        [JsonProperty("VpcWebConsoleErrorMessage")]
        public string VpcWebConsoleErrorMessage{ get; set; }

        /// <summary>
        /// <p>公网接入点操作的错误信息</p>
        /// </summary>
        [JsonProperty("PublicDataStreamErrorMessage")]
        public string PublicDataStreamErrorMessage{ get; set; }

        /// <summary>
        /// <p>公网Stream接入点</p>
        /// </summary>
        [JsonProperty("PublicStreamAccessEndpoint")]
        public string PublicStreamAccessEndpoint{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PublicAccessEndpoint", this.PublicAccessEndpoint);
            this.SetParamSimple(map, prefix + "WebConsoleEndpoint", this.WebConsoleEndpoint);
            this.SetParamSimple(map, prefix + "WebConsoleUsername", this.WebConsoleUsername);
            this.SetParamSimple(map, prefix + "WebConsolePassword", this.WebConsolePassword);
            this.SetParamSimple(map, prefix + "PublicAccessEndpointStatus", this.PublicAccessEndpointStatus);
            this.SetParamSimple(map, prefix + "PublicControlConsoleSwitchStatus", this.PublicControlConsoleSwitchStatus);
            this.SetParamSimple(map, prefix + "VpcControlConsoleSwitchStatus", this.VpcControlConsoleSwitchStatus);
            this.SetParamSimple(map, prefix + "VpcWebConsoleEndpoint", this.VpcWebConsoleEndpoint);
            this.SetParamSimple(map, prefix + "PublicWebConsoleSwitchStatus", this.PublicWebConsoleSwitchStatus);
            this.SetParamSimple(map, prefix + "VpcWebConsoleSwitchStatus", this.VpcWebConsoleSwitchStatus);
            this.SetParamSimple(map, prefix + "PublicDataStreamStatus", this.PublicDataStreamStatus);
            this.SetParamObj(map, prefix + "PrometheusEndpointInfo.", this.PrometheusEndpointInfo);
            this.SetParamSimple(map, prefix + "WebConsoleDomainEndpoint", this.WebConsoleDomainEndpoint);
            this.SetParamObj(map, prefix + "ControlPlaneEndpointInfo.", this.ControlPlaneEndpointInfo);
            this.SetParamSimple(map, prefix + "PublicTlsAccessEndpoint", this.PublicTlsAccessEndpoint);
            this.SetParamSimple(map, prefix + "PublicIpReused", this.PublicIpReused);
            this.SetParamSimple(map, prefix + "PublicWebConsoleErrorMessage", this.PublicWebConsoleErrorMessage);
            this.SetParamSimple(map, prefix + "VpcWebConsoleErrorMessage", this.VpcWebConsoleErrorMessage);
            this.SetParamSimple(map, prefix + "PublicDataStreamErrorMessage", this.PublicDataStreamErrorMessage);
            this.SetParamSimple(map, prefix + "PublicStreamAccessEndpoint", this.PublicStreamAccessEndpoint);
        }
    }
}

