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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WaiterItem : AbstractModel
    {
        
        /// <summary>
        /// <p>该边持有或申请的锁模式。</p>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// <p>并行执行子线程 ID。0 表示主线程；大于 0 表示并行计划的 worker。SessionId + ExecutionContextId 组合可唯一区分并行执行下的 worker。</p>
        /// </summary>
        [JsonProperty("ExecutionContextId")]
        public long? ExecutionContextId{ get; set; }

        /// <summary>
        /// <p>进程内部指针，对应 Transactions[].Processes[].ProcessId。</p>
        /// </summary>
        [JsonProperty("ProcessId")]
        public string ProcessId{ get; set; }

        /// <summary>
        /// <p>该边对应进程的 SPID，便于前端直接展示无需回查。</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public long? SessionId{ get; set; }

        /// <summary>
        /// <p>仅 Waiters 边有值。常见值：wait（普通等待）/ convert（锁转换，如从 S 升级到 X）。owner 边无此字段。</p>
        /// </summary>
        [JsonProperty("RequestType")]
        public string RequestType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "ExecutionContextId", this.ExecutionContextId);
            this.SetParamSimple(map, prefix + "ProcessId", this.ProcessId);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "RequestType", this.RequestType);
        }
    }
}

