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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBackupConfigResponse : AbstractModel
    {
        
        /// <summary>
        /// 备份开始的最早时间点，单位为时刻。例如，2 - 凌晨 2:00。
        /// </summary>
        [JsonProperty("StartTimeMin")]
        public long? StartTimeMin{ get; set; }

        /// <summary>
        /// 备份开始的最晚时间点，单位为时刻。例如，6 - 凌晨 6:00。
        /// </summary>
        [JsonProperty("StartTimeMax")]
        public long? StartTimeMax{ get; set; }

        /// <summary>
        /// 备份过期时间，单位为天。
        /// </summary>
        [JsonProperty("BackupExpireDays")]
        public long? BackupExpireDays{ get; set; }

        /// <summary>
        /// 备份方式，可能的值为：physical - 物理备份，logical - 逻辑备份。
        /// </summary>
        [JsonProperty("BackupMethod")]
        public string BackupMethod{ get; set; }

        /// <summary>
        /// Binlog 过期时间，单位为天。
        /// </summary>
        [JsonProperty("BinlogExpireDays")]
        public long? BinlogExpireDays{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTimeMin", this.StartTimeMin);
            this.SetParamSimple(map, prefix + "StartTimeMax", this.StartTimeMax);
            this.SetParamSimple(map, prefix + "BackupExpireDays", this.BackupExpireDays);
            this.SetParamSimple(map, prefix + "BackupMethod", this.BackupMethod);
            this.SetParamSimple(map, prefix + "BinlogExpireDays", this.BinlogExpireDays);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

