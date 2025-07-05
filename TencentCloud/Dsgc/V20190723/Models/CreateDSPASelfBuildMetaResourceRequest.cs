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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDSPASelfBuildMetaResourceRequest : AbstractModel
    {
        
        /// <summary>
        /// Dspa实例ID。
        /// </summary>
        [JsonProperty("DspaId")]
        public string DspaId{ get; set; }

        /// <summary>
        /// 自建数据库类型。目前支持的自建数据库类型按照协议进行区分，支持两种开源数据库协议：
        /// mysql_like_proto -- Mysql协议类关系型数据库，
        /// postgre_like_proto -- Postgre协议类关系型数据库。
        /// 其他闭源协议的数据库如SqlServer、Oracle等暂不支持。
        /// </summary>
        [JsonProperty("MetaType")]
        public string MetaType{ get; set; }

        /// <summary>
        /// 资源所处地域。
        /// </summary>
        [JsonProperty("ResourceRegion")]
        public string ResourceRegion{ get; set; }

        /// <summary>
        /// 自建云资源ID。
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 自建云资源的VPC ID。
        /// </summary>
        [JsonProperty("ResourceUniqueVpcId")]
        public string ResourceUniqueVpcId{ get; set; }

        /// <summary>
        /// 自建云资源的Subnet ID。
        /// </summary>
        [JsonProperty("ResourceUniqueSubnetId")]
        public string ResourceUniqueSubnetId{ get; set; }

        /// <summary>
        /// 自建云资源所处的服务类型，可选：
        /// cvm - 通过云服务器直接访问。
        /// clb - 通过LB的方式进行访问。
        /// </summary>
        [JsonProperty("ResourceAccessType")]
        public string ResourceAccessType{ get; set; }

        /// <summary>
        /// 可用于访问自建云资源的IP。
        /// emr的连接不需要使用该字段
        /// </summary>
        [JsonProperty("ResourceVip")]
        public string ResourceVip{ get; set; }

        /// <summary>
        /// 可用于访问自建云资源的端口。
        /// emr的连接不需要使用该字段
        /// </summary>
        [JsonProperty("ResourceVPort")]
        public ulong? ResourceVPort{ get; set; }

        /// <summary>
        /// 账户名。如果emr_hive的连接方式为“LDAP”，则复用该字段
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 账户密码。如果emr_hive的连接方式为“LDAP”，则复用该字段
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 资源名称，1-60个字符。
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// 实例类型
        /// databse
        /// sid
        /// serviceName
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 实例值
        /// </summary>
        [JsonProperty("InstanceValue")]
        public string InstanceValue{ get; set; }

        /// <summary>
        /// 授权范围（all:授权整个数据源 manual:手动指定数据库）
        /// </summary>
        [JsonProperty("AuthRange")]
        public string AuthRange{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DspaId", this.DspaId);
            this.SetParamSimple(map, prefix + "MetaType", this.MetaType);
            this.SetParamSimple(map, prefix + "ResourceRegion", this.ResourceRegion);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ResourceUniqueVpcId", this.ResourceUniqueVpcId);
            this.SetParamSimple(map, prefix + "ResourceUniqueSubnetId", this.ResourceUniqueSubnetId);
            this.SetParamSimple(map, prefix + "ResourceAccessType", this.ResourceAccessType);
            this.SetParamSimple(map, prefix + "ResourceVip", this.ResourceVip);
            this.SetParamSimple(map, prefix + "ResourceVPort", this.ResourceVPort);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceValue", this.InstanceValue);
            this.SetParamSimple(map, prefix + "AuthRange", this.AuthRange);
        }
    }
}

