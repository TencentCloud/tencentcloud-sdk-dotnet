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

    public class Agent : AbstractModel
    {
        
        /// <summary>
        /// 应用的唯一标识。不同的业务系统可以采用不同的AppId，不同AppId下的数据是隔离的。可以由控制台开发者中心-应用集成自主生成。
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 渠道平台自定义，对于渠道子客企业的唯一标识。一个渠道子客企业主体与子客企业ProxyOrganizationOpenId是一一对应的，不可更改，不可重复使用。（例如，可以使用企业名称的hash值，或者社会统一信用代码的hash值，或者随机hash值，需要渠道平台保存），最大64位字符串
        /// </summary>
        [JsonProperty("ProxyOrganizationOpenId")]
        public string ProxyOrganizationOpenId{ get; set; }

        /// <summary>
        /// 渠道子客企业中的员工/经办人，通过渠道平台进入电子签完成实名、且被赋予相关权限后，可以参与到企业资源的管理或签署流程中。
        /// </summary>
        [JsonProperty("ProxyOperator")]
        public UserInfo ProxyOperator{ get; set; }

        /// <summary>
        /// 在子客企业开通电子签后，会生成唯一的子客应用Id（ProxyAppId）用于代理调用时的鉴权，在子客开通的回调中获取。
        /// </summary>
        [JsonProperty("ProxyAppId")]
        public string ProxyAppId{ get; set; }

        /// <summary>
        /// 内部参数，暂未开放使用
        /// </summary>
        [JsonProperty("ProxyOrganizationId")]
        public string ProxyOrganizationId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "ProxyOrganizationOpenId", this.ProxyOrganizationOpenId);
            this.SetParamObj(map, prefix + "ProxyOperator.", this.ProxyOperator);
            this.SetParamSimple(map, prefix + "ProxyAppId", this.ProxyAppId);
            this.SetParamSimple(map, prefix + "ProxyOrganizationId", this.ProxyOrganizationId);
        }
    }
}

