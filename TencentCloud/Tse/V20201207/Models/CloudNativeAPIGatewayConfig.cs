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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloudNativeAPIGatewayConfig : AbstractModel
    {
        
        /// <summary>
        /// 控制台类型。
        /// </summary>
        [JsonProperty("ConsoleType")]
        public string ConsoleType{ get; set; }

        /// <summary>
        /// HTTP链接地址。
        /// </summary>
        [JsonProperty("HttpUrl")]
        public string HttpUrl{ get; set; }

        /// <summary>
        /// HTTPS链接地址。
        /// </summary>
        [JsonProperty("HttpsUrl")]
        public string HttpsUrl{ get; set; }

        /// <summary>
        /// 网络类型, Open|Internal。
        /// </summary>
        [JsonProperty("NetType")]
        public string NetType{ get; set; }

        /// <summary>
        /// 管理员用户名。
        /// </summary>
        [JsonProperty("AdminUser")]
        public string AdminUser{ get; set; }

        /// <summary>
        /// 管理员密码。
        /// </summary>
        [JsonProperty("AdminPassword")]
        public string AdminPassword{ get; set; }

        /// <summary>
        /// 网络状态, Open|Closed|Updating
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 网络访问策略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccessControl")]
        public NetworkAccessControl AccessControl{ get; set; }

        /// <summary>
        /// 内网子网 ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 内网VPC ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 负载均衡的描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 负载均衡的规格类型
        /// </summary>
        [JsonProperty("SlaType")]
        public string SlaType{ get; set; }

        /// <summary>
        /// clb规格名称
        /// </summary>
        [JsonProperty("SlaName")]
        public string SlaName{ get; set; }

        /// <summary>
        /// clb vip
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// 带宽
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public ulong? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// 是否多可用区
        /// </summary>
        [JsonProperty("MultiZoneFlag")]
        public bool? MultiZoneFlag{ get; set; }

        /// <summary>
        /// 主可用区
        /// </summary>
        [JsonProperty("MasterZoneId")]
        public string MasterZoneId{ get; set; }

        /// <summary>
        /// 备可用区
        /// </summary>
        [JsonProperty("SlaveZoneId")]
        public string SlaveZoneId{ get; set; }

        /// <summary>
        /// 主可用区名称
        /// </summary>
        [JsonProperty("MasterZoneName")]
        public string MasterZoneName{ get; set; }

        /// <summary>
        /// 备可用区名称
        /// </summary>
        [JsonProperty("SlaveZoneName")]
        public string SlaveZoneName{ get; set; }

        /// <summary>
        /// 网络 id
        /// </summary>
        [JsonProperty("NetworkId")]
        public string NetworkId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConsoleType", this.ConsoleType);
            this.SetParamSimple(map, prefix + "HttpUrl", this.HttpUrl);
            this.SetParamSimple(map, prefix + "HttpsUrl", this.HttpsUrl);
            this.SetParamSimple(map, prefix + "NetType", this.NetType);
            this.SetParamSimple(map, prefix + "AdminUser", this.AdminUser);
            this.SetParamSimple(map, prefix + "AdminPassword", this.AdminPassword);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "AccessControl.", this.AccessControl);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "SlaType", this.SlaType);
            this.SetParamSimple(map, prefix + "SlaName", this.SlaName);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "MultiZoneFlag", this.MultiZoneFlag);
            this.SetParamSimple(map, prefix + "MasterZoneId", this.MasterZoneId);
            this.SetParamSimple(map, prefix + "SlaveZoneId", this.SlaveZoneId);
            this.SetParamSimple(map, prefix + "MasterZoneName", this.MasterZoneName);
            this.SetParamSimple(map, prefix + "SlaveZoneName", this.SlaveZoneName);
            this.SetParamSimple(map, prefix + "NetworkId", this.NetworkId);
        }
    }
}

