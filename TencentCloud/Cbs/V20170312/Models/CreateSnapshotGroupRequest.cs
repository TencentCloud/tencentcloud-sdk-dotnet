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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSnapshotGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要创建快照组的云硬盘ID列表，必须选择挂载在同一实例上的盘列表。
        /// </summary>
        [JsonProperty("DiskIds")]
        public string[] DiskIds{ get; set; }

        /// <summary>
        /// 快照组名称，快照组关联的快照也会继承快照组的名称。例如：快照组名称为testSnapshotGroup，快照组关联两个快照，则两个快照的名称分别为testSnapshotGroup_0，testSnapshotGroup_1。
        /// </summary>
        [JsonProperty("SnapshotGroupName")]
        public string SnapshotGroupName{ get; set; }

        /// <summary>
        /// 快照组需要绑定的标签列表。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DiskIds.", this.DiskIds);
            this.SetParamSimple(map, prefix + "SnapshotGroupName", this.SnapshotGroupName);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

