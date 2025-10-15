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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccelerationDomain : AbstractModel
    {
        
        /// <summary>
        /// 站点 ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 加速域名名称。
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// 加速域名状态，取值有：
        /// <li>online：已生效；</li>
        /// <li>process：部署中；</li>
        /// <li>offline：已停用；</li>
        /// <li>forbidden：已封禁；</li>
        /// <li>init：未生效，待激活站点。</li>
        /// </summary>
        [JsonProperty("DomainStatus")]
        public string DomainStatus{ get; set; }

        /// <summary>
        /// CNAME 地址。
        /// </summary>
        [JsonProperty("Cname")]
        public string Cname{ get; set; }

        /// <summary>
        /// IPv6 状态，取值有：
        /// <li>follow：遵循站点IPv6配置；</li>
        /// <li>on：开启状态；</li>
        /// <li>off：关闭状态。</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IPv6Status")]
        public string IPv6Status{ get; set; }

        /// <summary>
        /// 加速域名归属权验证状态，取值有： 
        /// <li>pending：待验证；</li>
        /// <li>finished：已完成验证。</li>	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IdentificationStatus")]
        public string IdentificationStatus{ get; set; }

        /// <summary>
        /// 加速域名需进行归属权验证才能继续提供服务时，该对象会携带对应验证方式所需要的信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnershipVerification")]
        public OwnershipVerification OwnershipVerification{ get; set; }

        /// <summary>
        /// 源站信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginDetail")]
        public OriginDetail OriginDetail{ get; set; }

        /// <summary>
        /// 回源协议，取值有：
        /// <li>FOLLOW：协议跟随；</li>
        /// <li>HTTP：HTTP协议回源；</li>
        /// <li>HTTPS：HTTPS协议回源。</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginProtocol")]
        public string OriginProtocol{ get; set; }

        /// <summary>
        /// HTTP 回源端口。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HttpOriginPort")]
        public ulong? HttpOriginPort{ get; set; }

        /// <summary>
        /// HTTPS 回源端口。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HttpsOriginPort")]
        public ulong? HttpsOriginPort{ get; set; }

        /// <summary>
        /// 加速域名证书信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Certificate")]
        public AccelerationDomainCertificate Certificate{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// 修改时间。
        /// </summary>
        [JsonProperty("ModifiedOn")]
        public string ModifiedOn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "DomainStatus", this.DomainStatus);
            this.SetParamSimple(map, prefix + "Cname", this.Cname);
            this.SetParamSimple(map, prefix + "IPv6Status", this.IPv6Status);
            this.SetParamSimple(map, prefix + "IdentificationStatus", this.IdentificationStatus);
            this.SetParamObj(map, prefix + "OwnershipVerification.", this.OwnershipVerification);
            this.SetParamObj(map, prefix + "OriginDetail.", this.OriginDetail);
            this.SetParamSimple(map, prefix + "OriginProtocol", this.OriginProtocol);
            this.SetParamSimple(map, prefix + "HttpOriginPort", this.HttpOriginPort);
            this.SetParamSimple(map, prefix + "HttpsOriginPort", this.HttpsOriginPort);
            this.SetParamObj(map, prefix + "Certificate.", this.Certificate);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "ModifiedOn", this.ModifiedOn);
        }
    }
}

