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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SellType : AbstractModel
    {
        
        /// <summary>
        /// 售卖实例名称
        /// </summary>
        [JsonProperty("TypeName")]
        public string TypeName{ get; set; }

        /// <summary>
        /// 内核版本号
        /// </summary>
        [JsonProperty("EngineVersion")]
        public string[] EngineVersion{ get; set; }

        /// <summary>
        /// 售卖规格详细配置
        /// </summary>
        [JsonProperty("Configs")]
        public SellConfig[] Configs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TypeName", this.TypeName);
            this.SetParamArraySimple(map, prefix + "EngineVersion.", this.EngineVersion);
            this.SetParamArrayObj(map, prefix + "Configs.", this.Configs);
        }
    }
}

