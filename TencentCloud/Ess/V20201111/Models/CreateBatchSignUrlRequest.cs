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

    public class CreateBatchSignUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行本接口操作的员工信息。
        /// 注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 签署方经办人的姓名。
        /// 经办人的姓名将用于身份认证和电子签名，请确保填写的姓名为签署方的真实姓名，而非昵称等代名。
        /// 
        /// 注：
        /// <ul>
        /// <li>请确保和合同中填入的一致。</li>
        /// <li>在动态签署人补充链接场景中，可以通过传入这个值，对补充的个人参与方信息进行限制。仅匹配传入姓名的参与方才能补充合同。此参数预设信息功能暂时仅支持个人动态参与方。</li>
        /// </ul>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 手机号码， 支持中国大陆手机号11位数字(无需加+86前缀或其他字符)。请确认手机号所有方为此业务通知方。注：<ul><li>请确保和合同中填入的一致,  若无法保持一致，请确保在发起和生成批量签署链接时传入相同的参与方证件信息。</li><li>在生成动态签署人补充链接场景中，可以通过传入此值，对补充的个人参与方信息进行限制。仅匹配传入手机号的参与方才能补充合同。此参数预设信息功能暂时仅支持个人动态参与方。 </li></ul>
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 代理企业和员工的信息。
        /// 在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 证件类型，支持以下类型
        /// <ul><li>ID_CARD : 中国大陆居民身份证 (默认值)</li>
        /// <li>HONGKONG_AND_MACAO : 港澳居民来往内地通行证</li>
        /// <li>HONGKONG_MACAO_AND_TAIWAN : 港澳台居民居住证(格式同中国大陆居民身份证)</li></ul>
        /// 
        /// 注：
        /// 1. `请确保和合同中填入的一致`。
        /// 2. `在生成动态签署人补充链接场景中，可以通过传入此值，对补充的个人参与方信息进行限制。仅匹配传入证件类型的参与方才能补充合同。此参数预设信息功能暂时仅支持个人动态参与方，且需要和证件号参数一同传递，不能单独进行限制。`
        /// </summary>
        [JsonProperty("IdCardType")]
        public string IdCardType{ get; set; }

        /// <summary>
        /// 指定批量签署合同的签名类型，可传递以下值：<ul><li>**0**：手写签名</li><li>**1**：OCR楷体</li><li>**2**：姓名印章</li><li>**3**：图片印章</li><li>**4**：系统签名</li><li>**5**：长效手写签名（包含手写签名）</li></ul>注：<ul><li>不传值的情况则计算所有合同中个人签署区的签名类型，规则如下：<ul><li>1.如果所有合同中所有的个人签署区方式包含多种则是手写</li><li>2.如果所有合同中所有个人签名区签名类型仅为一种则就是那一种签名方式（例如合同1有多个签署区都是指定OCR楷体，合同2中也是多个签署区都是指定OCR楷体...则使用OCR楷体）</li></ul></li><li>该参数会覆盖您合同中的签名类型，若您在发起合同时限定了签名类型(赋值签名类型给ComponentTypeLimit)，请将这些签名类型赋予此参数</li><li>若签署方为企业员工，此参数无效，签名方式将以合同中为准。</li></ul>
        /// </summary>
        [JsonProperty("SignatureTypes")]
        public long?[] SignatureTypes{ get; set; }

        /// <summary>
        /// 证件号码，应符合以下规则
        /// <ul><li>中国大陆居民身份证号码应为18位字符串，由数字和大写字母X组成（如存在X，请大写）。</li>
        /// <li>中国港澳居民来往内地通行证号码共11位。第1位为字母，“H”字头签发给中国香港居民，“M”字头签发给中国澳门居民；第2位至第11位为数字。</li>
        /// <li>中国港澳台居民居住证号码编码规则与中国大陆身份证相同，应为18位字符串。</li></ul>
        /// 
        /// 注：
        /// 1. `请确保和合同中填入的一致`。
        /// 2. `在生成动态签署人补充链接场景中，可以通过传入此值，对补充的个人参与方信息进行限制。仅匹配传入证件号的参与方才能补充合同。此参数预设信息功能暂时仅支持个人动态参与方。`
        /// </summary>
        [JsonProperty("IdCardNumber")]
        public string IdCardNumber{ get; set; }

        /// <summary>
        /// 通知用户方式：
        /// <ul>
        /// <li>**NONE** : 不通知（默认）</li>
        /// <li>**SMS** : 短信通知（发送短信通知到Mobile参数所传的手机号）</li>
        /// </ul>
        /// </summary>
        [JsonProperty("NotifyType")]
        public string NotifyType{ get; set; }

        /// <summary>
        /// 批量签署的合同流程ID数组，<font color="red">此参数必传。</font>
        /// 注: `在调用此接口时，请确保合同流程均为本企业发起，且合同数量不超过100个。`
        /// </summary>
        [JsonProperty("FlowIds")]
        public string[] FlowIds{ get; set; }

        /// <summary>
        /// 目标签署人的企业名称，签署人如果是企业员工身份，需要传此参数。
        /// 
        /// 注：
        /// <ul>
        /// <li>请确认该名称与企业营业执照中注册的名称一致。</li>
        /// <li>如果名称中包含英文括号()，请使用中文括号（）代替。</li>
        /// <li>请确保此企业已完成腾讯电子签企业认证。</li>
        /// </ul>
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// 是否直接跳转至合同内容页面进行签署
        /// <ul>
        /// <li>**false**: 会跳转至批量合同流程的列表,  点击需要批量签署合同后进入合同内容页面进行签署(默认)</li>
        /// <li>**true**: 跳过合同流程列表, 直接进入合同内容页面进行签署</li>
        /// </ul>
        /// </summary>
        [JsonProperty("JumpToDetail")]
        public bool? JumpToDetail{ get; set; }

        /// <summary>
        /// 批量签署合同相关信息，指定合同和签署方的信息，用于补充动态签署人。	
        /// </summary>
        [JsonProperty("FlowBatchUrlInfo")]
        public FlowBatchUrlInfo FlowBatchUrlInfo{ get; set; }

        /// <summary>
        /// 签署完成后是否自动回跳
        /// <ul><li>false：否, 签署完成不会自动跳转回来(默认)</li><li>true：是, 签署完成会自动跳转回来</li></ul>
        /// 
        /// 注: 
        /// 1. 该参数<font color="red">只针对APP类型（电子签小程序跳转贵方小程序）场景</font> 的签署链接有效
        /// 2. <font color="red">手机应用APP 或 微信小程序需要监控界面的返回走后序逻辑</font>, 微信小程序的文档可以参考[这个](https://developers.weixin.qq.com/miniprogram/dev/reference/api/App.html#onShow-Object-object)
        /// 3. <font color="red">电子签小程序跳转贵方APP，不支持自动跳转，必须用户手动点击完成按钮（微信的限制）</font> 
        /// </summary>
        [JsonProperty("AutoJumpBack")]
        public bool? AutoJumpBack{ get; set; }

        /// <summary>
        /// <font color="red">仅公众号 H5 跳转电子签小程序时</font>，如需签署完成的“返回应用”功能，在获取签署链接接口的 UrlUseEnv 参数需设置为 **WeChatOfficialAccounts**，小程序签署成功的结果页面中才会出现“返回应用”按钮。在用户点击“返回应用”按钮之后，会返回到公众号 H5。 
        /// 
        /// 参考 [公众号 H5 跳转电子签小程序](https://qian.tencent.com/developers/company/openwxminiprogram/#23-%E5%85%AC%E4%BC%97%E5%8F%B7-h5-%E4%B8%AD%E8%B7%B3%E8%BD%AC)。
        /// </summary>
        [JsonProperty("UrlUseEnv")]
        public string UrlUseEnv{ get; set; }

        /// <summary>
        /// 是否允许此链接中签署方批量拒签。 <ul><li>false (默认): 不允许批量拒签</li> <li>true : 允许批量拒签。</li></ul>
        /// 注：`1. 当前合同组不支持批量拒签功能。请对合同组中的每个子合同逐一执行拒签操作，以达到拒签整个合同组的效果。2. 如果是链接直接跳转至详情页（JumpToDetail参数为true），也不支持批量拒签功能`
        /// </summary>
        [JsonProperty("CanBatchReject")]
        public bool? CanBatchReject{ get; set; }

        /// <summary>
        /// 是否允许此链接中签署方批量确认已读文件。 <ul><li>false (默认): 不允许批量确认已读文件。</li> <li>true : 允许批量确认已读文件。</li></ul>
        /// 注：`1. 此功能为白名单功能，使用前请联系对应客户经理进行开通。2. 使用此功能时，FlowIds参数必传。3. 对于企业签署方，如果对印章/签名控件有限制要求，需要保证所有印章/签名签署控件限制要求(印章id或印章/签名类型限制)一致，否则无法使用此功能。`
        /// </summary>
        [JsonProperty("CanSkipReadFlow")]
        public bool? CanSkipReadFlow{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "IdCardType", this.IdCardType);
            this.SetParamArraySimple(map, prefix + "SignatureTypes.", this.SignatureTypes);
            this.SetParamSimple(map, prefix + "IdCardNumber", this.IdCardNumber);
            this.SetParamSimple(map, prefix + "NotifyType", this.NotifyType);
            this.SetParamArraySimple(map, prefix + "FlowIds.", this.FlowIds);
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
            this.SetParamSimple(map, prefix + "JumpToDetail", this.JumpToDetail);
            this.SetParamObj(map, prefix + "FlowBatchUrlInfo.", this.FlowBatchUrlInfo);
            this.SetParamSimple(map, prefix + "AutoJumpBack", this.AutoJumpBack);
            this.SetParamSimple(map, prefix + "UrlUseEnv", this.UrlUseEnv);
            this.SetParamSimple(map, prefix + "CanBatchReject", this.CanBatchReject);
            this.SetParamSimple(map, prefix + "CanSkipReadFlow", this.CanSkipReadFlow);
        }
    }
}

