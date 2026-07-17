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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InferenceScheduledScalingAction : AbstractModel
    {
        
        /// <summary>
        /// Cron 表达式，用于描述定时伸缩动作的触发时间。采用 5 字段标准 Cron 格式：分钟 小时 日期 月份 星期。不支持秒字段和年份字段。
        /// </summary>
        [JsonProperty("CronExpression")]
        public string CronExpression{ get; set; }

        /// <summary>
        /// 命中该定时伸缩动作后，推理服务需要调整到的最小实例数。若同一评估窗口内多个定时伸缩动作同时命中，则使用其中最大的 MinInstanceCount。
        /// </summary>
        [JsonProperty("MinInstanceCount")]
        public long? MinInstanceCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CronExpression", this.CronExpression);
            this.SetParamSimple(map, prefix + "MinInstanceCount", this.MinInstanceCount);
        }
    }
}

