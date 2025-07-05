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

namespace TencentCloud.Thpc.V20230321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NodeActivity : AbstractModel
    {
        
        /// <summary>
        /// 节点活动所在的实例ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodeInstanceId")]
        public string NodeInstanceId{ get; set; }

        /// <summary>
        /// 节点活动状态。取值范围：<br><li>RUNNING：运行中</li><br><li>SUCCESSFUL：活动成功</li><br><li>FAILED：活动失败</li>
        /// </summary>
        [JsonProperty("NodeActivityStatus")]
        public string NodeActivityStatus{ get; set; }

        /// <summary>
        /// 节点活动状态码。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodeActivityStatusCode")]
        public string NodeActivityStatusCode{ get; set; }

        /// <summary>
        /// 节点活动状态原因。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodeActivityStatusReason")]
        public string NodeActivityStatusReason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeInstanceId", this.NodeInstanceId);
            this.SetParamSimple(map, prefix + "NodeActivityStatus", this.NodeActivityStatus);
            this.SetParamSimple(map, prefix + "NodeActivityStatusCode", this.NodeActivityStatusCode);
            this.SetParamSimple(map, prefix + "NodeActivityStatusReason", this.NodeActivityStatusReason);
        }
    }
}

