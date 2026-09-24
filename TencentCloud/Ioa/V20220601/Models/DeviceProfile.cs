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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeviceProfile : AbstractModel
    {
        
        /// <summary>
        /// <p>值</p>
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// <p>属性ID(只支持32位)</p>
        /// </summary>
        [JsonProperty("FieldId")]
        public long? FieldId{ get; set; }

        /// <summary>
        /// <p>设备唯一标识码</p>
        /// </summary>
        [JsonProperty("Mid")]
        public string Mid{ get; set; }

        /// <summary>
        /// <p>名称</p>
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// <p>类型(只支持32位)</p>
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// <p>可选数据</p>
        /// </summary>
        [JsonProperty("Options")]
        public string Options{ get; set; }

        /// <summary>
        /// <p>必填数据</p>
        /// </summary>
        [JsonProperty("IsMust")]
        public string IsMust{ get; set; }

        /// <summary>
        /// <p>必填数据</p>
        /// </summary>
        [JsonProperty("IsCustom")]
        public string IsCustom{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "FieldId", this.FieldId);
            this.SetParamSimple(map, prefix + "Mid", this.Mid);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Options", this.Options);
            this.SetParamSimple(map, prefix + "IsMust", this.IsMust);
            this.SetParamSimple(map, prefix + "IsCustom", this.IsCustom);
        }
    }
}

