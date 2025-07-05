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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAutoBackupConfigResponse : AbstractModel
    {
        
        /// <summary>
        /// 该参数因兼容性问题暂时保留，请忽略。
        /// </summary>
        [JsonProperty("AutoBackupType")]
        public long? AutoBackupType{ get; set; }

        /// <summary>
        /// 备份周期，默认为每天自动备份，Monday，Tuesday，Wednesday，Thursday，Friday，Saturday，Sunday。
        /// </summary>
        [JsonProperty("WeekDays")]
        public string[] WeekDays{ get; set; }

        /// <summary>
        /// 备份任务发起时间段。
        /// </summary>
        [JsonProperty("TimePeriod")]
        public string TimePeriod{ get; set; }

        /// <summary>
        /// 全量备份文件保存天数。默认为7天。如需保存更多天数，请[提交工单](https://console.cloud.tencent.com/workorder/category)申请。
        /// </summary>
        [JsonProperty("BackupStorageDays")]
        public long? BackupStorageDays{ get; set; }

        /// <summary>
        /// 该参数不再使用，请忽略。
        /// </summary>
        [JsonProperty("BinlogStorageDays")]
        public long? BinlogStorageDays{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoBackupType", this.AutoBackupType);
            this.SetParamArraySimple(map, prefix + "WeekDays.", this.WeekDays);
            this.SetParamSimple(map, prefix + "TimePeriod", this.TimePeriod);
            this.SetParamSimple(map, prefix + "BackupStorageDays", this.BackupStorageDays);
            this.SetParamSimple(map, prefix + "BinlogStorageDays", this.BinlogStorageDays);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

