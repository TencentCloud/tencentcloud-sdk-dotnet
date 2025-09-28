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

    public class CreateSealByImageResponse : AbstractModel
    {
        
        /// <summary>
        /// 电子印章ID，为32位字符串。
        /// 建议开发者保留此印章ID，后续指定签署区印章或者操作印章需此印章ID。
        /// </summary>
        [JsonProperty("SealId")]
        public string SealId{ get; set; }

        /// <summary>
        /// 电子印章预览链接地址，地址默认失效时间为24小时。
        /// 
        /// 注:`图片上传生成的电子印章无预览链接地址`
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 人脸验证操作人链接，用法可以参考"[跳转电子签小程序配置](https://qian.tencent.com/developers/company/openwxminiprogram/)"，默认为空。
        /// </summary>
        [JsonProperty("SealOperatorVerifyPath")]
        public string SealOperatorVerifyPath{ get; set; }

        /// <summary>
        /// 人脸验证操作人二维码链接，扫码后会跳转到腾讯电子签小程序进行人脸验证，默认为空。
        /// </summary>
        [JsonProperty("SealOperatorVerifyQrcodeUrl")]
        public string SealOperatorVerifyQrcodeUrl{ get; set; }

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
            this.SetParamSimple(map, prefix + "SealId", this.SealId);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "SealOperatorVerifyPath", this.SealOperatorVerifyPath);
            this.SetParamSimple(map, prefix + "SealOperatorVerifyQrcodeUrl", this.SealOperatorVerifyQrcodeUrl);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

