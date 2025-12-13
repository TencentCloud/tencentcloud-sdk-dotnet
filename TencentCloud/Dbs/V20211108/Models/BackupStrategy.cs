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

namespace TencentCloud.Dbs.V20211108.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BackupStrategy : AbstractModel
    {
        
        /// <summary>
        /// 全量备份开始时间。周期性的全量备份将在当天该时间开始。
        /// </summary>
        [JsonProperty("BackupStartTime")]
        public string BackupStartTime{ get; set; }

        /// <summary>
        /// 存储策略。
        /// </summary>
        [JsonProperty("StorageStrategy")]
        public StorageStrategy StorageStrategy{ get; set; }

        /// <summary>
        /// 备份周期。
        /// </summary>
        [JsonProperty("BackupPeriod")]
        public BackupPeriod BackupPeriod{ get; set; }

        /// <summary>
        /// 备份方法。目前仅支持 "logical" - 逻辑备份。
        /// </summary>
        [JsonProperty("BackupMethod")]
        public string BackupMethod{ get; set; }

        /// <summary>
        /// 备份周期。支持的值包括：
        /// "period" - 周期性备份；
        /// "single" - 单次备份。
        /// 默认值为"period"。
        /// </summary>
        [JsonProperty("StrategyType")]
        public string StrategyType{ get; set; }

        /// <summary>
        /// 是否开启增量备份。可能的取值为["true", "false"]。默认值为"true"。
        /// </summary>
        [JsonProperty("EnableIncrement")]
        public bool? EnableIncrement{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BackupStartTime", this.BackupStartTime);
            this.SetParamObj(map, prefix + "StorageStrategy.", this.StorageStrategy);
            this.SetParamObj(map, prefix + "BackupPeriod.", this.BackupPeriod);
            this.SetParamSimple(map, prefix + "BackupMethod", this.BackupMethod);
            this.SetParamSimple(map, prefix + "StrategyType", this.StrategyType);
            this.SetParamSimple(map, prefix + "EnableIncrement", this.EnableIncrement);
        }
    }
}

