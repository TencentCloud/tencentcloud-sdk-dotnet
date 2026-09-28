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

    public class DeadlockResource : AbstractModel
    {
        
        /// <summary>
        /// <p>锁资源对应的索引名。keylock/ridlock 尤为重要，可判断索引设计是否合理。</p>
        /// </summary>
        [JsonProperty("IndexName")]
        public string IndexName{ get; set; }

        /// <summary>
        /// <p>分区 HoBT ID（从 Attributes.hobtid 抽出）。分区表死锁排查必需字段，可定位到具体物理分区。</p>
        /// </summary>
        [JsonProperty("PartitionId")]
        public string PartitionId{ get; set; }

        /// <summary>
        /// <p>等待该锁资源的进程列表（死锁环的等待边）。</p>
        /// </summary>
        [JsonProperty("Waiters")]
        public WaiterItem[] Waiters{ get; set; }

        /// <summary>
        /// <p>锁资源类型。常见值：keylock / pagelock / objectlock / ridlock / applicationlock / exchangeEvent 等。</p>
        /// </summary>
        [JsonProperty("Kind")]
        public string Kind{ get; set; }

        /// <summary>
        /// <p>锁模式。常见值：X（排他）/ U（更新）/ S（共享）/ IX / IU / RangeS-U / RangeX-X 等。</p>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// <p>关联对象 ID（从 Attributes.associatedObjectId 抽出）。ObjectName 为空时可用于兜底定位对象。</p>
        /// </summary>
        [JsonProperty("AssociatedObjectId")]
        public string AssociatedObjectId{ get; set; }

        /// <summary>
        /// <p>SQL Server 引擎内的锁资源指针，例如 lock26054644a80。环内节点唯一标识，串联 Owners/Waiters。</p>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>锁资源对应的数据库对象名，格式 &#39;数据库.架构.表&#39;，例如 tempdb.dbo.dl_a。applicationlock 无此字段。</p>
        /// </summary>
        [JsonProperty("ObjectName")]
        public string ObjectName{ get; set; }

        /// <summary>
        /// <p>持有该锁资源的进程列表（死锁环的持有边）。</p>
        /// </summary>
        [JsonProperty("Owners")]
        public OwnerItem[] Owners{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IndexName", this.IndexName);
            this.SetParamSimple(map, prefix + "PartitionId", this.PartitionId);
            this.SetParamArrayObj(map, prefix + "Waiters.", this.Waiters);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "AssociatedObjectId", this.AssociatedObjectId);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ObjectName", this.ObjectName);
            this.SetParamArrayObj(map, prefix + "Owners.", this.Owners);
        }
    }
}

