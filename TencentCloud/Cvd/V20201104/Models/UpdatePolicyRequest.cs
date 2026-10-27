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

namespace TencentCloud.Cvd.V20201104.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdatePolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>待更新策略id</p>
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }

        /// <summary>
        /// <p>更新策略后策略名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>更新策略后策略描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>更新策略的具体修改值（全集）</p>
        /// </summary>
        [JsonProperty("PolicyInfoList")]
        public PolicyInfo[] PolicyInfoList{ get; set; }

        /// <summary>
        /// <p>新增绑定用户列表</p>
        /// </summary>
        [JsonProperty("BindUserIds")]
        public string[] BindUserIds{ get; set; }

        /// <summary>
        /// <p>移除绑定的用户列表</p>
        /// </summary>
        [JsonProperty("RemoveUserIds")]
        public string[] RemoveUserIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArrayObj(map, prefix + "PolicyInfoList.", this.PolicyInfoList);
            this.SetParamArraySimple(map, prefix + "BindUserIds.", this.BindUserIds);
            this.SetParamArraySimple(map, prefix + "RemoveUserIds.", this.RemoveUserIds);
        }
    }
}

