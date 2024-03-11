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

namespace TencentCloud.Ses.V20201002.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetEmailIdentityResponse : AbstractModel
    {
        
        /// <summary>
        /// 验证类型。固定值：DOMAIN
        /// </summary>
        [JsonProperty("IdentityType")]
        public string IdentityType{ get; set; }

        /// <summary>
        /// 是否已通过验证
        /// </summary>
        [JsonProperty("VerifiedForSendingStatus")]
        public bool? VerifiedForSendingStatus{ get; set; }

        /// <summary>
        /// DNS配置详情
        /// </summary>
        [JsonProperty("Attributes")]
        public DNSAttributes[] Attributes{ get; set; }

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
            this.SetParamSimple(map, prefix + "IdentityType", this.IdentityType);
            this.SetParamSimple(map, prefix + "VerifiedForSendingStatus", this.VerifiedForSendingStatus);
            this.SetParamArrayObj(map, prefix + "Attributes.", this.Attributes);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

