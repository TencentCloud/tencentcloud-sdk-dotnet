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

namespace TencentCloud.Tbaas.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SignCertCsr : AbstractModel
    {
        
        /// <summary>
        /// 用户签名证书的标识，会存在于用户申请的证书中
        /// </summary>
        [JsonProperty("CertMark")]
        public string CertMark{ get; set; }

        /// <summary>
        /// 用户申请签名证书所需要的证书请求文件的base64编码
        /// </summary>
        [JsonProperty("SignCsrContent")]
        public string SignCsrContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertMark", this.CertMark);
            this.SetParamSimple(map, prefix + "SignCsrContent", this.SignCsrContent);
        }
    }
}

