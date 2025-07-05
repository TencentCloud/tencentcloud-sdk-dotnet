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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RansomDefenseRollbackRequest : AbstractModel
    {
        
        /// <summary>
        /// 快照时间
        /// </summary>
        [JsonProperty("BackupTime")]
        public string BackupTime{ get; set; }

        /// <summary>
        /// 主机Quuid
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// 需要回滚的硬盘信息，硬盘直接用;分隔，留空为全部已快照磁盘： disk-id1|disk-name1;disk-id2|disk-name2
        /// </summary>
        [JsonProperty("DiskInfo")]
        public string DiskInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BackupTime", this.BackupTime);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "DiskInfo", this.DiskInfo);
        }
    }
}

