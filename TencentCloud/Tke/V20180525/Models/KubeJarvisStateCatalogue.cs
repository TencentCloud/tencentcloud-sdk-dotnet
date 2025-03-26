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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KubeJarvisStateCatalogue : AbstractModel
    {
        
        /// <summary>
        /// 目录级别，支持参数：
        /// first：一级目录
        /// second：二级目录
        /// </summary>
        [JsonProperty("CatalogueLevel")]
        public string CatalogueLevel{ get; set; }

        /// <summary>
        /// 目录名
        /// </summary>
        [JsonProperty("CatalogueName")]
        public string CatalogueName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CatalogueLevel", this.CatalogueLevel);
            this.SetParamSimple(map, prefix + "CatalogueName", this.CatalogueName);
        }
    }
}

