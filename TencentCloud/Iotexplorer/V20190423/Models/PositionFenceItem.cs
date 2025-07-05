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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PositionFenceItem : AbstractModel
    {
        
        /// <summary>
        /// 围栏Id
        /// </summary>
        [JsonProperty("FenceId")]
        public long? FenceId{ get; set; }

        /// <summary>
        /// 位置空间Id
        /// </summary>
        [JsonProperty("SpaceId")]
        public string SpaceId{ get; set; }

        /// <summary>
        /// 围栏名称
        /// </summary>
        [JsonProperty("FenceName")]
        public string FenceName{ get; set; }

        /// <summary>
        /// 围栏描述
        /// </summary>
        [JsonProperty("FenceDesc")]
        public string FenceDesc{ get; set; }

        /// <summary>
        /// 围栏区域信息，采用 GeoJSON 格式
        /// </summary>
        [JsonProperty("FenceArea")]
        public string FenceArea{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FenceId", this.FenceId);
            this.SetParamSimple(map, prefix + "SpaceId", this.SpaceId);
            this.SetParamSimple(map, prefix + "FenceName", this.FenceName);
            this.SetParamSimple(map, prefix + "FenceDesc", this.FenceDesc);
            this.SetParamSimple(map, prefix + "FenceArea", this.FenceArea);
        }
    }
}

