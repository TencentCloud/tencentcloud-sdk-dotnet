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

    public class DeleteClusterNodePoolRequest : AbstractModel
    {
        
        /// <summary>
        /// 节点池对应的 ClusterId
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 需要删除的节点池 Id 列表
        /// </summary>
        [JsonProperty("NodePoolIds")]
        public string[] NodePoolIds{ get; set; }

        /// <summary>
        /// 删除节点池时是否保留节点池内节点(节点仍然会被移出集群，但对应的实例不会被销毁)
        /// </summary>
        [JsonProperty("KeepInstance")]
        public bool? KeepInstance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamArraySimple(map, prefix + "NodePoolIds.", this.NodePoolIds);
            this.SetParamSimple(map, prefix + "KeepInstance", this.KeepInstance);
        }
    }
}

