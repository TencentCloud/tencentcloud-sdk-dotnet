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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyModuleIpDirectRequest : AbstractModel
    {
        
        /// <summary>
        /// 模块ID。
        /// </summary>
        [JsonProperty("ModuleId")]
        public string ModuleId{ get; set; }

        /// <summary>
        /// 是否关闭IP直通。取值范围：
        /// true：表示关闭IP直通
        /// false：表示开通IP直通
        /// </summary>
        [JsonProperty("CloseIpDirect")]
        public bool? CloseIpDirect{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModuleId", this.ModuleId);
            this.SetParamSimple(map, prefix + "CloseIpDirect", this.CloseIpDirect);
        }
    }
}

