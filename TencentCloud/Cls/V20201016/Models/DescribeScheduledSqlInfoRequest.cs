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

    public class DescribeScheduledSqlInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 分页的偏移量，默认值为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 分页单页限制数目，默认值为20，最大值100。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 任务名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 任务id。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <li>srcTopicName按照【源日志主题名称】进行过滤，模糊匹配。类型：String。必选：否</li>
        /// <li>dstTopicName按照【目标日志主题名称】进行过滤，模糊匹配。类型：String。必选：否</li>
        /// <li>srcTopicId按照【源日志主题ID】进行过滤。类型：String。必选：否</li>
        /// <li>dstTopicId按照【目标日志主题ID】进行过滤。类型：String。必选：否</li>
        /// <li>bizType按照【主题类型】进行过滤，0日志主题 1指标主题。类型：String。必选：否</li>
        /// <li>status按照【任务状态】进行过滤，1：运行；2：停止。类型：String。必选：否</li>
        /// <li>taskName按照【任务名称】进行过滤，模糊匹配。类型：String。必选：否</li>
        /// <li>taskId按照【任务ID】进行过滤，模糊匹配。类型：String。必选：否</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

