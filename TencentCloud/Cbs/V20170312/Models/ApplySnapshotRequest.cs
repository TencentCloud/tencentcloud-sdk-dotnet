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

    public class ApplySnapshotRequest : AbstractModel
    {
        
        /// <summary>
        /// 快照ID, 可通过[DescribeSnapshots](/document/product/362/15647)查询。
        /// </summary>
        [JsonProperty("SnapshotId")]
        public string SnapshotId{ get; set; }

        /// <summary>
        /// 快照原云硬盘ID，可通过[DescribeDisks](/document/product/362/16315)接口查询。
        /// </summary>
        [JsonProperty("DiskId")]
        public string DiskId{ get; set; }

        /// <summary>
        /// 回滚前是否执行自动关机，仅支持回滚快照至已挂载的云硬盘时传入。
        /// 此参数为true时，AutoStartInstance才能为true。
        /// </summary>
        [JsonProperty("AutoStopInstance")]
        public bool? AutoStopInstance{ get; set; }

        /// <summary>
        /// 回滚完成后是否自动开机，仅支持回滚快照至已挂载的云硬盘时传入。该参数传入时，需要同时传入AutoStopInstance参数。
        /// </summary>
        [JsonProperty("AutoStartInstance")]
        public bool? AutoStartInstance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SnapshotId", this.SnapshotId);
            this.SetParamSimple(map, prefix + "DiskId", this.DiskId);
            this.SetParamSimple(map, prefix + "AutoStopInstance", this.AutoStopInstance);
            this.SetParamSimple(map, prefix + "AutoStartInstance", this.AutoStartInstance);
        }
    }
}

