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

namespace TencentCloud.Weilingwith.V20230427.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeviceSpaceInfoRes : AbstractModel
    {
        
        /// <summary>
        /// 建筑id
        /// </summary>
        [JsonProperty("BuildingId")]
        public string BuildingId{ get; set; }

        /// <summary>
        /// 构件id
        /// </summary>
        [JsonProperty("ElementId")]
        public string ElementId{ get; set; }

        /// <summary>
        /// 构件类型
        /// </summary>
        [JsonProperty("EntityType")]
        public string EntityType{ get; set; }

        /// <summary>
        /// 构件名称
        /// </summary>
        [JsonProperty("ElementName")]
        public string ElementName{ get; set; }

        /// <summary>
        /// 构件级别
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// 底部标高（单位mm）
        /// </summary>
        [JsonProperty("BottomHeight")]
        public long? BottomHeight{ get; set; }

        /// <summary>
        /// 空间编码
        /// </summary>
        [JsonProperty("SpaceCode")]
        public string SpaceCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BuildingId", this.BuildingId);
            this.SetParamSimple(map, prefix + "ElementId", this.ElementId);
            this.SetParamSimple(map, prefix + "EntityType", this.EntityType);
            this.SetParamSimple(map, prefix + "ElementName", this.ElementName);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "BottomHeight", this.BottomHeight);
            this.SetParamSimple(map, prefix + "SpaceCode", this.SpaceCode);
        }
    }
}

