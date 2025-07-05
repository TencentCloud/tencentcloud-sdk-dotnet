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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRegularBackupPlanRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 定期备份保留天数 [90 - 3650]天，默认365天
        /// </summary>
        [JsonProperty("RegularBackupSaveDays")]
        public ulong? RegularBackupSaveDays{ get; set; }

        /// <summary>
        /// 定期备份策略 years-每年，quarters-每季度，months-每月，默认months
        /// </summary>
        [JsonProperty("RegularBackupStrategy")]
        public string RegularBackupStrategy{ get; set; }

        /// <summary>
        /// 定期备份保留个数，默认1个
        /// </summary>
        [JsonProperty("RegularBackupCounts")]
        public ulong? RegularBackupCounts{ get; set; }

        /// <summary>
        /// 定期备份开始日期，格式-YYYY-MM-DD 默认当前日期
        /// </summary>
        [JsonProperty("RegularBackupStartTime")]
        public string RegularBackupStartTime{ get; set; }

        /// <summary>
        /// 常规备份周期
        /// </summary>
        [JsonProperty("BackupCycle")]
        public ulong?[] BackupCycle{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "RegularBackupSaveDays", this.RegularBackupSaveDays);
            this.SetParamSimple(map, prefix + "RegularBackupStrategy", this.RegularBackupStrategy);
            this.SetParamSimple(map, prefix + "RegularBackupCounts", this.RegularBackupCounts);
            this.SetParamSimple(map, prefix + "RegularBackupStartTime", this.RegularBackupStartTime);
            this.SetParamArraySimple(map, prefix + "BackupCycle.", this.BackupCycle);
        }
    }
}

