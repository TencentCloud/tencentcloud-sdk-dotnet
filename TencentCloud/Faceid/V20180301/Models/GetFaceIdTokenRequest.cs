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

    public class GetFaceIdTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>比对库。</p><ul><li>取值范围：<br>LOCAL：本地上传照片。<br>BUSINESS：商业库。</li></ul>
        /// </summary>
        [JsonProperty("CompareLib")]
        public string CompareLib{ get; set; }

        /// <summary>
        /// <p>身份证。</p><ul><li>CompareLib为商业库时必传。</li></ul>
        /// </summary>
        [JsonProperty("IdCard")]
        public string IdCard{ get; set; }

        /// <summary>
        /// <p>姓名。</p><ul><li>CompareLib为商业库时必传。</li></ul>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>图片的Base64。</p><ul><li>CompareLib为上传照片比对时必传。</li><li>Base64后图片最大8MB。</li><li>请使用标准的Base64编码方式(带=补位)，编码规范参考RFC4648。</li></ul>
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// <p>SDK中生成的Meta字符串。</p>
        /// </summary>
        [JsonProperty("Meta")]
        public string Meta{ get; set; }

        /// <summary>
        /// <p>透传参数。</p><ul><li>1000长度字符串</li></ul>
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }

        /// <summary>
        /// <p>是否使用cos桶。</p><ul><li>默认为false。</li><li>设置该参数为true后，核身过程中的视频图片将会存储在人脸核身控制台授权cos的bucket中，拉取结果时会返回对应资源完整cos地址。</li><li>开通地址见https://console.cloud.tencent.com/faceid/cos</li><li>【注意】选择该参数为true后将不返回base64数据，请根据接入情况谨慎修改。</li></ul>
        /// </summary>
        [JsonProperty("UseCos")]
        public bool? UseCos{ get; set; }

        /// <summary>
        /// <p>敏感数据加密信息。对传入信息（姓名、身份证号、自传照片）有加密需求的用户可使用此参数，详情请点击左侧链接。</p>
        /// </summary>
        [JsonProperty("Encryption")]
        public Encryption Encryption{ get; set; }

        /// <summary>
        /// <p>用于细分客户使用场景。</p><ul><li>申请开通服务后，可以在腾讯云慧眼人脸核身控制台（https://console.cloud.tencent.com/faceid） 自助接入里面创建，审核通过后即可调用。</li><li>如有疑问，请添加腾讯云人脸核身小助手进行咨询。</li></ul>
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// <p>SDK和用户设备的元信息。该字段的值由HuiYan SDK以JSON字符串格式返回。  说明：不要修改返回值，直接传递即可。</p>
        /// </summary>
        [JsonProperty("MetaData")]
        public string MetaData{ get; set; }


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
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "MetaData", this.MetaData);
        }
    }
}

