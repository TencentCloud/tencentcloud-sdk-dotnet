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

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeReplicationInstanceSyncStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// 主实例Id
        /// </summary>
        [JsonProperty("RegistryId")]
        public string RegistryId{ get; set; }

        /// <summary>
        /// 复制实例Id
        /// </summary>
        [JsonProperty("ReplicationRegistryId")]
        public string ReplicationRegistryId{ get; set; }

        /// <summary>
        /// 复制实例的地域Id
        /// </summary>
        [JsonProperty("ReplicationRegionId")]
        public ulong? ReplicationRegionId{ get; set; }

        /// <summary>
        /// 是否显示同步日志
        /// </summary>
        [JsonProperty("ShowReplicationLog")]
        public bool? ShowReplicationLog{ get; set; }

        /// <summary>
        /// 日志页号, 默认0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 最大输出条数，默认5，最大为20
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegistryId", this.RegistryId);
            this.SetParamSimple(map, prefix + "ReplicationRegistryId", this.ReplicationRegistryId);
            this.SetParamSimple(map, prefix + "ReplicationRegionId", this.ReplicationRegionId);
            this.SetParamSimple(map, prefix + "ShowReplicationLog", this.ShowReplicationLog);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

