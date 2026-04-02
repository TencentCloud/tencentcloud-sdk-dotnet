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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IPSSLConfig : AbstractModel
    {
        
        /// <summary>
        /// IP SSL关联的域名。如果Status值为 unbound 时，该字段为空值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssociatedDomain")]
        public string AssociatedDomain{ get; set; }

        /// <summary>
        /// 关联状态， 取值如下：
        /// <li>bound：IP SSL配置已绑定</li>
        /// <li>binding：IP SSL配置绑定中</li>
        /// <li>unbinding：IP SSL配置解绑中</li>
        /// <li>unbound：IP SSL配置未绑定</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssociatedDomain", this.AssociatedDomain);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

