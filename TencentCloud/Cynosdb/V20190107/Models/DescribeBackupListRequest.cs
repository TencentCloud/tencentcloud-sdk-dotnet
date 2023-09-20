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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBackupListRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 备份文件列表大小，取值范围(0,100]
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 备份文件列表偏移，取值范围[0,INF)
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 数据库类型，取值范围: 
        /// <li> MYSQL </li>
        /// </summary>
        [JsonProperty("DbType")]
        public string DbType{ get; set; }

        /// <summary>
        /// 备份ID
        /// </summary>
        [JsonProperty("BackupIds")]
        public long?[] BackupIds{ get; set; }

        /// <summary>
        /// 备份类型，可选值：snapshot，快照备份； logic，逻辑备份
        /// </summary>
        [JsonProperty("BackupType")]
        public string BackupType{ get; set; }

        /// <summary>
        /// 备份方式，可选值：auto，自动备份；manual，手动备
        /// </summary>
        [JsonProperty("BackupMethod")]
        public string BackupMethod{ get; set; }

        /// <summary>
        /// 快照类型，可选值：full，全量；increment，增量
        /// </summary>
        [JsonProperty("SnapShotType")]
        public string SnapShotType{ get; set; }

        /// <summary>
        /// 备份开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 备份结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 备份文件名，模糊查询
        /// </summary>
        [JsonProperty("FileNames")]
        public string[] FileNames{ get; set; }

        /// <summary>
        /// 备份备注名，模糊查询
        /// </summary>
        [JsonProperty("BackupNames")]
        public string[] BackupNames{ get; set; }

        /// <summary>
        /// 快照备份Id列表
        /// </summary>
        [JsonProperty("SnapshotIdList")]
        public long?[] SnapshotIdList{ get; set; }

        /// <summary>
        /// 备份地域
        /// </summary>
        [JsonProperty("BackupRegion")]
        public string BackupRegion{ get; set; }

        /// <summary>
        /// 是否跨地域备份
        /// </summary>
        [JsonProperty("IsCrossRegionsBackup")]
        public string IsCrossRegionsBackup{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "DbType", this.DbType);
            this.SetParamArraySimple(map, prefix + "BackupIds.", this.BackupIds);
            this.SetParamSimple(map, prefix + "BackupType", this.BackupType);
            this.SetParamSimple(map, prefix + "BackupMethod", this.BackupMethod);
            this.SetParamSimple(map, prefix + "SnapShotType", this.SnapShotType);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "FileNames.", this.FileNames);
            this.SetParamArraySimple(map, prefix + "BackupNames.", this.BackupNames);
            this.SetParamArraySimple(map, prefix + "SnapshotIdList.", this.SnapshotIdList);
            this.SetParamSimple(map, prefix + "BackupRegion", this.BackupRegion);
            this.SetParamSimple(map, prefix + "IsCrossRegionsBackup", this.IsCrossRegionsBackup);
        }
    }
}

