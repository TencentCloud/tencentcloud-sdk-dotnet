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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTawAreasRequest : AbstractModel
    {
        
        /// <summary>
        /// 片区Id
        /// </summary>
        [JsonProperty("AreaIds")]
        public long?[] AreaIds{ get; set; }

        /// <summary>
        /// 片区Key
        /// </summary>
        [JsonProperty("AreaKeys")]
        public string[] AreaKeys{ get; set; }

        /// <summary>
        /// 分页Limit，默认根据AreaKeys和AreaStatuses参数查询所有。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 片区状态(1=有效，2=无效)
        /// </summary>
        [JsonProperty("AreaStatuses")]
        public long?[] AreaStatuses{ get; set; }

        /// <summary>
        /// 分页Offset，默认根据AreaKeys和AreaStatuses参数查询所有。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "AreaIds.", this.AreaIds);
            this.SetParamArraySimple(map, prefix + "AreaKeys.", this.AreaKeys);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "AreaStatuses.", this.AreaStatuses);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

