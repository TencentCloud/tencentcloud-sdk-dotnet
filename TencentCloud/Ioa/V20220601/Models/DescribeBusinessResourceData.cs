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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBusinessResourceData : AbstractModel
    {
        
        /// <summary>
        /// <p>业务资源id(只支持32位)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceId")]
        public long? ServiceId{ get; set; }

        /// <summary>
        /// <p>业务资源名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// <p>资源类型:ip,domain,ip_section，对应ip，域名，ip段</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// <p>业务资源地址</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceAddress")]
        public string ServiceAddress{ get; set; }

        /// <summary>
        /// <p>业务资源端口 all,1-65535</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServicePort")]
        public string ServicePort{ get; set; }

        /// <summary>
        /// <p>业务资源创建时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>业务资源最后修改时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>说明字段</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>资源模块ID(只支持32位)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AreaId")]
        public long? AreaId{ get; set; }

        /// <summary>
        /// <p>零信任网关id(只支持32位)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SmartGateIds")]
        public long?[] SmartGateIds{ get; set; }

        /// <summary>
        /// <p>业务资源协议类型,3：所有,2：UDP，1：TCP(只支持32位)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Protocol")]
        public long? Protocol{ get; set; }

        /// <summary>
        /// <p>业务资源等级(只支持32位)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Levels")]
        public long? Levels{ get; set; }

        /// <summary>
        /// <p>零信任网关名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SmartGateNames")]
        public string SmartGateNames{ get; set; }

        /// <summary>
        /// <p>网关连通性(只支持32位)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DirectConn")]
        public long? DirectConn{ get; set; }

        /// <summary>
        /// <p>网关连通性状态(只支持32位)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DetectState")]
        public long? DetectState{ get; set; }

        /// <summary>
        /// <p>网关连通性信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DetectInfo")]
        public string DetectInfo{ get; set; }

        /// <summary>
        /// <p>网关连通性创建时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DetectTime")]
        public string DetectTime{ get; set; }

        /// <summary>
        /// <p>绑定的连接器组Id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConnectorGroupId")]
        public string ConnectorGroupId{ get; set; }

        /// <summary>
        /// <p>绑定的连接器组的名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConnectorGroupName")]
        public string ConnectorGroupName{ get; set; }

        /// <summary>
        /// <p>资源连通性可达最后的检测时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReachableTime")]
        public string ReachableTime{ get; set; }

        /// <summary>
        /// <p>资源连通性可达状态,0：未检测，1：未连通，2：已连通</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReachableState")]
        public long? ReachableState{ get; set; }

        /// <summary>
        /// <p>访问类型:0-NGN 1-web(只支持32位)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccessType")]
        public long? AccessType{ get; set; }

        /// <summary>
        /// <p>web资源-后端协议</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BackendScheme")]
        public string BackendScheme{ get; set; }

        /// <summary>
        /// <p>web资源-后端路径</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BackendPath")]
        public string BackendPath{ get; set; }

        /// <summary>
        /// <p>web资源-前端协议</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrontScheme")]
        public string FrontScheme{ get; set; }

        /// <summary>
        /// <p>web资源-前端host</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrontHost")]
        public string FrontHost{ get; set; }

        /// <summary>
        /// <p>web资源-前端host(只支持32位)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrontPort")]
        public long? FrontPort{ get; set; }

        /// <summary>
        /// <p>web资源-前端路径 默认&quot;/&quot;</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrontPath")]
        public string FrontPath{ get; set; }

        /// <summary>
        /// <p>web资源-是否禁用外网访问：0-可通过外网访问 1-不能通过外网访问(只支持32位)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DisableFront")]
        public long? DisableFront{ get; set; }

        /// <summary>
        /// <p>web资源-租户自定义域名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomDomain")]
        public string CustomDomain{ get; set; }

        /// <summary>
        /// <p>web资源-自定义host</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomHost")]
        public string CustomHost{ get; set; }

        /// <summary>
        /// <p>web资源-Cname状态(只支持32位)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CnameStatus")]
        public long? CnameStatus{ get; set; }

        /// <summary>
        /// <p>web资源-关联证书ID(只支持32位)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertificateId")]
        public long? CertificateId{ get; set; }

        /// <summary>
        /// <p>web资源类型：0-应用 1-API(只支持32位)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WebGwResourceType")]
        public long? WebGwResourceType{ get; set; }

        /// <summary>
        /// <p>web资源-如果选择API类型资源，则需要配置密钥(只支持32位)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("APISecretId")]
        public long? APISecretId{ get; set; }

        /// <summary>
        /// <p>所属资源组名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AreaName")]
        public string AreaName{ get; set; }

        /// <summary>
        /// <p>web资源-前端协议是HTTPS类型，需要配置证书</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SSLCertId")]
        public string SSLCertId{ get; set; }

        /// <summary>
        /// <p>web资源-是否启用依赖地址：0-不启用 1-启用(只支持32位)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableDependentAddr")]
        public long? EnableDependentAddr{ get; set; }

        /// <summary>
        /// <p>web资源-依赖地址的后端服务器地址</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DependentAddr")]
        public string DependentAddr{ get; set; }

        /// <summary>
        /// <p>web免鉴权：1-鉴权 2-免鉴权</p>
        /// </summary>
        [JsonProperty("WebGwNoAuth")]
        public long? WebGwNoAuth{ get; set; }

        /// <summary>
        /// <p>通道类型</p><p>枚举值：</p><ul><li>vpc： vpc类型</li><li>native： 专线类型</li></ul><p>默认值：native</p>
        /// </summary>
        [JsonProperty("ConnectorGroupType")]
        public string ConnectorGroupType{ get; set; }

        /// <summary>
        /// <p>域名后缀</p>
        /// </summary>
        [JsonProperty("DomainSuffix")]
        public string DomainSuffix{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "ServiceAddress", this.ServiceAddress);
            this.SetParamSimple(map, prefix + "ServicePort", this.ServicePort);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "AreaId", this.AreaId);
            this.SetParamArraySimple(map, prefix + "SmartGateIds.", this.SmartGateIds);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Levels", this.Levels);
            this.SetParamSimple(map, prefix + "SmartGateNames", this.SmartGateNames);
            this.SetParamSimple(map, prefix + "DirectConn", this.DirectConn);
            this.SetParamSimple(map, prefix + "DetectState", this.DetectState);
            this.SetParamSimple(map, prefix + "DetectInfo", this.DetectInfo);
            this.SetParamSimple(map, prefix + "DetectTime", this.DetectTime);
            this.SetParamSimple(map, prefix + "ConnectorGroupId", this.ConnectorGroupId);
            this.SetParamSimple(map, prefix + "ConnectorGroupName", this.ConnectorGroupName);
            this.SetParamSimple(map, prefix + "ReachableTime", this.ReachableTime);
            this.SetParamSimple(map, prefix + "ReachableState", this.ReachableState);
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamSimple(map, prefix + "BackendScheme", this.BackendScheme);
            this.SetParamSimple(map, prefix + "BackendPath", this.BackendPath);
            this.SetParamSimple(map, prefix + "FrontScheme", this.FrontScheme);
            this.SetParamSimple(map, prefix + "FrontHost", this.FrontHost);
            this.SetParamSimple(map, prefix + "FrontPort", this.FrontPort);
            this.SetParamSimple(map, prefix + "FrontPath", this.FrontPath);
            this.SetParamSimple(map, prefix + "DisableFront", this.DisableFront);
            this.SetParamSimple(map, prefix + "CustomDomain", this.CustomDomain);
            this.SetParamSimple(map, prefix + "CustomHost", this.CustomHost);
            this.SetParamSimple(map, prefix + "CnameStatus", this.CnameStatus);
            this.SetParamSimple(map, prefix + "CertificateId", this.CertificateId);
            this.SetParamSimple(map, prefix + "WebGwResourceType", this.WebGwResourceType);
            this.SetParamSimple(map, prefix + "APISecretId", this.APISecretId);
            this.SetParamSimple(map, prefix + "AreaName", this.AreaName);
            this.SetParamSimple(map, prefix + "SSLCertId", this.SSLCertId);
            this.SetParamSimple(map, prefix + "EnableDependentAddr", this.EnableDependentAddr);
            this.SetParamSimple(map, prefix + "DependentAddr", this.DependentAddr);
            this.SetParamSimple(map, prefix + "WebGwNoAuth", this.WebGwNoAuth);
            this.SetParamSimple(map, prefix + "ConnectorGroupType", this.ConnectorGroupType);
            this.SetParamSimple(map, prefix + "DomainSuffix", this.DomainSuffix);
        }
    }
}

