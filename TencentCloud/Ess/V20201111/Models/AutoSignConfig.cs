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
        /// 自动签开通个人用户的三要素
        /// </summary>
        [JsonProperty("UserInfo")]
        public UserThreeFactor UserInfo{ get; set; }

        /// <summary>
        /// 接受回调URL地址。支持http://或者https://协议
        /// 
        /// Post数据到此地址后返回httpcode200表示接受回调成功, 返回其他httpcode表示接受回调失败
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 是否回调证书信息
        /// false-不需要 (默认值)
        /// true-需要
        /// </summary>
        [JsonProperty("CertInfoCallback")]
        public bool? CertInfoCallback{ get; set; }

        /// <summary>
        /// 是否支持用户自定义签名印章
        /// false-不需要(默认)
        /// true-需要
        /// </summary>
        [JsonProperty("UserDefineSeal")]
        public bool? UserDefineSeal{ get; set; }

        /// <summary>
        /// 是否需要回调的时候返回印章(签名) 图片的 base64
        /// 
        /// false-不需要(默认)
        /// true-需要
        /// </summary>
        [JsonProperty("SealImgCallback")]
        public bool? SealImgCallback{ get; set; }

        /// <summary>
        /// 开通时候的验证方式, 分布为
        /// 
        /// WEIXINAPP : 微信人脸识别
        /// INSIGHT : 慧眼人脸认别
        /// TELECOM : 运营商三要素验证
        /// 
        /// 如果是小程序开通链接，支持传 WEIXINAPP / TELECOM。
        /// 
        /// 如果是 H5 开通链接，支持传 INSIGHT / TELECOM。默认值 WEIXINAPP / INSIGHT。
        /// </summary>
        [JsonProperty("VerifyChannels")]
        public string[] VerifyChannels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "UserInfo.", this.UserInfo);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "CertInfoCallback", this.CertInfoCallback);
            this.SetParamSimple(map, prefix + "UserDefineSeal", this.UserDefineSeal);
            this.SetParamSimple(map, prefix + "SealImgCallback", this.SealImgCallback);
            this.SetParamArraySimple(map, prefix + "VerifyChannels.", this.VerifyChannels);
        }
    }
}

