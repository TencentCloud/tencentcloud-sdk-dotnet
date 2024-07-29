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
        /// 
        /// - taskId
        /// 按照【加工任务id】进行过滤。
        /// 类型：String
        /// 必选：否
        /// 
        /// - topicId
        /// 按照【源topicId】进行过滤。
        /// 类型：String
        /// 必选：否
        /// - status
        /// 按照【 任务运行状态】进行过滤。 1：准备中，2：运行中，3：停止中，4：已停止
        /// 类型：String
        /// 必选：否
        /// - hasServiceLog
        /// 按照【是否开启服务日志】进行过滤。 1：未开启，2：已开启
        /// 类型：String
        /// 必选：否
        /// - dstTopicType
        /// 按照【目标topic类型】进行过滤。  1：固定，2：动态
        /// 类型：String
        /// 必选：否
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

