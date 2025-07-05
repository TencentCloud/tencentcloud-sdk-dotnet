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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDatasourceConnectionRequest : AbstractModel
    {
        
        /// <summary>
        /// 连接ID列表，指定要查询的连接ID
        /// </summary>
        [JsonProperty("DatasourceConnectionIds")]
        public string[] DatasourceConnectionIds{ get; set; }

        /// <summary>
        /// 过滤条件，当前支持的过滤键为：DatasourceConnectionName（数据源连接名）。
        /// DatasourceConnectionType   （数据源连接连接类型）
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量，默认为0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认20，最大值100
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 排序字段，支持如下字段类型，create-time（默认，创建时间）、update-time（更新时间）
        /// </summary>
        [JsonProperty("SortBy")]
        public string SortBy{ get; set; }

        /// <summary>
        /// 排序方式，desc表示正序，asc表示反序， 默认为desc
        /// </summary>
        [JsonProperty("Sorting")]
        public string Sorting{ get; set; }

        /// <summary>
        /// 筛选字段：起始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 筛选字段：截止时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 连接名称列表，指定要查询的连接名称
        /// </summary>
        [JsonProperty("DatasourceConnectionNames")]
        public string[] DatasourceConnectionNames{ get; set; }

        /// <summary>
        /// 连接类型，支持Mysql/HiveCos/Kafka/DataLakeCatalog
        /// </summary>
        [JsonProperty("DatasourceConnectionTypes")]
        public string[] DatasourceConnectionTypes{ get; set; }

        /// <summary>
        /// 返回指定hive版本的数据源，该参数指定后，会过滤掉该参数指定版本以外的hive数据源，非hive数据源正常返回
        /// </summary>
        [JsonProperty("HiveVersion")]
        public string[] HiveVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DatasourceConnectionIds.", this.DatasourceConnectionIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "SortBy", this.SortBy);
            this.SetParamSimple(map, prefix + "Sorting", this.Sorting);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "DatasourceConnectionNames.", this.DatasourceConnectionNames);
            this.SetParamArraySimple(map, prefix + "DatasourceConnectionTypes.", this.DatasourceConnectionTypes);
            this.SetParamArraySimple(map, prefix + "HiveVersion.", this.HiveVersion);
        }
    }
}

