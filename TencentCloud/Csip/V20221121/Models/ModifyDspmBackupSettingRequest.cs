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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDspmBackupSettingRequest : AbstractModel
    {
        
        /// <summary>
        /// 集团账号的成员id
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// 备份日志保留时长
        /// </summary>
        [JsonProperty("BackupLogSaveTime")]
        public long? BackupLogSaveTime{ get; set; }

        /// <summary>
        /// 恢复日志保留时长
        /// </summary>
        [JsonProperty("RestoreLogSaveTime")]
        public long? RestoreLogSaveTime{ get; set; }

        /// <summary>
        /// 日志最大生命周期限制
        /// </summary>
        [JsonProperty("LogMaxSaveTime")]
        public long? LogMaxSaveTime{ get; set; }

        /// <summary>
        /// 在线日志最大天数限制
        /// </summary>
        [JsonProperty("OnlineLogMaxSaveTime")]
        public long? OnlineLogMaxSaveTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamSimple(map, prefix + "BackupLogSaveTime", this.BackupLogSaveTime);
            this.SetParamSimple(map, prefix + "RestoreLogSaveTime", this.RestoreLogSaveTime);
            this.SetParamSimple(map, prefix + "LogMaxSaveTime", this.LogMaxSaveTime);
            this.SetParamSimple(map, prefix + "OnlineLogMaxSaveTime", this.OnlineLogMaxSaveTime);
        }
    }
}

