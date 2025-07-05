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

namespace TencentCloud.Tke.V20220501.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteClusterMachinesRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群 ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 节点名列表
        /// </summary>
        [JsonProperty("MachineNames")]
        public string[] MachineNames{ get; set; }

        /// <summary>
        /// 删除节点时是否缩容节点池，true为缩容
        /// </summary>
        [JsonProperty("EnableScaleDown")]
        public bool? EnableScaleDown{ get; set; }

        /// <summary>
        /// 集群实例删除时的策略：terminate（销毁实例，仅支持按量计费云主机实例）retain（仅移除，保留实例）
        /// </summary>
        [JsonProperty("InstanceDeleteMode")]
        public string InstanceDeleteMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamArraySimple(map, prefix + "MachineNames.", this.MachineNames);
            this.SetParamSimple(map, prefix + "EnableScaleDown", this.EnableScaleDown);
            this.SetParamSimple(map, prefix + "InstanceDeleteMode", this.InstanceDeleteMode);
        }
    }
}

