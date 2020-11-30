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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloneItem : AbstractModel
    {
        
        /// <summary>
        /// 克隆任务的源实例Id。
        /// </summary>
        [JsonProperty("SrcInstanceId")]
        public string SrcInstanceId{ get; set; }

        /// <summary>
        /// 克隆任务的新产生实例Id。
        /// </summary>
        [JsonProperty("DstInstanceId")]
        public string DstInstanceId{ get; set; }

        /// <summary>
        /// 克隆任务对应的任务列表Id。
        /// </summary>
        [JsonProperty("CloneJobId")]
        public long? CloneJobId{ get; set; }

        /// <summary>
        /// 克隆实例使用的策略， 包括以下类型：  timepoint:指定时间点回档，  backupset: 指定备份文件回档。
        /// </summary>
        [JsonProperty("RollbackStrategy")]
        public string RollbackStrategy{ get; set; }

        /// <summary>
        /// 克隆实例回档的时间点。
        /// </summary>
        [JsonProperty("RollbackTargetTime")]
        public string RollbackTargetTime{ get; set; }

        /// <summary>
        /// 任务开始时间。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 任务结束时间。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 任务状态，包括以下状态：initial,running,wait_complete,success,failed
        /// </summary>
        [JsonProperty("TaskStatus")]
        public string TaskStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SrcInstanceId", this.SrcInstanceId);
            this.SetParamSimple(map, prefix + "DstInstanceId", this.DstInstanceId);
            this.SetParamSimple(map, prefix + "CloneJobId", this.CloneJobId);
            this.SetParamSimple(map, prefix + "RollbackStrategy", this.RollbackStrategy);
            this.SetParamSimple(map, prefix + "RollbackTargetTime", this.RollbackTargetTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
        }
    }
}

