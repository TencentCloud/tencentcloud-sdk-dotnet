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

    public class ApplyWebVerificationTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// 核验结束后重定向的Web回跳地址。
        /// </summary>
        [JsonProperty("RedirectUrl")]
        public string RedirectUrl{ get; set; }

        /// <summary>
        /// 人脸比对照片的腾讯云对象存储地址，可以使用以下两种方式：
        /// 1. 调用CreateUploadUrl接口生成，确保成功上传照片后再调用此接口。
        /// 2. 使用已有的腾讯云对象存储地址，如果是私有读写桶，请使用预签名URL授予下载权限，对象存储地域需要和入参Region保持一致。
        /// </summary>
        [JsonProperty("CompareImageUrl")]
        public string CompareImageUrl{ get; set; }

        /// <summary>
        /// 人脸比对照片（CompareImageUrl）内容的MD5散列值。
        /// </summary>
        [JsonProperty("CompareImageMd5")]
        public string CompareImageMd5{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RedirectUrl", this.RedirectUrl);
            this.SetParamSimple(map, prefix + "CompareImageUrl", this.CompareImageUrl);
            this.SetParamSimple(map, prefix + "CompareImageMd5", this.CompareImageMd5);
        }
    }
}

