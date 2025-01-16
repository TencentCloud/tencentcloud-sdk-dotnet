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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScheduleInfo : AbstractModel
    {
        
        /// <summary>
        /// 生效周期
        /// </summary>
        [JsonProperty("EffectivePeriod")]
        public string EffectivePeriod{ get; set; }

        /// <summary>
        /// 调度类型，不传该参数时为立即执行：
        /// Day-天
        /// Week-周
        /// Month-月
        /// Once-单次
        /// </summary>
        [JsonProperty("ScheduleType")]
        public string ScheduleType{ get; set; }

        /// <summary>
        /// 执行调度的日期。调度类型为周和月时以英文逗号分隔；
        /// 调度类型为单次时，该值是个日期
        /// </summary>
        [JsonProperty("ScheduleData")]
        public string ScheduleData{ get; set; }

        /// <summary>
        /// 执行时间：时
        /// </summary>
        [JsonProperty("ScheduleHour")]
        public long? ScheduleHour{ get; set; }

        /// <summary>
        /// 执行时间：分
        /// </summary>
        [JsonProperty("ScheduleMin")]
        public long? ScheduleMin{ get; set; }

        /// <summary>
        /// 备份粒度：
        /// All-全量
        /// Database-按库
        /// Table-按表
        /// </summary>
        [JsonProperty("BackupScope")]
        public string BackupScope{ get; set; }

        /// <summary>
        /// 备份库：如果是按库备份，则需要该字段，库之间用英文逗号分割
        /// </summary>
        [JsonProperty("BackupDatabase")]
        public string BackupDatabase{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EffectivePeriod", this.EffectivePeriod);
            this.SetParamSimple(map, prefix + "ScheduleType", this.ScheduleType);
            this.SetParamSimple(map, prefix + "ScheduleData", this.ScheduleData);
            this.SetParamSimple(map, prefix + "ScheduleHour", this.ScheduleHour);
            this.SetParamSimple(map, prefix + "ScheduleMin", this.ScheduleMin);
            this.SetParamSimple(map, prefix + "BackupScope", this.BackupScope);
            this.SetParamSimple(map, prefix + "BackupDatabase", this.BackupDatabase);
        }
    }
}

