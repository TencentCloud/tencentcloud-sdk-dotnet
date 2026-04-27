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

    public class SparseBackupConfigInfo : AbstractModel
    {
        
        /// <summary>
        /// 操作类型:add,modify,remove
        /// </summary>
        [JsonProperty("OpType")]
        public string OpType{ get; set; }

        /// <summary>
        /// 配置 ID
        /// </summary>
        [JsonProperty("ConfigId")]
        public string ConfigId{ get; set; }

        /// <summary>
        /// 周期策略类型：weekly/monthly/yearly
        /// </summary>
        [JsonProperty("SparsePeriodConfig")]
        public string SparsePeriodConfig{ get; set; }

        /// <summary>
        /// 周期时间配置
        /// </summary>
        [JsonProperty("SparsePeriodTime")]
        public SparsePeriodTime SparsePeriodTime{ get; set; }

        /// <summary>
        /// 保留天数（7-7320天，最长20年）
        /// </summary>
        [JsonProperty("SparseBackupSaveDays")]
        public long? SparseBackupSaveDays{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OpType", this.OpType);
            this.SetParamSimple(map, prefix + "ConfigId", this.ConfigId);
            this.SetParamSimple(map, prefix + "SparsePeriodConfig", this.SparsePeriodConfig);
            this.SetParamObj(map, prefix + "SparsePeriodTime.", this.SparsePeriodTime);
            this.SetParamSimple(map, prefix + "SparseBackupSaveDays", this.SparseBackupSaveDays);
        }
    }
}

