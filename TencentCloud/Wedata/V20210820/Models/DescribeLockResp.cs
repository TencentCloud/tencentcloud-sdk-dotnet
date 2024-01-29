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

    public class DescribeLockResp : AbstractModel
    {
        
        /// <summary>
        /// 锁持有人id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LockerId")]
        public long? LockerId{ get; set; }

        /// <summary>
        /// 锁持有人名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LockerName")]
        public string LockerName{ get; set; }

        /// <summary>
        /// 资源路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourcePath")]
        public string ResourcePath{ get; set; }

        /// <summary>
        /// 持有锁标志
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LockedByMe")]
        public bool? LockedByMe{ get; set; }

        /// <summary>
        /// 锁定时间时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LockTime")]
        public long? LockTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LockerId", this.LockerId);
            this.SetParamSimple(map, prefix + "LockerName", this.LockerName);
            this.SetParamSimple(map, prefix + "ResourcePath", this.ResourcePath);
            this.SetParamSimple(map, prefix + "LockedByMe", this.LockedByMe);
            this.SetParamSimple(map, prefix + "LockTime", this.LockTime);
        }
    }
}

