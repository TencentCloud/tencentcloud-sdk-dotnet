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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageRecognitionV2Request : AbstractModel
    {
        
        /// <summary>
        /// 身份证号。
        /// </summary>
        [JsonProperty("IdCard")]
        public string IdCard{ get; set; }

        /// <summary>
        /// 姓名。
        /// - 中文请使用UTF-8编码。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 用于人脸比对的照片，图片的Base64值；
        /// Base64编码后的图片数据大小不超过3M，仅支持jpg、png格式。
        /// 请使用标准的Base64编码方式(带=补位)，编码规范参考RFC4648。
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// 本接口不需要传递此参数。
        /// </summary>
        [JsonProperty("Optional")]
        public string Optional{ get; set; }

        /// <summary>
        /// 敏感数据加密信息。
        /// - 对传入信息（姓名、身份证号）有加密需求的用户可使用此参数，详情请点击左侧链接。
        /// </summary>
        [JsonProperty("Encryption")]
        public Encryption Encryption{ get; set; }

        /// <summary>
        /// 自定义描述字段。
        /// - 用于描述调用业务信息，出参中将返回此描述字段。 
        /// - 每个自定义描述字段支持[1,10]个字符。
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IdCard", this.IdCard);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "Optional", this.Optional);
            this.SetParamObj(map, prefix + "Encryption.", this.Encryption);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
        }
    }
}

