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

    public class BatchDeleteOpsTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// 批量删除的任务TaskId
        /// </summary>
        [JsonProperty("TaskIdList")]
        public string[] TaskIdList{ get; set; }

        /// <summary>
        /// true : 删除后下游任务可正常运行
        /// false：删除后下游任务不可运行
        /// </summary>
        [JsonProperty("DeleteMode")]
        public bool? DeleteMode{ get; set; }

        /// <summary>
        /// true：通知下游任务责任人
        /// false:  不通知下游任务责任人
        /// </summary>
        [JsonProperty("EnableNotify")]
        public bool? EnableNotify{ get; set; }

        /// <summary>
        /// 项目Id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "TaskIdList.", this.TaskIdList);
            this.SetParamSimple(map, prefix + "DeleteMode", this.DeleteMode);
            this.SetParamSimple(map, prefix + "EnableNotify", this.EnableNotify);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
        }
    }
}

