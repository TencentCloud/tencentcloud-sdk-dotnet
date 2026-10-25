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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LocationUpdate : AbstractModel
    {
        
        /// <summary>
        /// 更新类型，取值：modify_location_name、modify_location_comment、modify_location_properties
        /// </summary>
        [JsonProperty("UpdateType")]
        public string UpdateType{ get; set; }

        /// <summary>
        /// 新的备注，可选，UpdateType 为 modify_location_comment 时使用
        /// </summary>
        [JsonProperty("NewComment")]
        public string NewComment{ get; set; }

        /// <summary>
        /// 新增/修改的属性键值对列表，可选，UpdateType 为 modify_location_properties 时使用
        /// </summary>
        [JsonProperty("SetProperties")]
        public KVPair[] SetProperties{ get; set; }

        /// <summary>
        /// 要移除的属性key列表，可选，UpdateType 为 modify_location_properties 时使用
        /// </summary>
        [JsonProperty("RemoveProperties")]
        public string[] RemoveProperties{ get; set; }

        /// <summary>
        /// 新的名称，可选，UpdateType 为 modify_location_name 时使用
        /// </summary>
        [JsonProperty("NewName")]
        public string NewName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UpdateType", this.UpdateType);
            this.SetParamSimple(map, prefix + "NewComment", this.NewComment);
            this.SetParamArrayObj(map, prefix + "SetProperties.", this.SetProperties);
            this.SetParamArraySimple(map, prefix + "RemoveProperties.", this.RemoveProperties);
            this.SetParamSimple(map, prefix + "NewName", this.NewName);
        }
    }
}

