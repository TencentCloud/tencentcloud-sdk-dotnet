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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IngressInfo : AbstractModel
    {
        
        /// <summary>
        /// 环境ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// ip version
        /// </summary>
        [JsonProperty("AddressIPVersion")]
        public string AddressIPVersion{ get; set; }

        /// <summary>
        /// ingress name
        /// </summary>
        [JsonProperty("IngressName")]
        public string IngressName{ get; set; }

        /// <summary>
        /// rules 配置
        /// </summary>
        [JsonProperty("Rules")]
        public IngressRule[] Rules{ get; set; }

        /// <summary>
        /// clb ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClbId")]
        public string ClbId{ get; set; }

        /// <summary>
        /// 环境namespace
        /// </summary>
        [JsonProperty("ClusterNamespace")]
        public string ClusterNamespace{ get; set; }

        /// <summary>
        /// tls 配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tls")]
        public IngressTls[] Tls{ get; set; }

        /// <summary>
        /// 环境集群ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// clb ip
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 是否混合 https，默认 false，可选值 true 代表有 https 协议监听
        /// </summary>
        [JsonProperty("Mixed")]
        public bool? Mixed{ get; set; }

        /// <summary>
        /// 重定向模式，可选值：
        /// - AUTO（自动重定向http到https）
        /// - NONE（不使用重定向）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RewriteType")]
        public string RewriteType{ get; set; }

        /// <summary>
        /// clb 域名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "AddressIPVersion", this.AddressIPVersion);
            this.SetParamSimple(map, prefix + "IngressName", this.IngressName);
            this.SetParamArrayObj(map, prefix + "Rules.", this.Rules);
            this.SetParamSimple(map, prefix + "ClbId", this.ClbId);
            this.SetParamSimple(map, prefix + "ClusterNamespace", this.ClusterNamespace);
            this.SetParamArrayObj(map, prefix + "Tls.", this.Tls);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Mixed", this.Mixed);
            this.SetParamSimple(map, prefix + "RewriteType", this.RewriteType);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
        }
    }
}

