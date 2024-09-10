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

namespace TencentCloud.Dcdb.V20180411.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BackupConfig : AbstractModel
    {
        
        /// <summary>
        /// 备份策略是否启用。
        /// </summary>
        [JsonProperty("EnableBackupPolicy")]
        public bool? EnableBackupPolicy{ get; set; }

        /// <summary>
        /// 超期保留开始日期，早于开始日期的超期备份不保留，格式：yyyy-mm-dd。
        /// </summary>
        [JsonProperty("BeginDate")]
        public string BeginDate{ get; set; }

        /// <summary>
        /// 超期备份保留时长，超出保留时间的超期备份将被删除，可填写1-3650整数。
        /// </summary>
        [JsonProperty("MaxRetentionDays")]
        public long? MaxRetentionDays{ get; set; }

        /// <summary>
        /// 备份模式，可选择按年月周模式保存
        /// * 按年：annually
        /// * 按月：monthly
        /// * 按周：weekly
        /// </summary>
        [JsonProperty("Frequency")]
        public string Frequency{ get; set; }

        /// <summary>
        /// Frequency等于weekly时生效。
        /// 表示保留特定工作日备份。可选择周一到周日，支持多选，取星期英文：
        /// * 星期一 ：Monday
        /// * 星期二 ：Tuesday
        /// * 星期三：Wednesday
        /// * 星期四：Thursday
        /// * 星期五：Friday
        /// * 星期六：Saturday
        /// * 星期日：Sunday
        /// </summary>
        [JsonProperty("WeekDays")]
        public string[] WeekDays{ get; set; }

        /// <summary>
        /// 保留备份个数，Frequency等于monthly或weekly时生效。
        /// 备份模式选择按月时，可填写1-28整数；
        /// 备份模式选择年时，可填写1-336整数。
        /// </summary>
        [JsonProperty("BackupCount")]
        public long? BackupCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableBackupPolicy", this.EnableBackupPolicy);
            this.SetParamSimple(map, prefix + "BeginDate", this.BeginDate);
            this.SetParamSimple(map, prefix + "MaxRetentionDays", this.MaxRetentionDays);
            this.SetParamSimple(map, prefix + "Frequency", this.Frequency);
            this.SetParamArraySimple(map, prefix + "WeekDays.", this.WeekDays);
            this.SetParamSimple(map, prefix + "BackupCount", this.BackupCount);
        }
    }
}

