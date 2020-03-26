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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBasicAlarmListRequest : AbstractModel
    {
        
        /// <summary>
        /// 接口模块名，当前取值monitor
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// 起始时间，默认一天前的时间戳
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// 结束时间，默认当前时间戳
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 分页参数，每页返回的数量，取值1~100，默认20
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 分页参数，页偏移量，从0开始计数，默认0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 根据发生时间排序，取值ASC或DESC
        /// </summary>
        [JsonProperty("OccurTimeOrder")]
        public string OccurTimeOrder{ get; set; }

        /// <summary>
        /// 根据项目ID过滤
        /// </summary>
        [JsonProperty("ProjectIds")]
        public long?[] ProjectIds{ get; set; }

        /// <summary>
        /// 根据策略类型过滤
        /// </summary>
        [JsonProperty("ViewNames")]
        public string[] ViewNames{ get; set; }

        /// <summary>
        /// 根据告警状态过滤
        /// </summary>
        [JsonProperty("AlarmStatus")]
        public long?[] AlarmStatus{ get; set; }

        /// <summary>
        /// 根据告警对象过滤
        /// </summary>
        [JsonProperty("ObjLike")]
        public string ObjLike{ get; set; }

        /// <summary>
        /// 根据实例组ID过滤
        /// </summary>
        [JsonProperty("InstanceGroupIds")]
        public long?[] InstanceGroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "OccurTimeOrder", this.OccurTimeOrder);
            this.SetParamArraySimple(map, prefix + "ProjectIds.", this.ProjectIds);
            this.SetParamArraySimple(map, prefix + "ViewNames.", this.ViewNames);
            this.SetParamArraySimple(map, prefix + "AlarmStatus.", this.AlarmStatus);
            this.SetParamSimple(map, prefix + "ObjLike", this.ObjLike);
            this.SetParamArraySimple(map, prefix + "InstanceGroupIds.", this.InstanceGroupIds);
        }
    }
}

