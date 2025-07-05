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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourceGroup : AbstractModel
    {
        
        /// <summary>
        /// 资源组id
        /// </summary>
        [JsonProperty("ResourceGroupId")]
        public string ResourceGroupId{ get; set; }

        /// <summary>
        /// 资源组名称
        /// </summary>
        [JsonProperty("ResourceGroupName")]
        public string ResourceGroupName{ get; set; }

        /// <summary>
        /// 可用节点个数(运行中的节点)
        /// </summary>
        [JsonProperty("FreeInstance")]
        public ulong? FreeInstance{ get; set; }

        /// <summary>
        /// 总节点个数(所有节点)
        /// </summary>
        [JsonProperty("TotalInstance")]
        public ulong? TotalInstance{ get; set; }

        /// <summary>
        /// 资资源组已用的资源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UsedResource")]
        public GroupResource UsedResource{ get; set; }

        /// <summary>
        /// 资源组总资源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalResource")]
        public GroupResource TotalResource{ get; set; }

        /// <summary>
        /// 节点信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceSet")]
        public Instance[] InstanceSet{ get; set; }

        /// <summary>
        /// 标签列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceGroupId", this.ResourceGroupId);
            this.SetParamSimple(map, prefix + "ResourceGroupName", this.ResourceGroupName);
            this.SetParamSimple(map, prefix + "FreeInstance", this.FreeInstance);
            this.SetParamSimple(map, prefix + "TotalInstance", this.TotalInstance);
            this.SetParamObj(map, prefix + "UsedResource.", this.UsedResource);
            this.SetParamObj(map, prefix + "TotalResource.", this.TotalResource);
            this.SetParamArrayObj(map, prefix + "InstanceSet.", this.InstanceSet);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
        }
    }
}

