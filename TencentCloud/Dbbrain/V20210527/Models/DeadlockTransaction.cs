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

    public class DeadlockTransaction : AbstractModel
    {
        
        /// <summary>
        /// <p>事务最终状态。Rollback（被回滚，对应 IsVictim=true）/ Normal（正常，对应 IsVictim=false）/ Unknown（无 victim 信息）。</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>SQL Server 引擎内的事务 ID。同实例短期内唯一。与 Auxiliary 记录里的 transaction_id 对齐。</p>
        /// </summary>
        [JsonProperty("TransactionId")]
        public string TransactionId{ get; set; }

        /// <summary>
        /// <p>本事务是否为牺牲事务。true 表示 SQL Server 已回滚该事务；false 表示正常提交；null 表示 XML 缺 VictimProcessIds 无法判定。</p>
        /// </summary>
        [JsonProperty("IsVictim")]
        public bool? IsVictim{ get; set; }

        /// <summary>
        /// <p>该事务下的进程/会话列表。并行计划下同一事务可能包含多个 worker（SessionId 相同 ExecutionContextId 不同）。</p>
        /// </summary>
        [JsonProperty("Sessions")]
        public DeadlockSession[] Sessions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TransactionId", this.TransactionId);
            this.SetParamSimple(map, prefix + "IsVictim", this.IsVictim);
            this.SetParamArrayObj(map, prefix + "Sessions.", this.Sessions);
        }
    }
}

