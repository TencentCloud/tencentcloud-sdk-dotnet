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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AutoScaleRecord : AbstractModel
    {
        
        /// <summary>
        /// <p>扩缩容规则名。</p>
        /// </summary>
        [JsonProperty("StrategyName")]
        public string StrategyName{ get; set; }

        /// <summary>
        /// <p>&quot;SCALE_OUT&quot;和&quot;SCALE_IN&quot;，分别表示扩容和缩容。</p>
        /// </summary>
        [JsonProperty("ScaleAction")]
        public string ScaleAction{ get; set; }

        /// <summary>
        /// <p>取值为&quot;SUCCESS&quot;,&quot;FAILED&quot;,&quot;PART_SUCCESS&quot;,&quot;IN_PROCESS&quot;，分别表示成功、失败、部分成功和流程中。</p>
        /// </summary>
        [JsonProperty("ActionStatus")]
        public string ActionStatus{ get; set; }

        /// <summary>
        /// <p>流程触发时间。</p>
        /// </summary>
        [JsonProperty("ActionTime")]
        public string ActionTime{ get; set; }

        /// <summary>
        /// <p>扩缩容相关描述信息。</p>
        /// </summary>
        [JsonProperty("ScaleInfo")]
        public string ScaleInfo{ get; set; }

        /// <summary>
        /// <p>只在ScaleAction为SCALE_OUT时有效。</p>
        /// </summary>
        [JsonProperty("ExpectScaleNum")]
        public long? ExpectScaleNum{ get; set; }

        /// <summary>
        /// <p>流程结束时间。</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>策略类型，按负载或者按时间，1表示负载伸缩，2表示时间伸缩</p>
        /// </summary>
        [JsonProperty("StrategyType")]
        public long? StrategyType{ get; set; }

        /// <summary>
        /// <p>扩容时所使用规格信息。</p>
        /// </summary>
        [JsonProperty("SpecInfo")]
        public string SpecInfo{ get; set; }

        /// <summary>
        /// <p>补偿扩容，0表示不开启，1表示开启</p>
        /// </summary>
        [JsonProperty("CompensateFlag")]
        public long? CompensateFlag{ get; set; }

        /// <summary>
        /// <p>补偿次数</p>
        /// </summary>
        [JsonProperty("CompensateCount")]
        public long? CompensateCount{ get; set; }

        /// <summary>
        /// <p>重试次数</p>
        /// </summary>
        [JsonProperty("RetryCount")]
        public ulong? RetryCount{ get; set; }

        /// <summary>
        /// <p>重试信息</p>
        /// </summary>
        [JsonProperty("RetryInfo")]
        public string RetryInfo{ get; set; }

        /// <summary>
        /// <p>重试英文描述</p>
        /// </summary>
        [JsonProperty("RetryEnReason")]
        public string RetryEnReason{ get; set; }

        /// <summary>
        /// <p>重试描述</p>
        /// </summary>
        [JsonProperty("RetryReason")]
        public string RetryReason{ get; set; }

        /// <summary>
        /// <p>缺失分类</p>
        /// </summary>
        [JsonProperty("ShortageClass")]
        public long? ShortageClass{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StrategyName", this.StrategyName);
            this.SetParamSimple(map, prefix + "ScaleAction", this.ScaleAction);
            this.SetParamSimple(map, prefix + "ActionStatus", this.ActionStatus);
            this.SetParamSimple(map, prefix + "ActionTime", this.ActionTime);
            this.SetParamSimple(map, prefix + "ScaleInfo", this.ScaleInfo);
            this.SetParamSimple(map, prefix + "ExpectScaleNum", this.ExpectScaleNum);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "StrategyType", this.StrategyType);
            this.SetParamSimple(map, prefix + "SpecInfo", this.SpecInfo);
            this.SetParamSimple(map, prefix + "CompensateFlag", this.CompensateFlag);
            this.SetParamSimple(map, prefix + "CompensateCount", this.CompensateCount);
            this.SetParamSimple(map, prefix + "RetryCount", this.RetryCount);
            this.SetParamSimple(map, prefix + "RetryInfo", this.RetryInfo);
            this.SetParamSimple(map, prefix + "RetryEnReason", this.RetryEnReason);
            this.SetParamSimple(map, prefix + "RetryReason", this.RetryReason);
            this.SetParamSimple(map, prefix + "ShortageClass", this.ShortageClass);
        }
    }
}

