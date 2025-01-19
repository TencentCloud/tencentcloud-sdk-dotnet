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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSlowQueryRecordsRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 慢查询时间
        /// </summary>
        [JsonProperty("QueryDurationMs")]
        public long? QueryDurationMs{ get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 分页
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 分页
        /// </summary>
        [JsonProperty("PageNum")]
        public long? PageNum{ get; set; }

        /// <summary>
        /// 排序参数
        /// </summary>
        [JsonProperty("DurationMs")]
        public string DurationMs{ get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty("DbName")]
        public string[] DbName{ get; set; }

        /// <summary>
        /// 是否是查询，0：否， 1：是
        /// </summary>
        [JsonProperty("IsQuery")]
        public long? IsQuery{ get; set; }

        /// <summary>
        /// catalog名称
        /// </summary>
        [JsonProperty("CatalogName")]
        public string[] CatalogName{ get; set; }

        /// <summary>
        /// sql名
        /// </summary>
        [JsonProperty("Sql")]
        public string Sql{ get; set; }

        /// <summary>
        /// ReadRows排序字段
        /// </summary>
        [JsonProperty("ReadRows")]
        public string ReadRows{ get; set; }

        /// <summary>
        /// ResultBytes排序字段
        /// </summary>
        [JsonProperty("ResultBytes")]
        public string ResultBytes{ get; set; }

        /// <summary>
        /// MemoryUsage排序字段
        /// </summary>
        [JsonProperty("MemoryUsage")]
        public string MemoryUsage{ get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        [JsonProperty("SortField")]
        public string SortField{ get; set; }

        /// <summary>
        /// 排序方式
        /// </summary>
        [JsonProperty("SortOrder")]
        public string SortOrder{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "QueryDurationMs", this.QueryDurationMs);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageNum", this.PageNum);
            this.SetParamSimple(map, prefix + "DurationMs", this.DurationMs);
            this.SetParamArraySimple(map, prefix + "DbName.", this.DbName);
            this.SetParamSimple(map, prefix + "IsQuery", this.IsQuery);
            this.SetParamArraySimple(map, prefix + "CatalogName.", this.CatalogName);
            this.SetParamSimple(map, prefix + "Sql", this.Sql);
            this.SetParamSimple(map, prefix + "ReadRows", this.ReadRows);
            this.SetParamSimple(map, prefix + "ResultBytes", this.ResultBytes);
            this.SetParamSimple(map, prefix + "MemoryUsage", this.MemoryUsage);
            this.SetParamSimple(map, prefix + "SortField", this.SortField);
            this.SetParamSimple(map, prefix + "SortOrder", this.SortOrder);
        }
    }
}

