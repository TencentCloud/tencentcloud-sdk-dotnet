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

namespace TencentCloud.Tci.V20190318.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExpressRatioStatistic : AbstractModel
    {
        
        /// <summary>
        /// 出现次数
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// 表情
        /// </summary>
        [JsonProperty("Express")]
        public string Express{ get; set; }

        /// <summary>
        /// 该表情时长占所有表情时长的比例
        /// </summary>
        [JsonProperty("Ratio")]
        public float? Ratio{ get; set; }

        /// <summary>
        /// 该表情时长占视频总时长的比例
        /// </summary>
        [JsonProperty("RatioUseDuration")]
        public float? RatioUseDuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "Express", this.Express);
            this.SetParamSimple(map, prefix + "Ratio", this.Ratio);
            this.SetParamSimple(map, prefix + "RatioUseDuration", this.RatioUseDuration);
        }
    }
}

