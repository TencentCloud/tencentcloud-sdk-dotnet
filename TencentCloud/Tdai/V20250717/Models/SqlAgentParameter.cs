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

namespace TencentCloud.Tdai.V20250717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SqlAgentParameter : AbstractModel
    {
        
        /// <summary>
        /// 数据库实例信息列表
        /// </summary>
        [JsonProperty("InstanceInfos")]
        public InstanceInfos[] InstanceInfos{ get; set; }

        /// <summary>
        /// 代码仓库信息
        /// </summary>
        [JsonProperty("CodeRepo")]
        public CodeRepo CodeRepo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "InstanceInfos.", this.InstanceInfos);
            this.SetParamObj(map, prefix + "CodeRepo.", this.CodeRepo);
        }
    }
}

