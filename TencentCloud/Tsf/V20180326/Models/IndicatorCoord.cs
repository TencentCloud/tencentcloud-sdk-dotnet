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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IndicatorCoord : AbstractModel
    {
        
        /// <summary>
        /// 指标横坐标值
        /// </summary>
        [JsonProperty("CoordX")]
        public string CoordX{ get; set; }

        /// <summary>
        /// 指标纵坐标值
        /// </summary>
        [JsonProperty("CoordY")]
        public string CoordY{ get; set; }

        /// <summary>
        /// 指标标签，用于标识附加信息
        /// </summary>
        [JsonProperty("CoordTag")]
        public string CoordTag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CoordX", this.CoordX);
            this.SetParamSimple(map, prefix + "CoordY", this.CoordY);
            this.SetParamSimple(map, prefix + "CoordTag", this.CoordTag);
        }
    }
}

