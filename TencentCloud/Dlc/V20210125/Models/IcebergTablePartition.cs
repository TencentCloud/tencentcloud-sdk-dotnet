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

    public class IcebergTablePartition : AbstractModel
    {
        
        /// <summary>
        /// 分区信息名称
        /// </summary>
        [JsonProperty("Partition")]
        public string Partition{ get; set; }

        /// <summary>
        /// 分区记录数
        /// </summary>
        [JsonProperty("Records")]
        public long? Records{ get; set; }

        /// <summary>
        /// 分区数据文件数量
        /// </summary>
        [JsonProperty("DataFileSize")]
        public long? DataFileSize{ get; set; }

        /// <summary>
        /// 分区数据文件存储量
        /// </summary>
        [JsonProperty("DataFileStorage")]
        public long? DataFileStorage{ get; set; }

        /// <summary>
        /// 分区创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 分区更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 最后一次分区更新的快照ID
        /// </summary>
        [JsonProperty("LastUpdateSnapshotId")]
        public string LastUpdateSnapshotId{ get; set; }

        /// <summary>
        /// 分区的location
        /// </summary>
        [JsonProperty("Location")]
        public LocationInfo Location{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Partition", this.Partition);
            this.SetParamSimple(map, prefix + "Records", this.Records);
            this.SetParamSimple(map, prefix + "DataFileSize", this.DataFileSize);
            this.SetParamSimple(map, prefix + "DataFileStorage", this.DataFileStorage);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "LastUpdateSnapshotId", this.LastUpdateSnapshotId);
            this.SetParamObj(map, prefix + "Location.", this.Location);
        }
    }
}

