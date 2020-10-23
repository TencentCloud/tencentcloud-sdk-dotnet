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

namespace TencentCloud.Cat.V20180409.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlarmInfo : AbstractModel
    {
        
        /// <summary>
        /// 告警对象的名称
        /// </summary>
        [JsonProperty("ObjName")]
        public string ObjName{ get; set; }

        /// <summary>
        /// 告警发生的时间
        /// </summary>
        [JsonProperty("FirstOccurTime")]
        public string FirstOccurTime{ get; set; }

        /// <summary>
        /// 告警结束的时间
        /// </summary>
        [JsonProperty("LastOccurTime")]
        public string LastOccurTime{ get; set; }

        /// <summary>
        /// 告警状态。1 表示已恢复，0 表示未恢复，2表示数据不足
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 告警的内容
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 拨测任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong? TaskId{ get; set; }

        /// <summary>
        /// 特征项名字
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// 特征项数值
        /// </summary>
        [JsonProperty("MetricValue")]
        public string MetricValue{ get; set; }

        /// <summary>
        /// 告警对象的ID
        /// </summary>
        [JsonProperty("ObjId")]
        public string ObjId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ObjName", this.ObjName);
            this.SetParamSimple(map, prefix + "FirstOccurTime", this.FirstOccurTime);
            this.SetParamSimple(map, prefix + "LastOccurTime", this.LastOccurTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "MetricValue", this.MetricValue);
            this.SetParamSimple(map, prefix + "ObjId", this.ObjId);
        }
    }
}

