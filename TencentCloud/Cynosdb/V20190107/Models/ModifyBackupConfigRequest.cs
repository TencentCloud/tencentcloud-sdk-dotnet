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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyBackupConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集群ID</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>表示全备开始时间，[0-24*3600]， 如0:00, 1:00, 2:00 分别为 0，3600， 7200</p>
        /// </summary>
        [JsonProperty("BackupTimeBeg")]
        public ulong? BackupTimeBeg{ get; set; }

        /// <summary>
        /// <p>表示全备结束时间，[0-24*3600]， 如0:00, 1:00, 2:00 分别为 0，3600， 7200</p>
        /// </summary>
        [JsonProperty("BackupTimeEnd")]
        public ulong? BackupTimeEnd{ get; set; }

        /// <summary>
        /// <p>表示保留备份时长, 单位秒，超过该时间将被清理, 七天表示为3600<em>24</em>7=604800，最大为158112000</p>
        /// </summary>
        [JsonProperty("ReserveDuration")]
        public ulong? ReserveDuration{ get; set; }

        /// <summary>
        /// <p>该参数目前不支持修改，无需填写。备份频率，长度为7的数组，分别对应周一到周日的备份方式，full-全量备份，increment-增量备份</p>
        /// </summary>
        [JsonProperty("BackupFreq")]
        public string[] BackupFreq{ get; set; }

        /// <summary>
        /// <p>该参数目前不支持修改，无需填写。</p>
        /// </summary>
        [JsonProperty("BackupType")]
        public string BackupType{ get; set; }

        /// <summary>
        /// <p>逻辑备份配置</p>
        /// </summary>
        [JsonProperty("LogicBackupConfig")]
        public LogicBackupConfigInfo LogicBackupConfig{ get; set; }

        /// <summary>
        /// <p>是否删除自动逻辑备份</p>
        /// </summary>
        [JsonProperty("DeleteAutoLogicBackup")]
        public bool? DeleteAutoLogicBackup{ get; set; }

        /// <summary>
        /// <p>二级快照备份参数</p>
        /// </summary>
        [JsonProperty("SnapshotSecondaryBackupConfig")]
        public SnapshotBackupConfig SnapshotSecondaryBackupConfig{ get; set; }

        /// <summary>
        /// <p>稀疏备份配置</p>
        /// </summary>
        [JsonProperty("SparseBackupConfig")]
        public SparseBackupConfig SparseBackupConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "BackupTimeBeg", this.BackupTimeBeg);
            this.SetParamSimple(map, prefix + "BackupTimeEnd", this.BackupTimeEnd);
            this.SetParamSimple(map, prefix + "ReserveDuration", this.ReserveDuration);
            this.SetParamArraySimple(map, prefix + "BackupFreq.", this.BackupFreq);
            this.SetParamSimple(map, prefix + "BackupType", this.BackupType);
            this.SetParamObj(map, prefix + "LogicBackupConfig.", this.LogicBackupConfig);
            this.SetParamSimple(map, prefix + "DeleteAutoLogicBackup", this.DeleteAutoLogicBackup);
            this.SetParamObj(map, prefix + "SnapshotSecondaryBackupConfig.", this.SnapshotSecondaryBackupConfig);
            this.SetParamObj(map, prefix + "SparseBackupConfig.", this.SparseBackupConfig);
        }
    }
}

