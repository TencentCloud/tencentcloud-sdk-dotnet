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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ObjectTypeConfigFields : AbstractModel
    {
        
        /// <summary>
        /// instanceId
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("Header")]
        public string Header{ get; set; }

        /// <summary>
        /// 字段值是否需要转译，当不需要转译时，此字段返回null
        /// </summary>
        [JsonProperty("Transfer")]
        public string Transfer{ get; set; }

        /// <summary>
        /// tke的pod字段信息解析
        /// </summary>
        [JsonProperty("JsonParse")]
        public string JsonParse{ get; set; }

        /// <summary>
        /// 字段类型 0:str 1:list
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Header", this.Header);
            this.SetParamSimple(map, prefix + "Transfer", this.Transfer);
            this.SetParamSimple(map, prefix + "JsonParse", this.JsonParse);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

