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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDiskBackupsAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// 云硬盘备份点ID，可通过 [DescribeDiskBackups](https://cloud.tencent.com/document/api/1207/84379) 接口返回值中的 DiskBackupId 获取。列表长度最大值为100。
        /// </summary>
        [JsonProperty("DiskBackupIds")]
        public string[] DiskBackupIds{ get; set; }

        /// <summary>
        /// 云硬盘备份点名称，最大长度 90 。
        /// </summary>
        [JsonProperty("DiskBackupName")]
        public string DiskBackupName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DiskBackupIds.", this.DiskBackupIds);
            this.SetParamSimple(map, prefix + "DiskBackupName", this.DiskBackupName);
        }
    }
}

