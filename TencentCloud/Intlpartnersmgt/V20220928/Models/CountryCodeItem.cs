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

namespace TencentCloud.Intlpartnersmgt.V20220928.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CountryCodeItem : AbstractModel
    {
        
        /// <summary>
        /// 国家英文名
        /// </summary>
        [JsonProperty("EnName")]
        public string EnName{ get; set; }

        /// <summary>
        /// 国家中文名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// ISO2标准国家/地区代码
        /// </summary>
        [JsonProperty("IOS2")]
        public string IOS2{ get; set; }

        /// <summary>
        /// ISO3标准国家/地区代码
        /// </summary>
        [JsonProperty("IOS3")]
        public string IOS3{ get; set; }

        /// <summary>
        /// 电话代码
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnName", this.EnName);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IOS2", this.IOS2);
            this.SetParamSimple(map, prefix + "IOS3", this.IOS3);
            this.SetParamSimple(map, prefix + "Code", this.Code);
        }
    }
}

