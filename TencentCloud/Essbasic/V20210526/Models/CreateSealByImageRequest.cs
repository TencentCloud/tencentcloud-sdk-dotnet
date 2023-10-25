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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSealByImageRequest : AbstractModel
    {
        
        /// <summary>
        /// 代理企业和员工的信息。
        /// 在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 印章名称，最大长度不超过50字符
        /// </summary>
        [JsonProperty("SealName")]
        public string SealName{ get; set; }

        /// <summary>
        /// 印章图片base64，大小不超过10M（原始图片不超过7.6M）
        /// </summary>
        [JsonProperty("SealImage")]
        public string SealImage{ get; set; }

        /// <summary>
        /// 操作者的信息
        /// </summary>
        [JsonProperty("Operator")]
        [System.Obsolete]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 本接口支持上传图片印章及系统直接生成印章； 如果要使用系统生成印章，此值传：SealGenerateSourceSystem； 如果要使用图片上传，此字段置空并且传字段 SealImage
        /// </summary>
        [JsonProperty("GenerateSource")]
        public string GenerateSource{ get; set; }

        /// <summary>
        /// 电子印章类型：
        /// <ul><li>OFFICIAL-公章</li>
        /// <li>CONTRACT-合同专用章;</li>
        /// <li>FINANCE-合财务专用章;</li>
        /// <li>PERSONNEL-人事专用章
        /// </li>
        /// <li>默认：OFFICIAL</li>
        /// </ul>
        /// </summary>
        [JsonProperty("SealType")]
        public string SealType{ get; set; }

        /// <summary>
        /// 企业印章横向文字，最多可填15个汉字（若超过印章最大宽度，优先压缩字间距，其次缩小字号
        /// </summary>
        [JsonProperty("SealHorizontalText")]
        public string SealHorizontalText{ get; set; }

        /// <summary>
        /// 印章样式:
        /// 
        /// <ul><li>cycle:圆形印章</li>
        /// <li>ellipse:椭圆印章</li>
        /// <li> 注：默认圆形印章</li></ul>
        /// </summary>
        [JsonProperty("SealStyle")]
        public string SealStyle{ get; set; }

        /// <summary>
        /// 印章尺寸取值描述：<ul><li> 42_42 圆形企业公章直径42mm</li>
        /// <li> 40_40 圆形企业印章直径40mm</li>
        /// <li> 45_30 椭圆形印章45mm x 30mm</li>
        /// </ul>
        /// </summary>
        [JsonProperty("SealSize")]
        public string SealSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "SealName", this.SealName);
            this.SetParamSimple(map, prefix + "SealImage", this.SealImage);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "GenerateSource", this.GenerateSource);
            this.SetParamSimple(map, prefix + "SealType", this.SealType);
            this.SetParamSimple(map, prefix + "SealHorizontalText", this.SealHorizontalText);
            this.SetParamSimple(map, prefix + "SealStyle", this.SealStyle);
            this.SetParamSimple(map, prefix + "SealSize", this.SealSize);
        }
    }
}

