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

    public class BackupPlanPayInfo : AbstractModel
    {
        
        /// <summary>
        /// 实例规格。
        /// </summary>
        [JsonProperty("InstanceClass")]
        public string InstanceClass{ get; set; }

        /// <summary>
        /// 付费方式。取值：
        /// - postPay：后付费
        /// - prePay：预付费
        /// </summary>
        [JsonProperty("PayType")]
        public string PayType{ get; set; }

        /// <summary>
        /// 免费额度，单位：字节。取值为 -1 表示不限量。
        /// </summary>
        [JsonProperty("FreeSpace")]
        public long? FreeSpace{ get; set; }

        /// <summary>
        /// 本月计费空间，单位：字节。
        /// </summary>
        [JsonProperty("TotalChargeSpace")]
        public long? TotalChargeSpace{ get; set; }

        /// <summary>
        /// 全量计费空间，单位：字节。
        /// </summary>
        [JsonProperty("FullChargeSpace")]
        public long? FullChargeSpace{ get; set; }

        /// <summary>
        /// 增量计费空间，单位：字节。
        /// </summary>
        [JsonProperty("IncrementChargeSpace")]
        public long? IncrementChargeSpace{ get; set; }

        /// <summary>
        /// 本月全量备份集大小，单位：字节。
        /// </summary>
        [JsonProperty("FullBackupSetSize")]
        public long? FullBackupSetSize{ get; set; }

        /// <summary>
        /// 本月增量备份集大小，单位：字节。
        /// </summary>
        [JsonProperty("IncrementBackupSetSize")]
        public long? IncrementBackupSetSize{ get; set; }

        /// <summary>
        /// 创建时间。格式为 YYYY-MM-DD HH:mm:ss，如 2024-01-01 00:00:00。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 统计周期，格式为“开始时间 - 结束时间”。
        /// </summary>
        [JsonProperty("TimeRange")]
        public string TimeRange{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceClass", this.InstanceClass);
            this.SetParamSimple(map, prefix + "PayType", this.PayType);
            this.SetParamSimple(map, prefix + "FreeSpace", this.FreeSpace);
            this.SetParamSimple(map, prefix + "TotalChargeSpace", this.TotalChargeSpace);
            this.SetParamSimple(map, prefix + "FullChargeSpace", this.FullChargeSpace);
            this.SetParamSimple(map, prefix + "IncrementChargeSpace", this.IncrementChargeSpace);
            this.SetParamSimple(map, prefix + "FullBackupSetSize", this.FullBackupSetSize);
            this.SetParamSimple(map, prefix + "IncrementBackupSetSize", this.IncrementBackupSetSize);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "TimeRange", this.TimeRange);
        }
    }
}

