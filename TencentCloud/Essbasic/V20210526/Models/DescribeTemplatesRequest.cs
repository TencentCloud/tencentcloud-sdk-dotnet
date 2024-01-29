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

    public class DescribeTemplatesRequest : AbstractModel
    {
        
        /// <summary>
        /// 关于渠道应用的相关信息，包括渠道应用标识、第三方平台子客企业标识及第三方平台子客企业中的员工标识等内容，您可以参阅开发者中心所提供的 Agent 结构体以获取详细定义。
        /// 
        /// 此接口下面信息必填。
        /// <ul>
        /// <li>渠道应用标识:  Agent.AppId</li>
        /// <li>第三方平台子客企业标识: Agent.ProxyOrganizationOpenId</li>
        /// <li>第三方平台子客企业中的员工标识: Agent. ProxyOperator.OpenId</li>
        /// </ul>
        /// 第三方平台子客企业和员工必须已经经过实名认证
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 合同模板ID，为32位字符串。
        /// 
        /// 可以通过<a href="https://qian.tencent.com/developers/partnerApis/accounts/CreateConsoleLoginUrl" target="_blank">生成子客登录链接</a>登录企业控制台, 在企业模板中得到合同模板ID。
        /// 
        /// [点击产看模板Id在控制台上的位置](https://qcloudimg.tencent-cloud.cn/raw/e988be12bf28a89b4716aed4502c2e02.png)
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 查询模板的内容
        /// 
        /// <ul><li>**0**：（默认）模板列表及详情</li>
        /// <li>**1**：仅模板列表, 不会返回模板中的签署控件, 填写控件, 参与方角色列表等信息</li></ul>
        /// </summary>
        [JsonProperty("ContentType")]
        public long? ContentType{ get; set; }

        /// <summary>
        /// 合同模板ID数组，每一个合同模板ID为32位字符串,  最多支持200个模板的批量查询。
        /// 
        /// 注意: 
        /// 1.` 此参数TemplateIds与TemplateId互为独立，若两者均传入，以TemplateId为准。`
        /// 2. `请确保每个模板均正确且属于当前企业，若有任一模板不存在，则返回错误。`
        /// 4. `若传递此参数，分页参数(Limit,Offset)无效`
        /// 
        /// 
        /// [点击产看模板Id在控制台上的位置](https://qcloudimg.tencent-cloud.cn/raw/e988be12bf28a89b4716aed4502c2e02.png)
        /// </summary>
        [JsonProperty("TemplateIds")]
        public string[] TemplateIds{ get; set; }

        /// <summary>
        /// 指定每页返回的数据条数，和Offset参数配合使用。
        /// 
        /// 注：`1.默认值为20，单页做大值为200。`
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 查询结果分页返回，指定从第几页返回数据，和Limit参数配合使用。
        /// 
        /// 注：`1.offset从0开始，即第一页为0。`
        /// `2.默认从第一页返回。`
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 模糊搜索的模板名称，注意是模板名的连续部分，长度不能超过200，可支持由中文、字母、数字和下划线组成字符串。
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// 对应第三方应用平台企业的模板ID，通过此值可以搜索由第三方应用平台模板ID下发或领取得到的子客模板列表。
        /// </summary>
        [JsonProperty("ChannelTemplateId")]
        public string ChannelTemplateId{ get; set; }

        /// <summary>
        /// 返回控件的范围, 是只返回发起方自己的还是所有参与方的
        /// 
        /// <ul><li>**false**：（默认）只返回发起方控件</li>
        /// <li>**true**：返回所有参与方(包括发起方和签署方)控件</li></ul>
        /// </summary>
        [JsonProperty("QueryAllComponents")]
        public bool? QueryAllComponents{ get; set; }

        /// <summary>
        /// 是否获取模板预览链接。
        /// 
        /// <ul><li>**false**：不获取（默认）</li>
        /// <li>**true**：获取</li></ul>
        /// 
        /// 设置为true之后， 返回参数PreviewUrl，为模板的H5预览链接,  有效期5分钟。可以通过浏览器打开此链接预览模板，或者嵌入到iframe中预览模板。
        /// </summary>
        [JsonProperty("WithPreviewUrl")]
        public bool? WithPreviewUrl{ get; set; }

        /// <summary>
        /// 是否获取模板的PDF文件链接。
        /// 
        /// <ul><li>**false**：不获取（默认）</li>
        /// <li>**true**：获取</li></ul>
        /// 
        /// 设置为true之后， 返回参数PdfUrl，为模板PDF文件链接，有效期5分钟, 可以用于将PDF文件下载到本地
        /// 
        /// 注: `此功能为白名单功能，使用前请联系对接的客户经理沟通。`
        /// </summary>
        [JsonProperty("WithPdfUrl")]
        public bool? WithPdfUrl{ get; set; }

        /// <summary>
        /// 操作者的信息
        /// </summary>
        [JsonProperty("Operator")]
        [System.Obsolete]
        public UserInfo Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "ContentType", this.ContentType);
            this.SetParamArraySimple(map, prefix + "TemplateIds.", this.TemplateIds);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "ChannelTemplateId", this.ChannelTemplateId);
            this.SetParamSimple(map, prefix + "QueryAllComponents", this.QueryAllComponents);
            this.SetParamSimple(map, prefix + "WithPreviewUrl", this.WithPreviewUrl);
            this.SetParamSimple(map, prefix + "WithPdfUrl", this.WithPdfUrl);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
        }
    }
}

