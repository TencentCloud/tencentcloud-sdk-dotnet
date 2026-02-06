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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloudBaseGWService : AbstractModel
    {
        
        /// <summary>
        /// 服务ID
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// 服务域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 开启时间
        /// </summary>
        [JsonProperty("OpenTime")]
        public ulong? OpenTime{ get; set; }

        /// <summary>
        /// 绑定状态，1 绑定中；2绑定失败；3绑定成功
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 是否被抢占, 被抢占表示域名被其他环境绑定了，需要解绑或者重新绑定。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsPreempted")]
        public bool? IsPreempted{ get; set; }

        /// <summary>
        /// 是否开启多地域
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableRegion")]
        public bool? EnableRegion{ get; set; }

        /// <summary>
        /// cdn CName地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Cname")]
        public string Cname{ get; set; }

        /// <summary>
        /// 统一域名状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnionStatus")]
        public long? UnionStatus{ get; set; }

        /// <summary>
        /// CName状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CnameStatus")]
        public long? CnameStatus{ get; set; }

        /// <summary>
        /// 证书Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertId")]
        public string CertId{ get; set; }

        /// <summary>
        /// 是否强制https
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ForceHttps")]
        public bool? ForceHttps{ get; set; }

        /// <summary>
        /// icp黑名单封禁状态，0-未封禁，1-封禁
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IcpForbidStatus")]
        public long? IcpForbidStatus{ get; set; }

        /// <summary>
        /// 自定义路由规则
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomRoutingRules")]
        public string CustomRoutingRules{ get; set; }

        /// <summary>
        /// 绑定类型，1绑定cdn，2源站，4自定义
        /// </summary>
        [JsonProperty("BindFlag")]
        public ulong? BindFlag{ get; set; }

        /// <summary>
        /// TcbIngress源站cname
        /// </summary>
        [JsonProperty("OriginCname")]
        public string OriginCname{ get; set; }

        /// <summary>
        /// 自定义cname
        /// </summary>
        [JsonProperty("CustomCname")]
        public string CustomCname{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "OpenTime", this.OpenTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "IsPreempted", this.IsPreempted);
            this.SetParamSimple(map, prefix + "EnableRegion", this.EnableRegion);
            this.SetParamSimple(map, prefix + "Cname", this.Cname);
            this.SetParamSimple(map, prefix + "UnionStatus", this.UnionStatus);
            this.SetParamSimple(map, prefix + "CnameStatus", this.CnameStatus);
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
            this.SetParamSimple(map, prefix + "ForceHttps", this.ForceHttps);
            this.SetParamSimple(map, prefix + "IcpForbidStatus", this.IcpForbidStatus);
            this.SetParamSimple(map, prefix + "CustomRoutingRules", this.CustomRoutingRules);
            this.SetParamSimple(map, prefix + "BindFlag", this.BindFlag);
            this.SetParamSimple(map, prefix + "OriginCname", this.OriginCname);
            this.SetParamSimple(map, prefix + "CustomCname", this.CustomCname);
        }
    }
}

