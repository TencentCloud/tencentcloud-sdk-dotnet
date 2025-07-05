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

namespace TencentCloud.Irp.V20220324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReportMaterialRequest : AbstractModel
    {
        
        /// <summary>
        /// 业务id
        /// </summary>
        [JsonProperty("Bid")]
        public string Bid{ get; set; }

        /// <summary>
        /// 上报的信息流数组，一次数量不超过50
        /// </summary>
        [JsonProperty("DocItemList")]
        public DocItem[] DocItemList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Bid", this.Bid);
            this.SetParamArrayObj(map, prefix + "DocItemList.", this.DocItemList);
        }
    }
}

