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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSparkSessionBatchSQLResponse : AbstractModel
    {
        
        /// <summary>
        /// 状态：0：运行中、1：成功、2：失败、3：取消、4：超时；
        /// </summary>
        [JsonProperty("State")]
        public ulong? State{ get; set; }

        /// <summary>
        /// SQL子任务列表，仅展示运行完成的子任务，若某个任务运行失败，后续其它子任务不返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tasks")]
        public BatchSqlTask[] Tasks{ get; set; }

        /// <summary>
        /// 非sql运行的异常事件信息，包含资源创建失败、调度异常，JOB超时等，正常运行下该Event值为空
        /// </summary>
        [JsonProperty("Event")]
        public string Event{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamArrayObj(map, prefix + "Tasks.", this.Tasks);
            this.SetParamSimple(map, prefix + "Event", this.Event);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

