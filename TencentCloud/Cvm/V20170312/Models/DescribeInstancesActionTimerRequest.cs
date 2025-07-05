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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstancesActionTimerRequest : AbstractModel
    {
        
        /// <summary>
        /// 定时任务ID列表。
        /// </summary>
        [JsonProperty("ActionTimerIds")]
        public string[] ActionTimerIds{ get; set; }

        /// <summary>
        /// 按照一个或者多个实例ID查询。可通过 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728) 接口返回值中的`InstanceId`获取。
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 定时器动作，目前仅支持销毁一个值：TerminateInstances。
        /// </summary>
        [JsonProperty("TimerAction")]
        public string TimerAction{ get; set; }

        /// <summary>
        /// 定时任务执行时间的结束范围，用于条件筛选，格式如2018-05-01 19:00:00。
        /// </summary>
        [JsonProperty("EndActionTime")]
        public string EndActionTime{ get; set; }

        /// <summary>
        /// 定时任务执行时间的开始范围，用于条件筛选，格式如2018-05-01 19:00:00。
        /// </summary>
        [JsonProperty("StartActionTime")]
        public string StartActionTime{ get; set; }

        /// <summary>
        /// 定时任务状态列表。<br><li>UNDO：未执行</li> <li>DOING：正在执行</li><li>DONE：执行完成。</li>
        /// </summary>
        [JsonProperty("StatusList")]
        public string[] StatusList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ActionTimerIds.", this.ActionTimerIds);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "TimerAction", this.TimerAction);
            this.SetParamSimple(map, prefix + "EndActionTime", this.EndActionTime);
            this.SetParamSimple(map, prefix + "StartActionTime", this.StartActionTime);
            this.SetParamArraySimple(map, prefix + "StatusList.", this.StatusList);
        }
    }
}

