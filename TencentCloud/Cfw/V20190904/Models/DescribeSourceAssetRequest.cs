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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSourceAssetRequest : AbstractModel
    {
        
        /// <summary>
        /// 模糊查询
        /// </summary>
        [JsonProperty("FuzzySearch")]
        public string FuzzySearch{ get; set; }

        /// <summary>
        /// 资产类型 1公网 2内网
        /// </summary>
        [JsonProperty("InsType")]
        public string InsType{ get; set; }

        /// <summary>
        /// ChooseType为1，查询已经分组的资产；ChooseType不为1查询没有分组的资产
        /// </summary>
        [JsonProperty("ChooseType")]
        public string ChooseType{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 查询单页的最大值；eg：10；则最多返回10条结果
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 查询结果的偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FuzzySearch", this.FuzzySearch);
            this.SetParamSimple(map, prefix + "InsType", this.InsType);
            this.SetParamSimple(map, prefix + "ChooseType", this.ChooseType);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

