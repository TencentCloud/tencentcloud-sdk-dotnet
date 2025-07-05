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

namespace TencentCloud.Dcdb.V20180411.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeUserTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// 任务的状态列表。0-任务启动中；1-任务运行中；2-任务成功；3-任务失败
        /// </summary>
        [JsonProperty("Statuses")]
        public long?[] Statuses{ get; set; }

        /// <summary>
        /// 实例ID列表
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 任务类型列表，当前支持的任务类型有：0-回档任务；1-创建实例任务；2-扩容任务；3-迁移任务；4-删除实例任务；5-重启任务
        /// </summary>
        [JsonProperty("FlowTypes")]
        public long?[] FlowTypes{ get; set; }

        /// <summary>
        /// 任务的创建时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 任务的结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 任务ID的数组
        /// </summary>
        [JsonProperty("UTaskIds")]
        public long?[] UTaskIds{ get; set; }

        /// <summary>
        /// 每次最多返回多少条任务，取值范围为(0,100]，不传的话默认值为20
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 返回任务默认是按照创建时间降序排列，从偏移值Offset处开始返回
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Statuses.", this.Statuses);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamArraySimple(map, prefix + "FlowTypes.", this.FlowTypes);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "UTaskIds.", this.UTaskIds);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

