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

namespace TencentCloud.Captcha.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCaptchaTicketDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 验证码应用ID
        /// </summary>
        [JsonProperty("CaptchaAppId")]
        public long? CaptchaAppId{ get; set; }

        /// <summary>
        /// 查询开始时间 例如：20200909
        /// </summary>
        [JsonProperty("Start")]
        public long? Start{ get; set; }

        /// <summary>
        /// 查询结束时间 例如：20220314
        /// </summary>
        [JsonProperty("End")]
        public long? End{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CaptchaAppId", this.CaptchaAppId);
            this.SetParamSimple(map, prefix + "Start", this.Start);
            this.SetParamSimple(map, prefix + "End", this.End);
        }
    }
}

