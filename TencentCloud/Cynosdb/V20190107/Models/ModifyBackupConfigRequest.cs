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
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 表示全备开始时间，[0-24*3600]， 如0:00, 1:00, 2:00 分别为 0，3600， 7200
        /// </summary>
        [JsonProperty("BackupTimeBeg")]
        public ulong? BackupTimeBeg{ get; set; }

        /// <summary>
        /// 表示全备结束时间，[0-24*3600]， 如0:00, 1:00, 2:00 分别为 0，3600， 7200
        /// </summary>
        [JsonProperty("BackupTimeEnd")]
        public ulong? BackupTimeEnd{ get; set; }

        /// <summary>
        /// 表示保留备份时长, 单位秒，超过该时间将被清理, 七天表示为3600*24*7=604800，最大为158112000
        /// </summary>
        [JsonProperty("ReserveDuration")]
        public ulong? ReserveDuration{ get; set; }

        /// <summary>
        /// 该参数目前不支持修改，无需填写。备份频率，长度为7的数组，分别对应周一到周日的备份方式，full-全量备份，increment-增量备份
        /// </summary>
        [JsonProperty("BackupFreq")]
        public string[] BackupFreq{ get; set; }

        /// <summary>
        /// 该参数目前不支持修改，无需填写。
        /// </summary>
        [JsonProperty("BackupType")]
        public string BackupType{ get; set; }

        /// <summary>
        /// 逻辑备份配置
        /// </summary>
        [JsonProperty("LogicBackupConfig")]
        public LogicBackupConfigInfo LogicBackupConfig{ get; set; }

        /// <summary>
        /// 是否删除自动逻辑备份
        /// </summary>
        [JsonProperty("DeleteAutoLogicBackup")]
        public bool? DeleteAutoLogicBackup{ get; set; }


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
        }
    }
}

