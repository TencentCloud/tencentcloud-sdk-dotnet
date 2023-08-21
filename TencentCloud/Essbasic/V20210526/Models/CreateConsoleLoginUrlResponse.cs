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

    public class CreateConsoleLoginUrlResponse : AbstractModel
    {
        
        /// <summary>
        /// 子客企业Web控制台url注意事项：
        /// 1. 所有类型的链接在企业未认证/员工未认证完成时，只要在有效期内（一年）都可以访问
        /// 2. 若企业认证完成且员工认证完成后，重新获取pc端的链接在5分钟之内有效，且只能访问一次
        /// 3. 若企业认证完成且员工认证完成后，重新获取CHANNEL/APP的链接只要在有效期内（一年）都可以访问
        /// 4. 此链接仅单次有效，每次登录需要需要重新创建新的链接，尽量不要做链接存储，多次使用。
        /// 5. 创建的链接应避免被转义，如：&被转义为\u0026；如使用Postman请求后，请选择响应类型为 JSON，否则链接将被转义
        /// </summary>
        [JsonProperty("ConsoleUrl")]
        public string ConsoleUrl{ get; set; }

        /// <summary>
        /// 子客企业是否已开通腾讯电子签，true-是，false-否
        /// 注意：
        /// 1、企业是否实名根据传参Agent.ProxyOrganizationOpenId进行判断，非企业名称或者社会信用代码
        /// </summary>
        [JsonProperty("IsActivated")]
        public bool? IsActivated{ get; set; }

        /// <summary>
        /// 当前经办人是否已认证，true-是，false-否
        /// 注意：
        /// 1、经办人是否实名是根据Agent.ProxyOperator.OpenId判断，非经办人姓名
        /// </summary>
        [JsonProperty("ProxyOperatorIsVerified")]
        public bool? ProxyOperatorIsVerified{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConsoleUrl", this.ConsoleUrl);
            this.SetParamSimple(map, prefix + "IsActivated", this.IsActivated);
            this.SetParamSimple(map, prefix + "ProxyOperatorIsVerified", this.ProxyOperatorIsVerified);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

