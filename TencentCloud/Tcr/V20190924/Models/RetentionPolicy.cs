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

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RetentionPolicy : AbstractModel
    {
        
        /// <summary>
        /// 版本保留策略Id
        /// </summary>
        [JsonProperty("RetentionId")]
        public long? RetentionId{ get; set; }

        /// <summary>
        /// 命名空间的名称
        /// </summary>
        [JsonProperty("NamespaceName")]
        public string NamespaceName{ get; set; }

        /// <summary>
        /// 规则列表
        /// </summary>
        [JsonProperty("RetentionRuleList")]
        public RetentionRule[] RetentionRuleList{ get; set; }

        /// <summary>
        /// 定期执行方式
        /// </summary>
        [JsonProperty("CronSetting")]
        public string CronSetting{ get; set; }

        /// <summary>
        /// 是否启用规则
        /// </summary>
        [JsonProperty("Disabled")]
        public bool? Disabled{ get; set; }

        /// <summary>
        /// 基于当前时间根据cronSetting后下一次任务要执行的时间，仅做参考使用
        /// </summary>
        [JsonProperty("NextExecutionTime")]
        public string NextExecutionTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RetentionId", this.RetentionId);
            this.SetParamSimple(map, prefix + "NamespaceName", this.NamespaceName);
            this.SetParamArrayObj(map, prefix + "RetentionRuleList.", this.RetentionRuleList);
            this.SetParamSimple(map, prefix + "CronSetting", this.CronSetting);
            this.SetParamSimple(map, prefix + "Disabled", this.Disabled);
            this.SetParamSimple(map, prefix + "NextExecutionTime", this.NextExecutionTime);
        }
    }
}

