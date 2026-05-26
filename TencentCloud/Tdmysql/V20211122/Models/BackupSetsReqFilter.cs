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

namespace TencentCloud.Tdmysql.V20211122.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BackupSetsReqFilter : AbstractModel
    {
        
        /// <summary>
        /// <p>备份方式,多个值用逗号隔开</p><p>枚举值：</p><ul><li>physical： 物理备份</li><li>snapshot： 快照备份</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BackupMethod")]
        public string BackupMethod{ get; set; }

        /// <summary>
        /// <p>备份状态，多个值用逗号隔开，含义说明：等待调度pending， 运行中 running, 成功success,失败 failed</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BackupStatus")]
        public string BackupStatus{ get; set; }

        /// <summary>
        /// <p>备份类型，多个值用逗号隔开，含义说明：全量备份 full</p><p>枚举值：</p><ul><li>full： 全量备份</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BackupType")]
        public string BackupType{ get; set; }

        /// <summary>
        /// <p>备份触发方式</p><p>枚举值：</p><ul><li>0： 自动备份</li><li>1： 手工备份</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ManualBackup")]
        public string ManualBackup{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BackupMethod", this.BackupMethod);
            this.SetParamSimple(map, prefix + "BackupStatus", this.BackupStatus);
            this.SetParamSimple(map, prefix + "BackupType", this.BackupType);
            this.SetParamSimple(map, prefix + "ManualBackup", this.ManualBackup);
        }
    }
}

