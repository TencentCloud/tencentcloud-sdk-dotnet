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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FirewallTemplateApplyRecord : AbstractModel
    {
        
        /// <summary>
        /// 任务ID。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 应用模板的时间。
        /// </summary>
        [JsonProperty("ApplyTime")]
        public string ApplyTime{ get; set; }

        /// <summary>
        /// 模板规则列表。
        /// </summary>
        [JsonProperty("TemplateRuleSet")]
        public FirewallTemplateRule[] TemplateRuleSet{ get; set; }

        /// <summary>
        /// 应用模板的执行状态。
        /// 
        /// - SUCCESS：成功
        /// - FAILED：失败
        /// </summary>
        [JsonProperty("ApplyState")]
        public string ApplyState{ get; set; }

        /// <summary>
        /// 应用成功的实例数量。
        /// </summary>
        [JsonProperty("SuccessCount")]
        public long? SuccessCount{ get; set; }

        /// <summary>
        /// 应用失败的实例数量。
        /// </summary>
        [JsonProperty("FailedCount")]
        public long? FailedCount{ get; set; }

        /// <summary>
        /// 正在应用中的实例数量。
        /// </summary>
        [JsonProperty("RunningCount")]
        public long? RunningCount{ get; set; }

        /// <summary>
        /// 应用模板的执行细节。
        /// </summary>
        [JsonProperty("ApplyDetailSet")]
        public FirewallTemplateApplyRecordDetail[] ApplyDetailSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "ApplyTime", this.ApplyTime);
            this.SetParamArrayObj(map, prefix + "TemplateRuleSet.", this.TemplateRuleSet);
            this.SetParamSimple(map, prefix + "ApplyState", this.ApplyState);
            this.SetParamSimple(map, prefix + "SuccessCount", this.SuccessCount);
            this.SetParamSimple(map, prefix + "FailedCount", this.FailedCount);
            this.SetParamSimple(map, prefix + "RunningCount", this.RunningCount);
            this.SetParamArrayObj(map, prefix + "ApplyDetailSet.", this.ApplyDetailSet);
        }
    }
}

