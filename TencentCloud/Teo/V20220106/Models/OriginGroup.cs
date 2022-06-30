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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OriginGroup : AbstractModel
    {
        
        /// <summary>
        /// 源站组ID
        /// </summary>
        [JsonProperty("OriginId")]
        public string OriginId{ get; set; }

        /// <summary>
        /// 源站组名称
        /// </summary>
        [JsonProperty("OriginName")]
        public string OriginName{ get; set; }

        /// <summary>
        /// 源站组配置类型
        /// area：表示按照Record记录中的Area字段进行按客户端IP所在区域回源。
        /// weight：表示按照Record记录中的Weight字段进行按权重回源。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 记录
        /// </summary>
        [JsonProperty("Record")]
        public OriginRecord[] Record{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 站点ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// 源站类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// 当前源站组是否被四层代理使用。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplicationProxyUsed")]
        public bool? ApplicationProxyUsed{ get; set; }

        /// <summary>
        /// 当前源站组是否被负载均衡使用。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoadBalancingUsed")]
        public bool? LoadBalancingUsed{ get; set; }

        /// <summary>
        /// 源站状态信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public OriginCheckOriginStatus Status{ get; set; }

        /// <summary>
        /// 使用当前源站组的负载均衡的类型：
        /// none：未被使用
        /// dns_only：被仅DNS类型负载均衡使用
        /// proxied：被代理加速类型负载均衡使用
        /// both：同时被仅DNS和代理加速类型负载均衡使用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoadBalancingUsedType")]
        public string LoadBalancingUsedType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OriginId", this.OriginId);
            this.SetParamSimple(map, prefix + "OriginName", this.OriginName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "Record.", this.Record);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "OriginType", this.OriginType);
            this.SetParamSimple(map, prefix + "ApplicationProxyUsed", this.ApplicationProxyUsed);
            this.SetParamSimple(map, prefix + "LoadBalancingUsed", this.LoadBalancingUsed);
            this.SetParamObj(map, prefix + "Status.", this.Status);
            this.SetParamSimple(map, prefix + "LoadBalancingUsedType", this.LoadBalancingUsedType);
        }
    }
}

