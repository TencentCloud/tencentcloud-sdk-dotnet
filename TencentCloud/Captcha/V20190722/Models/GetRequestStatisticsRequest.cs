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

namespace TencentCloud.Captcha.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetRequestStatisticsRequest : AbstractModel
    {
        
        /// <summary>
        /// 验证码AppId
        /// </summary>
        [JsonProperty("CaptchaAppId")]
        public string CaptchaAppId{ get; set; }

        /// <summary>
        /// 开始时间字符串
        /// </summary>
        [JsonProperty("StartTimeStr")]
        public string StartTimeStr{ get; set; }

        /// <summary>
        /// 结束时间字符串
        /// </summary>
        [JsonProperty("EndTimeStr")]
        public string EndTimeStr{ get; set; }

        /// <summary>
        /// 查询粒度
        /// </summary>
        [JsonProperty("Dimension")]
        public string Dimension{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CaptchaAppId", this.CaptchaAppId);
            this.SetParamSimple(map, prefix + "StartTimeStr", this.StartTimeStr);
            this.SetParamSimple(map, prefix + "EndTimeStr", this.EndTimeStr);
            this.SetParamSimple(map, prefix + "Dimension", this.Dimension);
        }
    }
}

