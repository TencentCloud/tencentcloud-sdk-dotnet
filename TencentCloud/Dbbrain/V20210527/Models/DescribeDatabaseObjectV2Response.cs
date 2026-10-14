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

    public class DescribeDatabaseObjectV2Response : AbstractModel
    {
        
        /// <summary>
        /// <p>索引 DDL 列表，每项为一条 CREATE INDEX 语句，无索引时为空数组。</p>
        /// </summary>
        [JsonProperty("IndexDDLs")]
        public IndexDDLInfo[] IndexDDLs{ get; set; }

        /// <summary>
        /// <p>建表 DDL 语句，对象不存在时为空串。</p>
        /// </summary>
        [JsonProperty("TableDDL")]
        public string TableDDL{ get; set; }

        /// <summary>
        /// <p>表名。</p>
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// <p>库名。</p>
        /// </summary>
        [JsonProperty("TableSchema")]
        public string TableSchema{ get; set; }

        /// <summary>
        /// <p>表空间统计。</p>
        /// </summary>
        [JsonProperty("TableStatistics")]
        public TableStatistics TableStatistics{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "IndexDDLs.", this.IndexDDLs);
            this.SetParamSimple(map, prefix + "TableDDL", this.TableDDL);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "TableSchema", this.TableSchema);
            this.SetParamObj(map, prefix + "TableStatistics.", this.TableStatistics);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

