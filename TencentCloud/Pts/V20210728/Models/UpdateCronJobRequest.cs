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

namespace TencentCloud.Pts.V20210728.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateCronJobRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 定时任务ID
        /// </summary>
        [JsonProperty("CronJobId")]
        public string CronJobId{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }

        /// <summary>
        /// cron表达式
        /// </summary>
        [JsonProperty("CronExpression")]
        public string CronExpression{ get; set; }

        /// <summary>
        /// 执行频率类型，1:只执行一次; 2:日粒度; 3:周粒度; 4:高级
        /// </summary>
        [JsonProperty("FrequencyType")]
        public long? FrequencyType{ get; set; }

        /// <summary>
        /// 定时任务名字
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 场景ID
        /// </summary>
        [JsonProperty("ScenarioId")]
        public string ScenarioId{ get; set; }

        /// <summary>
        /// 场景名称
        /// </summary>
        [JsonProperty("ScenarioName")]
        public string ScenarioName{ get; set; }

        /// <summary>
        /// 任务发起人
        /// </summary>
        [JsonProperty("JobOwner")]
        public string JobOwner{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Notice ID
        /// </summary>
        [JsonProperty("NoticeId")]
        public string NoticeId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "CronJobId", this.CronJobId);
            this.SetParamSimple(map, prefix + "Note", this.Note);
            this.SetParamSimple(map, prefix + "CronExpression", this.CronExpression);
            this.SetParamSimple(map, prefix + "FrequencyType", this.FrequencyType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ScenarioId", this.ScenarioId);
            this.SetParamSimple(map, prefix + "ScenarioName", this.ScenarioName);
            this.SetParamSimple(map, prefix + "JobOwner", this.JobOwner);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "NoticeId", this.NoticeId);
        }
    }
}

