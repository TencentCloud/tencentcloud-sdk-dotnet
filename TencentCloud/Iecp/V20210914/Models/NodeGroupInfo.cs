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

namespace TencentCloud.Iecp.V20210914.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NodeGroupInfo : AbstractModel
    {
        
        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// NodeGroup名称
        /// </summary>
        [JsonProperty("NodeGroupName")]
        public string NodeGroupName{ get; set; }

        /// <summary>
        /// DeploymentGrid数组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeploymentGridList")]
        public GridDetail[] DeploymentGridList{ get; set; }

        /// <summary>
        /// StatefulSetGrid数组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StatefulSetGridList")]
        public GridDetail[] StatefulSetGridList{ get; set; }

        /// <summary>
        /// 是否平台保护
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Protect")]
        public bool? Protect{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "NodeGroupName", this.NodeGroupName);
            this.SetParamArrayObj(map, prefix + "DeploymentGridList.", this.DeploymentGridList);
            this.SetParamArrayObj(map, prefix + "StatefulSetGridList.", this.StatefulSetGridList);
            this.SetParamSimple(map, prefix + "Protect", this.Protect);
        }
    }
}

