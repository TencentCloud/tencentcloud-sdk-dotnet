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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HeartBeatResponse : AbstractModel
    {
        
        /// <summary>
        /// 资源唯一路径
        /// </summary>
        [JsonProperty("ResourcePath")]
        public string ResourcePath{ get; set; }

        /// <summary>
        /// 锁持有者id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LockerId")]
        public ulong? LockerId{ get; set; }

        /// <summary>
        /// 锁持有者displayName
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LockerName")]
        public string LockerName{ get; set; }

        /// <summary>
        /// 偷锁标志（有人偷锁为true）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StealFlag")]
        public bool? StealFlag{ get; set; }

        /// <summary>
        /// 持有锁标志（true表示被自己锁定）
        /// </summary>
        [JsonProperty("LockedByMe")]
        public bool? LockedByMe{ get; set; }

        /// <summary>
        /// 资源是否被锁定
        /// </summary>
        [JsonProperty("Locked")]
        public bool? Locked{ get; set; }

        /// <summary>
        /// 资源是否正在被编辑
        /// </summary>
        [JsonProperty("EditFlag")]
        public bool? EditFlag{ get; set; }

        /// <summary>
        /// 资源被锁定时间的时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LockTime")]
        public ulong? LockTime{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourcePath", this.ResourcePath);
            this.SetParamSimple(map, prefix + "LockerId", this.LockerId);
            this.SetParamSimple(map, prefix + "LockerName", this.LockerName);
            this.SetParamSimple(map, prefix + "StealFlag", this.StealFlag);
            this.SetParamSimple(map, prefix + "LockedByMe", this.LockedByMe);
            this.SetParamSimple(map, prefix + "Locked", this.Locked);
            this.SetParamSimple(map, prefix + "EditFlag", this.EditFlag);
            this.SetParamSimple(map, prefix + "LockTime", this.LockTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

