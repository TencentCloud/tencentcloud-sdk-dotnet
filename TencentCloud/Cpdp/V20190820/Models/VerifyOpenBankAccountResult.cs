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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VerifyOpenBankAccountResult : AbstractModel
    {
        
        /// <summary>
        /// 打款验证状态。
        ///  INIT("打款中"),
        /// PENDING("打款成功待验证"),
        /// VERIFIED("验证成功"),
        /// FAILED("打款失败"),
        /// VERIFY_FAILED("验证失败")
        /// </summary>
        [JsonProperty("VerifyState")]
        public string VerifyState{ get; set; }

        /// <summary>
        /// 重定向参数，用于客户端跳转，收款商户未完成打款验证时返回该参数
        /// </summary>
        [JsonProperty("RedirectInfo")]
        public OpenBankRedirectInfo RedirectInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VerifyState", this.VerifyState);
            this.SetParamObj(map, prefix + "RedirectInfo.", this.RedirectInfo);
        }
    }
}

