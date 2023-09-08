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

namespace TencentCloud.Ess.V20201111.Models
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
        /// 回调中是否需要自动签将要使用的印章(签名) 图片的 base64:
        /// <ul><li>**false**: 不需要(默认)</li>
        /// <li>**true**: 需要</li></ul>
        /// </summary>
        [JsonProperty("SealImgCallback")]
        public bool? SealImgCallback{ get; set; }

        /// <summary>
        /// 执行结果的回调URL，该URL仅支持HTTP或HTTPS协议，建议采用HTTPS协议以保证数据传输的安全性。
        /// 腾讯电子签服务器将通过POST方式，application/json格式通知执行结果，请确保外网可以正常访问该URL。
        /// 回调的相关说明可参考开发者中心的<a href="https://qian.tencent.com/developers/company/callback_types_v2" target="_blank">回调通知</a>模块。
        /// </summary>
        [JsonProperty("CallbackUrl")]
        [System.Obsolete]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 开通时候的身份验证方式, 取值为：
        /// <ul><li>**WEIXINAPP** : 微信人脸识别</li>
        /// <li>**INSIGHT** : 慧眼人脸认别</li>
        /// <li>**TELECOM** : 运营商三要素验证</li></ul>
        /// 注：
        /// <ul><li>如果是小程序开通链接，支持传 WEIXINAPP / TELECOM。为空默认 WEIXINAPP</li>
        /// <li>如果是 H5 开通链接，支持传 INSIGHT / TELECOM。为空默认 INSIGHT </li>
        /// </summary>
        [JsonProperty("VerifyChannels")]
        public string[] VerifyChannels{ get; set; }

        /// <summary>
        /// 设置用户开通自动签时是否绑定个人自动签账号许可。
        /// 
        /// <ul><li>**0**: (默认) 使用个人自动签账号许可进行开通，个人自动签账号许可有效期1年，注: `不可解绑释放更换他人`</li>
        /// <li>**1**: 不使用个人自动签账号许可进行开通</li></ul>
        /// </summary>
        [JsonProperty("LicenseType")]
        public long? LicenseType{ get; set; }


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
        }
    }
}

