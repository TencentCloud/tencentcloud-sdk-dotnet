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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Snapshot : AbstractModel
    {
        
        /// <summary>
        /// 快照所在的位置。
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// 是否为跨地域复制的快照。取值范围：
        /// <ul>
        ///     <li>true：表示为跨地域复制的快照。</li>
        ///     <li>false：本地域的快照。</li>
        /// </ul>
        /// </summary>
        [JsonProperty("CopyFromRemote")]
        public bool? CopyFromRemote{ get; set; }

        /// <summary>
        /// 快照的状态。取值范围：
        /// <ul>
        ///     <li>NORMAL：正常</li>
        ///     <li>CREATING：创建中</li>
        ///     <li>ROLLBACKING：回滚中</li>
        ///     <li>COPYING_FROM_REMOTE：跨地域复制中</li>
        ///     <li>CHECKING_COPIED：复制校验中</li>
        ///     <li>TORECYCLE：待回收</li>
        /// </ul>
        /// </summary>
        [JsonProperty("SnapshotState")]
        public string SnapshotState{ get; set; }

        /// <summary>
        /// 是否为永久快照。取值范围：
        /// <ul>
        ///     <li>true：永久快照</li>
        ///     <li>false：非永久快照</li>
        /// </ul>
        /// </summary>
        [JsonProperty("IsPermanent")]
        public bool? IsPermanent{ get; set; }

        /// <summary>
        /// 快照名称，用户自定义的快照别名。调用[ModifySnapshotAttribute](/document/product/362/15650)可修改此字段。
        /// </summary>
        [JsonProperty("SnapshotName")]
        public string SnapshotName{ get; set; }

        /// <summary>
        /// 快照到期时间。如果快照为永久保留，此字段为空。
        /// </summary>
        [JsonProperty("DeadlineTime")]
        public string DeadlineTime{ get; set; }

        /// <summary>
        /// 快照创建进度百分比，快照创建成功后此字段恒为100。
        /// </summary>
        [JsonProperty("Percent")]
        public ulong? Percent{ get; set; }

        /// <summary>
        /// 快照关联的镜像列表。
        /// </summary>
        [JsonProperty("Images")]
        public Image[] Images{ get; set; }

        /// <summary>
        /// 快照当前被共享数。
        /// </summary>
        [JsonProperty("ShareReference")]
        public ulong? ShareReference{ get; set; }

        /// <summary>
        /// 快照类型，目前该项取值可以为`PRIVATE_SNAPSHOT`（私有快照）或者`SHARED_SNAPSHOT`（共享快照）
        /// </summary>
        [JsonProperty("SnapshotType")]
        public string SnapshotType{ get; set; }

        /// <summary>
        /// 创建此快照的云硬盘大小，单位GiB。
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// 创建此快照的云硬盘ID。
        /// </summary>
        [JsonProperty("DiskId")]
        public string DiskId{ get; set; }

        /// <summary>
        /// 快照正在跨地域复制的目的地域，若没有则返回`[]`。
        /// </summary>
        [JsonProperty("CopyingToRegions")]
        public string[] CopyingToRegions{ get; set; }

        /// <summary>
        /// 是否为加密盘创建的快照。取值范围：
        /// <ul>
        ///     <li>true：该快照为加密盘创建的</li>
        ///     <li>false：非加密盘创建的快照</li>
        /// </ul>
        /// </summary>
        [JsonProperty("Encrypt")]
        public bool? Encrypt{ get; set; }

        /// <summary>
        /// 快照的创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 快照关联的镜像个数。
        /// </summary>
        [JsonProperty("ImageCount")]
        public ulong? ImageCount{ get; set; }

        /// <summary>
        /// 创建此快照的云硬盘类型。取值范围：
        /// <ul>
        ///     <li>SYSTEM_DISK：系统盘</li>
        ///     <li>DATA_DISK：数据盘</li>
        /// </ul>
        /// </summary>
        [JsonProperty("DiskUsage")]
        public string DiskUsage{ get; set; }

        /// <summary>
        /// 快照ID。
        /// </summary>
        [JsonProperty("SnapshotId")]
        public string SnapshotId{ get; set; }

        /// <summary>
        /// 快照开始共享的时间。
        /// </summary>
        [JsonProperty("TimeStartShare")]
        public string TimeStartShare{ get; set; }

        /// <summary>
        /// 快照绑定的标签列表。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamSimple(map, prefix + "CopyFromRemote", this.CopyFromRemote);
            this.SetParamSimple(map, prefix + "SnapshotState", this.SnapshotState);
            this.SetParamSimple(map, prefix + "IsPermanent", this.IsPermanent);
            this.SetParamSimple(map, prefix + "SnapshotName", this.SnapshotName);
            this.SetParamSimple(map, prefix + "DeadlineTime", this.DeadlineTime);
            this.SetParamSimple(map, prefix + "Percent", this.Percent);
            this.SetParamArrayObj(map, prefix + "Images.", this.Images);
            this.SetParamSimple(map, prefix + "ShareReference", this.ShareReference);
            this.SetParamSimple(map, prefix + "SnapshotType", this.SnapshotType);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "DiskId", this.DiskId);
            this.SetParamArraySimple(map, prefix + "CopyingToRegions.", this.CopyingToRegions);
            this.SetParamSimple(map, prefix + "Encrypt", this.Encrypt);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ImageCount", this.ImageCount);
            this.SetParamSimple(map, prefix + "DiskUsage", this.DiskUsage);
            this.SetParamSimple(map, prefix + "SnapshotId", this.SnapshotId);
            this.SetParamSimple(map, prefix + "TimeStartShare", this.TimeStartShare);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

