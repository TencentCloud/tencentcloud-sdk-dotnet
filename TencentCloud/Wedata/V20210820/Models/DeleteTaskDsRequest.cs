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

    public class DeleteTaskDsRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目Id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 是否删除脚本
        /// true：删除
        /// false：不删除
        /// 不传默认false
        /// </summary>
        [JsonProperty("DeleteScript")]
        public bool? DeleteScript{ get; set; }

        /// <summary>
        /// 任务操作是否消息通知下游任务责任人true：通知
        /// false：不通知
        /// 不传默认false
        /// </summary>
        [JsonProperty("OperateInform")]
        public bool? OperateInform{ get; set; }

        /// <summary>
        /// 任务ID
        /// 和VirtualTaskId选填一个
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 虚拟任务id
        /// 和TaskId选填一个
        /// </summary>
        [JsonProperty("VirtualTaskId")]
        public string VirtualTaskId{ get; set; }

        /// <summary>
        /// 虚拟任务标记
        /// true：是虚拟任务
        /// false：不是虚拟任务
        /// 不传默认false
        /// </summary>
        [JsonProperty("VirtualFlag")]
        public bool? VirtualFlag{ get; set; }

        /// <summary>
        /// 任务删除方式
        /// true：不针对下游任务实例进行强制失败
        /// false：针对下游任务实例进行强制失败
        /// 不传默认false
        /// </summary>
        [JsonProperty("DeleteMode")]
        public bool? DeleteMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "DeleteScript", this.DeleteScript);
            this.SetParamSimple(map, prefix + "OperateInform", this.OperateInform);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "VirtualTaskId", this.VirtualTaskId);
            this.SetParamSimple(map, prefix + "VirtualFlag", this.VirtualFlag);
            this.SetParamSimple(map, prefix + "DeleteMode", this.DeleteMode);
        }
    }
}

