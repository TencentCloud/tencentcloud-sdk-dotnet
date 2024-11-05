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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RabbitMQClusterAccessInfo : AbstractModel
    {
        
        /// <summary>
        /// 集群公网接入地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublicAccessEndpoint")]
        public string PublicAccessEndpoint{ get; set; }

        /// <summary>
        /// 集群控制台访问地址
        /// </summary>
        [JsonProperty("WebConsoleEndpoint")]
        public string WebConsoleEndpoint{ get; set; }

        /// <summary>
        /// 集群控制台登录用户名
        /// </summary>
        [JsonProperty("WebConsoleUsername")]
        public string WebConsoleUsername{ get; set; }

        /// <summary>
        /// 集群控制台登录密码
        /// </summary>
        [JsonProperty("WebConsolePassword")]
        public string WebConsolePassword{ get; set; }

        /// <summary>
        /// 已废弃
        /// </summary>
        [JsonProperty("PublicAccessEndpointStatus")]
        public bool? PublicAccessEndpointStatus{ get; set; }

        /// <summary>
        /// 已废弃
        /// </summary>
        [JsonProperty("PublicControlConsoleSwitchStatus")]
        public bool? PublicControlConsoleSwitchStatus{ get; set; }

        /// <summary>
        /// 已废弃
        /// </summary>
        [JsonProperty("VpcControlConsoleSwitchStatus")]
        public bool? VpcControlConsoleSwitchStatus{ get; set; }

        /// <summary>
        /// Vpc管控台访问地址，示例值，http://1.1.1.1:15672
        /// </summary>
        [JsonProperty("VpcWebConsoleEndpoint")]
        public string VpcWebConsoleEndpoint{ get; set; }

        /// <summary>
        /// 公网管控台开关状态，示例值，OFF/ON/CREATING/DELETING
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublicWebConsoleSwitchStatus")]
        public string PublicWebConsoleSwitchStatus{ get; set; }

        /// <summary>
        /// Vpc管控台开关状态，示例值，
        /// OFF/ON/CREATING/DELETING
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcWebConsoleSwitchStatus")]
        public string VpcWebConsoleSwitchStatus{ get; set; }

        /// <summary>
        /// 公网管控台开关状态，示例值，OFF/ON/CREATING/DELETING
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublicDataStreamStatus")]
        public string PublicDataStreamStatus{ get; set; }

        /// <summary>
        /// Prometheus信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PrometheusEndpointInfo")]
        public PrometheusEndpointInfo PrometheusEndpointInfo{ get; set; }

        /// <summary>
        /// 公网域名接入点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WebConsoleDomainEndpoint")]
        public string WebConsoleDomainEndpoint{ get; set; }


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
        }
    }
}

