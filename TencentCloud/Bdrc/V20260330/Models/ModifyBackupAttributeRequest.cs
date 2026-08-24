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

namespace TencentCloud.Bdrc.V20260330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyBackupAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// 备份ID。该字段的取值取决于ResourceType：当ResourceType=CVM（默认）时，需传入备份组ID（BackupGroupId），可通过DescribeBackupGroups（查询备份组列表）查询
        /// </summary>
        [JsonProperty("BackupId")]
        public string BackupId{ get; set; }

        /// <summary>
        /// 备份的名称。
        /// </summary>
        [JsonProperty("BackupName")]
        public string BackupName{ get; set; }

        /// <summary>
        /// 是否为永久保留的备份。
        /// </summary>
        [JsonProperty("IsPermanent")]
        public bool? IsPermanent{ get; set; }

        /// <summary>
        /// 备份到期时间。
        /// </summary>
        [JsonProperty("Deadline")]
        public string Deadline{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BackupId", this.BackupId);
            this.SetParamSimple(map, prefix + "BackupName", this.BackupName);
            this.SetParamSimple(map, prefix + "IsPermanent", this.IsPermanent);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
        }
    }
}

