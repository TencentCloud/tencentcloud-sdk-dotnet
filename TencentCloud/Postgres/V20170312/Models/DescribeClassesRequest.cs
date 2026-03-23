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
        /// <p>可用区名称。可以通过接口<a href="https://cloud.tencent.com/document/product/409/16769">DescribeZones</a>获取。</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>数据库引擎，支持：<br>1、postgresql（云数据库PostgreSQL）；<br>2、mssql_compatible（MSSQL兼容-云数据库PostgreSQL）；</p>
        /// </summary>
        [JsonProperty("DBEngine")]
        public string DBEngine{ get; set; }

        /// <summary>
        /// <p>数据库主版本号。例如12，13，可以通过接口<a href="https://cloud.tencent.com/document/product/409/89018">DescribeDBVersions</a>获取。</p>
        /// </summary>
        [JsonProperty("DBMajorVersion")]
        public string DBMajorVersion{ get; set; }

        /// <summary>
        /// <p>实例存储类型，根据存储类型返回支持的规格。</p><p>枚举值：</p><ul><li>PHYSICAL_LOCAL_SSD： 物理机本地ssd硬盘</li><li>CLOUD_PREMIUM： 高性能云硬盘</li><li>CLOUD_SSD： ssd云硬盘</li><li>CLOUD_HSSD： 增强型ssd云硬盘</li></ul><p>默认值：PHYSICAL_LOCAL_SSD</p>
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "DBEngine", this.DBEngine);
            this.SetParamSimple(map, prefix + "DBMajorVersion", this.DBMajorVersion);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
        }
    }
}

