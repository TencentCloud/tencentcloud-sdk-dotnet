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

namespace TencentCloud.Tat.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScheduleSettings : AbstractModel
    {
        
        /// <summary>
        /// 执行策略：
        /// 
        /// - ONCE：单次执行
        /// - RECURRENCE：周期执行
        /// </summary>
        [JsonProperty("Policy")]
        public string Policy{ get; set; }

        /// <summary>
        /// 触发 Crontab 表达式。Policy 为 RECURRENCE 时，需要指定此字段。Crontab 按北京时间解析。
        /// </summary>
        [JsonProperty("Recurrence")]
        public string Recurrence{ get; set; }

        /// <summary>
        /// 执行器下次执行时间。Policy 为 ONCE 时，需要指定此字段。
        /// 
        /// 时间格式为：YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [JsonProperty("InvokeTime")]
        public string InvokeTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Policy", this.Policy);
            this.SetParamSimple(map, prefix + "Recurrence", this.Recurrence);
            this.SetParamSimple(map, prefix + "InvokeTime", this.InvokeTime);
        }
    }
}

