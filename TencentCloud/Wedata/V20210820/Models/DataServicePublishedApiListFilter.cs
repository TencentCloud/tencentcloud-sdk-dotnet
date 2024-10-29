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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataServicePublishedApiListFilter : AbstractModel
    {
        
        /// <summary>
        /// 请求路径关键词筛选
        /// </summary>
        [JsonProperty("PathUrl")]
        public string PathUrl{ get; set; }

        /// <summary>
        /// Api名称关键词筛选
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// Api认证方式筛选 0:免认证 1:应用认证
        /// </summary>
        [JsonProperty("AuthTypes")]
        public ulong?[] AuthTypes{ get; set; }

        /// <summary>
        /// 服务Api状态 1:已上线  3:已下线
        /// </summary>
        [JsonProperty("ApiStatus")]
        public ulong?[] ApiStatus{ get; set; }

        /// <summary>
        /// API配置方式 0:向导、1、脚本、2、注册Api
        /// </summary>
        [JsonProperty("ConfigTypes")]
        public ulong?[] ConfigTypes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PathUrl", this.PathUrl);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamArraySimple(map, prefix + "AuthTypes.", this.AuthTypes);
            this.SetParamArraySimple(map, prefix + "ApiStatus.", this.ApiStatus);
            this.SetParamArraySimple(map, prefix + "ConfigTypes.", this.ConfigTypes);
        }
    }
}

