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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSealByImageRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>关于渠道应用的相关信息，包括渠道应用标识、第三方平台子客企业标识及第三方平台子客企业中的员工标识等内容，您可以参阅开发者中心所提供的 Agent 结构体以获取详细定义。</p><p>此接口下面信息必填。</p><ul><li>渠道应用标识:  Agent.AppId</li><li>第三方平台子客企业标识: Agent.ProxyOrganizationOpenId</li><li>第三方平台子客企业中的员工标识: Agent.ProxyOperator.OpenId</li></ul>第三方平台子客企业和员工必须已经经过实名认证
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// <p>电子印章名字，1-50个中文字符<br>注:<code>同一企业下电子印章名字不能相同</code></p>
        /// </summary>
        [JsonProperty("SealName")]
        public string SealName{ get; set; }

        /// <summary>
        /// <p>电子印章图片base64编码，大小不超过10M（原始图片不超过5M），只支持PNG或JPG图片格式</p><p>注: <code>通过图片创建的电子印章，需电子签平台人工审核</code></p>
        /// </summary>
        [JsonProperty("SealImage")]
        public string SealImage{ get; set; }

        /// <summary>
        /// <p>操作者的信息</p>
        /// </summary>
        [JsonProperty("Operator")]
        [System.Obsolete]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// <p>电子印章生成方式</p><ul><li><strong>空值</strong>:(默认)使用上传的图片生成印章, 此时需要上传SealImage图片</li><li><strong>SealGenerateSourceSystem</strong>: 系统生成印章, 无需上传SealImage图片</li></ul>
        /// </summary>
        [JsonProperty("GenerateSource")]
        public string GenerateSource{ get; set; }

        /// <summary>
        /// <p>电子印章类型 , 可选类型如下: <ul><li><strong>OFFICIAL</strong>: (默认)公章</li><li><strong>CONTRACT</strong>: 合同专用章;</li><li><strong>FINANCE</strong>: 财务专用章;</li><li><strong>PERSONNEL</strong>: 人事专用章</li><li><strong>INVOICE</strong>: 发票专用章</li><li><strong>OTHER</strong>: 其他</li></ul>注: 同企业下只能有<font color="red">一个</font>公章, 重复创建会报错</p>
        /// </summary>
        [JsonProperty("SealType")]
        public string SealType{ get; set; }

        /// <summary>
        /// <p>企业印章横向文字，最多可填15个汉字  (若超过印章最大宽度，优先压缩字间距，其次缩小字号)<br>横向文字的位置如下图中的&quot;印章横向文字在这里&quot;</p><p><img src="https://dyn.ess.tencent.cn/guide/capi/CreateSealByImage2.png" alt="image"></p>
        /// </summary>
        [JsonProperty("SealHorizontalText")]
        public string SealHorizontalText{ get; set; }

        /// <summary>
        /// <p>印章样式, 可以选择的样式如下: </p><ul><li>**circle**:(默认)圆形印章</li><li>**ellipse**:椭圆印章</li></ul>
        /// </summary>
        [JsonProperty("SealStyle")]
        public string SealStyle{ get; set; }

        /// <summary>
        /// <p>  印章其他子类型。仅当 <code>SealType=OTHER</code> 且 <code>GenerateSource=SealGenerateSourceSystem</code> 时生效（ <font color="red">不支持图片上传方式创建子类型印章</font>）。<br> <b>注1：</b>调用时请勿传入 <code>SealHorizontalText</code> 字段，系统将自动使用子印章类型名称填充该字段。<br>  <b>注2：</b>本字段为白名单受控功能。如需使用，请联系客服开通并获取支持的子类型枚举值。</p>
        /// </summary>
        [JsonProperty("SubSealType")]
        public string SubSealType{ get; set; }

        /// <summary>
        /// <p>印章尺寸，格式为 宽_高（单位：mm，整数），用于签署时按物理尺寸将印章加盖到PDF。<br>取值范围：<br> • 图片上传印章（Image 或 FileToken 非空时生效）：支持自定义尺寸，宽、高均为 10-100 的整数（即 1cm-10cm），宽高比（宽/高）需在 0.1-10 之间。<br>• 系统生成印章（未传 Image 与 FileToken）：仅支持与SealStyle 匹配的固定枚举值：<br>  - 圆形印章（SealStyle=cycle）：38_38 / 40_40 / 42_42 / 45_45 / 50_50 / 58_58<br>  - 椭圆印章（SealStyle=ellipse）：40_30 / 45_30<br>字段依赖关系：<br> • 与 SealStyle关联：仅系统生成印章场景下 SealStyle 生效，此时 SealSize 需与 SealStyle对应的枚举匹配；图片上传印章场景 SealStyle 会被忽略，SealSize支持自定义。<br> • 与 SealType 关联：公章/合同章仅支持圆形枚举，财务/人事/其它章支持圆形或椭圆枚举。<br>• 与 Image / FileToken 关联：SealSize 是加盖到 PDF的物理尺寸，与上传图片的像素分辨率无绑定，图片会按 SealSize 缩放渲染；建议上传图片的宽高比与 SealSize 保持一致，避免拉伸形变。</p>
        /// </summary>
        [JsonProperty("SealSize")]
        public string SealSize{ get; set; }

        /// <summary>
        /// <p>企业税号</p><p>注:</p><ul><li>1.印章类型SealType是INVOICE类型时，此参数才会生效</li><li>2.印章类型SealType是INVOICE类型，且该字段没有传入值或传入空时，会取该企业对应的统一社会信用代码作为默认的企业税号（<font color="red">如果是通过授权书授权方式认证的企业，此参数必传不能为空</font>）</li></ul>
        /// </summary>
        [JsonProperty("TaxIdentifyCode")]
        public string TaxIdentifyCode{ get; set; }

        /// <summary>
        /// <p>印章描述内容</p>
        /// </summary>
        [JsonProperty("SealDescription")]
        public string SealDescription{ get; set; }

        /// <summary>
        /// <p>个性化配置字段，默认不传。</p>
        /// </summary>
        [JsonProperty("Options")]
        public Option[] Options{ get; set; }


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
            this.SetParamSimple(map, prefix + "SubSealType", this.SubSealType);
            this.SetParamSimple(map, prefix + "SealSize", this.SealSize);
            this.SetParamSimple(map, prefix + "TaxIdentifyCode", this.TaxIdentifyCode);
            this.SetParamSimple(map, prefix + "SealDescription", this.SealDescription);
            this.SetParamArrayObj(map, prefix + "Options.", this.Options);
        }
    }
}

