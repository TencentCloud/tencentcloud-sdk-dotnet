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

    public class DescribeInstanceDetailInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 实例数据时间
        /// </summary>
        [JsonProperty("CurRunDate")]
        public string CurRunDate{ get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 实例的第几次执行
        /// </summary>
        [JsonProperty("LifeRound")]
        public long? LifeRound{ get; set; }

        /// <summary>
        /// 生命周期查询起始index
        /// </summary>
        [JsonProperty("LifeRoundStartIndex")]
        public long? LifeRoundStartIndex{ get; set; }

        /// <summary>
        /// 生命周期查询批次数量
        /// </summary>
        [JsonProperty("LifeRoundSize")]
        public long? LifeRoundSize{ get; set; }

        /// <summary>
        /// 生命周期总数，可省略
        /// </summary>
        [JsonProperty("TotalLifeRound")]
        public string TotalLifeRound{ get; set; }

        /// <summary>
        /// 动态加载日志标识
        /// </summary>
        [JsonProperty("Dynamic")]
        public bool? Dynamic{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "CurRunDate", this.CurRunDate);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "LifeRound", this.LifeRound);
            this.SetParamSimple(map, prefix + "LifeRoundStartIndex", this.LifeRoundStartIndex);
            this.SetParamSimple(map, prefix + "LifeRoundSize", this.LifeRoundSize);
            this.SetParamSimple(map, prefix + "TotalLifeRound", this.TotalLifeRound);
            this.SetParamSimple(map, prefix + "Dynamic", this.Dynamic);
        }
    }
}

