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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AppTriggerGongfengWebhookConfig : AbstractModel
    {
        
        /// <summary>
        /// 监听的工蜂事件标识，原值传递，1 至 20 个，如 push、merge_request。
        /// </summary>
        [JsonProperty("EventList")]
        public string[] EventList{ get; set; }

        /// <summary>
        /// 工蜂项目 ID 或项目路径，不能为空。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 分支规则列表，最多 20 个；空表示全部分支。
        /// </summary>
        [JsonProperty("BranchRuleList")]
        public string[] BranchRuleList{ get; set; }

        /// <summary>
        /// 合并请求动作标识，最多 20 个；监听 merge_request 时必填，如 open、merge。
        /// </summary>
        [JsonProperty("MRActionList")]
        public string[] MRActionList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "EventList.", this.EventList);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArraySimple(map, prefix + "BranchRuleList.", this.BranchRuleList);
            this.SetParamArraySimple(map, prefix + "MRActionList.", this.MRActionList);
        }
    }
}

