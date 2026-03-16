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

    public class ProxyOrganizationInfo : AbstractModel
    {
        
        /// <summary>
        /// 第三方应用平台自定义，对应第三方平台子客企业的唯一标识。一个第三方平台子客企业主体与子客企业ProxyOrganizationOpenId是一一对应的，不可更改，不可重复使用。（例如，可以使用企业名称的hash值，或者社会统一信用代码的hash值，或者随机hash值，需要第三方应用平台保存），最大64位字符串
        /// </summary>
        [JsonProperty("OrganizationOpenId")]
        public string OrganizationOpenId{ get; set; }

        /// <summary>
        /// 第三方应用平台自定义，对应第三方平台子客企业超管的唯一标识。
        /// 
        /// 
        /// 注意:
        /// 1. OpenId在子客企业对应一个真实员工，**本应用唯一, 不可重复使用**，最大64位字符串
        /// 2. 可使用用户在贵方企业系统中的Userid或者hash值作为子客企业的员工OpenId
        /// 3. **员工加入企业后**, 可以通过<a href="https://qian.tencent.com/developers/partnerApis/accounts/CreateConsoleLoginUrl" target="_blank">生成子客登录链接</a>登录子客控制台后, 在**组织架构**模块查看员工们的OpenId, 样式如下图
        /// ![image](https://qcloudimg.tencent-cloud.cn/raw/bb67fb66c926759df3a0af5838fdafd5.png)
        /// </summary>
        [JsonProperty("OperatorOpenId")]
        public string OperatorOpenId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrganizationOpenId", this.OrganizationOpenId);
            this.SetParamSimple(map, prefix + "OperatorOpenId", this.OperatorOpenId);
        }
    }
}

