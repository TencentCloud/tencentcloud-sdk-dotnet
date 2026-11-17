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

namespace TencentCloud.Dbs.V20211108.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyBackupPlanSourceInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 备份计划 ID。
        /// </summary>
        [JsonProperty("BackupPlanId")]
        public string BackupPlanId{ get; set; }

        /// <summary>
        /// 新的备份源实例信息。
        /// </summary>
        [JsonProperty("SourceEndPoint")]
        public BackupEndpoint SourceEndPoint{ get; set; }

        /// <summary>
        /// 新的备份名称。
        /// </summary>
        [JsonProperty("BackupPlanName")]
        public string BackupPlanName{ get; set; }

        /// <summary>
        /// 新的备份对象信息。
        /// </summary>
        [JsonProperty("BackupObject")]
        public BackupObject BackupObject{ get; set; }

        /// <summary>
        /// 是否立即启动新的备份任务。支持的取值为：1 - 立即启动；0 - 按备份策略配置的时间启动。
        /// </summary>
        [JsonProperty("BackupNow")]
        public long? BackupNow{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BackupPlanId", this.BackupPlanId);
            this.SetParamObj(map, prefix + "SourceEndPoint.", this.SourceEndPoint);
            this.SetParamSimple(map, prefix + "BackupPlanName", this.BackupPlanName);
            this.SetParamObj(map, prefix + "BackupObject.", this.BackupObject);
            this.SetParamSimple(map, prefix + "BackupNow", this.BackupNow);
        }
    }
}

