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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuditPermissionApplyOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>空间 ID</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>申请单 ID</p>
        /// </summary>
        [JsonProperty("ApplyId")]
        public string ApplyId{ get; set; }

        /// <summary>
        /// <p>审批结果</p><p>枚举值：</p><ul><li>Approve： 通过</li><li>Reject： 拒绝</li></ul>
        /// </summary>
        [JsonProperty("AuditResult")]
        public string AuditResult{ get; set; }

        /// <summary>
        /// <p>审批意见</p>
        /// </summary>
        [JsonProperty("AuditOpinion")]
        public string AuditOpinion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ApplyId", this.ApplyId);
            this.SetParamSimple(map, prefix + "AuditResult", this.AuditResult);
            this.SetParamSimple(map, prefix + "AuditOpinion", this.AuditOpinion);
        }
    }
}

