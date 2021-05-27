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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VerifyBasicBizLicenseRequest : AbstractModel
    {
        
        /// <summary>
        /// 用于入参是营业执照图片的场景，ImageBase64和ImageUrl必须提供一个，如果都提供，只使用 ImageUrl。
        /// 支持的图片格式：PNG、JPG、JPEG，暂不支持 GIF 格式。
        /// 支持的图片大小：所下载图片经Base64编码后不超过 7M。图片下载时间不超过 3 秒。
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// 用于入参是营业执照图片的场景，ImageBase64和ImageUrl必须提供一个，如果都提供，只使用 ImageUrl。
        /// 支持的图片格式：PNG、JPG、JPEG，暂不支持 GIF 格式。
        /// 支持的图片大小：所下载图片经Base64编码后不超过 7M。图片下载时间不超过 3 秒。
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 用于入参是营业执照图片的场景，表示需要校验的参数：RegNum（注册号或者统一社会信用代码），Name（企业名称），Address（经营地址）。选择后会返回相关参数校验结果。RegNum为必选，Name和Address可选。
        /// 格式为{RegNum: true, Name:true/false, Address:true/false}
        /// 
        /// 设置方式参考：
        /// Config = Json.stringify({"Name":true,"Address":true})
        /// API 3.0 Explorer 设置方式参考：
        /// Config = {"Name":true,"Address":true}
        /// </summary>
        [JsonProperty("ImageConfig")]
        public string ImageConfig{ get; set; }

        /// <summary>
        /// 用于入参是文本的场景，RegNum表示注册号或者统一社会信用代码。若没有传入营业执照图片，则RegNum为必选项，若图片和RegNum都传入，则只使用RegNum。
        /// </summary>
        [JsonProperty("RegNum")]
        public string RegNum{ get; set; }

        /// <summary>
        /// 用于入参是文本的场景，Name表示企业名称。Name为可选项，填写后会返回Name的校验结果。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 用于入参是文本的场景，Address表示经营地址。Address为可选项，填写后会返回Address的校验结果。
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 1表示输出注册资本字段（单位：万元），其他值表示不输出。默认不输出。
        /// </summary>
        [JsonProperty("RegCapital")]
        public long? RegCapital{ get; set; }

        /// <summary>
        /// true表示展示成立/注册日期
        /// </summary>
        [JsonProperty("EstablishTime")]
        public bool? EstablishTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "ImageConfig", this.ImageConfig);
            this.SetParamSimple(map, prefix + "RegNum", this.RegNum);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "RegCapital", this.RegCapital);
            this.SetParamSimple(map, prefix + "EstablishTime", this.EstablishTime);
        }
    }
}

