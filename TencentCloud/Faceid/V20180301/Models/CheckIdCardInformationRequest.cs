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

    public class CheckIdCardInformationRequest : AbstractModel
    {
        
        /// <summary>
        /// 身份证人像面的 Base64 值
        /// 支持的图片格式：PNG、JPG、JPEG，暂不支持 GIF 格式。
        /// 支持的图片大小：所下载图片经Base64编码后不超过 7M。
        /// 请使用标准的Base64编码方式(带=补位)，编码规范参考RFC4648。
        /// ImageBase64、ImageUrl二者必须提供其中之一。若都提供了，则按照ImageUrl>ImageBase64的优先级使用参数。
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// 身份证人像面的 Url 地址
        /// 支持的图片格式：PNG、JPG、JPEG，暂不支持 GIF 格式。
        /// 支持的图片大小：所下载图片经 Base64 编码后不超过 3M。图片下载时间不超过 3 秒。
        /// 图片存储于腾讯云的 Url 可保障更高的下载速度和稳定性，建议图片存储于腾讯云。
        /// 非腾讯云存储的 Url 速度和稳定性可能受一定影响。
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 以下可选字段均为bool 类型，默认false：
        /// CopyWarn，复印件告警
        /// BorderCheckWarn，边框和框内遮挡告警
        /// ReshootWarn，翻拍告警
        /// DetectPsWarn，PS检测告警（疑似存在PS痕迹）
        /// TempIdWarn，临时身份证告警
        /// Quality，图片质量告警（评价图片模糊程度）
        /// 
        /// SDK 设置方式参考：
        /// Config = Json.stringify({"CopyWarn":true,"ReshootWarn":true})
        /// API 3.0 Explorer 设置方式参考：
        /// Config = {"CopyWarn":true,"ReshootWarn":true}
        /// </summary>
        [JsonProperty("Config")]
        public string Config{ get; set; }

        /// <summary>
        /// 是否需要对返回中的敏感信息进行加密。默认false。
        /// 其中敏感信息包括：Response.IdNum、Response.Name
        /// </summary>
        [JsonProperty("IsEncrypt")]
        public bool? IsEncrypt{ get; set; }

        /// <summary>
        /// 是否需要对响应体加密
        /// </summary>
        [JsonProperty("IsEncryptResponse")]
        public bool? IsEncryptResponse{ get; set; }

        /// <summary>
        /// 是否需要对返回中的敏感信息进行加密,需指定加密算法Algorithm、CBC加密的初始向量、加密后的对称密钥。
        /// </summary>
        [JsonProperty("Encryption")]
        public Encryption Encryption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "Config", this.Config);
            this.SetParamSimple(map, prefix + "IsEncrypt", this.IsEncrypt);
            this.SetParamSimple(map, prefix + "IsEncryptResponse", this.IsEncryptResponse);
            this.SetParamObj(map, prefix + "Encryption.", this.Encryption);
        }
    }
}

