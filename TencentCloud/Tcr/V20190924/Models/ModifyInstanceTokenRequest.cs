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

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyInstanceTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例长期访问凭证 ID
        /// </summary>
        [JsonProperty("TokenId")]
        public string TokenId{ get; set; }

        /// <summary>
        /// 实例 ID
        /// </summary>
        [JsonProperty("RegistryId")]
        public string RegistryId{ get; set; }

        /// <summary>
        /// 启用或禁用实例长期访问凭证
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// 访问凭证描述
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// 1为修改描述 2为启动禁用，不填写默认为修改启动禁用
        /// </summary>
        [JsonProperty("ModifyFlag")]
        public long? ModifyFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TokenId", this.TokenId);
            this.SetParamSimple(map, prefix + "RegistryId", this.RegistryId);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "ModifyFlag", this.ModifyFlag);
        }
    }
}

