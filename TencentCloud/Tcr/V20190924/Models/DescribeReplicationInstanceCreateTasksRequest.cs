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

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeReplicationInstanceCreateTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// 同步实例Id，见实例返回列表中的同步实例ID
        /// </summary>
        [JsonProperty("ReplicationRegistryId")]
        public string ReplicationRegistryId{ get; set; }

        /// <summary>
        /// 同步实例的地域ID，见实例返回列表中地域ID
        /// </summary>
        [JsonProperty("ReplicationRegionId")]
        public ulong? ReplicationRegionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReplicationRegistryId", this.ReplicationRegistryId);
            this.SetParamSimple(map, prefix + "ReplicationRegionId", this.ReplicationRegionId);
        }
    }
}

