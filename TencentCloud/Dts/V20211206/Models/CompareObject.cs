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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CompareObject : AbstractModel
    {
        
        /// <summary>
        /// 对象模式 整实例-all,部分对象-partial
        /// </summary>
        [JsonProperty("ObjectMode")]
        public string ObjectMode{ get; set; }

        /// <summary>
        /// 对象列表
        /// </summary>
        [JsonProperty("ObjectItems")]
        public CompareObjectItem[] ObjectItems{ get; set; }

        /// <summary>
        /// 高级对象类型，目前只支持mongodb链路。如index(索引),shardkey(片键),schema(库表)
        /// </summary>
        [JsonProperty("AdvancedObjects")]
        public string[] AdvancedObjects{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ObjectMode", this.ObjectMode);
            this.SetParamArrayObj(map, prefix + "ObjectItems.", this.ObjectItems);
            this.SetParamArraySimple(map, prefix + "AdvancedObjects.", this.AdvancedObjects);
        }
    }
}

