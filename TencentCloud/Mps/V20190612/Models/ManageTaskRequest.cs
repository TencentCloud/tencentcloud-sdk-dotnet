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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ManageTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 操作类型，取值范围：
        /// <ul>
        /// <li>Abort：终止任务。使用说明：
        /// <ul><li>若 [任务类型](/document/product/862/37614#3.-.E8.BE.93.E5.87.BA.E5.8F.82.E6.95.B0) 为直播流处理任务（LiveStreamProcessTask），支持终止 [任务状态](/document/product/862/37614#3.-.E8.BE.93.E5.87.BA.E5.8F.82.E6.95.B0) 为等待中（WAITING）或处理中（PROCESSING）的任务；</li>
        /// <li>否则，对于其他 [任务类型](/document/product/862/37614#3.-.E8.BE.93.E5.87.BA.E5.8F.82.E6.95.B0)，只支持终止 [任务状态](/document/product/862/37614#3.-.E8.BE.93.E5.87.BA.E5.8F.82.E6.95.B0) 为等待中（WAITING）的任务。</li></ul>
        /// </li></ul>
        /// </summary>
        [JsonProperty("OperationType")]
        public string OperationType{ get; set; }

        /// <summary>
        /// 视频处理的任务 ID。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OperationType", this.OperationType);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
        }
    }
}

