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

namespace TencentCloud.Ds.V20180523.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SignInfo : AbstractModel
    {
        
        /// <summary>
        /// 账户ID
        /// </summary>
        [JsonProperty("AccountResId")]
        public string AccountResId{ get; set; }

        /// <summary>
        /// 授权时间，格式为年月日时分秒，例20160801095509
        /// </summary>
        [JsonProperty("AuthorizationTime")]
        public string AuthorizationTime{ get; set; }

        /// <summary>
        /// 授权IP地址
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// 签章ID
        /// </summary>
        [JsonProperty("SealId")]
        public string SealId{ get; set; }

        /// <summary>
        /// 签名图片，优先级比SealId高
        /// </summary>
        [JsonProperty("ImageData")]
        public string ImageData{ get; set; }

        /// <summary>
        /// 默认值：1  表示RSA证书， 2 表示国密证书， 参数不传时默认为1
        /// </summary>
        [JsonProperty("CertType")]
        public long? CertType{ get; set; }

        /// <summary>
        /// 签名域的标签值
        /// </summary>
        [JsonProperty("SignLocation")]
        public string SignLocation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccountResId", this.AccountResId);
            this.SetParamSimple(map, prefix + "AuthorizationTime", this.AuthorizationTime);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "SealId", this.SealId);
            this.SetParamSimple(map, prefix + "ImageData", this.ImageData);
            this.SetParamSimple(map, prefix + "CertType", this.CertType);
            this.SetParamSimple(map, prefix + "SignLocation", this.SignLocation);
        }
    }
}

