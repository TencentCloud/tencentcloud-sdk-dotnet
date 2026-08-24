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

    public class CreateFileBackupPlanRequest : AbstractModel
    {
        
        /// <summary>
        /// 备份策略ID
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }

        /// <summary>
        /// 备份库ID
        /// </summary>
        [JsonProperty("BackupStorageId")]
        public string BackupStorageId{ get; set; }

        /// <summary>
        /// 计划名称
        /// </summary>
        [JsonProperty("PlanName")]
        public string PlanName{ get; set; }

        /// <summary>
        /// 实例配置列表，[1,20]
        /// </summary>
        [JsonProperty("Resources")]
        public ResourcePlan[] Resources{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "BackupStorageId", this.BackupStorageId);
            this.SetParamSimple(map, prefix + "PlanName", this.PlanName);
            this.SetParamArrayObj(map, prefix + "Resources.", this.Resources);
        }
    }
}

