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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Version : AbstractModel
    {
        
        /// <summary>
        /// 数据库引擎，支持：
        /// 1、postgresql（云数据库PostgreSQL）；
        /// 2、mssql_compatible（MSSQL兼容-云数据库PostgreSQL）；
        /// </summary>
        [JsonProperty("DBEngine")]
        public string DBEngine{ get; set; }

        /// <summary>
        /// 数据库版本，例如：12.4
        /// </summary>
        [JsonProperty("DBVersion")]
        public string DBVersion{ get; set; }

        /// <summary>
        /// 数据库主要版本，例如：12
        /// </summary>
        [JsonProperty("DBMajorVersion")]
        public string DBMajorVersion{ get; set; }

        /// <summary>
        /// 数据库内核版本，例如：v12.4_r1.3
        /// </summary>
        [JsonProperty("DBKernelVersion")]
        public string DBKernelVersion{ get; set; }

        /// <summary>
        /// 数据库内核支持的特性列表。例如，
        /// TDE：支持数据加密。
        /// </summary>
        [JsonProperty("SupportedFeatureNames")]
        public string[] SupportedFeatureNames{ get; set; }

        /// <summary>
        /// 数据库版本状态，包括：
        /// AVAILABLE：可用；
        /// UPGRADE_ONLY：不可创建，此版本仅可升级至高版本；
        /// DEPRECATED：已弃用。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 该数据库版本（DBKernelVersion）可以升级到的版本号列表。其中包含可升级的小版本号和可升级的大版本号（完整内核版本格式示例：v15.1_v1.6）。
        /// </summary>
        [JsonProperty("AvailableUpgradeTarget")]
        public string[] AvailableUpgradeTarget{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DBEngine", this.DBEngine);
            this.SetParamSimple(map, prefix + "DBVersion", this.DBVersion);
            this.SetParamSimple(map, prefix + "DBMajorVersion", this.DBMajorVersion);
            this.SetParamSimple(map, prefix + "DBKernelVersion", this.DBKernelVersion);
            this.SetParamArraySimple(map, prefix + "SupportedFeatureNames.", this.SupportedFeatureNames);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "AvailableUpgradeTarget.", this.AvailableUpgradeTarget);
        }
    }
}

