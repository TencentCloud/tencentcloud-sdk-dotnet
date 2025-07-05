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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRunningTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用的SdkAppID
        /// </summary>
        [JsonProperty("SdkAppID")]
        public long? SdkAppID{ get; set; }

        /// <summary>
        /// 指定需要获取的任务类型。
        /// 有效取值如下：
        /// - TranscodeH5: 动态转码任务，文档转HTML5页面
        /// - TranscodeJPG: 静态转码任务，文档转图片
        /// - WhiteboardPush: 白板推流任务
        /// - OnlineRecord: 实时录制任务
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// 分页获取时的任务偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 每次获取任务列表时最大获取任务数，默认值为100。
        /// 有效取值范围：[1, 500]
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppID", this.SdkAppID);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

