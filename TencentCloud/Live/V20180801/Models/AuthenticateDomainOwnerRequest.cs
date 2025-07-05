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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuthenticateDomainOwnerRequest : AbstractModel
    {
        
        /// <summary>
        /// 要验证的域名。
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// 验证类型。可取值：
        /// dnsCheck ：立即验证配置 dns 的解析记录是否与待验证内容一致，成功则保存记录。
        /// fileCheck ：立即验证 web 文件是否与待验证内容一致，成功则保存记录。
        /// dbCheck :  检查是否已经验证成功过。
        /// </summary>
        [JsonProperty("VerifyType")]
        public string VerifyType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "VerifyType", this.VerifyType);
        }
    }
}

