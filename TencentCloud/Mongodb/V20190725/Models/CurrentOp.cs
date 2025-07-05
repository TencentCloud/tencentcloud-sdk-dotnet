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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CurrentOp : AbstractModel
    {
        
        /// <summary>
        /// 操作序号。
        /// </summary>
        [JsonProperty("OpId")]
        public long? OpId{ get; set; }

        /// <summary>
        /// 操作所在的命名空间，形式如db.collection。
        /// </summary>
        [JsonProperty("Ns")]
        public string Ns{ get; set; }

        /// <summary>
        /// 操作执行语句。
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// 操作类型，可能的取值：aggregate、count、delete、distinct、find、findAndModify、getMore、insert、mapReduce、update和command。
        /// </summary>
        [JsonProperty("Op")]
        public string Op{ get; set; }

        /// <summary>
        /// 操作所在的分片名称。
        /// </summary>
        [JsonProperty("ReplicaSetName")]
        public string ReplicaSetName{ get; set; }

        /// <summary>
        /// 操作所在的节点名称。
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// 操作详细信息。
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// 筛选条件，节点状态，可能的取值为：Primary、Secondary。
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 操作已执行时间（ms）。
        /// </summary>
        [JsonProperty("MicrosecsRunning")]
        public ulong? MicrosecsRunning{ get; set; }

        /// <summary>
        /// 当前操作所在节点信息。
        /// </summary>
        [JsonProperty("ExecNode")]
        public string ExecNode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OpId", this.OpId);
            this.SetParamSimple(map, prefix + "Ns", this.Ns);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "Op", this.Op);
            this.SetParamSimple(map, prefix + "ReplicaSetName", this.ReplicaSetName);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "MicrosecsRunning", this.MicrosecsRunning);
            this.SetParamSimple(map, prefix + "ExecNode", this.ExecNode);
        }
    }
}

