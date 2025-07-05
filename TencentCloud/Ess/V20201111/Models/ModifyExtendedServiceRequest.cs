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

    public class ModifyExtendedServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行本接口操作的员工信息。
        /// 注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 要管理的拓展服务类型。
        /// <ul><li>OPEN_SERVER_SIGN：企业自动签署</li>
        /// <li>AUTO_SIGN_CAN_FILL_IN：本企业自动签合同支持签前内容补充</li>
        /// <li>OVERSEA_SIGN：企业与港澳台居民签署合同</li>
        /// <li>AGE_LIMIT_EXPANSION：拓宽签署方年龄限制</li>
        /// <li>MOBILE_CHECK_APPROVER：个人签署方仅校验手机号</li>
        /// <li>HIDE_OPERATOR_DISPLAY：隐藏合同经办人姓名</li>
        /// <li>ORGANIZATION_OCR_FALLBACK：正楷临摹签名失败后更换其他签名类型</li>
        /// <li>ORGANIZATION_FLOW_NOTIFY_TYPE：短信通知签署方</li>
        /// <li>HIDE_ONE_KEY_SIGN：个人签署方手写签名时需逐个手写</li>
        /// <li>SIGN_SIGNATURE_DEFAULT_SET_HANDWRITE：个人签署方手动签名</li>
        /// <li>ORGANIZATION_FLOW_EMAIL_NOTIFY：邮件通知签署方</li>
        /// <li>FLOW_APPROVAL：合同审批强制开启</li>
        /// <li>ORGANIZATION_FLOW_PASSWD_NOTIFY：签署密码开通引导</li>
        /// <li>APP_LOGIN：限制企业员工小程序端登录</li>
        /// <li>PC_LOGIN：限制企业员工网页端登录</li>
        /// </ul>
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// 操作类型
        /// <ul>
        /// <li>OPEN : 开通</li>
        /// <li>CLOSE : 关闭</li>
        /// </ul>
        /// </summary>
        [JsonProperty("Operate")]
        public string Operate{ get; set; }

        /// <summary>
        /// 代理企业和员工的信息。
        /// 在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 链接跳转类型，支持以下类型
        /// <ul>
        /// <li>WEIXINAPP : 短链直接跳转到电子签小程序  (默认值)</li>
        /// <li>APP : 第三方APP或小程序跳转电子签小程序</li>
        /// <li>WEIXIN_QRCODE_URL：直接跳转至电子签小程序的二维码链接，无需通过中转页。<font color="red">您需要自行将其转换为二维码，使用微信扫码后可直接进入。请注意，直接点击链接是无效的。</font></li>
        /// </ul>
        /// </summary>
        [JsonProperty("Endpoint")]
        public string Endpoint{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "Operate", this.Operate);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "Endpoint", this.Endpoint);
        }
    }
}

