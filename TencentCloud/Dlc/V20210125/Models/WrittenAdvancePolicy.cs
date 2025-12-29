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

    public class WrittenAdvancePolicy : AbstractModel
    {
        
        /// <summary>
        /// 是否启用合并
        /// </summary>
        [JsonProperty("CompactEnable")]
        public string CompactEnable{ get; set; }

        /// <summary>
        /// 是否启用历史数据清理
        /// </summary>
        [JsonProperty("DeleteEnable")]
        public string DeleteEnable{ get; set; }

        /// <summary>
        /// 合并最新文件数量
        /// </summary>
        [JsonProperty("MinInputFiles")]
        public long? MinInputFiles{ get; set; }

        /// <summary>
        /// 合并文件目录文件大小
        /// </summary>
        [JsonProperty("TargetFileSizeBytes")]
        public long? TargetFileSizeBytes{ get; set; }

        /// <summary>
        /// 保留过期时间的快照数量
        /// </summary>
        [JsonProperty("RetainLast")]
        public long? RetainLast{ get; set; }

        /// <summary>
        /// 快照过期时间
        /// </summary>
        [JsonProperty("BeforeDays")]
        public long? BeforeDays{ get; set; }

        /// <summary>
        /// 快照过期执行周期
        /// </summary>
        [JsonProperty("ExpiredSnapshotsIntervalMin")]
        public long? ExpiredSnapshotsIntervalMin{ get; set; }

        /// <summary>
        /// 移除孤立文件执行周期
        /// </summary>
        [JsonProperty("RemoveOrphanIntervalMin")]
        public long? RemoveOrphanIntervalMin{ get; set; }

        /// <summary>
        /// 是否开启COW表合并
        /// </summary>
        [JsonProperty("CowCompactEnable")]
        public string CowCompactEnable{ get; set; }

        /// <summary>
        /// 文件合并策略
        /// </summary>
        [JsonProperty("CompactStrategy")]
        public string CompactStrategy{ get; set; }

        /// <summary>
        /// sort合并策略的规则定义
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SortOrders")]
        public SortOrder[] SortOrders{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompactEnable", this.CompactEnable);
            this.SetParamSimple(map, prefix + "DeleteEnable", this.DeleteEnable);
            this.SetParamSimple(map, prefix + "MinInputFiles", this.MinInputFiles);
            this.SetParamSimple(map, prefix + "TargetFileSizeBytes", this.TargetFileSizeBytes);
            this.SetParamSimple(map, prefix + "RetainLast", this.RetainLast);
            this.SetParamSimple(map, prefix + "BeforeDays", this.BeforeDays);
            this.SetParamSimple(map, prefix + "ExpiredSnapshotsIntervalMin", this.ExpiredSnapshotsIntervalMin);
            this.SetParamSimple(map, prefix + "RemoveOrphanIntervalMin", this.RemoveOrphanIntervalMin);
            this.SetParamSimple(map, prefix + "CowCompactEnable", this.CowCompactEnable);
            this.SetParamSimple(map, prefix + "CompactStrategy", this.CompactStrategy);
            this.SetParamArrayObj(map, prefix + "SortOrders.", this.SortOrders);
        }
    }
}

