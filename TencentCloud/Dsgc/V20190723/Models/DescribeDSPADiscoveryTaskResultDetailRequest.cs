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

    public class DescribeDSPADiscoveryTaskResultDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// DSPA实例ID
        /// </summary>
        [JsonProperty("DspaId")]
        public string DspaId{ get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public long? TaskId{ get; set; }

        /// <summary>
        /// 扫描数据库结果ID
        /// </summary>
        [JsonProperty("DbResultId")]
        public long? DbResultId{ get; set; }

        /// <summary>
        /// 合规组ID
        /// </summary>
        [JsonProperty("ComplianceId")]
        public long? ComplianceId{ get; set; }

        /// <summary>
        /// 数据库名
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// 所属数据表名
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 敏感数据分类ID
        /// </summary>
        [JsonProperty("CategoryId")]
        public long? CategoryId{ get; set; }

        /// <summary>
        /// 敏感数据分级ID
        /// </summary>
        [JsonProperty("LevelId")]
        public long? LevelId{ get; set; }

        /// <summary>
        /// 偏移量，默认为0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认值为20，最大值为100
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 多级分类的分类ID集合
        /// </summary>
        [JsonProperty("CategoryIdList")]
        public long?[] CategoryIdList{ get; set; }

        /// <summary>
        /// 任务扫描id
        /// </summary>
        [JsonProperty("ScanResultId")]
        public long? ScanResultId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DspaId", this.DspaId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "DbResultId", this.DbResultId);
            this.SetParamSimple(map, prefix + "ComplianceId", this.ComplianceId);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "CategoryId", this.CategoryId);
            this.SetParamSimple(map, prefix + "LevelId", this.LevelId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "CategoryIdList.", this.CategoryIdList);
            this.SetParamSimple(map, prefix + "ScanResultId", this.ScanResultId);
        }
    }
}

