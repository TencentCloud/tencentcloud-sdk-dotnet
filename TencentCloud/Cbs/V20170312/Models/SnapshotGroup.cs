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

    public class SnapshotGroup : AbstractModel
    {
        
        /// <summary>
        /// 快照组ID。
        /// </summary>
        [JsonProperty("SnapshotGroupId")]
        public string SnapshotGroupId{ get; set; }

        /// <summary>
        /// 快照组类型。NORMAL: 普通快照组，非一致性快照。
        /// </summary>
        [JsonProperty("SnapshotGroupType")]
        public string SnapshotGroupType{ get; set; }

        /// <summary>
        /// 快照组是否包含系统盘快照。
        /// </summary>
        [JsonProperty("ContainRootSnapshot")]
        public bool? ContainRootSnapshot{ get; set; }

        /// <summary>
        /// 快照组包含的快照ID列表。
        /// </summary>
        [JsonProperty("SnapshotIdSet")]
        public string[] SnapshotIdSet{ get; set; }

        /// <summary>
        /// <ul>
        ///     <li>NORMAL: 正常</li>
        ///     <li>CREATING: 创建中</li>
        ///     <li>ROLLBACKING: 回滚中</li>
        /// </ul>
        /// </summary>
        [JsonProperty("SnapshotGroupState")]
        public string SnapshotGroupState{ get; set; }

        /// <summary>
        /// 快照组创建进度。
        /// </summary>
        [JsonProperty("Percent")]
        public ulong? Percent{ get; set; }

        /// <summary>
        /// 快照组创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 快照组最新修改时间
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 快照组关联的镜像列表。
        /// </summary>
        [JsonProperty("Images")]
        public Image[] Images{ get; set; }

        /// <summary>
        /// 快照组名称。
        /// </summary>
        [JsonProperty("SnapshotGroupName")]
        public string SnapshotGroupName{ get; set; }

        /// <summary>
        /// 快照组关联的镜像数量。
        /// </summary>
        [JsonProperty("ImageCount")]
        public ulong? ImageCount{ get; set; }

        /// <summary>
        /// 快照组是否永久保留
        /// </summary>
        [JsonProperty("IsPermanent")]
        public bool? IsPermanent{ get; set; }

        /// <summary>
        /// 快照组到期时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeadlineTime")]
        public string DeadlineTime{ get; set; }

        /// <summary>
        /// 来源自动快照策略ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoSnapshotPolicyId")]
        public string AutoSnapshotPolicyId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SnapshotGroupId", this.SnapshotGroupId);
            this.SetParamSimple(map, prefix + "SnapshotGroupType", this.SnapshotGroupType);
            this.SetParamSimple(map, prefix + "ContainRootSnapshot", this.ContainRootSnapshot);
            this.SetParamArraySimple(map, prefix + "SnapshotIdSet.", this.SnapshotIdSet);
            this.SetParamSimple(map, prefix + "SnapshotGroupState", this.SnapshotGroupState);
            this.SetParamSimple(map, prefix + "Percent", this.Percent);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamArrayObj(map, prefix + "Images.", this.Images);
            this.SetParamSimple(map, prefix + "SnapshotGroupName", this.SnapshotGroupName);
            this.SetParamSimple(map, prefix + "ImageCount", this.ImageCount);
            this.SetParamSimple(map, prefix + "IsPermanent", this.IsPermanent);
            this.SetParamSimple(map, prefix + "DeadlineTime", this.DeadlineTime);
            this.SetParamSimple(map, prefix + "AutoSnapshotPolicyId", this.AutoSnapshotPolicyId);
        }
    }
}

