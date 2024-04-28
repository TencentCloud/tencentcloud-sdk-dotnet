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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateUserDataEngineConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 引擎ID
        /// </summary>
        [JsonProperty("DataEngineId")]
        public string DataEngineId{ get; set; }

        /// <summary>
        /// 用户自定义引擎配置项集合。该参数需要传用户需要添加的全部配置项，例如，已有配置项k1:v1，添加k2:v2，需要传[k1:v1,k2:v2]。
        /// </summary>
        [JsonProperty("DataEngineConfigPairs")]
        public DataEngineConfigPair[] DataEngineConfigPairs{ get; set; }

        /// <summary>
        /// 作业引擎资源配置模板
        /// </summary>
        [JsonProperty("SessionResourceTemplate")]
        public SessionResourceTemplate SessionResourceTemplate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataEngineId", this.DataEngineId);
            this.SetParamArrayObj(map, prefix + "DataEngineConfigPairs.", this.DataEngineConfigPairs);
            this.SetParamObj(map, prefix + "SessionResourceTemplate.", this.SessionResourceTemplate);
        }
    }
}

