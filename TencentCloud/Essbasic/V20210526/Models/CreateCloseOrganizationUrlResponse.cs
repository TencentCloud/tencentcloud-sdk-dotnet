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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCloseOrganizationUrlResponse : AbstractModel
    {
        
        /// <summary>
        /// 链接有效期，unix时间戳，精确到秒
        /// </summary>
        [JsonProperty("ExpiredOn")]
        public long? ExpiredOn{ get; set; }

        /// <summary>
        /// H5跳转到电子签小程序链接, 一般用于发送短信中带的链接, 打开后进入腾讯电子签小程序
        /// </summary>
        [JsonProperty("LongUrl")]
        public string LongUrl{ get; set; }

        /// <summary>
        /// H5跳转到电子签小程序链接的短链形式, 一般用于发送短信中带的链接, 打开后进入腾讯电子签小程序
        /// </summary>
        [JsonProperty("ShortUrl")]
        public string ShortUrl{ get; set; }

        /// <summary>
        /// APP或小程序跳转电子签小程序链接, 一般用于客户小程序或者APP跳转过来, 打开后进入腾讯电子签小程序
        /// </summary>
        [JsonProperty("MiniAppPath")]
        public string MiniAppPath{ get; set; }

        /// <summary>
        /// 二维码链接
        /// </summary>
        [JsonProperty("QrcodeUrl")]
        public string QrcodeUrl{ get; set; }

        /// <summary>
        /// 直接跳转至电子签小程序的二维码链接，无需通过中转页。您需要自行将其转换为二维码，使用微信扫码后可直接进入。请注意，直接点击链接是无效的。
        /// </summary>
        [JsonProperty("WeixinQrcodeUrl")]
        public string WeixinQrcodeUrl{ get; set; }

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
            this.SetParamSimple(map, prefix + "ExpiredOn", this.ExpiredOn);
            this.SetParamSimple(map, prefix + "LongUrl", this.LongUrl);
            this.SetParamSimple(map, prefix + "ShortUrl", this.ShortUrl);
            this.SetParamSimple(map, prefix + "MiniAppPath", this.MiniAppPath);
            this.SetParamSimple(map, prefix + "QrcodeUrl", this.QrcodeUrl);
            this.SetParamSimple(map, prefix + "WeixinQrcodeUrl", this.WeixinQrcodeUrl);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

