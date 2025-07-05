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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTaskVersionDsRequest : AbstractModel
    {
        
        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("Task")]
        public BatchCreateTaskVersionDTO Task{ get; set; }

        /// <summary>
        /// 是否需要校验父任务已经提交到调度
        /// </summary>
        [JsonProperty("NeedCheckParentSubmitted")]
        public bool? NeedCheckParentSubmitted{ get; set; }

        /// <summary>
        /// 是否自动运行
        /// </summary>
        [JsonProperty("AutoRun")]
        public bool? AutoRun{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 请求来源，WEB 前端；CLIENT 客户端
        /// </summary>
        [JsonProperty("RequestFromSource")]
        public string RequestFromSource{ get; set; }

        /// <summary>
        /// 告警方式:email-邮件;sms-短信;wecom-企业微信
        /// </summary>
        [JsonProperty("AlarmWays")]
        public string AlarmWays{ get; set; }

        /// <summary>
        /// 告警对象:1-项目管理员，2-任务责任人
        /// </summary>
        [JsonProperty("AlarmRecipientTypes")]
        public string AlarmRecipientTypes{ get; set; }

        /// <summary>
        /// 是否需要校验循环依赖，默认为 true，如果使用了 CheckTaskCycleLink 和 CheckTaskCycleConfiguration 两个接口校验成功可以传 false，后台服务器不再做校验
        /// </summary>
        [JsonProperty("EnableCheckTaskCycleLink")]
        public bool? EnableCheckTaskCycleLink{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Task.", this.Task);
            this.SetParamSimple(map, prefix + "NeedCheckParentSubmitted", this.NeedCheckParentSubmitted);
            this.SetParamSimple(map, prefix + "AutoRun", this.AutoRun);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "RequestFromSource", this.RequestFromSource);
            this.SetParamSimple(map, prefix + "AlarmWays", this.AlarmWays);
            this.SetParamSimple(map, prefix + "AlarmRecipientTypes", this.AlarmRecipientTypes);
            this.SetParamSimple(map, prefix + "EnableCheckTaskCycleLink", this.EnableCheckTaskCycleLink);
        }
    }
}

