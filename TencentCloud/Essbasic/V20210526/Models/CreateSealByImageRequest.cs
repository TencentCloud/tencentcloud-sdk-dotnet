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
        /// 关于渠道应用的相关信息，包括渠道应用标识、第三方平台子客企业标识及第三方平台子客企业中的员工标识等内容，您可以参阅开发者中心所提供的 Agent 结构体以获取详细定义。
        /// 
        /// 此接口下面信息必填。
        /// <ul>
        /// <li>渠道应用标识:  Agent.AppId</li>
        /// <li>第三方平台子客企业标识: Agent.ProxyOrganizationOpenId</li>
        /// <li>第三方平台子客企业中的员工标识: Agent.ProxyOperator.OpenId</li>
        /// </ul>
        /// 第三方平台子客企业和员工必须已经经过实名认证
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 电子印章名字，1-50个中文字符
        /// 注:`同一企业下电子印章名字不能相同`
        /// </summary>
        [JsonProperty("SealName")]
        public string SealName{ get; set; }

        /// <summary>
        /// 电子印章图片base64编码，大小不超过10M（原始图片不超过5M），只支持PNG或JPG图片格式
        /// 
        /// 注: `通过图片创建的电子印章，需电子签平台人工审核`
        /// 
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
        /// 电子印章生成方式
        /// <ul>
        /// <li><strong>空值</strong>:(默认)使用上传的图片生成印章, 此时需要上传SealImage图片</li>
        /// <li><strong>SealGenerateSourceSystem</strong>: 系统生成印章, 无需上传SealImage图片</li>
        /// </ul>
        /// </summary>
        [JsonProperty("GenerateSource")]
        public string GenerateSource{ get; set; }

        /// <summary>
        /// 电子印章类型 , 可选类型如下: 
        /// <ul><li>**OFFICIAL**: (默认)公章</li>
        /// <li>**CONTRACT**: 合同专用章;</li>
        /// <li>**FINANCE**: 财务专用章;</li>
        /// <li>**PERSONNEL**: 人事专用章</li>
        /// <li>**INVOICE**: 发票专用章</li>
        /// </ul>
        /// 注: `同企业下只能有一个公章, 重复创建会报错`
        /// </summary>
        [JsonProperty("SealType")]
        public string SealType{ get; set; }

        /// <summary>
        /// 企业印章横向文字，最多可填15个汉字  (若超过印章最大宽度，优先压缩字间距，其次缩小字号)
        /// 横向文字的位置如下图中的"印章横向文字在这里"
        /// 
        /// ![image](https://dyn.ess.tencent.cn/guide/capi/CreateSealByImage2.png)
        /// </summary>
        [JsonProperty("SealHorizontalText")]
        public string SealHorizontalText{ get; set; }

        /// <summary>
        /// 印章样式, 可以选择的样式如下: 
        /// <ul><li>**circle**:(默认)圆形印章</li>
        /// <li>**ellipse**:椭圆印章</li></ul>
        /// </summary>
        [JsonProperty("SealStyle")]
        public string SealStyle{ get; set; }

        /// <summary>
        /// 印章尺寸取值描述, 可以选择的尺寸如下: 
        /// <ul><li> **42_42**: 圆形企业公章直径42mm, 当SealStyle是圆形的时候才有效</li>
        /// <li> **40_40**: 圆形企业印章直径40mm, 当SealStyle是圆形的时候才有效</li>
        /// <li> **45_30**: 椭圆形印章45mm x 30mm, 当SealStyle是椭圆的时候才有效</li>
        /// <li> **40_30**: 椭圆形印章40mm x 30mm, 当SealStyle是椭圆的时候才有效</li></ul>
        /// </summary>
        [JsonProperty("SealSize")]
        public string SealSize{ get; set; }

        /// <summary>
        /// 企业税号
        /// 
        /// 注:
        /// <ul>
        /// <li>1.印章类型SealType是INVOICE类型时，此参数才会生效</li>
        /// <li>2.印章类型SealType是INVOICE类型，且该字段没有传入值或传入空时，会取该企业对应的统一社会信用代码作为默认的企业税号（<font color="red">如果是通过授权书授权方式认证的企业，此参数必传不能为空</font>）</li>
        /// </ul>
        /// </summary>
        [JsonProperty("TaxIdentifyCode")]
        public string TaxIdentifyCode{ get; set; }


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
            this.SetParamSimple(map, prefix + "TaxIdentifyCode", this.TaxIdentifyCode);
        }
    }
}

