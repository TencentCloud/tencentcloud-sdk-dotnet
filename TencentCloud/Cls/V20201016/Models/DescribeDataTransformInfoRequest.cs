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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDataTransformInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// - taskName
        /// 按照【加工任务名称】进行过滤。
        /// 类型：String
        /// 必选：否
        /// 示例：test-task
        /// 
        /// - taskId
        /// 按照【加工任务id】进行过滤。
        /// 类型：String
        /// 必选：否
        /// 示例：a3622556-6402-4942-b4ff-5ae32ec29810
        /// 数据加工任务ID- 通过[获取数据加工任务列表基本信息](https://cloud.tencent.com/document/product/614/72182)获取数据加工任务Id。
        /// 
        /// - topicId
        /// 按照【源topicId】进行过滤。
        /// 类型：String
        /// 必选：否
        /// 示例：756cec3e-a0a5-44c3-85a8-090870582000
        /// 日志主题ID
        /// 通过[获取日志主题列表](https://cloud.tencent.com/document/product/614/56454)获取日志主题Id。
        /// 
        /// - status
        /// 按照【 任务运行状态】进行过滤。 1：准备中，2：运行中，3：停止中，4：已停止
        /// 类型：String
        /// 必选：否
        /// 示例：1
        /// 
        /// - hasServiceLog
        /// 按照【是否开启服务日志】进行过滤。 1：未开启，2：已开启
        /// 类型：String
        /// 必选：否
        /// 示例：1
        /// 
        /// - dstTopicType
        /// 按照【目标topic类型】进行过滤。  1：固定，2：动态
        /// 类型：String
        /// 必选：否
        /// 示例：1
        /// 
        /// 每次请求的Filters的上限为10，Filter.Values的上限为100。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 分页的偏移量，默认值为0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 分页单页限制数目，默认值为20，最大值100。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 默认值为2.   1: 获取单个任务的详细信息 2：获取任务列表
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// Type为1， 此参数必填
        /// 数据加工任务ID- 通过[获取数据加工任务列表基本信息](https://cloud.tencent.com/document/product/614/72182)获取数据加工任务Id。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
        }
    }
}

