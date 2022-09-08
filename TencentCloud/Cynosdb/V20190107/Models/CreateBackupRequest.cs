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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateBackupRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 备份类型, 可选值：logic，逻辑备份；snapshot，物理备份
        /// </summary>
        [JsonProperty("BackupType")]
        public string BackupType{ get; set; }

        /// <summary>
        /// 备份的库, 只在 BackupType 为 logic 时有效
        /// </summary>
        [JsonProperty("BackupDatabases")]
        public string[] BackupDatabases{ get; set; }

        /// <summary>
        /// 备份的表, 只在 BackupType 为 logic 时有效
        /// </summary>
        [JsonProperty("BackupTables")]
        public DatabaseTables[] BackupTables{ get; set; }

        /// <summary>
        /// 备注名
        /// </summary>
        [JsonProperty("BackupName")]
        public string BackupName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "BackupType", this.BackupType);
            this.SetParamArraySimple(map, prefix + "BackupDatabases.", this.BackupDatabases);
            this.SetParamArrayObj(map, prefix + "BackupTables.", this.BackupTables);
            this.SetParamSimple(map, prefix + "BackupName", this.BackupName);
        }
    }
}

