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

    public class IdCardOCRVerificationResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>认证结果码，收费情况如下。</p><ul><li>收费结果码：<br>0: 姓名和身份证号一致。<br>-1: 姓名和身份证号不一致。</li><li>不收费结果码：<br>-2: 非法身份证号（长度、校验位等不正确）。<br>-3: 非法姓名（长度、格式等不正确）。<br>-4: 证件库服务异常。<br>-5: 证件库中无此身份证记录。<br>-6: 权威比对系统升级中，请稍后再试。<br>-7: 认证次数超过当日限制。</li></ul>
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// <p>业务结果描述。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>用于验证的姓名。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>用于验证的身份证号。</p>
        /// </summary>
        [JsonProperty("IdCard")]
        public string IdCard{ get; set; }

        /// <summary>
        /// <p>OCR得到的性别。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Sex")]
        public string Sex{ get; set; }

        /// <summary>
        /// <p>OCR得到的民族。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Nation")]
        public string Nation{ get; set; }

        /// <summary>
        /// <p>OCR得到的生日。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Birth")]
        public string Birth{ get; set; }

        /// <summary>
        /// <p>OCR得到的地址。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// <p>身份证头像照片的base64编码</p>
        /// </summary>
        [JsonProperty("Portrait")]
        public string Portrait{ get; set; }

        /// <summary>
        /// <p>告警信息。</p><ul><li>Code 告警码列表和释义：<br>  &#39;-9101&#39;：身份证边框不完整告警。<br>  &#39;-9102&#39;：身份证复印件告警。<br>  &#39;-9103&#39;：身份证翻拍告警。<br>  &#39;-9105&#39;：身份证框内遮挡告警。&#39;<br>  &#39;-9104&#39;：临时身份证告警。<br>  &#39;-9106&#39;：身份证 PS 告警（疑似存在PS痕迹）。<br>  &#39;-9107&#39;：身份证反光告警。<br>  &#39;-9108&#39;：身份证复印件告警（仅黑白复印件）。<br>  &#39;-9109&#39;：身份证有效日期不合法告警。<br>  &#39;-8001&#39;：图片模糊告警。</li><li>多个会用“|” 隔开，如 &quot;-9101|-9106|-9104&quot;。</li></ul>
        /// </summary>
        [JsonProperty("Warnings")]
        public string Warnings{ get; set; }

        /// <summary>
        /// <p>图片质量分数。</p><ul><li>当请求Config中配置图片模糊告警该参数才有意义。</li><li><ul><li>取值范围（0～100），目前默认阈值是50分，低于50分会触发模糊告警。</li></ul></li></ul>
        /// </summary>
        [JsonProperty("Quality")]
        public float? Quality{ get; set; }

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
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IdCard", this.IdCard);
            this.SetParamSimple(map, prefix + "Sex", this.Sex);
            this.SetParamSimple(map, prefix + "Nation", this.Nation);
            this.SetParamSimple(map, prefix + "Birth", this.Birth);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "Portrait", this.Portrait);
            this.SetParamSimple(map, prefix + "Warnings", this.Warnings);
            this.SetParamSimple(map, prefix + "Quality", this.Quality);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

