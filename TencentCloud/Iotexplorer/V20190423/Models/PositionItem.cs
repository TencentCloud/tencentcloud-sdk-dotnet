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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PositionItem : AbstractModel
    {
        
        /// <summary>
        /// 位置点的时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// 位置点的经度
        /// </summary>
        [JsonProperty("Longitude")]
        public float? Longitude{ get; set; }

        /// <summary>
        /// 位置点的纬度
        /// </summary>
        [JsonProperty("Latitude")]
        public float? Latitude{ get; set; }

        /// <summary>
        /// 位置点的定位类型
        /// </summary>
        [JsonProperty("LocationType")]
        public string LocationType{ get; set; }

        /// <summary>
        /// 位置点的精度预估，单位为米
        /// </summary>
        [JsonProperty("Accuracy")]
        public float? Accuracy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Longitude", this.Longitude);
            this.SetParamSimple(map, prefix + "Latitude", this.Latitude);
            this.SetParamSimple(map, prefix + "LocationType", this.LocationType);
            this.SetParamSimple(map, prefix + "Accuracy", this.Accuracy);
        }
    }
}

