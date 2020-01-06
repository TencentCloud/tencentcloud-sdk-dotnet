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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateIp6TranslatorsRequest : AbstractModel
    {
        
        /// <summary>
        /// 转换实例名称
        /// </summary>
        [JsonProperty("Ip6TranslatorName")]
        public string Ip6TranslatorName{ get; set; }

        /// <summary>
        /// 创建转换实例数量，默认是1个
        /// </summary>
        [JsonProperty("Ip6TranslatorCount")]
        public long? Ip6TranslatorCount{ get; set; }

        /// <summary>
        /// 转换实例运营商属性，可取"CMCC","CTCC","CUCC","BGP"
        /// </summary>
        [JsonProperty("Ip6InternetServiceProvider")]
        public string Ip6InternetServiceProvider{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Ip6TranslatorName", this.Ip6TranslatorName);
            this.SetParamSimple(map, prefix + "Ip6TranslatorCount", this.Ip6TranslatorCount);
            this.SetParamSimple(map, prefix + "Ip6InternetServiceProvider", this.Ip6InternetServiceProvider);
        }
    }
}

