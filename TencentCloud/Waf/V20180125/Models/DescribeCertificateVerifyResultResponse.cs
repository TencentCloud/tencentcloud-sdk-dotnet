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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCertificateVerifyResultResponse : AbstractModel
    {
        
        /// <summary>
        /// 状态码。
        /// 0：证书正常
        /// 310：证书异常
        /// 311：证书过期
        /// 312：证书即将过期
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 错误详情
        /// </summary>
        [JsonProperty("Detail")]
        public string[] Detail{ get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("NotAfter")]
        public string NotAfter{ get; set; }

        /// <summary>
        /// 证书是否改变。
        /// 0：未变化
        /// 1：有变化
        /// </summary>
        [JsonProperty("Changed")]
        public long? Changed{ get; set; }

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
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "Detail.", this.Detail);
            this.SetParamSimple(map, prefix + "NotAfter", this.NotAfter);
            this.SetParamSimple(map, prefix + "Changed", this.Changed);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

