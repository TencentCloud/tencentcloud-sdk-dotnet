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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MigrateSource : AbstractModel
    {
        
        /// <summary>
        /// 迁移源实例的ID，MigrateType=1(CDB for SQLServers)时使用，格式如：mssql-si2823jyl
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 迁移源Cvm的ID，MigrateType=2(云服务器自建SQLServer数据库)时使用
        /// </summary>
        [JsonProperty("CvmId")]
        public string CvmId{ get; set; }

        /// <summary>
        /// 迁移源Cvm的Vpc网络标识，MigrateType=2(云服务器自建SQLServer数据库)时使用，格式如：vpc-6ys9ont9
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 迁移源Cvm的Vpc下的子网标识，MigrateType=2(云服务器自建SQLServer数据库)时使用，格式如：subnet-h9extioi
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 用户名，MigrateType=1或MigrateType=2使用
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 密码，MigrateType=1或MigrateType=2使用
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 迁移源Cvm自建库的内网IP，MigrateType=2(云服务器自建SQLServer数据库)时使用
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 迁移源Cvm自建库的端口号，MigrateType=2(云服务器自建SQLServer数据库)时使用
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// 离线迁移的源备份地址，MigrateType=4或MigrateType=5使用
        /// </summary>
        [JsonProperty("Url")]
        public string[] Url{ get; set; }

        /// <summary>
        /// 离线迁移的源备份密码，MigrateType=4或MigrateType=5使用
        /// </summary>
        [JsonProperty("UrlPassword")]
        public string UrlPassword{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "CvmId", this.CvmId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamArraySimple(map, prefix + "Url.", this.Url);
            this.SetParamSimple(map, prefix + "UrlPassword", this.UrlPassword);
        }
    }
}

