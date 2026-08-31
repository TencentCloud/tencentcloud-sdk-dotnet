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

    public class AutoSignConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>自动签开通个人用户信息, 包括名字,身份证等</p>
        /// </summary>
        [JsonProperty("UserInfo")]
        public UserThreeFactor UserInfo{ get; set; }

        /// <summary>
        /// <p>是否回调证书信息:</p><ul><li>**false**: 不需要(默认)</li><li>**true**:需要</li></ul><p>注：<code>该字段已经失效，请勿设置此参数。</code></p>
        /// </summary>
        [JsonProperty("CertInfoCallback")]
        public bool? CertInfoCallback{ get; set; }

        /// <summary>
        /// <p>是否支持用户自定义签名印章:</p><ul><li>**false**: 不能自己定义(默认)</li><li>**true**: 可以自己定义</li></ul>
        /// </summary>
        [JsonProperty("UserDefineSeal")]
        public bool? UserDefineSeal{ get; set; }

        /// <summary>
        /// <p>回调中是否需要自动签将要使用的印章(签名) 图片的 base64:</p><ul><li>**false**: 不需要(默认)</li><li>**true**: 需要</li></ul>
        /// </summary>
        [JsonProperty("SealImgCallback")]
        public bool? SealImgCallback{ get; set; }

        /// <summary>
        /// <p>执行结果的回调URL，该URL仅支持HTTP或HTTPS协议，建议采用HTTPS协议以保证数据传输的安全性。<br>腾讯电子签服务器将通过POST方式，application/json格式通知执行结果，请确保外网可以正常访问该URL。<br>回调的相关说明可参考开发者中心的<a href="https://qian.tencent.com/developers/company/callback_types_v2" target="_blank">回调通知</a>模块。</p>
        /// </summary>
        [JsonProperty("CallbackUrl")]
        [System.Obsolete]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// <p>开通时候的身份验证方式, 取值为：</p><ul><li>**WEIXINAPP** : 微信人脸识别</li><li>**INSIGHT** : 慧眼人脸识别</li><li>**TELECOM** : 运营商三要素验证</li></ul>注：<ul><li>如果是小程序开通链接，仅支持 WEIXINAPP 。为空默认 WEIXINAPP</li><li>如果是 H5 开通链接，支持传 INSIGHT / TELECOM。为空默认 INSIGHT </li></ul>
        /// </summary>
        [JsonProperty("VerifyChannels")]
        public string[] VerifyChannels{ get; set; }

        /// <summary>
        /// <p>设置用户自动签合同的扣费方式。</p><ul><li><b>1</b>: (默认)使用合同份额进行扣减</li></ul><p>注：<code>该字段已经失效，请勿设置此参数。</code></p>
        /// </summary>
        [JsonProperty("LicenseType")]
        public long? LicenseType{ get; set; }

        /// <summary>
        /// <p>开通成功后前端页面跳转的url，此字段的用法场景请联系客户经理确认。</p><p>注：<code>仅支持H5开通场景</code>, <code>跳转链接仅支持 https:// , qianapp:// 开头</code></p><p>跳转场景：</p><ul><li>**贵方H5 -&gt; 腾讯电子签H5 -&gt; 贵方H5** : JumpUrl格式: https://YOUR_CUSTOM_URL/xxxx，只需满足 https:// 开头的正确且合规的网址即可。</li><li>**贵方原生App -&gt; 腾讯电子签H5 -&gt; 贵方原生App** : JumpUrl格式: qianapp://YOUR_CUSTOM_URL，只需满足 qianapp:// 开头的URL即可。<code>APP实现方，需要拦截Webview地址跳转，发现url是qianapp:// 开头时跳转到原生页面。</code>APP拦截地址跳转可参考：<a href="https://qian.tencent.com/developers/company/openqianh5/#3-%E8%BF%94%E5%9B%9E%E5%BA%94%E7%94%A8jumpurl%E6%A0%BC%E5%BC%8F">返回应用JumpUrl格式</a></li></ul><p>成功结果返回：<br>若贵方需要在跳转回时通过链接query参数提示开通成功，JumpUrl中的query应携带如下参数：<code>appendResult=qian</code>。这样腾讯电子签H5会在跳转回的url后面会添加query参数提示贵方签署成功，例如： qianapp://YOUR_CUSTOM_URL?action=sign&amp;result=success&amp;from=tencent_ess</p>
        /// </summary>
        [JsonProperty("JumpUrl")]
        public string JumpUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "UserInfo.", this.UserInfo);
            this.SetParamSimple(map, prefix + "CertInfoCallback", this.CertInfoCallback);
            this.SetParamSimple(map, prefix + "UserDefineSeal", this.UserDefineSeal);
            this.SetParamSimple(map, prefix + "SealImgCallback", this.SealImgCallback);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamArraySimple(map, prefix + "VerifyChannels.", this.VerifyChannels);
            this.SetParamSimple(map, prefix + "LicenseType", this.LicenseType);
            this.SetParamSimple(map, prefix + "JumpUrl", this.JumpUrl);
        }
    }
}

