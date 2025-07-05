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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GovernanceInstanceUpdate : AbstractModel
    {
        
        /// <summary>
        /// 实例所在服务名。
        /// </summary>
        [JsonProperty("Service")]
        public string Service{ get; set; }

        /// <summary>
        /// 实例服务所在命名空间。
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 实例负载均衡权重信息。不填默认为100。
        /// </summary>
        [JsonProperty("Weight")]
        public ulong? Weight{ get; set; }

        /// <summary>
        /// 实例默认健康信息。不填默认为健康。
        /// </summary>
        [JsonProperty("Healthy")]
        public bool? Healthy{ get; set; }

        /// <summary>
        /// 实例隔离信息。不填默认为非隔离。
        /// </summary>
        [JsonProperty("Isolate")]
        public bool? Isolate{ get; set; }

        /// <summary>
        /// 实例ip。
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// 实例监听端口。
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// 实例使用协议。不填默认为空。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 实例版本。不填默认为空。
        /// </summary>
        [JsonProperty("InstanceVersion")]
        public string InstanceVersion{ get; set; }

        /// <summary>
        /// 是否启用健康检查。不填默认不启用。
        /// </summary>
        [JsonProperty("EnableHealthCheck")]
        public bool? EnableHealthCheck{ get; set; }

        /// <summary>
        /// 上报心跳时间间隔。若 EnableHealthCheck 为不启用，则此参数不生效；若 EnableHealthCheck 启用，此参数不填，则默认 ttl 为 5s。
        /// </summary>
        [JsonProperty("Ttl")]
        public ulong? Ttl{ get; set; }

        /// <summary>
        /// 治理中心服务实例id。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 元数据信息。
        /// </summary>
        [JsonProperty("Metadatas")]
        public Metadata[] Metadatas{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Service", this.Service);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "Healthy", this.Healthy);
            this.SetParamSimple(map, prefix + "Isolate", this.Isolate);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "InstanceVersion", this.InstanceVersion);
            this.SetParamSimple(map, prefix + "EnableHealthCheck", this.EnableHealthCheck);
            this.SetParamSimple(map, prefix + "Ttl", this.Ttl);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamArrayObj(map, prefix + "Metadatas.", this.Metadatas);
        }
    }
}

