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

    public class DspaDiscoveryTaskResultDetail : AbstractModel
    {
        
        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public long? TaskId{ get; set; }

        /// <summary>
        /// 扫描结果详情ID
        /// </summary>
        [JsonProperty("FieldResultId")]
        public long? FieldResultId{ get; set; }

        /// <summary>
        /// 所属数据表名
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 字段名
        /// </summary>
        [JsonProperty("FieldName")]
        public string FieldName{ get; set; }

        /// <summary>
        /// 敏感数据分类ID
        /// </summary>
        [JsonProperty("CategoryId")]
        public long? CategoryId{ get; set; }

        /// <summary>
        /// 敏感数据分类名称
        /// </summary>
        [JsonProperty("CategoryName")]
        public string CategoryName{ get; set; }

        /// <summary>
        /// 敏感数据分级ID
        /// </summary>
        [JsonProperty("LevelId")]
        public long? LevelId{ get; set; }

        /// <summary>
        /// 敏感数据分级名称
        /// </summary>
        [JsonProperty("LevelName")]
        public string LevelName{ get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("RuleId")]
        public long? RuleId{ get; set; }

        /// <summary>
        /// 敏感数据分级分数
        /// </summary>
        [JsonProperty("LevelRiskScore")]
        public long? LevelRiskScore{ get; set; }

        /// <summary>
        /// 保护措施
        /// </summary>
        [JsonProperty("SafeGuard")]
        public DspaSafeGuard SafeGuard{ get; set; }

        /// <summary>
        /// 分类路径
        /// </summary>
        [JsonProperty("CategoryFullPath")]
        public string CategoryFullPath{ get; set; }

        /// <summary>
        /// 模式名
        /// </summary>
        [JsonProperty("SchemaName")]
        public string SchemaName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "FieldResultId", this.FieldResultId);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "FieldName", this.FieldName);
            this.SetParamSimple(map, prefix + "CategoryId", this.CategoryId);
            this.SetParamSimple(map, prefix + "CategoryName", this.CategoryName);
            this.SetParamSimple(map, prefix + "LevelId", this.LevelId);
            this.SetParamSimple(map, prefix + "LevelName", this.LevelName);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "LevelRiskScore", this.LevelRiskScore);
            this.SetParamObj(map, prefix + "SafeGuard.", this.SafeGuard);
            this.SetParamSimple(map, prefix + "CategoryFullPath", this.CategoryFullPath);
            this.SetParamSimple(map, prefix + "SchemaName", this.SchemaName);
        }
    }
}

