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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServerlessDBInstance : AbstractModel
    {
        
        /// <summary>
        /// 实例id，唯一标识符
        /// </summary>
        [JsonProperty("DBInstanceId")]
        public string DBInstanceId{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("DBInstanceName")]
        public string DBInstanceName{ get; set; }

        /// <summary>
        /// 实例状态
        /// </summary>
        [JsonProperty("DBInstanceStatus")]
        public string DBInstanceStatus{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 私有网络Id
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网id
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 字符集
        /// </summary>
        [JsonProperty("DBCharset")]
        public string DBCharset{ get; set; }

        /// <summary>
        /// 数据库版本
        /// </summary>
        [JsonProperty("DBVersion")]
        public string DBVersion{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 实例网络信息
        /// </summary>
        [JsonProperty("DBInstanceNetInfo")]
        public ServerlessDBInstanceNetInfo[] DBInstanceNetInfo{ get; set; }

        /// <summary>
        /// 实例账户信息
        /// </summary>
        [JsonProperty("DBAccountSet")]
        public ServerlessDBAccount[] DBAccountSet{ get; set; }

        /// <summary>
        /// 实例下的db信息
        /// </summary>
        [JsonProperty("DBDatabaseList")]
        public string[] DBDatabaseList{ get; set; }

        /// <summary>
        /// 实例绑定的标签数组
        /// </summary>
        [JsonProperty("TagList")]
        public Tag[] TagList{ get; set; }

        /// <summary>
        /// 数据库内核版本
        /// </summary>
        [JsonProperty("DBKernelVersion")]
        public string DBKernelVersion{ get; set; }

        /// <summary>
        /// 数据库主要版本
        /// </summary>
        [JsonProperty("DBMajorVersion")]
        public string DBMajorVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DBInstanceId", this.DBInstanceId);
            this.SetParamSimple(map, prefix + "DBInstanceName", this.DBInstanceName);
            this.SetParamSimple(map, prefix + "DBInstanceStatus", this.DBInstanceStatus);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "DBCharset", this.DBCharset);
            this.SetParamSimple(map, prefix + "DBVersion", this.DBVersion);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArrayObj(map, prefix + "DBInstanceNetInfo.", this.DBInstanceNetInfo);
            this.SetParamArrayObj(map, prefix + "DBAccountSet.", this.DBAccountSet);
            this.SetParamArraySimple(map, prefix + "DBDatabaseList.", this.DBDatabaseList);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
            this.SetParamSimple(map, prefix + "DBKernelVersion", this.DBKernelVersion);
            this.SetParamSimple(map, prefix + "DBMajorVersion", this.DBMajorVersion);
        }
    }
}

