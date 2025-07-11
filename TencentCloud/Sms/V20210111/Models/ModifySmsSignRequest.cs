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

namespace TencentCloud.Sms.V20210111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifySmsSignRequest : AbstractModel
    {
        
        /// <summary>
        /// 待修改的签名 ID。
        /// </summary>
        [JsonProperty("SignId")]
        public ulong? SignId{ get; set; }

        /// <summary>
        /// 签名名称。
        /// </summary>
        [JsonProperty("SignName")]
        public string SignName{ get; set; }

        /// <summary>
        /// 签名类型。其中每种类型后面标注了其可选的 DocumentType（证明类型）：
        /// 0：公司，可选 DocumentType 有（0，1）。
        /// 1：APP，可选 DocumentType 有（0，1，2，3，4） 。
        /// 4：商标，可选 DocumentType 有（7）。
        /// 5：政府/机关事业单位/其他机构，可选 DocumentType 有（2，3）。
        /// 注1：必须按照对应关系选择证明类型，否则会审核失败。
        /// 注2：签名类型2（网站）、3（公众号）、6（小程序）已不再支持，具体可参考 [关于腾讯云短信签名申请规则更新的公告](https://cloud.tencent.com/document/product/382/116397)。
        /// </summary>
        [JsonProperty("SignType")]
        public ulong? SignType{ get; set; }

        /// <summary>
        /// 证明类型：
        /// 0：三证合一。
        /// 1：企业营业执照。
        /// 2：组织机构代码证书。
        /// 3：社会信用代码证书。
        /// 4：应用后台管理截图（个人开发APP）。
        /// 7：商标注册书。
        /// 注：证明类型5（网站备案后台截图）、6（小程序设置页面截图）、8（公众号设置页面截图）已不再支持，具体可参考 [关于腾讯云短信签名申请规则更新的公告](https://cloud.tencent.com/document/product/382/116397)。
        /// </summary>
        [JsonProperty("DocumentType")]
        public ulong? DocumentType{ get; set; }

        /// <summary>
        /// 是否国际/港澳台短信：
        /// 0：表示国内短信。
        /// 1：表示国际/港澳台短信。
        /// 注：需要和待修改签名International值保持一致，该参数不能直接修改国内签名到国际签名。
        /// </summary>
        [JsonProperty("International")]
        public ulong? International{ get; set; }

        /// <summary>
        /// 签名用途：
        /// 0：自用。
        /// 1：他用。
        /// </summary>
        [JsonProperty("SignPurpose")]
        public ulong? SignPurpose{ get; set; }

        /// <summary>
        /// 签名对应的资质证明图片需先进行 base64 编码格式转换，将转换后的字符串去掉前缀`data:image/jpeg;base64,`再赋值给该参数。
        /// </summary>
        [JsonProperty("ProofImage")]
        public string ProofImage{ get; set; }

        /// <summary>
        /// 委托授权证明。选择 SignPurpose 为他用之后需要提交委托的授权证明。
        /// 图片需先进行 base64 编码格式转换，将转换后的字符串去掉前缀`data:image/jpeg;base64,`再赋值给该参数。
        /// 注：只有 SignPurpose 在选择为 1（他用）时，这个字段才会生效。
        /// </summary>
        [JsonProperty("CommissionImage")]
        public string CommissionImage{ get; set; }

        /// <summary>
        /// 签名的申请备注。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 已审核通过的国内短信的资质 ID。资质 ID 信息可前往国内短信的 [实名资质管理](https://console.cloud.tencent.com/smsv2/enterprise) 页查看。<dx-alert infotype="notice" title="说明"><ul><li>国内短信需填写资质ID，国际短信无需填写。</li></ul></dx-alert>
        /// </summary>
        [JsonProperty("QualificationId")]
        public ulong? QualificationId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SignId", this.SignId);
            this.SetParamSimple(map, prefix + "SignName", this.SignName);
            this.SetParamSimple(map, prefix + "SignType", this.SignType);
            this.SetParamSimple(map, prefix + "DocumentType", this.DocumentType);
            this.SetParamSimple(map, prefix + "International", this.International);
            this.SetParamSimple(map, prefix + "SignPurpose", this.SignPurpose);
            this.SetParamSimple(map, prefix + "ProofImage", this.ProofImage);
            this.SetParamSimple(map, prefix + "CommissionImage", this.CommissionImage);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "QualificationId", this.QualificationId);
        }
    }
}

