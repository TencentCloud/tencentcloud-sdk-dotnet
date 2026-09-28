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

    public class OwnerItem : AbstractModel
    {
        
        /// <summary>
        /// <p>锁模式。常见值：X（排他）/ U（更新）/ S（共享）/ IX / IU / RangeS-U / RangeX-X 等。</p>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// <p>该边对应进程的并行执行子线程 ID。</p>
        /// </summary>
        [JsonProperty("ExecutionContextId")]
        public long? ExecutionContextId{ get; set; }

        /// <summary>
        /// <p>SQL Server 引擎内的进程指针，例如 process260256c7468。与 Resources.Owners/Waiters.ProcessId 拼接死锁环。partial 事件为 null。</p>
        /// </summary>
        [JsonProperty("ProcessId")]
        public string ProcessId{ get; set; }

        /// <summary>
        /// <p>SQL Server 会话 ID。日志排查主键。</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public long? SessionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "ExecutionContextId", this.ExecutionContextId);
            this.SetParamSimple(map, prefix + "ProcessId", this.ProcessId);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
        }
    }
}

