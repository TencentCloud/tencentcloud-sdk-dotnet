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

    public class DescribeClassesRequest : AbstractModel
    {
        
        /// <summary>
        /// 可用区ID。可以通过接口DescribeZones获取。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 数据库引擎，支持：
        /// 1、postgresql（云数据库PostgreSQL）；
        /// 2、mssql_compatible（MSSQL兼容-云数据库PostgreSQL）；
        /// </summary>
        [JsonProperty("DBEngine")]
        public string DBEngine{ get; set; }

        /// <summary>
        /// 数据库主版本号。例如12，13，可以通过接口DescribeDBVersions获取。
        /// </summary>
        [JsonProperty("DBMajorVersion")]
        public string DBMajorVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "DBEngine", this.DBEngine);
            this.SetParamSimple(map, prefix + "DBMajorVersion", this.DBMajorVersion);
        }
    }
}

