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

    public class CommitRuleGroupTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 规则组ID
        /// </summary>
        [JsonProperty("RuleGroupId")]
        public ulong? RuleGroupId{ get; set; }

        /// <summary>
        /// 触发类型 1.手动触发 2.调度事中触发 3.周期调度触发
        /// </summary>
        [JsonProperty("TriggerType")]
        public ulong? TriggerType{ get; set; }

        /// <summary>
        /// 规则配置列表
        /// </summary>
        [JsonProperty("ExecRuleConfig")]
        public RuleConfig[] ExecRuleConfig{ get; set; }

        /// <summary>
        /// 执行配置
        /// </summary>
        [JsonProperty("ExecConfig")]
        public RuleExecConfig ExecConfig{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 该规则运行的执行引擎，不传时会请求该数据源下默认的执行引擎
        /// </summary>
        [JsonProperty("EngineType")]
        public string EngineType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleGroupId", this.RuleGroupId);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamArrayObj(map, prefix + "ExecRuleConfig.", this.ExecRuleConfig);
            this.SetParamObj(map, prefix + "ExecConfig.", this.ExecConfig);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "EngineType", this.EngineType);
        }
    }
}

