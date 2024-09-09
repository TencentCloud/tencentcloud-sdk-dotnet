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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeOrganizationAuthStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// 企业是否已认证
        /// </summary>
        [JsonProperty("IsVerified")]
        public bool? IsVerified{ get; set; }

        /// <summary>
        /// 企业认证状态 0-未认证 1-认证中 2-已认证
        /// </summary>
        [JsonProperty("AuthStatus")]
        public long? AuthStatus{ get; set; }

        /// <summary>
        /// 企业认证信息
        /// </summary>
        [JsonProperty("AuthRecords")]
        public AuthRecord[] AuthRecords{ get; set; }

        /// <summary>
        /// 企业在腾讯电子签平台的唯一身份标识，为32位字符串。
        /// 可登录腾讯电子签控制台，在 "更多"->"企业设置"->"企业中心"- 中查看企业电子签账号。
        /// p.s. 只有当前企业认证成功的时候返回
        /// </summary>
        [JsonProperty("OrganizationId")]
        public string OrganizationId{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsVerified", this.IsVerified);
            this.SetParamSimple(map, prefix + "AuthStatus", this.AuthStatus);
            this.SetParamArrayObj(map, prefix + "AuthRecords.", this.AuthRecords);
            this.SetParamSimple(map, prefix + "OrganizationId", this.OrganizationId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

