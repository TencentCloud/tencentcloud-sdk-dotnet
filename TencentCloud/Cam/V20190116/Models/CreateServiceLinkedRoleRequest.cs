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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateServiceLinkedRoleRequest : AbstractModel
    {
        
        /// <summary>
        /// 授权服务，附加了此角色的腾讯云服务主体。
        /// </summary>
        [JsonProperty("QCSServiceName")]
        public string[] QCSServiceName{ get; set; }

        /// <summary>
        /// 自定义后缀，根据您提供的字符串，与服务提供的前缀组合在一起以形成完整的角色名称。
        /// </summary>
        [JsonProperty("CustomSuffix")]
        public string CustomSuffix{ get; set; }

        /// <summary>
        /// 角色说明。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "QCSServiceName.", this.QCSServiceName);
            this.SetParamSimple(map, prefix + "CustomSuffix", this.CustomSuffix);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

