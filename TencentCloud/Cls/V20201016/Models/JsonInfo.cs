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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class JsonInfo : AbstractModel
    {
        
        /// <summary>
        /// 启用标志
        /// </summary>
        [JsonProperty("EnableTag")]
        public bool? EnableTag{ get; set; }

        /// <summary>
        /// 元数据信息列表, 可选值为 __SOURCE__、__FILENAME__、__TIMESTAMP__、__HOSTNAME__。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MetaFields")]
        public string[] MetaFields{ get; set; }

        /// <summary>
        /// 投递Json格式，0：字符串方式投递；1:以结构化方式投递
        /// </summary>
        [JsonProperty("JsonType")]
        public long? JsonType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableTag", this.EnableTag);
            this.SetParamArraySimple(map, prefix + "MetaFields.", this.MetaFields);
            this.SetParamSimple(map, prefix + "JsonType", this.JsonType);
        }
    }
}

