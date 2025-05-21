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

    public class CreateSnapshotRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要创建快照的云硬盘ID，可通过[DescribeDisks](/document/product/362/16315)接口查询。
        /// </summary>
        [JsonProperty("DiskId")]
        public string DiskId{ get; set; }

        /// <summary>
        /// 快照名称，不传则新快照名称默认为“未命名”。
        /// </summary>
        [JsonProperty("SnapshotName")]
        public string SnapshotName{ get; set; }

        /// <summary>
        /// 快照的到期时间，到期后该快照将会自动删除,需要传入UTC时间下的ISO-8601标准时间格式,例如:2022-01-08T09:47:55+00:00,。到期时间最小可设置为一天后的当前时间。
        /// </summary>
        [JsonProperty("Deadline")]
        public string Deadline{ get; set; }

        /// <summary>
        /// 云硬盘备份点ID。传入此参数时，将通过备份点创建快照。备份点 ID 可以通过[DescribeDiskBackups](document/product/362/80278)接口查询。
        /// </summary>
        [JsonProperty("DiskBackupId")]
        public string DiskBackupId{ get; set; }

        /// <summary>
        /// 快照绑定的标签。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiskId", this.DiskId);
            this.SetParamSimple(map, prefix + "SnapshotName", this.SnapshotName);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "DiskBackupId", this.DiskBackupId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

