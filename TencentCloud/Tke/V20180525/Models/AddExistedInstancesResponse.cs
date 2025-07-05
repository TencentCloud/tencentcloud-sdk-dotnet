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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddExistedInstancesResponse : AbstractModel
    {
        
        /// <summary>
        /// 失败的节点ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailedInstanceIds")]
        public string[] FailedInstanceIds{ get; set; }

        /// <summary>
        /// 成功的节点ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SuccInstanceIds")]
        public string[] SuccInstanceIds{ get; set; }

        /// <summary>
        /// 超时未返回出来节点的ID(可能失败，也可能成功)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeoutInstanceIds")]
        public string[] TimeoutInstanceIds{ get; set; }

        /// <summary>
        /// 失败的节点的失败原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailedReasons")]
        public string[] FailedReasons{ get; set; }

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
            this.SetParamArraySimple(map, prefix + "FailedInstanceIds.", this.FailedInstanceIds);
            this.SetParamArraySimple(map, prefix + "SuccInstanceIds.", this.SuccInstanceIds);
            this.SetParamArraySimple(map, prefix + "TimeoutInstanceIds.", this.TimeoutInstanceIds);
            this.SetParamArraySimple(map, prefix + "FailedReasons.", this.FailedReasons);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

