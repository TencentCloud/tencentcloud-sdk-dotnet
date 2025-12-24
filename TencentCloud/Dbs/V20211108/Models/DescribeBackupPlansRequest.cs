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

    public class DescribeBackupPlansRequest : AbstractModel
    {
        
        /// <summary>
        /// 过滤条件，备份计划 ID。
        /// </summary>
        [JsonProperty("BackupPlanId")]
        public string BackupPlanId{ get; set; }

        /// <summary>
        /// 过滤条件，备份计划状态。
        /// </summary>
        [JsonProperty("Status")]
        public string[] Status{ get; set; }

        /// <summary>
        /// 过滤条件，数据库类型。
        /// </summary>
        [JsonProperty("DatabaseType")]
        public string[] DatabaseType{ get; set; }

        /// <summary>
        /// 过滤条件，接入访问类型。
        /// </summary>
        [JsonProperty("AccessType")]
        public string[] AccessType{ get; set; }

        /// <summary>
        /// 过滤条件，备份计划名称。
        /// </summary>
        [JsonProperty("BackupPlanName")]
        public string BackupPlanName{ get; set; }

        /// <summary>
        /// 过滤条件，标签键值。
        /// </summary>
        [JsonProperty("TagFilters")]
        public TagFilter[] TagFilters{ get; set; }

        /// <summary>
        /// 分页参数。取值范围为(0, 100]，默认值为20。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 分页参数。默认值为0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BackupPlanId", this.BackupPlanId);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
            this.SetParamArraySimple(map, prefix + "DatabaseType.", this.DatabaseType);
            this.SetParamArraySimple(map, prefix + "AccessType.", this.AccessType);
            this.SetParamSimple(map, prefix + "BackupPlanName", this.BackupPlanName);
            this.SetParamArrayObj(map, prefix + "TagFilters.", this.TagFilters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

