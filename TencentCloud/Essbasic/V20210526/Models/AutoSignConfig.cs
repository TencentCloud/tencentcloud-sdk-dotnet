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

    public class AutoSignConfig : AbstractModel
    {
        
        /// <summary>
        /// 自动签开通个人用户信息, 包括名字,身份证等
        /// </summary>
        [JsonProperty("UserInfo")]
        public UserThreeFactor UserInfo{ get; set; }

        /// <summary>
        /// 是否回调证书信息:
        /// <ul><li>**false**: 不需要(默认)</li>
        /// <li>**true**:需要</li></ul>
        /// </summary>
        [JsonProperty("CertInfoCallback")]
        public bool? CertInfoCallback{ get; set; }

        /// <summary>
        /// 是否支持用户自定义签名印章:
        /// <ul><li>**false**: 不能自己定义(默认)</li>
        /// <li>**true**: 可以自己定义</li></ul>
        /// </summary>
        [JsonProperty("UserDefineSeal")]
        public bool? UserDefineSeal{ get; set; }

        /// <summary>
        /// 回调中是否需要自动签将要使用的印章（签名）图片的 base64:
        /// <ul><li>**false**: 不需要(默认)</li>
        /// <li>**true**: 需要</li></ul>
        /// </summary>
        [JsonProperty("SealImgCallback")]
        public bool? SealImgCallback{ get; set; }

        /// <summary>
        /// 回调链接，如果渠道已经配置了，可以不传
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 开通时候的身份验证方式, 取值为：
        /// <ul><li>**WEIXINAPP** : 微信人脸识别</li>
        /// <li>**INSIGHT** : 慧眼人脸认别</li>
        /// <li>**TELECOM** : 运营商三要素验证</li></ul>
        /// 注：
        /// <ul><li>如果是小程序开通链接，支持传 WEIXINAPP / TELECOM。为空默认 WEIXINAPP</li>
        /// <li>如果是 H5 开通链接，支持传 INSIGHT / TELECOM。为空默认 INSIGHT </li></ul>
        /// </summary>
        [JsonProperty("VerifyChannels")]
        public string[] VerifyChannels{ get; set; }

        /// <summary>
        /// 设置用户开通自动签时是否绑定个人自动签账号许可。
        /// 
        /// <ul><li>**0**: (默认) 使用个人自动签账号许可进行开通，个人自动签账号许可有效期1年，注: `不可解绑释放更换他人`</li>
        /// <li>**1**: 不绑定自动签账号许可开通，后续使用合同份额进行合同发起</li></ul>
        /// </summary>
        [JsonProperty("LicenseType")]
        public long? LicenseType{ get; set; }

        /// <summary>
        /// 开通成功后前端页面跳转的url，此字段的用法场景请联系客户经理确认。
        /// 
        /// 注：`仅支持H5开通场景`, `跳转链接仅支持 https:// , qianapp:// 开头`
        /// 
        /// 跳转场景：
        /// <ul><li>**贵方H5 -> 腾讯电子签H5 -> 贵方H5** : JumpUrl格式: https://YOUR_CUSTOM_URL/xxxx，只需满足 https:// 开头的正确且合规的网址即可。</li>
        /// <li>**贵方原生App -> 腾讯电子签H5 -> 贵方原生App** : JumpUrl格式: qianapp://YOUR_CUSTOM_URL，只需满足 qianapp:// 开头的URL即可。`APP实现方，需要拦截Webview地址跳转，发现url是qianapp:// 开头时跳转到原生页面。`APP拦截地址跳转可参考：<a href='https://stackoverflow.com/questions/41693263/android-webview-err-unknown-url-scheme'>Android</a>，<a href='https://razorpay.com/docs/payments/payment-gateway/web-integration/standard/webview/upi-intent-ios/'>IOS</a> </li></ul>
        /// 
        /// 成功结果返回：
        /// 若贵方需要在跳转回时通过链接query参数提示开通成功，JumpUrl中的query应携带如下参数：`appendResult=qian`。这样腾讯电子签H5会在跳转回的url后面会添加query参数提示贵方签署成功，比如 qianapp://YOUR_CUSTOM_URL?action=sign&result=success&from=tencent_ess
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

