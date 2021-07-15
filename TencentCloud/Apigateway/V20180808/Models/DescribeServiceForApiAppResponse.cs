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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeServiceForApiAppResponse : AbstractModel
    {
        
        /// <summary>
        /// 服务唯一ID。
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// 服务 环境列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AvailableEnvironments")]
        public string[] AvailableEnvironments{ get; set; }

        /// <summary>
        /// 服务名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// 服务描述。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceDesc")]
        public string ServiceDesc{ get; set; }

        /// <summary>
        /// 服务支持协议，可选值为http、https、http&https。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 服务创建时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 服务修改时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModifiedTime")]
        public string ModifiedTime{ get; set; }

        /// <summary>
        /// 独立集群名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExclusiveSetName")]
        public string ExclusiveSetName{ get; set; }

        /// <summary>
        /// 网络类型列表，INNER为内网访问，OUTER为外网访问。
        /// </summary>
        [JsonProperty("NetTypes")]
        public string[] NetTypes{ get; set; }

        /// <summary>
        /// 内网访问子域名。
        /// </summary>
        [JsonProperty("InternalSubDomain")]
        public string InternalSubDomain{ get; set; }

        /// <summary>
        /// 外网访问子域名。
        /// </summary>
        [JsonProperty("OuterSubDomain")]
        public string OuterSubDomain{ get; set; }

        /// <summary>
        /// 内网访问http服务端口号。
        /// </summary>
        [JsonProperty("InnerHttpPort")]
        public long? InnerHttpPort{ get; set; }

        /// <summary>
        /// 内网访问https端口号。
        /// </summary>
        [JsonProperty("InnerHttpsPort")]
        public long? InnerHttpsPort{ get; set; }

        /// <summary>
        /// API总数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiTotalCount")]
        public long? ApiTotalCount{ get; set; }

        /// <summary>
        /// API列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiIdStatusSet")]
        public ApiIdStatus[] ApiIdStatusSet{ get; set; }

        /// <summary>
        /// 使用计划总数量。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UsagePlanTotalCount")]
        public long? UsagePlanTotalCount{ get; set; }

        /// <summary>
        /// 使用计划数组。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UsagePlanList")]
        public UsagePlan[] UsagePlanList{ get; set; }

        /// <summary>
        /// IP版本。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpVersion")]
        public string IpVersion{ get; set; }

        /// <summary>
        /// 此服务的用户类型。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserType")]
        public string UserType{ get; set; }

        /// <summary>
        /// 预留字段。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SetId")]
        public long? SetId{ get; set; }

        /// <summary>
        /// 服务绑定的标签。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamArraySimple(map, prefix + "AvailableEnvironments.", this.AvailableEnvironments);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "ServiceDesc", this.ServiceDesc);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ModifiedTime", this.ModifiedTime);
            this.SetParamSimple(map, prefix + "ExclusiveSetName", this.ExclusiveSetName);
            this.SetParamArraySimple(map, prefix + "NetTypes.", this.NetTypes);
            this.SetParamSimple(map, prefix + "InternalSubDomain", this.InternalSubDomain);
            this.SetParamSimple(map, prefix + "OuterSubDomain", this.OuterSubDomain);
            this.SetParamSimple(map, prefix + "InnerHttpPort", this.InnerHttpPort);
            this.SetParamSimple(map, prefix + "InnerHttpsPort", this.InnerHttpsPort);
            this.SetParamSimple(map, prefix + "ApiTotalCount", this.ApiTotalCount);
            this.SetParamArrayObj(map, prefix + "ApiIdStatusSet.", this.ApiIdStatusSet);
            this.SetParamSimple(map, prefix + "UsagePlanTotalCount", this.UsagePlanTotalCount);
            this.SetParamArrayObj(map, prefix + "UsagePlanList.", this.UsagePlanList);
            this.SetParamSimple(map, prefix + "IpVersion", this.IpVersion);
            this.SetParamSimple(map, prefix + "UserType", this.UserType);
            this.SetParamSimple(map, prefix + "SetId", this.SetId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

