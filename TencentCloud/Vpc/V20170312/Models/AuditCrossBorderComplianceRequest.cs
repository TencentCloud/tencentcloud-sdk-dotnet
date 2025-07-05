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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuditCrossBorderComplianceRequest : AbstractModel
    {
        
        /// <summary>
        /// 服务商, 可选值：`UNICOM`。
        /// </summary>
        [JsonProperty("ServiceProvider")]
        public string ServiceProvider{ get; set; }

        /// <summary>
        /// 表单唯一`ID`。可通过[DescribeCrossBorderCompliance](https://cloud.tencent.com/document/product/215/47838)接口查询ComplianceId信息
        /// </summary>
        [JsonProperty("ComplianceId")]
        public ulong? ComplianceId{ get; set; }

        /// <summary>
        /// 通过：`APPROVED `，拒绝：`DENY`。
        /// </summary>
        [JsonProperty("AuditBehavior")]
        public string AuditBehavior{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceProvider", this.ServiceProvider);
            this.SetParamSimple(map, prefix + "ComplianceId", this.ComplianceId);
            this.SetParamSimple(map, prefix + "AuditBehavior", this.AuditBehavior);
        }
    }
}

