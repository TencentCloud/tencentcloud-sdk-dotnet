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

namespace TencentCloud.Tds.V20220801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RiskInfo : AbstractModel
    {
        
        /// <summary>
        /// 风险类型。更多详情请参见：[Android](https://cloud.tencent.com/document/product/1628/85898)、[iOS](https://cloud.tencent.com/document/product/1628/85896)、[H5](https://cloud.tencent.com/document/product/1628/85897)、[小程序](https://cloud.tencent.com/document/product/1628/85895)、[场景风险](https://cloud.tencent.com/document/product/1628/88912)
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// [风险等级](https://cloud.tencent.com/document/product/1628/85308)
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Level", this.Level);
        }
    }
}

