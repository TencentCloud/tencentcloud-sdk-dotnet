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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AssociateDatasourceHouseRequest : AbstractModel
    {
        
        /// <summary>
        /// 网络配置名称
        /// </summary>
        [JsonProperty("DatasourceConnectionName")]
        public string DatasourceConnectionName{ get; set; }

        /// <summary>
        /// 数据源类型
        /// </summary>
        [JsonProperty("DatasourceConnectionType")]
        public string DatasourceConnectionType{ get; set; }

        /// <summary>
        /// 数据源网络配置
        /// </summary>
        [JsonProperty("DatasourceConnectionConfig")]
        public DatasourceConnectionConfig DatasourceConnectionConfig{ get; set; }

        /// <summary>
        /// 引擎名称，只允许绑定一个引擎
        /// </summary>
        [JsonProperty("DataEngineNames")]
        public string[] DataEngineNames{ get; set; }

        /// <summary>
        /// 网络类型，2-跨源型，4-增强型
        /// </summary>
        [JsonProperty("NetworkConnectionType")]
        public long? NetworkConnectionType{ get; set; }

        /// <summary>
        /// 网络配置描述
        /// </summary>
        [JsonProperty("NetworkConnectionDesc")]
        public string NetworkConnectionDesc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DatasourceConnectionName", this.DatasourceConnectionName);
            this.SetParamSimple(map, prefix + "DatasourceConnectionType", this.DatasourceConnectionType);
            this.SetParamObj(map, prefix + "DatasourceConnectionConfig.", this.DatasourceConnectionConfig);
            this.SetParamArraySimple(map, prefix + "DataEngineNames.", this.DataEngineNames);
            this.SetParamSimple(map, prefix + "NetworkConnectionType", this.NetworkConnectionType);
            this.SetParamSimple(map, prefix + "NetworkConnectionDesc", this.NetworkConnectionDesc);
        }
    }
}

