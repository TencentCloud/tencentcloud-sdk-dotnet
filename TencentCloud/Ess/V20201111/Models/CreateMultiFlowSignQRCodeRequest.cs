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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateMultiFlowSignQRCodeRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>执行本接口操作的员工信息。<br>注: <code>在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。</code></p>
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// <p>合同模板ID，为32位字符串。<br>可登录腾讯电子签控制台，在 &quot;模板&quot;-&gt;&quot;模板中心&quot;-&gt;&quot;列表展示设置&quot;选中模板 ID 中查看某个模板的TemplateId(在页面中展示为模板ID)。</p>
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// <p>合同流程的名称（可自定义此名称），长度不能超过200，只能由中文、字母、数字和下划线组成。<br>该名称还将用于合同签署完成后的下载文件名。</p>
        /// </summary>
        [JsonProperty("FlowName")]
        public string FlowName{ get; set; }

        /// <summary>
        /// <p>通过此二维码可发起的流程最大限额，如未明确指定，默认为5份。<br>一旦发起流程数超越该限制，该二维码将自动失效。</p>
        /// </summary>
        [JsonProperty("MaxFlowNum")]
        public long? MaxFlowNum{ get; set; }

        /// <summary>
        /// <p>二维码的有效期限，默认为7天，最高设定不得超过90天。<br>一旦超过二维码的有效期限，该二维码将自动失效。</p>
        /// </summary>
        [JsonProperty("QrEffectiveDay")]
        [System.Obsolete]
        public long? QrEffectiveDay{ get; set; }

        /// <summary>
        /// <p>合同流程的签署有效期限，若未设定签署截止日期，则默认为自合同流程创建起的7天内截止。<br>若在签署截止日期前未完成签署，合同状态将变更为已过期，从而导致合同无效。<br>最长设定期限不得超过30天。</p>
        /// </summary>
        [JsonProperty("FlowEffectiveDay")]
        public long? FlowEffectiveDay{ get; set; }

        /// <summary>
        /// <p>在短信通知、填写、签署流程中，若标题、按钮、合同详情等地方存在“合同”字样时，可根据此配置指定文案，可选文案如下：<br> <ul><li> <b>0</b> :合同（默认值）</li> <li> <b>1</b> :文件</li> <li> <b>2</b> :协议</li><li> <b>3</b> :文书</li></ul></p><p>效果如下:<br><img src="https://qcloudimg.tencent-cloud.cn/raw/e4a2c4d638717cc901d3dbd5137c9bbc.png" alt="FlowDisplayType"></p><p>枚举值：</p><ul><li>0： 合同</li><li>1： 文件</li><li>2： 协议</li><li>3： 文书</li></ul><p>默认值：0</p>
        /// </summary>
        [JsonProperty("FlowDisplayType")]
        public long? FlowDisplayType{ get; set; }

        /// <summary>
        /// <p>指定签署人信息。<br>在指定签署人后，仅允许特定签署人通过扫描二维码进行签署。</p>
        /// </summary>
        [JsonProperty("Restrictions")]
        public ApproverRestriction[] Restrictions{ get; set; }

        /// <summary>
        /// <p>调用方自定义的个性化字段(可自定义此字段的值)，并以base64方式编码，支持的最大数据大小为 20480长度。<br>在合同状态变更的回调信息等场景中，该字段的信息将原封不动地透传给贵方。<br>回调的相关说明可参考开发者中心的<a href="https://qian.tencent.com/developers/company/callback_types_v2" target="_blank">回调通知</a>模块。</p>
        /// </summary>
        [JsonProperty("UserData")]
        public string UserData{ get; set; }

        /// <summary>
        /// <p>已废弃，回调配置统一使用企业应用管理-应用集成-企业版应用中的配置<br><br> 通过一码多扫二维码发起的合同，回调消息可参考文档 https://qian.tencent.com/developers/company/callback_types_contracts_sign<br><br> 用户通过签署二维码发起合同时，因企业额度不足导致失败 会触发签署二维码相关回调,具体参考文档 https://qian.tencent.com/developers/company/callback_types_commons#%E7%AD%BE%E7%BD%B2%E4%BA%8C%E7%BB%B4%E7%A0%81%E7%9B%B8%E5%85%B3%E5%9B%9E%E8%B0%83</p>
        /// </summary>
        [JsonProperty("CallbackUrl")]
        [System.Obsolete]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// <p>代理企业和员工的信息。<br>在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。</p>
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// <p>限制二维码用户条件（已弃用）</p>
        /// </summary>
        [JsonProperty("ApproverRestrictions")]
        [System.Obsolete]
        public ApproverRestriction ApproverRestrictions{ get; set; }

        /// <summary>
        /// <p>指定签署方在使用个人印章签署控件（SIGN_SIGNATURE） 时可使用的签署方式：自由书写、正楷临摹、系统签名、个人印章。</p>
        /// </summary>
        [JsonProperty("ApproverComponentLimitTypes")]
        public ApproverComponentLimitType[] ApproverComponentLimitTypes{ get; set; }

        /// <summary>
        /// <p>禁止个人用户重复签署，默认不禁止，即同一用户可多次扫码签署多份合同。若要求同一用户仅能扫码签署一份合同，请传入true。</p>
        /// </summary>
        [JsonProperty("ForbidPersonalMultipleSign")]
        public bool? ForbidPersonalMultipleSign{ get; set; }

        /// <summary>
        /// <p>合同流程名称是否应包含扫码签署人的信息，且遵循特定格式（flowname-姓名-手机号后四位）。<br>例如，通过参数FlowName设定的扫码发起合同名称为“员工入职合同”，当扫码人张三（手机号18800009527）扫码签署时，合同名称将自动生成为“员工入职合同-张三-9527”。</p>
        /// </summary>
        [JsonProperty("FlowNameAppendScannerInfo")]
        public bool? FlowNameAppendScannerInfo{ get; set; }

        /// <summary>
        /// <p>签署二维码的名称（可自定义此名称），长度不能超过200，只能由中文、字母、数字和下划线组成,会在生成的二维码图片上展示，若为空，则使用FlowName</p>
        /// </summary>
        [JsonProperty("QrCodeName")]
        public string QrCodeName{ get; set; }

        /// <summary>
        /// <p>签署二维码截止时间，格式为Unix标准时间戳（秒），如果未设置签署截止时间，则默认为签署二维码创建后的7天时截止，最长可设置为签署二维码创建后的365天时截止。</p>
        /// </summary>
        [JsonProperty("QrCodeExpiredOn")]
        public long? QrCodeExpiredOn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "FlowName", this.FlowName);
            this.SetParamSimple(map, prefix + "MaxFlowNum", this.MaxFlowNum);
            this.SetParamSimple(map, prefix + "QrEffectiveDay", this.QrEffectiveDay);
            this.SetParamSimple(map, prefix + "FlowEffectiveDay", this.FlowEffectiveDay);
            this.SetParamSimple(map, prefix + "FlowDisplayType", this.FlowDisplayType);
            this.SetParamArrayObj(map, prefix + "Restrictions.", this.Restrictions);
            this.SetParamSimple(map, prefix + "UserData", this.UserData);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamObj(map, prefix + "ApproverRestrictions.", this.ApproverRestrictions);
            this.SetParamArrayObj(map, prefix + "ApproverComponentLimitTypes.", this.ApproverComponentLimitTypes);
            this.SetParamSimple(map, prefix + "ForbidPersonalMultipleSign", this.ForbidPersonalMultipleSign);
            this.SetParamSimple(map, prefix + "FlowNameAppendScannerInfo", this.FlowNameAppendScannerInfo);
            this.SetParamSimple(map, prefix + "QrCodeName", this.QrCodeName);
            this.SetParamSimple(map, prefix + "QrCodeExpiredOn", this.QrCodeExpiredOn);
        }
    }
}

