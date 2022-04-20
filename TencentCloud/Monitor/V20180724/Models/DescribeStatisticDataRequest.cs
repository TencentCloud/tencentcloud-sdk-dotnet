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

    public class DescribeStatisticDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 所属模块，固定值，为monitor
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// 命名空间，目前只支持QCE/TKE
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 指标名列表
        /// </summary>
        [JsonProperty("MetricNames")]
        public string[] MetricNames{ get; set; }

        /// <summary>
        /// 维度条件，操作符支持=、in
        /// </summary>
        [JsonProperty("Conditions")]
        public MidQueryCondition[] Conditions{ get; set; }

        /// <summary>
        /// 统计粒度。默认取值为300，单位为s；可选的值为60、300、3600、86400
        /// 受存储时长限制，统计粒度与统计的时间范围有关：
        /// 60s：EndTime-StartTime<12小时，且StartTime距当前时间不能超过15天；
        /// 300s：EndTime-StartTime<3天，且StartTime距当前时间不能超过31天；
        /// 3600s：EndTime-StartTime<30天，且StartTime距当前时间不能超过93天；
        /// 86400s：EndTime-StartTime<186天，且StartTime距当前时间不能超过186天。
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// 起始时间，默认为当前时间，如2020-12-08T19:51:23+08:00
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间，默认为当前时间，如2020-12-08T19:51:23+08:00
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 按指定维度groupBy
        /// </summary>
        [JsonProperty("GroupBys")]
        public string[] GroupBys{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamArraySimple(map, prefix + "MetricNames.", this.MetricNames);
            this.SetParamArrayObj(map, prefix + "Conditions.", this.Conditions);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "GroupBys.", this.GroupBys);
        }
    }
}

