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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MonitorTime : AbstractModel
    {
        
        /// <summary>
        /// <p>执行周期， 可选值：<code>Period</code>、<code>Fixed</code>、<code>Cron</code>。</p><ul><li>Period：固定频率</li><li>Fixed：固定时间</li><li>Cron：Cron表达式</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>执行的周期，或者定制执行的时间节点。单位为分钟，取值范围为1~1440。<br>当type为<code>Period</code>,<code>Fixed</code>时，time字段生效。</p>
        /// </summary>
        [JsonProperty("Time")]
        public long? Time{ get; set; }

        /// <summary>
        /// <p>执行的周期cron表达式。示例：<code>0/1 * * * *</code> 从左到右每个field的含义 Minutes field(分钟), Hours field(小时),Day of month field(日期),Month field(月份),Day of week field(星期)， 不支持秒级别。当type为<code>Cron</code>时，CronExpression字段生效。</p>
        /// </summary>
        [JsonProperty("CronExpression")]
        public string CronExpression{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "CronExpression", this.CronExpression);
        }
    }
}

