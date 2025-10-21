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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CompareOptions : AbstractModel
    {
        
        /// <summary>
        /// 对比方式：dataCheck(完整数据对比)、sampleDataCheck(抽样数据对比)、rowsCount(行数对比), 默认为dataCheck
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// 抽样比例;范围0,100。默认为100
        /// </summary>
        [JsonProperty("SampleRate")]
        public long? SampleRate{ get; set; }

        /// <summary>
        /// 线程数，取值1-8，默认为1
        /// </summary>
        [JsonProperty("ThreadCount")]
        public long? ThreadCount{ get; set; }

        /// <summary>
        /// 对比类型：builtin（内置校验）、independent（独立校验）。默认为builtin，mongodb及redis链路不支持独立校验。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 校验类型，枚举值：structureCheck-结构校验(目前仅postgresql支持)、full-全量校验、increment-增量校验(如果勾选了增量校验，Method只能选dataCheck)、advanceObject-数据库信息校验(目前仅mongodb支持) 
        /// </summary>
        [JsonProperty("CompareMode")]
        public string[] CompareMode{ get; set; }

        /// <summary>
        /// 复检次数
        /// </summary>
        [JsonProperty("ReCheckTime")]
        public long? ReCheckTime{ get; set; }

        /// <summary>
        /// 复检时间间隔，单位为分钟，取值 1-60
        /// </summary>
        [JsonProperty("ReCheckInterval")]
        public long? ReCheckInterval{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
            this.SetParamSimple(map, prefix + "ThreadCount", this.ThreadCount);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArraySimple(map, prefix + "CompareMode.", this.CompareMode);
            this.SetParamSimple(map, prefix + "ReCheckTime", this.ReCheckTime);
            this.SetParamSimple(map, prefix + "ReCheckInterval", this.ReCheckInterval);
        }
    }
}

