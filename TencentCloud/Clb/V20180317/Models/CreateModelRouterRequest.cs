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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateModelRouterRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>模型路由类型</p><p>枚举值：</p><ul><li>Shared： 共享型</li><li>Enterprise： 企业级</li></ul>
        /// </summary>
        [JsonProperty("ModelRouterType")]
        public string ModelRouterType{ get; set; }

        /// <summary>
        /// <p>关联的积分预算ID</p>
        /// </summary>
        [JsonProperty("BudgetId")]
        public string BudgetId{ get; set; }

        /// <summary>
        /// <p>证书ID</p><p>入参限制：当Schema为HTTPS时，该参数必传</p>
        /// </summary>
        [JsonProperty("CertId")]
        public string CertId{ get; set; }

        /// <summary>
        /// <p>集群信息</p>
        /// </summary>
        [JsonProperty("ClusterInfo")]
        public ClusterInfo ClusterInfo{ get; set; }

        /// <summary>
        /// <p>模型路由实例名称</p><p>默认值：-</p>
        /// </summary>
        [JsonProperty("ModelRouterName")]
        public string ModelRouterName{ get; set; }

        /// <summary>
        /// <p>网络类型</p><p>枚举值：</p><ul><li>Internet： 公网</li><li>Intranet： 内网</li></ul>
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// <p>模型路由的监听端口</p><p>取值范围：[1, 65535]</p>
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// <p>限速配置</p>
        /// </summary>
        [JsonProperty("RateLimitConfig")]
        public RateLimitConfigForModelRouter RateLimitConfig{ get; set; }

        /// <summary>
        /// <p>路由配置</p>
        /// </summary>
        [JsonProperty("RouterSetting")]
        public RouterSettingWithoutFallBack RouterSetting{ get; set; }

        /// <summary>
        /// <p>模型路由实例的网络协议</p><p>枚举值：</p><ul><li>HTTP： HTTP协议</li><li>HTTPS： HTTPS协议</li></ul>
        /// </summary>
        [JsonProperty("Schema")]
        public string Schema{ get; set; }

        /// <summary>
        /// <p>模型路由实例所属子网的ID</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>标签</p>
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// <p>模型路由实例所属VPC的ID</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelRouterType", this.ModelRouterType);
            this.SetParamSimple(map, prefix + "BudgetId", this.BudgetId);
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
            this.SetParamObj(map, prefix + "ClusterInfo.", this.ClusterInfo);
            this.SetParamSimple(map, prefix + "ModelRouterName", this.ModelRouterName);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamObj(map, prefix + "RateLimitConfig.", this.RateLimitConfig);
            this.SetParamObj(map, prefix + "RouterSetting.", this.RouterSetting);
            this.SetParamSimple(map, prefix + "Schema", this.Schema);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
        }
    }
}

