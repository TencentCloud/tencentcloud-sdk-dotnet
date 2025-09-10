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

    public class MixedTablePartitions : AbstractModel
    {
        
        /// <summary>
        /// 数据表格式
        /// </summary>
        [JsonProperty("TableFormat")]
        public string TableFormat{ get; set; }

        /// <summary>
        /// 分区总数
        /// </summary>
        [JsonProperty("TotalSize")]
        public long? TotalSize{ get; set; }

        /// <summary>
        /// 分页查询的游标信息，在获取下一页信息时需要回传到服务端
        /// </summary>
        [JsonProperty("NextCursor")]
        public string NextCursor{ get; set; }

        /// <summary>
        /// iceberg表分区信息
        /// </summary>
        [JsonProperty("IcebergPartitions")]
        public IcebergTablePartition[] IcebergPartitions{ get; set; }

        /// <summary>
        /// hive表分区信息
        /// </summary>
        [JsonProperty("HivePartitions")]
        public HiveTablePartition[] HivePartitions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableFormat", this.TableFormat);
            this.SetParamSimple(map, prefix + "TotalSize", this.TotalSize);
            this.SetParamSimple(map, prefix + "NextCursor", this.NextCursor);
            this.SetParamArrayObj(map, prefix + "IcebergPartitions.", this.IcebergPartitions);
            this.SetParamArrayObj(map, prefix + "HivePartitions.", this.HivePartitions);
        }
    }
}

