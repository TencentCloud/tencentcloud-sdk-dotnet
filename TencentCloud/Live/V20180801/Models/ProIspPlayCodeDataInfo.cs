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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProIspPlayCodeDataInfo : AbstractModel
    {
        
        /// <summary>
        /// 省份。
        /// </summary>
        [JsonProperty("ProvinceName")]
        public string ProvinceName{ get; set; }

        /// <summary>
        /// 运营商。
        /// </summary>
        [JsonProperty("IspName")]
        public string IspName{ get; set; }

        /// <summary>
        /// 错误码为4开头的次数。
        /// </summary>
        [JsonProperty("Code4xx")]
        public ulong? Code4xx{ get; set; }

        /// <summary>
        /// 错误码为5开头的次数。
        /// </summary>
        [JsonProperty("Code5xx")]
        public ulong? Code5xx{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProvinceName", this.ProvinceName);
            this.SetParamSimple(map, prefix + "IspName", this.IspName);
            this.SetParamSimple(map, prefix + "Code4xx", this.Code4xx);
            this.SetParamSimple(map, prefix + "Code5xx", this.Code5xx);
        }
    }
}

