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

    public class ModifyCrossBackupStrategyRequest : AbstractModel
    {
        
        /// <summary>
        /// 跨地域备份开关(数据备份&日志备份) enable-开启，disable-关闭
        /// </summary>
        [JsonProperty("CrossBackupEnabled")]
        public string CrossBackupEnabled{ get; set; }

        /// <summary>
        /// 实例Id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例ID列表
        /// </summary>
        [JsonProperty("InstanceIdSet")]
        public string[] InstanceIdSet{ get; set; }

        /// <summary>
        /// 跨地域备份保留天数，取值：7~1830，默认7天
        /// </summary>
        [JsonProperty("CrossBackupSaveDays")]
        public ulong? CrossBackupSaveDays{ get; set; }

        /// <summary>
        /// 跨地域备份的目标地域ID，最多两个，最少一个
        /// </summary>
        [JsonProperty("CrossBackupRegion")]
        public string[] CrossBackupRegion{ get; set; }

        /// <summary>
        /// 是否立即清理跨地域备份(数据备份&日志备份) ，只有在BackupEnabled = disable时有效。1-是，0-否，默认：0
        /// </summary>
        [JsonProperty("CleanUpCrossBackup")]
        public ulong? CleanUpCrossBackup{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CrossBackupEnabled", this.CrossBackupEnabled);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "InstanceIdSet.", this.InstanceIdSet);
            this.SetParamSimple(map, prefix + "CrossBackupSaveDays", this.CrossBackupSaveDays);
            this.SetParamArraySimple(map, prefix + "CrossBackupRegion.", this.CrossBackupRegion);
            this.SetParamSimple(map, prefix + "CleanUpCrossBackup", this.CleanUpCrossBackup);
        }
    }
}

