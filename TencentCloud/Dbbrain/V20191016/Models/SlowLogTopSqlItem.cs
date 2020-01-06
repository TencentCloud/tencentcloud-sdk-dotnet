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

namespace TencentCloud.Dbbrain.V20191016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SlowLogTopSqlItem : AbstractModel
    {
        
        /// <summary>
        /// sql总锁等待时间
        /// </summary>
        [JsonProperty("LockTime")]
        public float? LockTime{ get; set; }

        /// <summary>
        /// 最大锁等待时间
        /// </summary>
        [JsonProperty("LockTimeMax")]
        public float? LockTimeMax{ get; set; }

        /// <summary>
        /// 最小锁等待时间
        /// </summary>
        [JsonProperty("LockTimeMin")]
        public float? LockTimeMin{ get; set; }

        /// <summary>
        /// 总扫描行数
        /// </summary>
        [JsonProperty("RowsExamined")]
        public long? RowsExamined{ get; set; }

        /// <summary>
        /// 最大扫描行数
        /// </summary>
        [JsonProperty("RowsExaminedMax")]
        public long? RowsExaminedMax{ get; set; }

        /// <summary>
        /// 最小扫描行数
        /// </summary>
        [JsonProperty("RowsExaminedMin")]
        public long? RowsExaminedMin{ get; set; }

        /// <summary>
        /// 总耗时
        /// </summary>
        [JsonProperty("QueryTime")]
        public float? QueryTime{ get; set; }

        /// <summary>
        /// 最大执行时间
        /// </summary>
        [JsonProperty("QueryTimeMax")]
        public float? QueryTimeMax{ get; set; }

        /// <summary>
        /// 最小执行时间
        /// </summary>
        [JsonProperty("QueryTimeMin")]
        public float? QueryTimeMin{ get; set; }

        /// <summary>
        /// 总返回行数
        /// </summary>
        [JsonProperty("RowsSent")]
        public long? RowsSent{ get; set; }

        /// <summary>
        /// 最大返回行数
        /// </summary>
        [JsonProperty("RowsSentMax")]
        public long? RowsSentMax{ get; set; }

        /// <summary>
        /// 最小返回行数
        /// </summary>
        [JsonProperty("RowsSentMin")]
        public long? RowsSentMin{ get; set; }

        /// <summary>
        /// 执行次数
        /// </summary>
        [JsonProperty("ExecTimes")]
        public long? ExecTimes{ get; set; }

        /// <summary>
        /// sql模板
        /// </summary>
        [JsonProperty("SqlTemplate")]
        public string SqlTemplate{ get; set; }

        /// <summary>
        /// 带参数SQL（随机）
        /// </summary>
        [JsonProperty("SqlText")]
        public string SqlText{ get; set; }

        /// <summary>
        /// schema
        /// </summary>
        [JsonProperty("Schema")]
        public string Schema{ get; set; }

        /// <summary>
        /// 总耗时占比
        /// </summary>
        [JsonProperty("QueryTimeRatio")]
        public float? QueryTimeRatio{ get; set; }

        /// <summary>
        /// sql总锁等待时间占比
        /// </summary>
        [JsonProperty("LockTimeRatio")]
        public float? LockTimeRatio{ get; set; }

        /// <summary>
        /// 总扫描行数占比
        /// </summary>
        [JsonProperty("RowsExaminedRatio")]
        public float? RowsExaminedRatio{ get; set; }

        /// <summary>
        /// 总返回行数占比
        /// </summary>
        [JsonProperty("RowsSentRatio")]
        public float? RowsSentRatio{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LockTime", this.LockTime);
            this.SetParamSimple(map, prefix + "LockTimeMax", this.LockTimeMax);
            this.SetParamSimple(map, prefix + "LockTimeMin", this.LockTimeMin);
            this.SetParamSimple(map, prefix + "RowsExamined", this.RowsExamined);
            this.SetParamSimple(map, prefix + "RowsExaminedMax", this.RowsExaminedMax);
            this.SetParamSimple(map, prefix + "RowsExaminedMin", this.RowsExaminedMin);
            this.SetParamSimple(map, prefix + "QueryTime", this.QueryTime);
            this.SetParamSimple(map, prefix + "QueryTimeMax", this.QueryTimeMax);
            this.SetParamSimple(map, prefix + "QueryTimeMin", this.QueryTimeMin);
            this.SetParamSimple(map, prefix + "RowsSent", this.RowsSent);
            this.SetParamSimple(map, prefix + "RowsSentMax", this.RowsSentMax);
            this.SetParamSimple(map, prefix + "RowsSentMin", this.RowsSentMin);
            this.SetParamSimple(map, prefix + "ExecTimes", this.ExecTimes);
            this.SetParamSimple(map, prefix + "SqlTemplate", this.SqlTemplate);
            this.SetParamSimple(map, prefix + "SqlText", this.SqlText);
            this.SetParamSimple(map, prefix + "Schema", this.Schema);
            this.SetParamSimple(map, prefix + "QueryTimeRatio", this.QueryTimeRatio);
            this.SetParamSimple(map, prefix + "LockTimeRatio", this.LockTimeRatio);
            this.SetParamSimple(map, prefix + "RowsExaminedRatio", this.RowsExaminedRatio);
            this.SetParamSimple(map, prefix + "RowsSentRatio", this.RowsSentRatio);
        }
    }
}

