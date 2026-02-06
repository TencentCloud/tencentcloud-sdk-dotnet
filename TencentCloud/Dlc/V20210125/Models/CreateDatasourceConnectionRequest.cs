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

    public class CreateDatasourceConnectionRequest : AbstractModel
    {
        
        /// <summary>
        /// 数据连接名称
        /// </summary>
        [JsonProperty("DatasourceConnectionName")]
        public string DatasourceConnectionName{ get; set; }

        /// <summary>
        /// 数据连接类型
        /// </summary>
        [JsonProperty("DatasourceConnectionType")]
        public string DatasourceConnectionType{ get; set; }

        /// <summary>
        /// 数据连接属性
        /// </summary>
        [JsonProperty("DatasourceConnectionConfig")]
        public DatasourceConnectionConfig DatasourceConnectionConfig{ get; set; }

        /// <summary>
        /// 数据连接所属服务
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// 数据连接描述
        /// </summary>
        [JsonProperty("DatasourceConnectionDesc")]
        public string DatasourceConnectionDesc{ get; set; }

        /// <summary>
        /// 数据引擎名称数组
        /// </summary>
        [JsonProperty("DataEngineNames")]
        public string[] DataEngineNames{ get; set; }

        /// <summary>
        /// 网络连接名称
        /// </summary>
        [JsonProperty("NetworkConnectionName")]
        public string NetworkConnectionName{ get; set; }

        /// <summary>
        /// 网络连接描述
        /// </summary>
        [JsonProperty("NetworkConnectionDesc")]
        public string NetworkConnectionDesc{ get; set; }

        /// <summary>
        /// 网络连接类型 （2-夸源型，4-增强型）
        /// </summary>
        [JsonProperty("NetworkConnectionType")]
        public long? NetworkConnectionType{ get; set; }

        /// <summary>
        /// 自定义配置
        /// </summary>
        [JsonProperty("CustomConfig")]
        public CustomConfig[] CustomConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DatasourceConnectionName", this.DatasourceConnectionName);
            this.SetParamSimple(map, prefix + "DatasourceConnectionType", this.DatasourceConnectionType);
            this.SetParamObj(map, prefix + "DatasourceConnectionConfig.", this.DatasourceConnectionConfig);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "DatasourceConnectionDesc", this.DatasourceConnectionDesc);
            this.SetParamArraySimple(map, prefix + "DataEngineNames.", this.DataEngineNames);
            this.SetParamSimple(map, prefix + "NetworkConnectionName", this.NetworkConnectionName);
            this.SetParamSimple(map, prefix + "NetworkConnectionDesc", this.NetworkConnectionDesc);
            this.SetParamSimple(map, prefix + "NetworkConnectionType", this.NetworkConnectionType);
            this.SetParamArrayObj(map, prefix + "CustomConfig.", this.CustomConfig);
        }
    }
}

