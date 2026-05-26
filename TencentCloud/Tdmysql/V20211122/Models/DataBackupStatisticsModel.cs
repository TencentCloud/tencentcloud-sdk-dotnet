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

namespace TencentCloud.Tdmysql.V20211122.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataBackupStatisticsModel : AbstractModel
    {
        
        /// <summary>
        /// 自动备份个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoBackupCount")]
        public long? AutoBackupCount{ get; set; }

        /// <summary>
        /// 自动备份大小，单位Byte
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoBackupSize")]
        public long? AutoBackupSize{ get; set; }

        /// <summary>
        /// 平均每个备份大小,单位Byte
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AverageSizePerBackup")]
        public long? AverageSizePerBackup{ get; set; }

        /// <summary>
        /// 平均每天备份大小,单位Byte
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AverageSizePerDay")]
        public long? AverageSizePerDay{ get; set; }

        /// <summary>
        /// 手工备份个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ManualBackupCount")]
        public long? ManualBackupCount{ get; set; }

        /// <summary>
        /// 手工备份大小，单位Byte
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ManualBackupSize")]
        public long? ManualBackupSize{ get; set; }

        /// <summary>
        /// 数据备份个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// 数据备份大小，单位Byte
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalSize")]
        public long? TotalSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoBackupCount", this.AutoBackupCount);
            this.SetParamSimple(map, prefix + "AutoBackupSize", this.AutoBackupSize);
            this.SetParamSimple(map, prefix + "AverageSizePerBackup", this.AverageSizePerBackup);
            this.SetParamSimple(map, prefix + "AverageSizePerDay", this.AverageSizePerDay);
            this.SetParamSimple(map, prefix + "ManualBackupCount", this.ManualBackupCount);
            this.SetParamSimple(map, prefix + "ManualBackupSize", this.ManualBackupSize);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "TotalSize", this.TotalSize);
        }
    }
}

