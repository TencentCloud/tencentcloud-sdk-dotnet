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

namespace TencentCloud.Goosefs.V20220519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExecutionPlan : AbstractModel
    {
        
        /// <summary>
        /// <p>执行类型</p><p>枚举值：</p><ul><li>scheduled： 指定时间执行</li><li>periodic： 周期执行</li></ul>
        /// </summary>
        [JsonProperty("ExecuteMode")]
        public string ExecuteMode{ get; set; }

        /// <summary>
        /// <p>任务执行时间</p><p>参数格式：2026-07-23 08:30</p><p>入参限制：只有立即执行或者指定时间执行时设置，周期执行不需要设置</p><p>默认值：当前时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecuteAt")]
        public string ExecuteAt{ get; set; }

        /// <summary>
        /// <p>周期执行的时间设置</p><p>入参限制：选择周期执行时必填</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutePeriod")]
        public ExecutePeriodAttribute ExecutePeriod{ get; set; }

        /// <summary>
        /// <p>任务等待时间</p><p>取值范围：[1, 500]</p><p>单位：H</p><p>默认值：12</p><p>任务执行的等待时间，超过时间任务未启动，自动取消</p>
        /// </summary>
        [JsonProperty("WaitTime")]
        public long? WaitTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExecuteMode", this.ExecuteMode);
            this.SetParamSimple(map, prefix + "ExecuteAt", this.ExecuteAt);
            this.SetParamObj(map, prefix + "ExecutePeriod.", this.ExecutePeriod);
            this.SetParamSimple(map, prefix + "WaitTime", this.WaitTime);
        }
    }
}

