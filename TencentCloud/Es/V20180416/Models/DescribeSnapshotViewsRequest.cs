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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSnapshotViewsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集群实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string[] InstanceId{ get; set; }

        /// <summary>
        /// <p>快照状态，IN_PROGRESS,SUCCESS,FAILED,PARTIAL</p>
        /// </summary>
        [JsonProperty("State")]
        public string[] State{ get; set; }

        /// <summary>
        /// <p>创建方式: true(手动备份); false(自动备份); 空字符串表示全部</p>
        /// </summary>
        [JsonProperty("UserBackUp")]
        public string UserBackUp{ get; set; }

        /// <summary>
        /// <p>时间范围, 最近多少天, 0表示查询所有时间范围</p>
        /// </summary>
        [JsonProperty("Duration")]
        public ulong? Duration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceId.", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "State.", this.State);
            this.SetParamSimple(map, prefix + "UserBackUp", this.UserBackUp);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
        }
    }
}

