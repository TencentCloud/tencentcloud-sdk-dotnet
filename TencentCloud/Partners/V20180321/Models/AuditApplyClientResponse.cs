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

namespace TencentCloud.Partners.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuditApplyClientResponse : AbstractModel
    {
        
        /// <summary>
        /// 代理商账号ID
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 客户账号ID
        /// </summary>
        [JsonProperty("ClientUin")]
        public string ClientUin{ get; set; }

        /// <summary>
        /// 审核结果，包括accept/reject/qcloudaudit（腾讯云审核）
        /// </summary>
        [JsonProperty("AuditResult")]
        public string AuditResult{ get; set; }

        /// <summary>
        /// 关联时间对应的时间戳
        /// </summary>
        [JsonProperty("AgentTime")]
        public ulong? AgentTime{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "ClientUin", this.ClientUin);
            this.SetParamSimple(map, prefix + "AuditResult", this.AuditResult);
            this.SetParamSimple(map, prefix + "AgentTime", this.AgentTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

