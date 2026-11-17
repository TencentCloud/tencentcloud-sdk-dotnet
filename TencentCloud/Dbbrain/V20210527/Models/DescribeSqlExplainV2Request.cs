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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSqlExplainV2Request : AbstractModel
    {
        
        /// <summary>
        /// <p>服务产品类型。取值：mysql（云数据库 MySQL）、cynosdb（TDSQL-C MySQL 版）、dcdb（TDSQL MySQL 版）、mariadb（TDSQL MariaDB 版）。</p>
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// <p>待分析的 SQL 语句。仅支持单条 SELECT 语句；若以 EXPLAIN 开头会自动剥离 EXPLAIN 前缀后分析。最大 4096 字符。</p>
        /// </summary>
        [JsonProperty("SqlText")]
        public string SqlText{ get; set; }

        /// <summary>
        /// <p>实例 ID。MySQL: cdb-xxxxxxx，TDSQL-C: cynosdbmysql-ins-xxxxxxx，MariaDB: tdsql-xxxxx，TDSQL-MySQL： '集群id&amp;分片id',如果TDSQL-MySQL数据库类型同时传入了集群id则instanceId字段只需要传入分片id。最大 64 字符。与 ClusterId 至少需传入其一。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>数据库名。可选；为空时按当前 SQL 上下文执行。最大 64 字符。</p>
        /// </summary>
        [JsonProperty("Schema")]
        public string Schema{ get; set; }

        /// <summary>
        /// <p>集群 ID。仅 TDSQL-MySQL时使用，与 InstanceId 至少需传入其一。最大 64 字符。</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>是否输出可视化执行树</p><p>默认值：false</p>
        /// </summary>
        [JsonProperty("Visual")]
        public bool? Visual{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamSimple(map, prefix + "SqlText", this.SqlText);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Schema", this.Schema);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Visual", this.Visual);
        }
    }
}

