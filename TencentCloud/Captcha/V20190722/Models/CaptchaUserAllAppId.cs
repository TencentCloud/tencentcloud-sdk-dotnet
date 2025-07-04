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

    public class CaptchaUserAllAppId : AbstractModel
    {
        
        /// <summary>
        /// 验证码应用ID
        /// </summary>
        [JsonProperty("CaptchaAppId")]
        public long? CaptchaAppId{ get; set; }

        /// <summary>
        /// 注册应用名称
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// 腾讯云APPID
        /// </summary>
        [JsonProperty("TcAppId")]
        public long? TcAppId{ get; set; }

        /// <summary>
        /// 渠道信息
        /// </summary>
        [JsonProperty("ChannelInfo")]
        public string ChannelInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CaptchaAppId", this.CaptchaAppId);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "TcAppId", this.TcAppId);
            this.SetParamSimple(map, prefix + "ChannelInfo", this.ChannelInfo);
        }
    }
}

