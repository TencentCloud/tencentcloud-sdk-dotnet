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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplyWebVerificationTokenResponse : AbstractModel
    {
        
        /// <summary>
        /// 用户浏览器需要打开此地址开始核验流程。
        /// </summary>
        [JsonProperty("VerificationUrl")]
        public string VerificationUrl{ get; set; }

        /// <summary>
        /// 标识一次Web核验流程的令牌，有效时间为7,200秒。流程结束后可用该令牌获取核验结果信息。
        /// </summary>
        [JsonProperty("BizToken")]
        public string BizToken{ get; set; }

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
            this.SetParamSimple(map, prefix + "VerificationUrl", this.VerificationUrl);
            this.SetParamSimple(map, prefix + "BizToken", this.BizToken);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

