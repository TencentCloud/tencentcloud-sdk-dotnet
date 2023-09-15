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

    public class CreateUserAutoSignEnableUrlResponse : AbstractModel
    {
        
        /// <summary>
        /// 个人用户自动签的开通链接, 短链形式。过期时间受 `ExpiredTime` 参数控制。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 腾讯电子签小程序的 AppID，用于其他小程序/APP等应用跳转至腾讯电子签小程序使用
        /// 
        /// 注: `如果获取的是H5链接, 则不会返回此值`
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 腾讯电子签小程序的原始 Id,  ，用于其他小程序/APP等应用跳转至腾讯电子签小程序使用
        /// 
        /// 注: `如果获取的是H5链接, 则不会返回此值`
        /// </summary>
        [JsonProperty("AppOriginalId")]
        public string AppOriginalId{ get; set; }

        /// <summary>
        /// 腾讯电子签小程序的跳转路径，用于其他小程序/APP等应用跳转至腾讯电子签小程序使用
        /// 
        /// 注: `如果获取的是H5链接, 则不会返回此值`
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// base64 格式的跳转二维码图片，可通过微信扫描后跳转到腾讯电子签小程序的开通界面。
        /// 
        /// 注: `如果获取的是H5链接, 则不会返回此二维码图片`
        /// </summary>
        [JsonProperty("QrCode")]
        public string QrCode{ get; set; }

        /// <summary>
        /// 返回的链接类型
        /// <ul><li> 空: 默认小程序端链接</li>
        /// <li> **H5SIGN** : h5端链接</li></ul>
        /// </summary>
        [JsonProperty("UrlType")]
        public string UrlType{ get; set; }

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
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "AppOriginalId", this.AppOriginalId);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "QrCode", this.QrCode);
            this.SetParamSimple(map, prefix + "UrlType", this.UrlType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

