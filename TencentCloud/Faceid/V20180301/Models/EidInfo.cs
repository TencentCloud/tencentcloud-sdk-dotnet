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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EidInfo : AbstractModel
    {
        
        /// <summary>
        /// 商户方 appeIDcode 的数字证书
        /// </summary>
        [JsonProperty("EidCode")]
        public string EidCode{ get; set; }

        /// <summary>
        /// Eid中心针对商户方EidCode的电子签名
        /// </summary>
        [JsonProperty("EidSign")]
        public string EidSign{ get; set; }

        /// <summary>
        /// 商户方公钥加密的会话密钥的base64字符串，[指引详见](https://cloud.tencent.com/document/product/1007/63370)
        /// </summary>
        [JsonProperty("DesKey")]
        public string DesKey{ get; set; }

        /// <summary>
        /// 会话密钥sm2加密后的base64字符串，[指引详见](https://cloud.tencent.com/document/product/1007/63370)
        /// </summary>
        [JsonProperty("UserInfo")]
        public string UserInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EidCode", this.EidCode);
            this.SetParamSimple(map, prefix + "EidSign", this.EidSign);
            this.SetParamSimple(map, prefix + "DesKey", this.DesKey);
            this.SetParamSimple(map, prefix + "UserInfo", this.UserInfo);
        }
    }
}

