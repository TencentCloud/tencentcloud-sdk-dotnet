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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScanBaselineRequest : AbstractModel
    {
        
        /// <summary>
        /// 策略id数组(StrategyIdList与CategoryIdList和RuleIdList三选一)
        /// </summary>
        [JsonProperty("StrategyIdList")]
        public ulong?[] StrategyIdList{ get; set; }

        /// <summary>
        /// 基线id数组(StrategyIdList与CategoryIdList和RuleIdList三选一)
        /// </summary>
        [JsonProperty("CategoryIdList")]
        public ulong?[] CategoryIdList{ get; set; }

        /// <summary>
        /// 检测项id数组(StrategyIdList与CategoryIdList和RuleIdList三选一)
        /// </summary>
        [JsonProperty("RuleIdList")]
        public ulong?[] RuleIdList{ get; set; }

        /// <summary>
        /// 选择StrategyIdList时，不需要填写，其他情况必填
        /// </summary>
        [JsonProperty("QuuidList")]
        public string[] QuuidList{ get; set; }

        /// <summary>
        /// 主机Uuid数组
        /// </summary>
        [JsonProperty("UuidList")]
        public string[] UuidList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "StrategyIdList.", this.StrategyIdList);
            this.SetParamArraySimple(map, prefix + "CategoryIdList.", this.CategoryIdList);
            this.SetParamArraySimple(map, prefix + "RuleIdList.", this.RuleIdList);
            this.SetParamArraySimple(map, prefix + "QuuidList.", this.QuuidList);
            this.SetParamArraySimple(map, prefix + "UuidList.", this.UuidList);
        }
    }
}

