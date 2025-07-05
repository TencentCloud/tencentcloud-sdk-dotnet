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

namespace TencentCloud.Cdwch.V20200915.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateBackUpScheduleRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 策略类型 meta(元数据)  data (表数据)
        /// </summary>
        [JsonProperty("ScheduleType")]
        public string ScheduleType{ get; set; }

        /// <summary>
        /// 操作类型 create(创建) update(编辑修改)
        /// </summary>
        [JsonProperty("OperationType")]
        public string OperationType{ get; set; }

        /// <summary>
        /// 保留天数 例如7
        /// </summary>
        [JsonProperty("RetainDays")]
        public long? RetainDays{ get; set; }

        /// <summary>
        /// 编辑时需要传
        /// </summary>
        [JsonProperty("ScheduleId")]
        public long? ScheduleId{ get; set; }

        /// <summary>
        /// 选择的星期 逗号分隔，例如 2 代表周二
        /// </summary>
        [JsonProperty("WeekDays")]
        public string WeekDays{ get; set; }

        /// <summary>
        /// 执行小时
        /// </summary>
        [JsonProperty("ExecuteHour")]
        public long? ExecuteHour{ get; set; }

        /// <summary>
        /// 备份表列表
        /// </summary>
        [JsonProperty("BackUpTables")]
        public BackupTableContent[] BackUpTables{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ScheduleType", this.ScheduleType);
            this.SetParamSimple(map, prefix + "OperationType", this.OperationType);
            this.SetParamSimple(map, prefix + "RetainDays", this.RetainDays);
            this.SetParamSimple(map, prefix + "ScheduleId", this.ScheduleId);
            this.SetParamSimple(map, prefix + "WeekDays", this.WeekDays);
            this.SetParamSimple(map, prefix + "ExecuteHour", this.ExecuteHour);
            this.SetParamArrayObj(map, prefix + "BackUpTables.", this.BackUpTables);
        }
    }
}

