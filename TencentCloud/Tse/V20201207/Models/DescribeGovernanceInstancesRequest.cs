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

    public class DescribeGovernanceInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例所在的服务名。
        /// </summary>
        [JsonProperty("Service")]
        public string Service{ get; set; }

        /// <summary>
        /// 实例所在命名空间名。
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// tse实例id。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 根据实例ip过滤，多个ip使用英文逗号分隔。
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// 根据实例版本过滤。
        /// </summary>
        [JsonProperty("InstanceVersion")]
        public string InstanceVersion{ get; set; }

        /// <summary>
        /// 根据实例协议过滤。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 根据实例健康状态过滤。false：表示不健康，true：表示健康。
        /// </summary>
        [JsonProperty("HealthStatus")]
        public bool? HealthStatus{ get; set; }

        /// <summary>
        /// 根据实例隔离状态过滤。false：表示非隔离，true：表示隔离中。
        /// </summary>
        [JsonProperty("Isolate")]
        public bool? Isolate{ get; set; }

        /// <summary>
        /// 根据元数据信息过滤。目前只支持一组元数据键值，若传了多个键值对，只会以第一个过滤。
        /// </summary>
        [JsonProperty("Metadatas")]
        public Metadata[] Metadatas{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最大值为100。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Location")]
        public Location Location{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Service", this.Service);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "InstanceVersion", this.InstanceVersion);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "HealthStatus", this.HealthStatus);
            this.SetParamSimple(map, prefix + "Isolate", this.Isolate);
            this.SetParamArrayObj(map, prefix + "Metadatas.", this.Metadatas);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamObj(map, prefix + "Location.", this.Location);
        }
    }
}

