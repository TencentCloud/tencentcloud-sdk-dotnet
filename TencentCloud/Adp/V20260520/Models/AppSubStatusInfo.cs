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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AppSubStatusInfo : AbstractModel
    {
        
        /// <summary>
        /// 审批记录ID (当sub_status_list包含PUBLISH_APPROVING时有效)
        /// </summary>
        [JsonProperty("ApprovalId")]
        public string ApprovalId{ get; set; }

        /// <summary>
        /// 应用子状态列表 (可能同时处于多个子状态)
        /// </summary>
        [JsonProperty("SubStatusList")]
        public long?[] SubStatusList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApprovalId", this.ApprovalId);
            this.SetParamArraySimple(map, prefix + "SubStatusList.", this.SubStatusList);
        }
    }
}

