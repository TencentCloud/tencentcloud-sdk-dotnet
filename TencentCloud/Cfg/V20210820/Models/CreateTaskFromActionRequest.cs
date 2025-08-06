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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTaskFromActionRequest : AbstractModel
    {
        
        /// <summary>
        /// 动作ID，可从动作列表接口DescribeActionLibraryList获取
        /// </summary>
        [JsonProperty("TaskActionId")]
        public ulong? TaskActionId{ get; set; }

        /// <summary>
        /// 参与演练的实例ID
        /// </summary>
        [JsonProperty("TaskInstances")]
        public string[] TaskInstances{ get; set; }

        /// <summary>
        /// 演练名称，不填则默认取动作名称
        /// </summary>
        [JsonProperty("TaskTitle")]
        public string TaskTitle{ get; set; }

        /// <summary>
        /// 演练描述，不填则默认取动作描述
        /// </summary>
        [JsonProperty("TaskDescription")]
        public string TaskDescription{ get; set; }

        /// <summary>
        /// 动作通用参数，需要json序列化传入，可以从动作详情接口DescribeActionFieldConfigList获取，不填默认使用动作默认参数
        /// </summary>
        [JsonProperty("TaskActionGeneralConfiguration")]
        public string TaskActionGeneralConfiguration{ get; set; }

        /// <summary>
        /// 动作自定义参数，需要json序列化传入，可以从动作详情接口DescribeActionFieldConfigList获取，不填默认使用动作默认参数，注意：必填参数，是没有默认值的 ，务必保证传入有效值
        /// </summary>
        [JsonProperty("TaskActionCustomConfiguration")]
        public string TaskActionCustomConfiguration{ get; set; }

        /// <summary>
        /// 演练自动暂停时间，单位分钟, 不填则默认为60
        /// </summary>
        [JsonProperty("TaskPauseDuration")]
        public ulong? TaskPauseDuration{ get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [JsonProperty("TaskTags")]
        public TagWithCreate[] TaskTags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskActionId", this.TaskActionId);
            this.SetParamArraySimple(map, prefix + "TaskInstances.", this.TaskInstances);
            this.SetParamSimple(map, prefix + "TaskTitle", this.TaskTitle);
            this.SetParamSimple(map, prefix + "TaskDescription", this.TaskDescription);
            this.SetParamSimple(map, prefix + "TaskActionGeneralConfiguration", this.TaskActionGeneralConfiguration);
            this.SetParamSimple(map, prefix + "TaskActionCustomConfiguration", this.TaskActionCustomConfiguration);
            this.SetParamSimple(map, prefix + "TaskPauseDuration", this.TaskPauseDuration);
            this.SetParamArrayObj(map, prefix + "TaskTags.", this.TaskTags);
        }
    }
}

