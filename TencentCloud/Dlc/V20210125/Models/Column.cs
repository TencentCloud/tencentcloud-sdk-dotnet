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

    public class Column : AbstractModel
    {
        
        /// <summary>
        /// 列名称，不区分大小写，最大支持25个字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// string|tinyint|smallint|int|bigint|boolean|float|double|decimal|timestamp|date|binary|array|map|struct|uniontype
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 对该类的注释。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 表示整个 numeric 的长度
        /// </summary>
        [JsonProperty("Precision")]
        public long? Precision{ get; set; }

        /// <summary>
        /// 表示小数部分的长度
        /// </summary>
        [JsonProperty("Scale")]
        public long? Scale{ get; set; }

        /// <summary>
        /// 是否为null
        /// </summary>
        [JsonProperty("Nullable")]
        public string Nullable{ get; set; }

        /// <summary>
        /// 字段位置，小的在前
        /// </summary>
        [JsonProperty("Position")]
        public long? Position{ get; set; }

        /// <summary>
        /// 字段创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 字段修改时间
        /// </summary>
        [JsonProperty("ModifiedTime")]
        public string ModifiedTime{ get; set; }

        /// <summary>
        /// 是否为分区字段
        /// </summary>
        [JsonProperty("IsPartition")]
        public bool? IsPartition{ get; set; }

        /// <summary>
        /// 数据脱敏策略信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataMaskStrategyInfo")]
        public DataMaskStrategyInfo DataMaskStrategyInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "Precision", this.Precision);
            this.SetParamSimple(map, prefix + "Scale", this.Scale);
            this.SetParamSimple(map, prefix + "Nullable", this.Nullable);
            this.SetParamSimple(map, prefix + "Position", this.Position);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifiedTime", this.ModifiedTime);
            this.SetParamSimple(map, prefix + "IsPartition", this.IsPartition);
            this.SetParamObj(map, prefix + "DataMaskStrategyInfo.", this.DataMaskStrategyInfo);
        }
    }
}

