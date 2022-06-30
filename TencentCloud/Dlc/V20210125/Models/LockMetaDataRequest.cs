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

    public class LockMetaDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 加锁内容
        /// </summary>
        [JsonProperty("LockComponentList")]
        public LockComponentInfo[] LockComponentList{ get; set; }

        /// <summary>
        /// 数据源名称
        /// </summary>
        [JsonProperty("DatasourceConnectionName")]
        public string DatasourceConnectionName{ get; set; }

        /// <summary>
        /// 事务id
        /// </summary>
        [JsonProperty("TxnId")]
        public long? TxnId{ get; set; }

        /// <summary>
        /// 客户端信息
        /// </summary>
        [JsonProperty("AgentInfo")]
        public string AgentInfo{ get; set; }

        /// <summary>
        /// 主机名
        /// </summary>
        [JsonProperty("Hostname")]
        public string Hostname{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "LockComponentList.", this.LockComponentList);
            this.SetParamSimple(map, prefix + "DatasourceConnectionName", this.DatasourceConnectionName);
            this.SetParamSimple(map, prefix + "TxnId", this.TxnId);
            this.SetParamSimple(map, prefix + "AgentInfo", this.AgentInfo);
            this.SetParamSimple(map, prefix + "Hostname", this.Hostname);
        }
    }
}

