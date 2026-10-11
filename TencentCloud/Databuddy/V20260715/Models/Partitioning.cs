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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Partitioning : AbstractModel
    {
        
        /// <summary>
        /// 转换策略
        /// </summary>
        [JsonProperty("Strategy")]
        public string Strategy{ get; set; }

        /// <summary>
        /// 分桶策略参数
        /// </summary>
        [JsonProperty("NumBuckets")]
        public long? NumBuckets{ get; set; }

        /// <summary>
        /// 字段名称
        /// </summary>
        [JsonProperty("FieldNames")]
        public string[] FieldNames{ get; set; }

        /// <summary>
        /// 策略参数
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// 字段名称
        /// </summary>
        [JsonProperty("FieldName")]
        public string[] FieldName{ get; set; }

        /// <summary>
        /// 按年分区策略
        /// </summary>
        [JsonProperty("YearPartitioning")]
        public SingleFieldPartitioning YearPartitioning{ get; set; }

        /// <summary>
        /// 按月分区策略
        /// </summary>
        [JsonProperty("MonthPartitioning")]
        public SingleFieldPartitioning MonthPartitioning{ get; set; }

        /// <summary>
        /// 按天分区策略
        /// </summary>
        [JsonProperty("DayPartitioning")]
        public SingleFieldPartitioning DayPartitioning{ get; set; }

        /// <summary>
        /// 按小时分区策略
        /// </summary>
        [JsonProperty("HourPartitioning")]
        public SingleFieldPartitioning HourPartitioning{ get; set; }

        /// <summary>
        /// 按字段分区策略
        /// </summary>
        [JsonProperty("IdentityPartitioning")]
        public SingleFieldPartitioning IdentityPartitioning{ get; set; }

        /// <summary>
        /// 列表分区策略
        /// </summary>
        [JsonProperty("ListPartitioning")]
        public ListPartitioning ListPartitioning{ get; set; }

        /// <summary>
        /// 范围分区策略
        /// </summary>
        [JsonProperty("RangePartitioning")]
        public RangePartitioning RangePartitioning{ get; set; }

        /// <summary>
        /// 分桶分区策略
        /// </summary>
        [JsonProperty("BucketPartitioning")]
        public BucketPartitioning BucketPartitioning{ get; set; }

        /// <summary>
        /// 截断分区策略
        /// </summary>
        [JsonProperty("TruncatePartitioning")]
        public TruncatePartitioning TruncatePartitioning{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Strategy", this.Strategy);
            this.SetParamSimple(map, prefix + "NumBuckets", this.NumBuckets);
            this.SetParamArraySimple(map, prefix + "FieldNames.", this.FieldNames);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamArraySimple(map, prefix + "FieldName.", this.FieldName);
            this.SetParamObj(map, prefix + "YearPartitioning.", this.YearPartitioning);
            this.SetParamObj(map, prefix + "MonthPartitioning.", this.MonthPartitioning);
            this.SetParamObj(map, prefix + "DayPartitioning.", this.DayPartitioning);
            this.SetParamObj(map, prefix + "HourPartitioning.", this.HourPartitioning);
            this.SetParamObj(map, prefix + "IdentityPartitioning.", this.IdentityPartitioning);
            this.SetParamObj(map, prefix + "ListPartitioning.", this.ListPartitioning);
            this.SetParamObj(map, prefix + "RangePartitioning.", this.RangePartitioning);
            this.SetParamObj(map, prefix + "BucketPartitioning.", this.BucketPartitioning);
            this.SetParamObj(map, prefix + "TruncatePartitioning.", this.TruncatePartitioning);
        }
    }
}

