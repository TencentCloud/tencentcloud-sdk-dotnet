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

namespace TencentCloud.Iecp.V20210914.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MonitorMetricsColumn : AbstractModel
    {
        
        /// <summary>
        /// 数据名称
        /// </summary>
        [JsonProperty("ColumnName")]
        public string ColumnName{ get; set; }

        /// <summary>
        /// 数据内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ColumnData")]
        public string[] ColumnData{ get; set; }

        /// <summary>
        /// 数据所属，查询Workload类型时有值
        /// </summary>
        [JsonProperty("ColumnBelong")]
        public string ColumnBelong{ get; set; }

        /// <summary>
        /// 最大值
        /// </summary>
        [JsonProperty("MaxValue")]
        public float? MaxValue{ get; set; }

        /// <summary>
        /// 最小值
        /// </summary>
        [JsonProperty("MinValue")]
        public float? MinValue{ get; set; }

        /// <summary>
        /// 平均值
        /// </summary>
        [JsonProperty("AvgValue")]
        public float? AvgValue{ get; set; }

        /// <summary>
        /// 时间戳数组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ColumnTime")]
        public long? ColumnTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ColumnName", this.ColumnName);
            this.SetParamArraySimple(map, prefix + "ColumnData.", this.ColumnData);
            this.SetParamSimple(map, prefix + "ColumnBelong", this.ColumnBelong);
            this.SetParamSimple(map, prefix + "MaxValue", this.MaxValue);
            this.SetParamSimple(map, prefix + "MinValue", this.MinValue);
            this.SetParamSimple(map, prefix + "AvgValue", this.AvgValue);
            this.SetParamSimple(map, prefix + "ColumnTime", this.ColumnTime);
        }
    }
}

