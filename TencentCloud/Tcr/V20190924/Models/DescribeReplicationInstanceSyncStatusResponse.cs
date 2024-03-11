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

    public class DescribeReplicationInstanceSyncStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// 同步状态
        /// </summary>
        [JsonProperty("ReplicationStatus")]
        public string ReplicationStatus{ get; set; }

        /// <summary>
        /// 同步完成时间
        /// </summary>
        [JsonProperty("ReplicationTime")]
        public string ReplicationTime{ get; set; }

        /// <summary>
        /// 同步日志
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReplicationLog")]
        public ReplicationLog ReplicationLog{ get; set; }

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
            this.SetParamSimple(map, prefix + "ReplicationStatus", this.ReplicationStatus);
            this.SetParamSimple(map, prefix + "ReplicationTime", this.ReplicationTime);
            this.SetParamObj(map, prefix + "ReplicationLog.", this.ReplicationLog);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

