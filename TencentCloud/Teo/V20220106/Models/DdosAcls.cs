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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DdosAcls : AbstractModel
    {
        
        /// <summary>
        /// 端口过滤规则数组。
        /// </summary>
        [JsonProperty("Acl")]
        public DDoSAcl[] Acl{ get; set; }

        /// <summary>
        /// 清空规则标识，取值有：
        /// <li>off ：清空端口过滤规则列表，Acl无需填写。 ；</li>
        /// <li>on ：配置端口过滤规则，需填写Acl参数。</li>默认值为on。
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Acl.", this.Acl);
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
        }
    }
}

