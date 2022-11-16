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

    public class GetFaceIdTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// 本地上传照片(LOCAL)、商业库(BUSINESS)
        /// </summary>
        [JsonProperty("CompareLib")]
        public string CompareLib{ get; set; }

        /// <summary>
        /// CompareLib为商业库时必传。
        /// </summary>
        [JsonProperty("IdCard")]
        public string IdCard{ get; set; }

        /// <summary>
        /// CompareLib为商业库时必传。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// CompareLib为上传照片比对时必传，Base64后图片最大8MB。
        /// 请使用标准的Base64编码方式(带=补位)，编码规范参考RFC4648。
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// SDK中生成的Meta字符串
        /// </summary>
        [JsonProperty("Meta")]
        public string Meta{ get; set; }

        /// <summary>
        /// 透传参数 1000长度字符串
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }

        /// <summary>
        /// 默认为false，设置该参数为true后，核身过程中的视频图片将会存储在人脸核身控制台授权cos的bucket中，拉取结果时会返回对应资源完整cos地址。开通地址见https://console.cloud.tencent.com/faceid/cos
        /// 【注意】选择该参数为true后将不返回base64数据，请根据接入情况谨慎修改。
        /// </summary>
        [JsonProperty("UseCos")]
        public bool? UseCos{ get; set; }

        /// <summary>
        /// 敏感数据加密信息。对传入信息（姓名、身份证号）有加密需求的用户可使用此参数，详情请点击左侧链接。
        /// </summary>
        [JsonProperty("Encryption")]
        public Encryption Encryption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompareLib", this.CompareLib);
            this.SetParamSimple(map, prefix + "IdCard", this.IdCard);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "Meta", this.Meta);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
            this.SetParamSimple(map, prefix + "UseCos", this.UseCos);
            this.SetParamObj(map, prefix + "Encryption.", this.Encryption);
        }
    }
}

