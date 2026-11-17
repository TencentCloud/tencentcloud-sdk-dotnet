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

namespace TencentCloud.Dbs.V20211108.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourceItemDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>当前存储状态。可能的取值为："standard" - 标准存储；"lowFrequency" - 低频存储；"archive" - 归档存储；"deepArchive" - 深度归档存储；</p>
        /// </summary>
        [JsonProperty("TieredType")]
        public string TieredType{ get; set; }

        /// <summary>
        /// <p>存储时长。备份集已保留的时长，单位为小时。</p>
        /// </summary>
        [JsonProperty("StayTime")]
        public float? StayTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TieredType", this.TieredType);
            this.SetParamSimple(map, prefix + "StayTime", this.StayTime);
        }
    }
}

