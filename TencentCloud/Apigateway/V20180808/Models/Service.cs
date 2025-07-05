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

    public class Service : AbstractModel
    {
        
        /// <summary>
        /// 内网访问https端口。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InnerHttpsPort")]
        public long? InnerHttpsPort{ get; set; }

        /// <summary>
        /// 用户自定义的服务描述。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceDesc")]
        public string ServiceDesc{ get; set; }

        /// <summary>
        /// 服务的前端请求类型。如http、https 或者 http&https。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 最后修改时间。按照 ISO8601 标准表示，并且使用 UTC 时间。格式为：YYYY-MM-DDThh:mm:ssZ。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModifiedTime")]
        public string ModifiedTime{ get; set; }

        /// <summary>
        /// 服务支持的网络类型。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NetTypes")]
        public string[] NetTypes{ get; set; }

        /// <summary>
        /// 独占集群名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExclusiveSetName")]
        public string ExclusiveSetName{ get; set; }

        /// <summary>
        /// 服务唯一 ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// IP版本。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpVersion")]
        public string IpVersion{ get; set; }

        /// <summary>
        /// 已经发布的环境列表。如test、prepub、release。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AvailableEnvironments")]
        public string[] AvailableEnvironments{ get; set; }

        /// <summary>
        /// 用户自定义的服务名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// 系统为该服务分配的外网域名。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OuterSubDomain")]
        public string OuterSubDomain{ get; set; }

        /// <summary>
        /// 创建时间。按照 ISO8601 标准表示，并且使用 UTC 时间。格式为：YYYY-MM-DDThh:mm:ssZ。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 内网访问http端口。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InnerHttpPort")]
        public ulong? InnerHttpPort{ get; set; }

        /// <summary>
        /// 系统为该服务自动分配的内网域名。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InnerSubDomain")]
        public string InnerSubDomain{ get; set; }

        /// <summary>
        /// 服务的计费状态。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TradeIsolateStatus")]
        public long? TradeIsolateStatus{ get; set; }

        /// <summary>
        /// 服务绑定的标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 独享实例
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 集群类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SetType")]
        public string SetType{ get; set; }

        /// <summary>
        /// 服务部署的集群类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeploymentType")]
        public string DeploymentType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InnerHttpsPort", this.InnerHttpsPort);
            this.SetParamSimple(map, prefix + "ServiceDesc", this.ServiceDesc);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "ModifiedTime", this.ModifiedTime);
            this.SetParamArraySimple(map, prefix + "NetTypes.", this.NetTypes);
            this.SetParamSimple(map, prefix + "ExclusiveSetName", this.ExclusiveSetName);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "IpVersion", this.IpVersion);
            this.SetParamArraySimple(map, prefix + "AvailableEnvironments.", this.AvailableEnvironments);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "OuterSubDomain", this.OuterSubDomain);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "InnerHttpPort", this.InnerHttpPort);
            this.SetParamSimple(map, prefix + "InnerSubDomain", this.InnerSubDomain);
            this.SetParamSimple(map, prefix + "TradeIsolateStatus", this.TradeIsolateStatus);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "SetType", this.SetType);
            this.SetParamSimple(map, prefix + "DeploymentType", this.DeploymentType);
        }
    }
}

