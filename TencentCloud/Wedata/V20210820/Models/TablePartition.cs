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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TablePartition : AbstractModel
    {
        
        /// <summary>
        /// 分区名称
        /// </summary>
        [JsonProperty("PartitionName")]
        public string PartitionName{ get; set; }

        /// <summary>
        /// 分区记录数
        /// </summary>
        [JsonProperty("RecordCount")]
        public long? RecordCount{ get; set; }

        /// <summary>
        /// 分区数据存储大小，字节数
        /// </summary>
        [JsonProperty("StorageSize")]
        public string StorageSize{ get; set; }

        /// <summary>
        /// 分区创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 分区修改时间
        /// </summary>
        [JsonProperty("ModifiedTime")]
        public string ModifiedTime{ get; set; }

        /// <summary>
        /// 分区数据存储大小，已转为适合的单位
        /// </summary>
        [JsonProperty("StorageSizeWithUnit")]
        public string StorageSizeWithUnit{ get; set; }

        /// <summary>
        /// 文件数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NumFiles")]
        public long? NumFiles{ get; set; }

        /// <summary>
        /// 平均文件大小
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AverageFileSizeWithUnit")]
        public string AverageFileSizeWithUnit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PartitionName", this.PartitionName);
            this.SetParamSimple(map, prefix + "RecordCount", this.RecordCount);
            this.SetParamSimple(map, prefix + "StorageSize", this.StorageSize);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifiedTime", this.ModifiedTime);
            this.SetParamSimple(map, prefix + "StorageSizeWithUnit", this.StorageSizeWithUnit);
            this.SetParamSimple(map, prefix + "NumFiles", this.NumFiles);
            this.SetParamSimple(map, prefix + "AverageFileSizeWithUnit", this.AverageFileSizeWithUnit);
        }
    }
}

