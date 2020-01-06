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

namespace TencentCloud.Bm.V20180423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeOperationResultResponse : AbstractModel
    {
        
        /// <summary>
        /// 任务的整体状态，取值如下：<br>
        /// 1：成功<br>
        /// 2：失败<br>
        /// 3：部分成功，部分失败<br>
        /// 4：未完成<br>
        /// 5：部分成功，部分未完成<br>
        /// 6：部分未完成，部分失败<br>
        /// 7：部分未完成，部分失败，部分成功
        /// </summary>
        [JsonProperty("TaskStatus")]
        public ulong? TaskStatus{ get; set; }

        /// <summary>
        /// 各实例对应任务的状态ID
        /// </summary>
        [JsonProperty("SubtaskStatusSet")]
        public SubtaskStatus[] SubtaskStatusSet{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamArrayObj(map, prefix + "SubtaskStatusSet.", this.SubtaskStatusSet);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

