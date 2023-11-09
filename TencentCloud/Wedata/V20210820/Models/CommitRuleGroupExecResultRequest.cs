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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CommitRuleGroupExecResultRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 规则组执行ID
        /// </summary>
        [JsonProperty("RuleGroupExecId")]
        public ulong? RuleGroupExecId{ get; set; }

        /// <summary>
        /// 规则组执行状态
        /// </summary>
        [JsonProperty("RuleGroupState")]
        public string RuleGroupState{ get; set; }

        /// <summary>
        /// 规则执行结果集合
        /// </summary>
        [JsonProperty("RuleExecResults")]
        public RunnerRuleExecResult[] RuleExecResults{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "RuleGroupExecId", this.RuleGroupExecId);
            this.SetParamSimple(map, prefix + "RuleGroupState", this.RuleGroupState);
            this.SetParamArrayObj(map, prefix + "RuleExecResults.", this.RuleExecResults);
        }
    }
}

