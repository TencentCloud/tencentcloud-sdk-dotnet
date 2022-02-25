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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryExceedingInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 超额日期。格式为yyyy-MM-dd。
        /// </summary>
        [JsonProperty("TimeStr")]
        public string TimeStr{ get; set; }

        /// <summary>
        /// 维度。目前支持三个维度: AGENT, ANCHOR, ORDER。不填默认使用AGENT维度。
        /// </summary>
        [JsonProperty("Dimension")]
        public string Dimension{ get; set; }

        /// <summary>
        /// 分页信息。不填默认Index为1，Count为100。
        /// </summary>
        [JsonProperty("PageNumber")]
        public Paging PageNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimeStr", this.TimeStr);
            this.SetParamSimple(map, prefix + "Dimension", this.Dimension);
            this.SetParamObj(map, prefix + "PageNumber.", this.PageNumber);
        }
    }
}

