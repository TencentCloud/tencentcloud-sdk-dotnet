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

    public class Snapshot : AbstractModel
    {
        
        /// <summary>
        /// <p>快照所在的位置。</p>
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// <p>是否为跨地域复制的快照。取值范围：</p><ul>    <li>true：表示为跨地域复制的快照。</li>    <li>false：本地域的快照。</li></ul>
        /// </summary>
        [JsonProperty("CopyFromRemote")]
        public bool? CopyFromRemote{ get; set; }

        /// <summary>
        /// <p>快照的状态。取值范围：</p><ul>    <li>NORMAL：正常</li>    <li>CREATING：创建中</li>    <li>ROLLBACKING：回滚中</li>    <li>COPYING_FROM_REMOTE：跨地域复制中</li>    <li>CHECKING_COPIED：复制校验中</li>    <li>TORECYCLE：待回收</li></ul>
        /// </summary>
        [JsonProperty("SnapshotState")]
        public string SnapshotState{ get; set; }

        /// <summary>
        /// <p>是否为永久快照。取值范围：</p><ul>    <li>true：永久快照</li>    <li>false：非永久快照</li></ul>
        /// </summary>
        [JsonProperty("IsPermanent")]
        public bool? IsPermanent{ get; set; }

        /// <summary>
        /// <p>快照名称，用户自定义的快照别名。调用<a href="/document/product/362/15650">ModifySnapshotAttribute</a>可修改此字段。</p>
        /// </summary>
        [JsonProperty("SnapshotName")]
        public string SnapshotName{ get; set; }

        /// <summary>
        /// <p>快照到期时间。如果快照为永久保留，此字段为空。</p>
        /// </summary>
        [JsonProperty("DeadlineTime")]
        public string DeadlineTime{ get; set; }

        /// <summary>
        /// <p>快照创建进度百分比，快照创建成功后此字段恒为100。</p>
        /// </summary>
        [JsonProperty("Percent")]
        public ulong? Percent{ get; set; }

        /// <summary>
        /// <p>快照关联的镜像列表。</p>
        /// </summary>
        [JsonProperty("Images")]
        public Image[] Images{ get; set; }

        /// <summary>
        /// <p>快照当前被共享数。</p>
        /// </summary>
        [JsonProperty("ShareReference")]
        public ulong? ShareReference{ get; set; }

        /// <summary>
        /// <p>快照类型，目前该项取值可以为<code>PRIVATE_SNAPSHOT</code>（私有快照）或者<code>SHARED_SNAPSHOT</code>（共享快照）</p>
        /// </summary>
        [JsonProperty("SnapshotType")]
        public string SnapshotType{ get; set; }

        /// <summary>
        /// <p>创建此快照的云硬盘大小，单位GiB。</p>
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// <p>创建此快照的云硬盘ID。</p>
        /// </summary>
        [JsonProperty("DiskId")]
        public string DiskId{ get; set; }

        /// <summary>
        /// <p>快照正在跨地域复制的目的地域，若没有则返回<code>[]</code>。</p>
        /// </summary>
        [JsonProperty("CopyingToRegions")]
        public string[] CopyingToRegions{ get; set; }

        /// <summary>
        /// <p>是否为加密盘创建的快照。取值范围：</p><ul>    <li>true：该快照为加密盘创建的</li>    <li>false：非加密盘创建的快照</li></ul>
        /// </summary>
        [JsonProperty("Encrypt")]
        public bool? Encrypt{ get; set; }

        /// <summary>
        /// <p>快照的创建时间。</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>快照关联的镜像个数。</p>
        /// </summary>
        [JsonProperty("ImageCount")]
        public ulong? ImageCount{ get; set; }

        /// <summary>
        /// <p>创建此快照的云硬盘类型。取值范围：</p><ul>    <li>SYSTEM_DISK：系统盘</li>    <li>DATA_DISK：数据盘</li></ul>
        /// </summary>
        [JsonProperty("DiskUsage")]
        public string DiskUsage{ get; set; }

        /// <summary>
        /// <p>快照ID。</p>
        /// </summary>
        [JsonProperty("SnapshotId")]
        public string SnapshotId{ get; set; }

        /// <summary>
        /// <p>快照开始共享的时间。</p>
        /// </summary>
        [JsonProperty("TimeStartShare")]
        public string TimeStartShare{ get; set; }

        /// <summary>
        /// <p>快照绑定的标签列表。</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>快照是否锁定。取值范围：</p><ul>    <li>true：已锁定</li>    <li>false：未锁定</li></ul>
        /// </summary>
        [JsonProperty("IsLocked")]
        public bool? IsLocked{ get; set; }

        /// <summary>
        /// <p>快照记录的最新修改时间</p>
        /// </summary>
        [JsonProperty("LatestModifyTime")]
        public string LatestModifyTime{ get; set; }

        /// <summary>
        /// <p>自动快照策略ID，仅当该快照由自动快照策略方式创建时才会返回。</p>
        /// </summary>
        [JsonProperty("AutoSnapshotPolicyId")]
        public string AutoSnapshotPolicyId{ get; set; }

        /// <summary>
        /// <p>快照模式。取值为 INSTANT_SNAPSHOT 表示极速快照，STANDARD_SNAPSHOT 表示普通快照。</p><p>枚举值：</p><ul><li>INSTANT_SNAPSHOT： 极速快照</li><li>STANDARD_SNAPSHOT： 普通快照</li></ul>
        /// </summary>
        [JsonProperty("SnapshotMode")]
        public string SnapshotMode{ get; set; }


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
            this.SetParamSimple(map, prefix + "IsLocked", this.IsLocked);
            this.SetParamSimple(map, prefix + "LatestModifyTime", this.LatestModifyTime);
            this.SetParamSimple(map, prefix + "AutoSnapshotPolicyId", this.AutoSnapshotPolicyId);
            this.SetParamSimple(map, prefix + "SnapshotMode", this.SnapshotMode);
        }
    }
}

