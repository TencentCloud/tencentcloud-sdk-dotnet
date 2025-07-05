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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DSPAMetaType : AbstractModel
    {
        
        /// <summary>
        /// 元数据类型
        /// </summary>
        [JsonProperty("MetaType")]
        public string MetaType{ get; set; }

        /// <summary>
        /// 支持的此元数据类型的地域列表
        /// </summary>
        [JsonProperty("Regions")]
        public string[] Regions{ get; set; }

        /// <summary>
        /// 此元数据类型支持的授权类型：
        /// account    -- 账户名密码授权，账户的最高只读权限需要由用户自行赋予；
        /// automatic -- 一键授权，由DSPA自动生成账户名密码并自动在实例中给账户名赋予最高只读权限；
        /// 如果此列表为空，表明此类资源不支持以上的授权机制，无法通过后台进行授权。
        /// </summary>
        [JsonProperty("SupportedAuthTypes")]
        public string[] SupportedAuthTypes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MetaType", this.MetaType);
            this.SetParamArraySimple(map, prefix + "Regions.", this.Regions);
            this.SetParamArraySimple(map, prefix + "SupportedAuthTypes.", this.SupportedAuthTypes);
        }
    }
}

