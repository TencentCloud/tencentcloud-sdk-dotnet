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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyEnvAccessControlRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>环境id</p>
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// <p>本次要设置的来源集合</p><p>入参限制：SourceType = PUBLIC 时，标识操作公网开关<br>SourceType = VPC 时，通过配置 VPCWhiteList，开启/关闭 VPC 白名单<br>SourceType = WOA 时，通过配置 WOAAuth，开启/关闭鉴权校验，开启鉴权时，AuthToken 字段为填</p>
        /// </summary>
        [JsonProperty("Sources")]
        public AccessSourceSetting[] Sources{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamArrayObj(map, prefix + "Sources.", this.Sources);
        }
    }
}

