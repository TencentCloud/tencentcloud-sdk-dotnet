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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServerlessIndexSettingsField : AbstractModel
    {
        
        /// <summary>
        /// 索引主分片数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NumberOfShards")]
        public string NumberOfShards{ get; set; }

        /// <summary>
        /// 索引刷新频率
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RefreshInterval")]
        public string RefreshInterval{ get; set; }

        /// <summary>
        /// 自定义参数
        /// </summary>
        [JsonProperty("CustomSetting")]
        public string CustomSetting{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NumberOfShards", this.NumberOfShards);
            this.SetParamSimple(map, prefix + "RefreshInterval", this.RefreshInterval);
            this.SetParamSimple(map, prefix + "CustomSetting", this.CustomSetting);
        }
    }
}

