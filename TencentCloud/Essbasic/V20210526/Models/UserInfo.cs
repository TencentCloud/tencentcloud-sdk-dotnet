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

    public class UserInfo : AbstractModel
    {
        
        /// <summary>
        /// 第三方应用平台自定义，对应第三方平台子客企业员工的唯一标识。
        /// 
        /// 
        /// 注意:
        /// 1. OpenId在子客企业对应一个真实员工，**本应用唯一, 不可重复使用**，最大64位字符串
        /// 2. 可使用用户在贵方企业系统中的Userid或者hash值作为子客企业的员工OpenId
        /// 3. **员工加入企业后**, 可以通过<a href="https://qian.tencent.com/developers/partnerApis/accounts/CreateConsoleLoginUrl" target="_blank">生成子客登录链接</a>登录子客控制台后, 在**组织架构**模块查看员工们的OpenId, 样式如下图
        /// ![image](https://qcloudimg.tencent-cloud.cn/raw/bb67fb66c926759df3a0af5838fdafd5.png)
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 内部参数，暂未开放使用
        /// </summary>
        [JsonProperty("Channel")]
        [System.Obsolete]
        public string Channel{ get; set; }

        /// <summary>
        /// 内部参数，暂未开放使用
        /// </summary>
        [JsonProperty("CustomUserId")]
        [System.Obsolete]
        public string CustomUserId{ get; set; }

        /// <summary>
        /// 内部参数，暂未开放使用
        /// </summary>
        [JsonProperty("ClientIp")]
        [System.Obsolete]
        public string ClientIp{ get; set; }

        /// <summary>
        /// 内部参数，暂未开放使用
        /// </summary>
        [JsonProperty("ProxyIp")]
        [System.Obsolete]
        public string ProxyIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "CustomUserId", this.CustomUserId);
            this.SetParamSimple(map, prefix + "ClientIp", this.ClientIp);
            this.SetParamSimple(map, prefix + "ProxyIp", this.ProxyIp);
        }
    }
}

