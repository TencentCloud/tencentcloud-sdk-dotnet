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

namespace TencentCloud.Vm.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTaskDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// 该字段表示创建视频审核任务后返回的任务ID（在Results参数中），用于标识需要查询任务详情的审核任务。
        /// <br>备注：查询接口单次最大查询量为**20条每次**。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 该布尔字段表示是否展示全部的视频片段，取值：True(展示全部的视频分片)、False(只展示命中审核规则的视频分片)；默认值为False。
        /// </summary>
        [JsonProperty("ShowAllSegments")]
        public bool? ShowAllSegments{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "ShowAllSegments", this.ShowAllSegments);
        }
    }
}

