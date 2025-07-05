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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyUpstreamResultInfo : AbstractModel
    {
        
        /// <summary>
        /// 后端通道唯一ID
        /// </summary>
        [JsonProperty("UpstreamId")]
        public string UpstreamId{ get; set; }

        /// <summary>
        /// 后端通道名字
        /// </summary>
        [JsonProperty("UpstreamName")]
        public string UpstreamName{ get; set; }

        /// <summary>
        /// 后端通道描述
        /// </summary>
        [JsonProperty("UpstreamDescription")]
        public string UpstreamDescription{ get; set; }

        /// <summary>
        /// 后端协议，取值范围：HTTP, HTTPS
        /// </summary>
        [JsonProperty("Scheme")]
        public string Scheme{ get; set; }

        /// <summary>
        /// 负载均衡算法，取值范围：ROUND_ROBIN
        /// </summary>
        [JsonProperty("Algorithm")]
        public string Algorithm{ get; set; }

        /// <summary>
        /// VPC唯一ID
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// 请求重试次数
        /// </summary>
        [JsonProperty("Retries")]
        public ulong? Retries{ get; set; }

        /// <summary>
        /// 后端节点
        /// </summary>
        [JsonProperty("Nodes")]
        public UpstreamNode[] Nodes{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 健康检查配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HealthChecker")]
        public UpstreamHealthChecker HealthChecker{ get; set; }

        /// <summary>
        /// 后端的类型，取值范围：IP_PORT, K8S
        /// </summary>
        [JsonProperty("UpstreamType")]
        public string UpstreamType{ get; set; }

        /// <summary>
        /// K8S容器服务配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("K8sServices")]
        public K8sService[] K8sServices{ get; set; }

        /// <summary>
        /// 网关转发给后端的Host请求头
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpstreamHost")]
        public string UpstreamHost{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UpstreamId", this.UpstreamId);
            this.SetParamSimple(map, prefix + "UpstreamName", this.UpstreamName);
            this.SetParamSimple(map, prefix + "UpstreamDescription", this.UpstreamDescription);
            this.SetParamSimple(map, prefix + "Scheme", this.Scheme);
            this.SetParamSimple(map, prefix + "Algorithm", this.Algorithm);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "Retries", this.Retries);
            this.SetParamArrayObj(map, prefix + "Nodes.", this.Nodes);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamObj(map, prefix + "HealthChecker.", this.HealthChecker);
            this.SetParamSimple(map, prefix + "UpstreamType", this.UpstreamType);
            this.SetParamArrayObj(map, prefix + "K8sServices.", this.K8sServices);
            this.SetParamSimple(map, prefix + "UpstreamHost", this.UpstreamHost);
        }
    }
}

