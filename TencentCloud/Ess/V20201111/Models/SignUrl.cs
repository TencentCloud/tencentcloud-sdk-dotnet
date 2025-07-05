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

    public class SignUrl : AbstractModel
    {
        
        /// <summary>
        /// 跳转至电子签名小程序签署的链接地址。
        /// 适用于客户端APP及小程序直接唤起电子签名小程序。
        /// </summary>
        [JsonProperty("AppSignUrl")]
        public string AppSignUrl{ get; set; }

        /// <summary>
        /// 签署链接有效时间，格式类似"2022-08-05 15:55:01"
        /// </summary>
        [JsonProperty("EffectiveTime")]
        public string EffectiveTime{ get; set; }

        /// <summary>
        /// 跳转至电子签名小程序签署的链接地址，格式类似于https://essurl.cn/xxx。
        /// 打开此链接将会展示H5中间页面，随后唤起电子签名小程序以进行合同签署。
        /// </summary>
        [JsonProperty("HttpSignUrl")]
        public string HttpSignUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppSignUrl", this.AppSignUrl);
            this.SetParamSimple(map, prefix + "EffectiveTime", this.EffectiveTime);
            this.SetParamSimple(map, prefix + "HttpSignUrl", this.HttpSignUrl);
        }
    }
}

