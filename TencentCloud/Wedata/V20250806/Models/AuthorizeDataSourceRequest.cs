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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuthorizeDataSourceRequest : AbstractModel
    {
        
        /// <summary>
        /// 数据源ID
        /// </summary>
        [JsonProperty("DataSourceId")]
        public string DataSourceId{ get; set; }

        /// <summary>
        /// 授权给的目标项目id
        /// </summary>
        [JsonProperty("AuthProjectId")]
        public string AuthProjectId{ get; set; }

        /// <summary>
        /// 授权项目下用户列表，格式为：项目id_用户id
        /// 与AuthProjectId参数只能选填一个
        /// 当授权给多个对象时，项目id必须一致
        /// </summary>
        [JsonProperty("AuthUsers")]
        public string[] AuthUsers{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataSourceId", this.DataSourceId);
            this.SetParamSimple(map, prefix + "AuthProjectId", this.AuthProjectId);
            this.SetParamArraySimple(map, prefix + "AuthUsers.", this.AuthUsers);
        }
    }
}

