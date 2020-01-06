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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DomainRuleSet : AbstractModel
    {
        
        /// <summary>
        /// 转发规则域名。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 该域名对应的转发规则列表。
        /// </summary>
        [JsonProperty("RuleSet")]
        public RuleInfo[] RuleSet{ get; set; }

        /// <summary>
        /// 该域名对应的服务器证书ID，值为default时，表示使用默认证书（监听器配置的证书）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }

        /// <summary>
        /// 该域名对应服务器证书名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertificateAlias")]
        public string CertificateAlias{ get; set; }

        /// <summary>
        /// 该域名对应的客户端证书ID，值为default时，表示使用默认证书（监听器配置的证书）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClientCertificateId")]
        public string ClientCertificateId{ get; set; }

        /// <summary>
        /// 该域名对应客户端证书名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClientCertificateAlias")]
        public string ClientCertificateAlias{ get; set; }

        /// <summary>
        /// 该域名对应基础认证配置ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BasicAuthConfId")]
        public string BasicAuthConfId{ get; set; }

        /// <summary>
        /// 基础认证开关，其中：
        /// 0，表示未开启；
        /// 1，表示已开启。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BasicAuth")]
        public long? BasicAuth{ get; set; }

        /// <summary>
        /// 该域名对应基础认证配置名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BasicAuthConfAlias")]
        public string BasicAuthConfAlias{ get; set; }

        /// <summary>
        /// 该域名对应源站认证证书ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealServerCertificateId")]
        public string RealServerCertificateId{ get; set; }

        /// <summary>
        /// 源站认证开关，其中：
        /// 0，表示未开启；
        /// 1，表示已开启。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealServerAuth")]
        public long? RealServerAuth{ get; set; }

        /// <summary>
        /// 该域名对应源站认证证书名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealServerCertificateAlias")]
        public string RealServerCertificateAlias{ get; set; }

        /// <summary>
        /// 该域名对应通道认证证书ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GaapCertificateId")]
        public string GaapCertificateId{ get; set; }

        /// <summary>
        /// 通道认证开关，其中：
        /// 0，表示未开启；
        /// 1，表示已开启。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GaapAuth")]
        public long? GaapAuth{ get; set; }

        /// <summary>
        /// 该域名对应通道认证证书名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GaapCertificateAlias")]
        public string GaapCertificateAlias{ get; set; }

        /// <summary>
        /// 源站认证域名。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealServerCertificateDomain")]
        public string RealServerCertificateDomain{ get; set; }

        /// <summary>
        /// 多客户端证书时，返回多个证书的id和别名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PolyClientCertificateAliasInfo")]
        public CertificateAliasInfo[] PolyClientCertificateAliasInfo{ get; set; }

        /// <summary>
        /// 多源站证书时，返回多个证书的id和别名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PolyRealServerCertificateAliasInfo")]
        public CertificateAliasInfo[] PolyRealServerCertificateAliasInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamArrayObj(map, prefix + "RuleSet.", this.RuleSet);
            this.SetParamSimple(map, prefix + "CertificateId", this.CertificateId);
            this.SetParamSimple(map, prefix + "CertificateAlias", this.CertificateAlias);
            this.SetParamSimple(map, prefix + "ClientCertificateId", this.ClientCertificateId);
            this.SetParamSimple(map, prefix + "ClientCertificateAlias", this.ClientCertificateAlias);
            this.SetParamSimple(map, prefix + "BasicAuthConfId", this.BasicAuthConfId);
            this.SetParamSimple(map, prefix + "BasicAuth", this.BasicAuth);
            this.SetParamSimple(map, prefix + "BasicAuthConfAlias", this.BasicAuthConfAlias);
            this.SetParamSimple(map, prefix + "RealServerCertificateId", this.RealServerCertificateId);
            this.SetParamSimple(map, prefix + "RealServerAuth", this.RealServerAuth);
            this.SetParamSimple(map, prefix + "RealServerCertificateAlias", this.RealServerCertificateAlias);
            this.SetParamSimple(map, prefix + "GaapCertificateId", this.GaapCertificateId);
            this.SetParamSimple(map, prefix + "GaapAuth", this.GaapAuth);
            this.SetParamSimple(map, prefix + "GaapCertificateAlias", this.GaapCertificateAlias);
            this.SetParamSimple(map, prefix + "RealServerCertificateDomain", this.RealServerCertificateDomain);
            this.SetParamArrayObj(map, prefix + "PolyClientCertificateAliasInfo.", this.PolyClientCertificateAliasInfo);
            this.SetParamArrayObj(map, prefix + "PolyRealServerCertificateAliasInfo.", this.PolyRealServerCertificateAliasInfo);
        }
    }
}

