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

    public class TopSqlTpl : AbstractModel
    {
        
        /// <summary>
        /// <p>执行次数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecTimes")]
        public long? ExecTimes{ get; set; }

        /// <summary>
        /// <p>SQL模板Id，数据类型Long。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SqlTemplateId")]
        public string SqlTemplateId{ get; set; }

        /// <summary>
        /// <p>最小影响行数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AffectRowsMin")]
        public long? AffectRowsMin{ get; set; }

        /// <summary>
        /// <p>sql模板</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SqlTemplate")]
        public string SqlTemplate{ get; set; }

        /// <summary>
        /// <p>表名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// <p>最大影响行数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AffectRowsMax")]
        public long? AffectRowsMax{ get; set; }

        /// <summary>
        /// <p>sql类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SqlType")]
        public string SqlType{ get; set; }

        /// <summary>
        /// <p>影响行数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AffectRows")]
        public long? AffectRows{ get; set; }

        /// <summary>
        /// <p>DB名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DB")]
        public string DB{ get; set; }

        /// <summary>
        /// <p>最小锁等待时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LockWaitTimeMin")]
        public float? LockWaitTimeMin{ get; set; }

        /// <summary>
        /// <p>cpu时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CpuTime")]
        public float? CpuTime{ get; set; }

        /// <summary>
        /// <p>最大io等待时间，单位秒</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IoWaitTimeMax")]
        public float? IoWaitTimeMax{ get; set; }

        /// <summary>
        /// <p>最大锁等待时间，单位秒</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LockWaitTimeMax")]
        public float? LockWaitTimeMax{ get; set; }

        /// <summary>
        /// <p>最小检查行数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckRowsMin")]
        public long? CheckRowsMin{ get; set; }

        /// <summary>
        /// <p>检查行数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckRows")]
        public long? CheckRows{ get; set; }

        /// <summary>
        /// <p>最大cpu时间，单位秒</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CpuTimeMax")]
        public float? CpuTimeMax{ get; set; }

        /// <summary>
        /// <p>最小io等待时间，单位秒</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IoWaitTimeMin")]
        public long? IoWaitTimeMin{ get; set; }

        /// <summary>
        /// <p>最大执行时间，单位秒</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LatencyMax")]
        public float? LatencyMax{ get; set; }

        /// <summary>
        /// <p>io等待时间，单位秒</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IoWaitTime")]
        public float? IoWaitTime{ get; set; }

        /// <summary>
        /// <p>最大检查行数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckRowsMax")]
        public long? CheckRowsMax{ get; set; }

        /// <summary>
        /// <p>最小cpu时间，单位秒</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CpuTimeMin")]
        public float? CpuTimeMin{ get; set; }

        /// <summary>
        /// <p>sql详情</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SqlText")]
        public string SqlText{ get; set; }

        /// <summary>
        /// <p>锁等待时间，单位秒</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LockWaitTime")]
        public float? LockWaitTime{ get; set; }

        /// <summary>
        /// <p>最小执行时间，单位秒</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LatencyMin")]
        public float? LatencyMin{ get; set; }

        /// <summary>
        /// <p>执行时间，单位秒</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Latency")]
        public float? Latency{ get; set; }

        /// <summary>
        /// <p>queryTime 占比，单位%</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueryTimeRatio")]
        public string QueryTimeRatio{ get; set; }

        /// <summary>
        /// <p>平均扫描行数</p>
        /// </summary>
        [JsonProperty("CheckRowsAvg")]
        public long? CheckRowsAvg{ get; set; }

        /// <summary>
        /// <p>平均cpu时间</p>
        /// </summary>
        [JsonProperty("CpuTimeAvg")]
        public float? CpuTimeAvg{ get; set; }

        /// <summary>
        /// <p>平均io等待时间</p>
        /// </summary>
        [JsonProperty("IoWaitTimeAvg")]
        public float? IoWaitTimeAvg{ get; set; }

        /// <summary>
        /// <p>平均执行时间</p>
        /// </summary>
        [JsonProperty("LatencyAvg")]
        public float? LatencyAvg{ get; set; }

        /// <summary>
        /// <p>平均锁等待时长</p>
        /// </summary>
        [JsonProperty("LockWaitTimeAvg")]
        public float? LockWaitTimeAvg{ get; set; }

        /// <summary>
        /// <p>发送行数</p>
        /// </summary>
        [JsonProperty("SentRows")]
        public long? SentRows{ get; set; }

        /// <summary>
        /// <p>平均发送行数</p>
        /// </summary>
        [JsonProperty("SentRowsAvg")]
        public long? SentRowsAvg{ get; set; }

        /// <summary>
        /// <p>平均影响行数</p>
        /// </summary>
        [JsonProperty("AffectRowsAvg")]
        public long? AffectRowsAvg{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExecTimes", this.ExecTimes);
            this.SetParamSimple(map, prefix + "SqlTemplateId", this.SqlTemplateId);
            this.SetParamSimple(map, prefix + "AffectRowsMin", this.AffectRowsMin);
            this.SetParamSimple(map, prefix + "SqlTemplate", this.SqlTemplate);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "AffectRowsMax", this.AffectRowsMax);
            this.SetParamSimple(map, prefix + "SqlType", this.SqlType);
            this.SetParamSimple(map, prefix + "AffectRows", this.AffectRows);
            this.SetParamSimple(map, prefix + "DB", this.DB);
            this.SetParamSimple(map, prefix + "LockWaitTimeMin", this.LockWaitTimeMin);
            this.SetParamSimple(map, prefix + "CpuTime", this.CpuTime);
            this.SetParamSimple(map, prefix + "IoWaitTimeMax", this.IoWaitTimeMax);
            this.SetParamSimple(map, prefix + "LockWaitTimeMax", this.LockWaitTimeMax);
            this.SetParamSimple(map, prefix + "CheckRowsMin", this.CheckRowsMin);
            this.SetParamSimple(map, prefix + "CheckRows", this.CheckRows);
            this.SetParamSimple(map, prefix + "CpuTimeMax", this.CpuTimeMax);
            this.SetParamSimple(map, prefix + "IoWaitTimeMin", this.IoWaitTimeMin);
            this.SetParamSimple(map, prefix + "LatencyMax", this.LatencyMax);
            this.SetParamSimple(map, prefix + "IoWaitTime", this.IoWaitTime);
            this.SetParamSimple(map, prefix + "CheckRowsMax", this.CheckRowsMax);
            this.SetParamSimple(map, prefix + "CpuTimeMin", this.CpuTimeMin);
            this.SetParamSimple(map, prefix + "SqlText", this.SqlText);
            this.SetParamSimple(map, prefix + "LockWaitTime", this.LockWaitTime);
            this.SetParamSimple(map, prefix + "LatencyMin", this.LatencyMin);
            this.SetParamSimple(map, prefix + "Latency", this.Latency);
            this.SetParamSimple(map, prefix + "QueryTimeRatio", this.QueryTimeRatio);
            this.SetParamSimple(map, prefix + "CheckRowsAvg", this.CheckRowsAvg);
            this.SetParamSimple(map, prefix + "CpuTimeAvg", this.CpuTimeAvg);
            this.SetParamSimple(map, prefix + "IoWaitTimeAvg", this.IoWaitTimeAvg);
            this.SetParamSimple(map, prefix + "LatencyAvg", this.LatencyAvg);
            this.SetParamSimple(map, prefix + "LockWaitTimeAvg", this.LockWaitTimeAvg);
            this.SetParamSimple(map, prefix + "SentRows", this.SentRows);
            this.SetParamSimple(map, prefix + "SentRowsAvg", this.SentRowsAvg);
            this.SetParamSimple(map, prefix + "AffectRowsAvg", this.AffectRowsAvg);
        }
    }
}

