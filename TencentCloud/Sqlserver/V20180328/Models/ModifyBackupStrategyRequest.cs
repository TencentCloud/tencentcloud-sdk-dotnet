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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyBackupStrategyRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 备份类型，当length(BackupDay) <=7 && length(BackupDay) >=2时，取值为weekly，当length(BackupDay)=1时，取值daily，默认daily
        /// </summary>
        [JsonProperty("BackupType")]
        public string BackupType{ get; set; }

        /// <summary>
        /// 备份时间点，取值为0-23的整数
        /// </summary>
        [JsonProperty("BackupTime")]
        public ulong? BackupTime{ get; set; }

        /// <summary>
        /// BackupType取值为daily时，表示备份间隔天数。当前取值只能为1
        /// </summary>
        [JsonProperty("BackupDay")]
        public ulong? BackupDay{ get; set; }

        /// <summary>
        /// 备份模式，master_pkg-主节点上打包备份文件；master_no_pkg-主节点单库备份文件；slave_pkg-从节点上打包备份文件；slave_no_pkg-从节点上单库备份文件，从节点上备份只有在always on容灾模式下支持。
        /// </summary>
        [JsonProperty("BackupModel")]
        public string BackupModel{ get; set; }

        /// <summary>
        /// BackupType取值为weekly时，表示每周的星期N做备份。（如果数据备份保留时间<7天，则取值[1,2,3,4,5,6,7]。如果数据备份保留时间>=7天，则备份周期取值至少是一周的任意2天）
        /// </summary>
        [JsonProperty("BackupCycle")]
        public ulong?[] BackupCycle{ get; set; }

        /// <summary>
        /// 数据(日志)备份保留时间，取值[3-1830]天，默认7天
        /// </summary>
        [JsonProperty("BackupSaveDays")]
        public ulong? BackupSaveDays{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "BackupType", this.BackupType);
            this.SetParamSimple(map, prefix + "BackupTime", this.BackupTime);
            this.SetParamSimple(map, prefix + "BackupDay", this.BackupDay);
            this.SetParamSimple(map, prefix + "BackupModel", this.BackupModel);
            this.SetParamArraySimple(map, prefix + "BackupCycle.", this.BackupCycle);
            this.SetParamSimple(map, prefix + "BackupSaveDays", this.BackupSaveDays);
        }
    }
}

