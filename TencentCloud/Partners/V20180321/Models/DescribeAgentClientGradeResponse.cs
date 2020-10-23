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

    public class DescribeAgentClientGradeResponse : AbstractModel
    {
        
        /// <summary>
        /// 审核状态：0待审核，1，已审核
        /// </summary>
        [JsonProperty("AuditStatus")]
        public ulong? AuditStatus{ get; set; }

        /// <summary>
        /// 实名认证状态：0，未实名认证，1实名认证
        /// </summary>
        [JsonProperty("AuthState")]
        public ulong? AuthState{ get; set; }

        /// <summary>
        /// 客户级别
        /// </summary>
        [JsonProperty("ClientGrade")]
        public string ClientGrade{ get; set; }

        /// <summary>
        /// 客户类型：1，个人；2，企业；3，其他
        /// </summary>
        [JsonProperty("ClientType")]
        public ulong? ClientType{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AuditStatus", this.AuditStatus);
            this.SetParamSimple(map, prefix + "AuthState", this.AuthState);
            this.SetParamSimple(map, prefix + "ClientGrade", this.ClientGrade);
            this.SetParamSimple(map, prefix + "ClientType", this.ClientType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

