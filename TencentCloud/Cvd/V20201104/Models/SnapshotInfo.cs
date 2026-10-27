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

namespace TencentCloud.Cvd.V20201104.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SnapshotInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>快照唯一ID</p>
        /// </summary>
        [JsonProperty("SnapshotId")]
        public string SnapshotId{ get; set; }

        /// <summary>
        /// <p>快照对应的云硬盘ID</p>
        /// </summary>
        [JsonProperty("DiskId")]
        public string DiskId{ get; set; }

        /// <summary>
        /// <p>快照状态，取值如下：<br>NORMAL：正常<br>CREATING：创建中<br>ROLLBACKING：回滚中<br>COPYING_FROM_REMOTE：跨地域复制中<br>CHECKING_COPIED：复制校验中<br>TORECYCLE：待回收。</p>
        /// </summary>
        [JsonProperty("SnapshotState")]
        public string SnapshotState{ get; set; }

        /// <summary>
        /// <p>创建此快照的云硬盘类型。取值范围：<br>SYSTEM_DISK：系统盘<br>DATA_DISK：数据盘。</p>
        /// </summary>
        [JsonProperty("DiskUsage")]
        public string DiskUsage{ get; set; }

        /// <summary>
        /// <p>快照创建的时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

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
        /// <p>是否为永久快照。取值范围：<br>true：永久快照<br>false：非永久快照。</p>
        /// </summary>
        [JsonProperty("IsPermanent")]
        public bool? IsPermanent{ get; set; }

        /// <summary>
        /// <p>快照创建方式，取值:<br>ManualSnapshot：手动创建<br>AutoSnapshot：快照策略自动创建</p>
        /// </summary>
        [JsonProperty("CreateType")]
        public string CreateType{ get; set; }

        /// <summary>
        /// <p>上一次快照回滚完成时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastRollbackTime")]
        public string LastRollbackTime{ get; set; }

        /// <summary>
        /// <p>上一次快照回滚状态，取值：<br>成功：SUCCESS<br>失败：FAILED</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastRollbackState")]
        public string LastRollbackState{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SnapshotId", this.SnapshotId);
            this.SetParamSimple(map, prefix + "DiskId", this.DiskId);
            this.SetParamSimple(map, prefix + "SnapshotState", this.SnapshotState);
            this.SetParamSimple(map, prefix + "DiskUsage", this.DiskUsage);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "DeadlineTime", this.DeadlineTime);
            this.SetParamSimple(map, prefix + "Percent", this.Percent);
            this.SetParamSimple(map, prefix + "IsPermanent", this.IsPermanent);
            this.SetParamSimple(map, prefix + "CreateType", this.CreateType);
            this.SetParamSimple(map, prefix + "LastRollbackTime", this.LastRollbackTime);
            this.SetParamSimple(map, prefix + "LastRollbackState", this.LastRollbackState);
        }
    }
}

